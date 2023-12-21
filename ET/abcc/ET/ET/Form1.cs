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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Articulos a = new Articulos();


        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtsku_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txtsku.Text != "")
            {
                MySqlConnection cnn = new MySqlConnection(Conexion.conex);
                cnn.Open();

                MySqlCommand comando = new MySqlCommand("mostrar", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@sk", txtsku.Text);

                MySqlDataReader myreader = comando.ExecuteReader();
                comando.Dispose();

                if (myreader.HasRows)
                {
                    while (myreader.Read())
                    {
                        txtarticulo.Text = myreader["Sku"].ToString();
                        txtmarca.Text = myreader["Articulo"].ToString();
                        txtmodelo.Text = myreader["Modelo"].ToString();
                        cbdepartamento.Text = myreader["Departamento"].ToString();
                        cbclase.Text = myreader["Clase"].ToString();
                        cbfamilia.Text = myreader["Familia"].ToString();
                        txtstock.Text = myreader["Stock"].ToString();
                        txtcantidad.Text = myreader["Cantidad"].ToString();
                        DateTime fechaalt = myreader.GetDateTime(myreader.GetOrdinal("Fecha_alta"));
                        dtpalta.Text = fechaalt.ToString();
                        DateTime fechabaj = myreader.GetDateTime(myreader.GetOrdinal("Fecha_baja"));
                        dtpbaja.Text = fechabaj.ToString();
                        activar();
                        btncambiar.Visible = true;
                        btneliminar.Visible = true;
                        btnconsultar.Visible = true;

                    }

                }
                else
                    btnalta.Enabled = true;
                btnalta.Visible = true;
                activar();

            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncambiar_Click(object sender, EventArgs e)
        {
            a.Sku = int.Parse(txtsku.Text);
            a.Articulo = txtarticulo.Text;
            a.Marca = txtarticulo.Text;
            a.Modelo = txtmodelo.Text;
            a.Departamento = int.Parse(cbdepartamento.Text);
            a.Clase = int.Parse(cbclase.Text);
            a.Familia = int.Parse(cbfamilia.Text);
            a.Fecha_alta = dtpalta.Value;
            a.Stock = int.Parse(txtstock.Text);
            a.Cantidad = int.Parse(txtcantidad.Text);
            if (chbdes.Checked == true)
            {
                a.Descontinuado = int.Parse("1");
            }
            else
            {
                a.Descontinuado = int.Parse("0");
            }
            a.Fecha_baja = dtpbaja.Value;
            a.Cambio();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            lblcon.Visible = true;
            btnbaja.Visible = true;
            btnbaja.Enabled = true;
            limpiar();
        }

        private void btnbaja_Click(object sender, EventArgs e)
        {
            a.Sku = int.Parse(txtsku.Text);
            a.Baja();
            limpiar();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            Consultar c = new Consultar();
            c.Show();
        }

        private void btnalta_Click(object sender, EventArgs e)
        {
            a.Sku = int.Parse(txtsku.Text);
            a.Articulo = txtarticulo.Text;
            a.Marca = txtarticulo.Text;
            a.Modelo = txtmodelo.Text;
            a.Departamento = int.Parse(cbdepartamento.Text);
            a.Clase = int.Parse(cbclase.Text);
            a.Familia = int.Parse(cbfamilia.Text);
            a.Fecha_alta = DateTime.Now;
            a.Stock = int.Parse(txtstock.Text);
            a.Cantidad = int.Parse(txtcantidad.Text);
            a.Descontinuado = int.Parse("0");
            a.Fecha_baja = DateTime.Parse("1900-01-01");
            a.Alta();
            limpiar();
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (int.Parse(txtstock.Text) > int.Parse(txtcantidad.Text))
            {
                MessageBox.Show("NO se puede tener una mayor cantidad al stock");
            }
        }

        public void activar()
        {
            btncambiar.Enabled = true;
            btneliminar.Enabled = true;
            btnconsultar.Enabled = true;
            txtarticulo.Enabled = true;
            txtmarca.Enabled = true;
            txtmodelo.Enabled = true;
            cbdepartamento.Enabled = true;
            cbclase.Enabled = true;
            cbfamilia.Enabled = true;
            txtstock.Enabled = true;
            txtcantidad.Enabled = true;
            dtpalta.Enabled = true;
            dtpbaja.Enabled = true;
        }
        public void limpiar()
        {
            txtsku.Text = "";
            txtsku.Focus();
            txtarticulo.Text = "";
            txtmarca.Text = "";
            txtmodelo.Text = "";
            cbdepartamento.Text = "";
            cbclase.Text = "";
            cbfamilia.Text = "";
            txtstock.Text = "";
            txtcantidad.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cbdepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection(Conexion.conex);
            cnn.Open();

            MySqlCommand comando = new MySqlCommand("validacion_dep", cnn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@dep", int.Parse(cbdepartamento.Text));

            MySqlDataReader myreader = comando.ExecuteReader();
            comando.Dispose();
            {
                
                    while (myreader.Read())
                    {
                        
                        cbclase.Text = myreader["id_dep"].ToString();
                        cbfamilia.Text = myreader["id_clas"].ToString();
                        
                    }
                
            }
        }
    }
}
