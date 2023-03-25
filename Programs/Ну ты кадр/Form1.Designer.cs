namespace Ну_ты_кадр
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lSort = new System.Windows.Forms.Label();
            this.lFiltr = new System.Windows.Forms.Label();
            this.lFind = new System.Windows.Forms.Label();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.CbSort = new System.Windows.Forms.ComboBox();
            this.CbFiltr = new System.Windows.Forms.ComboBox();
            this.pClients = new System.Windows.Forms.FlowLayoutPanel();
            this.bAddClient = new System.Windows.Forms.Button();
            this.Ppages = new System.Windows.Forms.Panel();
            this.bDel = new System.Windows.Forms.Button();
            this.lR = new System.Windows.Forms.Label();
            this.lL = new System.Windows.Forms.Label();
            this.rtbZapr = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lSort
            // 
            this.lSort.AutoSize = true;
            this.lSort.Location = new System.Drawing.Point(13, 9);
            this.lSort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSort.Name = "lSort";
            this.lSort.Size = new System.Drawing.Size(123, 28);
            this.lSort.TabIndex = 1;
            this.lSort.Text = "Сортировка";
            // 
            // lFiltr
            // 
            this.lFiltr.AutoSize = true;
            this.lFiltr.Location = new System.Drawing.Point(256, 9);
            this.lFiltr.Name = "lFiltr";
            this.lFiltr.Size = new System.Drawing.Size(124, 28);
            this.lFiltr.TabIndex = 2;
            this.lFiltr.Text = "Фильтрация";
            // 
            // lFind
            // 
            this.lFind.AutoSize = true;
            this.lFind.Location = new System.Drawing.Point(495, 9);
            this.lFind.Name = "lFind";
            this.lFind.Size = new System.Drawing.Size(69, 28);
            this.lFind.TabIndex = 3;
            this.lFind.Text = "Поиск";
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(555, 6);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(211, 34);
            this.tbFind.TabIndex = 4;
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged);
            // 
            // CbSort
            // 
            this.CbSort.FormattingEnabled = true;
            this.CbSort.Items.AddRange(new object[] {
            "Фамилия",
            "Дата рождения"});
            this.CbSort.Location = new System.Drawing.Point(116, 6);
            this.CbSort.Name = "CbSort";
            this.CbSort.Size = new System.Drawing.Size(121, 36);
            this.CbSort.TabIndex = 5;
            this.CbSort.SelectedIndexChanged += new System.EventHandler(this.CbSort_SelectedIndexChanged);
            // 
            // CbFiltr
            // 
            this.CbFiltr.FormattingEnabled = true;
            this.CbFiltr.Items.AddRange(new object[] {
            "Фамилия",
            "Имя",
            "Отчество"});
            this.CbFiltr.Location = new System.Drawing.Point(360, 6);
            this.CbFiltr.Name = "CbFiltr";
            this.CbFiltr.Size = new System.Drawing.Size(121, 36);
            this.CbFiltr.TabIndex = 6;
            this.CbFiltr.SelectedIndexChanged += new System.EventHandler(this.CbFiltr_SelectedIndexChanged);
            // 
            // pClients
            // 
            this.pClients.AutoScroll = true;
            this.pClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pClients.Location = new System.Drawing.Point(17, 89);
            this.pClients.Name = "pClients";
            this.pClients.Size = new System.Drawing.Size(902, 291);
            this.pClients.TabIndex = 7;
            // 
            // bAddClient
            // 
            this.bAddClient.AutoSize = true;
            this.bAddClient.Location = new System.Drawing.Point(18, 402);
            this.bAddClient.Name = "bAddClient";
            this.bAddClient.Size = new System.Drawing.Size(161, 38);
            this.bAddClient.TabIndex = 8;
            this.bAddClient.Text = "Добавить Кадр";
            this.bAddClient.UseVisualStyleBackColor = true;
            this.bAddClient.Click += new System.EventHandler(this.bAddClient_Click);
            // 
            // Ppages
            // 
            this.Ppages.Location = new System.Drawing.Point(12, 458);
            this.Ppages.Name = "Ppages";
            this.Ppages.Size = new System.Drawing.Size(907, 72);
            this.Ppages.TabIndex = 9;
            // 
            // bDel
            // 
            this.bDel.AutoSize = true;
            this.bDel.Location = new System.Drawing.Point(199, 402);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(167, 38);
            this.bDel.TabIndex = 10;
            this.bDel.Text = "Удаление кадра";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // lR
            // 
            this.lR.AutoSize = true;
            this.lR.Location = new System.Drawing.Point(395, 412);
            this.lR.Name = "lR";
            this.lR.Size = new System.Drawing.Size(26, 28);
            this.lR.TabIndex = 22;
            this.lR.Text = ">";
            // 
            // lL
            // 
            this.lL.AutoSize = true;
            this.lL.Location = new System.Drawing.Point(372, 412);
            this.lL.Name = "lL";
            this.lL.Size = new System.Drawing.Size(26, 28);
            this.lL.TabIndex = 21;
            this.lL.Text = "<";
            // 
            // rtbZapr
            // 
            this.rtbZapr.Location = new System.Drawing.Point(948, 89);
            this.rtbZapr.Name = "rtbZapr";
            this.rtbZapr.Size = new System.Drawing.Size(291, 291);
            this.rtbZapr.TabIndex = 23;
            this.rtbZapr.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1251, 542);
            this.Controls.Add(this.rtbZapr);
            this.Controls.Add(this.lR);
            this.Controls.Add(this.lL);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.Ppages);
            this.Controls.Add(this.bAddClient);
            this.Controls.Add(this.pClients);
            this.Controls.Add(this.CbFiltr);
            this.Controls.Add(this.CbSort);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.lFind);
            this.Controls.Add(this.lFiltr);
            this.Controls.Add(this.lSort);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lSort;
        private System.Windows.Forms.Label lFiltr;
        private System.Windows.Forms.Label lFind;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.ComboBox CbSort;
        private System.Windows.Forms.ComboBox CbFiltr;
        private System.Windows.Forms.FlowLayoutPanel pClients;
        private System.Windows.Forms.Button bAddClient;
        private System.Windows.Forms.Panel Ppages;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Label lR;
        private System.Windows.Forms.Label lL;
        private System.Windows.Forms.RichTextBox rtbZapr;
    }
}

