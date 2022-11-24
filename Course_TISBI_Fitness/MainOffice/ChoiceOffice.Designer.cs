namespace Course_TISBI_Fitness.MainOffice
{
    partial class ChoiceOffice
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
            this.MainOfficebutton = new System.Windows.Forms.Button();
            this.FilialOnebutton = new System.Windows.Forms.Button();
            this.FilialTwobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainOfficebutton
            // 
            this.MainOfficebutton.Location = new System.Drawing.Point(96, 56);
            this.MainOfficebutton.Name = "MainOfficebutton";
            this.MainOfficebutton.Size = new System.Drawing.Size(200, 61);
            this.MainOfficebutton.TabIndex = 0;
            this.MainOfficebutton.Text = "Главное";
            this.MainOfficebutton.UseVisualStyleBackColor = true;
            this.MainOfficebutton.Click += new System.EventHandler(this.MainOfficebutton_Click);
            // 
            // FilialOnebutton
            // 
            this.FilialOnebutton.Location = new System.Drawing.Point(96, 133);
            this.FilialOnebutton.Name = "FilialOnebutton";
            this.FilialOnebutton.Size = new System.Drawing.Size(200, 61);
            this.FilialOnebutton.TabIndex = 1;
            this.FilialOnebutton.Text = "Филиал первый";
            this.FilialOnebutton.UseVisualStyleBackColor = true;
            this.FilialOnebutton.Click += new System.EventHandler(this.FilialOnebutton_Click);
            // 
            // FilialTwobutton
            // 
            this.FilialTwobutton.Location = new System.Drawing.Point(96, 210);
            this.FilialTwobutton.Name = "FilialTwobutton";
            this.FilialTwobutton.Size = new System.Drawing.Size(200, 61);
            this.FilialTwobutton.TabIndex = 2;
            this.FilialTwobutton.Text = "Филиал второй";
            this.FilialTwobutton.UseVisualStyleBackColor = true;
            this.FilialTwobutton.Click += new System.EventHandler(this.FilialTwobutton_Click);
            // 
            // ChoiceOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 329);
            this.Controls.Add(this.FilialTwobutton);
            this.Controls.Add(this.FilialOnebutton);
            this.Controls.Add(this.MainOfficebutton);
            this.Name = "ChoiceOffice";
            this.Text = "ChoiceOffice";
            this.ResumeLayout(false);

        }

        #endregion

        private Button MainOfficebutton;
        private Button FilialOnebutton;
        private Button FilialTwobutton;
    }
}