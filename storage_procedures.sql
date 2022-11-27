use db_galerie
GO
create procedure sp_merge_typeProduit
(
	@designation VARCHAR(20),
	@action integer
)
as
	declare @id integer;
	select @id = Id from tTypeProduit where Designation = @designation;
if(@action = 1)
begin
	if not exists (select * from tTypeProduit where Designation = @designation)
		insert into tTypeProduit (Designation) values (@designation)
	else update tTypeProduit set Designation = @designation where Id = @id
end
else if(@action = 2)
begin
	delete from tTypeProduit where Id = @id
end
go
create procedure sp_merge_categorieProduit
(
	@designation VARCHAR(20),
	@action integer
)
as
	declare @id integer;
	select @id = Id from tCategorie where Designation = @designation;
if(@action = 1)
begin
	if not exists (select * from tCategorie where Designation = @designation)
		insert into tCategorie (Designation) values (@designation)
	else update tCategorie set Designation = @designation where Id = @id
end
else if(@action = 2)
begin
	delete from tCategorie where Id = @id
end
go

create procedure sp_merge_produit
(
	@code varchar(100),
	@designation VARCHAR(20),
	@typeproduit integer,
	@depot integer,
	@prix float,
	@action integer
)
as
	declare @id integer;
	select @id = Id from tProduit where Designation = @designation and Code = @code;
if(@action = 1)
begin
	if not exists (select * from tProduit where Id = @id)
		insert into tProduit (Code, Designation, TypeProduit, Depot, Prix) values (@code, @designation, @typeproduit, @depot, @prix)
	else update tProduit set Designation = @designation, TypeProduit = @typeproduit, Depot = @depot, Prix = @prix where Id = @id
end
else if(@action = 2)
begin
	delete from tProduit where Id = @id
end
go

create procedure sp_merge_vente
(
	@code varchar(100),
	@nomclient varchar(20),
	@numclient varchar(15),
	@produit varchar(100),
	@quantite integer,
	--@prix float,
	@totalpaie float,
	@situation integer,
	@depot integer,
	@action integer
)
as
	declare @current_code varchar(100);
	declare @current_total int;
	declare @current_pu float;
	declare @current_qte integer;
	declare @Id_Detail integer;
	declare @current_qte_vente integer;
	select @current_code = Code from tVente where Code = @code;
	select @current_total = Sum(Pt) from tDetailVente where CodeVente = @code;
	select @Id_Detail = Id from tDetailVente where Produit = @produit;
	select @current_pu = Prix from tProduit where Code = @produit;
	select @current_qte = Qte_stock from tProduit where Code = @produit;
	select @current_qte_vente = Quantite from tDetailVente where Id = @Id_Detail
if(@action = 1) -- Insert and update vente
begin
	if not exists (select * from tVente where Code = @code)
		insert into tVente(Code, DateVente, Depot) values (@code, GETDATE(), @depot)
end
else if(@action = 2) -- insert detailvente
begin
	if not exists (select * from tDetailVente where Produit = @produit and CodeVente = @current_code)
		insert into tDetailVente (CodeVente, Produit, Quantite, Pu, Pt) values (@current_code, @produit, @quantite, @current_pu, (@quantite * @current_pu));
	update tVente set Total = (select Sum(Pt) from tDetailVente where CodeVente= @current_code) where Code = @current_code

	update tProduit set Qte_stock = @current_qte - @quantite where Code = @produit
end
else if(@action = 3) -- update detail vente
begin
	update tDetailVente set Produit = @produit, Quantite = @quantite, Pu = @current_pu, Pt = (@quantite * @current_pu);

	update tVente set Total = (select Sum(Pt) from tDetailVente where CodeVente= @current_code) where Code = @current_code

	update tProduit set Qte_stock = (@current_qte + @current_qte_vente) - @quantite where Code = @produit
end
else if(@action = 4) -- set total price on tVente
begin
	update tVente set Nom_Client = @nomclient, Num_Client = @numclient, Total = (select Sum(Pt) from tDetailVente where CodeVente= @current_code), 
	TotalPaie = @totalpaie, RestePaie = (Total - (select Sum(Pt) from tDetailVente where CodeVente= @current_code)), Situation = @situation where Code = @current_code
end
else if(@action = 5 and @situation = 1)
begin
	update tVente set TotalPaie = @totalpaie, RestePaie = (Total - @totalpaie) where Code = @current_code
end
go

create procedure sp_merge_paiement
(
	@codevente VARCHAR(100),
	@montant float,
	@action integer
)
as
	declare @current_vente integer;
	declare @current_rest float;
	select @current_vente = Code from tVente where Code = @codevente;
	select @current_rest = RestePaie from tVente where Code = @codevente;

if(@action = 1)
begin
	insert into tPaiement (CodeVente, Montant_Paie, DatePaie) values (@current_vente, @montant, GETDATE())
	update tVente set RestePaie = (@current_rest - @montant) where Code = @current_vente;
end
go

create procedure sp_merge_approvisionnemen
(
	@code varchar(100),
	@produit VARCHAR(100),
	@quantite integer,
	@prix float,
	@depot integer,
	@action integer
)
as
	declare @current_code varchar(100);
	declare @current_qte integer;
	declare @current_produit varchar(100);
	select @current_produit = Code from tProduit where Code = @produit;
	select @current_qte = Qte_stock from tProduit where Code = @produit;
	select @current_code = Code from tApprovisionnement where Code = @code;

if(@action = 1)
begin
	if not exists (select * from tApprovisionnement where Code = @current_code)
		insert into tApprovisionnement (Code, DateApprov, Produit, Qte, Pu, Pt, Depot) values 
		(@code, GETDATE(), @current_produit, @quantite, @prix, (@quantite * @prix), @depot)
	else update tApprovisionnement set Produit = @produit, Qte = @quantite, Pu=@prix, 
	Pt = (@quantite * @prix), Depot = @depot where Code = @current_code

	update tProduit set Qte_stock = (@current_qte + @quantite) where Code = @current_produit;
end
go


