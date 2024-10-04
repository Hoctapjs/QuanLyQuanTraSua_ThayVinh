INSERT INTO OPENROWSET('Microsoft.ACE.OLEDB.12.0',
                       'Excel 12.0;Database=D:\chua file xlsx\trong.xlsx;',
                       'SELECT * FROM [Sheet1$]')
SELECT * FROM [thunghiem_import01];


use thunghiem_import

select * from thunghiem_import01

SELECT *
INTO [Excel 12.0;Database=C:\duongdan\tenfile.xlsx;HDR=YES].[Sheet1$]
FROM thunghiem_import01;


EXEC sp_configure 'show advanced options', 1;
RECONFIGURE;
EXEC sp_configure 'Ad Hoc Distributed Queries', 1;
RECONFIGURE;
INSERT INTO OPENROWSET('Microsoft.ACE.OLEDB.12.0', 
    'Excel 12.0;Database=D:\chua file xlsx\trong.xlsx;HDR=YES',
    'SELECT * FROM [Sheet1$]')
SELECT * FROM thunghiem_import01;
