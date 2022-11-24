namespace Course_TISBI_Fitness.MainOffice
{
    partial class CreateClient
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
            this.components = new System.ComponentModel.Container();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.PhoneNumberText = new System.Windows.Forms.TextBox();
            this.BirthdaydateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ClientCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TariffcomboBox = new System.Windows.Forms.ComboBox();
            this.tariffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SecondNametextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.MiddleNametextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(55, 362);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(246, 27);
            this.AddressText.TabIndex = 1;
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.Location = new System.Drawing.Point(403, 292);
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.Size = new System.Drawing.Size(185, 27);
            this.PhoneNumberText.TabIndex = 2;
            // 
            // BirthdaydateTimePicker
            // 
            this.BirthdaydateTimePicker.Location = new System.Drawing.Point(403, 126);
            this.BirthdaydateTimePicker.Name = "BirthdaydateTimePicker";
            this.BirthdaydateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.BirthdaydateTimePicker.TabIndex = 3;
            // 
            // ClientCreate
            // 
            this.ClientCreate.Location = new System.Drawing.Point(463, 375);
            this.ClientCreate.Name = "ClientCreate";
            this.ClientCreate.Size = new System.Drawing.Size(164, 74);
            this.ClientCreate.TabIndex = 4;
            this.ClientCreate.Text = "Создать";
            this.ClientCreate.UseVisualStyleBackColor = true;
            this.ClientCreate.Click += new System.EventHandler(this.ClientCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "День рождения";
            // 
            // TariffcomboBox
            // 
            this.TariffcomboBox.FormattingEnabled = true;
            this.TariffcomboBox.Location = new System.Drawing.Point(403, 203);
            this.TariffcomboBox.Name = "TariffcomboBox";
            this.TariffcomboBox.Size = new System.Drawing.Size(151, 28);
            this.TariffcomboBox.TabIndex = 9;
            this.TariffcomboBox.SelectedIndexChanged += new System.EventHandler(this.TariffcomboBox_SelectedIndexChanged);
            // 
            // tariffBindingSource
            // 
            this.tariffBindingSource.DataSource = typeof(Models.ModelsFitness.Tariff);
            // 
            // SecondNametextBox
            // 
            this.SecondNametextBox.Location = new System.Drawing.Point(55, 126);
            this.SecondNametextBox.Name = "SecondNametextBox";
            this.SecondNametextBox.Size = new System.Drawing.Size(210, 27);
            this.SecondNametextBox.TabIndex = 10;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(55, 203);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(210, 27);
            this.NametextBox.TabIndex = 11;
            // 
            // MiddleNametextBox
            // 
            this.MiddleNametextBox.Location = new System.Drawing.Point(55, 282);
            this.MiddleNametextBox.Name = "MiddleNametextBox";
            this.MiddleNametextBox.Size = new System.Drawing.Size(210, 27);
            this.MiddleNametextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Тариф";
            // 
            // CreateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 533);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MiddleNametextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.SecondNametextBox);
            this.Controls.Add(this.TariffcomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientCreate);
            this.Controls.Add(this.BirthdaydateTimePicker);
            this.Controls.Add(this.PhoneNumberText);
            this.Controls.Add(this.AddressText);
            this.Name = "CreateClient";
            this.Text = "CreateClient";
            this.Load += new System.EventHandler(this.CreateClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox AddressText;
        private TextBox PhoneNumberText;
        private DateTimePicker BirthdaydateTimePicker;
        private Button ClientCreate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox TariffcomboBox;
        private BindingSource tariffBindingSource;
        private TextBox SecondNametextBox;
        private TextBox NametextBox;
        private TextBox MiddleNametextBox;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}