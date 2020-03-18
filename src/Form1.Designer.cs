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
                if (System.IO.Directory.Exists(".tmp"))
                    System.IO.Directory.Delete(".tmp");

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
            this.radioButtonVers340 = new System.Windows.Forms.RadioButton();
            this.radioButtonVers321 = new System.Windows.Forms.RadioButton();
            this.radioButtonEng = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonRus
            // 
            this.radioButtonRus.AutoSize = true;
            this.radioButtonRus.Location = new System.Drawing.Point(7, 26);
            this.radioButtonRus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonRus.Name = "radioButtonRus";
            this.radioButtonRus.Size = new System.Drawing.Size(85, 24);
            this.radioButtonRus.TabIndex = 0;
            this.radioButtonRus.Text = "Russian";
            this.radioButtonRus.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(261, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Installation parameters GENIE2K";
            // 
            // radioButtonVers340
            // 
            this.radioButtonVers340.AutoSize = true;
            this.radioButtonVers340.Location = new System.Drawing.Point(7, 69);
            this.radioButtonVers340.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonVers340.Name = "radioButtonVers340";
            this.radioButtonVers340.Size = new System.Drawing.Size(62, 24);
            this.radioButtonVers340.TabIndex = 0;
            this.radioButtonVers340.TabStop = true;
            this.radioButtonVers340.Text = "3.4.0";
            this.radioButtonVers340.UseVisualStyleBackColor = true;
            // 
            // radioButtonVers321
            // 
            this.radioButtonVers321.AutoSize = true;
            this.radioButtonVers321.Checked = true;
            this.radioButtonVers321.Location = new System.Drawing.Point(7, 26);
            this.radioButtonVers321.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonVers321.Name = "radioButtonVers321";
            this.radioButtonVers321.Size = new System.Drawing.Size(62, 24);
            this.radioButtonVers321.TabIndex = 0;
            this.radioButtonVers321.TabStop = true;
            this.radioButtonVers321.Text = "3.2.1";
            this.radioButtonVers321.UseVisualStyleBackColor = true;
            // 
            // radioButtonEng
            // 
            this.radioButtonEng.AutoSize = true;
            this.radioButtonEng.Checked = true;
            this.radioButtonEng.Location = new System.Drawing.Point(7, 69);
            this.radioButtonEng.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonEng.Name = "radioButtonEng";
            this.radioButtonEng.Size = new System.Drawing.Size(79, 24);
            this.radioButtonEng.TabIndex = 0;
            this.radioButtonEng.TabStop = true;
            this.radioButtonEng.Text = "English";
            this.radioButtonEng.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Install";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonRus);
            this.groupBox2.Controls.Add(this.radioButtonEng);
            this.groupBox2.Location = new System.Drawing.Point(7, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Language";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonVers321);
            this.groupBox3.Controls.Add(this.radioButtonVers340);
            this.groupBox3.Location = new System.Drawing.Point(130, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(112, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Version";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 228);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Regata Auto Installer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonRus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonEng;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonVers340;
        private System.Windows.Forms.RadioButton radioButtonVers321;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

