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
using System.IO;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ну_ты_кадр
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int CountPerPage = 5, NBegin = 0;

        public static string txtCon= $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""{Application.StartupPath}\Kadr.mdf"";Integrated Security = True";
        void GetDateFromDB()
        {
            NBegin = 0;
            
            string Usl = "";
            if (CbFiltr.Text == "Фамилия")
                Usl += $" where Fam Like '{tbFind.Text}%'";
            if (CbFiltr.Text == "Имя")
                Usl += $" where Name Like '{tbFind.Text}%'";
            if (CbFiltr.Text == "Отчество")
                Usl += $" where Otc Like '{tbFind.Text}%'";

            //if (cbGenderTo.Text == "Женский")
            //    Usl += $" and GenderCode='ж'";
            //if (cbGenderTo.Text == "Мужской")
            //    Usl += $" and GenderCode='м'";

            if (CbSort.Text == "Фамилия")
                Usl += $" order by Fam";
            //if (CbSort.Text == "Колво посещений")
            //    Usl += $" order by CoCl desc";
            if (CbSort.Text == "Дата рождения")
                Usl += $" order by bdate desc";


            SqlConnection con = new SqlConnection(txtCon);
            con.Open();
            string txtQuery = @"Select * from Kadr" +Usl;
            rtbZapr.Text = txtQuery;
            SqlCommand query1 = new SqlCommand(txtQuery, con);
            SqlDataReader res = query1.ExecuteReader();
            lstClient.Clear();
            if (res.HasRows)
            {
                while (res.Read())
                {
                    Client NewClient = new Client();
                    NewClient.ID = res["IDKadr"].ToString();
                    NewClient.Otc = res["Otc"].ToString();
                    NewClient.Name = res["Name"].ToString();
                    NewClient.Fam = res["Fam"].ToString();
                    NewClient.bDate = res["bdate"].ToString();
                    NewClient.Ema = res["Email"].ToString();
                    NewClient.Phone = res["Phone"].ToString();

                    lstClient.Add(NewClient);
                }
                res.Close();
                con.Close();
            }
        }

        public struct Client
        {
            public string ID, Name,Fam,Otc,bDate,Ema,Phone;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbClientDataSet.Client". При необходимости она может быть перемещена или удалена.
           
            GetDateFromDB();
            FillPanel();
        }

        void FillPanel()
        {
            pClients.Controls.Clear();

            for (int i = NBegin; i <= NBegin + CountPerPage - 1; i++)
            {
                if (i > lstClient.Count - 1)
                    break;
                ItemPanelClient itc = new ItemPanelClient();
                    itc.lDB.Text = lstClient[i].bDate;
                    itc.lEma.Text = lstClient[i].Ema;
                    itc.lFio.Text = lstClient[i].Fam + " " + lstClient[i].Name + " " + lstClient[i].Otc;
                    itc.lPhone.Text = lstClient[i].Phone;

                    itc.IDClient = lstClient[i].ID;


                    pClients.Controls.Add(itc);

                    itc.Click += itc_Click;
                    itc.lDB.Click += Object_Click;
                    itc.lEma.Click += Object_Click;
                    itc.lFio.Click += Object_Click;
                    itc.lPhone.Click += Object_Click;
            }
                

                if (CountPerPage == 0)
                CountPerPage = 1;
            int Cnt = lstClient.Count / CountPerPage; //кол-во страниц
                                                      // если есть неполная последняя страница
            if (lstClient.Count % CountPerPage != 0)
                Cnt++;
            Ppages.Controls.Clear();
            lL.Dock = DockStyle.Left;
            lR.Dock = DockStyle.Left;
            lL.Click += lL_Click;
            lR.Click += lR_Click;
            Ppages.Controls.Add(lR);

            for (int i = Cnt; i >= 1; i--)
            {
                Label lbl = new Label();
                lbl.Text = i.ToString();
                lbl.Dock = DockStyle.Left;
                lbl.AutoSize = true;
                //если отображается номер текущей страницы
                if (NBegin / CountPerPage + 1 == i)
                {
                    lbl.BackColor = Color.LightGray;
                    lbl.Font = new Font(lbl.Font, FontStyle.Underline);
                }
                lbl.Click += Lbl_Click;
                Ppages.Controls.Add(lbl);
            }
            Ppages.Controls.Add(lL);

        }

        private void lL_Click(object sender, EventArgs e)
        {
            //если страница не первая
            if (NBegin > 0)
            {
                NBegin -= CountPerPage;
                FillPanel();
            }
        }

        private void lR_Click(object sender, EventArgs e)
        {
            //если страница не последняя
            if (NBegin < lstClient.Count - (1 + CountPerPage))
            {
                NBegin += CountPerPage;
                FillPanel();
            }
        }

        private void Lbl_Click(object sender, EventArgs e)
        {
            //номер страницы на метке на которой выполнили щелчок
            int n = int.Parse((sender as Label).Text);
            NBegin = (n - 1) * CountPerPage;
            FillPanel();
        }

       public static List<Client> lstClient = new List<Client>();
        ItemPanelClient itc1=new ItemPanelClient();

        private void Object_Click(object sender, EventArgs e)
        {
            itc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            itc1 = (sender as Control).Parent as ItemPanelClient;
            itc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
        }



        private void itc_Click(object sender, EventArgs e)
        {
            itc1 = sender as ItemPanelClient;  // текущая плитка
            if (itc1.isSelected)
            {
                itc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
                itc1.isSelected = false;
            }
            else
            {
                itc1.isSelected = true;
                itc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            }
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            int curNbegin = NBegin;
            GetDateFromDB();
            NBegin = curNbegin;
            FillPanel();
        }

        private void CbFiltr_SelectedIndexChanged(object sender, EventArgs e)
        {
            int curNbegin = NBegin;
            GetDateFromDB();
            NBegin = curNbegin;
            FillPanel();
        }

        private void CbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            int curNbegin = NBegin;
            GetDateFromDB();
            NBegin = curNbegin;
            FillPanel();
        }

        private void bAddClient_Click(object sender, EventArgs e)
        {
            fAddClient fa=new fAddClient();
            fa.ShowDialog();
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            foreach (Client c in lstClient)
            {
                if (itc1.isSelected)
                {
                    SqlConnection con = new SqlConnection(txtCon);
                    con.Open();
                    string txtQuery = $@"delete from Tcan where IDTcan ={c.ID}";
                    rtbZapr.Text = txtQuery;
                    SqlCommand query1 = new SqlCommand(txtQuery, con);
                    query1.ExecuteNonQuery();
                }
            }
        }

        //public static int EditDistance(string s, string t)
        //{
        //    int m = s.Length, n = t.Length;
        //    int[,] ed = new int[m, n];

        //    for (int i = 0; i < m; ++i)
        //    {
        //        ed[i, 0] = i + 1;
        //    }

        //    for (int j = 0; j < n; ++j)
        //    {
        //        ed[0, j] = j + 1;
        //    }

        //    for (int j = 1; j < n; ++j)
        //    {
        //        for (int i = 1; i < m; ++i)
        //        {
        //            if (s[i] == t[j])
        //            {
        //                // Операция не требуется
        //                ed[i, j] = ed[i - 1, j - 1];
        //            }
        //            else
        //            {
        //                // Минимум между удалением, вставкой и заменой
        //                ed[i, j] = Math.Min(ed[i - 1, j] + 1,
        //                    Math.Min(ed[i, j - 1] + 1, ed[i - 1, j - 1] + 1));
        //            }
        //        }
        //    }

        //    return ed[m - 1, n - 1];
        //}

        //void livins()
        //{
        //    if (tbFind.Text=="")
        //    {
        //        pClients.Controls.Clear();

        //        foreach (Client C in lstClient)
        //        {
        //            ItemPanelClient itc = new ItemPanelClient();
        //            itc.lDB.Text = C.bDate;
        //            itc.lEma.Text = C.Ema;
        //            itc.lFio.Text = C.Fam + " " + C.Name + " " + C.Otc;
        //            itc.lPhone.Text = C.Phone;

        //            itc.IDClient = C.ID;


        //            pClients.Controls.Add(itc);

        //            itc.Click += itc_Click;
        //            itc.lDB.Click += Object_Click;
        //            itc.lEma.Click += Object_Click;
        //            itc.lFio.Click += Object_Click;
        //            itc.lPhone.Click += Object_Click;
        //        }
        //    }

        //        else
        //        {
        //        Client c
        //            if (EditDistance(tbFind.Text.Trim(), c.Name.Split(' ')[1]) <= 3)
        //            {
        //            ItemPanelClient itc = new ItemPanelClient();
        //            itc.lDB.Text = C.bDate;
        //            itc.lEma.Text = C.Ema;
        //            itc.lFio.Text = C.Fam + " " + C.Name + " " + C.Otc;
        //            itc.lPhone.Text = C.Phone;

        //            itc.IDClient = C.ID;


        //            pClients.Controls.Add(itc);

        //            itc.Click += itc_Click;
        //            itc.lDB.Click += Object_Click;
        //            itc.lEma.Click += Object_Click;
        //            itc.lFio.Click += Object_Click;
        //            itc.lPhone.Click += Object_Click;

        //        }
        //    }
        //}

        class ItemPanelClient : Panel
        {
            #region 千引く七
            //public System.Windows.Forms.Panel pClient;
            public System.Windows.Forms.Label lPhone;
            public System.Windows.Forms.Label lFio;
            public System.Windows.Forms.Label lDB;
            public System.Windows.Forms.Label lEma;
            private System.Windows.Forms.PictureBox pbKadr;

            public string IDClient;
            public bool isSelected;
            #endregion
            public ItemPanelClient()
            {
               
                this.lEma = new System.Windows.Forms.Label();
                this.lDB = new System.Windows.Forms.Label();
                this.lFio = new System.Windows.Forms.Label();
                this.lPhone = new System.Windows.Forms.Label();
                this.pbKadr = new System.Windows.Forms.PictureBox();
                // 
                // pClient
                // 
                this.BackColor = System.Drawing.Color.LightGray;
                this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.Controls.Add(this.pbKadr);
                this.Controls.Add(this.lEma);
                this.Controls.Add(this.lDB);
                this.Controls.Add(this.lFio);
                this.Controls.Add(this.lPhone);
                this.Location = new System.Drawing.Point(40, 97);
                this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
                this.Name = "pClient";
                this.Size = new System.Drawing.Size(425, 108);
                this.TabIndex = 0;
                // 
                // lEma
                // 
                this.lEma.AutoSize = true;
                this.lEma.Location = new System.Drawing.Point(108, 82);
                this.lEma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.lEma.Name = "lEma";
                this.lEma.Size = new System.Drawing.Size(48, 21);
                this.lEma.TabIndex = 4;
                this.lEma.Text = "Email";
                // 
                // lDB
                // 
                this.lDB.AutoSize = true;
                this.lDB.Location = new System.Drawing.Point(108, 46);
                this.lDB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.lDB.Name = "lDB";
                this.lDB.Size = new System.Drawing.Size(88, 21);
                this.lDB.TabIndex = 3;
                this.lDB.Text = "00.00.0000";
                // 
                // lFio
                // 
                this.lFio.AutoSize = true;
                this.lFio.Location = new System.Drawing.Point(108, 3);
                this.lFio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.lFio.Name = "lFio";
                this.lFio.Size = new System.Drawing.Size(46, 21);
                this.lFio.TabIndex = 1;
                this.lFio.Text = "ФИО";
                // 
                // lPhone
                // 
                this.lPhone.AutoSize = true;
                this.lPhone.Location = new System.Drawing.Point(204, 46);
                this.lPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                this.lPhone.Name = "lPhone";
                this.lPhone.Size = new System.Drawing.Size(109, 21);
                this.lPhone.TabIndex = 2;
                this.lPhone.Text = "00000000000";
                // 
                // pbKadr
                // 
                this.pbKadr.Location = new System.Drawing.Point(3, 3);
                this.pbKadr.Name = "pbKadr";
                this.pbKadr.Size = new System.Drawing.Size(100, 100);
                this.pbKadr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                this.pbKadr.TabIndex = 5;
                this.pbKadr.TabStop = false;

            }
        }
    }
}
