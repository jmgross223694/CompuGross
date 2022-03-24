﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace CompuGross
{
    public partial class OrdenesTrabajo : Form
    {
        private List<Servicio> listaOrdenes;
        private List<Cliente> listaClientes;

        public OrdenesTrabajo()
        {
            InitializeComponent();
        }

        public OrdenesTrabajo(bool bandera)
        {
            InitializeComponent();
        }

        private void OrdenesTrabajo_Load(object sender, EventArgs e)
        {
            visibilidadCamposModificar("hide");
            listarTodas();

            cargarDdlTiposEquipo();
            cargarDdlTiposServicio();

            cargarListadoClientes();
            AlinearColumnasGrillaClientes();
            ordenarColumnasGrillaClientes();
            cambiarTitulosGrillaClientes();
        }

        private void cargarListado()
        {
            ServicioDB ordenTrabajoDB = new ServicioDB();

            try
            {
                listaOrdenes = ordenTrabajoDB.Listar();
                dgvOrdenesTrabajo.DataSource = listaOrdenes;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }

        private void alinearColumnas()
        {
            dgvOrdenesTrabajo.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["FechaRecepcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["FechaDevolucion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["TipoEquipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["TipoServicio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["CostoTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["Ganancia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void cambiarTitulos()
        {
            dgvOrdenesTrabajo.Columns["FechaRecepcion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvOrdenesTrabajo.Columns["FechaDevolucion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvOrdenesTrabajo.Columns["CostoTotal"].DefaultCellStyle.Format = "C0";
            dgvOrdenesTrabajo.Columns["Ganancia"].DefaultCellStyle.Format = "C0";

            dgvOrdenesTrabajo.Columns["ID"].HeaderText = "N° de orden";
            dgvOrdenesTrabajo.Columns["FechaRecepcion"].HeaderText = "Recepción";
            dgvOrdenesTrabajo.Columns["FechaDevolucion"].HeaderText = "Devolución";
            dgvOrdenesTrabajo.Columns["TipoServicio"].HeaderText = "Tipo";
            dgvOrdenesTrabajo.Columns["TipoEquipo"].HeaderText = "Equipo";
            dgvOrdenesTrabajo.Columns["MarcaModelo"].HeaderText = "Marca y modelo";
            dgvOrdenesTrabajo.Columns["CostoTotal"].HeaderText = "Subtotal";
        }

        private void alinearTitulos()
        {
            dgvOrdenesTrabajo.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["FechaRecepcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["FechaDevolucion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["Cliente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["TipoEquipo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["MarcaModelo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["TipoServicio"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["CostoTotal"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["Ganancia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ocultarColumnas()
        {
            dgvOrdenesTrabajo.Columns["RAM"].Visible = false;
            dgvOrdenesTrabajo.Columns["PlacaMadre"].Visible = false;
            dgvOrdenesTrabajo.Columns["Microprocesador"].Visible = false;
            dgvOrdenesTrabajo.Columns["Almacenamiento"].Visible = false;
            dgvOrdenesTrabajo.Columns["CdDvd"].Visible = false;
            dgvOrdenesTrabajo.Columns["Fuente"].Visible = false;
            dgvOrdenesTrabajo.Columns["Adicionales"].Visible = false;
            dgvOrdenesTrabajo.Columns["NumSerie"].Visible = false;
            dgvOrdenesTrabajo.Columns["Descripcion"].Visible = false;
            dgvOrdenesTrabajo.Columns["CostoRepuestos"].Visible = false;
            dgvOrdenesTrabajo.Columns["CostoTerceros"].Visible = false;
            dgvOrdenesTrabajo.Columns["CostoCG"].Visible = false;
            dgvOrdenesTrabajo.Columns["Estado"].Visible = false;
        }

        private void ordenarColumnas()
        {
            dgvOrdenesTrabajo.AllowUserToOrderColumns = true;

            dgvOrdenesTrabajo.Columns["ID"].DisplayIndex = 0;
            dgvOrdenesTrabajo.Columns["Cliente"].DisplayIndex = 1;
            dgvOrdenesTrabajo.Columns["FechaRecepcion"].DisplayIndex = 2;
            dgvOrdenesTrabajo.Columns["FechaDevolucion"].DisplayIndex = 3;
            dgvOrdenesTrabajo.Columns["TipoServicio"].DisplayIndex = 4;
            dgvOrdenesTrabajo.Columns["TipoEquipo"].DisplayIndex = 5;
            dgvOrdenesTrabajo.Columns["MarcaModelo"].DisplayIndex = 6;
            dgvOrdenesTrabajo.Columns["CostoTotal"].DisplayIndex = 7;
            dgvOrdenesTrabajo.Columns["Ganancia"].DisplayIndex = 8;
        }

        private void BuscarFiltro()
        {
            cargarListado();
            alinearTitulos();
            alinearColumnas();
            ocultarColumnas();
            ordenarColumnas();
            cambiarTitulos();

            List<Servicio> filtro;
            if (txtFiltro.Text != "")
            {
                filtro = listaOrdenes.FindAll(Art => Art.ID.ToString().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.Cliente.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.TipoEquipo.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.TipoServicio.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.MarcaModelo.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.Descripcion.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.FechaRecepcion.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.FechaDevolucion.ToUpper().Contains(txtFiltro.Text.ToUpper()));
                dgvOrdenesTrabajo.DataSource = null;
                dgvOrdenesTrabajo.DataSource = filtro;
            }
            else
            {
                dgvOrdenesTrabajo.DataSource = null;
                dgvOrdenesTrabajo.DataSource = listaOrdenes;
            }
            alinearTitulos();
            alinearColumnas();
            ocultarColumnas();
            ordenarColumnas();
            cambiarTitulos();
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtFiltro.Text != "" && e.KeyCode.Equals(Keys.Enter))
            {
                if (dgvOrdenesTrabajo.DataSource == null)
                {
                    cargarListado();
                    ocultarColumnas();
                    alinearColumnas();
                    ordenarColumnas();
                    cambiarTitulos();
                }

                BuscarFiltro();
            }
        }

        private void lblFiltro_Click(object sender, EventArgs e)
        {
             
        }

        private void listarTodas()
        {
            if (dgvOrdenesTrabajo.DataSource == null)
            {
                cargarListado();
                ocultarColumnas();
                alinearColumnas();
                ordenarColumnas();
                cambiarTitulos();
            }
            else if (txtFiltro.Text != "")
            {
                BuscarFiltro();
            }
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (dgvOrdenesTrabajo.DataSource == null)
                {
                    cargarListado();
                    ocultarColumnas();
                    alinearColumnas();
                    ordenarColumnas();
                    cambiarTitulos();
                }

                BuscarFiltro();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrdenesTrabajo.CurrentRow != null)
                {
                    txtFiltro.Text = "";
                    Servicio servicio = (Servicio)dgvOrdenesTrabajo.CurrentRow.DataBoundItem;

                    btnBuscarOrden.Visible = false;
                    txtFiltro.Visible = false;
                    dgvOrdenesTrabajo.Visible = false;
                    btnModificar.Visible = false;
                    lblNumOrden.Text = lblNumOrden.Text + servicio.ID;
                    visibilidadCamposModificar("show");
                    btnCambiarCliente.Visible = true;
                    txtCliente.Visible = true;

                    completarCamposOrden(servicio);
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ninguna orden.", "Atención!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {

            }
        }

        private void completarCamposOrden(Servicio servicio)
        {
            txtFiltro.Text = servicio.ID.ToString();
            txtCliente.Text = servicio.Cliente;
            fechaRecepcion.Text = servicio.FechaRecepcion;
            ddlTipoServicio.SelectedItem = servicio.TipoServicio;
            ddlTipoEquipo.SelectedItem = servicio.TipoEquipo;
            txtRam.Text = servicio.RAM;
            txtPlacaMadre.Text = servicio.PlacaMadre;
            txtMarcaModelo.Text = servicio.MarcaModelo;
            txtMicroprocesador.Text = servicio.Microprocesador;
            txtAlmacenamiento.Text = servicio.Almacenamiento;
            ddlUnidadOptica.SelectedItem = servicio.CdDvd;
            txtAlimentacion.Text = servicio.Fuente;
            txtAdicionales.Text = servicio.Adicionales;
            txtNumSerie.Text = servicio.NumSerie;
            txtCostoRepuestos.Text = servicio.CostoRepuestos.ToString();
            txtManoObra.Text = servicio.CostoCG.ToString();
            txtCostoTerceros.Text = servicio.CostoTerceros.ToString();
            fechaDevolucion.Text = servicio.FechaDevolucion;
            cbFechaDevolucion.Checked = false;
            if (servicio.FechaDevolucion != "")
            {
                cbFechaDevolucion.Checked = true;
            }
            txtDescripcion.Text = servicio.Descripcion;
        }

        private void cargarDdlTiposServicio()
        {
            string selectTiposServicio = "select Descripcion from TiposServicio where Estado = 1 order by ID asc";
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(selectTiposServicio);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    ddlTipoServicio.Items.Add(datos.Lector["Descripcion"].ToString());
                }
                ddlTipoServicio.SelectedItem = "-";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al leer la tabla TiposServicio en la base de datos.");
                this.Close();
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        private void cargarDdlTiposEquipo()
        {
            string selectTiposEquipo = "select Descripcion from TiposEquipo where Estado = 1 order by Descripcion asc";
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(selectTiposEquipo);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    ddlTipoEquipo.Items.Add(datos.Lector["Descripcion"].ToString());
                }
                ddlTipoEquipo.SelectedItem = "-";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al leer la tabla TiposEquipo en la base de datos.");
                this.Close();
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicio seleccionado = (Servicio)dgvOrdenesTrabajo.CurrentRow.DataBoundItem;
            ServicioDB ordentTrabajoDB = new ServicioDB();

            try
            {
                if (MessageBox.Show("¿Está seguro de eliminar la Orden N° " + seleccionado.ID + " del cliente " +
                                    seleccionado.Cliente + "?", "Atención!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ordentTrabajoDB.EliminarOrden(seleccionado.ID);
                    MessageBox.Show("La Orden N° " + seleccionado.ID + ", del cliente " + seleccionado.Cliente +
                                    ", se ha eliminado correctamente");
                }
            }
            catch
            {

            }
        }

        private void visibilidadCamposModificar(string aux)
        {
            if (aux == "show")
            {
                lblNumOrden.Visible = true;
                btnCancelar.Visible = true;
                lblFechaRecepcion.Visible = true;
                lblFechaDevolucion.Visible = true;
                cbFechaDevolucion.Visible = true;
                lblTipoServicio.Visible = true;
                lblTipoEquipo.Visible = true;
                lblMarcaModelo.Visible = true;
                lblRam.Visible = true;
                lblMicroprocesador.Visible = true;
                lblAlmacenamiento.Visible = true;
                lblPlacaMadre.Visible = true;
                lblNumSerie.Visible = true;
                lblAdicionales.Visible = true;
                lblAlimentacion.Visible = true;
                lblUnidadOptica.Visible = true;
                lblCostoRepuestos.Visible = true;
                lblManoObra.Visible = true;
                lblCostoTerceros.Visible = true;
                fechaRecepcion.Visible = true;
                fechaDevolucion.Visible = true;
                ddlTipoServicio.Visible = true;
                ddlTipoEquipo.Visible = true;
                txtMarcaModelo.Visible = true;
                txtRam.Visible = true;
                txtMicroprocesador.Visible = true;
                txtAlmacenamiento.Visible = true;
                txtPlacaMadre.Visible = true;
                txtNumSerie.Visible = true;
                txtAdicionales.Visible = true;
                txtAlimentacion.Visible = true;
                ddlUnidadOptica.Visible = true;
                txtCostoRepuestos.Visible = true;
                txtManoObra.Visible = true;
                txtCostoTerceros.Visible = true;
                lblDescripcion.Visible = true;
                txtDescripcion.Visible = true;
                lblAsteriscoTipoServicio.Visible = true;
                lblAsteriscoTipoEquipo.Visible = true;
                lblAsteriscoMarcaModelo.Visible = true;
                lblAsteriscoManoObra.Visible = true;
                lblAsteriscoDescripcion.Visible = true;
                lblCamposObligatorios.Visible = true;
                btnConfirmar.Visible = true;
            }
            if (aux == "hide")
            {
                lblNumOrden.Visible = false;
                btnCancelar.Visible = false;
                lblFechaRecepcion.Visible = false;
                lblFechaDevolucion.Visible = false;
                cbFechaDevolucion.Visible = false;
                lblTipoServicio.Visible = false;
                lblTipoEquipo.Visible = false;
                lblMarcaModelo.Visible = false;
                lblRam.Visible = false;
                lblMicroprocesador.Visible = false;
                lblAlmacenamiento.Visible = false;
                lblPlacaMadre.Visible = false;
                lblNumSerie.Visible = false;
                lblAdicionales.Visible = false;
                lblAlimentacion.Visible = false;
                lblUnidadOptica.Visible = false;
                lblCostoRepuestos.Visible = false;
                lblManoObra.Visible = false;
                lblCostoTerceros.Visible = false;
                fechaRecepcion.Visible = false;
                fechaDevolucion.Visible = false;
                ddlTipoServicio.Visible = false;
                ddlTipoEquipo.Visible = false;
                txtMarcaModelo.Visible = false;
                txtRam.Visible = false;
                txtMicroprocesador.Visible = false;
                txtAlmacenamiento.Visible = false;
                txtPlacaMadre.Visible = false;
                txtNumSerie.Visible = false;
                txtAdicionales.Visible = false;
                txtAlimentacion.Visible = false;
                ddlUnidadOptica.Visible = false;
                txtCostoRepuestos.Visible = false;
                txtManoObra.Visible = false;
                txtCostoTerceros.Visible = false;
                lblDescripcion.Visible = false;
                txtDescripcion.Visible = false;
                lblAsteriscoTipoServicio.Visible = false;
                lblAsteriscoTipoEquipo.Visible = false;
                lblAsteriscoMarcaModelo.Visible = false;
                lblAsteriscoManoObra.Visible = false;
                lblAsteriscoDescripcion.Visible = false;
                lblCamposObligatorios.Visible = false;
                btnConfirmar.Visible = false;
            }
        }

        private void btnCambiarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Visible == false)
            {
                visibilidadCamposModificar("hide");
                btnCambiarCliente.Visible = true;
                txtCliente.Visible = true;
                dgvClientes.Visible = true;

                ocultarColumnasClientes();
            }
            else
            {
                Cliente cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

                visibilidadCamposModificar("show");
                dgvClientes.Visible = false;

                txtCliente.Text = cliente.Nombres;

                dgvClientes.Visible = false;
            }
        }

        private void cargarListadoClientes()
        {
            ClienteDB clienteDB = new ClienteDB();

            try
            {
                listaClientes = clienteDB.Listar();
                dgvClientes.DataSource = listaClientes;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }

        private void ocultarColumnasClientes()
        {
            dgvClientes.Columns["Direccion"].Visible = false;
            dgvClientes.Columns["Localidad"].Visible = false;
            dgvClientes.Columns["IdLocalidad"].Visible = false;
            dgvClientes.Columns["Mail"].Visible = false;
        }

        private void cambiarTitulosGrillaClientes()
        {
            dgvClientes.Columns["Id"].HeaderText = "N° cliente";
            dgvClientes.Columns["Nombres"].HeaderText = "Cliente";
            dgvClientes.Columns["Telefono"].HeaderText = "Teléfono";
        }

        private void ordenarColumnasGrillaClientes()
        {
            dgvClientes.AllowUserToOrderColumns = true;

            dgvClientes.Columns["Id"].DisplayIndex = 0;
            dgvClientes.Columns["Nombres"].DisplayIndex = 1;
            dgvClientes.Columns["Telefono"].DisplayIndex = 2;
            dgvClientes.Columns["DNI"].DisplayIndex = 3;
        }

        private void AlinearColumnasGrillaClientes()
        {
            dgvClientes.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["DNI"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvClientes.Columns["Id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["Nombres"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["Telefono"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["DNI"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

            visibilidadCamposModificar("show");

            txtCliente.Text = cliente.Nombres;

            dgvClientes.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cancelar la edición?", "Atención!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtFiltro.Text = "";
                btnCambiarCliente.Visible = false;
                txtCliente.Visible = false;
                borrarCamposOrden();
                visibilidadCamposModificar("hide");
                btnModificar.Visible = true;
                btnBuscarOrden.Visible = true;
                txtFiltro.Visible = true;
                cargarListado();
                ocultarColumnas();
                alinearColumnas();
                ordenarColumnas();
                cambiarTitulos();
                dgvOrdenesTrabajo.Visible = true;

                /*MessageBox.Show("No se modificó el servicio.", "Atención!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            }
        }

        private void borrarCamposOrden()
        {
            txtCliente.Text = "";
            fechaRecepcion.Text = default;
            ddlTipoServicio.SelectedItem = "-";
            ddlTipoEquipo.SelectedItem = "-";
            txtRam.Text = "";
            txtPlacaMadre.Text = "";
            txtMarcaModelo.Text = "";
            txtMicroprocesador.Text = "";
            txtAlmacenamiento.Text = "";
            ddlUnidadOptica.SelectedItem = "-";
            txtAlimentacion.Text = "";
            txtAdicionales.Text = "";
            txtNumSerie.Text = "";
            txtCostoRepuestos.Text = "";
            txtManoObra.Text = "";
            txtCostoTerceros.Text = "";
            fechaDevolucion.Text = default;
            txtDescripcion.Text = "";
        }

        private void cbFechaDevolucion_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFechaDevolucion.Checked == true)
            {
                fechaDevolucion.Enabled = true;
                lblFechaDevolucion.ForeColor = Color.White;
            }
            else
            {
                fechaDevolucion.Enabled = false;
                lblFechaDevolucion.ForeColor = Color.FromArgb(26, 26, 29);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ServicioDB ordenDb = new ServicioDB();
            Servicio orden = new Servicio();

            orden.ID = Convert.ToInt64(txtFiltro.Text);

            orden.Cliente = txtCliente.Text;
            orden.FechaRecepcion = fechaRecepcion.Text;
            orden.TipoEquipo = ddlTipoEquipo.SelectedItem.ToString();

            if (txtRam.Text == "") { orden.RAM = "-"; }
            else { orden.RAM = txtRam.Text + " GB"; }

            if (txtPlacaMadre.Text == "") { orden.PlacaMadre = "-"; }
            else { orden.PlacaMadre = txtPlacaMadre.Text; }

            if (txtMicroprocesador.Text == "") { orden.Microprocesador = "-"; }
            else { orden.Microprocesador = txtMicroprocesador.Text; }

            if (txtAlmacenamiento.Text == "") { orden.Almacenamiento = "-"; }
            else { orden.Almacenamiento = txtAlmacenamiento.Text; }

            orden.CdDvd = ddlUnidadOptica.SelectedItem.ToString();

            if (txtAlimentacion.Text == "") { orden.Fuente = "-"; }
            else { orden.Fuente = txtAlimentacion.Text; }

            if (txtAdicionales.Text == "") { orden.Adicionales = "-"; }
            else { orden.Adicionales = txtAdicionales.Text; }

            if (txtNumSerie.Text == "") { orden.NumSerie = "-"; }
            else { orden.NumSerie = txtNumSerie.Text; }

            if (txtCostoRepuestos.Text == "") { orden.CostoRepuestos = 0; }
            else { orden.CostoRepuestos = Convert.ToInt32(txtCostoRepuestos.Text); }

            if (txtCostoTerceros.Text == "") { orden.CostoTerceros = 0; }
            else { orden.CostoTerceros = Convert.ToInt32(txtCostoTerceros.Text); }

            if (fechaDevolucion.Enabled == false) { orden.FechaDevolucion = ""; }
            else { orden.FechaDevolucion = fechaDevolucion.Text; }

            orden.MarcaModelo = txtMarcaModelo.Text;
            orden.TipoServicio = ddlTipoServicio.SelectedItem.ToString();
            orden.Descripcion = txtDescripcion.Text;
            orden.CostoCG = Convert.ToInt32(txtManoObra.Text);

            try
            {
                ordenDb.ModificarOrden(orden);

                MessageBox.Show("Se guardaron los cambios en la Orden de trabajo N°" + orden.ID + ".");

                txtFiltro.Text = "";
                btnCambiarCliente.Visible = false;
                txtCliente.Visible = false;
                borrarCamposOrden();
                visibilidadCamposModificar("hide");
                btnModificar.Visible = true;
                btnBuscarOrden.Visible = true;
                txtFiltro.Visible = true;
                cargarListado();
                ocultarColumnas();
                alinearColumnas();
                ordenarColumnas();
                cambiarTitulos();
                dgvOrdenesTrabajo.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error y no se modificó la orden de trabajo.");
            }
        }
    }
}
