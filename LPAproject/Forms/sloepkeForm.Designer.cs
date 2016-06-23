namespace LPAproject
{
    partial class sloepkeForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.AdminWachtwoordTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adminLogoutBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.budgetBotenLB = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.budgetBijkomendeArtikelenLB = new System.Windows.Forms.ListBox();
            this.budgetBijkomendeArtikelenCB = new System.Windows.Forms.ComboBox();
            this.budgetBootCB = new System.Windows.Forms.ComboBox();
            this.budgetNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nieuwContractBtn = new System.Windows.Forms.Button();
            this.LBContracten = new System.Windows.Forms.ListBox();
            this.x = new System.Windows.Forms.Button();
            this.adminLabel = new System.Windows.Forms.Label();
            this.adminLB = new System.Windows.Forms.ListBox();
            this.adminRadioVerwijder = new System.Windows.Forms.RadioButton();
            this.adminRadioVoegToe = new System.Windows.Forms.RadioButton();
            this.adminRadioWijzig = new System.Windows.Forms.RadioButton();
            this.motorBootLB = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adminVoegToeBtn = new System.Windows.Forms.Button();
            this.adminGB = new System.Windows.Forms.GroupBox();
            this.adminMeerCB = new System.Windows.Forms.ComboBox();
            this.adminWaterNaam = new System.Windows.Forms.TextBox();
            this.budgetIjsselmeerChck = new System.Windows.Forms.CheckBox();
            this.budgetNoordzeeChck = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetNUD)).BeginInit();
            this.adminGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Admin Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminWachtwoordTextBox
            // 
            this.AdminWachtwoordTextBox.Location = new System.Drawing.Point(26, 32);
            this.AdminWachtwoordTextBox.Name = "AdminWachtwoordTextBox";
            this.AdminWachtwoordTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdminWachtwoordTextBox.TabIndex = 2;
            this.AdminWachtwoordTextBox.Text = "Wachtwoord..";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.adminLogoutBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin";
            // 
            // adminLogoutBtn
            // 
            this.adminLogoutBtn.Location = new System.Drawing.Point(14, 72);
            this.adminLogoutBtn.Name = "adminLogoutBtn";
            this.adminLogoutBtn.Size = new System.Drawing.Size(75, 23);
            this.adminLogoutBtn.TabIndex = 14;
            this.adminLogoutBtn.Text = "Logout";
            this.adminLogoutBtn.UseVisualStyleBackColor = true;
            this.adminLogoutBtn.Visible = false;
            this.adminLogoutBtn.Click += new System.EventHandler(this.adminLogoutBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.budgetNoordzeeChck);
            this.groupBox2.Controls.Add(this.budgetIjsselmeerChck);
            this.groupBox2.Controls.Add(this.budgetBotenLB);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.budgetBijkomendeArtikelenLB);
            this.groupBox2.Controls.Add(this.budgetBijkomendeArtikelenCB);
            this.groupBox2.Controls.Add(this.budgetBootCB);
            this.groupBox2.Controls.Add(this.budgetNUD);
            this.groupBox2.Location = new System.Drawing.Point(13, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 306);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Budget Berekening";
            // 
            // budgetBotenLB
            // 
            this.budgetBotenLB.FormattingEnabled = true;
            this.budgetBotenLB.Location = new System.Drawing.Point(149, 102);
            this.budgetBotenLB.Name = "budgetBotenLB";
            this.budgetBotenLB.Size = new System.Drawing.Size(121, 173);
            this.budgetBotenLB.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Bereken";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // budgetBijkomendeArtikelenLB
            // 
            this.budgetBijkomendeArtikelenLB.FormattingEnabled = true;
            this.budgetBijkomendeArtikelenLB.Location = new System.Drawing.Point(7, 102);
            this.budgetBijkomendeArtikelenLB.Name = "budgetBijkomendeArtikelenLB";
            this.budgetBijkomendeArtikelenLB.Size = new System.Drawing.Size(121, 173);
            this.budgetBijkomendeArtikelenLB.TabIndex = 3;
            // 
            // budgetBijkomendeArtikelenCB
            // 
            this.budgetBijkomendeArtikelenCB.FormattingEnabled = true;
            this.budgetBijkomendeArtikelenCB.Items.AddRange(new object[] {
            "zwemvest",
            "peddel",
            "dekzeil",
            "kampeerset"});
            this.budgetBijkomendeArtikelenCB.Location = new System.Drawing.Point(7, 74);
            this.budgetBijkomendeArtikelenCB.Name = "budgetBijkomendeArtikelenCB";
            this.budgetBijkomendeArtikelenCB.Size = new System.Drawing.Size(121, 21);
            this.budgetBijkomendeArtikelenCB.TabIndex = 2;
            this.budgetBijkomendeArtikelenCB.Text = "Bijkomende artikelen..";
            this.budgetBijkomendeArtikelenCB.SelectedIndexChanged += new System.EventHandler(this.budgetBijkomendeArtikelenCB_SelectedIndexChanged);
            // 
            // budgetBootCB
            // 
            this.budgetBootCB.FormattingEnabled = true;
            this.budgetBootCB.Items.AddRange(new object[] {
            "Spier",
            "Motor"});
            this.budgetBootCB.Location = new System.Drawing.Point(7, 47);
            this.budgetBootCB.Name = "budgetBootCB";
            this.budgetBootCB.Size = new System.Drawing.Size(121, 21);
            this.budgetBootCB.TabIndex = 1;
            this.budgetBootCB.Text = "Boot type..";
            this.budgetBootCB.SelectedIndexChanged += new System.EventHandler(this.budgetBootCB_SelectedIndexChanged);
            // 
            // budgetNUD
            // 
            this.budgetNUD.DecimalPlaces = 2;
            this.budgetNUD.Location = new System.Drawing.Point(7, 20);
            this.budgetNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.budgetNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.budgetNUD.Name = "budgetNUD";
            this.budgetNUD.Size = new System.Drawing.Size(120, 20);
            this.budgetNUD.TabIndex = 0;
            this.budgetNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contracten";
            // 
            // nieuwContractBtn
            // 
            this.nieuwContractBtn.Location = new System.Drawing.Point(608, 42);
            this.nieuwContractBtn.Name = "nieuwContractBtn";
            this.nieuwContractBtn.Size = new System.Drawing.Size(114, 23);
            this.nieuwContractBtn.TabIndex = 7;
            this.nieuwContractBtn.Text = "Nieuw contract";
            this.nieuwContractBtn.UseVisualStyleBackColor = true;
            this.nieuwContractBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // LBContracten
            // 
            this.LBContracten.FormattingEnabled = true;
            this.LBContracten.Location = new System.Drawing.Point(608, 84);
            this.LBContracten.Name = "LBContracten";
            this.LBContracten.Size = new System.Drawing.Size(278, 342);
            this.LBContracten.TabIndex = 8;
            this.LBContracten.SelectedIndexChanged += new System.EventHandler(this.LBContracten_SelectedIndexChanged);
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(805, 42);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(75, 23);
            this.x.TabIndex = 9;
            this.x.Text = "Ververs";
            this.x.UseVisualStyleBackColor = true;
            this.x.Click += new System.EventHandler(this.verversBtn);
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Location = new System.Drawing.Point(404, 18);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(101, 13);
            this.adminLabel.TabIndex = 0;
            this.adminLabel.Text = "ADMIN INGELOGD";
            this.adminLabel.Visible = false;
            // 
            // adminLB
            // 
            this.adminLB.FormattingEnabled = true;
            this.adminLB.Items.AddRange(new object[] {
            "Hier komt de voorraad te staan zodat de admin ",
            "deze kan verwijderen, toevoegen en wijzigen."});
            this.adminLB.Location = new System.Drawing.Point(320, 42);
            this.adminLB.Name = "adminLB";
            this.adminLB.Size = new System.Drawing.Size(268, 147);
            this.adminLB.TabIndex = 10;
            this.adminLB.Visible = false;
            // 
            // adminRadioVerwijder
            // 
            this.adminRadioVerwijder.AutoSize = true;
            this.adminRadioVerwijder.Location = new System.Drawing.Point(320, 197);
            this.adminRadioVerwijder.Name = "adminRadioVerwijder";
            this.adminRadioVerwijder.Size = new System.Drawing.Size(68, 17);
            this.adminRadioVerwijder.TabIndex = 11;
            this.adminRadioVerwijder.TabStop = true;
            this.adminRadioVerwijder.Text = "Verwijder";
            this.adminRadioVerwijder.UseVisualStyleBackColor = true;
            this.adminRadioVerwijder.Visible = false;
            // 
            // adminRadioVoegToe
            // 
            this.adminRadioVoegToe.AutoSize = true;
            this.adminRadioVoegToe.Location = new System.Drawing.Point(407, 197);
            this.adminRadioVoegToe.Name = "adminRadioVoegToe";
            this.adminRadioVoegToe.Size = new System.Drawing.Size(68, 17);
            this.adminRadioVoegToe.TabIndex = 12;
            this.adminRadioVoegToe.TabStop = true;
            this.adminRadioVoegToe.Text = "Voeg toe";
            this.adminRadioVoegToe.UseVisualStyleBackColor = true;
            this.adminRadioVoegToe.Visible = false;
            // 
            // adminRadioWijzig
            // 
            this.adminRadioWijzig.AutoSize = true;
            this.adminRadioWijzig.Location = new System.Drawing.Point(496, 197);
            this.adminRadioWijzig.Name = "adminRadioWijzig";
            this.adminRadioWijzig.Size = new System.Drawing.Size(53, 17);
            this.adminRadioWijzig.TabIndex = 13;
            this.adminRadioWijzig.TabStop = true;
            this.adminRadioWijzig.Text = "Wijzig";
            this.adminRadioWijzig.UseVisualStyleBackColor = true;
            this.adminRadioWijzig.Visible = false;
            // 
            // motorBootLB
            // 
            this.motorBootLB.FormattingEnabled = true;
            this.motorBootLB.Location = new System.Drawing.Point(218, 43);
            this.motorBootLB.Name = "motorBootLB";
            this.motorBootLB.Size = new System.Drawing.Size(75, 69);
            this.motorBootLB.TabIndex = 14;
            this.motorBootLB.SelectedIndexChanged += new System.EventHandler(this.motorBootLB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kies een boot om \r\nde radius te berekenen";
            // 
            // adminVoegToeBtn
            // 
            this.adminVoegToeBtn.Location = new System.Drawing.Point(6, 169);
            this.adminVoegToeBtn.Name = "adminVoegToeBtn";
            this.adminVoegToeBtn.Size = new System.Drawing.Size(75, 23);
            this.adminVoegToeBtn.TabIndex = 16;
            this.adminVoegToeBtn.Text = "Voeg toe";
            this.adminVoegToeBtn.UseVisualStyleBackColor = true;
            this.adminVoegToeBtn.Visible = false;
            this.adminVoegToeBtn.Click += new System.EventHandler(this.adminVoegToeBtn_Click);
            // 
            // adminGB
            // 
            this.adminGB.Controls.Add(this.adminMeerCB);
            this.adminGB.Controls.Add(this.adminWaterNaam);
            this.adminGB.Controls.Add(this.adminVoegToeBtn);
            this.adminGB.Location = new System.Drawing.Point(320, 225);
            this.adminGB.Name = "adminGB";
            this.adminGB.Size = new System.Drawing.Size(248, 198);
            this.adminGB.TabIndex = 17;
            this.adminGB.TabStop = false;
            this.adminGB.Text = "Meer toevoegen";
            this.adminGB.Visible = false;
            // 
            // adminMeerCB
            // 
            this.adminMeerCB.FormattingEnabled = true;
            this.adminMeerCB.Items.AddRange(new object[] {
            "Meer",
            "Zee"});
            this.adminMeerCB.Location = new System.Drawing.Point(7, 47);
            this.adminMeerCB.Name = "adminMeerCB";
            this.adminMeerCB.Size = new System.Drawing.Size(121, 21);
            this.adminMeerCB.TabIndex = 18;
            // 
            // adminWaterNaam
            // 
            this.adminWaterNaam.Location = new System.Drawing.Point(7, 20);
            this.adminWaterNaam.Name = "adminWaterNaam";
            this.adminWaterNaam.Size = new System.Drawing.Size(100, 20);
            this.adminWaterNaam.TabIndex = 17;
            this.adminWaterNaam.Text = "Naam van water..";
            // 
            // budgetIjsselmeerChck
            // 
            this.budgetIjsselmeerChck.AutoSize = true;
            this.budgetIjsselmeerChck.Location = new System.Drawing.Point(149, 20);
            this.budgetIjsselmeerChck.Name = "budgetIjsselmeerChck";
            this.budgetIjsselmeerChck.Size = new System.Drawing.Size(72, 17);
            this.budgetIjsselmeerChck.TabIndex = 8;
            this.budgetIjsselmeerChck.Text = "Ijsselmeer";
            this.budgetIjsselmeerChck.UseVisualStyleBackColor = true;
            // 
            // budgetNoordzeeChck
            // 
            this.budgetNoordzeeChck.AutoSize = true;
            this.budgetNoordzeeChck.Location = new System.Drawing.Point(149, 43);
            this.budgetNoordzeeChck.Name = "budgetNoordzeeChck";
            this.budgetNoordzeeChck.Size = new System.Drawing.Size(72, 17);
            this.budgetNoordzeeChck.TabIndex = 9;
            this.budgetNoordzeeChck.Text = "Noordzee";
            this.budgetNoordzeeChck.UseVisualStyleBackColor = true;
            // 
            // sloepkeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.motorBootLB);
            this.Controls.Add(this.adminRadioWijzig);
            this.Controls.Add(this.adminRadioVoegToe);
            this.Controls.Add(this.adminRadioVerwijder);
            this.Controls.Add(this.adminLB);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.x);
            this.Controls.Add(this.LBContracten);
            this.Controls.Add(this.nieuwContractBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AdminWachtwoordTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.adminGB);
            this.Name = "sloepkeForm";
            this.Text = "T Sloepke";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetNUD)).EndInit();
            this.adminGB.ResumeLayout(false);
            this.adminGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AdminWachtwoordTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox budgetBijkomendeArtikelenLB;
        private System.Windows.Forms.ComboBox budgetBijkomendeArtikelenCB;
        private System.Windows.Forms.ComboBox budgetBootCB;
        private System.Windows.Forms.NumericUpDown budgetNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nieuwContractBtn;
        private System.Windows.Forms.ListBox LBContracten;
        private System.Windows.Forms.Button x;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.ListBox adminLB;
        private System.Windows.Forms.RadioButton adminRadioVerwijder;
        private System.Windows.Forms.RadioButton adminRadioVoegToe;
        private System.Windows.Forms.RadioButton adminRadioWijzig;
        private System.Windows.Forms.Button adminLogoutBtn;
        private System.Windows.Forms.ListBox budgetBotenLB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox motorBootLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button adminVoegToeBtn;
        private System.Windows.Forms.GroupBox adminGB;
        private System.Windows.Forms.ComboBox adminMeerCB;
        private System.Windows.Forms.TextBox adminWaterNaam;
        private System.Windows.Forms.CheckBox budgetNoordzeeChck;
        private System.Windows.Forms.CheckBox budgetIjsselmeerChck;
    }
}

