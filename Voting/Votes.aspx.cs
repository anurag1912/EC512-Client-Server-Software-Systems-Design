using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
public partial class Modify : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string q = null;
        long s=0;
        double per =0.0;
        double count = 0.0;
        DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        DataRow dr;

        DataRow dc;
        for (int i = 0; i < dv.Count; i++)
        {
            dc = dv.Table.Rows[i];
             s = (int)dc["Count"];
            count+=s;
        }
        
            for (int i = -1; i < dv.Count; i++)
            {   
                
                TableRow r = new TableRow();
                TableCell c1 = new TableCell();
                TableCell c2 = new TableCell();
                TableCell c3 = new TableCell();
               
                c1.BorderWidth = 3;
                c1.BorderColor = Color.Black;
                c1.Width = 20;
                c2.BorderWidth = 3;
                c2.BorderColor = Color.Black;
                c2.Width = 20;
                c3.BorderWidth = 3;
                c3.BorderColor = Color.Black;
                c3.Width = 20;
                if (i == -1)
                {
                    c1.Text = "Candidate";
                    c2.Text = "Votes";
                    c3.Text = "Percentage";
                }
                else
                {
                    dr = dv.Table.Rows[i];
                    c1.Text = dr["Name"].ToString();
                    c2.Text = dr["Count"].ToString();
                    s = (int)dr["Count"];
                    per = (s/count) * 100;
                    c3.Text = per.ToString();
                   // comment1.Text = count.ToString();
                }
                r.Cells.Add(c1);
                r.Cells.Add(c2);
                r.Cells.Add(c3);
                Table1.Rows.Add(r);
            }

            
    
    }
}