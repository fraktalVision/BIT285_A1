/**
* Fred Jaworski
* Assignment 1
* 1/26/2016
*
* Validates that textboxes have been filled and sends data to PasswordGenerator
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIT285_A1
{
	public partial class NewAccount : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			emailValidator.Enabled = sendEmails.Checked;
		}

		protected void create_Click(object sender, EventArgs e)
		{
			// validation is performed on the server, so we know that all required fields have been filled
			// fill session variables with results from textboxes
			Session["firstName"] = firstName.Text.Trim();
			Session["lastName"] = lastName.Text.Trim();
			Session["program"] = programs.SelectedValue;
			// check if the user either opted in to receiving emails or filled in the email field
			Session["email"] = 
				(sendEmails.Checked || !String.IsNullOrWhiteSpace(email.Text))
				? email.Text.Trim()
				: "";

			// transfer to a new asp page
			Server.Transfer("~/PasswordGenerator.aspx");
		}

		protected void reset_Click(object sender, EventArgs e)
		{
			firstName.Text = "";
			lastName.Text = "";
			email.Text = "";
			sendEmails.Checked = false;
		}
	}
}