using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodebasedExam_No4_Q2
{
    public partial class Laptop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "select", "Hp", "Apple", "Dell", "Asus", "Lenevo" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList.Items.Add(str[i]);
                }
            }



        }



        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList.Text;
            Laptops.ImageUrl = "~/images/" + str + ".jfif";



        }




        protected void TextBox_Text(object sender, EventArgs e)
        {



        }



        protected void Button_Click(object sender, EventArgs e)
        {
            TextBox.Text = DropDownList.SelectedIndex.ToString();
            if (DropDownList.Text == "Hp")
            {
                TextBox.Text = "Rs 100000";
            }
            else if (DropDownList.Text == "Apple")
            {
                TextBox.Text = "Rs 200000";
            }
            else if (DropDownList.Text == "Dell")
            {
                TextBox.Text = "Rs 40000";
            }
            else if (DropDownList.Text == "Asus")
            {
                TextBox.Text = "Rs 600000";
            }
            else if (DropDownList.Text == "Lenevo")
            {
                TextBox.Text = "Rs 700000";
            }
            else
            {
                TextBox.Text = "Rs 80000";
            }
        }

        protected void SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}