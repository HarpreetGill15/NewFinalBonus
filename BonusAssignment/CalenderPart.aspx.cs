using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment
{
    public partial class CalenderPart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {
                    output.InnerHtml = "";
                    //Run the loop to output the month of october and its days 
                    for (int i = 1; i<= 32;)
                    {
                        
                            //check if item 2 is checked in the checkboxes which is tuesday if checked output time to work
                            if (user_days_working.Items[2].Selected)
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Tuesday! Time to work</br>";
                            }
                            //if not output time to have fun
                            else
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Tuesday! Time to have fun!</br>";
                            }
                            //increment the loop to allow for the advancement of the days
                            i++;
                            //repeat for every day in the checkbox list
                            if (user_days_working.Items[3].Selected)
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Wednesday! Time to work</br>";
                            }
                            else
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Wednesday! Time to have fun!</br>";
                            }
                            i++;
                            if (user_days_working.Items[4].Selected)
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Thursday! Time to work</br>";
                            }
                            else
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Thursday! Time to have fun!</br>";
                            }
                            i++;
                            //once the loop gets to day 32 break the program
                            //this is because everytime it runs the loop it will increment based on how many checkboxes are checked 
                            //the loop will stop at 31 but will only check that parameter after the loop has run 
                            //since october ends on a thursdya it will check if the date is past 32 and break
                            if (i >= 32)
                            {
                                break;
                            }
                            if (user_days_working.Items[5].Selected)
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Friday! Time to work</br>";
                            }
                            else
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Friday! Time to have fun!</br>";
                            }
                            i++;
                            if (user_days_working.Items[6].Selected)
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Saturday! Time to work</br>";
                            }
                            else
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Saturday! Time to have fun!</br>";
                            }
                            i++;
                            if (user_days_working.Items[0].Selected)
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Sunday! Time to work</br>";
                            }
                            else
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Sunday! Time to have fun!</br>";
                            }
                            i++;
                            if (user_days_working.Items[1].Selected)
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Monday! Time to work</br>";
                            }
                            else
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Monday! Time to have fun!</br>";
                            }
                            i++;
                            


                    }//End of for loop


                    
                }
            }
        }
    }
}