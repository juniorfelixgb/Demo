using Demo.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class frm_ramo : Form
    {
        ControllerRamoTipo ControllerRamoTipo;
        ControllerRamo ControllerRamo;
        public frm_ramo()
        {
            InitializeComponent();
            ControllerRamoTipo = new ControllerRamoTipo();
            ControllerRamo = new ControllerRamo();
            Lista();
        }

        private void frm_ramo_Load(object sender, EventArgs e)
        {
            cmbTipo.DataSource = ControllerRamoTipo.Get();
            cmbTipo.DisplayMember = "nombre";
            cmbTipo.ValueMember = "valor";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != string.Empty && cmbTipo.Text != string.Empty)
            {
                string rpt = ControllerRamo.Insert(txtNombre.Text, Convert.ToInt32(cmbTipo.SelectedValue));
                if (rpt == "ok")
                {
                    MessageBox.Show(rpt + " Registro insertado");
                    txtNombre.Text = string.Empty;
                    cmbTipo.Text = string.Empty;
                    Lista();
                }
                else
                {
                    MessageBox.Show(rpt);
                }
            }
        }

        private void Lista()
        {
            ControllerRamo.Lista(dataGridView1);
        }
    }
}
