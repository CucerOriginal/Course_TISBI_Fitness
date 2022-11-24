namespace Course_TISBI_Fitness.MainOffice
{
    partial class MainOfficeForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffActionTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tariffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tariffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CreateAbonement = new System.Windows.Forms.Button();
            this.AbonementList = new System.Windows.Forms.Button();
            this.TrainerListbutton = new System.Windows.Forms.Button();
            this.GroupClassesListbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tariffNameDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.tariffActionTimeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tariffBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(240, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(555, 297);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // tariffNameDataGridViewTextBoxColumn
            // 
            this.tariffNameDataGridViewTextBoxColumn.DataPropertyName = "TariffName";
            this.tariffNameDataGridViewTextBoxColumn.HeaderText = "Тарифы";
            this.tariffNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tariffNameDataGridViewTextBoxColumn.Name = "tariffNameDataGridViewTextBoxColumn";
            this.tariffNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // tariffActionTimeDataGridViewTextBoxColumn
            // 
            this.tariffActionTimeDataGridViewTextBoxColumn.DataPropertyName = "TariffActionTime";
            this.tariffActionTimeDataGridViewTextBoxColumn.HeaderText = "Длительность абонемента";
            this.tariffActionTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tariffActionTimeDataGridViewTextBoxColumn.Name = "tariffActionTimeDataGridViewTextBoxColumn";
            this.tariffActionTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // tariffBindingSource2
            // 
            this.tariffBindingSource2.DataSource = typeof(Models.ModelsFitness.Tariff);
            // 
            // tariffBindingSource1
            // 
            this.tariffBindingSource1.DataSource = typeof(Models.ModelsFitness.Tariff);
            // 
            // tariffBindingSource
            // 
            this.tariffBindingSource.DataSource = typeof(Models.ModelsFitness.Tariff);
            // 
            // CreateAbonement
            // 
            this.CreateAbonement.Location = new System.Drawing.Point(660, 376);
            this.CreateAbonement.Name = "CreateAbonement";
            this.CreateAbonement.Size = new System.Drawing.Size(167, 29);
            this.CreateAbonement.TabIndex = 1;
            this.CreateAbonement.Text = "Создать Абонемент";
            this.CreateAbonement.UseVisualStyleBackColor = true;
            this.CreateAbonement.Click += new System.EventHandler(this.CreateAbonement_Click);
            // 
            // AbonementList
            // 
            this.AbonementList.Location = new System.Drawing.Point(34, 74);
            this.AbonementList.Name = "AbonementList";
            this.AbonementList.Size = new System.Drawing.Size(179, 29);
            this.AbonementList.TabIndex = 2;
            this.AbonementList.Text = "Список Абонементов";
            this.AbonementList.UseVisualStyleBackColor = true;
            this.AbonementList.Click += new System.EventHandler(this.AbonementList_Click);
            // 
            // TrainerListbutton
            // 
            this.TrainerListbutton.Location = new System.Drawing.Point(34, 173);
            this.TrainerListbutton.Name = "TrainerListbutton";
            this.TrainerListbutton.Size = new System.Drawing.Size(179, 29);
            this.TrainerListbutton.TabIndex = 3;
            this.TrainerListbutton.Text = "Список Тренеров";
            this.TrainerListbutton.UseVisualStyleBackColor = true;
            this.TrainerListbutton.Click += new System.EventHandler(this.TrainerListbutton_Click);
            // 
            // GroupClassesListbutton
            // 
            this.GroupClassesListbutton.Location = new System.Drawing.Point(34, 270);
            this.GroupClassesListbutton.Name = "GroupClassesListbutton";
            this.GroupClassesListbutton.Size = new System.Drawing.Size(179, 29);
            this.GroupClassesListbutton.TabIndex = 4;
            this.GroupClassesListbutton.Text = "Групповые занятия";
            this.GroupClassesListbutton.UseVisualStyleBackColor = true;
            this.GroupClassesListbutton.Click += new System.EventHandler(this.GroupClassesListbutton_Click);
            // 
            // MainOfficeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 427);
            this.Controls.Add(this.GroupClassesListbutton);
            this.Controls.Add(this.TrainerListbutton);
            this.Controls.Add(this.AbonementList);
            this.Controls.Add(this.CreateAbonement);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainOfficeForm";
            this.Text = "MainOfficeForm";
            this.Load += new System.EventHandler(this.MainOfficeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource tariffBindingSource;
        private BindingSource tariffBindingSource1;
        private BindingSource tariffBindingSource2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tariffNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tariffActionTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private Button CreateAbonement;
        private Button AbonementList;
        private Button TrainerListbutton;
        private Button GroupClassesListbutton;
    }
}