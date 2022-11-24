namespace Course_TISBI_Fitness.MainOffice
{
    partial class CreateVisitClientsWithTrainer
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
            this.CreateVisit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TrainercomboBox = new System.Windows.Forms.ComboBox();
            this.TrainermonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.StartTimecomboBox = new System.Windows.Forms.ComboBox();
            this.EndTimecomboBox = new System.Windows.Forms.ComboBox();
            this.ClientsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TrainerTimedataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TrainerTimedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateVisit
            // 
            this.CreateVisit.Location = new System.Drawing.Point(635, 357);
            this.CreateVisit.Name = "CreateVisit";
            this.CreateVisit.Size = new System.Drawing.Size(94, 29);
            this.CreateVisit.TabIndex = 0;
            this.CreateVisit.Text = "Создать";
            this.CreateVisit.UseVisualStyleBackColor = true;
            this.CreateVisit.Click += new System.EventHandler(this.CreateVisit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Клиенты";
            // 
            // TrainercomboBox
            // 
            this.TrainercomboBox.FormattingEnabled = true;
            this.TrainercomboBox.Location = new System.Drawing.Point(233, 113);
            this.TrainercomboBox.Name = "TrainercomboBox";
            this.TrainercomboBox.Size = new System.Drawing.Size(208, 28);
            this.TrainercomboBox.TabIndex = 2;
            this.TrainercomboBox.SelectedIndexChanged += new System.EventHandler(this.TrainercomboBox_SelectedIndexChanged);
            // 
            // TrainermonthCalendar
            // 
            this.TrainermonthCalendar.Location = new System.Drawing.Point(469, 50);
            this.TrainermonthCalendar.MaxSelectionCount = 1;
            this.TrainermonthCalendar.Name = "TrainermonthCalendar";
            this.TrainermonthCalendar.TabIndex = 3;
            this.TrainermonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.TrainermonthCalendar_DateChanged);
            // 
            // StartTimecomboBox
            // 
            this.StartTimecomboBox.FormattingEnabled = true;
            this.StartTimecomboBox.Items.AddRange(new object[] {
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00"});
            this.StartTimecomboBox.Location = new System.Drawing.Point(376, 289);
            this.StartTimecomboBox.Name = "StartTimecomboBox";
            this.StartTimecomboBox.Size = new System.Drawing.Size(151, 28);
            this.StartTimecomboBox.TabIndex = 4;
            // 
            // EndTimecomboBox
            // 
            this.EndTimecomboBox.FormattingEnabled = true;
            this.EndTimecomboBox.Items.AddRange(new object[] {
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00"});
            this.EndTimecomboBox.Location = new System.Drawing.Point(578, 289);
            this.EndTimecomboBox.Name = "EndTimecomboBox";
            this.EndTimecomboBox.Size = new System.Drawing.Size(151, 28);
            this.EndTimecomboBox.TabIndex = 5;
            // 
            // ClientsComboBox
            // 
            this.ClientsComboBox.FormattingEnabled = true;
            this.ClientsComboBox.Location = new System.Drawing.Point(26, 113);
            this.ClientsComboBox.Name = "ClientsComboBox";
            this.ClientsComboBox.Size = new System.Drawing.Size(192, 28);
            this.ClientsComboBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тренеры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Начало тренировки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Конец тренировки";
            // 
            // TrainerTimedataGridView
            // 
            this.TrainerTimedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrainerTimedataGridView.Location = new System.Drawing.Point(810, 50);
            this.TrainerTimedataGridView.Name = "TrainerTimedataGridView";
            this.TrainerTimedataGridView.RowHeadersWidth = 51;
            this.TrainerTimedataGridView.RowTemplate.Height = 29;
            this.TrainerTimedataGridView.Size = new System.Drawing.Size(291, 297);
            this.TrainerTimedataGridView.TabIndex = 10;
            // 
            // CreateVisitClientsWithTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 436);
            this.Controls.Add(this.TrainerTimedataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientsComboBox);
            this.Controls.Add(this.EndTimecomboBox);
            this.Controls.Add(this.StartTimecomboBox);
            this.Controls.Add(this.TrainermonthCalendar);
            this.Controls.Add(this.TrainercomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateVisit);
            this.Name = "CreateVisitClientsWithTrainer";
            this.Text = "CreateVisitClientsWithTrainer";
            this.Load += new System.EventHandler(this.CreateVisitClientsWithTrainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrainerTimedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CreateVisit;
        private Label label1;
        private ComboBox TrainercomboBox;
        private MonthCalendar TrainermonthCalendar;
        private ComboBox StartTimecomboBox;
        private ComboBox EndTimecomboBox;
        private ComboBox ClientsComboBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView TrainerTimedataGridView;
    }
}