using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Complexcalc
{
    public static class Validator
    {
        public static bool isCorrectField(ref string str, string name)
        {
            Regex regex = new Regex(@"^(-?)(0|([1-9][0-9]*))((\.|\,)[0-9]+)?$");
            if (!regex.IsMatch(str))
            {
               MessageBox.Show(name + " is incorrectly filled!!");
                return false;
            }
            str = str.Replace(".", ",");
            return true;
        }
    }
}
