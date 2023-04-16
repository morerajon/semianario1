using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int boton;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEjer1_2_Click(object sender, EventArgs e)
        {
            boton = 1;
            seleccionEjercicio(boton);

        }

        public void seleccionEjercicio(int boton)
        {
            switch (boton)
            {
                case 1:
                    btninvisible.Hide();
                    btnvisible.Hide();
                    btnDespedida.Hide();
                    btnABC.Show();
                    btnNo.Show();
                    btnSi.Show();
                    break;

                case 2:
                    btninvisible.Hide();
                    btnvisible.Hide();
                    btnDespedida.Show();
                    btnABC.Hide();
                    btnNo.Hide();
                    btnSi.Hide();
                    break;
                case 3:
                    btninvisible.Show();
                    btnvisible.Show();
                    btnDespedida.Hide();
                    btnABC.Hide();
                    btnNo.Hide();
                    btnSi.Hide();
                    break;
            }
        }

        private void btnEjercicio1_3_Click(object sender, EventArgs e)
        {
            boton = 2;
            seleccionEjercicio(boton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boton = 3;
            seleccionEjercicio(boton);
        }

        private void btnDespedida_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adios mundo");
        }

        private void btnvisible_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }

        private void btninvisible_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            label1.Text = "Si";
            label2.Text = "Si";
            label3.Text = "Si";
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            label1.Text = "No";
            label2.Text = "No";
            label3.Text = "No"; 
        }

        private void btnABC_Click(object sender, EventArgs e)
        {
            label1.Text = "A";
            label2.Text = "B";
            label3.Text = "C";
        }



    }
}
