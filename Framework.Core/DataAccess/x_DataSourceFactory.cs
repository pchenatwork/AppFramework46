using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PC.Framework.Core.DataAccess
{
    /// <summary>
    /// DataSourceFactory returns DataSource objects.
    /// Maintains/refreshes internal cache of DataSources.
    /// Config info retrieved from SCA.VAS.DataAccess.dll.config
    /// </summary>
    ////public sealed class x_DataSourceFactory
    ////{
    ////    #region Private Variables and Constants

    ////    private static readonly x_DataSourceFactory _instance = new x_DataSourceFactory();

    ////    private static Hashtable _dataSources = null;
    ////    private static Hashtable _dataProviders = null;
    ////    private static IDataSource _defaultDataSource = null;

    ////    #endregion

    ////    #region Constructors
    ////    //only static methods - no instance can be created.
    ////    private x_DataSourceFactory()
    ////    {
    ////    }

    ////    static x_DataSourceFactory()
    ////    {
    ////    }
    ////    #endregion

    ////    public x_DataSourceFactory Instance => _instance;

    ////    #region Public Methods

    ////    public static IDataSource CreateInstance()
    ////    {
    ////        return null; // CreateInstance(DEFAULT_DATASOURCE_NAME);
    ////    }

    ////    public static IDataSource CreateInstance(string dataSourceName)
    ////    {
    ////        IDataSource ds = null;

    ////        if (dataSourceName.Equals("DEFAULT_DATASOURCE_NAME"))
    ////            ds = _defaultDataSource;
    ////        else
    ////            ds = _dataSources[dataSourceName] as DataSource;

    ////        if (ds == null)
    ////        {
    ////            //TODO: specialize the exception, perhaps DataSourceNotFoundException
    ////            throw new ApplicationException("DataSource with name '" + dataSourceName + "' not found.");
    ////        }
    ////        return ds;
    ////    }

    ////    #endregion

    ////    #region Private Methods
    ////    /*
    ////    private static void LoadCache()
    ////    {
    ////        try
    ////        {
    ////            dataAccessSettings settings =
    ////                (dataAccessSettings)ConfigurationManager.GetSection("dataAccessSettings");

    ////            // Cache the dataProviders.
    ////            _dataProviders = new Hashtable();
    ////            foreach (dataProvider dp in settings.dataProviders)
    ////            {
    ////                _dataProviders.Add(dp.name, dp);
    ////            }

    ////            var dataAccessAssemblyPath = AppDomain.CurrentDomain.BaseDirectory;
    ////            if (!dataAccessAssemblyPath.EndsWith("\\"))
    ////            {
    ////                dataAccessAssemblyPath += "\\";
    ////            }

    ////            // Cache the dataSources.
    ////            _dataSources = new Hashtable();
    ////            foreach (dataSource ds in settings.dataSources)
    ////            {
    ////                dataProvider provider = (dataProvider)_dataProviders[ds.provider];
    ////                DataSource dataSource =
    ////                    new DataSource(ds.name, provider.connectionType, ds.connectionString,
    ////                    dataAccessAssemblyPath + ds.dataAccessAssembly, ds.encryption);
    ////                _dataSources.Add(dataSource.Name, dataSource);

    ////                if (ds.isDefault)
    ////                {
    ////                    _defaultDataSource = dataSource;
    ////                }
    ////            }
    ////        }
    ////        catch (Exception e)
    ////        {
    ////            throw new ApplicationException("Error loading cache from config.", e);
    ////        }
    ////    }

    ////****/
    ////    #endregion

    ////}
}

