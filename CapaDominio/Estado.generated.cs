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
	public partial class Estado
	{
		private int idEstado;
		public virtual int IdEstado
		{
			get
			{
				return this.idEstado;
			}
			set
			{
				this.idEstado = value;
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
		
		private int? idProyecto;
		public virtual int? IdProyecto
		{
			get
			{
				return this.idProyecto;
			}
			set
			{
				this.idProyecto = value;
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
