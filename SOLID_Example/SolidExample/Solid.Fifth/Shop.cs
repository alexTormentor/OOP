using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Fifth
{
    public class Shop
    {
        private ICash Cash;

        public Shop(ICash cash)
        {
            Cash = cash;
        }

        public void DoPayment(int amount)
        {
            Cash.DoTransaction(amount);
        }
    }
}
