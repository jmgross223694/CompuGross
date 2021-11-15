﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompuGross
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes frmClientes = new Clientes();
            this.Hide();
            frmClientes.ShowDialog();
            this.Show();
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Se ha cerrado la sesión en curso.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Login frmLogin = new Login();
            this.Hide();
            frmLogin.ShowDialog();
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AgregarUsuario frmAgregarUsuario = new AgregarUsuario();
            this.Hide();
            frmAgregarUsuario.ShowDialog();
            this.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnPrecios_Click(object sender, EventArgs e)
        {
            ListaPrecios frmListadoPrecios = new ListaPrecios();
            this.Hide();
            frmListadoPrecios.ShowDialog();
            this.Show();
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            Ingresos frmIngresos = new Ingresos();
            this.Hide();
            frmIngresos.ShowDialog();
            this.Show();
        }

        private void btnOrdenesTrabajo_Click(object sender, EventArgs e)
        {
            OrdenesTrabajo frmOrdenesTrabajo = new OrdenesTrabajo();
            this.Hide();
            frmOrdenesTrabajo.ShowDialog();
            this.Show();
        }
    }
}
