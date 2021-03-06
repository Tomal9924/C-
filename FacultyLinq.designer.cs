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

namespace AllInfo
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Info")]
	public partial class FacultyLinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertlogin(login instance);
    partial void Updatelogin(login instance);
    partial void Deletelogin(login instance);
    partial void InsertFaculty_Info(Faculty_Info instance);
    partial void UpdateFaculty_Info(Faculty_Info instance);
    partial void DeleteFaculty_Info(Faculty_Info instance);
    #endregion
		
		public FacultyLinqDataContext() : 
				base(global::AllInfo.Properties.Settings.Default.InfoConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public FacultyLinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FacultyLinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FacultyLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FacultyLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<login> logins
		{
			get
			{
				return this.GetTable<login>();
			}
		}
		
		public System.Data.Linq.Table<Faculty_Info> Faculty_Infos
		{
			get
			{
				return this.GetTable<Faculty_Info>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.login")]
	public partial class login : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
		
		public login()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Faculty_Info")]
	public partial class Faculty_Info : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Email;
		
		private string _Contact;
		
		private string _Address;
		
		private string _Education;
		
		private string _Age;
		
		private string _Sex;
		
		private string _Religion;
		
		private string _PreferredCourse;
		
		private string _Depatment;
		
		private string _CreatePassword;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnContactChanging(string value);
    partial void OnContactChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnEducationChanging(string value);
    partial void OnEducationChanged();
    partial void OnAgeChanging(string value);
    partial void OnAgeChanged();
    partial void OnSexChanging(string value);
    partial void OnSexChanged();
    partial void OnReligionChanging(string value);
    partial void OnReligionChanged();
    partial void OnPreferredCourseChanging(string value);
    partial void OnPreferredCourseChanged();
    partial void OnDepatmentChanging(string value);
    partial void OnDepatmentChanged();
    partial void OnCreatePasswordChanging(string value);
    partial void OnCreatePasswordChanged();
    #endregion
		
		public Faculty_Info()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contact", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Contact
		{
			get
			{
				return this._Contact;
			}
			set
			{
				if ((this._Contact != value))
				{
					this.OnContactChanging(value);
					this.SendPropertyChanging();
					this._Contact = value;
					this.SendPropertyChanged("Contact");
					this.OnContactChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Education", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Education
		{
			get
			{
				return this._Education;
			}
			set
			{
				if ((this._Education != value))
				{
					this.OnEducationChanging(value);
					this.SendPropertyChanging();
					this._Education = value;
					this.SendPropertyChanged("Education");
					this.OnEducationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sex", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Sex
		{
			get
			{
				return this._Sex;
			}
			set
			{
				if ((this._Sex != value))
				{
					this.OnSexChanging(value);
					this.SendPropertyChanging();
					this._Sex = value;
					this.SendPropertyChanged("Sex");
					this.OnSexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Religion", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Religion
		{
			get
			{
				return this._Religion;
			}
			set
			{
				if ((this._Religion != value))
				{
					this.OnReligionChanging(value);
					this.SendPropertyChanging();
					this._Religion = value;
					this.SendPropertyChanged("Religion");
					this.OnReligionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PreferredCourse", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PreferredCourse
		{
			get
			{
				return this._PreferredCourse;
			}
			set
			{
				if ((this._PreferredCourse != value))
				{
					this.OnPreferredCourseChanging(value);
					this.SendPropertyChanging();
					this._PreferredCourse = value;
					this.SendPropertyChanged("PreferredCourse");
					this.OnPreferredCourseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Depatment", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Depatment
		{
			get
			{
				return this._Depatment;
			}
			set
			{
				if ((this._Depatment != value))
				{
					this.OnDepatmentChanging(value);
					this.SendPropertyChanging();
					this._Depatment = value;
					this.SendPropertyChanged("Depatment");
					this.OnDepatmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatePassword", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CreatePassword
		{
			get
			{
				return this._CreatePassword;
			}
			set
			{
				if ((this._CreatePassword != value))
				{
					this.OnCreatePasswordChanging(value);
					this.SendPropertyChanging();
					this._CreatePassword = value;
					this.SendPropertyChanged("CreatePassword");
					this.OnCreatePasswordChanged();
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
}
#pragma warning restore 1591
