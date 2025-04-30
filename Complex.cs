using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_oop
{
    internal class Complex
    {
        int real;
        int img;

        public void SetReal(int _real)
        {
            this.real = _real;
        }
        public void SetImg(int _img)
        {
            this.img = _img;
        }
        public int GetReal()
        {
            return real;
        }
        public int GetImg()
        {
            return this.img;
        }
        public string PrintComplex()
        {
            return $"{this.real}+{img}i";
        }

        public Complex()
        {
            real = 9;
            img = 4;
        }


        public Complex(int _real, int _img)
        {
            real = _real;
            img = _img;
        }

        public Complex(int _number)
        {
            real = _number;
            img = _number;
        }


    }
}
