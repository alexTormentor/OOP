using System;
using System.Collections.Generic;
using System.Text;

namespace MechSOLID_L
{
    public class Personel
    {
        protected int emplys;
        public Personel(int emplys)
        {
            if (emplys < 0)
                throw new Exception("штат сотрудников некорректен");

            this.emplys = emplys;
        }

        public int Employees
        {
            get { return emplys; }
            set
            {
                if (value < 0)
                    throw new Exception("штат сотрудников некорректен");
                this.emplys = value;
            }
        }
    }
}
