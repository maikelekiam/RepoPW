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
	public partial class CorreoElectronico
	{
		private int idCorreoElectronico;
		public virtual int IdCorreoElectronico
		{
			get
			{
				return this.idCorreoElectronico;
			}
			set
			{
				this.idCorreoElectronico = value;
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
		
		private string correoElectronico1;
		public virtual string CorreoElectronico1
		{
			get
			{
				return this.correoElectronico1;
			}
			set
			{
				this.correoElectronico1 = value;
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
		
	}
}
#pragma warning restore 1591
