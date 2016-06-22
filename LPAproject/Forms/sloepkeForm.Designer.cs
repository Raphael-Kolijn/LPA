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
            this.listView1 = new System.Windows.Forms.ListView();
            this.AdminWachtwoordTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.budgetNUD = new System.Windows.Forms.NumericUpDown();
            this.budgetBootCB = new System.Windows.Forms.ComboBox();
            this.budgetBijkomendeArtikelenCB = new System.Windows.Forms.ComboBox();
            this.budgetBijkomendeArtikelenLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetNUD)).BeginInit();
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
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(520, 84);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(272, 345);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.budgetBijkomendeArtikelenLB);
            this.groupBox2.Controls.Add(this.budgetBijkomendeArtikelenCB);
            this.groupBox2.Controls.Add(this.budgetBootCB);
            this.groupBox2.Controls.Add(this.budgetNUD);
            this.groupBox2.Location = new System.Drawing.Point(13, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 306);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Budget Berekening";
            // 
            // budgetNUD
            // 
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
            1,
            0,
            0,
            0});
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
            this.budgetBijkomendeArtikelenCB.Text = "Bijkomde artikelen..";
            this.budgetBijkomendeArtikelenCB.SelectedIndexChanged += new System.EventHandler(this.budgetBijkomendeArtikelenCB_SelectedIndexChanged);
            // 
            // budgetBijkomendeArtikelenLB
            // 
            this.budgetBijkomendeArtikelenLB.FormattingEnabled = true;
            this.budgetBijkomendeArtikelenLB.Location = new System.Drawing.Point(7, 102);
            this.budgetBijkomendeArtikelenLB.Name = "budgetBijkomendeArtikelenLB";
            this.budgetBijkomendeArtikelenLB.Size = new System.Drawing.Size(187, 199);
            this.budgetBijkomendeArtikelenLB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contracten";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exporteer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(520, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Nieuw contract";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AdminWachtwoordTextBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "T Sloepke";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.budgetNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox AdminWachtwoordTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox budgetBijkomendeArtikelenLB;
        private System.Windows.Forms.ComboBox budgetBijkomendeArtikelenCB;
        private System.Windows.Forms.ComboBox budgetBootCB;
        private System.Windows.Forms.NumericUpDown budgetNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

