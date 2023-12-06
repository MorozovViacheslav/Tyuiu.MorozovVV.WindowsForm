namespace Tyuiu.MorozovVV.WindowsForm
{
    partial class Form1Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Main));
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelVarX = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.pictureBoxFunc2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFunc1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.textBoxVarX = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonDev = new System.Windows.Forms.Button();
            this.labelVarY = new System.Windows.Forms.Label();
            this.textBoxVarY = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunc1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(-4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(800, 153);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = resources.GetString("labelTitle.Text");
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 153);
            this.panel1.TabIndex = 1;
            // 
            // labelVarX
            // 
            this.labelVarX.AutoSize = true;
            this.labelVarX.BackColor = System.Drawing.SystemColors.Control;
            this.labelVarX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVarX.Location = new System.Drawing.Point(12, 176);
            this.labelVarX.Name = "labelVarX";
            this.labelVarX.Size = new System.Drawing.Size(208, 25);
            this.labelVarX.TabIndex = 1;
            this.labelVarX.Text = "Введите значение X:";
            this.labelVarX.Click += new System.EventHandler(this.labelVarX_Click);
            // 
            // labelRes
            // 
            this.labelRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes.Location = new System.Drawing.Point(13, 266);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(207, 22);
            this.labelRes.TabIndex = 1;
            this.labelRes.Text = "Значение Z (X,Y) =";
            this.labelRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRes.Click += new System.EventHandler(this.labelVarX_Click);
            // 
            // pictureBoxFunc2
            // 
            this.pictureBoxFunc2.Image = global::Tyuiu.MorozovVV.WindowsForm.Properties.Resources._2picture;
            this.pictureBoxFunc2.Location = new System.Drawing.Point(396, 249);
            this.pictureBoxFunc2.Name = "pictureBoxFunc2";
            this.pictureBoxFunc2.Size = new System.Drawing.Size(190, 64);
            this.pictureBoxFunc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFunc2.TabIndex = 2;
            this.pictureBoxFunc2.TabStop = false;
            this.pictureBoxFunc2.Click += new System.EventHandler(this.pictureBoxFunc2_Click);
            // 
            // pictureBoxFunc1
            // 
            this.pictureBoxFunc1.Image = global::Tyuiu.MorozovVV.WindowsForm.Properties.Resources._1picture;
            this.pictureBoxFunc1.Location = new System.Drawing.Point(396, 159);
            this.pictureBoxFunc1.Name = "pictureBoxFunc1";
            this.pictureBoxFunc1.Size = new System.Drawing.Size(190, 64);
            this.pictureBoxFunc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFunc1.TabIndex = 2;
            this.pictureBoxFunc1.TabStop = false;
            this.pictureBoxFunc1.Click += new System.EventHandler(this.pictureBoxFunc1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(359, 177);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(359, 276);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBoxRes
            // 
            this.textBoxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRes.Location = new System.Drawing.Point(238, 262);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(100, 26);
            this.textBoxRes.TabIndex = 5;
            this.textBoxRes.TextChanged += new System.EventHandler(this.textBoxVarZ_TextChanged);
            // 
            // textBoxVarX
            // 
            this.textBoxVarX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVarX.Location = new System.Drawing.Point(238, 174);
            this.textBoxVarX.Name = "textBoxVarX";
            this.textBoxVarX.Size = new System.Drawing.Size(100, 26);
            this.textBoxVarX.TabIndex = 5;
            this.textBoxVarX.TextChanged += new System.EventHandler(this.textBoxVarX_TextChanged);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Location = new System.Drawing.Point(546, 369);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(242, 82);
            this.buttonCalc.TabIndex = 6;
            this.buttonCalc.Text = "ВЫПОЛНИТЬ РАСЧЁТ";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonDev
            // 
            this.buttonDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDev.Location = new System.Drawing.Point(16, 385);
            this.buttonDev.Name = "buttonDev";
            this.buttonDev.Size = new System.Drawing.Size(322, 33);
            this.buttonDev.TabIndex = 7;
            this.buttonDev.Text = "Информация о разработчике";
            this.buttonDev.UseVisualStyleBackColor = true;
            this.buttonDev.Click += new System.EventHandler(this.buttonDev_Click);
            // 
            // labelVarY
            // 
            this.labelVarY.AutoSize = true;
            this.labelVarY.BackColor = System.Drawing.SystemColors.Control;
            this.labelVarY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVarY.Location = new System.Drawing.Point(13, 215);
            this.labelVarY.Name = "labelVarY";
            this.labelVarY.Size = new System.Drawing.Size(207, 25);
            this.labelVarY.TabIndex = 1;
            this.labelVarY.Text = "Введите значение Y:";
            this.labelVarY.Click += new System.EventHandler(this.labelVarX_Click);
            // 
            // textBoxVarY
            // 
            this.textBoxVarY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVarY.Location = new System.Drawing.Point(238, 215);
            this.textBoxVarY.Name = "textBoxVarY";
            this.textBoxVarY.Size = new System.Drawing.Size(100, 26);
            this.textBoxVarY.TabIndex = 5;
            this.textBoxVarY.TextChanged += new System.EventHandler(this.textBoxVarX_TextChanged);
            // 
            // Form1Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(810, 463);
            this.Controls.Add(this.buttonDev);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxVarY);
            this.Controls.Add(this.textBoxVarX);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBoxFunc2);
            this.Controls.Add(this.pictureBoxFunc1);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.labelVarY);
            this.Controls.Add(this.labelVarX);
            this.Controls.Add(this.panel1);
            this.Name = "Form1Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "CalcForm by V.V. Morozov";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunc1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelVarX;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.PictureBox pictureBoxFunc1;
        private System.Windows.Forms.PictureBox pictureBoxFunc2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.TextBox textBoxVarX;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonDev;
        private System.Windows.Forms.Label labelVarY;
        private System.Windows.Forms.TextBox textBoxVarY;
    }
}

