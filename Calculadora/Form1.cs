using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            lbxTela.Items.Add(7);
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            lbxTela.Items.Add(0);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lbxTela.Items.Add(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lbxTela.Items.Add(3);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lbxTela.Items.Add(6);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lbxTela.Items.Add(5);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lbxTela.Items.Add(4);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lbxTela.Items.Add(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lbxTela.Items.Add(9);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lbxTela.Items.Add(1);
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            var items = lbxTela.Items;
            if (items.Count == 0) return;
            foreach (var item in items) 
            {
                switch (item) 
                {
                    case "+":
                    case "-": 
                    case "*":
                    case "/":
                        return;
                    default:
                        break;
                }
            }

            lbxTela.Items.Add("+");  
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            var items = lbxTela.Items;
            if (items.Count == 0) return;
            foreach (var item in items)
            {
                switch (item)
                {
                    case "+":
                    case "-":
                    case "x":
                    case "/":
                        return;
                    default:
                        break;
                }
            }

            lbxTela.Items.Add("x");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            var items = lbxTela.Items;
            if (items.Count == 0) return;
            foreach (var item in items) 
            {
                if (item == "+" || item == "-" || item == "x" || item == "/") return;
            }
            lbxTela.Items.Add("-");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            var items = lbxTela.Items;
            if (items.Count == 0) return;
            foreach (var item in items)
            {
                if (item == "+" || item == "-" || item == "x" || item == "/") return;
            }
            lbxTela.Items.Add("/");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            // Obtendo os elementos da minha lista 
            var lista = lbxTela.Items;
            string operacao = "";
            if (lista.Count == 0)
            {
                //Fim do algoritimo
                return;
            }
            
            foreach (var item in lista) 
            {
                operacao += item.ToString();
                if (item.ToString() == "=") 
                {
                    // Fim do algoritimo
                    return ;
                }
            }
            if (operacao.Contains("+"))
            {
                string[] operados = operacao.Split('+');

                if (operados.Length < 2 || operados[1] == "")
                {
                    return;
                }
                double resultdo = Convert.ToDouble(operados[0]) + Convert.ToDouble(operados[1]);
                lbxTela.Items.Add("=");
                lbxTela.Items.Add(resultdo);
            }
            else if (operacao.Contains("-"))
            {
                string[] operados = operacao.Split('-');

                if (operados.Length < 2 || operados[1] == "")
                {
                    return;
                }
                double resultdo = Convert.ToDouble(operados[0]) - Convert.ToDouble(operados[1]);
                lbxTela.Items.Add("=");
                lbxTela.Items.Add(resultdo);
            }
            else if (operacao.Contains("/")) 
            {
                string[] operados = operacao.Split('/');
              

                if (operados.Length < 2 || operados[1] == "")
                {
                    return;
                }

                if (Convert.ToDouble(operados[1]) == 0)
                {
                    string resultado = "Não é possivel dividir por zero";
                    lbxTela.Items.Add("=");
                    lbxTela.Items.Add(resultado);
                }
                else {
                    double resultado = Convert.ToDouble(operados[0]) / Convert.ToDouble(operados[1]);
                    lbxTela.Items.Add("=");
                    lbxTela.Items.Add(resultado);
                }
            }else if (operacao.Contains("x"))
            {
                string[] operados = operacao.Split('x');

                if (operados.Length < 2 || operados[1] == "")
                {
                    return;
                }
                double resultdo = Convert.ToDouble(operados[0]) * Convert.ToDouble(operados[1]);
                lbxTela.Items.Add("=");
                lbxTela.Items.Add(resultdo);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lbxTela.Items.Clear();
        }
    }
}


