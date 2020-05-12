using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassObjectMethodValuePass
{
    class calculation
    {
        public int add(int firstnumber, int secondnumber)
        {
            int answer = firstnumber + secondnumber;
           // MessageBox.Show(answer.ToString());
            return answer;

        }
            public string add(TextBox firstnumber,TextBox secondnumber)
        {
            return add(Convert.ToInt32(firstnumber.Text) , Convert.ToInt32(secondnumber.Text)).ToString();
          //  int answer = Convert.ToInt32(  firstnumber.Text) + Convert.ToInt32( secondnumber.Text);
           // MessageBox.Show(answer.ToString());
           // return answer.ToString();
         
        }

    }
}
