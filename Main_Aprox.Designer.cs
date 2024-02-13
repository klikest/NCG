namespace NCG
{
    partial class Main_Aprox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Aprox));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_start_net_approx = new System.Windows.Forms.Button();
            this.button_start_gen_approx = new System.Windows.Forms.Button();
            this.button_start_fourie_approx = new System.Windows.Forms.Button();
            this.Plot_Data_Input = new ScottPlot.FormsPlot();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_delete_last_point = new System.Windows.Forms.Button();
            this.button_delete_all_points = new System.Windows.Forms.Button();
            this.button_input_std_data = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_start_net_approx);
            this.groupBox1.Controls.Add(this.button_start_gen_approx);
            this.groupBox1.Controls.Add(this.button_start_fourie_approx);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор метода оптимизации";
            // 
            // button_start_net_approx
            // 
            this.button_start_net_approx.Location = new System.Drawing.Point(6, 139);
            this.button_start_net_approx.Name = "button_start_net_approx";
            this.button_start_net_approx.Size = new System.Drawing.Size(226, 67);
            this.button_start_net_approx.TabIndex = 0;
            this.button_start_net_approx.Text = "Обучение нейронной сети (универсальная теорема аппроксимации)";
            this.button_start_net_approx.UseVisualStyleBackColor = true;
            // 
            // button_start_gen_approx
            // 
            this.button_start_gen_approx.Location = new System.Drawing.Point(6, 80);
            this.button_start_gen_approx.Name = "button_start_gen_approx";
            this.button_start_gen_approx.Size = new System.Drawing.Size(226, 53);
            this.button_start_gen_approx.TabIndex = 0;
            this.button_start_gen_approx.Text = "Генетический алгоритм";
            this.button_start_gen_approx.UseVisualStyleBackColor = true;
            this.button_start_gen_approx.Click += new System.EventHandler(this.start_fourie_approx_Click);
            // 
            // button_start_fourie_approx
            // 
            this.button_start_fourie_approx.Location = new System.Drawing.Point(6, 21);
            this.button_start_fourie_approx.Name = "button_start_fourie_approx";
            this.button_start_fourie_approx.Size = new System.Drawing.Size(226, 53);
            this.button_start_fourie_approx.TabIndex = 0;
            this.button_start_fourie_approx.Text = "Дискретное преобразование Фурье";
            this.button_start_fourie_approx.UseVisualStyleBackColor = true;
            this.button_start_fourie_approx.Click += new System.EventHandler(this.start_fourie_approx_Click);
            // 
            // Plot_Data_Input
            // 
            this.Plot_Data_Input.Location = new System.Drawing.Point(8, 21);
            this.Plot_Data_Input.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Plot_Data_Input.Name = "Plot_Data_Input";
            this.Plot_Data_Input.Size = new System.Drawing.Size(753, 349);
            this.Plot_Data_Input.TabIndex = 1;
            this.Plot_Data_Input.Load += new System.EventHandler(this.Plot_Data_Input_Load);
            this.Plot_Data_Input.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Plot_Data_Input_MouseDown);
            this.Plot_Data_Input.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Plot_Data_Input_MouseMove);
            this.Plot_Data_Input.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Plot_Data_Input_MouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_delete_last_point);
            this.groupBox2.Controls.Add(this.button_delete_all_points);
            this.groupBox2.Controls.Add(this.button_input_std_data);
            this.groupBox2.Controls.Add(this.Plot_Data_Input);
            this.groupBox2.Location = new System.Drawing.Point(256, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(763, 426);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод данных";
            // 
            // button_delete_last_point
            // 
            this.button_delete_last_point.Location = new System.Drawing.Point(335, 376);
            this.button_delete_last_point.Name = "button_delete_last_point";
            this.button_delete_last_point.Size = new System.Drawing.Size(207, 44);
            this.button_delete_last_point.TabIndex = 3;
            this.button_delete_last_point.Text = "Удалить последнюю точку";
            this.button_delete_last_point.UseVisualStyleBackColor = true;
            this.button_delete_last_point.Click += new System.EventHandler(this.button_delete_last_point_Click);
            // 
            // button_delete_all_points
            // 
            this.button_delete_all_points.Location = new System.Drawing.Point(548, 376);
            this.button_delete_all_points.Name = "button_delete_all_points";
            this.button_delete_all_points.Size = new System.Drawing.Size(207, 44);
            this.button_delete_all_points.TabIndex = 3;
            this.button_delete_all_points.Text = "Удалить все точки";
            this.button_delete_all_points.UseVisualStyleBackColor = true;
            this.button_delete_all_points.Click += new System.EventHandler(this.button_delete_all_points_Click);
            // 
            // button_input_std_data
            // 
            this.button_input_std_data.Location = new System.Drawing.Point(8, 376);
            this.button_input_std_data.Name = "button_input_std_data";
            this.button_input_std_data.Size = new System.Drawing.Size(237, 44);
            this.button_input_std_data.TabIndex = 2;
            this.button_input_std_data.Text = "Ввести стандартную функцию";
            this.button_input_std_data.UseVisualStyleBackColor = true;
            this.button_input_std_data.Click += new System.EventHandler(this.button_input_std_data_Click);
            // 
            // Main_Aprox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Aprox";
            this.Text = "Approximization";
            this.Load += new System.EventHandler(this.Main_Aprox_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_start_fourie_approx;
        private ScottPlot.FormsPlot Plot_Data_Input;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_delete_last_point;
        private System.Windows.Forms.Button button_delete_all_points;
        private System.Windows.Forms.Button button_input_std_data;
        private System.Windows.Forms.Button button_start_net_approx;
        private System.Windows.Forms.Button button_start_gen_approx;
    }
}