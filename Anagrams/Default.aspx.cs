using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public int factorial(int length)
    {
        int i = 1, j = 1;
        for (; i <= length; i++)
            j = j * i;
        return j;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {


        
    

       string str = inputString.Text;
       inputString.Text = "";
        int length = str.Length;
        if (length <= 1 || length >= 8)
        {
            comment.Text = "Please enter a string from 1 to 8 characters";

        }
        else
        {
            int fact = factorial(length);

            int[,] arr = new int[fact, length];  //I am using 2-D array to store all the anagrams

            int i = 0;
            for (int j = 0; j < length; j++)
            {
                arr[i, j] = j;

            }
            /* My logic is based on 
             *finding all permutations of the positions of the characters in the String
             */
            //Initialization of variables used in main logic...............................................................
    
            int l = 0, k = 0, index = 0, b = 0, c = 0;
            bool cond = false, cond1 = true;
            int[] swap = new int[2];
            swap[0] = length - 1;
            swap[1] = length - 2;
            int temp;
            int[] count = new int[length];
            for (int z = 0; z < length; z++)
                count[z] = 1;

            //START of LOGIC................................................................................................ 

            for (i = 1; i < fact; i++)
                for (int j = 0; j < length; j++)
                {
                    if ((length - j) != 2 && (length - j) != 1)
                    {
                        if (count[j] < (factorial(length - j) / (length - j)))
                        {


                            arr[i, j] = arr[i - 1, j];
                            ++count[j];


                        }

                        else
                        {
                            b = 0;
                            while (arr[i - 1, j] != b)
                            {
                                b++;

                            }

                            b++;
                            if (b == length) b = 0;
                            c = 0;
                            while (c < j)
                            {
                                if (b == arr[i, c])
                                {
                                    b++;
                                    if (b == length) b = 0;
                                    c = 0;
                                }

                                else c++;
                            }
                            if (c == j)
                            {
                                arr[i, j] = b;
                                count[j] = 1;
                            }
                        }

                    }

                        //Taken care of finding missing last two characters and swapping on next iteration of j

                    else
                    {
                        if (cond == false && cond1 == false)
                        {
                            k = 0;
                            l = 0;
                            while (l < j)
                            {
                                if (arr[0, k] == arr[i, l])
                                {
                                    k++;
                                    l = 0;
                                }
                                else l++;
                            }
                            if (l == j)
                                swap[0] = arr[0, k];



                            cond = true;
                            arr[i, j] = swap[0];
                        }
                        else if (cond == true && cond1 == false)
                        {
                            k = 0;
                            l = 0;
                            while (true)
                            {
                                while (l < j)
                                {
                                    if (arr[0, k] == arr[i, l])
                                    {
                                        k++;
                                        l = 0;
                                    }
                                    else l++;
                                }
                                if (l == j)
                                {
                                    if (swap[0] == arr[0, k])
                                        k++;
                                    else
                                    {
                                        swap[1] = arr[0, k];
                                        break;
                                    }
                                }
                            }


                            arr[i, j] = swap[1];
                            cond = false;
                            cond1 = true;
                            temp = swap[0];
                            swap[0] = swap[1];
                            swap[1] = temp;
                            index = 0;


                        }
                        else
                        {
                            arr[i, j] = swap[index++];
                            if ((length - j) == 1)
                            {
                                index = 0;
                                cond1 = false;
                            }



                        }



                    }





                }
            
            for (i = 0; i < fact; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write("{0}", str[arr[i, j]]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Without repeats");
             
    
            string[] array = new string[fact];
            char[] characterss = new char[length];

            for (i = 0; i < fact; i++)
            {
                for (int j = 0; j < length; j++)
                {

                    characterss[j] = str[arr[i, j]];
                }

                String strings = new String(characterss);
                array[i] = strings;
                //  Console.WriteLine(array[i]);
            }
             if (CheckBox1.Checked==false)
            {
                outputList1.Text = "";
                 for (int j = 0; j < fact; j++)
            {
                outputList1.Text = outputList1.Text + array[j]+"\r";
            }
            comment.Text = fact.ToString() + "anagrams found";
            
             }
            else
             {
                 outputList1.Text = "";
                int count1 = 0;
                for (i = 0; i < fact; i++)
                    for (int j = 0; j < fact; j++)
                    {
                        if (i != j && array[i] != null && array[j] != null)
                        {
                            if (array[i].Equals(array[j]))
                            {

                                array[j] = null;

                            }

                        }
                    }

                for (i = 0; i < fact; i++)
                {
                    // Console.WriteLine(array[i]);


                    if (array[i] != null)
                    {
                        count1++;
                    }

                }

                String[] norepeats = new String[count1];
                int o = 0;
                for (i = 0; i < fact; i++)
                {
                    if (array[i] != null)
                    {
                        norepeats[o++] = String.Copy(array[i]);
                    }
                }

                for (i = 0; i < count1; i++)
                {
                    outputList1.Text = outputList1.Text + norepeats[i] + "\r";

                }
                comment.Text = count1.ToString() + "anagrams found";
                
            }
        }
    }


}

            

