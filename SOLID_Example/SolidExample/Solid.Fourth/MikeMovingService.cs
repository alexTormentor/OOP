using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Fourth
{
    public class MikeMovingService : IMoving
    {
        public void BusMoving()
        {
            //some logic
        }

        public void CarMoving()
        {
            //У Майка нет машины, он не может реализовать этот метод
            throw new NotImplementedException();
        }

        public void TramMoving()
        {
            //some logic
        }
    }
}
