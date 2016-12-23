alter table Annonce add constraint FKproposistion_FK
     foreign key (Id_Utilisateur)
     references Utilisateur;

alter table Annonce add constraint FKclassement_FK
     foreign key (Id_Sous_Categorie)
     references Categorie;
