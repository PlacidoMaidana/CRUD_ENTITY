namespace GoyaEntity
{
    partial class FormularioFichaContacto
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
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label tipoLabel;
            this.fotoTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.zoologicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            fotoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zoologicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(34, 89);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(36, 17);
            fotoLabel.TabIndex = 1;
            fotoLabel.Text = "foto:";
            // 
            // fotoTextBox
            // 
            this.fotoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zoologicoBindingSource, "foto", true));
            this.fotoTextBox.Location = new System.Drawing.Point(100, 86);
            this.fotoTextBox.Name = "fotoTextBox";
            this.fotoTextBox.Size = new System.Drawing.Size(385, 22);
            this.fotoTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(34, 117);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 3;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zoologicoBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(100, 114);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(385, 22);
            this.idTextBox.TabIndex = 4;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(34, 145);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 17);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zoologicoBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(100, 142);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(385, 22);
            this.nombreTextBox.TabIndex = 6;
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(34, 173);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(35, 17);
            tipoLabel.TabIndex = 7;
            tipoLabel.Text = "tipo:";
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zoologicoBindingSource, "tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(100, 170);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(385, 22);
            this.tipoTextBox.TabIndex = 8;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(423, 273);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 9;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // zoologicoBindingSource
            // 
            this.zoologicoBindingSource.DataSource = typeof(GoyaEntity.Datos.zoologico);
            // 
            // FormularioFichaContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 349);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.fotoTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Name = "FormularioFichaContacto";
            this.Text = "FormularioFichaContacto";
            this.Load += new System.EventHandler(this.FormularioFichaContacto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zoologicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource zoologicoBindingSource;
        private System.Windows.Forms.TextBox fotoTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.Button Aceptar;
    }
}