using Dominio.Enums;
using Infraestructura.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductoApp.Forms
{
    public partial class FrmProductoManage : Form
    {
        private ProductoModel producto;

        public FrmProductoManage()
        {
            //ProductoModel = new ProductoModel();
            InitializeComponent();
        }

        private void CmbFinder_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFinder.SelectedIndex)
            {
                case 0:
                    pnlID.Visible = true;
                    pnlUnidadMedida.Visible = false;
                    pnlPriceRange.Visible = false;
                    pnlVencimiento.Visible = false;
                    break;
                case 1:
                    pnlID.Visible = false;
                    pnlUnidadMedida.Visible = true;
                    pnlPriceRange.Visible = false;
                    pnlVencimiento.Visible = false;
                    break;
                case 2:
                    pnlID.Visible = false;
                    pnlUnidadMedida.Visible = false;
                    pnlPriceRange.Visible = true;
                    pnlVencimiento.Visible = false;
                    break;
                case 3:
                    pnlID.Visible = false;
                    pnlUnidadMedida.Visible = false;
                    pnlPriceRange.Visible = false;
                    pnlVencimiento.Visible = true;
                    break;
            }
        }

        private void DtpVencimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CmbUnidadMedida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmProductoManage_Load(object sender, EventArgs e)
        {
            cmbUnidadMedida.Items.AddRange(Enum.GetValues(typeof(UnidadMedida)).Cast<object>().ToArray());
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();

            frmProducto.ShowDialog();
        }
    }
}
