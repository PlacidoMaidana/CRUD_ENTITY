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
    public partial class FichaAlumno : Form
    {
        public int? id;
        public FichaAlumno(int? id=null)
        {
            InitializeComponent();
            if (id!=null)
            {
              this.id = id;
              DataTable dt=  alumnosTableAdapter.tomoAlumno((int)this.id);
              alumnosBindingSource.DataSource = (DataRow)dt.Rows[0];

            }
        }

        

        private void FichaAlumno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'uNIVERSIDADDataSet.alumnos' Puede moverla o quitarla según sea necesario.
            //    this.alumnosTableAdapter.Fill(this.uNIVERSIDADDataSet.alumnos);

            idTextBox.ReadOnly = true;

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            if (id==null)
            {
                alumnosTableAdapter.NuevoAlumno(nombreTextBox.Text.Trim(), apellidoTextBox.Text.Trim(),
                direccionTextBox.Text.Trim(), fechaNacimientoDateTimePicker.Text,
                int.Parse(tituloSecundarioTextBox.Text)
             );
            }
            else
            {
                this.Validate();
                this.alumnosBindingSource.EndEdit();
                alumnosTableAdapter.modificarAlumno(nombreTextBox.Text.Trim(),apellidoTextBox.Text.Trim(),
                    direccionTextBox.Text.Trim(),fechaNacimientoDateTimePicker.Text,
                    int.Parse(tituloSecundarioTextBox.Text),int.Parse(idTextBox.Text));

            }

         
            this.Close();
        }
    }
}
