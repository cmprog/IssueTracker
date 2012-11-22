﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IssueTracker.Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="IssueTracker")]
	public partial class IssueTrackerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertIssue(Issue instance);
    partial void UpdateIssue(Issue instance);
    partial void DeleteIssue(Issue instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertIssueLabel(IssueLabel instance);
    partial void UpdateIssueLabel(IssueLabel instance);
    partial void DeleteIssueLabel(IssueLabel instance);
    partial void InsertLabel(Label instance);
    partial void UpdateLabel(Label instance);
    partial void DeleteLabel(Label instance);
    partial void InsertMilestone(Milestone instance);
    partial void UpdateMilestone(Milestone instance);
    partial void DeleteMilestone(Milestone instance);
    partial void InsertProject(Project instance);
    partial void UpdateProject(Project instance);
    partial void DeleteProject(Project instance);
    #endregion
		
		public IssueTrackerDataContext() : 
				base(global::IssueTracker.Data.Properties.Settings.Default.IssueTrackerConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public IssueTrackerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IssueTrackerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IssueTrackerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IssueTrackerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Issue> Issues
		{
			get
			{
				return this.GetTable<Issue>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<IssueLabel> IssueLabels
		{
			get
			{
				return this.GetTable<IssueLabel>();
			}
		}
		
		public System.Data.Linq.Table<Label> Labels
		{
			get
			{
				return this.GetTable<Label>();
			}
		}
		
		public System.Data.Linq.Table<Milestone> Milestones
		{
			get
			{
				return this.GetTable<Milestone>();
			}
		}
		
		public System.Data.Linq.Table<Project> Projects
		{
			get
			{
				return this.GetTable<Project>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Issue")]
	public partial class Issue : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _ProjectId;
		
		private System.Nullable<int> _AssignedUserId;
		
		private int _OpenedByUserId;
		
		private System.Nullable<int> _MilestoneId;
		
		private string _Title;
		
		private string _Body;
		
		private EntitySet<IssueLabel> _IssueLabels;
		
		private EntityRef<User> _User;
		
		private EntityRef<User> _User1;
		
		private EntityRef<Milestone> _Milestone;
		
		private EntityRef<Project> _Project;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnProjectIdChanging(int value);
    partial void OnProjectIdChanged();
    partial void OnAssignedUserIdChanging(System.Nullable<int> value);
    partial void OnAssignedUserIdChanged();
    partial void OnOpenedByUserIdChanging(int value);
    partial void OnOpenedByUserIdChanged();
    partial void OnMilestoneIdChanging(System.Nullable<int> value);
    partial void OnMilestoneIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnBodyChanging(string value);
    partial void OnBodyChanged();
    #endregion
		
		public Issue()
		{
			this._IssueLabels = new EntitySet<IssueLabel>(new Action<IssueLabel>(this.attach_IssueLabels), new Action<IssueLabel>(this.detach_IssueLabels));
			this._User = default(EntityRef<User>);
			this._User1 = default(EntityRef<User>);
			this._Milestone = default(EntityRef<Milestone>);
			this._Project = default(EntityRef<Project>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectId", DbType="Int NOT NULL")]
		public int ProjectId
		{
			get
			{
				return this._ProjectId;
			}
			set
			{
				if ((this._ProjectId != value))
				{
					if (this._Project.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProjectIdChanging(value);
					this.SendPropertyChanging();
					this._ProjectId = value;
					this.SendPropertyChanged("ProjectId");
					this.OnProjectIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssignedUserId", DbType="Int")]
		public System.Nullable<int> AssignedUserId
		{
			get
			{
				return this._AssignedUserId;
			}
			set
			{
				if ((this._AssignedUserId != value))
				{
					if (this._User1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAssignedUserIdChanging(value);
					this.SendPropertyChanging();
					this._AssignedUserId = value;
					this.SendPropertyChanged("AssignedUserId");
					this.OnAssignedUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OpenedByUserId", DbType="Int NOT NULL")]
		public int OpenedByUserId
		{
			get
			{
				return this._OpenedByUserId;
			}
			set
			{
				if ((this._OpenedByUserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOpenedByUserIdChanging(value);
					this.SendPropertyChanging();
					this._OpenedByUserId = value;
					this.SendPropertyChanged("OpenedByUserId");
					this.OnOpenedByUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MilestoneId", DbType="Int")]
		public System.Nullable<int> MilestoneId
		{
			get
			{
				return this._MilestoneId;
			}
			set
			{
				if ((this._MilestoneId != value))
				{
					if (this._Milestone.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMilestoneIdChanging(value);
					this.SendPropertyChanging();
					this._MilestoneId = value;
					this.SendPropertyChanged("MilestoneId");
					this.OnMilestoneIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(256) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Body", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this.OnBodyChanging(value);
					this.SendPropertyChanging();
					this._Body = value;
					this.SendPropertyChanged("Body");
					this.OnBodyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Issue_IssueLabel", Storage="_IssueLabels", ThisKey="Id", OtherKey="IssueId")]
		public EntitySet<IssueLabel> IssueLabels
		{
			get
			{
				return this._IssueLabels;
			}
			set
			{
				this._IssueLabels.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Issue", Storage="_User", ThisKey="OpenedByUserId", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Issues.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Issues.Add(this);
						this._OpenedByUserId = value.Id;
					}
					else
					{
						this._OpenedByUserId = default(int);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Issue1", Storage="_User1", ThisKey="AssignedUserId", OtherKey="Id", IsForeignKey=true)]
		public User User1
		{
			get
			{
				return this._User1.Entity;
			}
			set
			{
				User previousValue = this._User1.Entity;
				if (((previousValue != value) 
							|| (this._User1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User1.Entity = null;
						previousValue.Issues1.Remove(this);
					}
					this._User1.Entity = value;
					if ((value != null))
					{
						value.Issues1.Add(this);
						this._AssignedUserId = value.Id;
					}
					else
					{
						this._AssignedUserId = default(Nullable<int>);
					}
					this.SendPropertyChanged("User1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Milestone_Issue", Storage="_Milestone", ThisKey="MilestoneId", OtherKey="Id", IsForeignKey=true)]
		public Milestone Milestone
		{
			get
			{
				return this._Milestone.Entity;
			}
			set
			{
				Milestone previousValue = this._Milestone.Entity;
				if (((previousValue != value) 
							|| (this._Milestone.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Milestone.Entity = null;
						previousValue.Issues.Remove(this);
					}
					this._Milestone.Entity = value;
					if ((value != null))
					{
						value.Issues.Add(this);
						this._MilestoneId = value.Id;
					}
					else
					{
						this._MilestoneId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Milestone");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Project_Issue", Storage="_Project", ThisKey="ProjectId", OtherKey="Id", IsForeignKey=true)]
		public Project Project
		{
			get
			{
				return this._Project.Entity;
			}
			set
			{
				Project previousValue = this._Project.Entity;
				if (((previousValue != value) 
							|| (this._Project.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Project.Entity = null;
						previousValue.Issues.Remove(this);
					}
					this._Project.Entity = value;
					if ((value != null))
					{
						value.Issues.Add(this);
						this._ProjectId = value.Id;
					}
					else
					{
						this._ProjectId = default(int);
					}
					this.SendPropertyChanged("Project");
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
		
		private void attach_IssueLabels(IssueLabel entity)
		{
			this.SendPropertyChanging();
			entity.Issue = this;
		}
		
		private void detach_IssueLabels(IssueLabel entity)
		{
			this.SendPropertyChanging();
			entity.Issue = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Username;
		
		private EntitySet<Issue> _Issues;
		
		private EntitySet<Issue> _Issues1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    #endregion
		
		public User()
		{
			this._Issues = new EntitySet<Issue>(new Action<Issue>(this.attach_Issues), new Action<Issue>(this.detach_Issues));
			this._Issues1 = new EntitySet<Issue>(new Action<Issue>(this.attach_Issues1), new Action<Issue>(this.detach_Issues1));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(64) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(64) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(128) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Issue", Storage="_Issues", ThisKey="Id", OtherKey="OpenedByUserId")]
		public EntitySet<Issue> Issues
		{
			get
			{
				return this._Issues;
			}
			set
			{
				this._Issues.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Issue1", Storage="_Issues1", ThisKey="Id", OtherKey="AssignedUserId")]
		public EntitySet<Issue> Issues1
		{
			get
			{
				return this._Issues1;
			}
			set
			{
				this._Issues1.Assign(value);
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
		
		private void attach_Issues(Issue entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Issues(Issue entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_Issues1(Issue entity)
		{
			this.SendPropertyChanging();
			entity.User1 = this;
		}
		
		private void detach_Issues1(Issue entity)
		{
			this.SendPropertyChanging();
			entity.User1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.IssueLabel")]
	public partial class IssueLabel : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IssueId;
		
		private int _LabelId;
		
		private EntityRef<Issue> _Issue;
		
		private EntityRef<Label> _Label;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIssueIdChanging(int value);
    partial void OnIssueIdChanged();
    partial void OnLabelIdChanging(int value);
    partial void OnLabelIdChanged();
    #endregion
		
		public IssueLabel()
		{
			this._Issue = default(EntityRef<Issue>);
			this._Label = default(EntityRef<Label>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IssueId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IssueId
		{
			get
			{
				return this._IssueId;
			}
			set
			{
				if ((this._IssueId != value))
				{
					if (this._Issue.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIssueIdChanging(value);
					this.SendPropertyChanging();
					this._IssueId = value;
					this.SendPropertyChanged("IssueId");
					this.OnIssueIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LabelId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int LabelId
		{
			get
			{
				return this._LabelId;
			}
			set
			{
				if ((this._LabelId != value))
				{
					if (this._Label.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLabelIdChanging(value);
					this.SendPropertyChanging();
					this._LabelId = value;
					this.SendPropertyChanged("LabelId");
					this.OnLabelIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Issue_IssueLabel", Storage="_Issue", ThisKey="IssueId", OtherKey="Id", IsForeignKey=true)]
		public Issue Issue
		{
			get
			{
				return this._Issue.Entity;
			}
			set
			{
				Issue previousValue = this._Issue.Entity;
				if (((previousValue != value) 
							|| (this._Issue.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Issue.Entity = null;
						previousValue.IssueLabels.Remove(this);
					}
					this._Issue.Entity = value;
					if ((value != null))
					{
						value.IssueLabels.Add(this);
						this._IssueId = value.Id;
					}
					else
					{
						this._IssueId = default(int);
					}
					this.SendPropertyChanged("Issue");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Label_IssueLabel", Storage="_Label", ThisKey="LabelId", OtherKey="Id", IsForeignKey=true)]
		public Label Label
		{
			get
			{
				return this._Label.Entity;
			}
			set
			{
				Label previousValue = this._Label.Entity;
				if (((previousValue != value) 
							|| (this._Label.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Label.Entity = null;
						previousValue.IssueLabels.Remove(this);
					}
					this._Label.Entity = value;
					if ((value != null))
					{
						value.IssueLabels.Add(this);
						this._LabelId = value.Id;
					}
					else
					{
						this._LabelId = default(int);
					}
					this.SendPropertyChanged("Label");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Label")]
	public partial class Label : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Description;
		
		private int _ColorValue;
		
		private EntitySet<IssueLabel> _IssueLabels;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnColorValueChanging(int value);
    partial void OnColorValueChanged();
    #endregion
		
		public Label()
		{
			this._IssueLabels = new EntitySet<IssueLabel>(new Action<IssueLabel>(this.attach_IssueLabels), new Action<IssueLabel>(this.detach_IssueLabels));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(64) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(256) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ColorValue", DbType="Int NOT NULL")]
		public int ColorValue
		{
			get
			{
				return this._ColorValue;
			}
			set
			{
				if ((this._ColorValue != value))
				{
					this.OnColorValueChanging(value);
					this.SendPropertyChanging();
					this._ColorValue = value;
					this.SendPropertyChanged("ColorValue");
					this.OnColorValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Label_IssueLabel", Storage="_IssueLabels", ThisKey="Id", OtherKey="LabelId")]
		public EntitySet<IssueLabel> IssueLabels
		{
			get
			{
				return this._IssueLabels;
			}
			set
			{
				this._IssueLabels.Assign(value);
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
		
		private void attach_IssueLabels(IssueLabel entity)
		{
			this.SendPropertyChanging();
			entity.Label = this;
		}
		
		private void detach_IssueLabels(IssueLabel entity)
		{
			this.SendPropertyChanging();
			entity.Label = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Milestone")]
	public partial class Milestone : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _ProjectId;
		
		private System.Nullable<System.DateTime> _DueDate;
		
		private string _Title;
		
		private string _Description;
		
		private EntitySet<Issue> _Issues;
		
		private EntityRef<Project> _Project;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnProjectIdChanging(int value);
    partial void OnProjectIdChanged();
    partial void OnDueDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDueDateChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public Milestone()
		{
			this._Issues = new EntitySet<Issue>(new Action<Issue>(this.attach_Issues), new Action<Issue>(this.detach_Issues));
			this._Project = default(EntityRef<Project>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectId", DbType="Int NOT NULL")]
		public int ProjectId
		{
			get
			{
				return this._ProjectId;
			}
			set
			{
				if ((this._ProjectId != value))
				{
					if (this._Project.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProjectIdChanging(value);
					this.SendPropertyChanging();
					this._ProjectId = value;
					this.SendPropertyChanged("ProjectId");
					this.OnProjectIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DueDate", DbType="Date")]
		public System.Nullable<System.DateTime> DueDate
		{
			get
			{
				return this._DueDate;
			}
			set
			{
				if ((this._DueDate != value))
				{
					this.OnDueDateChanging(value);
					this.SendPropertyChanging();
					this._DueDate = value;
					this.SendPropertyChanged("DueDate");
					this.OnDueDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(256) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Milestone_Issue", Storage="_Issues", ThisKey="Id", OtherKey="MilestoneId")]
		public EntitySet<Issue> Issues
		{
			get
			{
				return this._Issues;
			}
			set
			{
				this._Issues.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Project_Milestone", Storage="_Project", ThisKey="ProjectId", OtherKey="Id", IsForeignKey=true)]
		public Project Project
		{
			get
			{
				return this._Project.Entity;
			}
			set
			{
				Project previousValue = this._Project.Entity;
				if (((previousValue != value) 
							|| (this._Project.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Project.Entity = null;
						previousValue.Milestones.Remove(this);
					}
					this._Project.Entity = value;
					if ((value != null))
					{
						value.Milestones.Add(this);
						this._ProjectId = value.Id;
					}
					else
					{
						this._ProjectId = default(int);
					}
					this.SendPropertyChanged("Project");
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
		
		private void attach_Issues(Issue entity)
		{
			this.SendPropertyChanging();
			entity.Milestone = this;
		}
		
		private void detach_Issues(Issue entity)
		{
			this.SendPropertyChanging();
			entity.Milestone = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Project")]
	public partial class Project : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Description;
		
		private EntitySet<Issue> _Issues;
		
		private EntitySet<Milestone> _Milestones;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public Project()
		{
			this._Issues = new EntitySet<Issue>(new Action<Issue>(this.attach_Issues), new Action<Issue>(this.detach_Issues));
			this._Milestones = new EntitySet<Milestone>(new Action<Milestone>(this.attach_Milestones), new Action<Milestone>(this.detach_Milestones));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(128) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Project_Issue", Storage="_Issues", ThisKey="Id", OtherKey="ProjectId")]
		public EntitySet<Issue> Issues
		{
			get
			{
				return this._Issues;
			}
			set
			{
				this._Issues.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Project_Milestone", Storage="_Milestones", ThisKey="Id", OtherKey="ProjectId")]
		public EntitySet<Milestone> Milestones
		{
			get
			{
				return this._Milestones;
			}
			set
			{
				this._Milestones.Assign(value);
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
		
		private void attach_Issues(Issue entity)
		{
			this.SendPropertyChanging();
			entity.Project = this;
		}
		
		private void detach_Issues(Issue entity)
		{
			this.SendPropertyChanging();
			entity.Project = null;
		}
		
		private void attach_Milestones(Milestone entity)
		{
			this.SendPropertyChanging();
			entity.Project = this;
		}
		
		private void detach_Milestones(Milestone entity)
		{
			this.SendPropertyChanging();
			entity.Project = null;
		}
	}
}
#pragma warning restore 1591
