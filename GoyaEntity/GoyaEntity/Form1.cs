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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormularioFichaContacto ficha = new FormularioFichaContacto();
                ficha.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zoologicoEntities z = new zoologicoEntities();
            zoologicoBindingSource.DataSource = z.zoologico.ToList();
            zoologicoDataGridView.DataSource = zoologicoBindingSource.DataSource;
        }
    }
}
