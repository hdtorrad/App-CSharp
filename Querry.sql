-- SQLite
DROP TABLE IF EXISTS CLiente;
DROP TABLE IF EXISTS Venda;

CREATE TABLE Cliente(
    id int NOT NULL PRIMARY KEY,
    nome varchar(255) NOT NULL,
    cpf varchar(11) NOT NULL,
    rg varchar(9) NOT NULL,
    endereco varchar(255) NOT NULL
);

CREATE TABLE Venda(
    VendaId int NOT NULL PRIMARY KEY,
    pedidoID int NOT NULL,
    clienteID int NOT NULL,
    dataVenda DATE NOT NULL,
    desconto decimal(10,2) NOT NULL,
    valorBruto decimal(10,2) NOT NULL
);
