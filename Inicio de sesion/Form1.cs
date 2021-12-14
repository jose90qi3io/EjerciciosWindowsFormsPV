using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inicio_de_sesion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Usuario_Enter(object sender, EventArgs e)
        {
            if (Usuario.Text == "Usuario") {
                Usuario.Text = "";
            }
        }

        private void Usuario_Leave(object sender, EventArgs e)
        {
            if (Usuario.Text == ""){
                Usuario.Text = "Usuario";
            }
        }

        private void Contraseña_Enter(object sender, EventArgs e)
        {
            if (Contraseña.Text == "Contraseña") {
                Contraseña.Text = "";
                Contraseña.UseSystemPasswordChar = true;
            }
        }

        private void Contraseña_Leave(object sender, EventArgs e)
        {
            if (Contraseña.Text == "") {
                Contraseña.Text = "Contraseña";
                Contraseña.UseSystemPasswordChar = false;
            }
        }

        private void Acceder_Click(object sender, EventArgs e)
        {
            MySqlConnection conetar = new MySqlConnection("server=127.0.0.1; database= inicio_de_sesion; Uid=root;pwd=056120");
            conetar.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conetar;

            codigo.CommandText = ("select *from usuarios where usuario = '"+Usuario.Text+"' and Contraseña = '"+Contraseña.Text+"'");
            MySqlDataReader leer = codigo.ExecuteReader();

            if (leer.Read()) {
                MessageBox.Show("Bienvenido");
                Inicio llamar = new Inicio();
                llamar.Show();
                this.Hide();

            }

            else {
                MessageBox.Show("Usuario o Contraseña son incorrectos");
            }
        }
    }
}
