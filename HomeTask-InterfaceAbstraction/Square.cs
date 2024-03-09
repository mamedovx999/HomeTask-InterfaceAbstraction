using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_InterfaceAbstraction
{
    internal class Square : Figure
    {
        private int _side;

        public int Side
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

        public Square(int side)
        {
            Side = side;
            
        }

        public override int CalcArea()
        {
            return Side * Side;
        }
    }   



}
