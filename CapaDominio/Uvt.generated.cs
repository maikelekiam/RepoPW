#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using CapaDominio;

namespace CapaDominio	
{
	public partial class Uvt
	{
		private int idUvt;
		public virtual int IdUvt
		{
			get
			{
				return this.idUvt;
			}
			set
			{
				this.idUvt = value;
			}
		}
		
		private string nombre;
		public virtual string Nombre
		{
			get
			{
				return this.nombre;
			}
			set
			{
				this.nombre = value;
			}
		}
		
		private string direccion;
		public virtual string Direccion
		{
			get
			{
				return this.direccion;
			}
			set
			{
				this.direccion = value;
			}
		}
		
		private IList<Persona> personas = new List<Persona>();
		public virtual IList<Persona> Personas
		{
			get
			{
				return this.personas;
			}
		}
		
		private IList<Proyecto> proyectos = new List<Proyecto>();
		public virtual IList<Proyecto> Proyectos
		{
			get
			{
				return this.proyectos;
			}
		}
		
	}
}
#pragma warning restore 1591
