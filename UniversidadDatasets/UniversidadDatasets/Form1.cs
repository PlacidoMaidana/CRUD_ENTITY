using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversidadDatasets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void alumnosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

       

        private void Nuevo_Click(object sender, EventArgs e)
        {
            FichaAlumno fa = new FichaAlumno();
            fa.ShowDialog();
            refresh();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            int? id = getId();
            if (id!=null)
            {
                FichaAlumno fa = new FichaAlumno(id);
                fa.ShowDialog();
            }

            refresh();
            
        }


        #region Metodos utiles
        public int? getId()
        {
            int? id = int.Parse(alumnosDataGridView.CurrentRow.Cells[0].Value.ToString());
            return id;
        }

        public void refresh()
        {
            alumnosDataGridView.DataSource = null;
            alumnosBindingSource.DataSource = alumnosTableAdapter.tablaCompleta();
            alumnosDataGridView.DataSource = alumnosBindingSource.DataSource;
        }






        #endregion

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            int? id = getId();
            if (id!=null)
            {
                alumnosTableAdapter.borrarAlumno((int) id);
            }
            refresh();
        }
    }
}
