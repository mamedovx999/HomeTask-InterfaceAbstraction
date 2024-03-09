using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_InterfaceAbstraction
{
    internal class Rectangular : Figure
    {
        private int _width;
        private int _length;


        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(" Width Menfi Ola bilmez");
                }
                _width = value;
            }
        }
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Length Menfi ola bilmez");
                }
                _length = value;
            }
        }

        public Rectangular(int width , int lentgh)
        {
            Width = width;
            Length = lentgh;
        }

        public override int CalcArea()
        {
            return Width * Length;
        }
    }
}
