using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace ET
{
    class Articulos
    {
        private int sk;
        private string art;
        private string mar;
        private string model;
        private int dep;
        private int clas;
        private int fam;
        private DateTime falt;
        private int sto;
        private int cant;
        private int descont;
        private DateTime fbaj;




        public int Sku { get { return this.sk; } set { this.sk = value; } }
        public string Articulo { get { return this.art; } set { this.art = value; } }
        public string Marca { get { return this.mar; } set { this.mar = value; } }
        public string Modelo { get { return this.model; } set { this.model = value; } }
        public int Departamento { get { return this.dep; } set { this.dep = value; } }
        public int Clase { get { return this.clas; } set { this.clas = value; } }
        public int Familia { get { return this.fam; } set { this.fam = value; } }
        public DateTime Fecha_alta { get { return this.falt; } set { this.falt = value; } }
        public int Stock { get { return this.sto; } set { this.sto = value; } }
        public int Cantidad { get { return this.cant; } set { this.cant = value; } }
        public int Descontinuado { get { return this.descont; } set { this.descont = value; } }
        public DateTime Fecha_baja { get { return this.fbaj; } set { this.fbaj = value; } }


        public bool Alta()
        {
            MySqlConnection cnn = new MySqlConnection();
            MySqlCommand comando = new MySqlCommand("alta_com",cnn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            cnn.ConnectionString = Conexion.conex;
            comando.Connection = cnn;
            cnn.Open();
            comando.Parameters.AddWithValue("@sk",this.sk );
            comando.Parameters.AddWithValue("@art",this.art );
            comando.Parameters.AddWithValue("@mar",this.mar );
            comando.Parameters.AddWithValue("@model",this.model );
            comando.Parameters.AddWithValue("@dep",this.dep );
            comando.Parameters.AddWithValue("@clas",this.clas );
            comando.Parameters.AddWithValue("@fam", this.fam);
            comando.Parameters.AddWithValue("@falt", this.falt);
            comando.Parameters.AddWithValue("@sto", this.sto);
            comando.Parameters.AddWithValue("@cant", this.cant);
            comando.Parameters.AddWithValue("@descont", this.descont);
            comando.Parameters.AddWithValue("@fbaj", this.fbaj);   
            
            
            int resul;
            resul = comando.ExecuteNonQuery();
            cnn.Close();
            cnn.Dispose();
            if (resul > 0) return true; else return false;
        }

        public bool Baja() {
            MySqlConnection cnn = new MySqlConnection();
            MySqlCommand comando = new MySqlCommand("baja", cnn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            cnn.ConnectionString = Conexion.conex;
            comando.Connection = cnn;
            cnn.Open();
            comando.Parameters.AddWithValue("@sk", this.sk);


            int resul;
            resul = comando.ExecuteNonQuery();
            cnn.Close();
            cnn.Dispose();
            if (resul > 0) return true; else return false;
        }

        public bool Cambio() {
            MySqlConnection cnn = new MySqlConnection();
            MySqlCommand comando = new MySqlCommand("cambio", cnn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            cnn.ConnectionString = Conexion.conex;
            comando.Connection = cnn;
            cnn.Open();
            comando.Parameters.AddWithValue("@art", this.art);
            comando.Parameters.AddWithValue("@mar", this.mar);
            comando.Parameters.AddWithValue("@model", this.model);
            comando.Parameters.AddWithValue("@dep", this.dep);
            comando.Parameters.AddWithValue("@clas", this.clas);
            comando.Parameters.AddWithValue("@fam", this.fam);
            comando.Parameters.AddWithValue("@falt", this.falt);
            comando.Parameters.AddWithValue("@sto", this.sto);
            comando.Parameters.AddWithValue("@cant", this.cant);
            comando.Parameters.AddWithValue("@descont", this.descont);
            comando.Parameters.AddWithValue("@fbaj", this.fbaj);   


            int resul;
            resul = comando.ExecuteNonQuery();
            cnn.Close();
            cnn.Dispose();
            if (resul > 0) return true; else return false;
        }

        
    }

}
