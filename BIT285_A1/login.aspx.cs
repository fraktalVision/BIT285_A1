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
using System.Data;
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

			// create a new row in the application visitor table
			DataTable dt = (DataTable) Application["visitorTable"];
			DataRow row = dt.NewRow();
			row[0] = (int) Application["count"]; // sessionID
			row[1] = userNameText; // username
			row[2] = DateTime.Now.ToString(); // time
			row[3] = Request.ServerVariables["REMOTE_ADDR"]; // ip
			dt.Rows.Add(row);
			dt.AcceptChanges();

			// increment application user count
			Application["count"] = ((int) Application["count"] + 1);

			// transfer to UserLog page
			Server.Transfer("~/UserLog.aspx");
		}
	}
}