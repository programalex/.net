﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConectarLINQ.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="crud")]
	public partial class DataUsuarioDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertconsept(consept instance);
    partial void Updateconsept(consept instance);
    partial void Deleteconsept(consept instance);
    #endregion
		
		public DataUsuarioDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["crudConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataUsuarioDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataUsuarioDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataUsuarioDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataUsuarioDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<consept> consepts
		{
			get
			{
				return this.GetTable<consept>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.crud_actualizar")]
		public int crud_actualizar([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NumeroIdentificacion", DbType="Int")] System.Nullable<int> numeroIdentificacion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TipoDocumento", DbType="Int")] System.Nullable<int> tipoDocumento, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="NVarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fecha", DbType="Date")] System.Nullable<System.DateTime> fecha)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), numeroIdentificacion, tipoDocumento, nombre, fecha);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.crud_eliminar")]
		public int crud_eliminar([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NumeroIdentificacion", DbType="Int")] System.Nullable<int> numeroIdentificacion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), numeroIdentificacion);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.crud_consulta")]
		public ISingleResult<crud_consultaResult> crud_consulta([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NumeroIdentificacion", DbType="Int")] System.Nullable<int> numeroIdentificacion)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), numeroIdentificacion);
			return ((ISingleResult<crud_consultaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.consulta")]
		public ISingleResult<consultaResult> consulta()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<consultaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.insertar")]
		public int insertar([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NumeroIdentificacion", DbType="Int")] System.Nullable<int> numeroIdentificacion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TipoDocumento", DbType="Int")] System.Nullable<int> tipoDocumento, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="NVarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fecha", DbType="Date")] System.Nullable<System.DateTime> fecha)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), numeroIdentificacion, tipoDocumento, nombre, fecha);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.crud_insertar")]
		public ISingleResult<crud_insertarResult> crud_insertar([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NumeroIdentificacion", DbType="Int")] System.Nullable<int> numeroIdentificacion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TipoDocumento", DbType="Int")] System.Nullable<int> tipoDocumento, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="NVarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fecha", DbType="Date")] System.Nullable<System.DateTime> fecha)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), numeroIdentificacion, tipoDocumento, nombre, fecha);
			return ((ISingleResult<crud_insertarResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.consept")]
	public partial class consept : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _NumeroIdentificacion;
		
		private System.Nullable<int> _TipoDocumento;
		
		private string _Nombre;
		
		private System.Nullable<System.DateTime> _Fecha;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNumeroIdentificacionChanging(int value);
    partial void OnNumeroIdentificacionChanged();
    partial void OnTipoDocumentoChanging(System.Nullable<int> value);
    partial void OnTipoDocumentoChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnFechaChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaChanged();
    #endregion
		
		public consept()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumeroIdentificacion", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int NumeroIdentificacion
		{
			get
			{
				return this._NumeroIdentificacion;
			}
			set
			{
				if ((this._NumeroIdentificacion != value))
				{
					this.OnNumeroIdentificacionChanging(value);
					this.SendPropertyChanging();
					this._NumeroIdentificacion = value;
					this.SendPropertyChanged("NumeroIdentificacion");
					this.OnNumeroIdentificacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoDocumento", DbType="Int")]
		public System.Nullable<int> TipoDocumento
		{
			get
			{
				return this._TipoDocumento;
			}
			set
			{
				if ((this._TipoDocumento != value))
				{
					this.OnTipoDocumentoChanging(value);
					this.SendPropertyChanging();
					this._TipoDocumento = value;
					this.SendPropertyChanged("TipoDocumento");
					this.OnTipoDocumentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="Date")]
		public System.Nullable<System.DateTime> Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this.OnFechaChanging(value);
					this.SendPropertyChanging();
					this._Fecha = value;
					this.SendPropertyChanged("Fecha");
					this.OnFechaChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class crud_consultaResult
	{
		
		private int _NumeroIdentificacion;
		
		private System.Nullable<int> _TipoDocumento;
		
		private string _Nombre;
		
		private System.Nullable<System.DateTime> _Fecha;
		
		public crud_consultaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumeroIdentificacion", DbType="Int NOT NULL")]
		public int NumeroIdentificacion
		{
			get
			{
				return this._NumeroIdentificacion;
			}
			set
			{
				if ((this._NumeroIdentificacion != value))
				{
					this._NumeroIdentificacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoDocumento", DbType="Int")]
		public System.Nullable<int> TipoDocumento
		{
			get
			{
				return this._TipoDocumento;
			}
			set
			{
				if ((this._TipoDocumento != value))
				{
					this._TipoDocumento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="Date")]
		public System.Nullable<System.DateTime> Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this._Fecha = value;
				}
			}
		}
	}
	
	public partial class consultaResult
	{
		
		private int _NumeroIdentificacion;
		
		private System.Nullable<int> _TipoDocumento;
		
		private string _Nombre;
		
		private System.Nullable<System.DateTime> _Fecha;
		
		public consultaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumeroIdentificacion", DbType="Int NOT NULL")]
		public int NumeroIdentificacion
		{
			get
			{
				return this._NumeroIdentificacion;
			}
			set
			{
				if ((this._NumeroIdentificacion != value))
				{
					this._NumeroIdentificacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoDocumento", DbType="Int")]
		public System.Nullable<int> TipoDocumento
		{
			get
			{
				return this._TipoDocumento;
			}
			set
			{
				if ((this._TipoDocumento != value))
				{
					this._TipoDocumento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="Date")]
		public System.Nullable<System.DateTime> Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this._Fecha = value;
				}
			}
		}
	}
	
	public partial class crud_insertarResult
	{
		
		private int _NumeroIdentificacion;
		
		private System.Nullable<int> _TipoDocumento;
		
		private string _Nombre;
		
		private System.Nullable<System.DateTime> _Fecha;
		
		public crud_insertarResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumeroIdentificacion", DbType="Int NOT NULL")]
		public int NumeroIdentificacion
		{
			get
			{
				return this._NumeroIdentificacion;
			}
			set
			{
				if ((this._NumeroIdentificacion != value))
				{
					this._NumeroIdentificacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipoDocumento", DbType="Int")]
		public System.Nullable<int> TipoDocumento
		{
			get
			{
				return this._TipoDocumento;
			}
			set
			{
				if ((this._TipoDocumento != value))
				{
					this._TipoDocumento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="Date")]
		public System.Nullable<System.DateTime> Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this._Fecha = value;
				}
			}
		}
	}
}
#pragma warning restore 1591