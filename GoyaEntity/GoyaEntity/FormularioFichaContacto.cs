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
    public partial class FormularioFichaContacto : Form
    {
        public zoologicoEntities z { get; set; }
        zoologico zoo_var;
        bool insert = true;
        public FormularioFichaContacto(zoologico zoo_var=null)
        {
            InitializeComponent();
            if (zoo_var==null)
            {
                this.zoo_var = new zoologico();
                zoologicoBindingSource.DataSource = this.zoo_var;
            }
            else
            {
                this.zoo_var = zoo_var;
                zoologicoBindingSource.DataSource = this.zoo_var;
                insert = false;
            }

        }

        private void zoologicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          
           
        }

        private void FormularioFichaContacto_Load(object sender, EventArgs e)
        {
           
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            zoologicoBindingSource.EndEdit();
            if (insert)
            {
                z.zoologico.Add(zoo_var);
            }
            else
            {
               
                zoologico z2 = z.zoologico.FirstOrDefault(a=>a.id==zoo_var.id);
                z.Entry(z2).CurrentValues.SetValues(zoo_var);
            }
           
            z.SaveChanges();
            this.Close();
        }
    }
}
