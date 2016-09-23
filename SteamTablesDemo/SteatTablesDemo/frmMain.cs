using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SteamTablesDemo.SteamTablesServices;

namespace SteatTablesDemo
{
    public partial class frmMain : Form
    {
        const double TCR = 647.096;             //  K    temperature
        const double PCR = 22.064;              //  MPa   pressure
        const double RhoCR = 322;               //  kg m-3 density

        NEELSteamTablesSoapClient client = new NEELSteamTablesSoapClient("INEELSteamTablesSoap");
        WtrProps props95;
        WtrProps propsIF97;
        WtrSepBoundary sepBndry;


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Functions.InitializeDGV(dgvLiquid);
            Functions.InitializeDGV(dgvVapor);

        }

        private void btnTCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double Temp;

                Temp = Convert.ToDouble(txtTemp.Text);

                if (Temp <= TCR)
                {
                    sepBndry = WtrSepBoundary.Saturation;
                }
                else
                {
                    sepBndry = WtrSepBoundary.CriticalIsochor;
                }

                props95 = client.IAPWS95T(sepBndry, Temp);
                propsIF97 = client.IAPWSIF97T(sepBndry, Temp);

                Functions.FillDGV(dgvLiquid, true, props95, propsIF97);
                Functions.FillDGV(dgvVapor, false, props95, propsIF97);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnPCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double Press;

                Press = Convert.ToDouble(txtPress.Text);

                if (Press <= PCR)
                {
                    sepBndry = WtrSepBoundary.Saturation;
                }
                else
                {
                    sepBndry = WtrSepBoundary.CriticalIsochor;
                }

                props95 = client.IAPWS95P(sepBndry, Press);
                propsIF97 = client.IAPWSIF97P(sepBndry, Press);

                Functions.FillDGV(dgvLiquid, true, props95, propsIF97);
                Functions.FillDGV(dgvVapor, false, props95, propsIF97);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTPCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double Temp = Convert.ToDouble(txtTemp.Text);
                double Press = Convert.ToDouble(txtPress.Text);


                props95 = client.IAPWS95TP(Temp, Press);
                propsIF97 = client.IAPWSIF97TP(Temp, Press);

                Functions.FillDGV(dgvLiquid, true, props95, propsIF97);
                Functions.FillDGV(dgvVapor, false, props95, propsIF97);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
