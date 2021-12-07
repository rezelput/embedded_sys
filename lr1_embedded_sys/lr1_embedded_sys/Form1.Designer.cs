
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadSAU));
            this.prec_tem_pusk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.regul = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.locktt = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb = new System.Windows.Forms.Label();
            this.MotorBox = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.track4 = new System.Windows.Forms.Label();
            this.tpBox = new System.Windows.Forms.TextBox();
            this.barkl = new System.Windows.Forms.HScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.temp_num = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TrackOC = new System.Windows.Forms.HScrollBar();
            this.pusk_btn = new System.Windows.Forms.ToolStripSplitButton();
            this.start_system = new System.Windows.Forms.ToolStripMenuItem();
            this.stop_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.enbl_temp = new System.Windows.Forms.ToolStripMenuItem();
            this.enbl_boiler = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnPort = new System.Windows.Forms.ToolStripMenuItem();
            this.UpConn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.null_rowtt = new System.Windows.Forms.ErrorProvider(this.components);
            this.NBar = new System.Windows.Forms.HScrollBar();
            this.label8 = new System.Windows.Forms.Label();
            this.tm_prgrbar = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_graph = new System.Windows.Forms.Timer(this.components);
            this.BoxPort = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.regul.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temp_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox5.SuspendLayout();
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
            this.prec_tem_pusk.TextChanged += new System.EventHandler(this.prec_tem_pusk_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Уставка температуры, %";
            // 
            // regul
            // 
            this.regul.Controls.Add(this.label2);
            this.regul.Controls.Add(this.locktt);
            this.regul.Location = new System.Drawing.Point(29, 96);
            this.regul.Name = "regul";
            this.regul.Size = new System.Drawing.Size(143, 94);
            this.regul.TabIndex = 3;
            this.regul.TabStop = false;
            this.regul.Text = "Регулятор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "сигнал";
            // 
            // locktt
            // 
            this.locktt.AutoSize = true;
            this.locktt.Location = new System.Drawing.Point(6, 51);
            this.locktt.Name = "locktt";
            this.locktt.Size = new System.Drawing.Size(15, 13);
            this.locktt.TabIndex = 5;
            this.locktt.Text = "%";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb);
            this.groupBox2.Controls.Add(this.MotorBox);
            this.groupBox2.Location = new System.Drawing.Point(482, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 100);
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
            this.MotorBox.TextChanged += new System.EventHandler(this.MotorBox_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 140);
            this.trackBar1.Maximum = 180;
            this.trackBar1.Minimum = -90;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(339, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.track4);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.tpBox);
            this.groupBox1.Controls.Add(this.barkl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(482, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 204);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Топливный клапан 21";
            // 
            // track4
            // 
            this.track4.AutoSize = true;
            this.track4.Location = new System.Drawing.Point(15, 185);
            this.track4.Name = "track4";
            this.track4.Size = new System.Drawing.Size(0, 13);
            this.track4.TabIndex = 7;
            // 
            // tpBox
            // 
            this.tpBox.Location = new System.Drawing.Point(15, 53);
            this.tpBox.Name = "tpBox";
            this.tpBox.ReadOnly = true;
            this.tpBox.Size = new System.Drawing.Size(144, 20);
            this.tpBox.TabIndex = 6;
            // 
            // barkl
            // 
            this.barkl.Location = new System.Drawing.Point(18, 95);
            this.barkl.Maximum = 50;
            this.barkl.Minimum = -50;
            this.barkl.Name = "barkl";
            this.barkl.Size = new System.Drawing.Size(318, 20);
            this.barkl.TabIndex = 5;
            this.barkl.Scroll += new System.Windows.Forms.ScrollEventHandler(this.barkl_Scroll);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.temp_num);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Location = new System.Drawing.Point(200, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 137);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Котел";
            // 
            // temp_num
            // 
            this.temp_num.Location = new System.Drawing.Point(10, 53);
            this.temp_num.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.temp_num.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.temp_num.Name = "temp_num";
            this.temp_num.Size = new System.Drawing.Size(114, 20);
            this.temp_num.TabIndex = 4;
            this.temp_num.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.temp_num.ValueChanged += new System.EventHandler(this.temp_num_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Температура";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 95);
            this.progressBar1.Maximum = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(247, 35);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 1;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(27, 373);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Lime;
            series3.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.LabelForeColor = System.Drawing.Color.Tomato;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.Red;
            series3.Name = "Входные";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series4.Name = "Вывод";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(791, 306);
            this.chart1.TabIndex = 8;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.LoadSAU_Load);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TrackOC);
            this.groupBox5.Location = new System.Drawing.Point(29, 205);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(434, 100);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Обратная Связь (ОС)";
            // 
            // TrackOC
            // 
            this.null_rowtt.SetIconPadding(this.TrackOC, 1);
            this.TrackOC.LargeChange = 20;
            this.TrackOC.Location = new System.Drawing.Point(3, 49);
            this.TrackOC.Maximum = 500;
            this.TrackOC.Minimum = -500;
            this.TrackOC.Name = "TrackOC";
            this.TrackOC.Size = new System.Drawing.Size(422, 29);
            this.TrackOC.TabIndex = 10;
            this.TrackOC.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackOC_Scroll);
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
            this.enbl_temp.Size = new System.Drawing.Size(184, 22);
            this.enbl_temp.Text = "вкл температура";
            // 
            // enbl_boiler
            // 
            this.enbl_boiler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnPort,
            this.UpConn});
            this.enbl_boiler.Name = "enbl_boiler";
            this.enbl_boiler.Size = new System.Drawing.Size(184, 22);
            this.enbl_boiler.Text = "Управление котлом";
            this.enbl_boiler.Click += new System.EventHandler(this.enbl_boiler_Click);
            // 
            // ConnPort
            // 
            this.ConnPort.Name = "ConnPort";
            this.ConnPort.Size = new System.Drawing.Size(226, 22);
            this.ConnPort.Text = "вкл";
            this.ConnPort.Click += new System.EventHandler(this.вклToolStripMenuItem_Click);
            // 
            // UpConn
            // 
            this.UpConn.Name = "UpConn";
            this.UpConn.Size = new System.Drawing.Size(226, 22);
            this.UpConn.Text = "обновить доступные порты";
            this.UpConn.Click += new System.EventHandler(this.UpConn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pusk_btn,
            this.toolStripSeparator1,
            this.toolStripSplitButton1,
            this.toolStripSeparator2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1153, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // null_rowtt
            // 
            this.null_rowtt.ContainerControl = this;
            // 
            // NBar
            // 
            this.NBar.Location = new System.Drawing.Point(29, 333);
            this.NBar.Maximum = 150;
            this.NBar.Minimum = -150;
            this.NBar.Name = "NBar";
            this.NBar.Size = new System.Drawing.Size(398, 30);
            this.NBar.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Мощность мотора управления клапаном";
            // 
            // tm_prgrbar
            // 
            this.tm_prgrbar.Tick += new System.EventHandler(this.tm_prgrbar_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_graph
            // 
            this.timer_graph.Tick += new System.EventHandler(this.timer_graph_Tick);
            // 
            // BoxPort
            // 
            this.BoxPort.Enabled = false;
            this.BoxPort.FormattingEnabled = true;
            this.BoxPort.Location = new System.Drawing.Point(993, 3);
            this.BoxPort.Name = "BoxPort";
            this.BoxPort.Size = new System.Drawing.Size(148, 21);
            this.BoxPort.TabIndex = 21;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "exit";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // LoadSAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 701);
            this.Controls.Add(this.BoxPort);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NBar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.chart1);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temp_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox5.ResumeLayout(false);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox MotorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox5;
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
        private System.Windows.Forms.Label locktt;
        private System.Windows.Forms.NumericUpDown temp_num;
        private System.Windows.Forms.HScrollBar TrackOC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.HScrollBar NBar;
        private System.Windows.Forms.Timer tm_prgrbar;
        private System.Windows.Forms.ToolStripMenuItem ConnPort;
        private System.Windows.Forms.HScrollBar barkl;
        private System.Windows.Forms.TextBox tpBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer_graph;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem UpConn;
        private System.Windows.Forms.ComboBox BoxPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label track4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

