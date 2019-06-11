using Application.DataAccess;
using Application.Common.ValueObjects.Supplier;
using Framework.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core.Common;
using Application.BusinessLogic.Supplier;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /// works
            ///IRepository < SupplierLicense > X = DaoFactory<SupplierLicense>.Instance.GetDAO(nameof(SupplierLicense));
            ///var y = X.Get(1);

            //var address = SupplierAddressManager.Instance.Get(1);

            //var supplierLicense = SupplierLicenseManager.Instance.CreateObject();
            //supplierLicense = SupplierLicenseManager.Instance.Get(1);
            //supplierLicense = SupplierLicenseManager.Instance.Get(2);

            var tasks = new[]
            {
                ////***** Failed thread testing **************/
                ////***** When each Dao runs in its own thread, then thread testings are OK ********/
               // Task.Factory.StartNew(() => GetLicense(1)),
               // Task.Factory.StartNew(() => GetLicense(2)),
               // Task.Factory.StartNew(() => GetLicense(3)),
                Task.Factory.StartNew(() => GetAddress(5000)),
                Task.Factory.StartNew(() => GetLicense(6000))
            };
            Task.WaitAll(tasks);

            ///////Works            
            ////var supplierLicenses = SupplierLicenseManager.Instance.FindByCriteria(
            ////        SupplierLicenseManager.FIND_LICENSE_BY_SUPPLIER,
            ////        new object[] { 5135 });

            ////foreach(SupplierLicense x in supplierLicenses)
            ////{
            ////    Console.WriteLine("ID {2}; Supplier ID {0}; License {1}", x.SupplierId, x.LicenseNo, x.Id);
            ////}

            Console.ReadKey();
        }

        static void GetLicense(int xx)
        {
            for (int id = xx; id<xx+1000; id++)
            {
                var obj = SupplierLicenseManager.Instance.Get(id);
                if (obj==null) obj = SupplierLicenseManager.Instance.CreateObject();
                Console.WriteLine("GetLicense() => ID {2}; Supplier ID {0}; License {1}", obj.SupplierId.ToString(), obj.LicenseNo, id);
            }
        }

        static void GetAddress(int xx)
        {
            for (int id = xx ; id < xx  + 1000; id++)
            {
                var obj = SupplierAddressManager.Instance.Get(id);
                if (obj == null) obj = SupplierAddressManager.Instance.CreateObject();
                Console.WriteLine("GetAddress() => ID {0}; Supplier ID {1}; Address1 {2}; Zip {3}", id, obj.SupplierId.ToString(), obj.AddressLine1, obj.ZipCode);
            }
        }
    }
}
