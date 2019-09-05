using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial3_VTNZ
{
    public abstract class TestingStation
    {
        protected string z_storeLocation;
        protected string z_storeName;
        protected string z_storeHours;
        
        public TestingStation(string storeLocation, string storeName, string storeHours)
        {
            
            z_storeLocation = storeLocation;
            z_storeName = storeName;
            z_storeHours = storeHours;
        }

        public string StoreLocation
        {
            get => z_storeLocation;
            set => z_storeLocation = value;
        }

        public string StoreName
        {
            get => z_storeName;
            set => z_storeName = value;
        }

        public string StoreHours
        {
            get => z_storeHours;
            set => z_storeHours = value;
        }

        public abstract string ShowStoreDetails();
    }
}