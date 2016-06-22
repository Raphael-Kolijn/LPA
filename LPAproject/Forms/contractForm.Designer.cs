namespace LPAproject
{
    partial class contractForm
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
            this.c_SlaOpBtn = new System.Windows.Forms.Button();
            this.c_BootTB1 = new System.Windows.Forms.ComboBox();
            this.c_BijkomendeArtikelenLB = new System.Windows.Forms.ListBox();
            this.c_BijkomendeArtikelenCB = new System.Windows.Forms.ComboBox();
            this.c_Verhuurder = new System.Windows.Forms.TextBox();
            this.c_DTPickerVan = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.c_DTPickerTot = new System.Windows.Forms.DateTimePicker();
            this.c_BootTB2 = new System.Windows.Forms.ComboBox();
            this.c_BootTB3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // c_SlaOpBtn
            // 
            this.c_SlaOpBtn.Location = new System.Drawing.Point(12, 396);
            this.c_SlaOpBtn.Name = "c_SlaOpBtn";
            this.c_SlaOpBtn.Size = new System.Drawing.Size(75, 23);
            this.c_SlaOpBtn.TabIndex = 0;
            this.c_SlaOpBtn.Text = "Sla op";
            this.c_SlaOpBtn.UseVisualStyleBackColor = true;
            // 
            // c_BootTB1
            // 
            this.c_BootTB1.FormattingEnabled = true;
            this.c_BootTB1.Items.AddRange(new object[] {
            "Kano",
            "Motorboot",
            "Zeilboot"});
            this.c_BootTB1.Location = new System.Drawing.Point(12, 35);
            this.c_BootTB1.Name = "c_BootTB1";
            this.c_BootTB1.Size = new System.Drawing.Size(121, 21);
            this.c_BootTB1.TabIndex = 1;
            this.c_BootTB1.Text = "Boot..";
            // 
            // c_BijkomendeArtikelenLB
            // 
            this.c_BijkomendeArtikelenLB.FormattingEnabled = true;
            this.c_BijkomendeArtikelenLB.Location = new System.Drawing.Point(12, 90);
            this.c_BijkomendeArtikelenLB.Name = "c_BijkomendeArtikelenLB";
            this.c_BijkomendeArtikelenLB.Size = new System.Drawing.Size(187, 199);
            this.c_BijkomendeArtikelenLB.TabIndex = 5;
            // 
            // c_BijkomendeArtikelenCB
            // 
            this.c_BijkomendeArtikelenCB.FormattingEnabled = true;
            this.c_BijkomendeArtikelenCB.Items.AddRange(new object[] {
            "zwemvest",
            "peddel",
            "dekzeil",
            "kampeerset"});
            this.c_BijkomendeArtikelenCB.Location = new System.Drawing.Point(12, 62);
            this.c_BijkomendeArtikelenCB.Name = "c_BijkomendeArtikelenCB";
            this.c_BijkomendeArtikelenCB.Size = new System.Drawing.Size(121, 21);
            this.c_BijkomendeArtikelenCB.TabIndex = 4;
            this.c_BijkomendeArtikelenCB.Text = "Bijkomde artikelen..";
            // 
            // c_Verhuurder
            // 
            this.c_Verhuurder.Location = new System.Drawing.Point(12, 9);
            this.c_Verhuurder.Name = "c_Verhuurder";
            this.c_Verhuurder.Size = new System.Drawing.Size(100, 20);
            this.c_Verhuurder.TabIndex = 6;
            this.c_Verhuurder.Text = "Verhuurder..";
            // 
            // c_DTPickerVan
            // 
            this.c_DTPickerVan.Location = new System.Drawing.Point(44, 311);
            this.c_DTPickerVan.Name = "c_DTPickerVan";
            this.c_DTPickerVan.Size = new System.Drawing.Size(200, 20);
            this.c_DTPickerVan.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Van:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tot:";
            // 
            // c_DTPickerTot
            // 
            this.c_DTPickerTot.Location = new System.Drawing.Point(44, 342);
            this.c_DTPickerTot.Name = "c_DTPickerTot";
            this.c_DTPickerTot.Size = new System.Drawing.Size(200, 20);
            this.c_DTPickerTot.TabIndex = 10;
            // 
            // c_BootTB2
            // 
            this.c_BootTB2.FormattingEnabled = true;
            this.c_BootTB2.Items.AddRange(new object[] {
            "Kano",
            "Motorboot",
            "Zeilboot"});
            this.c_BootTB2.Location = new System.Drawing.Point(139, 35);
            this.c_BootTB2.Name = "c_BootTB2";
            this.c_BootTB2.Size = new System.Drawing.Size(121, 21);
            this.c_BootTB2.TabIndex = 11;
            this.c_BootTB2.Text = "Boot..";
            // 
            // c_BootTB3
            // 
            this.c_BootTB3.FormattingEnabled = true;
            this.c_BootTB3.Items.AddRange(new object[] {
            "Kano",
            "Motorboot",
            "Zeilboot"});
            this.c_BootTB3.Location = new System.Drawing.Point(266, 35);
            this.c_BootTB3.Name = "c_BootTB3";
            this.c_BootTB3.Size = new System.Drawing.Size(121, 21);
            this.c_BootTB3.TabIndex = 12;
            this.c_BootTB3.Text = "Boot..";
            // 
            // contractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 431);
            this.Controls.Add(this.c_BootTB3);
            this.Controls.Add(this.c_BootTB2);
            this.Controls.Add(this.c_DTPickerTot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c_DTPickerVan);
            this.Controls.Add(this.c_Verhuurder);
            this.Controls.Add(this.c_BijkomendeArtikelenLB);
            this.Controls.Add(this.c_BijkomendeArtikelenCB);
            this.Controls.Add(this.c_BootTB1);
            this.Controls.Add(this.c_SlaOpBtn);
            this.Name = "contractForm";
            this.Text = "contract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button c_SlaOpBtn;
        private System.Windows.Forms.ComboBox c_BootTB1;
        private System.Windows.Forms.ListBox c_BijkomendeArtikelenLB;
        private System.Windows.Forms.ComboBox c_BijkomendeArtikelenCB;
        private System.Windows.Forms.TextBox c_Verhuurder;
        private System.Windows.Forms.DateTimePicker c_DTPickerVan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker c_DTPickerTot;
        private System.Windows.Forms.ComboBox c_BootTB2;
        private System.Windows.Forms.ComboBox c_BootTB3;
    }
}