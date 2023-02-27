using BLL.Services;
using DOMAIN;
using DOMAIN.Productos;
using SL.Services.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Lisener;

namespace UI
{
    public partial class FmrPagoProveedor : Form, IProveedorSeleccionadoLisener, IMateriaPrimaSeleccionadoLisener
    {
        Proveedor proveedor = new Proveedor();
        MateriaPrima materiaPrima = new MateriaPrima();
        Pago_Proveedor pago_proveedorGetMontoAdeudado = new Pago_Proveedor();
        Pago_Proveedor pago_Proveedor = new Pago_Proveedor();
        public FmrPagoProveedor()
        {
            InitializeComponent();
        }

        public void MateriaPrimaSeleccionada(MateriaPrima materiaPrima)
        {
            //Obteniendo Materia Prima seleccionada
            this.materiaPrima = MateriaPrimaService.Current.GetOneCode(materiaPrima.Codigo);
            TxtMateriaPrima.Text = materiaPrima.Nombre;
        }

        public void ProveedorSeleccionado(Proveedor proveedor)
        {
            //Obteninedo Porveedor seleccionado
            this.proveedor = ProveedorService.Current.GetOneDni((int)proveedor.Cuit);
            TxtProveedor.Text = proveedor.Nombre;
            //Obtener montodo adeudado
            pago_proveedorGetMontoAdeudado = Pago_proveedorService.Current.GetMontoAdeudado(proveedor);
            TxtDeudaAnterior.Text = (pago_proveedorGetMontoAdeudado.Monto_adeudado).ToString();            
        }

        private void BtnSeleccionarProveedor_Click(object sender, EventArgs e)
        {
            //Mostrando listado de Proveedores
            FmrListarProveedor F = new FmrListarProveedor(this);
            F.Show();
        }

        private void BtnSeleccionarMateriaPrima_Click(object sender, EventArgs e)
        {
            //Mostrando listado de Materias Primas
            FmrListarMateriaPrima F = new FmrListarMateriaPrima(this);
            F.Show();
        }

        private void BtnAgregarMateriaPrima_Click(object sender, EventArgs e)
        {
            try
            {
                if(materiaPrima.IdMateriaPrima == null)
                {
                    MessageBox.Show("Debe seleccionar una materia prima".Traducir());
                }
                else
                {
                    //Agregando Orden de compra
                    pago_Proveedor.Add(new Orden_de_Compra
                    {
                        materiaPrima = this.materiaPrima,
                        Cantidad = decimal.Parse(TxtCantidad.Text),
                        Subtotal = decimal.Parse(TxtCostoMateriaPrima.Text) * materiaPrima.Cantidad
                    });
                    DtgMateriaPrima.Rows.Add(materiaPrima.Codigo, materiaPrima.Nombre, materiaPrima.Cantidad, materiaPrima.unidad_de_medida.Unidad_de_medida, materiaPrima.Costo);
                    TxtCantidad.Text = "";
                    TxtCostoMateriaPrima.Text = "";
                    TxtMateriaPrima.Text = "";
                    //Calculo de Subtotal
                    decimal subtotal = 0;
                    foreach (var item in pago_Proveedor.Orden_De_Compras)
                    {
                        subtotal = item.Subtotal + subtotal;
                    }
                    TxtSubtotal.Text = subtotal.ToString();
                    //Calculo de Total
                    TxtTotalApagar.Text = (decimal.Parse(TxtSubtotal.Text) + decimal.Parse(TxtDeudaAnterior.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
                MessageBox.Show(ex.ToString());
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void BtnRealizarPago_Click(object sender, EventArgs e)
        {
            try
            {
                if(proveedor.Cuit == null)
                {
                    MessageBox.Show("Debe seleccionar un proveedor".Traducir());
                }
                else
                {
                    if (pago_Proveedor.Orden_De_Compras.Count == 0)
                    {
                        MessageBox.Show("Debe contener una orden de venta".Traducir());
                    }
                    else
                    {
                        //Ingresando Pago de Proveedor
                        pago_Proveedor.proveedor = this.proveedor;
                        pago_Proveedor.Monto_pagado = decimal.Parse(TxtPagado.Text);
                        pago_Proveedor.Total = decimal.Parse(TxtTotalApagar.Text);
                        pago_Proveedor.Fecha_Pago = DateTime.Now;   
                        pago_Proveedor.Monto_adeudado = pago_Proveedor.Total - pago_Proveedor.Monto_pagado;
                        Pago_proveedorService.Current.insert(pago_Proveedor);
                        TxtCantidad.Text = "";
                        TxtCostoMateriaPrima.Text = "";
                        TxtDeudaAnterior.Text = "";
                        TxtMateriaPrima.Text = "";
                        TxtPagado.Text = "";
                        TxtProveedor.Text = "";
                        TxtSubtotal.Text = "";
                        TxtTotalApagar.Text = "";
                        DtgMateriaPrima.Rows.Clear();
                        MessageBox.Show($"Pago de proveedor realizado".Traducir());
                    }
                }
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
                MessageBox.Show(ex.ToString());
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void FmrPagoProveedor_Load(object sender, EventArgs e)
        {
            SL.Services.Helper.Current.GetHelper("410", helpProvider1, this);
            TraducirForm();
        }

        private void BtnRemoverDeOrdenDeCompra_Click(object sender, EventArgs e)
        {
            try
            {
                //Remover Materia de la lista de orden de compra
                int i = DtgMateriaPrima.CurrentRow.Index;
                MateriaPrima materiaPrima = new MateriaPrima();
                materiaPrima.Codigo = DtgMateriaPrima[0, i].Value.ToString();
                for (int c = 0; c <= pago_Proveedor.Orden_De_Compras.Count - 1; c++)
                {
                    if (materiaPrima.Codigo == pago_Proveedor.Orden_De_Compras[c].materiaPrima.Codigo)
                    {
                        this.pago_Proveedor.Remove(pago_Proveedor.Orden_De_Compras[c]);
                        DtgMateriaPrima.Rows.RemoveAt(i);
                    }
                }
                //Calculo de Subtotal
                decimal value = 0;
                foreach (var item in pago_Proveedor.Orden_De_Compras)
                {
                    value = item.Subtotal + value;
                }
                TxtSubtotal.Text = value.ToString();
                //Calculo de Total
                TxtTotalApagar.Text = (decimal.Parse(TxtSubtotal.Text) + decimal.Parse(TxtDeudaAnterior.Text)).ToString();
            }
            catch (Exception ex)
            {
                SL.Services.ExceptionManager.Current.Handle(this, ex);
                MessageBox.Show(ex.ToString());
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }
        private void TraducirForm()
        {
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            label3.Text = label3.Text.Traducir();
            label4.Text = label4.Text.Traducir();
            label5.Text = label5.Text.Traducir();
            label6.Text = label6.Text.Traducir();
            BtnAgregarMateriaPrima.Text = BtnAgregarMateriaPrima.Text.Traducir();
            BtnRealizarPago.Text = BtnRealizarPago.Text.Traducir();
            BtnRemoverDeOrdenDeCompra.Text = BtnRemoverDeOrdenDeCompra.Text.Traducir();
            BtnSeleccionarMateriaPrima.Text = BtnSeleccionarMateriaPrima.Text.Traducir();
            BtnSeleccionarProveedor.Text = BtnSeleccionarProveedor.Text.Traducir();
        }
    }
}
