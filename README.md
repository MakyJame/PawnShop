
System build with NET 8, WinForms, C#, SQL Server, Entity Framework (Database

# 🛠️ Pawnshop Management System – Backup Hướng Dẫn

Đây là hướng dẫn chi tiết giúp bạn sao lưu (backup) dữ liệu cho hệ thống Pawnshop. Việc sao lưu giúp bạn bảo toàn dữ liệu trong trường hợp hệ thống gặp sự cố.

---

## 📂 Thư mục backup
> Vị trí đề xuất lưu file backup:
---

## ✅ Trường hợp 1: Khi CÓ SQL Server Management Studio (SSMS)

1. Mở **SQL Server Management Studio (SSMS)**.
2. Kết nối đến SQL Server instance của bạn.
3. Trong `Object Explorer`, tìm đến database **PawnShopDB**.
4. Nhấp chuột phải vào database → **Tasks** → **Back Up...**.
5. Trong cửa sổ Backup Database:
    - Chọn **Backup type**: `Full`
    - Phần **Destination**:
        - Nhấn **Remove** để xóa các đường dẫn cũ (nếu có).
        - Nhấn **Add...** để chọn đường dẫn lưu mới, ví dụ:
        ```
        C:\Users\<YourUser>\Documents\DraftAboutReserveEngineer.bak
        ```
6. Nhấn **OK** để bắt đầu backup.
7. Nếu thành công, sẽ có thông báo:  
   `"The backup of database 'PawnShopDB' completed successfully."`

---

## 🚫 Trường hợp 2: KHÔNG có SSMS

### 🧩 Cách 1: Dùng `sqlcmd` trong Command Prompt

1. Mở **Command Prompt** bằng quyền Admin.
2. Chạy lệnh sau:

```bash
sqlcmd -S . -E -Q "BACKUP DATABASE [PawnShopDB] TO DISK='C:\Users\<YourUser>\Documents\DraftAboutReserveEngineer.bak'"
