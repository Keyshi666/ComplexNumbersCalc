using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Complexcalc
{
    class ComplexNumCalc
    {
        protected Complex a;
        protected Complex b;

        public ComplexNumCalc(Complex a, Complex b)
        {
            this.a = a;
            this.b = b;
        }

        public string Compare()
        {
            if (this.a.Equals(this.b))
            {
                return "=";
            }
            else if (this.a.Magnitude > this.b.Magnitude)
            {
                return ">";
            }
            else if (this.a.Magnitude < this.b.Magnitude)
            {
                return "<";
            }
            return "Infinity";
        }

        public Complex Add() 
        {
            return Complex.Add(this.a, this.b);
        }

        public Complex Multiply()
        {
            return Complex.Multiply(this.a, this.b);
        }
        public Complex Divide()
        {
            return Complex.Divide(this.a, this.b);
        }
        public Complex Subtract()
        {
            return Complex.Subtract(this.a, this.b);
        }
    }
}
