using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice2_3
{
    public partial class Reflect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int M, r, sum, o_M, n;

            M = 663166;
            o_M = M;
            sum = 0;
            n = 0;
            while (M > 0)
            {
                r = M % 10;
                sum = (sum * 10) + r;
                M = M / 10;
                n++;
            }

            if (o_M == sum & n <= 8)
            {
                Response.Write("True");
            }
            else if (n > 8)
            {
                Response.Write("M值不能大於8"); ;
            }
            else
            {
                Response.Write("False");
            }
        }
    }
}