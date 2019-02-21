namespace wk3Excercise
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDivide = new System.Windows.Forms.Button();
            this.txtPhysics = new System.Windows.Forms.TextBox();
            this.txtChem = new System.Windows.Forms.TextBox();
            this.txtCA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roll No.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Physics:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chemistry:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Computer Application:";
            // 
            // txtRoll
            // 
            this.txtRoll.Location = new System.Drawing.Point(144, 31);
            this.txtRoll.MaxLength = 1000;
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(121, 20);
            this.txtRoll.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(144, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 6;
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(27, 200);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(238, 60);
            this.btnDivide.TabIndex = 10;
            this.btnDivide.Text = "What\'s My Division?";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // txtPhysics
            // 
            this.txtPhysics.Location = new System.Drawing.Point(144, 97);
            this.txtPhysics.Name = "txtPhysics";
            this.txtPhysics.Size = new System.Drawing.Size(121, 20);
            this.txtPhysics.TabIndex = 11;
            // 
            // txtChem
            // 
            this.txtChem.Location = new System.Drawing.Point(144, 124);
            this.txtChem.Name = "txtChem";
            this.txtChem.Size = new System.Drawing.Size(121, 20);
            this.txtChem.TabIndex = 12;
            // 
            // txtCA
            // 
            this.txtCA.Location = new System.Drawing.Point(144, 153);
            this.txtCA.Name = "txtCA";
            this.txtCA.Size = new System.Drawing.Size(121, 20);
            this.txtCA.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 289);
            this.Controls.Add(this.txtCA);
            this.Controls.Add(this.txtChem);
            this.Controls.Add(this.txtPhysics);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRoll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Test Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoll;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.TextBox txtPhysics;
        private System.Windows.Forms.TextBox txtChem;
        private System.Windows.Forms.TextBox txtCA;
    }
}

