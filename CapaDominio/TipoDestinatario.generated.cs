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
	public partial class TipoDestinatario
	{
		private int idTipoDestinatario;
		public virtual int IdTipoDestinatario
		{
			get
			{
				return this.idTipoDestinatario;
			}
			set
			{
				this.idTipoDestinatario = value;
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
		
		private IList<Convocatorium> convocatoria = new List<Convocatorium>();
		public virtual IList<Convocatorium> Convocatoria
		{
			get
			{
				return this.convocatoria;
			}
		}
		
	}
}
#pragma warning restore 1591