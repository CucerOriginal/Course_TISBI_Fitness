namespace Course_TISBI_Fitness.MainOffice
{
    partial class TrainerList
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
            this.TraineListdataGridView = new System.Windows.Forms.DataGridView();
            this.trainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.VisitShowbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TraineListdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TraineListdataGridView
            // 
            this.TraineListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TraineListdataGridView.Location = new System.Drawing.Point(101, 129);
            this.TraineListdataGridView.Name = "TraineListdataGridView";
            this.TraineListdataGridView.RowHeadersWidth = 51;
            this.TraineListdataGridView.RowTemplate.Height = 29;
            this.TraineListdataGridView.Size = new System.Drawing.Size(779, 332);
            this.TraineListdataGridView.TabIndex = 0;
            this.TraineListdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TraineListdataGridView_CellClick);
            // 
            // trainerBindingSource
            // 
            this.trainerBindingSource.DataSource = typeof(Models.ModelsFitness.Trainer);
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Location = new System.Drawing.Point(319, 80);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(347, 27);
            this.SearchtextBox.TabIndex = 1;
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(720, 80);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(94, 29);
            this.Searchbutton.TabIndex = 2;
            this.Searchbutton.Text = "Найти";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.Location = new System.Drawing.Point(101, 58);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(94, 29);
            this.Refreshbutton.TabIndex = 3;
            this.Refreshbutton.Text = "Обновить";
            this.Refreshbutton.UseVisualStyleBackColor = true;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // VisitShowbutton
            // 
            this.VisitShowbutton.Location = new System.Drawing.Point(651, 506);
            this.VisitShowbutton.Name = "VisitShowbutton";
            this.VisitShowbutton.Size = new System.Drawing.Size(199, 29);
            this.VisitShowbutton.TabIndex = 4;
            this.VisitShowbutton.Text = "Показать занятия";
            this.VisitShowbutton.UseVisualStyleBackColor = true;
            this.VisitShowbutton.Click += new System.EventHandler(this.VisitShowbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поиск";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тренеры";
            // 
            // TrainerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VisitShowbutton);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.TraineListdataGridView);
            this.Name = "TrainerList";
            this.Text = "TrainerList";
            this.Load += new System.EventHandler(this.TrainerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TraineListdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView TraineListdataGridView;
        private BindingSource trainerBindingSource;
        private TextBox SearchtextBox;
        private Button Searchbutton;
        private Button Refreshbutton;
        private Button VisitShowbutton;
        private Label label1;
        private Label label2;
    }
}