namespace WinFormsWeatherApp
{
    partial class MainPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            this.weatherIcon = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSunset = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSunrise = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCityName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCondition = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblCityName = new System.Windows.Forms.Label();
            this.flpHourlyWeather = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // weatherIcon
            // 
            this.weatherIcon.Location = new System.Drawing.Point(538, 124);
            this.weatherIcon.Name = "weatherIcon";
            this.weatherIcon.Size = new System.Drawing.Size(83, 61);
            this.weatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weatherIcon.TabIndex = 0;
            this.weatherIcon.TabStop = false;
            this.weatherIcon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblSunset);
            this.groupBox1.Controls.Add(this.lblWind);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblSunrise);
            this.groupBox1.Controls.Add(this.lblHumidity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(607, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wind Conditions";
            // 
            // lblSunset
            // 
            this.lblSunset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSunset.Location = new System.Drawing.Point(339, 105);
            this.lblSunset.Name = "lblSunset";
            this.lblSunset.Size = new System.Drawing.Size(85, 23);
            this.lblSunset.TabIndex = 13;
            this.lblSunset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWind
            // 
            this.lblWind.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWind.Location = new System.Drawing.Point(127, 40);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(70, 21);
            this.lblWind.TabIndex = 13;
            this.lblWind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(249, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 33);
            this.label9.TabIndex = 12;
            this.label9.Text = "Sunrise:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSunrise
            // 
            this.lblSunrise.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSunrise.Location = new System.Drawing.Point(339, 39);
            this.lblSunrise.Name = "lblSunrise";
            this.lblSunrise.Size = new System.Drawing.Size(85, 23);
            this.lblSunrise.TabIndex = 10;
            this.lblSunrise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHumidity
            // 
            this.lblHumidity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHumidity.Location = new System.Drawing.Point(127, 107);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(70, 19);
            this.lblHumidity.TabIndex = 5;
            this.lblHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(249, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sunset: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 33);
            this.label13.TabIndex = 16;
            this.label13.Text = "Wind Speed:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Humidity:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(297, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "City:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCityName
            // 
            this.tbCityName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbCityName.Location = new System.Drawing.Point(454, 34);
            this.tbCityName.Multiline = true;
            this.tbCityName.Name = "tbCityName";
            this.tbCityName.Size = new System.Drawing.Size(232, 33);
            this.tbCityName.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightBlue;
            this.btnSearch.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearch.Location = new System.Drawing.Point(715, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 47);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCondition
            // 
            this.lblCondition.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCondition.Location = new System.Drawing.Point(108, 36);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(86, 27);
            this.lblCondition.TabIndex = 8;
            this.lblCondition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 27);
            this.label11.TabIndex = 14;
            this.label11.Text = "Details";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescription.Location = new System.Drawing.Point(78, 105);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(94, 26);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 26);
            this.label10.TabIndex = 13;
            this.label10.Text = "Condition:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTemp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaxTemp.Location = new System.Drawing.Point(358, 36);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(86, 27);
            this.lblMaxTemp.TabIndex = 17;
            this.lblMaxTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 41);
            this.label2.TabIndex = 18;
            this.label2.Text = "Max Temp:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblMinTemp);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblMaxTemp);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblDescription);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblCondition);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Location = new System.Drawing.Point(56, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 145);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weather Details";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTemp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMinTemp.Location = new System.Drawing.Point(358, 103);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(86, 27);
            this.lblMinTemp.TabIndex = 20;
            this.lblMinTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(231, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "Min Temp:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemp
            // 
            this.lblTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblTemp.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTemp.Location = new System.Drawing.Point(535, 206);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(86, 27);
            this.lblTemp.TabIndex = 18;
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCityName
            // 
            this.lblCityName.BackColor = System.Drawing.Color.Transparent;
            this.lblCityName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCityName.Location = new System.Drawing.Point(494, 82);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(162, 27);
            this.lblCityName.TabIndex = 19;
            this.lblCityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpHourlyWeather
            // 
            this.flpHourlyWeather.AutoScroll = true;
            this.flpHourlyWeather.BackColor = System.Drawing.Color.Transparent;
            this.flpHourlyWeather.Location = new System.Drawing.Point(56, 476);
            this.flpHourlyWeather.Name = "flpHourlyWeather";
            this.flpHourlyWeather.Size = new System.Drawing.Size(1050, 165);
            this.flpHourlyWeather.TabIndex = 20;
            this.flpHourlyWeather.WrapContents = false;
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1147, 653);
            this.Controls.Add(this.flpHourlyWeather);
            this.Controls.Add(this.lblCityName);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbCityName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.weatherIcon);
            this.DoubleBuffered = true;
            this.Name = "MainPageForm";
            this.Text = "TheWeatherApp";
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox weatherIcon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSunrise;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbCityName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSunset;
        public System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblTemp;
        public System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.FlowLayoutPanel flpHourlyWeather;
    }
}

