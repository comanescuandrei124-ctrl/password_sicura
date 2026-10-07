namespace password_sicura
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
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.btn_n1 = new System.Windows.Forms.Button();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Font = new System.Drawing.Font("MingLiU-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.Location = new System.Drawing.Point(107, 9);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(621, 29);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "Inserire la password (3 tentativi max)";
            // 
            // btn_n1
            // 
            this.btn_n1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_n1.Location = new System.Drawing.Point(302, 141);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(219, 84);
            this.btn_n1.TabIndex = 1;
            this.btn_n1.Text = "CONFERMA";
            this.btn_n1.UseVisualStyleBackColor = true;
            this.btn_n1.Click += new System.EventHandler(this.btn_n1_Click);
            // 
            // txt_n1
            // 
            this.txt_n1.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n1.Location = new System.Drawing.Point(185, 77);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(474, 34);
            this.txt_n1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.btn_n1);
            this.Controls.Add(this.lbl_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Button btn_n1;
        private System.Windows.Forms.TextBox txt_n1;
    }
}

