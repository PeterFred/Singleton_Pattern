using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial3_VTNZ
{
    public class ServiceWrapper : IService
    {
        private CarInspection _carInspection;

        public ServiceWrapper(string name, decimal price)
        {
            _carInspection = new CarInspection();
            _carInspection.CarInspectionName = name;
            _carInspection.CarInspectionPrice = price;
        }

        //public CarInspection CarInspection
        //{
        //    get => _carInspection;
        //}
        
        string IService.ServiceName
        {
            get => _carInspection.CarInspectionName;
        }

        decimal IService.ServicePrice
        {
            get => _carInspection.CarInspectionPrice;
        }
    }
}