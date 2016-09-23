using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterHeating.SteamTablesServices;

namespace WaterHeating
{
    public partial class frmMain : Form
    {
        string ChartSeriesName;
        List<Color> myColors;
        int myColorIndex = 0;
        const double TCR = 647.096;
        NEELSteamTablesSoapClient client = new NEELSteamTablesSoapClient("INEELSteamTablesSoap");
        WtrHeating wtrHeating = new WtrHeating();
        double Tinc = 2;

        private bool IsConnectionAvailable(string url)
        {

            WebRequest request = null;
            WebResponse response = null;
            Uri Url = new Uri(url);
            try
            {
                //Creamos la request
                request = System.Net.WebRequest.Create(Url);
                //Ponemos un tiempo limite
                request.Timeout = 5000;
                //ejecutamos la request
                response = request.GetResponse();
                response.Close();
                request = null;

                return true;
            }
            catch 
            {
                request = null;
                return false;
            }
        }

        public frmMain()
        {
            InitializeComponent();
            if (IsConnectionAvailable("http://www.google.com.mx/?gws_rd=ssl") != true)
            {
                MessageBox.Show("Error! check internet connection");
                Application.Exit();
            }
            else if (IsConnectionAvailable("http://www.INEELGeoSteamNET.com/INEELSteamTables.asmx") != true)
            {
                MessageBox.Show("Error! Steam Tables Web Service is not active.");
                Application.Exit();
            }

            ////Avoid flickering
            //this.DoubleBuffered = true;
            //this.Paint += new PaintEventHandler(frmMain_Paint);

            SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw, true);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            InitialPlot();

            myColors = new List<Color>();
            myColors.Add(Color.BlueViolet);
            myColors.Add(Color.BurlyWood);
            myColors.Add(Color.Brown);
            myColors.Add(Color.Cyan);
            myColors.Add(Color.Crimson);
            myColors.Add(Color.Coral);
            myColors.Add(Color.CadetBlue);
            myColors.Add(Color.Chocolate);
            myColors.Add(Color.Crimson);
            myColors.Add(Color.DarkGreen);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            //draw container
            Pen p = new Pen(Color.DarkSlateGray, 10);
            e.Graphics.DrawRectangle(p, new Rectangle(0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1));

            wtrHeating.TotalMass = Convert.ToDouble(txtTotalMass.Text);
            wtrHeating.Volume = Convert.ToDouble(txtVol.Text);
            wtrHeating.Temperature = Convert.ToDouble(txtTemp.Text);

            if (wtrHeating.TotalMass == 0 || wtrHeating.Temperature < 273.16)
            {
                wtrHeating.WaterLevel = 0.0;
            }
            else
            {
                wtrHeating.WaterLevel = client.CalcWaterLevel(wtrHeating.TotalMass, wtrHeating.Volume, wtrHeating.Temperature).Level;
            }


            int wtrHeight = Convert.ToInt32((1 - wtrHeating.WaterLevel) * pictureBox1.Height);
            e.Graphics.FillRectangle(Brushes.Blue, new Rectangle(0, wtrHeight, pictureBox1.Width - 1, pictureBox1.Height - 1));

            e.Graphics.FillRectangle(Brushes.PaleVioletRed, new Rectangle(0, 0, pictureBox1.Width - 1, wtrHeight));

            e.Graphics.DrawRectangle(p, new Rectangle(0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1));

            txtWaterLevel.Text = MyMath.MyFormat(wtrHeating.WaterLevel);

        }

        private void txtTotalMass_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            lblCalcStatus.Text = "Calculating ... Please wait";

            ChartSeriesName = (string)(cboSeriesName.SelectedItem);
            timer1.Enabled = true;

            wtrHeating.TLiqVapFull = client.TempLiqVapFull(wtrHeating.TotalMass, wtrHeating.Volume).Temp;

            if (Math.Abs(wtrHeating.TLiqVapFull - TCR) < 1.1)
            {
                lblLiqVap.Text = "NEAR TO CP";
            }
            else
            {
                lblLiqVap.Text = MyMath.MyFormat(wtrHeating.TLiqVapFull);
            }


            wtrHeating = client.CalcVesselWtrHeating(wtrHeating.TotalMass, wtrHeating.Volume, wtrHeating.Temperature, wtrHeating.TLiqVapFull);

            txtPress.Text = MyMath.MyFormat(wtrHeating.Pressure);
            chart1.Series[ChartSeriesName].Points.AddXY(wtrHeating.Temperature, wtrHeating.Pressure);

            txtPress.Enabled = false;
            txtTemp.Enabled = false;
            btnCalc.Enabled = false;
            txtTotalMass.Enabled = false;
            cboSeriesName.Enabled = false;
            btnPause.Enabled = true;

            lblLiqVap.BorderStyle = BorderStyle.FixedSingle;
        }


        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private PointF[] SatSeries()
        {
            PointF[] SatData = new PointF[84];

            SatData[0] = new PointF(273.16F, 0.0006117F);
            SatData[1] = new PointF(274F, 0.0006500F);
            SatData[2] = new PointF(275F, 0.0006985F);
            SatData[3] = new PointF(277f, 0.000805f);
            SatData[4] = new PointF(280F, 0.0009918F);
            SatData[5] = new PointF(285F, 0.0013890F);
            SatData[6] = new PointF(290F, 0.0019200F);
            SatData[7] = new PointF(295F, 0.0026212F);
            SatData[8] = new PointF(300F, 0.0035368F);
            SatData[9] = new PointF(305F, 0.0047193F);
            SatData[10] = new PointF(310F, 0.0062311F);
            SatData[11] = new PointF(315F, 0.0081451F);
            SatData[12] = new PointF(320F, 0.0105460F);
            SatData[13] = new PointF(325F, 0.0135315F);
            SatData[14] = new PointF(330F, 0.0172132F);
            SatData[15] = new PointF(335F, 0.0217177F);
            SatData[16] = new PointF(340F, 0.0271878F);
            SatData[17] = new PointF(345F, 0.0337833F);
            SatData[18] = new PointF(350F, 0.0416817F);
            SatData[19] = new PointF(355F, 0.0510798F);
            SatData[20] = new PointF(360F, 0.0621936F);
            SatData[21] = new PointF(365F, 0.0752596F);
            SatData[22] = new PointF(370F, 0.0905352F);
            SatData[23] = new PointF(375F, 0.1082994F);
            SatData[24] = new PointF(380F, 0.1288531F);
            SatData[25] = new PointF(385F, 0.1525195F);
            SatData[26] = new PointF(390F, 0.1796447F);
            SatData[27] = new PointF(395F, 0.2105973F);
            SatData[28] = new PointF(400F, 0.2457693F);
            SatData[29] = new PointF(405F, 0.2855757F);
            SatData[30] = new PointF(410F, 0.3304544F);
            SatData[31] = new PointF(415F, 0.3808667F);
            SatData[32] = new PointF(420F, 0.4372967F);
            SatData[33] = new PointF(425F, 0.5002512F);
            SatData[34] = new PointF(430F, 0.5702598F);
            SatData[35] = new PointF(435F, 0.6478744F);
            SatData[36] = new PointF(440F, 0.7336690F);
            SatData[37] = new PointF(445F, 0.8282396F);
            SatData[38] = new PointF(450F, 0.9322036F);
            SatData[39] = new PointF(455F, 1.0461997F);
            SatData[40] = new PointF(460F, 1.1708876F);
            SatData[41] = new PointF(465F, 1.3069478F);
            SatData[42] = new PointF(470F, 1.4550812F);
            SatData[43] = new PointF(475F, 1.6160088F);
            SatData[44] = new PointF(480F, 1.7904718F);
            SatData[45] = new PointF(485F, 1.9792313F);
            SatData[46] = new PointF(490F, 2.1830680F);
            SatData[47] = new PointF(495F, 2.4027827F);
            SatData[48] = new PointF(500F, 2.6391959F);
            SatData[49] = new PointF(505F, 2.8931480F);
            SatData[50] = new PointF(510F, 3.1655001F);
            SatData[51] = new PointF(515F, 3.4571334F);
            SatData[52] = new PointF(520F, 3.7689510F);
            SatData[53] = new PointF(525F, 4.1018775F);
            SatData[54] = new PointF(530F, 4.4568605F);
            SatData[55] = new PointF(535F, 4.8348716F);
            SatData[56] = new PointF(540F, 5.2369081F);
            SatData[57] = new PointF(545F, 5.6639942F);
            SatData[58] = new PointF(550F, 6.1171836F);
            SatData[59] = new PointF(555F, 6.5975619F);
            SatData[60] = new PointF(560F, 7.1062495F);
            SatData[61] = new PointF(565F, 7.6444060F);
            SatData[62] = new PointF(570F, 8.2132339F);
            SatData[63] = new PointF(575F, 8.8139850F);
            SatData[64] = new PointF(580F, 9.4479664F);
            SatData[65] = new PointF(585F, 10.1165497F);
            SatData[66] = new PointF(590F, 10.8211806F);
            SatData[67] = new PointF(595F, 11.5633928F);
            SatData[68] = new PointF(600F, 12.3448244F);
            SatData[69] = new PointF(605F, 13.1672398F);
            SatData[70] = new PointF(610F, 14.0325580F);
            SatData[71] = new PointF(615F, 14.9428890F);
            SatData[72] = new PointF(620F, 15.9005794F);
            SatData[73] = new PointF(625F, 16.9082693F);
            SatData[74] = new PointF(630F, 17.9689714F);
            SatData[75] = new PointF(635F, 19.0862700F);
            SatData[76] = new PointF(640F, 20.2652093F);
            SatData[74] = new PointF(641F, 20.5091035F);
            SatData[77] = new PointF(642F, 20.7559294F);
            SatData[78] = new PointF(643F, 21.0058098F);
            SatData[79] = new PointF(644F, 21.2588685F);
            SatData[80] = new PointF(645F, 21.5152087F);
            SatData[81] = new PointF(646F, 21.7749107F);
            SatData[82] = new PointF(647F, 22.0384057F);
            SatData[83] = new PointF(647.096F, 22.0640000F);

            return SatData;
        }


        private PointF[] Melt1Series()
        {

            PointF[] Melt1Data = new PointF[43];
            Melt1Data[0] = new PointF(251.165F, 208.5660000F);
            Melt1Data[1] = new PointF(252F, 202.3703116F);
            Melt1Data[2] = new PointF(253F, 194.8431154F);
            Melt1Data[3] = new PointF(254F, 187.1929444F);
            Melt1Data[4] = new PointF(255F, 179.4128060F);
            Melt1Data[5] = new PointF(256F, 171.4950492F);
            Melt1Data[6] = new PointF(257F, 163.4312946F);
            Melt1Data[7] = new PointF(258F, 155.2123526F);
            Melt1Data[8] = new PointF(259F, 146.8281274F);
            Melt1Data[9] = new PointF(260F, 138.2675013F);
            Melt1Data[10] = new PointF(261F, 129.5181917F);
            Melt1Data[11] = new PointF(262F, 120.5665720F);
            Melt1Data[12] = new PointF(263F, 111.3974418F);
            Melt1Data[13] = new PointF(264F, 101.9937252F);
            Melt1Data[14] = new PointF(265F, 92.3360684F);
            Melt1Data[15] = new PointF(266F, 82.4022939F);
            Melt1Data[16] = new PointF(267F, 72.1666499F);
            Melt1Data[17] = new PointF(268F, 61.5987679F);
            Melt1Data[18] = new PointF(269F, 50.6622005F);
            Melt1Data[19] = new PointF(270F, 39.3123605F);
            Melt1Data[20] = new PointF(270.2F, 36.9881391F);
            Melt1Data[21] = new PointF(270.4F, 34.6447000F);
            Melt1Data[22] = new PointF(270.6F, 32.2815094F);
            Melt1Data[23] = new PointF(270.8F, 29.8980056F);
            Melt1Data[24] = new PointF(271.0F, 27.4935984F);
            Melt1Data[25] = new PointF(271.2F, 25.0676663F);
            Melt1Data[26] = new PointF(271.4F, 22.6195545F);
            Melt1Data[27] = new PointF(271.6F, 20.1485729F);
            Melt1Data[28] = new PointF(271.8F, 17.6539934F);
            Melt1Data[29] = new PointF(272.0F, 15.1350473F);
            Melt1Data[30] = new PointF(272.2F, 12.5909226F);
            Melt1Data[31] = new PointF(272.4F, 10.0207608F);
            Melt1Data[32] = new PointF(272.6F, 7.4236536F);
            Melt1Data[33] = new PointF(272.8F, 4.7986397F);
            Melt1Data[34] = new PointF(273.0F, 2.1447006F);
            Melt1Data[35] = new PointF(273.05F, 1.4765712F);
            Melt1Data[36] = new PointF(273.1F, 0.8065493F);
            Melt1Data[37] = new PointF(273.15F, 0.1346172F);

            Melt1Data[38] = new PointF(273.152F, 0.1077000F);
            Melt1Data[39] = new PointF(273.154F, 0.0807796F);
            Melt1Data[40] = new PointF(273.156F, 0.0538562F);
            Melt1Data[41] = new PointF(273.158F, 0.0269296F);

            Melt1Data[42] = new PointF(273.16F, 0.0006117F);

            return Melt1Data;
        }


        private void InitialPlot()
        {

            //X-axis

            chart1.ChartAreas[0].AxisX.Minimum = 250;
            chart1.ChartAreas[0].AxisX.Maximum = 850;
            chart1.ChartAreas[0].AxisX.Interval = 100;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 100;

            //chart1.ChartAreas[0].AxisX.LineColor = Color.Black;



            //Y-axis

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 40;
            chart1.ChartAreas[0].AxisY.Interval = 10;
            chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 10;
            //chart1.ChartAreas[0].AxisY.LineColor = Color.Black;
            //chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 2;


            //Liquid-vapor saturation data

            PointF[] pnt;
            pnt = SatSeries();
            int n = pnt.Count();
            float[] X = new float[n];
            float[] Y = new float[n];

            chart1.Series[0].BorderWidth = 2;

            chart1.Series[0].LegendText = "Sat.";
            for (int i = 0; i < n - 1; i++)
            {
                chart1.Series[0].Points.AddXY(pnt[i].X, pnt[i].Y);
            }

            //Melt Ice 1 data
            chart1.Series[1].BorderWidth = 2;
            chart1.Series[1].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            PointF[] pntMelt;
            pntMelt = Melt1Series();

            n = pntMelt.Count();

            for (int i = 0; i < n - 1; i++)
            {
                chart1.Series[1].Points.AddXY(pntMelt[i].X, pntMelt[i].Y);
            }

            chart1.Series[1].LegendText = "Ice I";
            chart1.Series[2].BorderWidth = 3;
            chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart1.Series[2].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;


            chart1.Series[2].Points.AddXY(647.096F, 39.9F);
            chart1.Series[2].Points.AddXY(647.096F, 22.064F);
            chart1.Series[2].Points.AddXY(849.9F, 22.064F);
            chart1.Series[2].LegendText = "Cri.";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            if (wtrHeating.Temperature < 850.0 && wtrHeating.Pressure < 40.0)
            {
                if ((wtrHeating.TLiqVapFull > 600.0) && (wtrHeating.Temperature > 600.0 && wtrHeating.Temperature < 648.0)
                    && (Math.Abs(wtrHeating.TLiqVapFull - wtrHeating.Temperature) < 4))
                {
                    Tinc = 0.1;
                }
                else
                {
                    Tinc = calcTinc(trbSpeedCalc.Value);
                }

                wtrHeating.Temperature += Tinc;
                wtrHeating = client.CalcVesselWtrHeating(wtrHeating.TotalMass, wtrHeating.Volume, wtrHeating.Temperature, wtrHeating.TLiqVapFull);

                txtPress.Text = MyMath.MyFormat(wtrHeating.Pressure);
                txtTemp.Text = wtrHeating.Temperature.ToString();

                txtWaterLevel.Text = MyMath.MyFormat(wtrHeating.WaterLevel);
                chart1.Series[ChartSeriesName].Points.AddXY(wtrHeating.Temperature, wtrHeating.Pressure);
                pictureBox1.Refresh();
            }
            else
            {
                lblCalcStatus.Text = "Done! Define new experiment ....";

                timer1.Enabled = false;

                chart1.Series[ChartSeriesName].Color = myColors[myColorIndex];
                chart1.Series[ChartSeriesName].BorderWidth = 1;
                chart1.Series[ChartSeriesName].LegendText = txtTotalMass.Text;
                pictureBox1.Refresh();

                myColorIndex += 1;
                //changing 
                txtTemp.Text = "300";
                txtPress.Text = "";

                cboSeriesName.Items.Remove(cboSeriesName.Text);
                if (cboSeriesName.Items.Count > 0)
                {
                    cboSeriesName.Text = cboSeriesName.Items[0].ToString();
                    txtPress.Enabled = true;
                    txtTemp.Enabled = true;
                    btnCalc.Enabled = true;
                    txtTotalMass.Enabled = true;
                    cboSeriesName.Enabled = true;
                    btnPause.Enabled = false;
                    pictureBox1.Refresh();
                }
                else
                {
                    cboSeriesName.Text = "";
                    cboSeriesName.Enabled = false;
                    lblCalcStatus.Text = "Rerun! limit upto 10 experiments...";
                }
            }
        }

        private void trbSpeedCalc_Scroll(object sender, EventArgs e)
        {
            Tinc = calcTinc(trbSpeedCalc.Value);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (btnPause.Text == "Pause")
            {
                btnPause.Text = "Continue";
                timer1.Enabled = false;
            }
            else
            {
                btnPause.Text = "Pause";
                timer1.Enabled = true;
            }
        }

        private void txtTotalMass_Validating(object sender, CancelEventArgs e)
        {
            if (txtTotalMass.Text != "")
            {
                try
                {
                    double totalMass;
                    totalMass = Convert.ToDouble(txtTotalMass.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid Entry, Must be Numeric", "Error");
                }
            }
            else
            {
                MessageBox.Show("Nothing entered in myTextBox", "Error");
            }
        }

        private void txtTemp_Validated(object sender, EventArgs e)
        {
            if (txtTemp.Text != "")
            {
                try
                {
                    double temp;
                    temp = Convert.ToDouble(txtTemp.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid Entry, Must be Numeric", "Error");
                }
            }
            else
            {
                MessageBox.Show("Nothing entered in myTextBox", "Error");
            }
        }

        private double calcTinc(double x)
        {
            double TincMin = 1;
            double TincMax = 4;
            double m = (TincMax - TincMin) / (10);
            double c = 1;
            Tinc = m * x + c;
            return Tinc;
        }

        private void txtTemp_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
    }
}
