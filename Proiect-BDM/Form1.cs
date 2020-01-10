using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using  Oracle.DataAccess.Types;
using WMPLib;

namespace Proiect_BDM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OracleConnection con;
        private void Conexiune_Click(object sender, EventArgs e)
        {
            string cons = "User ID=BDSA_DRAGHICIA; Password=stud; Data Source=(DESCRIPTION =" +
                        "(ADDRESS_LIST = (ADDRESS=(PROTOCOL = TCP)(HOST = 37.120.249.41)(PORT = 1521)))" +
                        " (CONNECT_DATA =(SID = orcl)(SERVER = DEDICATED)))";
            con = new OracleConnection(cons);
            MessageBox.Show("conexiune reusita");
        }

        private void BtnInserareImagine_Click(object sender, EventArgs e)
        {
            this.Conexiune_Click(sender, e);
            try
            {
                con.Open();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

            OracleCommand oracleCommand = new OracleCommand("psinserare", con);
            oracleCommand.CommandType = CommandType.StoredProcedure;
            oracleCommand.Parameters.Add("vid", OracleDbType.Int32);
            oracleCommand.Parameters.Add("vdescriere", OracleDbType.Varchar2, 255);
            oracleCommand.Parameters.Add("nfis", OracleDbType.Varchar2, 255);
            oracleCommand.Parameters[0].Value = Convert.ToInt32(txtBoxId.Text);
            oracleCommand.Parameters[1].Value = txtBoxDescriere.Text;
            oracleCommand.Parameters[2].Value = txtBoxNumeFisier.Text;
            try
            {
                oracleCommand.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            MessageBox.Show("inserare reusita");
        }


        private void btnGenerareSemnatura_Click(object sender, EventArgs e)
        {
            this.Conexiune_Click(sender, e);
            try
            {
                con.Open();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            OracleCommand oracleCommand = new OracleCommand("generareSemnatura", con);
            oracleCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                oracleCommand.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            MessageBox.Show("inserare reusita a semnaturilor");
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            this.Conexiune_Click(sender, e);
            try
            {
                con.Open();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            OracleCommand cmd = new OracleCommand("psexport", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("vid", OracleDbType.Int32);
            cmd.Parameters.Add("nfis", OracleDbType.Varchar2, 255);
            cmd.Parameters[0].Value = Convert.ToInt32(txtBoxId.Text);
            cmd.Parameters[1].Value = txtBoxNumeFisier.Text;

            try
            {
                cmd.ExecuteNonQuery();
            }

            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            MessageBox.Show("Export reusit!");
        }

        private void BtnAfisareImagine_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

            OracleCommand cmd = new OracleCommand("psAfisare", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("vid", OracleDbType.Int32);
            cmd.Parameters.Add("flux", OracleDbType.Blob);
            cmd.Parameters[0].Direction = ParameterDirection.Input;
            cmd.Parameters[1].Direction = ParameterDirection.Output;
            cmd.Parameters[0].Value = Convert.ToInt32(txtBoxIdAfisare.Text);

            try
            {
                cmd.ExecuteScalar();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            OracleBlob temp = (OracleBlob)cmd.Parameters[1].Value;
            pictureBox1.Image = Image.FromStream((System.IO.Stream)temp);
            con.Close();
        }

        private void btnRegasireImagine_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            OracleCommand cmd = new OracleCommand("psregasire", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("nfis", OracleDbType.Varchar2, 255);
            cmd.Parameters.Add("cculoare", OracleDbType.Decimal);
            cmd.Parameters.Add("ctextura", OracleDbType.Decimal);
            cmd.Parameters.Add("cforma", OracleDbType.Decimal);
            cmd.Parameters.Add("clocatie", OracleDbType.Decimal);
            cmd.Parameters.Add("idrez", OracleDbType.Int32);
            for (int i = 0; i < 5; i++)
            {
                cmd.Parameters[i].Direction = ParameterDirection.Input;
            }
            cmd.Parameters[5].Direction = ParameterDirection.Output;
            cmd.Parameters[0].Value = tBoxNumeFisier.Text;
            cmd.Parameters[1].Value = Convert.ToDecimal(tBoxCuloare.Text);
            cmd.Parameters[2].Value = Convert.ToDecimal(tBoxTextura.Text);
            cmd.Parameters[3].Value = Convert.ToDecimal(tBoxForma.Text);
            cmd.Parameters[4].Value = Convert.ToDecimal(tBoxLocatie.Text);

            try
            {
                cmd.ExecuteScalar();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtBoxIdAfisare.Text = Convert.ToString(cmd.Parameters[5].Value);
            con.Close();
            this.BtnAfisareImagine_Click(sender, e);
        }       
    }
}
