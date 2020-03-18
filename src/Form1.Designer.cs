namespace AutoInstaller
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                RunCommand("set-executionpolicy", "default");
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonRus = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonEng = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonVers340 = new System.Windows.Forms.RadioButton();
            this.radioButtonVers321 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonRus
            // 
            this.radioButtonRus.AutoSize = true;
            this.radioButtonRus.Checked = true;
            this.radioButtonRus.Location = new System.Drawing.Point(6, 57);
            this.radioButtonRus.Name = "radioButtonRus";
            this.radioButtonRus.Size = new System.Drawing.Size(65, 19);
            this.radioButtonRus.TabIndex = 0;
            this.radioButtonRus.TabStop = true;
            this.radioButtonRus.Text = "Russian";
            this.radioButtonRus.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonVers340);
            this.groupBox1.Controls.Add(this.radioButtonVers321);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButtonRus);
            this.groupBox1.Controls.Add(this.radioButtonEng);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Installation parameters GENIE2K";
            // 
            // radioButtonEng
            // 
            this.radioButtonEng.AutoSize = true;
            this.radioButtonEng.Location = new System.Drawing.Point(6, 82);
            this.radioButtonEng.Name = "radioButtonEng";
            this.radioButtonEng.Size = new System.Drawing.Size(63, 19);
            this.radioButtonEng.TabIndex = 0;
            this.radioButtonEng.TabStop = true;
            this.radioButtonEng.Text = "English";
            this.radioButtonEng.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Install";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Language";
            // 
            // radioButtonVers340
            // 
            this.radioButtonVers340.AutoSize = true;
            this.radioButtonVers340.Location = new System.Drawing.Point(93, 82);
            this.radioButtonVers340.Name = "radioButtonVers340";
            this.radioButtonVers340.Size = new System.Drawing.Size(49, 19);
            this.radioButtonVers340.TabIndex = 0;
            this.radioButtonVers340.TabStop = true;
            this.radioButtonVers340.Text = "3.4.0";
            this.radioButtonVers340.UseVisualStyleBackColor = true;
            // 
            // radioButtonVers321
            // 
            this.radioButtonVers321.AutoSize = true;
            this.radioButtonVers321.Checked = true;
            this.radioButtonVers321.Location = new System.Drawing.Point(93, 57);
            this.radioButtonVers321.Name = "radioButtonVers321";
            this.radioButtonVers321.Size = new System.Drawing.Size(49, 19);
            this.radioButtonVers321.TabIndex = 0;
            this.radioButtonVers321.TabStop = true;
            this.radioButtonVers321.Text = "3.2.1";
            this.radioButtonVers321.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Version";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 158);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Regata Auto Installer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonRus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonEng;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonVers340;
        private System.Windows.Forms.RadioButton radioButtonVers321;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

