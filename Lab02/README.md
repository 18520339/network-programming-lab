# Bài thực hành 2

**1. Ghi và Đọc file**

-   Viết chương trình đọc nội dung một file “input.txt” và xuất ra màn hình nội dung của file. Sau đó ghi nội dung (chuyển toàn bộ ký tự sang kiểu in hoa) xuống file “output.txt”.

**2. Đọc thông tin một file .txt**

-   Viết chương trình đọc file và hiển thị các thông tin sau:
    -   Tên file
    -   Đường dẫn
    -   Số dòng, số từ, số ký tự
    -   Hiển thị nội dung của file

**3. Đọc và Ghi file**

-   Đọc nội dung từ file “input.txt” với nội dung theo định dạng, sau đó thực hiện các phép tính và ghi kết quả xuống file “output.txt”.
-   Ví dụ:

<table>
    <tr>
        <th>input.txt</th>
        <th>output.txt</th>
    </tr>
    <tr>
        <td>1 +2</td>
        <td>1 +2 = 3</td>
    </tr>
    <tr>
        <td>12 –7</td>
        <td>12 –7 = 5</td>
    </tr>
    <tr>
        <td>10 *20</td>
        <td>10 *20 = 200</td>
    </tr>
    <tr>
        <td>200 /10</td>
        <td>200 /10 = 20</td>
    </tr>
</table>

**4. Đọc và Ghi file sử dụng BinaryFormatter**

-   Viết chương trình cho phép quản lý danh sách Học Viên. Thông tin các học viên sẽ được lưu trữ tại file nhị phân “hocvien.txt”.
-   Chương trình có 2 chức năng chính:
    -   Lưu thông tin học viên: Thực hiện kiểm tra tính hợp lệ của dữ liệu người dùng điền vào, sau đó lưu thông tin vào file “hocvien.txt” (cho phép lưu nhiều học viên). Sử dụng phương thức Serialize của BinaryFormatter để chuyển đổi định dạng dữ liệu trước khi ghi xuống.
    -   Hiển thị danh sách học viên: Đọc toàn bộ danh sách các học viên từ file “hocvien.txt”, sử dụng phương thức Deserialize của BinaryFormatter để chuyển dữ liệu về dạng đối tượng ban đầu và hiển thị các dữ liệu tính điểm trung bình của học viên đó.
