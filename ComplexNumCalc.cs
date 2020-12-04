using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Complexcalc
{
    public class ComplexNumCalc : IComplexNumCalc
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
            if (this.a.Magnitude > this.b.Magnitude)
            {
                return ">";
            }
            else if (this.a.Magnitude < this.b.Magnitude)
            {
                return "<";
            }
             return "=";
        }

        public Complex Add() 
        {
            return Complex.Add(this.a, this.b);
        }

        public Complex Multiply()
        {
            Complex res = Complex.Multiply(this.a, this.b);
            return new Complex(Math.Round(res.Real, 15), Math.Round(res.Imaginary, 15));
        }
        public Complex Divide()
        {
            Complex res = Complex.Divide(this.a, this.b);
            return new Complex(Math.Round(res.Real, 15), Math.Round(res.Imaginary, 15));
        }
        public Complex Subtract()
        {
            Complex res = Complex.Subtract(this.a, this.b);
            return new Complex(Math.Round(res.Real,15), Math.Round(res.Imaginary, 15));
        }
    }
}
