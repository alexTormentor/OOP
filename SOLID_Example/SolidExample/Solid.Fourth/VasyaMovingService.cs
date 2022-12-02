using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Fourth
{
    public class VasyaMovingService : IMoving
    {
        public void BusMoving()
        {
            //logic
        }

        public void CarMoving()
        {
            //logic
        }

        public void TramMoving()
        {
            //Вася живет в городе, где нет трамваев, он не может реализовать этот метод
            throw new NotImplementedException();
        }
    }
}
