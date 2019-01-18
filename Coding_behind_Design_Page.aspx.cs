using System;
using System.Text.RegularExpressions;

public partial class NewFolder1_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    public void btncheck_click()
    {
          
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "")
        {
            //checking if all the fields are filled with 
            if (checklicenseplateno(TextBox1.Text.ToString()))
        {
             
                        //Putting the values of Textbox in string to use it for further purpose.
                        string no = TextBox1.Text;
                        string dt = TextBox2.Text;
                        string dth = TextBox3.Text;
                        string x = TextBox3.Text;

                        //Taking out the last number of the Licence plate number for checking the car should be allowed or not for perticular weekends.
                        no = no.Substring(no.Length - 1);

                        //Fetching the Weekend from the Date textbox.
                        DateTime dtn = Convert.ToDateTime(dt);
                        DayOfWeek week = dtn.DayOfWeek;

                        //Fetching the Time from the Time Textbox.
                        DateTime hhmm = (DateTime.Parse(x));

                        //Defining the different Time as per the Quito, Ecuador government rule to check if the cars to be allowed on road or not.
                        DateTime dt1 = DateTime.Parse("07:00");
                        DateTime dt2 = DateTime.Parse("09:30");
                        DateTime dt3 = DateTime.Parse("16:00");
                        DateTime dt4 = DateTime.Parse("19:30");

                        //With the use of if statement checking the last number of Car Licence Plate should be a number not alphabet.
                        if (no == "1" || no == "2" || no == "3" || no == "4" || no == "5" || no == "6" || no == "7" || no == "8" || no == "9" || no == "0")
                        {
                            //With the use of if statement checking the Week of Car Licence Plate Number.
                            if (week == DayOfWeek.Monday)
                            {
                                //With the use of if statement checking the car Licence Plate number last digit.
                                if (no == "1" || no == "2")
                                {
                                    //With the use of if statement checking the Morning time of Licence Plate number.
                                    if (hhmm < dt1 || hhmm > dt2)
                                    {
                                        //With the use of if statement checking the Evening time of Licence Plate number.
                                        if (hhmm < dt3 || hhmm > dt4)
                                        {
                                            Label1.Text = "Your Car number " + TextBox1.Text + "  is allowed to be on road. ";
                                        }
                                        else
                                        {
                                            Label1.Text = "Your Car number " + TextBox1.Text + "  is not allowed to be on road. ";
                                        }
                                    }
                                    else
                                    {
                                        Label1.Text = "Your Car number " + TextBox1.Text + "  is not allowed to be on road. ";
                                    }
                                }
                                else
                                {
                                    Label1.Text = "Your Car number " + TextBox1.Text + "  is allowed to be on road. ";
                                }
                            }

                            else if (week == DayOfWeek.Tuesday)
                            {
                                if (no == "3" || no == "4")
                                {
                                    if (hhmm < dt1 || hhmm > dt2)
                                    {
                                        if (hhmm < dt3 || hhmm > dt4)
                                        {
                                            Label1.Text = "Your Car number " + TextBox1.Text + "  is allowed to be on road. ";
                                        }
                                        else
                                        {
                                            Label1.Text = "Your Car number " + TextBox1.Text + "  is not allowed to be on road. ";
                                        }
                                    }
                                    else
                                    {
                                        Label1.Text = "Your Car number " + TextBox1.Text + "  is not allowed to be on road. ";
                                    }
                                }
                                else
                                {
                                    Label1.Text = "Your Car number " + TextBox1.Text + "  is allowed to be on road. ";
                                }
                            }

                            else if (week == DayOfWeek.Wednesday)
                            {
                                if (no == "5" || no == "6")
                                {
                                    if (hhmm < dt1 || hhmm > dt2)
                                    {
                                        if (hhmm < dt3 || hhmm > dt4)
                                        {
                                            Label1.Text = "Your Car number " + TextBox1.Text + "  is allowed to be on road. ";
                                        }
                                        else
                                        {
                                            Label1.Text = "Your Car number " + TextBox1.Text + "  is not allowed to be on road. ";
                                        }
                                    }
                                    else
                                    {
                                        Label1.Text = "Your Car number " + TextBox1.Text + "  is not allowed to be on road. ";
                                    }
                                }
                                else
                                {
                                    Label1.Text = "Your Car number " + TextBox1.Text + "  is allowed to be on road. ";
                                }
                            }

                            else if (week == DayOfWeek.Thursday)
                            {
                                if (no == "7" || no == "8")
                                {
                                    if (hhmm < dt1 || hhmm > dt2)
                                    {
                                        if (hhmm < dt3 || hhmm > dt4)
                                        {
                                            Label1.Text = "Your Car number " + TextBox1.Text + "  is allowed to be on road. ";
                                        }
                                        else
                                        {
                                            Label1.Text = "Your Car number " + TextBox1.Text + "  is not allowed to be on road. ";
                                        }
                                    }
                                    else
                                    {
                                        Label1.Text = "Your Car number " + TextBox1.Text + "  is not allowed to be on road. ";
                                    }
                                }
                                else
                                {
                                    Label1.Text = "Your Car number " + TextBox1.Text + "  is allowed to be on road. ";
                                }
                            }
                            else if (week == DayOfWeek.Friday)
                            {
                                if (no == "9" || no == "0")
                                {
                                    if (hhmm < dt1 || hhmm > dt2)
                                    {
                                        if (hhmm < dt3 || hhmm > dt4)
                                        {
                                            Label1.Text = "Your Car number " + TextBox1.Text + "  is allowed to be on road. ";
                                        }
                                        else
                                        {
                                            Label1.Text = "Your Car number " + TextBox1.Text + "  is not allowed to be on road. ";
                                        }
                                    }
                                    else
                                    {
                                        Label1.Text = "Your Car number " + TextBox1.Text + "  is not allowed to be on road. ";
                                    }
                                }
                                else
                                {
                                    Label1.Text = "Your Car number " + TextBox1.Text + "  is allowed to be on road. ";
                                }
                            }
                            else
                            {
                                Label1.Text = "Your Car number " + TextBox1.Text + "  is allowed to be on road. ";
                            }
                        }
                        else
                        {
                            Label1.Text = "Please enter the Car Licence plate number in the format XXX-1111 <br />(where XXX are alphabets and 1111 are the four digit of car number plate).";
                        }
                    
                }
        else
        {
            Label1.Text = "Please Enter the Car Licence Number in the format as XXX-1111 <br />as XXX to be three digit of alphabet followed by hifen (-) <br/>and then following the 4 digit of numbers.";
        }
        }
        else
        {
            Label1.Text = "Please fill all the details.";
        }
    }
    public static bool checklicenseplateno(string value)
    {
        bool IsValid = false;
        Regex r = new Regex(@"([A-Za-z]{2,3})-(\d{2,3})\w");
        if (r.IsMatch(value))
            IsValid = true;
        return IsValid;

    }
}
