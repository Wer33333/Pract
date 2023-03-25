using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ну_ты_кадр
{
    public partial class fAddClient : Form
    {
        public fAddClient()
        {
            InitializeComponent();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            if (tbFam.Text != "" && tbFam.Text != "" && tbFam.Text != "")
            {
                SqlConnection con = new SqlConnection(Form1.txtCon);
                con.Open();
                if (tbEmail.Text != "")
                {
                    string txtQuery = $@"insert into Kadr(IdKadr,Fam,Name,Otc) values({Form1.lstClient.Count},{tbFam.Text},{tbName.Text},{tbOtc.Text})";
                    rtbadd.Text = txtQuery;
                    SqlCommand query1 = new SqlCommand(txtQuery, con);
                    query1.ExecuteNonQuery();
                }
                else if (tbPhone.Text != "")
                {
                    string txtQuery = $@"insert into Kadr(IdKadr,Fam,Name,Otc,Email) values({Form1.lstClient.Count},{tbFam.Text},{tbName.Text},{tbOtc.Text},{tbEmail.Text})";
                    rtbadd.Text = txtQuery;
                    SqlCommand query1 = new SqlCommand(txtQuery, con);
                    query1.ExecuteNonQuery();
                }
                else
                {
                    string txtQuery = $@"insert into Kadr(IdKadr,Fam,Name,Otc,Email,Phone) values({Form1.lstClient.Count},{tbFam.Text},{tbName.Text},{tbOtc.Text},{tbPhone.Text})";
                    rtbadd.Text = txtQuery;
                    SqlCommand query1 = new SqlCommand(txtQuery, con);
                    query1.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}
