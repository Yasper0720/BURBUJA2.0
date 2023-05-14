
using System.Drawing;
using System;
using System.Windows.Forms;
using System.Windows.Forms.Design;



namespace Ordenamiento
{
    partial class Burbuja
    {
    
        //bool estado = false;
        //int[] Arreglo_numeros;
        //public Button[] Arreglo;
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(454, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulación Método de Ordenamiento Burja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insertar Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(210, 100);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(148, 22);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.TextChanged += new System.EventHandler(this.TxtNumero_TextChanged);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(592, 100);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(112, 32);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(441, 97);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 32);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(48, 176);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 317);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 286);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ver Simulacion";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.TabPage1_Paint);
            // 
            // Burbuja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Burbuja";
            this.Text = "Método de ordenamiento BubbleSort";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
    }
    class Numeros
    {
        private int longitud;
        private int[] arreglo = new int[1];
        private Button[] arreglo_botones = new Button[1];


        public Numeros()
        {
            int a = 0;
            arreglo[0] = a;
            arreglo_botones[0] = new Button();
            arreglo_botones[0].Width = 40;
            arreglo_botones[0].Height = 40;
            Color GreenYellow = default;
            arreglo_botones[0].BackColor = GreenYellow;
            arreglo_botones[0].Text = a.ToString();
            calcular_Longitud();

        }
        public void calcular_Longitud()
        {
            longitud = arreglo.Length;
        }
        public int obtener_Longitud()
        {
            return longitud;
        }
        public int[] obtener_Arreglo()
        {
            return arreglo;
        }
        public void Insertar_Dato(int dato)
        {

            Array.Resize<int>(ref arreglo, longitud + 1);
            arreglo[longitud] = dato;
            Array.Resize<Button>(ref arreglo_botones, longitud + 1);
            arreglo[longitud] = dato;
            arreglo_botones[longitud] = new Button();
            arreglo_botones[longitud].Width = 50;
            arreglo_botones[longitud].Height = 50;
            arreglo_botones[longitud].BackColor = Color.GreenYellow;
            arreglo_botones[longitud].Text = dato.ToString();
            calcular_Longitud();
        }
        public Button[] Arreglo_Botones()
        {
            return arreglo_botones;
        }
    }

}

