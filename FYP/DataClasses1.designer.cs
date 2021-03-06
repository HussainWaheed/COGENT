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

namespace FYP
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Analytics")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertadmin(admin instance);
    partial void Updateadmin(admin instance);
    partial void Deleteadmin(admin instance);
    partial void Insertuser_game(user_game instance);
    partial void Updateuser_game(user_game instance);
    partial void Deleteuser_game(user_game instance);
    partial void Insertgame(game instance);
    partial void Updategame(game instance);
    partial void Deletegame(game instance);
    partial void Insertsuggestion(suggestion instance);
    partial void Updatesuggestion(suggestion instance);
    partial void Deletesuggestion(suggestion instance);
    partial void InsertTable(Table instance);
    partial void UpdateTable(Table instance);
    partial void DeleteTable(Table instance);
    partial void Insertuser_data(user_data instance);
    partial void Updateuser_data(user_data instance);
    partial void Deleteuser_data(user_data instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["AnalyticsConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<admin> admins
		{
			get
			{
				return this.GetTable<admin>();
			}
		}
		
		public System.Data.Linq.Table<user_game> user_games
		{
			get
			{
				return this.GetTable<user_game>();
			}
		}
		
		public System.Data.Linq.Table<game> games
		{
			get
			{
				return this.GetTable<game>();
			}
		}
		
		public System.Data.Linq.Table<suggestion> suggestions
		{
			get
			{
				return this.GetTable<suggestion>();
			}
		}
		
		public System.Data.Linq.Table<Table> Tables
		{
			get
			{
				return this.GetTable<Table>();
			}
		}
		
		public System.Data.Linq.Table<user_data> user_datas
		{
			get
			{
				return this.GetTable<user_data>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.admin")]
	public partial class admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _admin_id;
		
		private System.Nullable<int> _user_id;
		
		private EntityRef<user_data> _user_data;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onadmin_idChanging(int value);
    partial void Onadmin_idChanged();
    partial void Onuser_idChanging(System.Nullable<int> value);
    partial void Onuser_idChanged();
    #endregion
		
		public admin()
		{
			this._user_data = default(EntityRef<user_data>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_admin_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int admin_id
		{
			get
			{
				return this._admin_id;
			}
			set
			{
				if ((this._admin_id != value))
				{
					this.Onadmin_idChanging(value);
					this.SendPropertyChanging();
					this._admin_id = value;
					this.SendPropertyChanged("admin_id");
					this.Onadmin_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="Int")]
		public System.Nullable<int> user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					if (this._user_data.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_data_admin", Storage="_user_data", ThisKey="user_id", OtherKey="id", IsForeignKey=true)]
		public user_data user_data
		{
			get
			{
				return this._user_data.Entity;
			}
			set
			{
				user_data previousValue = this._user_data.Entity;
				if (((previousValue != value) 
							|| (this._user_data.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user_data.Entity = null;
						previousValue.admins.Remove(this);
					}
					this._user_data.Entity = value;
					if ((value != null))
					{
						value.admins.Add(this);
						this._user_id = value.id;
					}
					else
					{
						this._user_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("user_data");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.user_games")]
	public partial class user_game : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _user_id;
		
		private int _game_id;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void Onuser_idChanging(int value);
    partial void Onuser_idChanged();
    partial void Ongame_idChanging(int value);
    partial void Ongame_idChanged();
    #endregion
		
		public user_game()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="Int NOT NULL")]
		public int user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_game_id", DbType="Int NOT NULL")]
		public int game_id
		{
			get
			{
				return this._game_id;
			}
			set
			{
				if ((this._game_id != value))
				{
					this.Ongame_idChanging(value);
					this.SendPropertyChanging();
					this._game_id = value;
					this.SendPropertyChanged("game_id");
					this.Ongame_idChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.games")]
	public partial class game : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private System.Nullable<int> _UserID;
		
		private string _Api_path;
		
		private EntityRef<user_data> _user_data;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnUserIDChanging(System.Nullable<int> value);
    partial void OnUserIDChanged();
    partial void OnApi_pathChanging(string value);
    partial void OnApi_pathChanged();
    #endregion
		
		public game()
		{
			this._user_data = default(EntityRef<user_data>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int")]
		public System.Nullable<int> UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					if (this._user_data.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Api_path", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Api_path
		{
			get
			{
				return this._Api_path;
			}
			set
			{
				if ((this._Api_path != value))
				{
					this.OnApi_pathChanging(value);
					this.SendPropertyChanging();
					this._Api_path = value;
					this.SendPropertyChanged("Api_path");
					this.OnApi_pathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_data_game", Storage="_user_data", ThisKey="UserID", OtherKey="id", IsForeignKey=true)]
		public user_data user_data
		{
			get
			{
				return this._user_data.Entity;
			}
			set
			{
				user_data previousValue = this._user_data.Entity;
				if (((previousValue != value) 
							|| (this._user_data.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user_data.Entity = null;
						previousValue.games.Remove(this);
					}
					this._user_data.Entity = value;
					if ((value != null))
					{
						value.games.Add(this);
						this._UserID = value.id;
					}
					else
					{
						this._UserID = default(Nullable<int>);
					}
					this.SendPropertyChanged("user_data");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.suggestion")]
	public partial class suggestion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _message_box;
		
		private int _id;
		
		private int _user_id;
		
		private string _Full_name;
		
		private string _Email;
		
		private EntityRef<user_data> _user_data;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onmessage_boxChanging(string value);
    partial void Onmessage_boxChanged();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onuser_idChanging(int value);
    partial void Onuser_idChanged();
    partial void OnFull_nameChanging(string value);
    partial void OnFull_nameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public suggestion()
		{
			this._user_data = default(EntityRef<user_data>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_message_box", DbType="VarChar(50)")]
		public string message_box
		{
			get
			{
				return this._message_box;
			}
			set
			{
				if ((this._message_box != value))
				{
					this.Onmessage_boxChanging(value);
					this.SendPropertyChanging();
					this._message_box = value;
					this.SendPropertyChanged("message_box");
					this.Onmessage_boxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="Int NOT NULL")]
		public int user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					if (this._user_data.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Full_name", DbType="VarChar(50)")]
		public string Full_name
		{
			get
			{
				return this._Full_name;
			}
			set
			{
				if ((this._Full_name != value))
				{
					this.OnFull_nameChanging(value);
					this.SendPropertyChanging();
					this._Full_name = value;
					this.SendPropertyChanged("Full_name");
					this.OnFull_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_data_suggestion", Storage="_user_data", ThisKey="user_id", OtherKey="id", IsForeignKey=true)]
		public user_data user_data
		{
			get
			{
				return this._user_data.Entity;
			}
			set
			{
				user_data previousValue = this._user_data.Entity;
				if (((previousValue != value) 
							|| (this._user_data.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user_data.Entity = null;
						previousValue.suggestions.Remove(this);
					}
					this._user_data.Entity = value;
					if ((value != null))
					{
						value.suggestions.Add(this);
						this._user_id = value.id;
					}
					else
					{
						this._user_id = default(int);
					}
					this.SendPropertyChanged("user_data");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Table]")]
	public partial class Table : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Api_path;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnApi_pathChanging(string value);
    partial void OnApi_pathChanged();
    #endregion
		
		public Table()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Api_path", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Api_path
		{
			get
			{
				return this._Api_path;
			}
			set
			{
				if ((this._Api_path != value))
				{
					this.OnApi_pathChanging(value);
					this.SendPropertyChanging();
					this._Api_path = value;
					this.SendPropertyChanged("Api_path");
					this.OnApi_pathChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.user_data")]
	public partial class user_data : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _first_name;
		
		private string _last_name;
		
		private string _user_country;
		
		private string _user_application;
		
		private System.Data.Linq.Binary _user_image;
		
		private string _user_password;
		
		private string _user_email;
		
		private string _user_c_password;
		
		private EntitySet<admin> _admins;
		
		private EntitySet<game> _games;
		
		private EntitySet<suggestion> _suggestions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onfirst_nameChanging(string value);
    partial void Onfirst_nameChanged();
    partial void Onlast_nameChanging(string value);
    partial void Onlast_nameChanged();
    partial void Onuser_countryChanging(string value);
    partial void Onuser_countryChanged();
    partial void Onuser_applicationChanging(string value);
    partial void Onuser_applicationChanged();
    partial void Onuser_imageChanging(System.Data.Linq.Binary value);
    partial void Onuser_imageChanged();
    partial void Onuser_passwordChanging(string value);
    partial void Onuser_passwordChanged();
    partial void Onuser_emailChanging(string value);
    partial void Onuser_emailChanged();
    partial void Onuser_c_passwordChanging(string value);
    partial void Onuser_c_passwordChanged();
    #endregion
		
		public user_data()
		{
			this._admins = new EntitySet<admin>(new Action<admin>(this.attach_admins), new Action<admin>(this.detach_admins));
			this._games = new EntitySet<game>(new Action<game>(this.attach_games), new Action<game>(this.detach_games));
			this._suggestions = new EntitySet<suggestion>(new Action<suggestion>(this.attach_suggestions), new Action<suggestion>(this.detach_suggestions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_first_name", DbType="VarChar(50)")]
		public string first_name
		{
			get
			{
				return this._first_name;
			}
			set
			{
				if ((this._first_name != value))
				{
					this.Onfirst_nameChanging(value);
					this.SendPropertyChanging();
					this._first_name = value;
					this.SendPropertyChanged("first_name");
					this.Onfirst_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_last_name", DbType="VarChar(50)")]
		public string last_name
		{
			get
			{
				return this._last_name;
			}
			set
			{
				if ((this._last_name != value))
				{
					this.Onlast_nameChanging(value);
					this.SendPropertyChanging();
					this._last_name = value;
					this.SendPropertyChanged("last_name");
					this.Onlast_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_country", DbType="VarChar(50)")]
		public string user_country
		{
			get
			{
				return this._user_country;
			}
			set
			{
				if ((this._user_country != value))
				{
					this.Onuser_countryChanging(value);
					this.SendPropertyChanging();
					this._user_country = value;
					this.SendPropertyChanged("user_country");
					this.Onuser_countryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_application", DbType="VarChar(50)")]
		public string user_application
		{
			get
			{
				return this._user_application;
			}
			set
			{
				if ((this._user_application != value))
				{
					this.Onuser_applicationChanging(value);
					this.SendPropertyChanging();
					this._user_application = value;
					this.SendPropertyChanged("user_application");
					this.Onuser_applicationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_image", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary user_image
		{
			get
			{
				return this._user_image;
			}
			set
			{
				if ((this._user_image != value))
				{
					this.Onuser_imageChanging(value);
					this.SendPropertyChanging();
					this._user_image = value;
					this.SendPropertyChanged("user_image");
					this.Onuser_imageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_password", DbType="VarChar(50)")]
		public string user_password
		{
			get
			{
				return this._user_password;
			}
			set
			{
				if ((this._user_password != value))
				{
					this.Onuser_passwordChanging(value);
					this.SendPropertyChanging();
					this._user_password = value;
					this.SendPropertyChanged("user_password");
					this.Onuser_passwordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_email", DbType="VarChar(50)")]
		public string user_email
		{
			get
			{
				return this._user_email;
			}
			set
			{
				if ((this._user_email != value))
				{
					this.Onuser_emailChanging(value);
					this.SendPropertyChanging();
					this._user_email = value;
					this.SendPropertyChanged("user_email");
					this.Onuser_emailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_c_password", DbType="VarChar(50)")]
		public string user_c_password
		{
			get
			{
				return this._user_c_password;
			}
			set
			{
				if ((this._user_c_password != value))
				{
					this.Onuser_c_passwordChanging(value);
					this.SendPropertyChanging();
					this._user_c_password = value;
					this.SendPropertyChanged("user_c_password");
					this.Onuser_c_passwordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_data_admin", Storage="_admins", ThisKey="id", OtherKey="user_id")]
		public EntitySet<admin> admins
		{
			get
			{
				return this._admins;
			}
			set
			{
				this._admins.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_data_game", Storage="_games", ThisKey="id", OtherKey="UserID")]
		public EntitySet<game> games
		{
			get
			{
				return this._games;
			}
			set
			{
				this._games.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_data_suggestion", Storage="_suggestions", ThisKey="id", OtherKey="user_id")]
		public EntitySet<suggestion> suggestions
		{
			get
			{
				return this._suggestions;
			}
			set
			{
				this._suggestions.Assign(value);
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
		
		private void attach_admins(admin entity)
		{
			this.SendPropertyChanging();
			entity.user_data = this;
		}
		
		private void detach_admins(admin entity)
		{
			this.SendPropertyChanging();
			entity.user_data = null;
		}
		
		private void attach_games(game entity)
		{
			this.SendPropertyChanging();
			entity.user_data = this;
		}
		
		private void detach_games(game entity)
		{
			this.SendPropertyChanging();
			entity.user_data = null;
		}
		
		private void attach_suggestions(suggestion entity)
		{
			this.SendPropertyChanging();
			entity.user_data = this;
		}
		
		private void detach_suggestions(suggestion entity)
		{
			this.SendPropertyChanging();
			entity.user_data = null;
		}
	}
}
#pragma warning restore 1591
