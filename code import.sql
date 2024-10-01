EXEC sp_configure 'show advanced options', 1;
RECONFIGURE;
EXEC sp_configure 'Ad Hoc Distributed Queries', 1;
RECONFIGURE;
USE QuanLyTraSuaDB2
SELECT * 
INTO thunghiem_import02
FROM OPENROWSET('Microsoft.ACE.OLEDB.12.0',
                'Excel 12.0;Database=D:\chua file xlsx\KHACH.xlsx;HDR=YES',
                'SELECT * FROM [KHACH$]');


