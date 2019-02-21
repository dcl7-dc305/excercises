namespace Wk2Demo
{
    partial class frmWelcome
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
            this.lblWeclome = new System.Windows.Forms.Label();
            this.frmName = new System.Windows.Forms.TextBox();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWeclome
            // 
            this.lblWeclome.AutoSize = true;
            this.lblWeclome.Font = new System.Drawing.Font("Oxygen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeclome.ForeColor = System.Drawing.Color.Lime;
            this.lblWeclome.Location = new System.Drawing.Point(117, 164);
            this.lblWeclome.Name = "lblWeclome";
            this.lblWeclome.Size = new System.Drawing.Size(183, 17);
            this.lblWeclome.TabIndex = 0;
            this.lblWeclome.Text = "Welcome Visual Studio 2017";
            // 
            // frmName
            // 
            this.frmName.Location = new System.Drawing.Point(120, 194);
            this.frmName.Name = "frmName";
            this.frmName.Size = new System.Drawing.Size(180, 21);
            this.frmName.TabIndex = 3;
            // 
            // btnClickMe
            // 
            this.btnClickMe.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClickMe.ForeColor = System.Drawing.Color.White;
            this.btnClickMe.Location = new System.Drawing.Point(120, 235);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(95, 48);
            this.btnClickMe.TabIndex = 2;
            this.btnClickMe.Text = "Click Me!";
            this.btnClickMe.UseVisualStyleBackColor = false;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnClear.Location = new System.Drawing.Point(221, 235);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 48);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(176, 302);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(176, 84);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClickMe);
            this.Controls.Add(this.frmName);
            this.Controls.Add(this.lblWeclome);
            this.Font = new System.Drawing.Font("Oxygen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Aspire2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeclome;
        private System.Windows.Forms.TextBox frmName;
        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
    }
}

