INSERT INTO OPENROWSET('Microsoft.ACE.OLEDB.12.0',
                       'Excel 12.0;Database=C:\duongdan\tenfile.xlsx;',
                       'SELECT * FROM [Sheet1$]')
SELECT * FROM [thunghiem_import01];

select * from thunghiem_import01
