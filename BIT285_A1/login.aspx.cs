/**
* Fred Jaworski
* Assignment 1
* 1/26/2016
*
* Takes login information, navigates to new welcome if username and password are correct
* If password is empty or need new account link is clicked, navigate to password generator
* Any incorrect information will display some error text
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIT285_A1
{
	public partial class login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnLogin_Click(object sender, EventArgs e)
		{
			// get trimmed strings from textboxes
			string userNameText = userName.Text.Trim();
			string passwordText = password.Text.Trim();

			// clear textboxes of any and all text
			userName.Text = "";
			password.Text = "";

			// check if userName was blank, if so return out of the method
			if (String.IsNullOrWhiteSpace(userNameText))
			{
				error.Visible = true;
				return;
			}

			// store username in session variable
			Session["userName"] = userNameText;

			// check if password is blank, if so send to password generator
			if (String.IsNullOrWhiteSpace(passwordText)) 
				Server.Transfer("~/PasswordGenerator.aspx");

			if (String.Equals(userNameText, "Ian") && String.Equals(passwordText, "password"))
				Server.Transfer("~/UserLog.aspx");

		}
	}
}