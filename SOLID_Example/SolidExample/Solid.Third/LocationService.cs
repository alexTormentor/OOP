using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Third
{
    public class LocationService : ILocationService
    {
        public string GetLocationShop()
        {
            //нет имплементации, т к у онлайн магазина нет координат
            throw new NotImplementedException();
        }

        public string GetNameShop()
        {
            //нет имплементации, т к у онлайн магазина нет координат
            throw new NotImplementedException();
        }
    }
}
