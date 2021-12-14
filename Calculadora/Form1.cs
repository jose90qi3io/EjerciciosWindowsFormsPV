using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(Resultado.Text);

            if (Operador == '+')
            {
                Resultado.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(Resultado.Text);
            }
            else if (Operador == '-')
            {
                Resultado.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(Resultado.Text);
            }
            else if (Operador == 'x')
            {
                Resultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(Resultado.Text);
            }
            else if (Operador == '/')
            {
                if (Resultado.Text != "0")
                {
                    Resultado.Text = (Numero1 / Numero2).ToString();
                    Numero1 = Convert.ToDouble(Resultado.Text);
                }
                else
                {
                    MessageBox.Show("No se puede dividir por cero!!");
                }
                
            }
        }

        private void AgregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (Resultado.Text == "0")
                Resultado.Text = "";

            Resultado.Text += boton.Text;
        
        }

        private void Quitar_Click(object sender, EventArgs e)
        {
            if (Resultado.Text.Length > 1)
            {
                Resultado.Text = Resultado.Text.Substring(0, Resultado.Text.Length - 1);
            }
            else 
            {
                Resultado.Text = "0";
            }
        }

        private void BorrarTodo_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operador = '\0';
            Resultado.Text = "0";
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            Resultado.Text = "0";
        }

        private void Punto_Click(object sender, EventArgs e)
        {
            if (!Resultado.Text.Contains("."))
            {
                Resultado.Text += ".";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(Resultado.Text);
            Numero1 *= -1;
            Resultado.Text = Numero1.ToString();
        }

        private void ClickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            Numero1 = Convert.ToDouble(Resultado.Text);
            Operador = Convert.ToChar(boton.Tag);

            if (Operador == '²')
            {
                Numero1 = Math.Pow(Numero1, 2);
                Resultado.Text = Numero1.ToString();
            }
            else if (Operador == '√')
            {
                Numero1 = Math.Sqrt(Numero1);
                Resultado.Text = Numero1.ToString();
            }
            else {
                Resultado.Text = "0";

            }

        }

    }
}
