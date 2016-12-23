alter table Objet add constraint FKsousmission_FK
     foreign key (Id_Annonce)
     references Annonce;