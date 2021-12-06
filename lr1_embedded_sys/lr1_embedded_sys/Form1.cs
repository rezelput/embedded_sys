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
        SerialPort port1 = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);

        public void send(byte data)
        {
            if (port1.IsOpen)
            {
                byte[] buffer = { 0 };
                buffer[0] = data;
                port1.Write(buffer, 0, 1);
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
            //timer.Enabled = true;//запуск

            temp_num.Maximum = 155;
            temp_num.Minimum = -10;
            //ось Y
            chart1.ChartAreas[0].AxisY.Maximum = 160;
            chart1.ChartAreas[0].AxisY.Minimum = -15;
            //ось X
            //установить формат
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            chart1.Series[0].XValueType = ChartValueType.DateTime;

            //chart1.ChartAreas[0].AxisX.Maximum = 125;
            chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            chart1.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chart1.ChartAreas[0].AxisX.Interval = 10;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Start();
            trackstep(null, null);
            MotorBox_TextChanged(null, null);
            //
            // progressBar1.Value = Int32.Parse(temprt.Text);
            tm_prgrbar_Tick(null, null);
             //lboc.Text = trackOC.Value + "";
             //првоерка рандома
             /* Random random = new Random(DateTime.Now.Millisecond);
              double randtemp = random.Next(0, 41);
             */
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
            if (_countSeconds == 120)
            {
                _countSeconds = 0;
                chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                chart1.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

                chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chart1.ChartAreas[0].AxisX.Interval = 10;
            }

        }

        protected void start_system_Click(object sender, EventArgs e)
        {
            timer_Tick(null,null);
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
                TrackOC.Value = ta;

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

        //расчет мощности клапа и передача NBar
        private void SumMMK()
        {

            Random P = new Random();
            double p0 = P.Next(1, 10);
            //для расчета КПД насоса примем стандартную величину , где мощность мотора равна250 Вт , а приблизительная мощность насоса около 20%
            //следовательно его КПД равна около 45 %
            //определим давление 
            double Pdd = p0 * Convert.ToDouble(prec_tem_pusk.Text) / 10000; //деление на 1к для преобразования в кПА
            double Qreal = (100 * 10 * 2) - 20; //примерные стат данные
            int Nup = Convert.ToInt32((Pdd * Qreal) / (60 * 0.45));
            NBar.Value = Nup;

        }

        private void MotorBox_TextChanged(object sender, EventArgs e)
        {
            SumMMK();
            //string w; //собственная функция изменения 
            Random random = new Random(DateTime.Now.Millisecond);
            double tt = random.Next(10, 60); //коэффициент t
            double s0 = tt * 100;
            double w;
            Random T0 = new Random();
            double t0 = T0.Next(0, 1);
            if (Double.TryParse(locktt.Text, out w))
            {
                w = Convert.ToDouble(s0 + (Convert.ToDouble(locktt.Text) - s0) * Convert.ToDouble(NBar.Value)*(t0));
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
                MessageBox.Show(exeption.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void temprt_TextChanged(object sender, EventArgs e)
        {
           // temprt.Text = temp_num.Value.ToString();
        }

        private void tpBox_TextChanged(object sender, EventArgs e)
        {
            double fi;
            Random random = new Random();
            double n = random.Next(1, 10); //коэффициент n
            Random tet = new Random();
            double teta = tet.Next(1, 10); //teta


        }

        private void temp_num_ValueChanged(object sender, EventArgs e)
        {
           
            
        }

        private void enbl_boiler_Click(object sender, EventArgs e)
        {
            
        }

        private void вклToolStripMenuItem_Click(object sender, EventArgs e)
        {
            port1.Open();
            send(Byte.Parse(temp_num.Value.ToString()));
        }

        private void выклToolStripMenuItem_Click(object sender, EventArgs e)
        {
            port1.Close();
        }
    }
}
