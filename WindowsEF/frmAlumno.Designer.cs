namespace WindowsEF
{
    partial class frmAlumno
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
            this.gridAlumno = new System.Windows.Forms.DataGridView();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscarPorId = new System.Windows.Forms.Button();
            this.llbId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAlumno
            // 
            this.gridAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlumno.Location = new System.Drawing.Point(48, 217);
            this.gridAlumno.Name = "gridAlumno";
            this.gridAlumno.Size = new System.Drawing.Size(458, 169);
            this.gridAlumno.TabIndex = 0;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(586, 90);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(153, 31);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(586, 139);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(153, 31);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(586, 189);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(153, 32);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscarPorId
            // 
            this.btnBuscarPorId.Location = new System.Drawing.Point(586, 240);
            this.btnBuscarPorId.Name = "btnBuscarPorId";
            this.btnBuscarPorId.Size = new System.Drawing.Size(153, 32);
            this.btnBuscarPorId.TabIndex = 4;
            this.btnBuscarPorId.Text = "Buscar por Id";
            this.btnBuscarPorId.UseVisualStyleBackColor = true;
            this.btnBuscarPorId.Click += new System.EventHandler(this.btnBuscarPorId_Click);
            // 
            // llbId
            // 
            this.llbId.AutoSize = true;
            this.llbId.Location = new System.Drawing.Point(139, 59);
            this.llbId.Name = "llbId";
            this.llbId.Size = new System.Drawing.Size(16, 13);
            this.llbId.TabIndex = 5;
            this.llbId.Text = "Id";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(139, 93);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(139, 129);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(139, 164);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.lblFechaNacimiento.TabIndex = 8;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(283, 59);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(136, 20);
            this.txtId.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(283, 93);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(136, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(283, 129);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(136, 20);
            this.txtApellido.TabIndex = 11;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(283, 164);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(136, 20);
            this.txtFechaNacimiento.TabIndex = 12;
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.llbId);
            this.Controls.Add(this.btnBuscarPorId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.gridAlumno);
            this.Name = "frmAlumno";
            this.Text = "frmAlumno";
            this.Load += new System.EventHandler(this.frmAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAlumno;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscarPorId;
        private System.Windows.Forms.Label llbId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
    }
}