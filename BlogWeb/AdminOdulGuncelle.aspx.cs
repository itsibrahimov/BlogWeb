using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminOdulGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["ID"]);
        TextBox1.Text = x.ToString();
        TextBox1.Enabled = false;

        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.TBLODULLERTableAdapter dt = new DataSetTableAdapters.TBLODULLERTableAdapter();
            TextBox2.Text = dt.OdulGetir(Convert.ToInt16(x))[0].ODUL;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLODULLERTableAdapter dt = new DataSetTableAdapters.TBLODULLERTableAdapter();
        dt.OdulGuncelle(TextBox2.Text, Convert.ToInt16(TextBox1.Text));
        Response.Redirect("AdminOduller.aspx");
    }
}