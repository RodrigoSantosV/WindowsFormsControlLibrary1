using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1 : UserControl
    {
        int numero_Correctas = 0;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        //Pregunta 1
        private void respuesta1Preg1_CheckedChanged(object sender, EventArgs e)
        {
            if (respuesta1Preg1.Checked)
            {
                respuesta2Preg1.Enabled = false;
                respuesta3Preg1.Enabled = false;
                respuesta4Preg1.Enabled = false;
                numero_Correctas = numero_Correctas + 1;
            }
            else
            {
                respuesta2Preg1.Enabled = true;
                respuesta3Preg1.Enabled = true;
                respuesta4Preg1.Enabled = true;
                numero_Correctas = numero_Correctas - 1;

            }
        }

        private void respuesta2Preg1_CheckedChanged(object sender, EventArgs e)
        {
            if (respuesta2Preg1.Checked)
            {
                respuesta1Preg1.Enabled = false;
                respuesta3Preg1.Enabled = false;
                respuesta4Preg1.Enabled = false;
            }
            else
            {
                respuesta1Preg1.Enabled = true;
                respuesta3Preg1.Enabled = true;
                respuesta4Preg1.Enabled = true;
            }
        }

        private void respuesta3Preg1_CheckedChanged(object sender, EventArgs e)
        {
            if (respuesta3Preg1.Checked)
            {
                respuesta2Preg1.Enabled = false;
                respuesta1Preg1.Enabled = false;
                respuesta4Preg1.Enabled = false;
            }
            else
            {
                respuesta2Preg1.Enabled = true;
                respuesta1Preg1.Enabled = true;
                respuesta4Preg1.Enabled = true;
            }
        }

        private void respuesta4Preg1_CheckedChanged(object sender, EventArgs e)
        {
            if (respuesta4Preg1.Checked)
            {
                respuesta2Preg1.Enabled = false;
                respuesta3Preg1.Enabled = false;
                respuesta1Preg1.Enabled = false;
            }
            else
            {
                respuesta2Preg1.Enabled = true;
                respuesta3Preg1.Enabled = true;
                respuesta1Preg1.Enabled = true;
            }
        }
        //Pregunta 2
        private void respuesta1Preg2_CheckedChanged(object sender, EventArgs e)
        {
            if (respuesta1Preg2.Checked)
            {
                respuesta2Preg2.Enabled = false;
                respuesta3Preg2.Enabled = false;
                respuesta4Preg2.Enabled = false;
            }
            else
            {
                respuesta2Preg2.Enabled = true;
                respuesta3Preg2.Enabled = true;
                respuesta4Preg2.Enabled = true;
            }
        }

        private void respuesta2Preg2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (respuesta2Preg2.Checked)
            {
                respuesta1Preg2.Enabled = false;
                respuesta3Preg2.Enabled = false;
                respuesta4Preg2.Enabled = false;
            }
            else
            {
                respuesta1Preg2.Enabled = true;
                respuesta3Preg2.Enabled = true;
                respuesta4Preg2.Enabled = true;
            }
        }

        private void respuesta3Preg2_CheckedChanged(object sender, EventArgs e)
        {
            if (respuesta3Preg2.Checked)
            {
                respuesta1Preg2.Enabled = false;
                respuesta2Preg2.Enabled = false;
                respuesta4Preg2.Enabled = false;
            }
            else
            {
                respuesta1Preg2.Enabled = true;
                respuesta2Preg2.Enabled = true;
                respuesta4Preg2.Enabled = true;
            }
        }

        private void respuesta4Preg2_CheckedChanged(object sender, EventArgs e)
        {
            if (respuesta4Preg2.Checked)
            {
                respuesta1Preg2.Enabled = false;
                respuesta2Preg2.Enabled = false;
                respuesta3Preg2.Enabled = false;
                numero_Correctas = numero_Correctas + 1;
            }
            else
            {
                respuesta1Preg2.Enabled = true;
                respuesta2Preg2.Enabled = true;
                respuesta3Preg2.Enabled = true;
                numero_Correctas = numero_Correctas - 1;
            }
        }
        
        //Pregunta 3
        private void respuesta1Preg3_CheckedChanged(object sender, EventArgs e)
        {
            if (respuesta1Preg3.Checked)
            {
                respuesta2Preg3.Enabled = false;
                respuesta3Preg3.Enabled = false;
                respuesta4Preg3.Enabled = false;

            }
            else
            {
                respuesta2Preg3.Enabled = true;
                respuesta3Preg3.Enabled = true;
                respuesta4Preg3.Enabled = true;

            }
        }

        private void respuesta2Preg3_CheckedChanged(object sender, EventArgs e)
        {
            if (respuesta2Preg3.Checked)
            {
                respuesta1Preg3.Enabled = false;
                respuesta3Preg3.Enabled = false;
                respuesta4Preg3.Enabled = false;
                numero_Correctas = numero_Correctas + 1;
            }
            else
            {
                respuesta1Preg3.Enabled = true;
                respuesta3Preg3.Enabled = true;
                respuesta4Preg3.Enabled = true;
                numero_Correctas = numero_Correctas - 1;
            }
        }

        private void respuesta3Preg3_CheckedChanged(object sender, EventArgs e)
        {
            if (respuesta3Preg3.Checked)
            {
                respuesta1Preg3.Enabled = false;
                respuesta2Preg3.Enabled = false;
                respuesta4Preg3.Enabled = false;

            }
            else
            {
                respuesta1Preg3.Enabled = true;
                respuesta2Preg3.Enabled = true;
                respuesta4Preg3.Enabled = true;

            }
        } 
        
        private void respuesta4Preg3_CheckedChanged(object sender, EventArgs e)
        {
            if (respuesta4Preg3.Checked)
            {
                respuesta1Preg3.Enabled = false;
                respuesta2Preg3.Enabled = false;
                respuesta3Preg3.Enabled = false;

            }
            else
            {
                respuesta1Preg3.Enabled = true;
                respuesta2Preg3.Enabled = true;
                respuesta3Preg3.Enabled = true;

            }
        }

        //Pregunta 4
       

        private void respuesta1Preg4_CheckedChanged(object sender, EventArgs e)
        {
            if (respuesta1Preg4.Checked)
            {
                respuesta2Preg4.Enabled = false;
                respuesta3Preg4.Enabled = false;
                respuesta4Preg4.Enabled = false;

            }
            else
            {
                respuesta2Preg4.Enabled = true;
                respuesta3Preg4.Enabled = true;
                respuesta4Preg4.Enabled = true;

            }
        }

        private void respuesta2Preg4_CheckedChanged(object sender, EventArgs e)
        {
            if (respuesta2Preg4.Checked)
            {
                respuesta1Preg4.Enabled = false;
                respuesta3Preg4.Enabled = false;
                respuesta4Preg4.Enabled = false;
                numero_Correctas = numero_Correctas + 1;
            }
            else
            {
                respuesta1Preg4.Enabled = true;
                respuesta3Preg4.Enabled = true;
                respuesta4Preg4.Enabled = true;
                numero_Correctas = numero_Correctas - 1;
            }
        }

        private void respuesta3Preg4_CheckedChanged(object sender, EventArgs e)
        {
            if (respuesta3Preg4.Checked)
            {
                respuesta1Preg4.Enabled = false;
                respuesta2Preg4.Enabled = false;
                respuesta4Preg4.Enabled = false;

            }
            else
            {
                respuesta1Preg4.Enabled = true;
                respuesta2Preg4.Enabled = true;
                respuesta4Preg4.Enabled = true;

            }
        }
        private void respuesta4Preg4_CheckedChanged(object sender, EventArgs e)
        {
            if (respuesta4Preg4.Checked)
            {
                respuesta1Preg4.Enabled = false;
                respuesta2Preg4.Enabled = false;
                respuesta3Preg4.Enabled = false;

            }
            else
            {
                respuesta1Preg4.Enabled = true;
                respuesta2Preg4.Enabled = true;
                respuesta3Preg4.Enabled = true;

            }
        }

       
        
        //Boton Resultados
        private void botonResultados_Click(object sender, EventArgs e)
        {
            resultadoFinal.Visible = true;
            if (numero_Correctas >= 2)
            {
                resultadoFinal.Text = "Enhorabuena has aprobado";
            }
            else
            {
                resultadoFinal.Text = "Hay que esforzarse mas, has suspendido";
            }
        }
    }
}

