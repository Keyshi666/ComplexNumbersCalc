using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Numerics;

namespace Complexcalc
{
    public partial class UserControl1: UserControl
    {
        
        public UserControl1()
        {
            InitializeComponent();
            textBoxs.Add(RealPart1);
            textBoxs.Add(RealPart2);
            textBoxs.Add(ImaginaryPart2);
            textBoxs.Add(ImaginaryPart1);
        }
        private List<TextBox> textBoxs = new List<TextBox>();

        private bool isCorrectFields()
        {
            foreach (TextBox tb in this.textBoxs)
            {
                string text = tb.Text;
                if (!Validator.isCorrectField(ref text, tb.Name))
                    return false;
                tb.Text = text;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new NumCalcMock().Compare();
            if (!this.isCorrectFields())
                return;
            Complex a = new Complex(Double.Parse(RealPart1.Text), Double.Parse(ImaginaryPart1.Text));
            Complex b = new Complex(Double.Parse(RealPart2.Text), Double.Parse(ImaginaryPart2.Text));
            string result = new ComplexNumCalc(a, b).Compare();
            MessageBox.Show("First " + result + " Second");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //new NumCalcMock().Add();
            buttonClick(
                (a, b) => new ComplexNumCalc(a, b).Add());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //new NumCalcMock().Subtract();
            buttonClick(
                (a, b) => new ComplexNumCalc(a, b).Subtract());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //new NumCalcMock().Multiply();
            buttonClick(
                (a, b) => new ComplexNumCalc(a, b).Multiply());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //new NumCalcMock().Divide();
            buttonClick(
                (a, b) => new ComplexNumCalc(a, b).Divide());
        }

        public void buttonClick(Func <Complex, Complex, Complex> f)
        {
            if (!this.isCorrectFields())
                return;
            Complex a = new Complex(Double.Parse(RealPart1.Text), Double.Parse(ImaginaryPart1.Text));
            Complex b = new Complex(Double.Parse(RealPart2.Text), Double.Parse(ImaginaryPart2.Text));
            Complex result = f(a, b);
            textBox2.Text = result.Real.ToString();
            textBox4.Text = result.Imaginary.ToString();
        }
    }
}
