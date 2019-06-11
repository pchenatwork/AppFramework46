using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace PC.Framework.Core.DataAccess
{
    /// <summary>
    /// DataSource is a facade class and represents a certain database.
    /// Produces connections.
    /// </summary>
    ////class DataSource : IDataSource
    ////{
    ////    // refactor with lazy loading
    ////    private string _name = string.Empty;
    ////    private string _connectionString = string.Empty;
    ////    private string _connectionTypeName = string.Empty;
    ////    private string _daoAssemblyName = string.Empty;
    ////    private string _encryption = string.Empty;
    ////    //private IDbConnection _templateConnection = null;
    ////    //private Assembly _daoAssembly = null;

    ////    #region Constructors
    ////    public DataSource(string name, string connectionTypeName, string connectionString,
    ////        string daoAssembly, string encryption)
    ////    {
    ////        _name = name;
    ////        _connectionString = connectionString;
    ////        _connectionTypeName = connectionTypeName;
    ////        _daoAssemblyName = daoAssembly;
    ////        _encryption = encryption;
    ////        /*
    ////        ////if (encryption != null && encryption.Trim().Length > 0)
    ////        ////{
    ////        ////    _connectionString = CryptUtility.Decrypt(connectionString, encryption);
    ////        ////}
    ////        ////else
    ////            _connectionString = connectionString;

    ////        Type connectionType = Type.GetType(connectionTypeName);
    ////        _templateConnection = (IDbConnection)Activator.CreateInstance(connectionType);
    ////        _daoAssembly = Assembly.LoadFrom(daoAssembly);
    ////        */
    ////    }
    ////    #endregion

    ////    #region Properties
    ////    /// <summary>
    ////    /// Property Name (string)
    ////    /// </summary>
    ////    public string Name
    ////    {
    ////        get
    ////        {
    ////            return this._name;
    ////        }
    ////    }
    ////    #endregion

    ////    #region Public Methods

    ////    public IDbConnection CreateConnection()
    ////    {
    ////        IDbConnection dbCon = (IDbConnection)Activator.CreateInstance(Type.GetType(_connectionTypeName));
    ////        //IDbConnection dbCon = (IDbConnection)((ICloneable)_templateConnection).Clone();
    ////        dbCon.ConnectionString = _connectionString;
    ////        return dbCon;
    ////    }

    ////    public IDataAccessObject CreateDataAccessObject(string DaoClassName)
    ////    {
    ////        //IDataAccessObject dao = (IDataAccessObject)_daoAssembly.CreateInstance(DaoClassName);
    ////        //return dao;
    ////        return (IDataAccessObject)Assembly.LoadFrom(_daoAssemblyName).CreateInstance(DaoClassName);
    ////    }

    ////    #endregion
    ////}
}

