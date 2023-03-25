namespace Ну_ты_кадр
{
    partial class fAddClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbOtc = new System.Windows.Forms.TextBox();
            this.lFam = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lOtc = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbadd = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bOk
            // 
            this.bOk.AutoSize = true;
            this.bOk.Location = new System.Drawing.Point(26, 257);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(111, 38);
            this.bOk.TabIndex = 0;
            this.bOk.Text = "Добавить";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bCancel
            // 
            this.bCancel.AutoSize = true;
            this.bCancel.Location = new System.Drawing.Point(231, 257);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(111, 38);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Отменить";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // tbFam
            // 
            this.tbFam.Location = new System.Drawing.Point(184, 22);
            this.tbFam.Name = "tbFam";
            this.tbFam.Size = new System.Drawing.Size(244, 34);
            this.tbFam.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(184, 62);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(244, 34);
            this.tbName.TabIndex = 3;
            // 
            // tbOtc
            // 
            this.tbOtc.Location = new System.Drawing.Point(184, 102);
            this.tbOtc.Name = "tbOtc";
            this.tbOtc.Size = new System.Drawing.Size(244, 34);
            this.tbOtc.TabIndex = 4;
            // 
            // lFam
            // 
            this.lFam.AutoSize = true;
            this.lFam.Location = new System.Drawing.Point(41, 22);
            this.lFam.Name = "lFam";
            this.lFam.Size = new System.Drawing.Size(96, 28);
            this.lFam.TabIndex = 5;
            this.lFam.Text = "Фамилия";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(41, 65);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(51, 28);
            this.lName.TabIndex = 6;
            this.lName.Text = "Имя";
            // 
            // lOtc
            // 
            this.lOtc.AutoSize = true;
            this.lOtc.Location = new System.Drawing.Point(41, 105);
            this.lOtc.Name = "lOtc";
            this.lOtc.Size = new System.Drawing.Size(96, 28);
            this.lOtc.TabIndex = 7;
            this.lOtc.Text = "Отчество";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(184, 142);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(244, 34);
            this.tbEmail.TabIndex = 8;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(184, 182);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(244, 34);
            this.tbPhone.TabIndex = 9;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(45, 147);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(59, 28);
            this.lEmail.TabIndex = 10;
            this.lEmail.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Телефон";
            // 
            // rtbadd
            // 
            this.rtbadd.Location = new System.Drawing.Point(454, 22);
            this.rtbadd.Name = "rtbadd";
            this.rtbadd.Size = new System.Drawing.Size(364, 194);
            this.rtbadd.TabIndex = 12;
            this.rtbadd.Text = "";
            // 
            // fAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 329);
            this.Controls.Add(this.rtbadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lOtc);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lFam);
            this.Controls.Add(this.tbOtc);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbFam);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fAddClient";
            this.Text = "fAddClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TextBox tbFam;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbOtc;
        private System.Windows.Forms.Label lFam;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lOtc;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbadd;
    }
}