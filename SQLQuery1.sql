GO
INSERT [dbo].[Footwear] ([FootwearID], [FootwearCetogory], [FootwearType], [FootwearBrand], [Price]) VALUES (1, N'Men', N'Shoes', N'Nike', 10000)
GO
INSERT [dbo].[Footwear] ([FootwearID], [FootwearCetogory], [FootwearType], [FootwearBrand], [Price]) VALUES (2, N'Men', N'Slippers', N'Wawes', 2500)
GO
INSERT [dbo].[Footwear] ([FootwearID], [FootwearCetogory], [FootwearType], [FootwearBrand], [Price]) VALUES (3, N'Men', N'Sandles', N'Paragon', 5000)
GO
INSERT [dbo].[Footwear] ([FootwearID], [FootwearCetogory], [FootwearType], [FootwearBrand], [Price]) VALUES (4, N'Women', N'Shoes', N'Nike', 8000)
GO
INSERT [dbo].[Footwear] ([FootwearID], [FootwearCetogory], [FootwearType], [FootwearBrand], [Price]) VALUES (5, N'Women', N'Slippers', N'Wawes', 2500)
GO
INSERT [dbo].[Footwear] ([FootwearID], [FootwearCetogory], [FootwearType], [FootwearBrand], [Price]) VALUES (6, N'Women', N'Heels', N'Paragon', 10000)
GO
SET IDENTITY_INSERT [dbo].[Footwear] OFF
GO

truncate table Footwear.[dbo].[Footwear]


select * from Footwear