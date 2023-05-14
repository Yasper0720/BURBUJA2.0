﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenamiento
{
    public partial class Burbuja : Form
    {
        Numeros Datos = new Numeros();
        bool estado = false;
        int[] Arreglo_numeros;
        Button[] Arreglo;
        public Burbuja()
        {
            InitializeComponent();
            
        }
        public void BubbleSort(ref int[] arreglo, ref Button[] Arreglo_Numeros)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = 0; j < arreglo.Length - 1; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    { 
                        int aux = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = aux;
                    Intercambio(ref Arreglo_Numeros, j + 1, j);
                     }
                }
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtNumero.Text);
                Datos.Insertar_Dato(num);
                Arreglo_numeros = Datos.obtener_Arreglo();
;                Arreglo = Datos.Arreglo_Botones();
            }
            catch
            {
                MessageBox.Show("Solo se admiten números enteros");
            }
            estado = true;
            tabPage1.Refresh();

        }

        private void TabPage1_Paint(object sender, PaintEventArgs e)
        {
            if (estado)
            {
                Point xy = new Point(50, 70);

                try
                {
                    Dibujar_Arreglo(ref Arreglo, xy, ref tabPage1);
                }
                catch
                {


                }
                estado = false;
            }
        }
        public void Dibujar_Arreglo(ref Button[] Arreglo, Point xy, ref TabPage t)
        {
            for (int i = 1; i < Arreglo.Length; i++)
            {
                Arreglo[i].Location = xy;
                t.Controls.Add(Arreglo[i]);
                xy += new Size(70, 0);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            btnOrdenar.Enabled = false; 
            txtNumero.Enabled = false;
            btnAgregar.Enabled = false;
            BubbleSort(ref Arreglo_numeros, ref Arreglo);

            this.Cursor = Cursors.Default;
            btnOrdenar.Enabled = true;
            txtNumero.Enabled = true;
            btnAgregar.Enabled = true;
        }
        public void Intercambio(ref Button[] boton, int a, int b)
        {
            string temp = boton[a].Text;
            Point pa = boton[a].Location;
            Point pb = boton[b].Location;
            int diferencia = pa.X - pb.X;
            int x = 10;
            int y = 10;
            int t = 70;
            while( y != 70)
            {
                Thread.Sleep(t);
                boton[a].Location += new Size(0, 10);
                boton[b].Location += new Size(0, -10);
                y += 10;
            }
            while (x != diferencia +10)
            {
                Thread.Sleep(t);
                boton[a].Location += new Size(-10, 0);
                boton[b].Location += new Size(10, 0);
                x += 10;
            }
            y = 0;
            while (y != -60)
            {
                Thread.Sleep(t);
                boton[a].Location += new Size(0, -10);
                boton[b].Location += new Size(0, +10);
                y -= 10;
            }
            boton[a].Text = boton[b].Text;
            boton[b].Text = temp;
            boton[b].Location = pb;
            boton[a].Location = pa;
            estado = true;
            tabPage1.Refresh();
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
