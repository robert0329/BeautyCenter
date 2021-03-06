create table Citas (
CitaId int identity(1, 1)not null primary key,
Nombres   varchar(50),
ClienteId  int,
Servicio  varchar (100) ,
CantPersonas int ,
Fecha datetime
);

create table Ciudades (
CiudadId   int identity(1, 1)not null primary key,
NombreCiudad varchar(100),
);

create table Provincias (
ProvinviaId int identity(1,1)not null primary key,
CiudadId int,
NombreProv varchar(100),
);

create table Clientes (
ClienteId int identity(1, 1)not null primary key,
Nombres   varchar(150),
Provincia varchar(100),
Ciudad    varchar(100),
Direccion varchar(300),
Cedula  varchar(25) ,
Telefono varchar(15) ,
FechaNac datetime
);

create table Empleados(
EmpleadoId int identity(1, 1)not null primary key,
Nombres   varchar(150),
Provincia varchar(100),
Ciudad    varchar(100),
Direccion varchar(300),
Cedula  varchar(25) ,
Telefono varchar(15) ,
FechaNac datetime,
SueldoFijo decimal
);

create table DetalleCitas(
Id  int identity(1,1)not null primary key,
CitaId int,
Servicio varchar(25),
ClienteId int ,
Nombres varchar(50),
Costo float(53)  
);

create table FacturaDetalles(
Id int identity(1,1)not null primary key,
FacturaId int ,
ServicioId varchar(25),
Costo      float(53),
Descuento  float(53),
SubTotal  float(53)  
);
create table DetalleCitas(
Id int identity(1,1) not null primary key,
CitaId int foreign key references Citas,
Nombres varchar(300),
ClienteId int,
Servicio varchar(100),
Costo float
);

Create table Facturas(
FacturaId int identity(1,1) not null primary key,
ClienteId int not null foreign key references Clientes,
Fecha    datetime,
Total    decimal(18) ,
Nombres varchar(50),
);


create table Servicios(
ServicioId int identity(1,1)not null primary key,
Nombre varchar(100),
Costo decimal(18) ,
);

create table UserAccount(
UserID int identity(1,1)not null primary key,
ConfirmPassword varchar(50),
Email     varchar(50),
FirstName varchar(50),
LastName  varchar(50),
Password  varchar(50),
Username  varchar(50),
);