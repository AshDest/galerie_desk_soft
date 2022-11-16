create database db_galerie
use db_galerie

create table tTypeProduit
(
	Id integer identity(1,1) primary key,
	Designation varchar(25)
)
GO
create table tCategorie
(
	Id integer identity(1,1) primary key,
	Designation varchar(20)
)
GO

create table tProduit
(
	Id integer identity(1,1),
	Code varchar(100) primary key,
	Designation varchar(20) not null,
	TypeProduit integer not null,
	CategorieProduit integer not null,
	Qte_stock integer default(0),
	Prix float not null,
	Constraint fk_type foreign key (TypeProduit) references tTypeProduit(Id),
	Constraint fk_categorie foreign key (CategorieProduit) references tCategorie(Id)
)
GO
create table tVente
(
	Code varchar(100) primary key,
	DateVente Datetime,
	Nom_Client varchar(20) null,
	Num_Client varchar(14) null,
	Total float default(0),
	TotalPaie float default(0),
	RestePaie float default(0),
	Situation integer default(0) --pour determiner si une vente est en cache ou credit 
)
GO
create table tDetailVente
(
	Id integer identity(1,1) primary key,
	CodeVente varchar(100) not null,
	Produit varchar(100) not null,
	Quantite integer default(0),
	Pu float default(0),
	Pt float default(0),
	Constraint fk_prod foreign key (Produit) references tProduit(Code),
	Constraint fk_vent foreign key (CodeVente) references tVente(Code)
)
GO
create table tRestePaie
(
	Id integer identity(1,1) primary key,
	CodeVente varchar(100) not null,
	Montat_Rest float default(0),
	DateVente DateTime,
	Situation varchar(10),
	Constraint fk_v foreign key (CodeVente) references tVente(Code)
)
GO
create table tPaiement
(
	Code varchar(100) primary key,
	CodeVente varchar(100) not null,
	Montant_Paie float default(0),
	DatePaie Datetime,
	Constraint fk_paie foreign key (CodeVente) references tVente(Code)
)
GO

create table tApprovisionnement
(
	Code varchar(100) primary key,
	DateApprov Date,
	Produit varchar(100) not null,
	Qte integer,
	Pu float,
	Pt float,
	Constraint fk_pro foreign key (Produit) references tProduit(Code)
)

GO

create table Users
(
	Id integer identity(1,1) primary key,
	Name varchar(20),
	Username varchar(20) unique,
	Pwd varchar(255)
)