alter table Offre add constraint FKAnn_Off_FK
     foreign key (Id_Annonce)
     references Annonce;