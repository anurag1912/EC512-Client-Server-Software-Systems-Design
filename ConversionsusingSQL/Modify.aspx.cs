using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class Modify : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void add_Click(object sender, EventArgs e)
    {

        
        
        
        
        string s = null;
        bool exc0 = false, exc1 = false, exc2 = false, exc3 = false;
        double val;
        
        DataView dv =
                  (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        if (dv == null)
        {
            //handle error
        }
        //The select query has returned the desired row
        DataRow row;
        for (int i = 0; i < dv.Count; i++)
        {
            row = dv.Table.Rows[i];
            s = (string)row["Units"];
            if(String.Compare(newunit.Text,s)==0)
            {   
                comment1.Text = "Unit already exists: enter new unit";
                newunit.Text = "";
                convFactor.Text = "";
                exc3=true;
                break;
            }
        }
        
        

        if (exc3 == false)
        {
            try
            {
                val = Convert.ToDouble(convFactor.Text);
                if (val == 0)
                {
                    comment1.Text = "Enter non-zero value for factor";
                    newunit.Text = "";
                    convFactor.Text = "";
                    exc0 = true;
                }
            }
            catch (FormatException)
            {

                comment1.Text = "Please enter a decimal value";
                newunit.Text = "";
                convFactor.Text = "";
                exc1 = true;
            }

            catch (OverflowException)
            {
                comment1.Text = "Bad input: data exceeded bounds";
                newunit.Text = "";
                convFactor.Text = "";
                exc2 = true;
            }
            if (exc0 == false && exc1 == false && exc2 == false)
            {bool exc4=false;
                String s1 = newunit.Text;
                int i=0;
                char[] input = s1.ToCharArray();
                for( i=0;i<s1.Length;i++)
                {
                    if (input[i] != ' ')
                        break;
                }
                if (i == s1.Length)
                {
                    comment1.Text = "Unit should have a name";
                    newunit.Text="";
                    convFactor.Text="";
                    exc4 = true;
                }
                if (newunit.Text != "" & convFactor.Text != "")
                {
                    if (exc4 == false)
                    {
                        SqlDataSource1.Insert();
                        newunit.Text = "";
                        convFactor.Text = "";
                        comment1.Text = "Factor added successfully!";
                    }
                }

            }
        }
    
    
    
    
    
    }
    protected void delete_Click(object sender, EventArgs e)
    {
        sfactor.Text = "";
        DataView dv =
                      (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        if (dv.Count == 0)
        {
            comment1.Text = "Error: No items to delete!";
        }
        else
        {
            comment1.Text = "Successfully deleted 1 item!";
            if (output3.SelectedItem != null)
                SqlDataSource1.Delete();

        }
    }
    protected void show_Click(object sender, EventArgs e)
    {
        String s = null;
        DataView dv =
                    (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        if (dv == null)
        {
            comment1.Text = "No units/factors found in database!";
        }
       // comment1.Text = output3.Text;
       
        DataRow row;
        for (int i = 0; i < dv.Count;i++)
        { 
            row = dv.Table.Rows[i];
            s = Convert.ToString(row["Id"]);
            if(String.Compare(output3.Text,s)==0)
            {s = Convert.ToString(row["Factor"]);
            sfactor.Text = s;
            break;
            }
        }



            }
    protected void return_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}

    
  
