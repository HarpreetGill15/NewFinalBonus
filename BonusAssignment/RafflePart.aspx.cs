using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment
{
    public partial class RafflePart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {

                int user_tickets = Convert.ToInt32(user_amun_tickets.Text);
                double total = user_tickets * 0.25;


                output.InnerHtml = "";
                if (user_tickets <= 50)
                {
                    for (int i = 1; i <= user_tickets; i++)
                    {
                        output.InnerHtml += "<div class='line'>";
                        output.InnerHtml += "You received a bundle of 1! That's " + (i) + " ticket(s)!</div>";
                    }

                    output.InnerHtml += "<div class='line'>Your total ticket(s) is " + user_tickets + " and your cost is $" + total + "</div>";
                }
                else if (user_tickets <= 150 && user_tickets >= 51)
                {
                    //Pass the int 2 and the ammount of tickets to the method of loop
                    loop(2, user_tickets);
                    output.InnerHtml += "<div class='line'>Your total ticket(s) is " + user_tickets + " and your cost is $" + total + "</div>";
                }
                else if (user_tickets <= 300 && user_tickets >= 151)
                {
                    //Pass the int 3 and the ammount of tickets to the method of loop
                    loop(3, user_tickets);
                    output.InnerHtml += "<div class='line'>Your total ticket(s) is " + user_tickets + " and your cost is " + total;
                }
                else if (user_tickets >= 301)
                {
                    //Pass the int 5 and the ammount of tickets to the method of loop
                    loop(5, user_tickets);
                    output.InnerHtml += "<div class='line'>Your total ticket(s) is " + user_tickets + " and your cost is " + total;
                }
            }

        }
        //Created a function that would have two parameters that represent the ammount of bundles needed and a second parameter of how many tickets the user will recive
        public void loop(int bundle, int tickets)
        {
            int leftover;
            for (int i = bundle; i <= tickets; i = i + bundle)
            {
                output.InnerHtml += "<div class='line'>";
                output.InnerHtml += "You received a bundle of 5! That's " + (i) + " ticket(s)!</div>";
            }
            if (tickets % bundle != 0)
            {
                leftover = tickets % bundle;
                output.InnerHtml += "<div class='line'>";
                output.InnerHtml += "Your leftover is " + leftover + ". That's " + tickets + " ticket(s)!</div>";
            }


        }
    }
}