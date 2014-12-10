namespace GuitarCentral
{
    partial class ClientesT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesT));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poblacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guitarCentralDataSet = new GuitarCentral.GuitarCentralDataSet();
            this.clientesTableAdapter = new GuitarCentral.GuitarCentralDataSetTableAdapters.ClientesTableAdapter();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitarCentralDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoClienteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.codigoPostalDataGridViewTextBoxColumn,
            this.poblacionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.clientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(851, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // codigoClienteDataGridViewTextBoxColumn
            // 
            this.codigoClienteDataGridViewTextBoxColumn.DataPropertyName = "Codigo Cliente";
            this.codigoClienteDataGridViewTextBoxColumn.HeaderText = "Codigo Cliente";
            this.codigoClienteDataGridViewTextBoxColumn.Name = "codigoClienteDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
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
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "Fax";
            this.faxDataGridViewTextBoxColumn.HeaderText = "Fax";
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "Foto";
            this.fotoDataGridViewImageColumn.HeaderText = "Foto";
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.guitarCentralDataSet;
            // 
            // guitarCentralDataSet
            // 
            this.guitarCentralDataSet.DataSetName = "GuitarCentralDataSet";
            this.guitarCentralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // btnlast
            // 
            this.btnlast.BackgroundImage = global::GuitarCentral.Properties.Resources.last;
            this.btnlast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlast.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlast.Location = new System.Drawing.Point(492, 377);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(37, 36);
            this.btnlast.TabIndex = 60;
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.BackgroundImage = global::GuitarCentral.Properties.Resources.previous;
            this.btnprevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnprevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprevious.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnprevious.Location = new System.Drawing.Point(406, 377);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(37, 36);
            this.btnprevious.TabIndex = 59;
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.BackgroundImage = global::GuitarCentral.Properties.Resources.first;
            this.btnfirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnfirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfirst.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnfirst.Location = new System.Drawing.Point(363, 377);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(37, 36);
            this.btnfirst.TabIndex = 58;
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackgroundImage = global::GuitarCentral.Properties.Resources.next;
            this.btnnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnnext.Location = new System.Drawing.Point(449, 377);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(37, 36);
            this.btnnext.TabIndex = 57;
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclose.Location = new System.Drawing.Point(577, 377);
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
            this.btnr.Location = new System.Drawing.Point(211, 377);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(106, 36);
            this.btnr.TabIndex = 63;
            this.btnr.Text = "Regresar";
            this.btnr.UseVisualStyleBackColor = false;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // ClientesT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(858, 425);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientesT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientesT";
            this.Load += new System.EventHandler(this.ClientesT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitarCentralDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GuitarCentralDataSet guitarCentralDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private GuitarCentralDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poblacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnr;
    }
}