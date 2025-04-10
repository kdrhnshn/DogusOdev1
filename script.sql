
CREATE DATABASE PaymentDb;
GO


USE PaymentDb;
GO


CREATE TABLE PaymentTypes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    DisplayName NVARCHAR(100),
    ClassName NVARCHAR(100)
);
GO


INSERT INTO PaymentTypes (DisplayName, ClassName) VALUES
('Nakit Ödeme', 'CashPayment'),
('Kredi Kartı', 'CardPayment'),
('Havale', 'BankTransfer');
GO
