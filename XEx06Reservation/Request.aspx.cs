using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEx06Reservation
{
    public partial class Request : System.Web.UI.Page
    {
        private string currentDate = DateTime.Today.ToShortDateString();
        private string currentYear = DateTime.Today.Year.ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            txtArrivalDate.Text = currentDate;
            lblYear.Text = currentYear;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                lblMessage.Text = "Thank you for your request.<br />We will get back to you within 24 hours.";
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            if(IsValid)
            {
                txtArrivalDate.Text = currentDate;
                txtDepartureDate.Text = null;
                ddlNumberOfPeople.SelectedValue = "1";
                rblBedType.SelectedValue = "King";
                txtSpecialRequests.Text = null;
                txtFirstName.Text = null;
                txtLastName.Text = null;
                txtEmail.Text = null;
                txtTelephone.Text = null;
                ddlMethod.SelectedValue = "Email";
            }
        }
    }
}