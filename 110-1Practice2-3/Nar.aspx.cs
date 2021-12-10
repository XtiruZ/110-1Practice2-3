using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace _110_1Practice2_3
{
    public partial class Nar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i_number, n, o_number1, o_number2, Squares1, Squares2, sum, i, j;
            i_number = 153;
            n = 0;
            o_number1 = i_number;
            o_number2 = i_number;
            sum = 0;
            while (o_number1 != 0)
            {
                o_number1 /= 10;
                n++;
            }

            for (i = 0; i < n; i++)
            {
                Squares1 = o_number2 % 10;
                o_number2 /= 10;
                Squares2 = Squares1;
                for (j = 1; j < n; j++)
                {
                    Squares1 = Squares2 * Squares1;
                }
                sum += Squares1;
            }

            if (sum == i_number)
            {
                Response.Write("True");
            }
            else
            {
                Response.Write("False");
            }



        }
    }
}