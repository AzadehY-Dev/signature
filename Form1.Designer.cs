namespace signature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnllogin = new System.Windows.Forms.Panel();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.pnlfile = new System.Windows.Forms.Panel();
            this.btnsave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnconvert = new System.Windows.Forms.Button();
            this.btnopenfile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.openfile = new System.Windows.Forms.OpenFileDialog();
            this.lblfilepath = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnllogin.SuspendLayout();
            this.pnlfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::signature.Properties.Resources.ng2;
            this.pictureBox2.Location = new System.Drawing.Point(2, 268);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 122);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(151, 105);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(165, 28);
            this.txtpassword.TabIndex = 2;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(182, 159);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(67, 32);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Auto Signature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "August  2016 ";
            // 
            // pnllogin
            // 
            this.pnllogin.Controls.Add(this.btnlogin);
            this.pnllogin.Controls.Add(this.txtusername);
            this.pnllogin.Controls.Add(this.txtpassword);
            this.pnllogin.Controls.Add(this.label2);
            this.pnllogin.Controls.Add(this.label1);
            this.pnllogin.Location = new System.Drawing.Point(140, 31);
            this.pnllogin.Name = "pnllogin";
            this.pnllogin.Size = new System.Drawing.Size(425, 219);
            this.pnllogin.TabIndex = 8;
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(151, 40);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(165, 28);
            this.txtusername.TabIndex = 2;
            // 
            // pnlfile
            // 
            this.pnlfile.Controls.Add(this.btnsave);
            this.pnlfile.Controls.Add(this.label6);
            this.pnlfile.Controls.Add(this.btnconvert);
            this.pnlfile.Controls.Add(this.btnopenfile);
            this.pnlfile.Controls.Add(this.label5);
            this.pnlfile.Location = new System.Drawing.Point(12, 4);
            this.pnlfile.Name = "pnlfile";
            this.pnlfile.Size = new System.Drawing.Size(622, 258);
            this.pnlfile.TabIndex = 10;
            this.pnlfile.Visible = false;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(177, 186);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(371, 37);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save File";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "select your file:";
            // 
            // btnconvert
            // 
            this.btnconvert.Location = new System.Drawing.Point(294, 143);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(108, 23);
            this.btnconvert.TabIndex = 2;
            this.btnconvert.Text = "Add Signature";
            this.btnconvert.UseVisualStyleBackColor = true;
            this.btnconvert.Click += new System.EventHandler(this.btnconvert_Click);
            // 
            // btnopenfile
            // 
            this.btnopenfile.Location = new System.Drawing.Point(182, 81);
            this.btnopenfile.Name = "btnopenfile";
            this.btnopenfile.Size = new System.Drawing.Size(371, 37);
            this.btnopenfile.TabIndex = 1;
            this.btnopenfile.Text = "Open File";
            this.btnopenfile.UseVisualStyleBackColor = true;
            this.btnopenfile.Click += new System.EventHandler(this.btnopenfile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "select your file:";
            // 
            // openfile
            // 
            this.openfile.FileName = "openFileDialog1";
            // 
            // lblfilepath
            // 
            this.lblfilepath.AutoSize = true;
            this.lblfilepath.Location = new System.Drawing.Point(409, 312);
            this.lblfilepath.Name = "lblfilepath";
            this.lblfilepath.Size = new System.Drawing.Size(0, 15);
            this.lblfilepath.TabIndex = 11;
            this.lblfilepath.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(644, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblfilepath);
            this.Controls.Add(this.pnlfile);
            this.Controls.Add(this.pnllogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Auto Signature";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnllogin.ResumeLayout(false);
            this.pnllogin.PerformLayout();
            this.pnlfile.ResumeLayout(false);
            this.pnlfile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnllogin;
        private System.Windows.Forms.Panel pnlfile;
        private System.Windows.Forms.OpenFileDialog openfile;
        private System.Windows.Forms.Button btnopenfile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnconvert;
        private System.Windows.Forms.Label lblfilepath;
        private System.Windows.Forms.Button button1;




    }
}

