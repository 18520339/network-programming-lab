# Bài thực hành 3

**1. UDP Application**

-   Viết ứng dụng thực hiện gởi và nhận dữ liệu giữa hai bên sử dụng giao thức UDP (UDP Client và UDP Server). Người dùng ở Client sẽ chỉ định IP, port cần kết nối và thông điệp gửi đến Server. Tại Server sẽ nhận được thông điệp gửi từ Client.

**2. TCP Application**

-   Viết chương trình lắng nghe dữ liệu từ dịch vụ Telnet sử dụng kết nối TCP (sử dụng lớp
    Socket) với mô tả như sau: - Chạy chương trình - Nhấn nút Listen - Mở CMD gõ lệnh: `telnet <IP của máy> 8080` hoặc sử dụng chương trình **Putty**. - Vào màn hình telnet, gõ thông điệp tùy ý, chương trình sẽ nhận và hiện dữ liệu lên Form.

**3. Server – 1 Client**

-   Viết ứng dụng thực hiện gửi và nhận dữ liệu sử dụng giao thức TCP (TCP Client và TCP Listener). Server lắng nghe kết nối và thông điệp từ Client.
    -   Chạy Server
    -   Nhấn nút Listen
    -   Khởi tạo Client
    -   Gửi thông điệp từ Client đến Server
    -   Server nhận thông điệp và hiện lên form.
