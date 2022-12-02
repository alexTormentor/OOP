using System;
using System.Collections.Generic;
using System.Text;

namespace MechSOLID_D
{
    public class Service
    {


        public string Raport { get; set; }
        public IAdutante Adutante { get; set; }

        public Service(IAdutante adutante)
        {
            this.Adutante = adutante;
        }

        public void Response()
        {
            Adutante.Response(Raport);
        }
    }
}
