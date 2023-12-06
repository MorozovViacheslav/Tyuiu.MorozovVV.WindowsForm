namespace Tyuiu.MorozovVV.WindowsForm._2
{
    partial class Form2Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBoxFunc = new System.Windows.Forms.PictureBox();
            this.groupBoxTitle = new System.Windows.Forms.GroupBox();
            this.buttonDev = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.numericFinish = new System.Windows.Forms.NumericUpDown();
            this.numericStart = new System.Windows.Forms.NumericUpDown();
            this.labelFinish = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.chartRes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunc)).BeginInit();
            this.groupBoxTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFunc
            // 
            this.pictureBoxFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFunc.Image = global::Tyuiu.MorozovVV.WindowsForm._2.Properties.Resources._2Picture;
            this.pictureBoxFunc.Location = new System.Drawing.Point(11, 118);
            this.pictureBoxFunc.Name = "pictureBoxFunc";
            this.pictureBoxFunc.Size = new System.Drawing.Size(284, 60);
            this.pictureBoxFunc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFunc.TabIndex = 0;
            this.pictureBoxFunc.TabStop = false;
            this.pictureBoxFunc.Click += new System.EventHandler(this.pictureBoxFunc_Click);
            // 
            // groupBoxTitle
            // 
            this.groupBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxTitle.Controls.Add(this.buttonDev);
            this.groupBoxTitle.Controls.Add(this.buttonCalc);
            this.groupBoxTitle.Controls.Add(this.numericFinish);
            this.groupBoxTitle.Controls.Add(this.numericStart);
            this.groupBoxTitle.Controls.Add(this.labelFinish);
            this.groupBoxTitle.Controls.Add(this.labelStart);
            this.groupBoxTitle.Controls.Add(this.textBoxDesc);
            this.groupBoxTitle.Location = new System.Drawing.Point(0, 12);
            this.groupBoxTitle.Name = "groupBoxTitle";
            this.groupBoxTitle.Size = new System.Drawing.Size(801, 100);
            this.groupBoxTitle.TabIndex = 1;
            this.groupBoxTitle.TabStop = false;
            this.groupBoxTitle.Text = "Описание";
            // 
            // buttonDev
            // 
            this.buttonDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDev.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDev.Location = new System.Drawing.Point(586, 58);
            this.buttonDev.Name = "buttonDev";
            this.buttonDev.Size = new System.Drawing.Size(200, 23);
            this.buttonDev.TabIndex = 3;
            this.buttonDev.Text = "О разработчике";
            this.buttonDev.UseVisualStyleBackColor = true;
            this.buttonDev.Click += new System.EventHandler(this.buttonDev_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Location = new System.Drawing.Point(586, 24);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(200, 23);
            this.buttonCalc.TabIndex = 3;
            this.buttonCalc.Text = "ВЫПОЛНИТЬ РАССЧЁТ";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // numericFinish
            // 
            this.numericFinish.Location = new System.Drawing.Point(514, 58);
            this.numericFinish.Name = "numericFinish";
            this.numericFinish.Size = new System.Drawing.Size(53, 22);
            this.numericFinish.TabIndex = 2;
            this.numericFinish.ValueChanged += new System.EventHandler(this.numericFinish_ValueChanged);
            // 
            // numericStart
            // 
            this.numericStart.Location = new System.Drawing.Point(433, 58);
            this.numericStart.Name = "numericStart";
            this.numericStart.Size = new System.Drawing.Size(64, 22);
            this.numericStart.TabIndex = 2;
            this.numericStart.ValueChanged += new System.EventHandler(this.numericStart_ValueChanged);
            // 
            // labelFinish
            // 
            this.labelFinish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFinish.AutoSize = true;
            this.labelFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinish.Location = new System.Drawing.Point(511, 24);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(56, 18);
            this.labelFinish.TabIndex = 1;
            this.labelFinish.Text = "Конец";
            this.labelFinish.Click += new System.EventHandler(this.labelFinish_Click);
            // 
            // labelStart
            // 
            this.labelStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart.Location = new System.Drawing.Point(430, 24);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(67, 18);
            this.labelStart.TabIndex = 1;
            this.labelStart.Text = "Начало";
            this.labelStart.Click += new System.EventHandler(this.labelStart_Click);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDesc.Location = new System.Drawing.Point(7, 21);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(417, 59);
            this.textBoxDesc.TabIndex = 0;
            this.textBoxDesc.TabStop = false;
            this.textBoxDesc.Text = "Для проведения рассчётов и построения графика \r\nнеобходимо ввести начальное и кон" +
    "ечное значение шага\r\nи нажать на кнопку \"ВЫПОЛНИТЬ РАССЧЁТ\"";
            this.textBoxDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDesc.TextChanged += new System.EventHandler(this.textBoxDesc_TextChanged);
            // 
            // textBoxRes
            // 
            this.textBoxRes.Location = new System.Drawing.Point(13, 185);
            this.textBoxRes.Multiline = true;
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRes.Size = new System.Drawing.Size(282, 253);
            this.textBoxRes.TabIndex = 2;
            this.textBoxRes.TextChanged += new System.EventHandler(this.textBoxRes_TextChanged);
            // 
            // chartRes
            // 
            this.chartRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chartRes.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartRes.Legends.Add(legend4);
            this.chartRes.Location = new System.Drawing.Point(301, 118);
            this.chartRes.Name = "chartRes";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartRes.Series.Add(series4);
            this.chartRes.Size = new System.Drawing.Size(489, 343);
            this.chartRes.TabIndex = 3;
            this.chartRes.Text = "chartRes";
            this.chartRes.Click += new System.EventHandler(this.chartRes_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 473);
            this.Controls.Add(this.chartRes);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.groupBoxTitle);
            this.Controls.Add(this.pictureBoxFunc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(820, 480);
            this.Name = "Form2";
            this.Text = "CalcForm by V.V. Morozov";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunc)).EndInit();
            this.groupBoxTitle.ResumeLayout(false);
            this.groupBoxTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFunc;
        private System.Windows.Forms.GroupBox groupBoxTitle;
        public System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.NumericUpDown numericFinish;
        private System.Windows.Forms.NumericUpDown numericStart;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Button buttonDev;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes;
    }
}

