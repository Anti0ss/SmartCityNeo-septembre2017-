alter table Demande add constraint FKAnn_Dem_FK
     foreign key (Id_Annonce)
     references Annonce;
