namespace GuitarCentral
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.btnlast = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.txtbrand = new System.Windows.Forms.TextBox();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guitarCentralDataSet = new GuitarCentral.GuitarCentralDataSet();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productosTableAdapter = new GuitarCentral.GuitarCentralDataSetTableAdapters.ProductosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitarCentralDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnlast.TabIndex = 28;
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
            this.btnprevious.TabIndex = 27;
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
            this.btnfirst.TabIndex = 26;
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
            this.btnnext.TabIndex = 25;
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // txtbrand
            // 
            this.txtbrand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Marca", true));
            this.txtbrand.Location = new System.Drawing.Point(59, 111);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(159, 20);
            this.txtbrand.TabIndex = 23;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.guitarCentralDataSet;
            // 
            // guitarCentralDataSet
            // 
            this.guitarCentralDataSet.DataSetName = "GuitarCentralDataSet";
            this.guitarCentralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtcolor
            // 
            this.txtcolor.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.productosBindingSource, "Color", true));
            this.txtcolor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Color", true));
            this.txtcolor.Location = new System.Drawing.Point(59, 158);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(159, 20);
            this.txtcolor.TabIndex = 22;
            // 
            // txtprice
            // 
            this.txtprice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Precio", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.txtprice.Location = new System.Drawing.Point(59, 206);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(159, 20);
            this.txtprice.TabIndex = 21;
            // 
            // txtname
            // 
            this.txtname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Nombre del Producto", true));
            this.txtname.Location = new System.Drawing.Point(59, 65);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(159, 20);
            this.txtname.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productosBindingSource, "Imagen", true));
            this.pictureBox1.Location = new System.Drawing.Point(275, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(56, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre del producto";
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.BackColor = System.Drawing.Color.Transparent;
            this.Marca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Marca.Location = new System.Drawing.Point(56, 95);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(37, 13);
            this.Marca.TabIndex = 30;
            this.Marca.Text = "Marca";
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.BackColor = System.Drawing.Color.Transparent;
            this.Color.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Color.Location = new System.Drawing.Point(56, 142);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(31, 13);
            this.Color.TabIndex = 31;
            this.Color.Text = "Color";
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.BackColor = System.Drawing.Color.Transparent;
            this.Precio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Precio.Location = new System.Drawing.Point(56, 190);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(37, 13);
            this.Precio.TabIndex = 32;
            this.Precio.Text = "Precio";
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
            this.btnclose.Click += new System.EventHandler(this.btnc_Click);
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
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuitarCentral.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(484, 366);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbrand);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitarCentralDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbrand;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtname;
        private GuitarCentralDataSet guitarCentralDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private GuitarCentralDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnr;
    }
}