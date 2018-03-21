namespace WeatherClient
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
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.radioButtonCelsius = new System.Windows.Forms.RadioButton();
         this.radioButtonFahrenheit = new System.Windows.Forms.RadioButton();
         this.label1 = new System.Windows.Forms.Label();
         this.textCity = new System.Windows.Forms.TextBox();
         this.buttonGetWeather = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.textWeatherCondition = new System.Windows.Forms.TextBox();
         this.textTemperature = new System.Windows.Forms.TextBox();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.radioButtonFahrenheit);
         this.groupBox1.Controls.Add(this.radioButtonCelsius);
         this.groupBox1.Location = new System.Drawing.Point(23, 26);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(139, 100);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Temperature Type";
         // 
         // radioButtonCelsius
         // 
         this.radioButtonCelsius.AutoSize = true;
         this.radioButtonCelsius.Checked = true;
         this.radioButtonCelsius.Location = new System.Drawing.Point(20, 29);
         this.radioButtonCelsius.Name = "radioButtonCelsius";
         this.radioButtonCelsius.Size = new System.Drawing.Size(58, 17);
         this.radioButtonCelsius.TabIndex = 0;
         this.radioButtonCelsius.TabStop = true;
         this.radioButtonCelsius.Text = "Celsius";
         this.radioButtonCelsius.UseVisualStyleBackColor = true;
         // 
         // radioButtonFahrenheit
         // 
         this.radioButtonFahrenheit.AutoSize = true;
         this.radioButtonFahrenheit.Location = new System.Drawing.Point(20, 59);
         this.radioButtonFahrenheit.Name = "radioButtonFahrenheit";
         this.radioButtonFahrenheit.Size = new System.Drawing.Size(75, 17);
         this.radioButtonFahrenheit.TabIndex = 1;
         this.radioButtonFahrenheit.Text = "Fahrenheit";
         this.radioButtonFahrenheit.UseVisualStyleBackColor = true;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(197, 41);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(27, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "City:";
         // 
         // textCity
         // 
         this.textCity.Location = new System.Drawing.Point(200, 75);
         this.textCity.Name = "textCity";
         this.textCity.Size = new System.Drawing.Size(100, 20);
         this.textCity.TabIndex = 2;
         // 
         // buttonGetWeather
         // 
         this.buttonGetWeather.Location = new System.Drawing.Point(23, 150);
         this.buttonGetWeather.Name = "buttonGetWeather";
         this.buttonGetWeather.Size = new System.Drawing.Size(139, 23);
         this.buttonGetWeather.TabIndex = 3;
         this.buttonGetWeather.Text = "Get Weather";
         this.buttonGetWeather.UseVisualStyleBackColor = true;
         this.buttonGetWeather.Click += new System.EventHandler(this.buttonGetWeather_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(20, 193);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(98, 13);
         this.label2.TabIndex = 4;
         this.label2.Text = "Weather Condition:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(20, 230);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(70, 13);
         this.label3.TabIndex = 5;
         this.label3.Text = "Temperature:";
         // 
         // textWeatherCondition
         // 
         this.textWeatherCondition.Location = new System.Drawing.Point(200, 193);
         this.textWeatherCondition.Name = "textWeatherCondition";
         this.textWeatherCondition.Size = new System.Drawing.Size(100, 20);
         this.textWeatherCondition.TabIndex = 6;
         // 
         // textTemperature
         // 
         this.textTemperature.Location = new System.Drawing.Point(200, 230);
         this.textTemperature.Name = "textTemperature";
         this.textTemperature.Size = new System.Drawing.Size(100, 20);
         this.textTemperature.TabIndex = 7;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(323, 265);
         this.Controls.Add(this.textTemperature);
         this.Controls.Add(this.textWeatherCondition);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.buttonGetWeather);
         this.Controls.Add(this.textCity);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.groupBox1);
         this.Name = "Form1";
         this.Text = "Weather Client";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.RadioButton radioButtonFahrenheit;
      private System.Windows.Forms.RadioButton radioButtonCelsius;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox textCity;
      private System.Windows.Forms.Button buttonGetWeather;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox textWeatherCondition;
      private System.Windows.Forms.TextBox textTemperature;
   }
}

