using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }






    protected void Button1_Click(object sender, EventArgs e)
    {
        
        int exc1 = 0, exc2=0;
        double val = 0;
        try
        {
            val = Convert.ToDouble(inputString.Text);


        }
        catch (FormatException)
        {

            comment.Text = "Please enter a decimal value";
            inputString.Text = "";
            outputString.Text = "";
            exc1 = 1;
        }

        catch (OverflowException)
        {
            comment.Text = "Bad input: data exceeded bounds";
            inputString.Text = "";
            outputString.Text = "";
            exc2 = 1;
        }

        if (exc1 == 0 && exc2 == 0)
        {
            comment.Text = "";
            string input = input1.Text;
            string output = output1.Text;

            if (input.Equals(output) == true)
            {
                comment.Text = "Conversion cannot be done on the same parameter! Choose two different parameters for conversion";
                inputString.Text = "";
                outputString.Text = "";
            }
            else
            {                            
              double inunit = Convert.ToDouble(input1.SelectedValue);
              double outunit = Convert.ToDouble(output1.SelectedValue);
                
                double outputval = (val * inunit) / outunit;
      
                outputString.Text = outputval.ToString();


                
            }

        }



        }
    
}