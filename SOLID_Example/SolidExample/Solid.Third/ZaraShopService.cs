using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Third
{
    public class ZaraShopService : IShopService
    {
        public string GetLocationShop()
        {
            return "г. Волгоград, ул. Пушкина, д. Колотушкина";
        }
    }

    public class ZaraLocation : ILocationService
    {
        public string GetNameShop()
        {
            return "Zara";
        }
    }
}
