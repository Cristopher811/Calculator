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
        private double valor1;
        private double valor2;

        private double resultado;

        private int operacion;

        
        public Form1()
        {
            InitializeComponent();
        }
        //Para mostrar texto al dar click
        private void buttonNum1_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "1";
        }

        private void buttonNum2_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "2";
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "3";
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "4";
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "5";
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "6";
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "7";
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "8";
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
           
            textBoxDisplay.Text = textBoxDisplay.Text + "9";
        }

        private void buttonNum0_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "0";
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxDisplay.Text == " ")
                {
                    textBoxDisplay.Text = textBoxDisplay.Text.Substring(textBoxDisplay.Text.Length - 1, 1);
                    textBoxDisplay.Text = textBoxDisplay.Text + ".";
                }
                else
                {
                    textBoxDisplay.Text = ".";
                }
                

            }
            catch(Exception error)
            {

            }
            
        }
        //Botones para borrar
        private void buttonBorrarCalculo_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
        }
        private void buttonBorrarCaracter_Click(object sender, EventArgs e)
        {
            try
            {
                int hasta = textBoxDisplay.Text.Length - 1;
                string resultado = textBoxDisplay.Text.Substring(0, hasta);
                textBoxDisplay.Text = resultado;
            }catch(Exception error)
            {
                
            }
        }
        //Operaciones matemáticas
        private void buttonMás_Click(object sender, EventArgs e)
        {
            try
            {
                operacion = 1;
                valor1 = Convert.ToDouble(textBoxDisplay.Text);
                textBoxDisplay.Text = " ";
            }catch(Exception error)
            {
                
            }
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                operacion = 2;
                valor1 = Convert.ToDouble(textBoxDisplay.Text);
                textBoxDisplay.Text = " ";
            }
            catch(Exception error)
            {
                
            }
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            try
            {
                operacion = 3;
                valor1 = Convert.ToDouble(textBoxDisplay.Text);
                textBoxDisplay.Text = " ";
            }catch(Exception error)
            {
                
            }
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (textBoxDisplay.Text == "")
                {
                    
                    textBoxDisplay.Text = textBoxDisplay.Text = "-";
                    
                }
                else
                {
                    textBoxDisplay.Text = " ";
                    
                }
                operacion = 4;
                valor1 = Convert.ToDouble(textBoxDisplay.Text);
                


            }
            catch (Exception error)
            {
               
            }

        }

        private void buttonPorcentaje_Click(object sender, EventArgs e)
        {
            try
            {
                
                operacion = 5;
                valor1 = Convert.ToDouble(textBoxDisplay.Text);
                textBoxDisplay.Text = " ";
            }catch(Exception error)
            {
               
            }
        }
        //Botón igual
        private void buttonIgual_Click(object sender, EventArgs e)
        {
            try
            {
                valor2 = Convert.ToDouble(textBoxDisplay.Text);
                switch (operacion)
                {
                    case 1:
                        resultado = valor1 + valor2;
                        break;
                    case 2:
                        resultado = valor1 * valor2;
                        break;
                    case 3:
                        resultado = valor1 / valor2;
                        Console.WriteLine(resultado);
                        break;
                    case 4:
                        resultado = valor1 - valor2;
                        break;
                    case 5:
                        resultado = (valor1 / 100) * valor2;
                        break;
                }
                textBoxDisplay.Text = resultado.ToString();
            }
            catch (Exception error)
            {

            }
        }
        private void textBoxDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Esta calculadora no permite ingresar datos ni acciones por medio del teclado :( \nSe recomienda usar la interfaz :)");
            //Para obligar a que sólo se introduzcan números por medio de la interfaz
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
              if (Char.IsControl(e.KeyChar)) // No permitir teclas de control como retroceso
            {
                e.Handled = true;
            }
            else
            {
                //El resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
