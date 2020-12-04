using System.Numerics;
using System.Windows.Forms;

namespace Complexcalc
{
    class NumCalcMock : IComplexNumCalc
    {
        public Complex Add()
        {
            MessageBox.Show("Add");
            return new Complex(1,1);
        }

        public string Compare()
        {
            MessageBox.Show("Compare");
            return "Compare";
        }

        public Complex Divide()
        {
            MessageBox.Show("Divide");
            return new Complex(1, 1);
        }

        public Complex Multiply()
        {
            MessageBox.Show("Multiply");
            return new Complex(1, 1);
        }

        public Complex Subtract()
        {
            MessageBox.Show("Subtract");
            return new Complex(1, 1);
        }
    }
}
