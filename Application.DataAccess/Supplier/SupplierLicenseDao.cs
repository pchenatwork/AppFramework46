using Application.Common.ValueObjects.Supplier;
using Framework.Core.DataAccess;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Application.DataAccess.Supplier
{
    public class SupplierLicenseDao : DaoBase<SupplierLicense>
    {

        #region	Constants
        // *************************************************************************
        //				 constants
        // *************************************************************************
        public const string FIND_LICENSE_BY_SUPPLIER = "FindLicenseBySupplier";
        public const string FIND_LICENSE_BY_STATUS = "FindLicenseByStatus";
        public const string FIND_LICENSE_BY_BATCHJOB = "FindLicenseByBatchJob";
        #endregion Constants

        #region	Constructors
        // *************************************************************************
        //				 Constructors
        // *************************************************************************
        /// <summary>
        /// class constructor 
        /// initializes logging
        /// </summary>
        static SupplierLicenseDao()
        {
            //_logger = LoggingUtility.GetLogger(typeof(LicenseDao).FullName);
        }

        ///	<summary>
        ///	default	constructor	
        ///	inits with default
        ///	</summary>
        public SupplierLicenseDao(DataSourceSettingObject dataSource) : base(dataSource)
        {
        }

        #endregion Constructors
        public override int Create(SupplierLicense newObject)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<SupplierLicense> FindByCriteria(string finderType, object[] criteria)
        {
            String methodName = "FindByCriteria() - " + finderType + " - " + _dataSource.Value.Name;
            ////if (_logger.IsDebugEnabled)
            ////{
            ////    LoggingUtility.logMethodEntry(_logger, methodName);
            ////}

            try
            {
                ////SqlTransaction transaction = (SqlTransaction)this.GetContextTransaction(dataSource);
                ////if (transaction == null) // Not in a transaction.
                ////{
                var x = _dataSource.Value;
                    using (SqlConnection connection = (SqlConnection)_dataSource.Value.DbConnection)
                    {
                        switch ((string)finderType)
                        {
                            case FIND_LICENSE_BY_SUPPLIER:
                                {
                                    int supplierId = (int)criteria[0];
                                    SqlParameter[] parameters = new SqlParameter[2];

                                    parameters[0] = new SqlParameter("@supplierId", SqlDbType.Int)
                                    {
                                        Value = supplierId
                                    };
                                    parameters[1] = new SqlParameter("@ReturnValue", SqlDbType.Int)
                                    {
                                        Direction = ParameterDirection.ReturnValue
                                    };


                                XmlReader reader = SqlHelper.ExecuteXmlReader(connection, CommandType.StoredProcedure, "FindLicenseXml_xx", parameters);

                                    return DeserializeCollection(reader);
                                }
                            default:
                                return null;
                        }
                    }
                ////}
                ////else
                ////{
                ////    switch ((string)finderType)
                ////    {
                ////        case FIND_LICENSE_BY_SUPPLIER:
                ////            {
                ////                int supplierId = (int)criteria[0];
                ////                XmlReader reader = FindLicenseXml(transaction,
                ////                    supplierId);
                ////                return DeserializeCollection(reader);
                ////            }
                ////        case FIND_LICENSE_BY_STATUS:
                ////            {
                ////                int status = (int)criteria[0];
                ////                XmlReader reader = FindLicenseByStatusXml(transaction,
                ////                    status);
                ////                return DeserializeCollection(reader);
                ////            }
                ////        case FIND_LICENSE_BY_BATCHJOB:
                ////            {
                ////                string jobName = (string)criteria[0];
                ////                int dueDate = (int)criteria[1];
                ////                XmlReader reader = FindLicenseByBatchJobXml(transaction,
                ////                    jobName, dueDate);
                ////                return DeserializeCollection(reader);
                ////            }
                ////        default:
                ////            return null;
                ////    }
                ////}
            }
            catch (System.Exception e)
            {
                ////_logger.Error(methodName, e);
                return null;
            }
        }

        public override SupplierLicense Get(int id)
        {
            using (SqlConnection connection = (SqlConnection)_dataSource.Value.DbConnection)
            {
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                parameters[0].Value = id;
                parameters[1] = new SqlParameter("@ReturnValue", SqlDbType.Int);
                parameters[1].Direction = ParameterDirection.ReturnValue;

                XmlReader reader = SqlHelper.ExecuteXmlReader(connection, CommandType.StoredProcedure, "GetSupplierLicenseXml_XX", parameters);
                return Deserialize(reader);
            }
        }

        public override IEnumerable<SupplierLicense> GetAll()
        {
            throw new NotImplementedException();
        }

        public override bool Update(SupplierLicense newObject)
        {
            throw new NotImplementedException();
        }
    }
}
