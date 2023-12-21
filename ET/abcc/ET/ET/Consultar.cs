using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ET
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

       

        public DataTable datosdep() 
        {
            MySqlConnection cnn = new MySqlConnection();
            MySqlCommand comando = new MySqlCommand("seledep",cnn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            cnn.ConnectionString = Conexion.conex;
            comando.Connection = cnn;
            cnn.Open();
            da.SelectCommand = comando;
            da.Fill(dt);
            cnn.Close();
            cnn.Dispose();
            return dt;
        }

        public DataTable datosclas()
        {
            MySqlConnection cnn = new MySqlConnection();
            MySqlCommand comando = new MySqlCommand("seleclas", cnn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            cnn.ConnectionString = Conexion.conex;
            comando.Connection = cnn;
            cnn.Open();
            da.SelectCommand = comando;
            da.Fill(dt);
            cnn.Close();
            cnn.Dispose();
            return dt;
        }

        public DataTable datosfam()
        {
            MySqlConnection cnn = new MySqlConnection();
            MySqlCommand comando = new MySqlCommand("selefam", cnn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            cnn.ConnectionString = Conexion.conex;
            comando.Connection = cnn;
            cnn.Open();
            da.SelectCommand = comando;
            da.Fill(dt);
            cnn.Close();
            cnn.Dispose();
            return dt;
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            dgvdep.DataSource = datosdep();
            dgvclas.DataSource = datosclas();
            dgvfam.DataSource = datosfam();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
