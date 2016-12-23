alter table Categorie add constraint FKappartenance_FK
     foreign key (Sous_categorie)
     references Categorie;
