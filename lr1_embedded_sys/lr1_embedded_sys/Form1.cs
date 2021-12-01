using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace lr1_embedded_sys
{
 
    public partial class LoadSAU : Form
    {
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
                null_rowtt.SetError(prec_tem_pusk, "не установлена температура");
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

        
    }
}
