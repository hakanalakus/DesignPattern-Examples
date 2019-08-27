using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface IAdress
    {
        string GetAdress();
        string GetDistrict();
        string GetCity();
        string GetCountry();

    }
}
