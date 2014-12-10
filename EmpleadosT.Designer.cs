namespace GuitarCentral
{
    partial class EmpleadosT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadosT));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poblacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guitarCentralDataSet = new GuitarCentral.GuitarCentralDataSet();
            this.empleadosTableAdapter = new GuitarCentral.GuitarCentralDataSetTableAdapters.EmpleadosTableAdapter();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitarCentralDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoEmpleadoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.fechaDeInicioDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.codigoPostalDataGridViewTextBoxColumn,
            this.poblacionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.puestoDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.empleadosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(916, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // codigoEmpleadoDataGridViewTextBoxColumn
            // 
            this.codigoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "Codigo Empleado";
            this.codigoEmpleadoDataGridViewTextBoxColumn.HeaderText = "Codigo Empleado";
            this.codigoEmpleadoDataGridViewTextBoxColumn.Name = "codigoEmpleadoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // fechaDeInicioDataGridViewTextBoxColumn
            // 
            this.fechaDeInicioDataGridViewTextBoxColumn.DataPropertyName = "Fecha de inicio";
            this.fechaDeInicioDataGridViewTextBoxColumn.HeaderText = "Fecha de inicio";
            this.fechaDeInicioDataGridViewTextBoxColumn.Name = "fechaDeInicioDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // codigoPostalDataGridViewTextBoxColumn
            // 
            this.codigoPostalDataGridViewTextBoxColumn.DataPropertyName = "Codigo Postal";
            this.codigoPostalDataGridViewTextBoxColumn.HeaderText = "Codigo Postal";
            this.codigoPostalDataGridViewTextBoxColumn.Name = "codigoPostalDataGridViewTextBoxColumn";
            // 
            // poblacionDataGridViewTextBoxColumn
            // 
            this.poblacionDataGridViewTextBoxColumn.DataPropertyName = "Poblacion";
            this.poblacionDataGridViewTextBoxColumn.HeaderText = "Poblacion";
            this.poblacionDataGridViewTextBoxColumn.Name = "poblacionDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // puestoDataGridViewTextBoxColumn
            // 
            this.puestoDataGridViewTextBoxColumn.DataPropertyName = "Puesto";
            this.puestoDataGridViewTextBoxColumn.HeaderText = "Puesto";
            this.puestoDataGridViewTextBoxColumn.Name = "puestoDataGridViewTextBoxColumn";
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "Foto";
            this.fotoDataGridViewImageColumn.HeaderText = "Foto";
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.guitarCentralDataSet;
            // 
            // guitarCentralDataSet
            // 
            this.guitarCentralDataSet.DataSetName = "GuitarCentralDataSet";
            this.guitarCentralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // btnlast
            // 
            this.btnlast.BackgroundImage = global::GuitarCentral.Properties.Resources.last;
            this.btnlast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlast.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlast.Location = new System.Drawing.Point(522, 372);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(37, 36);
            this.btnlast.TabIndex = 45;
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.BackgroundImage = global::GuitarCentral.Properties.Resources.previous;
            this.btnprevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnprevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprevious.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnprevious.Location = new System.Drawing.Point(436, 372);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(37, 36);
            this.btnprevious.TabIndex = 44;
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.BackgroundImage = global::GuitarCentral.Properties.Resources.first;
            this.btnfirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnfirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfirst.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnfirst.Location = new System.Drawing.Point(393, 372);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(37, 36);
            this.btnfirst.TabIndex = 43;
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackgroundImage = global::GuitarCentral.Properties.Resources.next;
            this.btnnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnnext.Location = new System.Drawing.Point(479, 372);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(37, 36);
            this.btnnext.TabIndex = 42;
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclose.Location = new System.Drawing.Point(606, 372);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(106, 36);
            this.btnclose.TabIndex = 64;
            this.btnclose.Text = "Cerrar";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnr
            // 
            this.btnr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnr.Location = new System.Drawing.Point(240, 372);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(106, 36);
            this.btnr.TabIndex = 63;
            this.btnr.Text = "Regresar";
            this.btnr.UseVisualStyleBackColor = false;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // EmpleadosT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(933, 420);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmpleadosT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpleadosT";
            this.Load += new System.EventHandler(this.EmpleadosT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitarCentralDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GuitarCentralDataSet guitarCentralDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private GuitarCentralDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poblacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnr;
    }
}