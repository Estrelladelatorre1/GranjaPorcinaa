using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GranjaPorcinaa.Data;
using GranjaPorcinaa.Models;

namespace GranjaPorcinaa
{
    public partial class ForVentas : Form
    {
        private int id = 0;
        public ForVentas()
        {
            InitializeComponent();
        }
        private void butModificar_Click(object sender, EventArgs e)

        {
            using (var contex = new AplicationDBContext())
            {
                if (id != 0)
                {
                    var venta = contex.Ventas.First(x => x.Id == id);
                    if (venta != null)
                    {
                        venta.Idcer = Convert.ToInt32(texIdCer.Text);
                        venta.NomComp = texNomCom.Text;
                        venta.Presio = Convert.ToInt32(texPresio.Text);
                        venta.DateVenta = dateVenta.Value.Date;
                        contex.SaveChanges();
                        ListaVentas();
                    }
                }
            }
        }


        private void ForVentas_Load(object sender, EventArgs e)
        {
            ListaVentas(); 
        }
        private void ListaVentas()
        {
            using (var Context = new AplicationDBContext())
            {
                var ventas = Context.Ventas.ToList();
                dgvventa.DataSource = ventas;
            }
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            using (var Context = new AplicationDBContext())
            {
                var venta = new Ventas();
                venta.Idcer = Convert.ToInt32(texIdCer.Text);
                venta.NomComp = texNomCom.Text;
                venta.Presio = Convert.ToInt32(texPresio.Text);
                venta.DateVenta = dateVenta.Value.Date;

                Context.Ventas.Add(venta);
                Context.SaveChanges();
                var ventas = Context.Ventas.ToList();
                dgvventa.DataSource = ventas;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id=Convert.ToInt32(dgvventa.Rows[e.RowIndex].Cells[0].Value);
            texIdCer.Text= dgvventa.CurrentRow.Cells[1].Value.ToString();
            texNomCom.Text = dgvventa.CurrentRow.Cells[2].Value.ToString();
            texPresio.Text= dgvventa.CurrentRow.Cells[3].Value.ToString();
            dateVenta.Value = Convert.ToDateTime(dgvventa.CurrentRow.Cells[4].Value.ToString());

        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            using (var contex = new AplicationDBContext())
            {
                var venta = contex.Ventas.First(x => x.Id == id);
                if (venta != null)
                {
                    contex.Ventas.Remove(venta);
                    contex.SaveChanges();
                    ListaVentas();
                }
            }
        }

        private void butLimpiar_Click(object sender, EventArgs e)
        {
            id = 0;
            texIdCer.Text = "";
            texNomCom.Text = "";
            texPresio.Text = "";
            dateVenta.Value = Convert.ToDateTime(DateTime.Now);
        }

        private void texId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
