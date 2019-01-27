namespace BasnoStroj
{
    partial class Form1
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
            this.tbOutPut = new System.Windows.Forms.TextBox();
            this.btnGenerujBasen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbOutPut
            // 
            this.tbOutPut.Location = new System.Drawing.Point(38, 30);
            this.tbOutPut.Multiline = true;
            this.tbOutPut.Name = "tbOutPut";
            this.tbOutPut.Size = new System.Drawing.Size(513, 290);
            this.tbOutPut.TabIndex = 0;
            // 
            // btnGenerujBasen
            // 
            this.btnGenerujBasen.Location = new System.Drawing.Point(598, 41);
            this.btnGenerujBasen.Name = "btnGenerujBasen";
            this.btnGenerujBasen.Size = new System.Drawing.Size(105, 56);
            this.btnGenerujBasen.TabIndex = 1;
            this.btnGenerujBasen.Text = "Vygeneruj Basen";
            this.btnGenerujBasen.UseVisualStyleBackColor = true;
            this.btnGenerujBasen.Click += new System.EventHandler(this.btnGenerujBasen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerujBasen);
            this.Controls.Add(this.tbOutPut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutPut;
        private System.Windows.Forms.Button btnGenerujBasen;
    }
}

