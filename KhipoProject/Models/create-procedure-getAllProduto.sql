use [Khipo]
go
CREATE PROCEDURE GetAllProduto
AS
BEGIN
    SELECT Id, CreatedAt, Name, Price, Brand, UpdatedAt
    FROM Produto
END
