
namespace UniversidadDatasets
{
    partial class FichaAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label tituloSecundarioLabel;
            this.uNIVERSIDADDataSet = new UniversidadDatasets.UNIVERSIDADDataSet();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosTableAdapter = new UniversidadDatasets.UNIVERSIDADDataSetTableAdapters.alumnosTableAdapter();
            this.tableAdapterManager = new UniversidadDatasets.UNIVERSIDADDataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tituloSecundarioTextBox = new System.Windows.Forms.TextBox();
            this.Salir = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            tituloSecundarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uNIVERSIDADDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uNIVERSIDADDataSet
            // 
            this.uNIVERSIDADDataSet.DataSetName = "UNIVERSIDADDataSet";
            this.uNIVERSIDADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "alumnos";
            this.alumnosBindingSource.DataSource = this.uNIVERSIDADDataSet;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alumnosTableAdapter = this.alumnosTableAdapter;
            this.tableAdapterManager.asistencia2TableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = UniversidadDatasets.UNIVERSIDADDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(26, 72);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(153, 69);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(459, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(26, 100);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 17);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(153, 97);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(459, 22);
            this.nombreTextBox.TabIndex = 4;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(26, 128);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(61, 17);
            apellidoLabel.TabIndex = 5;
            apellidoLabel.Text = "apellido:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(153, 125);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(459, 22);
            this.apellidoTextBox.TabIndex = 6;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(26, 156);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(69, 17);
            direccionLabel.TabIndex = 7;
            direccionLabel.Text = "direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(153, 153);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(459, 22);
            this.direccionTextBox.TabIndex = 8;
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(26, 185);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(121, 17);
            fechaNacimientoLabel.TabIndex = 9;
            fechaNacimientoLabel.Text = "fecha Nacimiento:";
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.alumnosBindingSource, "fechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(153, 181);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(459, 22);
            this.fechaNacimientoDateTimePicker.TabIndex = 10;
            // 
            // tituloSecundarioLabel
            // 
            tituloSecundarioLabel.AutoSize = true;
            tituloSecundarioLabel.Location = new System.Drawing.Point(26, 212);
            tituloSecundarioLabel.Name = "tituloSecundarioLabel";
            tituloSecundarioLabel.Size = new System.Drawing.Size(118, 17);
            tituloSecundarioLabel.TabIndex = 11;
            tituloSecundarioLabel.Text = "titulo Secundario:";
            // 
            // tituloSecundarioTextBox
            // 
            this.tituloSecundarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "tituloSecundario", true));
            this.tituloSecundarioTextBox.Location = new System.Drawing.Point(153, 209);
            this.tituloSecundarioTextBox.Name = "tituloSecundarioTextBox";
            this.tituloSecundarioTextBox.Size = new System.Drawing.Size(459, 22);
            this.tituloSecundarioTextBox.TabIndex = 12;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(537, 293);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 13;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // FichaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 366);
            this.Controls.Add(this.Salir);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(tituloSecundarioLabel);
            this.Controls.Add(this.tituloSecundarioTextBox);
            this.Name = "FichaAlumno";
            this.Text = "FichaAlumno";
            this.Load += new System.EventHandler(this.FichaAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uNIVERSIDADDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UNIVERSIDADDataSet uNIVERSIDADDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private UNIVERSIDADDataSetTableAdapters.alumnosTableAdapter alumnosTableAdapter;
        private UNIVERSIDADDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox tituloSecundarioTextBox;
        private System.Windows.Forms.Button Salir;
    }
}