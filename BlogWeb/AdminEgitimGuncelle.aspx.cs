using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminEgitimGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
          int x = Convert.ToInt16(Request.QueryString["ID"]);
        TextBox5.Enabled = false;
        TextBox5.Text = x.ToString();

        if(Page.IsPostBack == false) 
        { 
        DataSetTableAdapters.TBLEGITIMTableAdapter dt = new DataSetTableAdapters.TBLEGITIMTableAdapter();
        TextBox1.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].BASLIK;
        TextBox2.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
        TextBox3.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
        TextBox6.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].GNOT;
        TextBox4.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].TARIH;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLEGITIMTableAdapter dt = new DataSetTableAdapters.TBLEGITIMTableAdapter();
        dt.EgitimGuncelle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox6.Text, TextBox4.Text, Convert.ToInt16(TextBox5.Text));
        Response.Redirect("AdminEgitimler.aspx");
    }
}