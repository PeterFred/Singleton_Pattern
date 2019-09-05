using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial3_VTNZ
{
    public sealed class VTNZ : TestingStation
    {
        private static int _qty;
        private static int _totalQty;
        private List<CarInspection> _serviceList;

        private static VTNZ _uniqueInstance; 

        private VTNZ(string storeName, string storeLocation, string storeHours) : base(storeName, storeLocation, storeHours)
        {
            _serviceList = new List<CarInspection>();
        }

        public static VTNZ getInstance(string storeName, string storeLocation, string storeHours)
        {
            return _uniqueInstance ?? (_uniqueInstance = new VTNZ(storeName, storeLocation, storeHours));

            //if (_uniqueInstance == null)
            //{
            //    _uniqueInstance = new VTNZ(storeName, storeLocation, storeHours);
            //}
            //return _uniqueInstance;
        }

        public static int TotalQty
        {
            get => _totalQty;
        }

        public string ShowServiceDetails(CarInspection inspection)
        {
            string serviceDetails =
                "Inspection Type " + inspection.CarInspectionName + Environment.NewLine +
                "Inspection Price "+inspection.CarInspectionPrice.ToString("C");
            return serviceDetails;
        }

        public decimal ShowTotalServicePrice(CarInspection inspection)
        {
            return (_qty * inspection.CarInspectionPrice);
        }

        public override string ShowStoreDetails()
        {
            return base.StoreName + Environment.NewLine + base.StoreLocation + Environment.NewLine + base.StoreHours;
        }

        public void addService(CarInspection service)
        {
            _serviceList.Add(service);
        }

        public List<CarInspection> GetService()
        {
            return _serviceList;
        }

        public void bookService(int quantity)
        {
            _qty = quantity;
            _totalQty += _qty;
        }
    }
}