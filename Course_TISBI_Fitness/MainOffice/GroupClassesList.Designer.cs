namespace Course_TISBI_Fitness.MainOffice
{
    partial class GroupClassesList
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
            this.GroupClassesdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GroupClassesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupClassesdataGridView
            // 
            this.GroupClassesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupClassesdataGridView.Location = new System.Drawing.Point(163, 170);
            this.GroupClassesdataGridView.Name = "GroupClassesdataGridView";
            this.GroupClassesdataGridView.RowHeadersWidth = 51;
            this.GroupClassesdataGridView.RowTemplate.Height = 29;
            this.GroupClassesdataGridView.Size = new System.Drawing.Size(807, 399);
            this.GroupClassesdataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Групповые занятия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поиск";
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.Location = new System.Drawing.Point(163, 96);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(94, 29);
            this.Refreshbutton.TabIndex = 3;
            this.Refreshbutton.Text = "Обновить";
            this.Refreshbutton.UseVisualStyleBackColor = true;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(821, 97);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(94, 29);
            this.Searchbutton.TabIndex = 4;
            this.Searchbutton.Text = "Найти";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Location = new System.Drawing.Point(408, 98);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(347, 27);
            this.SearchtextBox.TabIndex = 5;
            // 
            // GroupClassesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 662);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupClassesdataGridView);
            this.Name = "GroupClassesList";
            this.Text = "GroupClassesList";
            this.Load += new System.EventHandler(this.GroupClassesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupClassesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GroupClassesdataGridView;
        private Label label1;
        private Label label2;
        private Button Refreshbutton;
        private Button Searchbutton;
        private TextBox SearchtextBox;
    }
}