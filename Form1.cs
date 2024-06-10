using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PROYECTOS_FINAL_DE_CALCULADORA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void estanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cal_Cientifica.Visible = false;
            Cal_Estandar.Visible = true;
            Cal_Programador.Visible = false;
            Size = new Size(294, 410);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cal_Cientifica_Paint(object sender, PaintEventArgs e)
        {

        }

        private void científicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cal_Estandar.Visible = false;
            Cal_Cientifica.Visible = true;
            Cal_Programador.Visible = false;
            panel5.Visible = false;
            Size = new Size(578, 410);
        }

        private void programadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cal_Estandar.Visible = false;
            Cal_Cientifica.Visible = false;
            Cal_Programador.Visible = true;
            panel5.Visible = false;
            Size = new Size(578, 410);
        }

        private void Cal_Programador_Paint(object sender, PaintEventArgs e)
        {

        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            if (A.Enabled == false || pro8.Enabled == true)
            {
                A.Enabled = true;
                B.Enabled = true;
                C.Enabled = true;
                D.Enabled = true;
                E.Enabled = true;
                F.Enabled = true;
                pro9.Enabled = true;
                pro8.Enabled = true;
                pro7.Enabled = true;
                pro6.Enabled = true;
                pro5.Enabled = true;
                pro4.Enabled = true;
                pro3.Enabled = true;
                pro2.Enabled = true;
            }
        }
        //Dec
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            E.Enabled = false;
            F.Enabled = false;
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            radioButton5_CheckedChanged(sender,e);
            pro8.Enabled = false;
            pro9.Enabled = false;
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            radioButton7_CheckedChanged(sender, e);
            pro7.Enabled = false;
            pro6.Enabled = false;
            pro5.Enabled = false;
            pro4.Enabled = false;
            pro3.Enabled = false;
            pro2.Enabled = false;
        }


        private void A_Click(object sender, EventArgs e)
        {

        }

        private void conversionDeUnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cal_Estandar.Visible = true;
            Cal_Cientifica.Visible = false;
            Cal_Programador.Visible = false;
            panel5.Visible = true;
            Size = new Size(294, 410);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String unidad = comboBox1.SelectedItem.ToString();

            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            string[] unidades = new string[] { };

            switch (unidad)
            {
                case "Ángulo":
                    unidades = new string[] { "Grados", "Radianes", "Grados centesimales"};
                    break;

                case "Área":
                    unidades = new string[] { "Milímetros cuadrados", "Centímetros cuadrados", "Metros cuadrados"
                        , "Hectáreas", "Kilómetros cuadrados", "Pulgadas cuadradas", "Pies cuadrados"
                        , "Yardas cuadradas", "Acres", "Millas cuadradas" };
                    break;
                case "Energía":
                    unidades = new string[] { "Electronvoltio", "Joules", "Kilojulios"
                        , "Calorias termales", "Calorías de alimentos", "Pie-libras", "Unidades termicas británicas"
                        , "Kilobyte-horas"};
                    break;
                case "Longitud":
                    unidades = new string[] { "Nanómetros", "Micrones", "Milímetros", "Centímetros"
                        , "Kilómetros", "Pulgadas", "Pies", "Yardas", "Millas", "Millas naúticas"};
                    break;
                case "Masa":
                    unidades = new string[] { "Quitales", "Miligramos", "Centigramos", "Decigramos", "Gramos"
                        , "Decagramos", "Hectogramos", "Kilogramos", "Toneladas métricas", "Onzas", "Libras"
                        , "Piedra", "Toneladas cortas (EE.UU.)"};
                    break;
                case "Potencia":
                    unidades = new string[] { "Vatios", "Kilovatios", "Caballos de fuerza (EE.UU.)", "Pie-libras/minuto"
                        , "Unidades Térmicas británicas/minuto"};
                    break;
                case "Presión":
                    unidades = new string[] { "Atmósferas", "Bares", "Kilospascales", "Milímetros de mercurio"
                        , "Pascales", "Libras por pulgada cuadrada (PSI)"};
                    break;
                case "Temperatura":
                    unidades = new string[] { "Celsius", "Fahrenheit", "Kelvin" };
                    break;
                case "Tiempo":
                    unidades = new string[] { "Microsegundos", "Milisegundos", "Segundos", "Minutos"
                        , "Horas", "Días", "Semanas", "Años" };
                    break;
                case "Velocidad":
                    unidades = new string[] { "Centímetros por segundo", "Metros por segundo", "Kilómetros por hora"
                        , "Pies por segundo", "Millas por hora", "Nudos", "Mach"};
                    break;
                case "Volúmen":
                    unidades = new string[] { "Mililitros", "Centímetros cúbicos", "Litros", "Metros cúbicos", "Cucharaditas (EE.UU.)"
                        , "Cucharadas (EE.UU.)", "Onzas líquidas (EE.UU.)", "Tazas (EE.UU.)", "Pintas(EE.UU.)"
                        , "Cuartos de galón (EE.UU.)", "Galones (EE.UU.)", "Pulgadas cúbicas", "Pies cúbicas"
                        , "Yardas cúbicas", "Cucharaditas (Reino unido)", "Onzas Líquidas (Reino unido)", "Pintas (Reino unido)"
                        , "Cuartos de galón (Reino unido)", "Galones (Reino unido)"};
                    break;
            }
            foreach(var item in unidades){
                comboBox2.Items.Add(item);
                comboBox3.Items.Add(item);
            }
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        // funnciones para calculadora estandar +*- 
        #region
        string operador = "";
        double primero;
        double segundo;
        double res;
        private void est_screen_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn0_Click(object sender, EventArgs e)
        {
            est_screen.Text = est_screen.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            est_screen.Text = est_screen.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            est_screen.Text = est_screen.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            est_screen.Text = est_screen.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            est_screen.Text = est_screen.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            est_screen.Text = est_screen.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            est_screen.Text = est_screen.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            est_screen.Text = est_screen.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            est_screen.Text = est_screen.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            est_screen.Text = est_screen.Text + "9";
        }
        // suma
        private void button47_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(est_screen.Text);
            est_screen.Clear();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(est_screen.Text);
            est_screen.Clear();
        }

        private void multi_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(est_screen.Text);
            est_screen.Clear();
        }
        // raiz cuadrada me da fallo

        private void button42_Click(object sender, EventArgs e)
        {
            // esta mal
            operador = "raiz";
            primero = double.Parse(est_screen.Text);
            est_screen.Clear();
        }
        private void resultado_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(est_screen.Text);
  
            switch (operador)
            {
                case "+":
                    res = primero + segundo;
                    est_screen.Text = res.ToString();
                    break;
                case "-":
                    res = primero - segundo;
                    est_screen.Text = res.ToString();
                    break;
                case "*":
                    res = primero * segundo;
                    est_screen.Text = res.ToString();
                    break;
                    /*
                case "raiz":
                    res = Math.Sqrt(primero);
                    est_screen.Text = res.ToString();
                    break;*/
            }
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            est_screen.Clear();
        }
        #endregion
    }
}
