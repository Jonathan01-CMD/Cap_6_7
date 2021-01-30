using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap_6_7
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void txt_calcular_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            

            int salone = Convert.ToInt32(txt_salone.Text);

            int totalest = 0;

            float[][] calificaciones = new float[salone][];
            float total1 = 0;

            for (int i = 0; i < salone; i++)
            {
                cantidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Dijite el numero de estudiantes del salon " + (i + 1), "Estudiantes"));
                calificaciones[i] = new float[cantidad];
                totalest += cantidad;
            }

            for (int i = 0; i < salone; i++)
            {
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    calificaciones[i][j] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Dijite la calificacion del estudiante " + (j + 1), "Calificaciones"));
                    
                    

                }

            }
            imprimir(calificaciones, salone, totalest);
        }
        void imprimir(float[][] calificaciones, int salone, int totalest)
        {
            float total = 0;
            float menor = 999f;
            float mayor = 0f;
            float promedio = 0;
            float suma = 0;
            for (int i = 0; i < salone; i++)
            {
                lb_lista.Items.Add("-------Calificaciones salon " + (i + 1) + "-------");

                for (int m = 0; m < calificaciones[i].GetLength(0); m++)
                {

                    lb_lista.Items.Add("La calificacion de estidiante: " + (m + 1) + " :" + calificaciones[i][m]);
                    
                    if (calificaciones[i][m] < menor) 
                        {
                            menor = calificaciones[i][m];
                        }
                    if (calificaciones[i][m] > mayor)
                        {
                             mayor = calificaciones[i][m];
                        }
                    total += calificaciones[i][m];
                }
                
            }
           
            lb_positivo.Text = Convert.ToString(mayor);
            lb_negativo.Text = Convert.ToString(menor);

            promedio = total / totalest;
            txt_promedio.Text = promedio.ToString();


        }
        public void rellenar() { 

        }
    }
    
}
