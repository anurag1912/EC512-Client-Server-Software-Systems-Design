using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected string[] conversions = { "Kilometres", "Metres", "Centimetres", "Millimetres", "Miles", "Yards", "Feet", "Inches" };
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            input1.DataSource = conversions;
            output1.DataSource = conversions;
            input1.DataBind();
            output1.DataBind();
        }
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
                double[] arr = new double[8];
                arr[0] = 1000;
                arr[1] = 1;
                arr[2] = 0.01;
                arr[3] = 0.001;
                arr[4] = 1609.34;
                arr[5] = 0.9144;
                arr[6] = 0.3048;
                arr[7] = 0.0254;

                int i = 0, o = 0;

                if (input.Equals("Kilometres"))
                    i = 0;
                else if (input.Equals("Metres"))
                    i = 1;
                else if (input.Equals("Centimetres"))
                    i = 2;
                else if (input.Equals("Millimetres"))
                    i = 3;
                else if (input.Equals("Miles"))
                    i = 4;
                else if (input.Equals("Yards"))
                    i = 5;
                else if (input.Equals("Feet"))
                    i = 6;
                else i = 7;

                if (output.Equals("Kilometres"))
                    o = 0;
                else if (output.Equals("Metres"))
                    o = 1;
                else if (output.Equals("Centimetres"))
                    o = 2;
                else if (output.Equals("Millimetres"))
                    o = 3;
                else if (output.Equals("Miles"))
                    o = 4;
                else if (output.Equals("Yards"))
                    o = 5;
                else if (output.Equals("Feet"))
                    o = 6;
                else o = 7;

    

                double outputval = (val * arr[i]) / arr[o];
                outputString.Text = outputval.ToString();
                

            }




        }



        }
    
}
