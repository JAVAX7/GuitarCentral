namespace GuitarCentral
{
    partial class Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            this.Telefono = new System.Windows.Forms.Label();
            this.Poblacion = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guitarCentralDataSet = new GuitarCentral.GuitarCentralDataSet();
            this.txtdirecccion = new System.Windows.Forms.TextBox();
            this.txtpob = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.empleadosTableAdapter = new GuitarCentral.GuitarCentralDataSetTableAdapters.EmpleadosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitarCentralDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.BackColor = System.Drawing.Color.Transparent;
            this.Telefono.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Telefono.Location = new System.Drawing.Point(56, 246);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(49, 13);
            this.Telefono.TabIndex = 45;
            this.Telefono.Text = "Telefono";
            // 
            // Poblacion
            // 
            this.Poblacion.AutoSize = true;
            this.Poblacion.BackColor = System.Drawing.Color.Transparent;
            this.Poblacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Poblacion.Location = new System.Drawing.Point(56, 198);
            this.Poblacion.Name = "Poblacion";
            this.Poblacion.Size = new System.Drawing.Size(54, 13);
            this.Poblacion.TabIndex = 44;
            this.Poblacion.Text = "Poblacion";
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.BackColor = System.Drawing.Color.Transparent;
            this.Direccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Direccion.Location = new System.Drawing.Point(56, 151);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(52, 13);
            this.Direccion.TabIndex = 43;
            this.Direccion.Text = "Direccion";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Nombre.Location = new System.Drawing.Point(56, 49);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 42;
            this.Nombre.Text = "Nombre";
            // 
            // btnlast
            // 
            this.btnlast.BackgroundImage = global::GuitarCentral.Properties.Resources.last;
            this.btnlast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlast.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlast.Location = new System.Drawing.Point(286, 306);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(37, 36);
            this.btnlast.TabIndex = 41;
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.BackgroundImage = global::GuitarCentral.Properties.Resources.previous;
            this.btnprevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnprevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprevious.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnprevious.Location = new System.Drawing.Point(200, 306);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(37, 36);
            this.btnprevious.TabIndex = 40;
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.BackgroundImage = global::GuitarCentral.Properties.Resources.first;
            this.btnfirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnfirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfirst.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnfirst.Location = new System.Drawing.Point(157, 306);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(37, 36);
            this.btnfirst.TabIndex = 39;
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackgroundImage = global::GuitarCentral.Properties.Resources.next;
            this.btnnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnnext.Location = new System.Drawing.Point(243, 306);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(37, 36);
            this.btnnext.TabIndex = 38;
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.empleadosBindingSource, "Foto", true));
            this.pictureBox1.Location = new System.Drawing.Point(275, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
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
            // txtdirecccion
            // 
            this.txtdirecccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Direccion", true));
            this.txtdirecccion.Location = new System.Drawing.Point(59, 167);
            this.txtdirecccion.Name = "txtdirecccion";
            this.txtdirecccion.Size = new System.Drawing.Size(159, 20);
            this.txtdirecccion.TabIndex = 36;
            // 
            // txtpob
            // 
            this.txtpob.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Poblacion", true));
            this.txtpob.Location = new System.Drawing.Point(59, 214);
            this.txtpob.Name = "txtpob";
            this.txtpob.Size = new System.Drawing.Size(159, 20);
            this.txtpob.TabIndex = 35;
            // 
            // txttel
            // 
            this.txttel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Telefono", true));
            this.txttel.Location = new System.Drawing.Point(59, 262);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(159, 20);
            this.txttel.TabIndex = 34;
            // 
            // txtname
            // 
            this.txtname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Nombre", true));
            this.txtname.Location = new System.Drawing.Point(59, 65);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(159, 20);
            this.txtname.TabIndex = 33;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(56, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Puesto";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Puesto", true));
            this.textBox1.Location = new System.Drawing.Point(59, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 46;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclose.Location = new System.Drawing.Point(372, 306);
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
            this.btnr.Location = new System.Drawing.Point(6, 306);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(106, 36);
            this.btnr.TabIndex = 63;
            this.btnr.Text = "Regresar";
            this.btnr.UseVisualStyleBackColor = false;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::GuitarCentral.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(484, 366);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Poblacion);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtdirecccion);
            this.Controls.Add(this.txtpob);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitarCentralDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label Poblacion;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtdirecccion;
        private System.Windows.Forms.TextBox txtpob;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtname;
        private GuitarCentralDataSet guitarCentralDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private GuitarCentralDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnr;
    }
}