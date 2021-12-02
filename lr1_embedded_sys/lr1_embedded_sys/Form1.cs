using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace lr1_embedded_sys
{
 
    public partial class LoadSAU : Form
    {

        //double S = 2.0;
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
            double S = random.Next(2, 120); //коэффициент t
            double ttEnt = LaplaceTransform.Transform(f, S);
            double ttEnd = LaplaceTransform.InverseTransform(F, S);
            double funcW = ttEnd/ttEnt ;
            //lboc.Text = Convert.ToString(funcW);
            TrackOC.Value = Convert.ToInt32(funcW);
            TrackOC.PerformStep();
            
            //записать данные сигнала
            double ssgnl = Convert.ToDouble(prec_tem_pusk.Text) - Convert.ToDouble(funcW);
            signalBox.Text = Convert.ToString(ssgnl);


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
    }
}
