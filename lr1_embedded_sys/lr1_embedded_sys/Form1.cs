using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO.Ports;


namespace lr1_embedded_sys
{
 
    public partial class LoadSAU : Form
    {

        //double S = 2.0;
        //добавление порта
       // SerialPort port1 = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);

        public void send(byte data)
        {
            if (serialPort1.IsOpen)
            {
                byte[] buffer = { 0 };
                buffer[0] = data;
                serialPort1.Write(buffer, 0, 1);
            }
        }
        class InsertToList
        {
            int value;
            DateTime ddtt;

            public InsertToList(int value, DateTime ddtt)
            {
                value = 0;
                ddtt = DateTime.Now;
            }
        }

        List<InsertToList> ttll = new List<InsertToList>();

        public LoadSAU()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private int _countSeconds = 0;
        //double limitTemp = 150;
        private void LoadSAU_Load(object sender, EventArgs e)
        {
            //запуск
            timer.Tick += timer_Tick;
            timer.Interval = 120;
        }



        private void timer_Tick(object sender, EventArgs e)
        {
            timer_graph.Tick += timer_graph_Tick;
            timer_graph.Interval = 120;
            //запуск методов
            timer1_Tick(null, null);
            
            DateTime timeNow = DateTime.Now;
            try
            {
                double value_tt = Convert.ToDouble(prec_tem_pusk.Text);
                chart1.Series[0].Points.AddXY(timeNow, value_tt);
            }
            catch
            {
                null_rowtt.SetError(prec_tem_pusk, "нет уставки");
            }
            
            int value = Convert.ToInt32(temp_num.Value);


            //построение точки на графике - выходные данные
            
            chart1.Series[1].Points.AddXY(timeNow, value);
            //график рандома
            // chart1.Series[1].Points.AddXY(timeNow, randtemp);

            ttll.Add(new InsertToList(value, timeNow));
            //обновление данных после x минуты
            _countSeconds++;
            if (_countSeconds == 240)
            {
                _countSeconds = 0;
                chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                chart1.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

                chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
                chart1.ChartAreas[0].AxisX.Interval = 2;
            }
           
        }

        protected void start_system_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
        double f(double s)
        {
            Random random = new Random();
            s = random.Next(2, 10);
            return -Math.Log(s) / s;
        }

        double F(double t)
        {
            Random random = new Random();
            t = random.Next(2, 10);
            return 1.0 / Math.Exp(2.0 * t);
        }

        private void trackstep(object sender, EventArgs e)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            double S = random.Next(10, 60); //коэффициент t
            try
            {
                double ttEnt = LaplaceTransform.Transform(f, S);
                double ttEnd = LaplaceTransform.InverseTransform(F, S);
                double funcW = ttEnd / ttEnt;
                //lboc.Text = Convert.ToString(funcW);

                //TrackOC.PerformStep(); когда-то был прогресс бар
                //трэк навигация
                locktt.Text = Convert.ToString(funcW);
                int ta = Convert.ToInt32(Convert.ToDouble(prec_tem_pusk.Text));
                //TrackOC.Value = ta;

            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //записать данные сигнала
            //signalBox.Text = Convert.ToString(Convert.ToDouble(funcW));
            //signalBox.Text = Convert.ToString(Convert.ToDouble(ssgnl));


        }

        private void prec_tem_pusk_TextChanged(object sender, EventArgs e)
        {
            //prec_tem_pusk.Text = trackOC.Value.ToString();
        }

        private void lboc_Click(object sender, EventArgs e)
        {
            
        }

        private void signalBox_TextChanged(object sender, EventArgs e)
        {
            

        }

       

        private void MotorBox_TextChanged(object sender, EventArgs e)
        {
            //расчет мощности клапа и передача NBar
            Random P = new Random();
            double p0 = P.Next(1, 10);
            //для расчета КПД насоса примем стандартную величину , где мощность мотора равна250 Вт , а приблизительная мощность насоса около 20%
            //следовательно его КПД равна около 45 %
            //определим давление 
            double Pdd = p0 * Convert.ToDouble(prec_tem_pusk.Text) / 1000; //деление на 1к для преобразования в кПА
            double Qreal = (100 * 10 * 2) - 20; //примерные стат данные
            int Nup = Convert.ToInt32((Pdd * Qreal) / (60 * 0.45));
            NBar.Value = Nup;

            //string w; //собственная функция изменения 
            Random random = new Random(DateTime.Now.Millisecond);
            double tt = random.Next(10, 60); //коэффициент t
            double s0 = tt * 100;
            double w;
            Random T0 = new Random();
            double t0 = T0.Next(0, 1);
            if (Double.TryParse(locktt.Text, out w))
            {
                w = (Convert.ToDouble(s0 + (Convert.ToDouble(locktt.Text) - s0) * Convert.ToDouble(NBar.Value)*(t0))) * 0.001;
            }
            
            MotorBox.Text = Convert.ToString(w);

        }

       // private void temp_num_ValueChanged(object sender, EventArgs e)
        

        private void tm_prgrbar_Tick(object sender, EventArgs e)
        {
            temp_num_ValueChanged(null, null);
            temprt_TextChanged(null, null);

            tm_prgrbar.Start();
            try
            {
                if (temp_num.Text  != String.Empty)
                {
                    progressBar1.Value = Int32.Parse(temp_num.Text);
                }
            
            }
            catch(Exception exeption)
            {
               // MessageBox.Show(exeption.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void temprt_TextChanged(object sender, EventArgs e)
        {
           // temprt.Text = temp_num.Value.ToString();
        }


        //расчет положения клапана
        private void tpBox_TextChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            double n = random.Next(1, 10); //коэффициент n
            Random tet = new Random();
            double teta = tet.Next(1, 10); //teta
            double T1 = Convert.ToDouble(trackBar1.Value) + (Convert.ToDouble(MotorBox.Text) - Convert.ToDouble(temp_num.Value)) * n * teta;
            tpBox.Text = Convert.ToString(T1);
            try
            {
                if (barkl.Value > 52.0)
                {
                    null_rowtt.SetError(barkl, "Ошибка");
                }
                else 
                {
                    barkl.Value = Convert.ToInt32(T1 * 0.01);
                }
                    
            }
            catch(Exception exeption)
            {
                //MessageBox.Show(exeption.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        //значение температуры
        private void temp_num_ValueChanged(object sender, EventArgs e)
        {
            // tpBox.Text
            //рандомы перемнных
            Random random = new Random();
            double n = random.Next(1, 10); //коэффициент n
            Random tet = new Random();
            double teta = tet.Next(1, 10); //teta
            Random ttmpet = new Random();
            double tt = ttmpet.Next(1, 10);
            try
            {
                double Tmp_num = tt + (Convert.ToDouble(tpBox.Text) - tt) * n * teta * 0.001;
                temp_num.Value = Convert.ToInt32(Tmp_num);
            }
            catch
            {
                MessageBox.Show("Неккоректные значения!");
            }
        }

        private void enbl_boiler_Click(object sender, EventArgs e)
        {
            
        }

        private void вклToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConnPort.Text == "вкл")
            {
                try
                {
                    serialPort1.PortName = BoxPort.Text;
                    serialPort1.Open();
                    ConnPort.Text = "выкл";
                }
                catch
                {
                    MessageBox.Show("Нет доступных подключений");
                }
            }

            else if (ConnPort.Text == "выкл")
            {
                serialPort1.Close();
                BoxPort.Enabled = false;
                ConnPort.Text = "вкл";
            }
         }


        private void TrackOC_Scroll(object sender, ScrollEventArgs e)
        {
            Random kk = new Random();
            int k = kk.Next(-1, 1);
            TrackOC.Value = Convert.ToInt32(temp_num.Value) * k;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trackstep(null, null);
            MotorBox_TextChanged(null, null);
            tpBox_TextChanged(null, null);
            TrackOC_Scroll(null, null);

            tm_prgrbar_Tick(null, null);
        }

        private void timer_graph_Tick(object sender, EventArgs e)
        {
            //timer_graph.Enabled = true;
            //рисуем график//
            temp_num.Maximum = 160;
            temp_num.Minimum = -10;
            //ось Y
            chart1.ChartAreas[0].AxisY.Maximum = 160;
            chart1.ChartAreas[0].AxisY.Minimum = -15;
            //ось X
            //установить формат
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            chart1.Series[0].XValueType = ChartValueType.DateTime;

            chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            chart1.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chart1.ChartAreas[0].AxisX.Interval = 10;
            // chart1.Series[0].ChartType = SeriesChartType.Line;
            // chart1.Series[1].ChartType = SeriesChartType.Line;


        }

        private void UpConn_Click(object sender, EventArgs e)
        {
            BoxPort.Enabled = true;
            string[] ports = SerialPort.GetPortNames();
            BoxPort.Text = "";
            BoxPort.Items.Clear();
            if (ports.Length !=0)
            {
                BoxPort.Items.AddRange(ports);
                BoxPort.SelectedIndex = 0;
            }
        }

        private void barkl_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //port1.Open();
            try
            {
                if(trackBar1.Value > 0)
                send(Byte.Parse(trackBar1.Value.ToString()));
                //track4.Text = trackBar1.Value.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            this.Close();
        }
    }
}
