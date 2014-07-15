--------------------- Tabela Categoria

CREATE TABLE Categoria(
	Id int not null,
	Descricao varchar(25),
	primary key(Id)
)

--------------------- Insercao tabela Categoria

INSERT INTO Categoria (Id,Descricao) VALUES (1,'Processo Civil')
INSERT INTO Categoria (Id,Descricao) VALUES (2,'Processo Penal')
INSERT INTO Categoria (Id,Descricao) VALUES (3,'Processo Trabalhista')

--------------------- Tabela Interessado

CREATE TABLE Interessado(
	Id int not null,
	Nome varchar(100) not null,
	Cpf numeric(11) not null unique,
	Contatos varchar(100),
	Endereco text,
	primary key(Id)
)

--------------------- Tabela Processo
CREATE TABLE Processo(
	Numero varchar(10) not null unique,
	Categoria int not null,
	Interessado int not null,
	Data_Julgamento datetime,
	Valor_Acao numeric not null,
	Descricao text,
	primary key (Numero),
	foreign key (Categoria) references Categoria (Id),
	foreign key (Interessado) references Interessado (Id)
)

