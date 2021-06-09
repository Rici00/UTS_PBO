
namespace GuitarCachier
{
    partial class LoginVerif
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
            this.lblUN = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.btnOkLgn = new System.Windows.Forms.Button();
            this.btnExitLgn = new System.Windows.Forms.Button();
            this.tbUname = new System.Windows.Forms.TextBox();
            this.tbPassw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUN.Location = new System.Drawing.Point(37, 32);
            this.lblUN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(88, 17);
            this.lblUN.TabIndex = 0;
            this.lblUN.Text = "Username :";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPW.Location = new System.Drawing.Point(37, 64);
            this.lblPW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(88, 17);
            this.lblPW.TabIndex = 1;
            this.lblPW.Text = "Password :";
            // 
            // btnOkLgn
            // 
            this.btnOkLgn.Location = new System.Drawing.Point(69, 116);
            this.btnOkLgn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOkLgn.Name = "btnOkLgn";
            this.btnOkLgn.Size = new System.Drawing.Size(56, 28);
            this.btnOkLgn.TabIndex = 2;
            this.btnOkLgn.Text = "Okay";
            this.btnOkLgn.UseVisualStyleBackColor = true;
            this.btnOkLgn.Click += new System.EventHandler(this.btnOkLgn_Click);
            // 
            // btnExitLgn
            // 
            this.btnExitLgn.Location = new System.Drawing.Point(168, 116);
            this.btnExitLgn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExitLgn.Name = "btnExitLgn";
            this.btnExitLgn.Size = new System.Drawing.Size(56, 28);
            this.btnExitLgn.TabIndex = 3;
            this.btnExitLgn.Text = "Exit";
            this.btnExitLgn.UseVisualStyleBackColor = true;
            this.btnExitLgn.Click += new System.EventHandler(this.btnExitLgn_Click);
            // 
            // tbUname
            // 
            this.tbUname.Location = new System.Drawing.Point(146, 31);
            this.tbUname.Name = "tbUname";
            this.tbUname.Size = new System.Drawing.Size(110, 20);
            this.tbUname.TabIndex = 4;
            // 
            // tbPassw
            // 
            this.tbPassw.Location = new System.Drawing.Point(146, 63);
            this.tbPassw.Name = "tbPassw";
            this.tbPassw.Size = new System.Drawing.Size(110, 20);
            this.tbPassw.TabIndex = 5;
            // 
            // LoginVerif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(298, 164);
            this.Controls.Add(this.tbPassw);
            this.Controls.Add(this.tbUname);
            this.Controls.Add(this.btnExitLgn);
            this.Controls.Add(this.btnOkLgn);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.lblUN);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginVerif";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.LoginVerif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Button btnOkLgn;
        private System.Windows.Forms.Button btnExitLgn;
        private System.Windows.Forms.TextBox tbUname;
        private System.Windows.Forms.TextBox tbPassw;
    }
}