-- CapaDominio.Actuacion
CREATE TABLE [Actuacion] (
    [idViaComunicacion] int NULL,           -- viaComunicacion
    [idTematica] int NULL,                  -- tematica
    [idActuacion] int IDENTITY NOT NULL,    -- idActuacion
    [fecha] datetime NULL,                  -- fecha
    [detalle] varchar(50) NULL,             -- detalle
    CONSTRAINT [pk_Actuacion] PRIMARY KEY ([idActuacion])
)
go

-- CapaDominio.Localidad
CREATE TABLE [Localidad] (
    [nombre] varchar(50) NULL,              -- nombre
    [idLocalidad] int IDENTITY NOT NULL,    -- idLocalidad
    [codigoPostal] int NULL,                -- codigoPostal
    CONSTRAINT [pk_Localidad] PRIMARY KEY ([idLocalidad])
)
go

-- CapaDominio.Persona
CREATE TABLE [Persona] (
    [tipoDocumento] varchar(50) NULL,       -- tipoDocumento
    [nombre] varchar(50) NULL,              -- nombre
    [idLocalidad] int NULL,                 -- localidad
    [isInteresado] bit NULL,                -- isInteresado
    [isBeneficiario] bit NULL,              -- isBeneficiario
    [idPersona] int IDENTITY NOT NULL,      -- idPersona
    [fechaNacimiento] datetime NULL,        -- fechaNacimiento
    [empresa] varchar(50) NULL,             -- empresa
    [documento] varchar(50) NULL,           -- documento
    [direccion] varchar(50) NULL,           -- direccion
    [cuil] varchar(50) NULL,                -- cuil
    [apellido] varchar(50) NULL,            -- apellido
    [activo] bit NULL,                      -- activo
    CONSTRAINT [pk_Persona] PRIMARY KEY ([idPersona])
)
go

-- CapaDominio.Tematica
CREATE TABLE [Tematica] (
    [nombre] varchar(50) NULL,              -- nombre
    [idTematica] int IDENTITY NOT NULL,     -- idTematica
    CONSTRAINT [pk_Tematica] PRIMARY KEY ([idTematica])
)
go

-- CapaDominio.ViaComunicacion
CREATE TABLE [ViaComunicacion] (
    [nombre] varchar(50) NULL,              -- nombre
    [idViaComunicacion] int IDENTITY NOT NULL, -- idViaComunicacion
    CONSTRAINT [pk_ViaComunicacion] PRIMARY KEY ([idViaComunicacion])
)
go

CREATE INDEX [idx_Actuacion_idTematica] ON [Actuacion]([idTematica])
go

CREATE INDEX [idx_Actacion_idViaComunicacion] ON [Actuacion]([idViaComunicacion])
go

CREATE INDEX [idx_Persona_idLocalidad] ON [Persona]([idLocalidad])
go

ALTER TABLE [Actuacion] ADD CONSTRAINT [FK_Actuacion_Tematica] FOREIGN KEY ([idTematica]) REFERENCES [Tematica]([idTematica])
go

ALTER TABLE [Actuacion] ADD CONSTRAINT [FK_Actuacion_ViaComunicacion] FOREIGN KEY ([idViaComunicacion]) REFERENCES [ViaComunicacion]([idViaComunicacion])
go

ALTER TABLE [Persona] ADD CONSTRAINT [FK_Persona_Localidad] FOREIGN KEY ([idLocalidad]) REFERENCES [Localidad]([idLocalidad])
go

