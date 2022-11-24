namespace Course_TISBI_Fitness.MainOffice
{
    partial class AllClientsListForm
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
            this.AllClietnsListdataGridView = new System.Windows.Forms.DataGridView();
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllClietnsListdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllClietnsListdataGridView
            // 
            this.AllClietnsListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllClietnsListdataGridView.Location = new System.Drawing.Point(50, 101);
            this.AllClietnsListdataGridView.Name = "AllClietnsListdataGridView";
            this.AllClietnsListdataGridView.RowHeadersWidth = 51;
            this.AllClietnsListdataGridView.RowTemplate.Height = 29;
            this.AllClietnsListdataGridView.Size = new System.Drawing.Size(734, 377);
            this.AllClietnsListdataGridView.TabIndex = 0;
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.Location = new System.Drawing.Point(50, 46);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(94, 29);
            this.Refreshbutton.TabIndex = 1;
            this.Refreshbutton.Text = "Обновить";
            this.Refreshbutton.UseVisualStyleBackColor = true;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(618, 46);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(94, 29);
            this.Searchbutton.TabIndex = 2;
            this.Searchbutton.Text = "Найти";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Location = new System.Drawing.Point(269, 48);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(314, 27);
            this.SearchtextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Все клиенты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Поиск";
            // 
            // AllClientsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.AllClietnsListdataGridView);
            this.Name = "AllClientsListForm";
            this.Text = "AllClientsListForm";
            this.Load += new System.EventHandler(this.AllClientsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllClietnsListdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView AllClietnsListdataGridView;
        private Button Refreshbutton;
        private Button Searchbutton;
        private TextBox SearchtextBox;
        private Label label1;
        private Label label2;
    }
}