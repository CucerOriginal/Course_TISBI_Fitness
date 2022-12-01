namespace Course_TISBI_Fitness.MainOffice
{
    partial class AbonementsList
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
            this.ClientsdataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartAbonement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndAbonement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Button();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.UpdateDatabutton = new System.Windows.Forms.Button();
            this.VisitsShowbutton = new System.Windows.Forms.Button();
            this.TrainerTimeShowbutton = new System.Windows.Forms.Button();
            this.CreateTrainerVisit = new System.Windows.Forms.Button();
            this.AllClientsListbutton = new System.Windows.Forms.Button();
            this.updateAdonementButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsdataGridView
            // 
            this.ClientsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.SecondName,
            this.Name,
            this.MiddleName,
            this.addressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.StartAbonement,
            this.EndAbonement});
            this.ClientsdataGridView.Location = new System.Drawing.Point(73, 131);
            this.ClientsdataGridView.Name = "ClientsdataGridView";
            this.ClientsdataGridView.RowHeadersWidth = 51;
            this.ClientsdataGridView.RowTemplate.Height = 29;
            this.ClientsdataGridView.Size = new System.Drawing.Size(904, 299);
            this.ClientsdataGridView.TabIndex = 0;
            this.ClientsdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsdataGridView_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // SecondName
            // 
            this.SecondName.DataPropertyName = "SecondName";
            this.SecondName.HeaderText = "SecondName";
            this.SecondName.MinimumWidth = 6;
            this.SecondName.Name = "SecondName";
            this.SecondName.Width = 125;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // MiddleName
            // 
            this.MiddleName.DataPropertyName = "MiddleName";
            this.MiddleName.HeaderText = "MiddleName";
            this.MiddleName.MinimumWidth = 6;
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.Width = 125;
            // 
            // StartAbonement
            // 
            this.StartAbonement.DataPropertyName = "StartAbonement";
            this.StartAbonement.HeaderText = "StartAbonement";
            this.StartAbonement.MinimumWidth = 6;
            this.StartAbonement.Name = "StartAbonement";
            this.StartAbonement.Width = 125;
            // 
            // EndAbonement
            // 
            this.EndAbonement.DataPropertyName = "EndAbonement";
            this.EndAbonement.HeaderText = "EndAbonement";
            this.EndAbonement.MinimumWidth = 6;
            this.EndAbonement.Name = "EndAbonement";
            this.EndAbonement.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Клиенты";
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(73, 489);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(94, 29);
            this.Change.TabIndex = 4;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Location = new System.Drawing.Point(322, 56);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(418, 27);
            this.SearchtextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поиск";
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(789, 56);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(94, 29);
            this.Searchbutton.TabIndex = 7;
            this.Searchbutton.Text = "Найти";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // UpdateDatabutton
            // 
            this.UpdateDatabutton.Location = new System.Drawing.Point(73, 56);
            this.UpdateDatabutton.Name = "UpdateDatabutton";
            this.UpdateDatabutton.Size = new System.Drawing.Size(94, 29);
            this.UpdateDatabutton.TabIndex = 8;
            this.UpdateDatabutton.Text = "Обновить";
            this.UpdateDatabutton.UseVisualStyleBackColor = true;
            this.UpdateDatabutton.Click += new System.EventHandler(this.UpdateDatabutton_Click);
            // 
            // VisitsShowbutton
            // 
            this.VisitsShowbutton.Location = new System.Drawing.Point(501, 489);
            this.VisitsShowbutton.Name = "VisitsShowbutton";
            this.VisitsShowbutton.Size = new System.Drawing.Size(239, 29);
            this.VisitsShowbutton.TabIndex = 9;
            this.VisitsShowbutton.Text = "Показать посещения";
            this.VisitsShowbutton.UseVisualStyleBackColor = true;
            this.VisitsShowbutton.Click += new System.EventHandler(this.VisitsShowbutton_Click);
            // 
            // TrainerTimeShowbutton
            // 
            this.TrainerTimeShowbutton.Location = new System.Drawing.Point(217, 489);
            this.TrainerTimeShowbutton.Name = "TrainerTimeShowbutton";
            this.TrainerTimeShowbutton.Size = new System.Drawing.Size(239, 29);
            this.TrainerTimeShowbutton.TabIndex = 10;
            this.TrainerTimeShowbutton.Text = "Показать занятия с тренером";
            this.TrainerTimeShowbutton.UseVisualStyleBackColor = true;
            this.TrainerTimeShowbutton.Click += new System.EventHandler(this.TrainerTimeShowbutton_Click);
            // 
            // CreateTrainerVisit
            // 
            this.CreateTrainerVisit.Location = new System.Drawing.Point(767, 515);
            this.CreateTrainerVisit.Name = "CreateTrainerVisit";
            this.CreateTrainerVisit.Size = new System.Drawing.Size(210, 29);
            this.CreateTrainerVisit.TabIndex = 11;
            this.CreateTrainerVisit.Text = "Создать запись с тренером";
            this.CreateTrainerVisit.UseVisualStyleBackColor = true;
            this.CreateTrainerVisit.Click += new System.EventHandler(this.CreateTrainerVisit_Click);
            // 
            // AllClientsListbutton
            // 
            this.AllClientsListbutton.Location = new System.Drawing.Point(790, 97);
            this.AllClientsListbutton.Name = "AllClientsListbutton";
            this.AllClientsListbutton.Size = new System.Drawing.Size(187, 29);
            this.AllClientsListbutton.TabIndex = 12;
            this.AllClientsListbutton.Text = "Показать всех клиентов";
            this.AllClientsListbutton.UseVisualStyleBackColor = true;
            this.AllClientsListbutton.Click += new System.EventHandler(this.AllClientsListbutton_Click);
            // 
            // updateAdonementButton
            // 
            this.updateAdonementButton.Location = new System.Drawing.Point(767, 465);
            this.updateAdonementButton.Name = "updateAdonementButton";
            this.updateAdonementButton.Size = new System.Drawing.Size(210, 29);
            this.updateAdonementButton.TabIndex = 13;
            this.updateAdonementButton.Text = "Продлить абонемент";
            this.updateAdonementButton.UseVisualStyleBackColor = true;
            this.updateAdonementButton.Click += new System.EventHandler(this.updateAdonementButton_Click);
            // 
            // AbonementsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 578);
            this.Controls.Add(this.updateAdonementButton);
            this.Controls.Add(this.AllClientsListbutton);
            this.Controls.Add(this.CreateTrainerVisit);
            this.Controls.Add(this.TrainerTimeShowbutton);
            this.Controls.Add(this.VisitsShowbutton);
            this.Controls.Add(this.UpdateDatabutton);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientsdataGridView);
            this.Text = "AbonementsList";
            this.Load += new System.EventHandler(this.AbonementsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView ClientsdataGridView;
        private Label label2;
        private Button Change;
        private TextBox SearchtextBox;
        private Label label1;
        private Button Searchbutton;
        private Button UpdateDatabutton;
        private Button VisitsShowbutton;
        private Button TrainerTimeShowbutton;
        private Button CreateTrainerVisit;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn SecondName;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn MiddleName;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn StartAbonement;
        private DataGridViewTextBoxColumn EndAbonement;
        private Button AllClientsListbutton;
        private Button updateAdonementButton;
    }
}