using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Second
{
    public class CashPayment : IPaymentService
    {
        public void Pay(string type)
        {
            if (type == "cash")
            {
                //payment by cash
            }
        }
    }
}
