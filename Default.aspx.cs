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
    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        double amount = 0;
        bool goodAmount = double.TryParse(txtAmount.Text, out amount);
        if (!goodAmount)
        {
            Response.Write("<script>alert('Please enter a valid amount');</script>");
            txtAmount.Text = "";
            txtAmount.Focus();
            return;
        }
        double percent = 0;
        if (rdbPercentage.SelectedItem.Text != "other")
        {
            percent = double.Parse(rdbPercentage.SelectedValue.ToString());
        }
        else
        {
            bool goodPercent = double.TryParse(txtOther.Text, out percent);
            if (!goodPercent)
            {
                Response.Write("<script>alert('Please enter a valid Percentage');</script>");
                txtAmount.Text = "";
                txtAmount.Focus();
                return;
            }
        }
        TipCalculator Tip = new TipCalculator(amount, percent);
        lblTip.Text = Tip.CalculateTip().ToString("$##0.##");
        lblTotal.Text = Tip.CalculateTotal().ToString("$##0.##");
    }
}