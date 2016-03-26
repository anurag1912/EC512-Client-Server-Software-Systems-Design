using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedItem == null)
            comment.Text = "Select a candidate, please!";
        else
        {
            
            int j = 0;
            DataView dv =
(DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            if (dv == null)
            {
                //handle error
            }
            //The select query has returned the desired row
            DataRow row = dv.Table.Rows[RadioButtonList1.SelectedIndex];
            j = (int)row["Count"];
            //comment.Text= RadioButtonList1.SelectedIndex.ToString();

            j++;
            HiddenField1.Value = j.ToString();
            
            SqlDataSource1.Update();
            RadioButtonList1.ClearSelection();
            Response.Redirect("Votes.aspx");
            //comment.Text = j.ToString();
            
        }
    }

    protected void HiddenField1_ValueChanged(object sender, EventArgs e)
    {
         
    }
}