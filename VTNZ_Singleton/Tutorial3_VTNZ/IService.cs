using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial3_VTNZ
{
    public interface IService
    {
        decimal ServicePrice { get; }
        string ServiceName { get;}
    }
}