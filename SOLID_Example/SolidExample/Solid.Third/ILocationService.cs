using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Third
{
    public interface ILocationService : IShopService
    {
        public string GetLocationShop();
    }
}
