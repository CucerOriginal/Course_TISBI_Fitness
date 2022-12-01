namespace Course_TISBI_Fitness.MainOffice
{
    partial class ExtendAbonement
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
            this.label1 = new System.Windows.Forms.Label();
            this.TariffcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FIOlabel = new System.Windows.Forms.Label();
            this.ExtendAbonbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиент";
            // 
            // TariffcomboBox
            // 
            this.TariffcomboBox.FormattingEnabled = true;
            this.TariffcomboBox.Location = new System.Drawing.Point(246, 81);
            this.TariffcomboBox.Name = "TariffcomboBox";
            this.TariffcomboBox.Size = new System.Drawing.Size(151, 28);
            this.TariffcomboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тариф";
            // 
            // FIOlabel
            // 
            this.FIOlabel.AutoSize = true;
            this.FIOlabel.Location = new System.Drawing.Point(12, 84);
            this.FIOlabel.Name = "FIOlabel";
            this.FIOlabel.Size = new System.Drawing.Size(50, 20);
            this.FIOlabel.TabIndex = 3;
            this.FIOlabel.Text = "label3";
            // 
            // ExtendAbonbutton
            // 
            this.ExtendAbonbutton.Location = new System.Drawing.Point(303, 151);
            this.ExtendAbonbutton.Name = "ExtendAbonbutton";
            this.ExtendAbonbutton.Size = new System.Drawing.Size(94, 29);
            this.ExtendAbonbutton.TabIndex = 4;
            this.ExtendAbonbutton.Text = "Продлить";
            this.ExtendAbonbutton.UseVisualStyleBackColor = true;
            this.ExtendAbonbutton.Click += new System.EventHandler(this.ExtendAbonbutton_Click);
            // 
            // ExtendAbonement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 220);
            this.Controls.Add(this.ExtendAbonbutton);
            this.Controls.Add(this.FIOlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TariffcomboBox);
            this.Controls.Add(this.label1);
            this.Name = "ExtendAbonement";
            this.Text = "ExtendAbonement";
            this.Load += new System.EventHandler(this.ExtendAbonement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox TariffcomboBox;
        private Label label2;
        private Label FIOlabel;
        private Button ExtendAbonbutton;
    }
}