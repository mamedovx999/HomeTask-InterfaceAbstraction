using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_InterfaceAbstraction
{
    internal class Rectangular : Figure
    {
        public double _width { get; set; }
        public double _length { get; set; }


        public double Width
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
        public double Length
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

        public Rectangular(double width , double lentgh)
        {
            Width = width;
            Length = lentgh;
        }

        public override int CalcArea()
        {
            throw new NotImplementedException();
        }
    }
}
