using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SteamTablesDemo.SteamTablesServices;
using System.Drawing;

namespace SteatTablesDemo
{
    class Functions
    {

        public static void FillDGV(DataGridView dgv, bool LiqVap, WtrProps Props95, WtrProps Props97)
        {

            if (LiqVap)
            {
                dgv.Rows[0].Cells[1].Value = MyMath.MyFormat(Props95.Temp);
                dgv.Rows[1].Cells[1].Value = MyMath.MyFormat(Props95.Press);
                dgv.Rows[2].Cells[1].Value = Props95.State;

                dgv.Rows[3].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.Volume);
                dgv.Rows[4].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.Density);
                dgv.Rows[5].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.Zo);
                dgv.Rows[6].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.U);
                dgv.Rows[7].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.H);
                dgv.Rows[8].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.G);
                dgv.Rows[9].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.A);
                dgv.Rows[10].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.S);
                dgv.Rows[11].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.Cp);
                dgv.Rows[12].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.Cv);
                dgv.Rows[13].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.CTE);
                dgv.Rows[14].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.Ziso);
                dgv.Rows[15].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.VelS);
                dgv.Rows[16].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.dPdT);
                dgv.Rows[17].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.dTdV);
                dgv.Rows[18].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.dVdP);
                dgv.Rows[19].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.JTC);
                dgv.Rows[20].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.IJTC);
                dgv.Rows[21].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.Vis);
                dgv.Rows[22].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.ThrmCond);
                dgv.Rows[23].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.SurfTen);
                dgv.Rows[24].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.PrdNum);
                dgv.Rows[25].Cells[1].Value = MyMath.MyFormat(Props95.Liquid.DielCons);

            }
            else
            {
                dgv.Rows[0].Cells[1].Value = MyMath.MyFormat(Props95.Temp);
                dgv.Rows[1].Cells[1].Value = MyMath.MyFormat(Props95.Press);
                dgv.Rows[2].Cells[1].Value = Props95.State;

                dgv.Rows[3].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.Volume);
                dgv.Rows[4].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.Density);
                dgv.Rows[5].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.Zo);
                dgv.Rows[6].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.U);
                dgv.Rows[7].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.H);
                dgv.Rows[8].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.G);
                dgv.Rows[9].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.A);
                dgv.Rows[10].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.S);
                dgv.Rows[11].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.Cp);
                dgv.Rows[12].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.Cv);
                dgv.Rows[13].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.CTE);
                dgv.Rows[14].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.Ziso);
                dgv.Rows[15].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.VelS);
                dgv.Rows[16].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.dPdT);
                dgv.Rows[17].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.dTdV);
                dgv.Rows[18].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.dVdP);
                dgv.Rows[19].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.JTC);
                dgv.Rows[20].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.IJTC);
                dgv.Rows[21].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.Vis);
                dgv.Rows[22].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.ThrmCond);
                dgv.Rows[23].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.SurfTen);
                dgv.Rows[24].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.PrdNum);
                dgv.Rows[25].Cells[1].Value = MyMath.MyFormat(Props95.Vapor.DielCons);
            }




            if (LiqVap)
            {
                dgv.Rows[0].Cells[2].Value = MyMath.MyFormat(Props97.Temp);
                dgv.Rows[1].Cells[2].Value = MyMath.MyFormat(Props97.Press);
                dgv.Rows[2].Cells[2].Value = Props97.State;

                dgv.Rows[3].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.Volume);
                dgv.Rows[4].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.Density);
                dgv.Rows[5].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.Zo);
                dgv.Rows[6].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.U);
                dgv.Rows[7].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.H);
                dgv.Rows[8].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.G);
                dgv.Rows[9].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.A);
                dgv.Rows[10].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.S);
                dgv.Rows[11].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.Cp);
                dgv.Rows[12].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.Cv);
                dgv.Rows[13].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.CTE);
                dgv.Rows[14].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.Ziso);
                dgv.Rows[15].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.VelS);
                dgv.Rows[16].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.dPdT);
                dgv.Rows[17].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.dTdV);
                dgv.Rows[18].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.dVdP);
                dgv.Rows[19].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.JTC);
                dgv.Rows[20].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.IJTC);
                dgv.Rows[21].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.Vis);
                dgv.Rows[22].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.ThrmCond);
                dgv.Rows[23].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.SurfTen);
                dgv.Rows[24].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.PrdNum);
                dgv.Rows[25].Cells[2].Value = MyMath.MyFormat(Props97.Liquid.DielCons);

            }
            else
            {
                dgv.Rows[0].Cells[2].Value = MyMath.MyFormat(Props97.Temp);
                dgv.Rows[1].Cells[2].Value = MyMath.MyFormat(Props97.Press);
                dgv.Rows[2].Cells[2].Value = Props97.State;

                dgv.Rows[3].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.Volume);
                dgv.Rows[4].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.Density);
                dgv.Rows[5].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.Zo);
                dgv.Rows[6].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.U);
                dgv.Rows[7].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.H);
                dgv.Rows[8].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.G);
                dgv.Rows[9].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.A);
                dgv.Rows[10].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.S);
                dgv.Rows[11].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.Cp);
                dgv.Rows[12].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.Cv);
                dgv.Rows[13].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.CTE);
                dgv.Rows[14].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.Ziso);
                dgv.Rows[15].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.VelS);
                dgv.Rows[16].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.dPdT);
                dgv.Rows[17].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.dTdV);
                dgv.Rows[18].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.dVdP);
                dgv.Rows[19].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.JTC);
                dgv.Rows[20].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.IJTC);
                dgv.Rows[21].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.Vis);
                dgv.Rows[22].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.ThrmCond);
                dgv.Rows[23].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.SurfTen);
                dgv.Rows[24].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.PrdNum);
                dgv.Rows[25].Cells[2].Value = MyMath.MyFormat(Props97.Vapor.DielCons);
            }
        }

        public static void InitializeDGV(DataGridView dgv)
        {
            dgv.DefaultCellStyle.Font = new Font("ArialNarrow", 8f);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("ArialNarrow", 10f);
            dgv.ColumnCount = 4;
            dgv.RowCount = 26;

            dgv.Columns[0].HeaderCell.Value = "Property";
            dgv.Columns[0].Width = 160;

            dgv.Columns[1].HeaderCell.Value = "StmTbl-95";
            dgv.Columns[1].Width = 130;
            dgv.Columns[2].HeaderCell.Value = "StmTbl-IF97";
            dgv.Columns[2].Width = 130;
            dgv.Columns[3].HeaderCell.Value = "Units";
            dgv.Columns[3].Width = 90;

            dgv.RowHeadersWidth = 38;

            int i;
            dgv.RowHeadersDefaultCellStyle.Font = new Font("ArialNarrow", 8f);
            dgv.RowHeadersWidth = 50;

            for (i = 1; i <= 26; i++)
            {
                dgv.Rows[i - 1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Rows[i - 1].HeaderCell.Value = i.ToString();
            }

            dgv.Rows[0].Cells[0].Value = "Temperature";
            dgv.Rows[1].Cells[0].Value = "Pressure";
            dgv.Rows[2].Cells[0].Value = "State";
            dgv.Rows[3].Cells[0].Value = "Volume";
            dgv.Rows[4].Cells[0].Value = "Density";
            dgv.Rows[5].Cells[0].Value = "Compressibility factor";
            dgv.Rows[6].Cells[0].Value = "Internal energy";
            dgv.Rows[7].Cells[0].Value = "Enthalpy";
            dgv.Rows[8].Cells[0].Value = "Gibbs free energy";
            dgv.Rows[9].Cells[0].Value = "Helmholtz free energy";
            dgv.Rows[10].Cells[0].Value = "Entropy";
            dgv.Rows[11].Cells[0].Value = "Heat capacity at constant P";
            dgv.Rows[12].Cells[0].Value = "Heat capacity at constant V";
            dgv.Rows[13].Cells[0].Value = "Coef. thermal expansion";
            dgv.Rows[14].Cells[0].Value = "Isothermal compressibility";
            dgv.Rows[15].Cells[0].Value = "Veolocity of sound";
            dgv.Rows[16].Cells[0].Value = "dP//dT ";
            dgv.Rows[17].Cells[0].Value = "dT//dV";
            dgv.Rows[18].Cells[0].Value = "dV//dP";
            dgv.Rows[19].Cells[0].Value = "Joules-Thomson Coef.";
            dgv.Rows[20].Cells[0].Value = "Isothermal Throttling Coef.";
            dgv.Rows[21].Cells[0].Value = "Viscosity";
            dgv.Rows[22].Cells[0].Value = "Thermal conductivity";
            dgv.Rows[23].Cells[0].Value = "Surface tension";
            dgv.Rows[24].Cells[0].Value = "Prandtl number";
            dgv.Rows[25].Cells[0].Value = "Dielectric constant";

            dgv.Rows[0].Cells[3].Value = @"K";
            dgv.Rows[1].Cells[3].Value = @"MPa";
            dgv.Rows[2].Cells[3].Value = @"Dimensionless";
            dgv.Rows[3].Cells[3].Value = @"m3/kg";
            dgv.Rows[4].Cells[3].Value = @"kg/m3";
            dgv.Rows[5].Cells[3].Value = @"Dimensionless";
            dgv.Rows[6].Cells[3].Value = @"kJ/kg K";
            dgv.Rows[7].Cells[3].Value = @"kJ/kg K";
            dgv.Rows[8].Cells[3].Value = @"kJ/kg K";
            dgv.Rows[9].Cells[3].Value = @"kJ/kg K";
            dgv.Rows[10].Cells[3].Value = @"kJ/kg K";
            dgv.Rows[11].Cells[3].Value = @"kJ/kg K";
            dgv.Rows[12].Cells[3].Value = @"kJ/kg K";
            dgv.Rows[13].Cells[3].Value = @"1/K";
            dgv.Rows[14].Cells[3].Value = @"1/MPa";
            dgv.Rows[15].Cells[3].Value = @"m/s";
            dgv.Rows[16].Cells[3].Value = @"MPa/K ";
            dgv.Rows[17].Cells[3].Value = @"K kg /m3";
            dgv.Rows[18].Cells[3].Value = @"m3/kg MPa";
            dgv.Rows[19].Cells[3].Value = @"K/MPa";
            dgv.Rows[20].Cells[3].Value = @"kJ/kg MPa";
            dgv.Rows[21].Cells[3].Value = @"micro Pa s";
            dgv.Rows[22].Cells[3].Value = @"W/m K";
            dgv.Rows[23].Cells[3].Value = @"N/m";
            dgv.Rows[24].Cells[3].Value = @"Dimensionless";
            dgv.Rows[25].Cells[3].Value = @"Dimensionless";
        }
    }
}
