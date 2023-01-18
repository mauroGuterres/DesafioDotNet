use [Khipo]
go
CREATE PROCEDURE GetProdutoById
    @Id INT
AS
BEGIN
    SELECT Id, CreatedAt, Name, Price, Brand, UpdatedAt
    FROM Produto
    WHERE Id = @Id
END
