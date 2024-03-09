using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_InterfaceAbstraction
{
    internal class Square : Figure
    {
        public  double _side { get; set; }

        public double Side
        {
            get
            {
                return _side;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Menfi Ola bilmez");
                }
             _side = value;
            }
            
        }

        public Square(double side)
        {
            Side = side;
            
        }

        public override int CalcArea()
        {
            throw new NotImplementedException();
        }
    }   



}
