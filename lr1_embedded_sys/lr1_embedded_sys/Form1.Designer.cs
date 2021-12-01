
namespace lr1_embedded_sys
{
    partial class LoadSAU
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadSAU));
            this.prec_tem_pusk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.regul = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.signalBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb = new System.Windows.Forms.Label();
            this.MotorBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tpBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.temp_num = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DownBox = new System.Windows.Forms.TextBox();
            this.StrtBox = new System.Windows.Forms.TextBox();
            this.errorBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.trackOC = new System.Windows.Forms.TrackBar();
            this.pusk_btn = new System.Windows.Forms.ToolStripSplitButton();
            this.start_system = new System.Windows.Forms.ToolStripMenuItem();
            this.stop_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.enbl_temp = new System.Windows.Forms.ToolStripMenuItem();
            this.enbl_boiler = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.null_rowtt = new System.Windows.Forms.ErrorProvider(this.components);
            this.regul.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temp_num)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackOC)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.null_rowtt)).BeginInit();
            this.SuspendLayout();
            // 
            // prec_tem_pusk
            // 
            this.prec_tem_pusk.Location = new System.Drawing.Point(29, 69);
            this.prec_tem_pusk.Name = "prec_tem_pusk";
            this.prec_tem_pusk.Size = new System.Drawing.Size(128, 20);
            this.prec_tem_pusk.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Установка температуры, %";
            // 
            // regul
            // 
            this.regul.Controls.Add(this.label2);
            this.regul.Controls.Add(this.signalBox);
            this.regul.Location = new System.Drawing.Point(29, 96);
            this.regul.Name = "regul";
            this.regul.Size = new System.Drawing.Size(143, 127);
            this.regul.TabIndex = 3;
            this.regul.TabStop = false;
            this.regul.Text = "Регулятор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "сигнал";
            // 
            // signalBox
            // 
            this.signalBox.Location = new System.Drawing.Point(7, 71);
            this.signalBox.Name = "signalBox";
            this.signalBox.ReadOnly = true;
            this.signalBox.Size = new System.Drawing.Size(121, 20);
            this.signalBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb);
            this.groupBox2.Controls.Add(this.MotorBox);
            this.groupBox2.Location = new System.Drawing.Point(209, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 170);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Мотор упарвления клапоном 5";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(15, 31);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(54, 13);
            this.lb.TabIndex = 3;
            this.lb.Text = "скорость";
            // 
            // MotorBox
            // 
            this.MotorBox.Location = new System.Drawing.Point(15, 50);
            this.MotorBox.Name = "MotorBox";
            this.MotorBox.ReadOnly = true;
            this.MotorBox.Size = new System.Drawing.Size(144, 20);
            this.MotorBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tpBox);
            this.groupBox1.Location = new System.Drawing.Point(482, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 170);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Топливный клапан 21";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "положение";
            // 
            // tpBox
            // 
            this.tpBox.Location = new System.Drawing.Point(15, 50);
            this.tpBox.Name = "tpBox";
            this.tpBox.ReadOnly = true;
            this.tpBox.Size = new System.Drawing.Size(144, 20);
            this.tpBox.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.temp_num);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Location = new System.Drawing.Point(711, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 170);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Котел";
            // 
            // temp_num
            // 
            this.temp_num.Location = new System.Drawing.Point(10, 87);
            this.temp_num.Name = "temp_num";
            this.temp_num.Size = new System.Drawing.Size(120, 20);
            this.temp_num.TabIndex = 3;
            this.temp_num.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Температура";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 114);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(187, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DownBox);
            this.groupBox4.Controls.Add(this.StrtBox);
            this.groupBox4.Controls.Add(this.errorBox);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(939, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 170);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Качество управления";
            // 
            // DownBox
            // 
            this.DownBox.Location = new System.Drawing.Point(10, 134);
            this.DownBox.Name = "DownBox";
            this.DownBox.Size = new System.Drawing.Size(154, 20);
            this.DownBox.TabIndex = 5;
            // 
            // StrtBox
            // 
            this.StrtBox.Location = new System.Drawing.Point(10, 87);
            this.StrtBox.Name = "StrtBox";
            this.StrtBox.Size = new System.Drawing.Size(154, 20);
            this.StrtBox.TabIndex = 4;
            // 
            // errorBox
            // 
            this.errorBox.Location = new System.Drawing.Point(10, 46);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(154, 20);
            this.errorBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Затухание";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Быстродействие";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Точность";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(29, 247);
            this.chart1.Name = "chart1";
            series5.BorderWidth = 5;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Lime;
            series5.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series5.LabelForeColor = System.Drawing.Color.Tomato;
            series5.Legend = "Legend1";
            series5.MarkerBorderColor = System.Drawing.Color.Red;
            series5.Name = "Входные";
            series6.BorderWidth = 5;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Red;
            series6.Legend = "Legend1";
            series6.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series6.Name = "Вывод";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(876, 326);
            this.chart1.TabIndex = 8;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.LoadSAU_Load);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.trackOC);
            this.groupBox5.Location = new System.Drawing.Point(939, 261);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Обратная Связь (ОС)";
            // 
            // trackOC
            // 
            this.trackOC.Location = new System.Drawing.Point(7, 43);
            this.trackOC.Maximum = 200;
            this.trackOC.Name = "trackOC";
            this.trackOC.Size = new System.Drawing.Size(187, 45);
            this.trackOC.TabIndex = 0;
            this.trackOC.Scroll += new System.EventHandler(this.trackOC_Scroll);
            // 
            // pusk_btn
            // 
            this.pusk_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pusk_btn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.start_system,
            this.stop_btn});
            this.pusk_btn.Image = ((System.Drawing.Image)(resources.GetObject("pusk_btn.Image")));
            this.pusk_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pusk_btn.Name = "pusk_btn";
            this.pusk_btn.Size = new System.Drawing.Size(100, 22);
            this.pusk_btn.Text = "Действия САУ";
            // 
            // start_system
            // 
            this.start_system.Name = "start_system";
            this.start_system.Size = new System.Drawing.Size(138, 22);
            this.start_system.Text = "Запуск";
            this.start_system.Click += new System.EventHandler(this.start_system_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(138, 22);
            this.stop_btn.Text = "Остановить";
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enbl_temp,
            this.enbl_boiler});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(89, 22);
            this.toolStripSplitButton1.Text = "Управление";
            // 
            // enbl_temp
            // 
            this.enbl_temp.Name = "enbl_temp";
            this.enbl_temp.Size = new System.Drawing.Size(166, 22);
            this.enbl_temp.Text = "вкл температура";
            // 
            // enbl_boiler
            // 
            this.enbl_boiler.Name = "enbl_boiler";
            this.enbl_boiler.Size = new System.Drawing.Size(166, 22);
            this.enbl_boiler.Text = "вкл котел";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pusk_btn,
            this.toolStripSeparator1,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1166, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // null_rowtt
            // 
            this.null_rowtt.ContainerControl = this;
            // 
            // LoadSAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 606);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.regul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prec_tem_pusk);
            this.Controls.Add(this.toolStrip1);
            this.Name = "LoadSAU";
            this.Text = "САУ_лаб_р_1";
            this.Load += new System.EventHandler(this.LoadSAU_Load);
            this.regul.ResumeLayout(false);
            this.regul.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temp_num)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackOC)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.null_rowtt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox prec_tem_pusk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox regul;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox signalBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox MotorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tpBox;
        private System.Windows.Forms.TextBox DownBox;
        private System.Windows.Forms.TextBox StrtBox;
        private System.Windows.Forms.TextBox errorBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown temp_num;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TrackBar trackOC;
        private System.Windows.Forms.ToolStripSplitButton pusk_btn;
        private System.Windows.Forms.ToolStripMenuItem start_system;
        private System.Windows.Forms.ToolStripMenuItem stop_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem enbl_temp;
        private System.Windows.Forms.ToolStripMenuItem enbl_boiler;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ErrorProvider null_rowtt;
    }
}

