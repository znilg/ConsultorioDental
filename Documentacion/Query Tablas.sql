CREATE TABLE HistoriaClinica
(
	  IdHistoriaClinica INT IDENTITY(1,1) PRIMARY KEY
	 ,Fecha Date
	 ,Motivo VARCHAR(150)
	 ,Consentimiento VARCHAR(MAX)	
)

CREATE TABLE Tratamiento
(
	 IdTratamiento INT IDENTITY(1,1) PRIMARY KEY
	,IdHistoriaClinica INT FOREIGN KEY REFERENCES HistoriaClinica(IdHistoriaClinica)
	,OrganoDentario VARCHAR(150)
	,Estatus VARCHAR(20)
	,Procedimiento VARCHAR(150)
	,Costo INT
	,Anticipo INT
	,FechaInicio DATE
	,FechaUltimaVisita DATE
)

CREATE TABLE AnteFam
(
	 IdAnteFam INT IDENTITY(1,1) PRIMARY KEY
	,Nombre VARCHAR(100)
)

CREATE TABLE AnteHeredoFam
(
	 IdAnteHeredoFam INT IDENTITY(1,1) PRIMARY KEY
	,IdHistoriaClinica INT FOREIGN KEY REFERENCES HistoriaClinica(IdHistoriaClinica)
	,IdAnteFam INT FOREIGN KEY REFERENCES AnteFam(IdAnteFam)
	,Comentario VARCHAR(100)
)

CREATE TABLE AntePers
(
	 IdAntePers INT IDENTITY(1,1) PRIMARY KEY
	,Nombre VARCHAR(100)
)

CREATE TABLE AnteNoPatoPers
(
	 IdAnteNoPatoPers INT IDENTITY(1,1) PRIMARY KEY
	,IdHistoriaClinica INT FOREIGN KEY REFERENCES HistoriaClinica(IdHistoriaClinica)
	,IdAntePers INT FOREIGN KEY REFERENCES AntePers(IdAntePers)
)

CREATE TABLE AntePato
(
	 IdAntePato INT IDENTITY(1,1) PRIMARY KEY
	,Nombre VARCHAR(100)
)

CREATE TABLE AntePersPato
(
	 IdAntePersPato INT IDENTITY(1,1) PRIMARY KEY
	,IdHistoriaClinica INT FOREIGN KEY REFERENCES HistoriaClinica(IdHistoriaClinica)
	,IdAntePato INT FOREIGN KEY REFERENCES AntePato(IdAntePato)
	,Respuesta VARCHAR(120)
)

CREATE TABLE Exploracion
(
	 IdExploracion INT IDENTITY(1,1) PRIMARY KEY
	,IdHistoriaClinica INT FOREIGN KEY REFERENCES HistoriaClinica(IdHistoriaClinica)
	,Temperatura VARCHAR(10)
	,TA VARCHAR(15)
	,FR VARCHAR(15)
	,FC VARCHAR(15)
	,AspcPac VARCHAR(30)
	,LabiosComisuras VARCHAR(30)
	,ATM VARCHAR(25)
	,RegionHyT VARCHAR(30)
)

CREATE TABLE Paciente
(
	  IdPaciente INT IDENTITY(1,1) PRIMARY KEY
	 ,IdHistoriaClinica INT FOREIGN KEY REFERENCES HistoriaClinica(IdHistoriaClinica)
	 ,Nombre VARCHAR(40)
	 ,ApellidoPaterno VARCHAR(40)
	 ,ApellidoMaterno VARCHAR(40)
	 ,Genero VARCHAR(10)
	 ,Edad INT
	 ,Direccion VARCHAR(200)
	 ,Telefono VARCHAR(12)
	 ,Ocupacion VARCHAR(100)
)

CREATE TABLE ExamIntrabucal
(
	  IdExamIntrabucal INT IDENTITY(1,1) PRIMARY KEY
	 ,IdHistoriaClinica INT FOREIGN KEY REFERENCES HistoriaClinica(IdHistoriaClinica)
	 ,Carrillos VARCHAR(50)
	 ,Mucosa VARCHAR(50)
	 ,Encia VARCHAR(50)
	 ,Lengua VARCHAR(50)
	 ,Paladar VARCHAR(50)
)

CREATE TABLE TipoMordida
(
	 IdTipoMordida INT IDENTITY(1,1) PRIMARY KEY
	,Tipo VARCHAR(100)
)

CREATE TABLE ExamOclusion
(
	 IdExamOclusion INT IDENTITY(1,1) PRIMARY KEY
	,IdHistoriaClinica INT FOREIGN KEY REFERENCES HistoriaClinica(IdHistoriaClinica)
	,IdTipoMordida INT FOREIGN KEY REFERENCES TipoMordida(IdTipoMordida)
	,TipoDenticion VARCHAR(30)
	,Erupcion VARCHAR(30)
	,PlanoTerminal_L VARCHAR(30)
	,PlanoTerminal_R VARCHAR(30)
	,ClasAngulo_L VARCHAR(30)
	,ClasAngulo_R VARCHAR(30)
	,RelaCan_L VARCHAR(30)
	,RelaCan_R VARCHAR(30)
	,RelaAnt VARCHAR(30)
	,LineaMedia VARCHAR(30)
	,Apinamiento VARCHAR(30)
	,Diastemas VARCHAR(30)
	,Tremas VARCHAR(30)
	,VersDentarias VARCHAR(30)
	,AlteraFormNumEstru VARCHAR(30)
)

CREATE TABLE TipoExamCompl
(
	 IdTipoExamCompl INT IDENTITY(1,1) PRIMARY KEY
	,Tipo VARCHAR(100)
)

CREATE TABLE ExamComplementario
(
	 IdExamComplementario INT IDENTITY(1,1) PRIMARY KEY
	,IdHistoriaClinica INT FOREIGN KEY REFERENCES HistoriaClinica(IdHistoriaClinica)
	,IdTipoExamCompl INT FOREIGN KEY REFERENCES TipoExamCompl(IdTipoExamCompl)
	,Imagen VARCHAR(MAX)
)