GO
USE QUANLYSTCOOPFOOD
SET DATEFORMAT DMY;

-------------------------------------------------KHACHHANG
GO
INSERT INTO [KHACHHANG] VALUES(N'KH00',N'NGUYỄN VĂN', N'GIÁP',N'0864611705',N'486, Đ.Phan Bội Châu, P.Phú Cường, TP.Thủ Dầu Một, Tỉnh Bình Dương',875)

-------------------------------------------------NHANVIEN

GO
INSERT INTO [NHANVIEN] VALUES(N'NV00',N'NGUYỄN THỊ NHƯ',N'QUỲNH',N'22/08/1998',N'NỮ',N'332, Đ.Nguyễn Du, P.Phú Hòa, TP.Thủ Dầu Một, Tỉnh Bình Dương',N'0921378908',N'384738685')

-------------------------------------------------NHACUNGCAP
GO
INSERT INTO [NHACUNGCAP] VALUES(N'NCC00',N'Bích Chi Food - Công Ty Cổ Phần Thực Phẩm Bích Chi',N'45X1, Đường Nguyễn Sinh Sắc, Phường 2, Sa Đéc, Đồng Tháp',N'02773861910',N'thaipham@bichchi.com.vn')

-------------------------------------------------SANPHAM
GO
INSERT INTO [HANGHOA] VALUES(N'HH00',N'NCC00',N'Bít tết đùi bò Úc mát Pacow vỉ 250g',N'THITCACLOAI',231,118000,'27/06/2022','13/08/2022')

-------------------------------------------------HOADON VÀ HDCHITIET
GO
INSERT INTO [HOADON] VALUES(N'HD00','22/07/2022', N'TIỀN MẶT', N'NV00', N'KH00', 9132000)
GO
INSERT INTO [HDCHITIET] VALUES(N'HD00',N'HH00', 2)

select*
from nhanvien