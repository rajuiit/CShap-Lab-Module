using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassObjectMethodValuePass
{
    class calculation
    {
        public void add(int firstnumber,int secondnumber)
        {
            int answer = firstnumber + secondnumber;
            MessageBox.Show(answer.ToString());
            return;
           
        }

    }
}
