namespace GuitarCentral
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.Cantidad = new System.Windows.Forms.Label();
            this.Producto = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.Label();
            this.Emp = new System.Windows.Forms.Label();
            this.txtbrand = new System.Windows.Forms.TextBox();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guitarCentralDataSet = new GuitarCentral.GuitarCentralDataSet();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.ventasTableAdapter = new GuitarCentral.GuitarCentralDataSetTableAdapters.VentasTableAdapter();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitarCentralDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.BackColor = System.Drawing.Color.Transparent;
            this.Cantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cantidad.Location = new System.Drawing.Point(56, 190);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(49, 13);
            this.Cantidad.TabIndex = 44;
            this.Cantidad.Text = "Cantidad";
            // 
            // Producto
            // 
            this.Producto.AutoSize = true;
            this.Producto.BackColor = System.Drawing.Color.Transparent;
            this.Producto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Producto.Location = new System.Drawing.Point(56, 142);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(50, 13);
            this.Producto.TabIndex = 43;
            this.Producto.Text = "Producto";
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.BackColor = System.Drawing.Color.Transparent;
            this.Cliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cliente.Location = new System.Drawing.Point(56, 95);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(39, 13);
            this.Cliente.TabIndex = 42;
            this.Cliente.Text = "Cliente";
            // 
            // Emp
            // 
            this.Emp.AutoSize = true;
            this.Emp.BackColor = System.Drawing.Color.Transparent;
            this.Emp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Emp.Location = new System.Drawing.Point(56, 49);
            this.Emp.Name = "Emp";
            this.Emp.Size = new System.Drawing.Size(54, 13);
            this.Emp.TabIndex = 41;
            this.Emp.Text = "Empleado";
            // 
            // txtbrand
            // 
            this.txtbrand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Codigo Cliente", true));
            this.txtbrand.Location = new System.Drawing.Point(59, 111);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(159, 20);
            this.txtbrand.TabIndex = 36;
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.guitarCentralDataSet;
            // 
            // guitarCentralDataSet
            // 
            this.guitarCentralDataSet.DataSetName = "GuitarCentralDataSet";
            this.guitarCentralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtcolor
            // 
            this.txtcolor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Codigo Producto", true));
            this.txtcolor.Location = new System.Drawing.Point(59, 158);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(159, 20);
            this.txtcolor.TabIndex = 35;
            // 
            // txtprice
            // 
            this.txtprice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Cantidad", true));
            this.txtprice.Location = new System.Drawing.Point(59, 206);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(159, 20);
            this.txtprice.TabIndex = 34;
            // 
            // txtname
            // 
            this.txtname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Codigo Empleado", true));
            this.txtname.Location = new System.Drawing.Point(59, 65);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(159, 20);
            this.txtname.TabIndex = 33;
            // 
            // btnlast
            // 
            this.btnlast.BackgroundImage = global::GuitarCentral.Properties.Resources.last;
            this.btnlast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlast.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlast.Location = new System.Drawing.Point(286, 306);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(37, 36);
            this.btnlast.TabIndex = 40;
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.BackgroundImage = global::GuitarCentral.Properties.Resources.previous;
            this.btnprevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnprevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprevious.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnprevious.Location = new System.Drawing.Point(200, 306);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(37, 36);
            this.btnprevious.TabIndex = 39;
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.BackgroundImage = global::GuitarCentral.Properties.Resources.first;
            this.btnfirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnfirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfirst.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnfirst.Location = new System.Drawing.Point(157, 306);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(37, 36);
            this.btnfirst.TabIndex = 38;
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackgroundImage = global::GuitarCentral.Properties.Resources.next;
            this.btnnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnnext.Location = new System.Drawing.Point(243, 306);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(37, 36);
            this.btnnext.TabIndex = 37;
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.BackColor = System.Drawing.Color.Transparent;
            this.chk1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.ventasBindingSource, "Envio", true));
            this.chk1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chk1.Location = new System.Drawing.Point(70, 240);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(53, 17);
            this.chk1.TabIndex = 45;
            this.chk1.Text = "Envio";
            this.chk1.UseVisualStyleBackColor = false;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclose.Location = new System.Drawing.Point(372, 306);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(106, 36);
            this.btnclose.TabIndex = 66;
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
            this.btnr.TabIndex = 65;
            this.btnr.Text = "Regresar";
            this.btnr.UseVisualStyleBackColor = false;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::GuitarCentral.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(484, 366);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.chk1);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.Emp);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.txtbrand);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitarCentralDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.Label Producto;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label Emp;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.TextBox txtbrand;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.CheckBox chk1;
        private GuitarCentralDataSet guitarCentralDataSet;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private GuitarCentralDataSetTableAdapters.VentasTableAdapter ventasTableAdapter;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnr;
    }
}