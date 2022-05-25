create database gestion_des_commandes
use gestion_des_commandes

create table client 
(
 numc int primary key,
 nomc varchar(10),
 adresse varchar(10),
 ville varchar(10),
)

create table facture
( 
 numfac int primary key,
 date_facture date ,
 client int references client(numc)
)

create table fournisseur 
(numf int primary key,
 nomf varchar(10),
 ville varchar(10)
 )

create table produit 
(nump int primary key ,
descriptionP varchar(10),
prixht float ,
couleur varchar(10),
fournisseur int references fournisseur(numf)
)

create table contenu
(facture int references facture(numfac),
produit int references produit (nump),
primary key (facture,produit),
quantite int )
/*les insertions*/

insert into client values(1,'sabiri','maarif','casa'),(2,'fikri','manal','rabat'),(3,'afif','mahdia','kenitra')

insert into fournisseur  values(1,'Bois Maroc','casa'),(2,'DELL','rabat'),(3,'Philips','tanger')

insert into produit values(1,'Pc XPS',20000,'noir',2),(2,'table',1500,'white',1),(3,'TV 65in',38000,'blue',3)

insert into facture values(1,'12-02-2021',3),(2,'12-12-2021',2)
insert into facture values(3,'10-05-2019',1)

insert into contenu values(1,2,5),(1,1,5),(2,3,2),(2,2,1)
insert into contenu values(3,1,10)
drop table contenu
drop table produit 
drop table fournisseur
drop table facture
drop table client


/*procédure stocké d'insertion d'un facture*/

create proc ps_add_cmd @numf int,@datef date,@client int
as 
begin
if exists(select * from facture where numfac=@numf)
return 1
else
insert into facture values( @numf,@datef,@client)
end

declare @ret int
exec @ret=ps_add_cmd 4,'11-11-2020',3
print(@ret)


select * from contenu
select * from produit
select * from client
select * from facture








/*trigger de la suppression d'une facture*/
go
create trigger trg_DeleteFacture
on facture
instead of delete
as 
begin
declare @commande int
select @commande=numfac from deleted
if exists(select * from contenu where facture=@commande)
begin
   delete from contenu where facture=@commande
   delete from facture where numfac=@commande
end
else
begin
   delete from facture where numfac=@commande
end
end













/*teste des requetes*/
/*totale*/
select sum((prixht*qunatite)*1.2) 
from produit 
join contenu
on produit=nump 
where facture=1

/*ttc*/

select sum(prixht*qunatite) 
from produit 
join contenu
on nump=produit 
where facture=1

/*tva*/
select sum((prixht*qunatite)*0.2)
from produit 
join contenu  
on nump=produit 
where facture=1


/*CA*/

select sum(prixht*qunatite) 
from produit 
join contenu 
on produit=nump 
join facture  
on facture=numfac
where client=


