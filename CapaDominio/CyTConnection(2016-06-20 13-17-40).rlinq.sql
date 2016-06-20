-- CapaDominio.Actuacion
CREATE TABLE [Actuacion] (
    [idViaComunicacion] int NULL,           -- viaComunicacion
    [idTematica] int NULL,                  -- tematica
    [idPersona] int NULL,                   -- persona
    [idActuacion] int IDENTITY NOT NULL,    -- idActuacion
    [fecha] datetime NULL,                  -- fecha
    [detalle] varchar(max) NULL,            -- detalle
    [activo] bit NULL,                      -- activo
    CONSTRAINT [pk_Actuacion] PRIMARY KEY ([idActuacion])
)
go

-- CapaDominio.AreaProductiva
CREATE TABLE [AreaProductiva] (
    [nombre] varchar(50) NULL,              -- nombre
    [idAreaProductiva] int IDENTITY NOT NULL, -- idAreaProductiva
    CONSTRAINT [pk_AreaProductiva] PRIMARY KEY ([idAreaProductiva])
)
go

-- CapaDominio.Convocatorium
CREATE TABLE [Convocatoria] (
    [idTipoFinanciamiento] int NULL,        -- tipoFinanciamiento
    [objetivo] varchar(100) NULL,           -- objetivo
    [nombre] varchar(50) NULL,              -- nombre
    [montoTotal] numeric(18,2) NULL,        -- montoTotal
    [montoProyecto] numeric(18,2) NULL,     -- montoProyecto
    [idModalidad] int NULL,                 -- modalidad
    [isAbierta] int NULL,                   -- isAbierta
    [idConvocatoria] int IDENTITY NOT NULL, -- idConvocatoria
    [idFondo] int NULL,                     -- fondo
    [fechaInicio] datetime NULL,            -- fechaInicio
    [fechaCierre] datetime NULL,            -- fechaCierre
    [descripcion] varchar(100) NULL,        -- descripcion
    [anio] int NULL,                        -- anio
    [activa] bit NULL,                      -- activa
    CONSTRAINT [pk_Convocatoria] PRIMARY KEY ([idConvocatoria])
)
go

-- CapaDominio.CorreoElectronico
CREATE TABLE [CorreoElectronico] (
    [idPersona] int NOT NULL,               -- persona
    [idCorreoElectronico] int IDENTITY NOT NULL, -- idCorreoElectronico
    [correoElectronico] varchar(50) NULL,   -- correoElectronico1
    [activo] bit NULL,                      -- activo
    CONSTRAINT [pk_CorreoElectronico] PRIMARY KEY ([idCorreoElectronico])
)
go

-- CapaDominio.Estado
CREATE TABLE [Estado] (
    [nombre] varchar(50) NULL,              -- nombre
    [idEstado] int IDENTITY NOT NULL,       -- idEstado
    CONSTRAINT [pk_Estado] PRIMARY KEY ([idEstado])
)
go

-- CapaDominio.Etapa
CREATE TABLE [Etapa] (
    [idProyecto] int NULL,                  -- proyecto
    [numero] int NULL,                      -- numero
    [montoEtapa] numeric(18,2) NULL,        -- montoEtapa
    [idEtapa] int IDENTITY NOT NULL,        -- idEtapa
    [fechaInicio] datetime NULL,            -- fechaInicio
    [fechaFin] datetime NULL,               -- fechaFin
    [activo] bit NULL,                      -- activo
    CONSTRAINT [pk_Etapa] PRIMARY KEY ([idEtapa])
)
go

-- CapaDominio.Fondo
CREATE TABLE [Fondo] (
    [idOrigen] int NULL,                    -- origen
    [nombre] varchar(50) NULL,              -- nombre
    [idFondo] int IDENTITY NOT NULL,        -- idFondo
    [descripcion] varchar(50) NULL,         -- descripcion
    [activo] bit NULL,                      -- activo
    CONSTRAINT [pk_Fondo] PRIMARY KEY ([idFondo])
)
go

-- CapaDominio.Integrante
CREATE TABLE [Integrantes] (
    [idProyecto] int NOT NULL,              -- idProyecto
    [idPersona] int NOT NULL,               -- idPersona
    [activo] bit NULL,                      -- activo
    CONSTRAINT [pk_Integrantes] PRIMARY KEY ([idPersona], [idProyecto])
)
go

-- CapaDominio.ListaTipoDestinatario
CREATE TABLE [ListaTipoDestinatario] (
    [idTipoDestinatario] int NOT NULL,      -- idTipoDestinatario
    [idConvocatoria] int NOT NULL,          -- idConvocatoria
    [activo] bit NULL,                      -- activo
    CONSTRAINT [pk_ListaTipoDestinatario] PRIMARY KEY ([idConvocatoria], [idTipoDestinatario])
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

-- CapaDominio.LocalidadImpacto
CREATE TABLE [LocalidadImpacto] (
    [idProyecto] int NOT NULL,              -- idProyecto
    [idLocalidad] int NOT NULL,             -- idLocalidad
    [activo] bit NULL,                      -- activo
    CONSTRAINT [pk_LocalidadImpacto] PRIMARY KEY ([idLocalidad], [idProyecto])
)
go

-- CapaDominio.Modalidad
CREATE TABLE [Modalidad] (
    [nombre] varchar(50) NULL,              -- nombre
    [idModalidad] int IDENTITY NOT NULL,    -- idModalidad
    CONSTRAINT [pk_Modalidad] PRIMARY KEY ([idModalidad])
)
go

-- CapaDominio.Origen
CREATE TABLE [Origen] (
    [nombre] varchar(50) NOT NULL,          -- nombre
    [idOrigen] int IDENTITY NOT NULL,       -- idOrigen
    CONSTRAINT [pk_Origen] PRIMARY KEY ([idOrigen])
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

-- CapaDominio.Proyecto
CREATE TABLE [Proyecto] (
    [idUvt] int NULL,                       -- uvt
    [numeroExp] varchar(50) NULL,           -- numeroExp
    [nombre] varchar(50) NULL,              -- nombre
    [montoSolicitado] numeric(18,2) NULL,   -- montoSolicitado
    [montoContraparte] numeric(18,2) NULL,  -- montoContraparte
    [idProyecto] int IDENTITY NOT NULL,     -- idProyecto
    [idEstado] int NULL,                    -- estado
    [idConvocatoria] int NULL,              -- convocatorium
    [idAreaProductiva] int NULL,            -- areaProductiva
    [activo] bit NULL,                      -- activo
    CONSTRAINT [pk_Proyecto] PRIMARY KEY ([idProyecto])
)
go

-- CapaDominio.Telefono
CREATE TABLE [Telefono] (
    [telefono] varchar(50) NULL,            -- telefono1
    [idPersona] int NOT NULL,               -- persona
    [idTelefono] int IDENTITY NOT NULL,     -- idTelefono
    [activo] bit NULL,                      -- activo
    CONSTRAINT [pk_Telefono] PRIMARY KEY ([idTelefono])
)
go

-- CapaDominio.Tematica
CREATE TABLE [Tematica] (
    [nombre] varchar(50) NULL,              -- nombre
    [idTematica] int IDENTITY NOT NULL,     -- idTematica
    [activo] bit NULL,                      -- activo
    CONSTRAINT [pk_Tematica] PRIMARY KEY ([idTematica])
)
go

-- CapaDominio.TipoDestinatario
CREATE TABLE [TipoDestinatario] (
    [nombre] varchar(50) NULL,              -- nombre
    [idTipoDestinatario] int IDENTITY NOT NULL, -- idTipoDestinatario
    [activo] bit NULL,                      -- activo
    CONSTRAINT [pk_TipoDestinatario] PRIMARY KEY ([idTipoDestinatario])
)
go

-- CapaDominio.TipoFinanciamiento
CREATE TABLE [TipoFinanciamiento] (
    [nombre] varchar(50) NULL,              -- nombre
    [idTipoFinanciamiento] int IDENTITY NOT NULL, -- idTipoFinanciamiento
    CONSTRAINT [pk_TipoFinanciamiento] PRIMARY KEY ([idTipoFinanciamiento])
)
go

-- CapaDominio.Uvt
CREATE TABLE [Uvt] (
    [nombreUvt] varchar(50) NULL,           -- nombreUvt
    [idUvt] int IDENTITY NOT NULL,          -- idUvt
    [direccion] varchar(50) NULL,           -- direccion
    [activo] bit NULL,                      -- activo
    CONSTRAINT [pk_Uvt] PRIMARY KEY ([idUvt])
)
go

-- CapaDominio.UvtReferente
CREATE TABLE [UvtReferentes] (
    [idUvt] int NOT NULL,                   -- idUvt
    [idPersona] int NOT NULL,               -- idPersona
    [activo] bit NULL,                      -- activo
    CONSTRAINT [pk_UvtReferentes] PRIMARY KEY ([idPersona], [idUvt])
)
go

-- CapaDominio.ViaComunicacion
CREATE TABLE [ViaComunicacion] (
    [nombre] varchar(50) NULL,              -- nombre
    [idViaComunicacion] int IDENTITY NOT NULL, -- idViaComunicacion
    [activo] bit NULL,                      -- activo
    CONSTRAINT [pk_ViaComunicacion] PRIMARY KEY ([idViaComunicacion])
)
go

CREATE INDEX [idx_Actuacion_idPersona] ON [Actuacion]([idPersona])
go

CREATE INDEX [idx_Actuacion_idTematica] ON [Actuacion]([idTematica])
go

CREATE INDEX [idx_Actacion_idViaComunicacion] ON [Actuacion]([idViaComunicacion])
go

CREATE INDEX [idx_Convocatoria_idFondo] ON [Convocatoria]([idFondo])
go

CREATE INDEX [idx_Convocatoria_idModalidad] ON [Convocatoria]([idModalidad])
go

CREATE INDEX [idx_Cnvctr_dTipoFinanciamiento] ON [Convocatoria]([idTipoFinanciamiento])
go

CREATE INDEX [idx_CrreoElectronico_idPersona] ON [CorreoElectronico]([idPersona])
go

CREATE INDEX [idx_Etapa_idProyecto] ON [Etapa]([idProyecto])
go

CREATE INDEX [idx_Fondo_idOrigen] ON [Fondo]([idOrigen])
go

CREATE INDEX [idx_Integrantes_idPersona] ON [Integrantes]([idPersona])
go

CREATE INDEX [idx_Integrantes_idProyecto] ON [Integrantes]([idProyecto])
go

CREATE INDEX [idx_LstTpDstntr_idConvocatoria] ON [ListaTipoDestinatario]([idConvocatoria])
go

CREATE INDEX [idx_LstTpDstntr_dTpDstinatario] ON [ListaTipoDestinatario]([idTipoDestinatario])
go

CREATE INDEX [idx_LclidadImpacto_idLocalidad] ON [LocalidadImpacto]([idLocalidad])
go

CREATE INDEX [idx_LcalidadImpacto_idProyecto] ON [LocalidadImpacto]([idProyecto])
go

CREATE INDEX [idx_Persona_idLocalidad] ON [Persona]([idLocalidad])
go

CREATE INDEX [idx_Proyecto_idAreaProductiva] ON [Proyecto]([idAreaProductiva])
go

CREATE INDEX [idx_Proyecto_idConvocatoria] ON [Proyecto]([idConvocatoria])
go

CREATE INDEX [idx_Proyecto_idEstado] ON [Proyecto]([idEstado])
go

CREATE INDEX [idx_Proyecto_idUvt] ON [Proyecto]([idUvt])
go

CREATE INDEX [idx_Telefono_idPersona] ON [Telefono]([idPersona])
go

CREATE INDEX [idx_UvtReferentes_idPersona] ON [UvtReferentes]([idPersona])
go

CREATE INDEX [idx_UvtReferentes_idUvt] ON [UvtReferentes]([idUvt])
go

ALTER TABLE [Actuacion] ADD CONSTRAINT [FK_Actuacion_Persona] FOREIGN KEY ([idPersona]) REFERENCES [Persona]([idPersona])
go

ALTER TABLE [Actuacion] ADD CONSTRAINT [FK_Actuacion_Tematica] FOREIGN KEY ([idTematica]) REFERENCES [Tematica]([idTematica])
go

ALTER TABLE [Actuacion] ADD CONSTRAINT [FK_Actuacion_ViaComunicacion] FOREIGN KEY ([idViaComunicacion]) REFERENCES [ViaComunicacion]([idViaComunicacion])
go

ALTER TABLE [Convocatoria] ADD CONSTRAINT [FK_Convocatoria_Fondo] FOREIGN KEY ([idFondo]) REFERENCES [Fondo]([idFondo])
go

ALTER TABLE [Convocatoria] ADD CONSTRAINT [FK_Convocatoria_Modalidad] FOREIGN KEY ([idModalidad]) REFERENCES [Modalidad]([idModalidad])
go

ALTER TABLE [Convocatoria] ADD CONSTRAINT [FK_Convocatoria_TipoFinanciamiento] FOREIGN KEY ([idTipoFinanciamiento]) REFERENCES [TipoFinanciamiento]([idTipoFinanciamiento])
go

ALTER TABLE [CorreoElectronico] ADD CONSTRAINT [FK_CorreoElectronico_Persona] FOREIGN KEY ([idPersona]) REFERENCES [Persona]([idPersona])
go

ALTER TABLE [Etapa] ADD CONSTRAINT [FK_Etapa_Proyecto] FOREIGN KEY ([idProyecto]) REFERENCES [Proyecto]([idProyecto])
go

ALTER TABLE [Fondo] ADD CONSTRAINT [FK_Fondo_Origen] FOREIGN KEY ([idOrigen]) REFERENCES [Origen]([idOrigen])
go

ALTER TABLE [Integrantes] ADD CONSTRAINT [FK_Integrantes_Persona] FOREIGN KEY ([idPersona]) REFERENCES [Persona]([idPersona])
go

ALTER TABLE [Integrantes] ADD CONSTRAINT [FK_Integrantes_Proyecto] FOREIGN KEY ([idProyecto]) REFERENCES [Proyecto]([idProyecto])
go

ALTER TABLE [ListaTipoDestinatario] ADD CONSTRAINT [FK_ListaTipoDestinatario_Convocatoria] FOREIGN KEY ([idConvocatoria]) REFERENCES [Convocatoria]([idConvocatoria])
go

ALTER TABLE [ListaTipoDestinatario] ADD CONSTRAINT [FK_ListaTipoDestinatario_TipoDestinatario] FOREIGN KEY ([idTipoDestinatario]) REFERENCES [TipoDestinatario]([idTipoDestinatario])
go

ALTER TABLE [LocalidadImpacto] ADD CONSTRAINT [FK_LocalidadImpacto_Localidad] FOREIGN KEY ([idLocalidad]) REFERENCES [Localidad]([idLocalidad])
go

ALTER TABLE [LocalidadImpacto] ADD CONSTRAINT [FK_LocalidadImpacto_Proyecto] FOREIGN KEY ([idProyecto]) REFERENCES [Proyecto]([idProyecto])
go

ALTER TABLE [Persona] ADD CONSTRAINT [FK_Persona_Localidad] FOREIGN KEY ([idLocalidad]) REFERENCES [Localidad]([idLocalidad])
go

ALTER TABLE [Proyecto] ADD CONSTRAINT [FK_Proyecto_AreaProductiva] FOREIGN KEY ([idAreaProductiva]) REFERENCES [AreaProductiva]([idAreaProductiva])
go

ALTER TABLE [Proyecto] ADD CONSTRAINT [FK_Proyecto_Convocatoria] FOREIGN KEY ([idConvocatoria]) REFERENCES [Convocatoria]([idConvocatoria])
go

ALTER TABLE [Proyecto] ADD CONSTRAINT [FK_Proyecto_Estado] FOREIGN KEY ([idEstado]) REFERENCES [Estado]([idEstado])
go

ALTER TABLE [Proyecto] ADD CONSTRAINT [FK_Proyecto_Uvt] FOREIGN KEY ([idUvt]) REFERENCES [Uvt]([idUvt])
go

ALTER TABLE [Telefono] ADD CONSTRAINT [FK_Telefono_Persona] FOREIGN KEY ([idPersona]) REFERENCES [Persona]([idPersona])
go

ALTER TABLE [UvtReferentes] ADD CONSTRAINT [FK_UvtReferentes_Persona] FOREIGN KEY ([idPersona]) REFERENCES [Persona]([idPersona])
go

ALTER TABLE [UvtReferentes] ADD CONSTRAINT [FK_UvtReferentes_Uvt] FOREIGN KEY ([idUvt]) REFERENCES [Uvt]([idUvt])
go

