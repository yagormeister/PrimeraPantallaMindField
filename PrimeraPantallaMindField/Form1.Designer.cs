
namespace PrimeraPantallaMindField
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.dgPacientes = new System.Windows.Forms.DataGridView();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSesiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDiagnosticos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.Image = ((System.Drawing.Image)(resources.GetObject("lbTitulo.Image")));
            this.lbTitulo.Location = new System.Drawing.Point(22, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(1297, 193);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "MindField VR";
            // 
            // dgPacientes
            // 
            this.dgPacientes.AllowUserToOrderColumns = true;
            this.dgPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNombre,
            this.cSIP,
            this.cSesiones,
            this.cPrecio,
            this.cDiagnosticos,
            this.cTratamiento});
            this.dgPacientes.Location = new System.Drawing.Point(281, 173);
            this.dgPacientes.Name = "dgPacientes";
            this.dgPacientes.RowTemplate.Height = 25;
            this.dgPacientes.Size = new System.Drawing.Size(644, 370);
            this.dgPacientes.TabIndex = 1;
            this.dgPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPacientes_CellContentClick);
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "Nombre Paciente";
            this.cNombre.Name = "cNombre";
            // 
            // cSIP
            // 
            this.cSIP.HeaderText = "SIP";
            this.cSIP.Name = "cSIP";
            // 
            // cSesiones
            // 
            this.cSesiones.HeaderText = "Numero De Sesiones";
            this.cSesiones.Name = "cSesiones";
            // 
            // cPrecio
            // 
            this.cPrecio.HeaderText = "Precio/Sesion";
            this.cPrecio.Name = "cPrecio";
            // 
            // cDiagnosticos
            // 
            this.cDiagnosticos.HeaderText = "Diagnósticos";
            this.cDiagnosticos.Name = "cDiagnosticos";
            // 
            // cTratamiento
            // 
            this.cTratamiento.HeaderText = "Tratamientos";
            this.cTratamiento.Name = "cTratamiento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 639);
            this.Controls.Add(this.dgPacientes);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.DataGridView dgPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSesiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDiagnosticos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTratamiento;
    }
}

