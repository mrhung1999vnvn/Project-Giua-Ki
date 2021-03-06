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

namespace DAL_Login
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLlogin")]
	public partial class LinQBaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_per_relationship(tbl_per_relationship instance);
    partial void Updatetbl_per_relationship(tbl_per_relationship instance);
    partial void Deletetbl_per_relationship(tbl_per_relationship instance);
    partial void Inserttbl_permisstion(tbl_permisstion instance);
    partial void Updatetbl_permisstion(tbl_permisstion instance);
    partial void Deletetbl_permisstion(tbl_permisstion instance);
    partial void Inserttbl_user(tbl_user instance);
    partial void Updatetbl_user(tbl_user instance);
    partial void Deletetbl_user(tbl_user instance);
    #endregion
		
		public LinQBaseDataContext() : 
				base(global::DAL_Login.Properties.Settings.Default.QLloginConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinQBaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinQBaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinQBaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinQBaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_per_relationship> tbl_per_relationships
		{
			get
			{
				return this.GetTable<tbl_per_relationship>();
			}
		}
		
		public System.Data.Linq.Table<tbl_permisstion> tbl_permisstions
		{
			get
			{
				return this.GetTable<tbl_permisstion>();
			}
		}
		
		public System.Data.Linq.Table<tbl_permisstion_detail> tbl_permisstion_details
		{
			get
			{
				return this.GetTable<tbl_permisstion_detail>();
			}
		}
		
		public System.Data.Linq.Table<tbl_user> tbl_users
		{
			get
			{
				return this.GetTable<tbl_user>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_per_relationship")]
	public partial class tbl_per_relationship : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_rel;
		
		private int _id_user_rel;
		
		private int _id_per_rel;
		
		private System.Nullable<bool> _suspended;
		
		private EntityRef<tbl_permisstion> _tbl_permisstion;
		
		private EntityRef<tbl_user> _tbl_user;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_relChanging(int value);
    partial void Onid_relChanged();
    partial void Onid_user_relChanging(int value);
    partial void Onid_user_relChanged();
    partial void Onid_per_relChanging(int value);
    partial void Onid_per_relChanged();
    partial void OnsuspendedChanging(System.Nullable<bool> value);
    partial void OnsuspendedChanged();
    #endregion
		
		public tbl_per_relationship()
		{
			this._tbl_permisstion = default(EntityRef<tbl_permisstion>);
			this._tbl_user = default(EntityRef<tbl_user>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_rel", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_rel
		{
			get
			{
				return this._id_rel;
			}
			set
			{
				if ((this._id_rel != value))
				{
					this.Onid_relChanging(value);
					this.SendPropertyChanging();
					this._id_rel = value;
					this.SendPropertyChanged("id_rel");
					this.Onid_relChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_user_rel", DbType="Int NOT NULL")]
		public int id_user_rel
		{
			get
			{
				return this._id_user_rel;
			}
			set
			{
				if ((this._id_user_rel != value))
				{
					if (this._tbl_user.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_user_relChanging(value);
					this.SendPropertyChanging();
					this._id_user_rel = value;
					this.SendPropertyChanged("id_user_rel");
					this.Onid_user_relChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_per_rel", DbType="Int NOT NULL")]
		public int id_per_rel
		{
			get
			{
				return this._id_per_rel;
			}
			set
			{
				if ((this._id_per_rel != value))
				{
					if (this._tbl_permisstion.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_per_relChanging(value);
					this.SendPropertyChanging();
					this._id_per_rel = value;
					this.SendPropertyChanged("id_per_rel");
					this.Onid_per_relChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_suspended", DbType="Bit")]
		public System.Nullable<bool> suspended
		{
			get
			{
				return this._suspended;
			}
			set
			{
				if ((this._suspended != value))
				{
					this.OnsuspendedChanging(value);
					this.SendPropertyChanging();
					this._suspended = value;
					this.SendPropertyChanged("suspended");
					this.OnsuspendedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_permisstion_tbl_per_relationship", Storage="_tbl_permisstion", ThisKey="id_per_rel", OtherKey="id_per", IsForeignKey=true)]
		public tbl_permisstion tbl_permisstion
		{
			get
			{
				return this._tbl_permisstion.Entity;
			}
			set
			{
				tbl_permisstion previousValue = this._tbl_permisstion.Entity;
				if (((previousValue != value) 
							|| (this._tbl_permisstion.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_permisstion.Entity = null;
						previousValue.tbl_per_relationships.Remove(this);
					}
					this._tbl_permisstion.Entity = value;
					if ((value != null))
					{
						value.tbl_per_relationships.Add(this);
						this._id_per_rel = value.id_per;
					}
					else
					{
						this._id_per_rel = default(int);
					}
					this.SendPropertyChanged("tbl_permisstion");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_user_tbl_per_relationship", Storage="_tbl_user", ThisKey="id_user_rel", OtherKey="id_user", IsForeignKey=true)]
		public tbl_user tbl_user
		{
			get
			{
				return this._tbl_user.Entity;
			}
			set
			{
				tbl_user previousValue = this._tbl_user.Entity;
				if (((previousValue != value) 
							|| (this._tbl_user.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_user.Entity = null;
						previousValue.tbl_per_relationships.Remove(this);
					}
					this._tbl_user.Entity = value;
					if ((value != null))
					{
						value.tbl_per_relationships.Add(this);
						this._id_user_rel = value.id_user;
					}
					else
					{
						this._id_user_rel = default(int);
					}
					this.SendPropertyChanged("tbl_user");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_permisstion")]
	public partial class tbl_permisstion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_per;
		
		private string _name_per;
		
		private string _description;
		
		private EntitySet<tbl_per_relationship> _tbl_per_relationships;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_perChanging(int value);
    partial void Onid_perChanged();
    partial void Onname_perChanging(string value);
    partial void Onname_perChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    #endregion
		
		public tbl_permisstion()
		{
			this._tbl_per_relationships = new EntitySet<tbl_per_relationship>(new Action<tbl_per_relationship>(this.attach_tbl_per_relationships), new Action<tbl_per_relationship>(this.detach_tbl_per_relationships));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_per", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id_per
		{
			get
			{
				return this._id_per;
			}
			set
			{
				if ((this._id_per != value))
				{
					this.Onid_perChanging(value);
					this.SendPropertyChanging();
					this._id_per = value;
					this.SendPropertyChanged("id_per");
					this.Onid_perChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name_per", DbType="NVarChar(50)")]
		public string name_per
		{
			get
			{
				return this._name_per;
			}
			set
			{
				if ((this._name_per != value))
				{
					this.Onname_perChanging(value);
					this.SendPropertyChanging();
					this._name_per = value;
					this.SendPropertyChanged("name_per");
					this.Onname_perChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(50)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_permisstion_tbl_per_relationship", Storage="_tbl_per_relationships", ThisKey="id_per", OtherKey="id_per_rel")]
		public EntitySet<tbl_per_relationship> tbl_per_relationships
		{
			get
			{
				return this._tbl_per_relationships;
			}
			set
			{
				this._tbl_per_relationships.Assign(value);
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
		
		private void attach_tbl_per_relationships(tbl_per_relationship entity)
		{
			this.SendPropertyChanging();
			entity.tbl_permisstion = this;
		}
		
		private void detach_tbl_per_relationships(tbl_per_relationship entity)
		{
			this.SendPropertyChanging();
			entity.tbl_permisstion = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_permisstion_detail")]
	public partial class tbl_permisstion_detail
	{
		
		private int _id_pd;
		
		private string _name_action;
		
		private string _code_action;
		
		private System.Nullable<int> _id_per;
		
		public tbl_permisstion_detail()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_pd", DbType="Int NOT NULL")]
		public int id_pd
		{
			get
			{
				return this._id_pd;
			}
			set
			{
				if ((this._id_pd != value))
				{
					this._id_pd = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name_action", DbType="NVarChar(50)")]
		public string name_action
		{
			get
			{
				return this._name_action;
			}
			set
			{
				if ((this._name_action != value))
				{
					this._name_action = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_code_action", DbType="VarChar(50)")]
		public string code_action
		{
			get
			{
				return this._code_action;
			}
			set
			{
				if ((this._code_action != value))
				{
					this._code_action = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_per", DbType="Int")]
		public System.Nullable<int> id_per
		{
			get
			{
				return this._id_per;
			}
			set
			{
				if ((this._id_per != value))
				{
					this._id_per = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_user")]
	public partial class tbl_user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_user;
		
		private string _name_user;
		
		private string _user_name;
		
		private string _pass;
		
		private EntitySet<tbl_per_relationship> _tbl_per_relationships;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_userChanging(int value);
    partial void Onid_userChanged();
    partial void Onname_userChanging(string value);
    partial void Onname_userChanged();
    partial void Onuser_nameChanging(string value);
    partial void Onuser_nameChanged();
    partial void OnpassChanging(string value);
    partial void OnpassChanged();
    #endregion
		
		public tbl_user()
		{
			this._tbl_per_relationships = new EntitySet<tbl_per_relationship>(new Action<tbl_per_relationship>(this.attach_tbl_per_relationships), new Action<tbl_per_relationship>(this.detach_tbl_per_relationships));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_user", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_user
		{
			get
			{
				return this._id_user;
			}
			set
			{
				if ((this._id_user != value))
				{
					this.Onid_userChanging(value);
					this.SendPropertyChanging();
					this._id_user = value;
					this.SendPropertyChanged("id_user");
					this.Onid_userChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name_user", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name_user
		{
			get
			{
				return this._name_user;
			}
			set
			{
				if ((this._name_user != value))
				{
					this.Onname_userChanging(value);
					this.SendPropertyChanging();
					this._name_user = value;
					this.SendPropertyChanged("name_user");
					this.Onname_userChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string user_name
		{
			get
			{
				return this._user_name;
			}
			set
			{
				if ((this._user_name != value))
				{
					this.Onuser_nameChanging(value);
					this.SendPropertyChanging();
					this._user_name = value;
					this.SendPropertyChanged("user_name");
					this.Onuser_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if ((this._pass != value))
				{
					this.OnpassChanging(value);
					this.SendPropertyChanging();
					this._pass = value;
					this.SendPropertyChanged("pass");
					this.OnpassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_user_tbl_per_relationship", Storage="_tbl_per_relationships", ThisKey="id_user", OtherKey="id_user_rel")]
		public EntitySet<tbl_per_relationship> tbl_per_relationships
		{
			get
			{
				return this._tbl_per_relationships;
			}
			set
			{
				this._tbl_per_relationships.Assign(value);
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
		
		private void attach_tbl_per_relationships(tbl_per_relationship entity)
		{
			this.SendPropertyChanging();
			entity.tbl_user = this;
		}
		
		private void detach_tbl_per_relationships(tbl_per_relationship entity)
		{
			this.SendPropertyChanging();
			entity.tbl_user = null;
		}
	}
}
#pragma warning restore 1591
