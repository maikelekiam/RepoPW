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
	public partial class UvtReferente
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
		
		private int idPersona;
		public virtual int IdPersona
		{
			get
			{
				return this.idPersona;
			}
			set
			{
				this.idPersona = value;
			}
		}
		
		private bool? activo;
		public virtual bool? Activo
		{
			get
			{
				return this.activo;
			}
			set
			{
				this.activo = value;
			}
		}
		
		private Persona persona;
		public virtual Persona Persona
		{
			get
			{
				return this.persona;
			}
			set
			{
				this.persona = value;
			}
		}
		
		private Uvt uvt;
		public virtual Uvt Uvt
		{
			get
			{
				return this.uvt;
			}
			set
			{
				this.uvt = value;
			}
		}
		
	}
}
#pragma warning restore 1591
