namespace NCG
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
            this.Plot_i = new ScottPlot.FormsPlot();
            this.Plot_Gears = new ScottPlot.FormsPlot();
            this.Plot_Angle = new ScottPlot.FormsPlot();
            this.textBox_function = new System.Windows.Forms.TextBox();
            this.button_plot = new System.Windows.Forms.Button();
            this.textBox_Angle_Step = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_aprox = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_normalize = new System.Windows.Forms.CheckBox();
            this.textBox_num_rotates = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Plot_i
            // 
            this.Plot_i.Location = new System.Drawing.Point(14, 12);
            this.Plot_i.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Plot_i.Name = "Plot_i";
            this.Plot_i.Size = new System.Drawing.Size(645, 226);
            this.Plot_i.TabIndex = 0;
            this.Plot_i.Load += new System.EventHandler(this.Plot_i_Load);
            // 
            // Plot_Gears
            // 
            this.Plot_Gears.Location = new System.Drawing.Point(665, 269);
            this.Plot_Gears.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Plot_Gears.Name = "Plot_Gears";
            this.Plot_Gears.Size = new System.Drawing.Size(592, 345);
            this.Plot_Gears.TabIndex = 1;
            // 
            // Plot_Angle
            // 
            this.Plot_Angle.Location = new System.Drawing.Point(669, 12);
            this.Plot_Angle.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Plot_Angle.Name = "Plot_Angle";
            this.Plot_Angle.Size = new System.Drawing.Size(592, 246);
            this.Plot_Angle.TabIndex = 3;
            // 
            // textBox_function
            // 
            this.textBox_function.Location = new System.Drawing.Point(6, 32);
            this.textBox_function.Multiline = true;
            this.textBox_function.Name = "textBox_function";
            this.textBox_function.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_function.Size = new System.Drawing.Size(195, 111);
            this.textBox_function.TabIndex = 4;
            this.textBox_function.Text = "1.5+sin(2*x)/2";
            // 
            // button_plot
            // 
            this.button_plot.Location = new System.Drawing.Point(208, 20);
            this.button_plot.Name = "button_plot";
            this.button_plot.Size = new System.Drawing.Size(134, 43);
            this.button_plot.TabIndex = 5;
            this.button_plot.Text = "Построить";
            this.button_plot.UseVisualStyleBackColor = true;
            this.button_plot.Click += new System.EventHandler(this.button_plot_Click);
            // 
            // textBox_Angle_Step
            // 
            this.textBox_Angle_Step.Location = new System.Drawing.Point(121, 42);
            this.textBox_Angle_Step.Name = "textBox_Angle_Step";
            this.textBox_Angle_Step.Size = new System.Drawing.Size(100, 22);
            this.textBox_Angle_Step.TabIndex = 7;
            this.textBox_Angle_Step.Text = "1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Включить анимацию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Angle_Step);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(408, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 70);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Анимация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Шаг, град";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_function);
            this.groupBox2.Controls.Add(this.button_plot);
            this.groupBox2.Location = new System.Drawing.Point(44, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 156);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод передаточной функции";
            // 
            // button_aprox
            // 
            this.button_aprox.Location = new System.Drawing.Point(35, 410);
            this.button_aprox.Name = "button_aprox";
            this.button_aprox.Size = new System.Drawing.Size(171, 53);
            this.button_aprox.TabIndex = 11;
            this.button_aprox.Text = "Аппроксимация";
            this.button_aprox.UseVisualStyleBackColor = true;
            this.button_aprox.Click += new System.EventHandler(this.button_aprox_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_normalize);
            this.groupBox3.Controls.Add(this.textBox_num_rotates);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(408, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 80);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Нормировать до целого числа оборотов";
            // 
            // checkBox_normalize
            // 
            this.checkBox_normalize.AutoSize = true;
            this.checkBox_normalize.Location = new System.Drawing.Point(6, 47);
            this.checkBox_normalize.Name = "checkBox_normalize";
            this.checkBox_normalize.Size = new System.Drawing.Size(118, 20);
            this.checkBox_normalize.TabIndex = 15;
            this.checkBox_normalize.Text = "Нормировать";
            this.checkBox_normalize.UseVisualStyleBackColor = true;
            this.checkBox_normalize.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox_num_rotates
            // 
            this.textBox_num_rotates.Location = new System.Drawing.Point(145, 47);
            this.textBox_num_rotates.Name = "textBox_num_rotates";
            this.textBox_num_rotates.Size = new System.Drawing.Size(104, 22);
            this.textBox_num_rotates.TabIndex = 14;
            this.textBox_num_rotates.Text = "1";
            this.textBox_num_rotates.TextChanged += new System.EventHandler(this.textBox_num_rotates_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Число оборотов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 626);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_aprox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Plot_Angle);
            this.Controls.Add(this.Plot_Gears);
            this.Controls.Add(this.Plot_i);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NCG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ScottPlot.FormsPlot Plot_i;
        private ScottPlot.FormsPlot Plot_Gears;
        private ScottPlot.FormsPlot Plot_Angle;
        private System.Windows.Forms.TextBox textBox_function;
        private System.Windows.Forms.Button button_plot;
        private System.Windows.Forms.TextBox textBox_Angle_Step;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_aprox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox_normalize;
        private System.Windows.Forms.TextBox textBox_num_rotates;
        private System.Windows.Forms.Label label2;
    }
}

