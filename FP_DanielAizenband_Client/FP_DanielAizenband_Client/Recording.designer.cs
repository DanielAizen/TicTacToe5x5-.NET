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

namespace FP_DanielAizenband_Client
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="RecordsDB")]
	public partial class RecordingDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTblRecord(TblRecord instance);
    partial void UpdateTblRecord(TblRecord instance);
    partial void DeleteTblRecord(TblRecord instance);
    #endregion
		
		public RecordingDataContext() : 
				base(global::FP_DanielAizenband_Client.Properties.Settings.Default.RecordsDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public RecordingDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RecordingDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RecordingDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RecordingDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TblRecord> TblRecords
		{
			get
			{
				return this.GetTable<TblRecord>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TblRecords")]
	public partial class TblRecord : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _NumOfTurns;
		
		private string _PlayerMoves;
		
		private int _PlayerId;
		
		private string _Winner;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNumOfTurnsChanging(int value);
    partial void OnNumOfTurnsChanged();
    partial void OnPlayerMovesChanging(string value);
    partial void OnPlayerMovesChanged();
    partial void OnPlayerIdChanging(int value);
    partial void OnPlayerIdChanged();
    partial void OnWinnerChanging(string value);
    partial void OnWinnerChanged();
    #endregion
		
		public TblRecord()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumOfTurns", DbType="Int NOT NULL")]
		public int NumOfTurns
		{
			get
			{
				return this._NumOfTurns;
			}
			set
			{
				if ((this._NumOfTurns != value))
				{
					this.OnNumOfTurnsChanging(value);
					this.SendPropertyChanging();
					this._NumOfTurns = value;
					this.SendPropertyChanged("NumOfTurns");
					this.OnNumOfTurnsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerMoves", DbType="Char(80) NOT NULL", CanBeNull=false)]
		public string PlayerMoves
		{
			get
			{
				return this._PlayerMoves;
			}
			set
			{
				if ((this._PlayerMoves != value))
				{
					this.OnPlayerMovesChanging(value);
					this.SendPropertyChanging();
					this._PlayerMoves = value;
					this.SendPropertyChanged("PlayerMoves");
					this.OnPlayerMovesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerId", DbType="Int NOT NULL")]
		public int PlayerId
		{
			get
			{
				return this._PlayerId;
			}
			set
			{
				if ((this._PlayerId != value))
				{
					this.OnPlayerIdChanging(value);
					this.SendPropertyChanging();
					this._PlayerId = value;
					this.SendPropertyChanged("PlayerId");
					this.OnPlayerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Winner", DbType="Char(30) NOT NULL", CanBeNull=false)]
		public string Winner
		{
			get
			{
				return this._Winner;
			}
			set
			{
				if ((this._Winner != value))
				{
					this.OnWinnerChanging(value);
					this.SendPropertyChanging();
					this._Winner = value;
					this.SendPropertyChanged("Winner");
					this.OnWinnerChanged();
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
