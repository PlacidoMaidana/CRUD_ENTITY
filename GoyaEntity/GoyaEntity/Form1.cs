using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoyaEntity.Datos;

namespace GoyaEntity
{
    public partial class Form1 : Form
    {
        public zoologicoEntities z = new zoologicoEntities();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh()
        {

           
            zoologicoBindingSource.DataSource = z.zoologico.ToList();
            zoologicoDataGridView.DataSource = zoologicoBindingSource.DataSource;
        }

        private void zoologicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            FormularioFichaContacto ficha = new FormularioFichaContacto();
            ficha.z = this.z;
            ficha.ShowDialog();
            refresh();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            int id = idSeleccionado();
            zoologico ob =(zoologico) z.zoologico.FirstOrDefault(q=>q.id==id) ; 
            FormularioFichaContacto ficha = new FormularioFichaContacto(ob);
            ficha.z = this.z;            
            ficha.ShowDialog();
            refresh();
        }
        public int idSeleccionado()
        {
            return int.Parse(zoologicoDataGridView.CurrentRow.Cells[0].Value.ToString());
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            int id = idSeleccionado();
            zoologico ob = (zoologico)z.zoologico.FirstOrDefault(q => q.id == id);
            z.zoologico.Remove(ob);
            z.SaveChanges();
            refresh();

        }
    }
}
