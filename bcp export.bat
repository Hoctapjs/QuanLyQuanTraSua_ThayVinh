:: Thiết lập thông tin kết nối và bảng xuất dữ liệu
set BCP_EXPORT_SERVER=LAPTOP-2IRIHD28\SQLSEVER2012
set BCP_EXPORT_DB=QuanLyTraSuaDB2
set BCP_EXPORT_TABLE=NHANVIEN

:: Xuất tên cột từ bảng trong SQL Server ra file CSV
BCP "DECLARE @colnames VARCHAR(max); 
SELECT @colnames = COALESCE(@colnames + ',', '') + COLUMN_NAME 
FROM %BCP_EXPORT_DB%.INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME='%BCP_EXPORT_TABLE%'; 
SELECT @colnames;" queryout NHANVIEN.csv -c -t, -T -S%BCP_EXPORT_SERVER% -C 65001

:: Xuất dữ liệu từ bảng trong SQL Server ra file CSV thứ hai (với dấu phân cách là dấu phẩy)
BCP "%BCP_EXPORT_DB%.dbo.%BCP_EXPORT_TABLE%" out NHANVIEN2.csv -c -t, -T -S%BCP_EXPORT_SERVER% -C 65001

:: Kiểm tra và tạo file TableData.csv, sau đó thêm tiêu đề cột từ NHANVIEN.csv
(
    if not exist TableData.csv (
        echo. > TableData.csv
    )
    type NHANVIEN.csv
    type NHANVIEN2.csv
) > TableData.csv

:: Xóa các file tạm sau khi gộp xong
del NHANVIEN.csv
del NHANVIEN2.csv
