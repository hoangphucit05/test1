# Khắc phục lỗi Application Control chặn `ChaoHoiApp.dll`

## Lỗi

Khi chạy ứng dụng, Windows báo:

```text
System.IO.FileLoadException
Could not load file or assembly '...\ChaoHoiApp.dll'.
An Application Control policy has blocked this file. (0x800711C7)
```

## Nguyên nhân

Đây là thông báo Windows không cho phép nạp DLL theo chính sách kiểm soát ứng dụng trên máy. Chính sách có thể do tổ chức quản lý cấu hình, hoặc do tính năng bảo vệ ứng dụng trên Windows. Đây không phải thông báo cho thấy lỗi cú pháp hay lỗi logic trong `Program.cs`; đổi mã nguồn hoặc cài lại .NET thường không gỡ được quy tắc chặn.

## Cách xử lý an toàn

1. **Đóng ứng dụng và dừng phiên debug** trong Visual Studio/VS Code. Không thể ghi đè một số tệp đầu ra khi tiến trình vẫn đang chạy.
2. Tại thư mục chứa `ChaoHoiApp.slnx`, chạy:

   ```powershell
   dotnet clean .\ChaoHoiApp.slnx
   dotnet build .\ChaoHoiApp.slnx
   ```

3. Nếu build thành công nhưng chạy vẫn bị chặn, hãy liên hệ quản trị viên IT (nếu máy thuộc trường học/công ty). Cung cấp thông báo lỗi, đường dẫn DLL và thời điểm lỗi để họ kiểm tra quy tắc Application Control và nhật ký Windows.
4. Quản trị viên có thể kiểm tra **Event Viewer** tại:
   - `Applications and Services Logs > Microsoft > Windows > CodeIntegrity > Operational`
   - `Applications and Services Logs > Microsoft > Windows > AppLocker` (nếu AppLocker được dùng)
5. Nếu đây là máy cá nhân, kiểm tra ứng dụng bảo mật/chính sách Windows đang quản lý máy. Chỉ cho phép chương trình sau khi xác minh nguồn mã và tệp build là đáng tin cậy; nhờ quản trị viên cấu hình ngoại lệ hoặc chính sách cho phép theo cách được tổ chức phê duyệt.

## Lưu ý bảo mật

Không tắt Application Control, không đổi tên hoặc chuyển tệp sang thư mục khác để lách quy tắc, và không tải DLL thay thế từ nguồn không rõ. Nếu chính sách đang chặn nhầm chương trình hợp lệ, hãy nhờ người có quyền quản trị xem nhật ký và điều chỉnh chính sách phù hợp.

## Kết quả kiểm tra dự án

Dự án dùng .NET 10 và có SDK `10.0.401` trên máy. Lệnh build kiểm tra đã không hoàn tất vì `ChaoHoiApp.exe` đang được tiến trình `ChaoHoiApp` (PID `6736`) sử dụng. Hãy đóng ứng dụng/phiên debug rồi chạy lại hai lệnh ở trên. Việc build thành công cũng không tự gỡ được chính sách Windows nếu DLL tiếp tục bị chặn khi chạy.
