namespace GuitarCentral
{
    partial class LogIn
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.btni = new System.Windows.Forms.Button();
            this.lblpas = new System.Windows.Forms.Label();
            this.lblusern = new System.Windows.Forms.Label();
            this.txtpas = new System.Windows.Forms.TextBox();
            this.txtusern = new System.Windows.Forms.TextBox();
            this.btnminimize = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btni
            // 
            this.btni.BackColor = System.Drawing.Color.Red;
            this.btni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btni.Location = new System.Drawing.Point(103, 314);
            this.btni.Name = "btni";
            this.btni.Size = new System.Drawing.Size(109, 36);
            this.btni.TabIndex = 22;
            this.btni.Text = "Ingresar";
            this.btni.UseVisualStyleBackColor = false;
            this.btni.Click += new System.EventHandler(this.btni_Click);
            // 
            // lblpas
            // 
            this.lblpas.AutoSize = true;
            this.lblpas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblpas.Location = new System.Drawing.Point(87, 252);
            this.lblpas.Name = "lblpas";
            this.lblpas.Size = new System.Drawing.Size(61, 13);
            this.lblpas.TabIndex = 21;
            this.lblpas.Text = "Contraseña";
            // 
            // lblusern
            // 
            this.lblusern.AutoSize = true;
            this.lblusern.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblusern.Location = new System.Drawing.Point(87, 204);
            this.lblusern.Name = "lblusern";
            this.lblusern.Size = new System.Drawing.Size(98, 13);
            this.lblusern.TabIndex = 20;
            this.lblusern.Text = "Nombre de Usuario";
            // 
            // txtpas
            // 
            this.txtpas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpas.Location = new System.Drawing.Point(87, 268);
            this.txtpas.Name = "txtpas";
            this.txtpas.PasswordChar = '*';
            this.txtpas.Size = new System.Drawing.Size(141, 26);
            this.txtpas.TabIndex = 19;
            this.txtpas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtusern
            // 
            this.txtusern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusern.Location = new System.Drawing.Point(87, 219);
            this.txtusern.Name = "txtusern";
            this.txtusern.Size = new System.Drawing.Size(141, 26);
            this.txtusern.TabIndex = 18;
            this.txtusern.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnminimize
            // 
            this.btnminimize.BackColor = System.Drawing.Color.Transparent;
            this.btnminimize.BackgroundImage = global::GuitarCentral.Properties.Resources.minimize1;
            this.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnminimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnminimize.Location = new System.Drawing.Point(254, 0);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(26, 25);
            this.btnminimize.TabIndex = 24;
            this.btnminimize.UseVisualStyleBackColor = false;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BackgroundImage = global::GuitarCentral.Properties.Resources.exit1;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclose.Location = new System.Drawing.Point(279, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(26, 25);
            this.btnclose.TabIndex = 23;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GuitarCentral.Properties.Resources.GuitarCenter2;
            this.pictureBox1.Location = new System.Drawing.Point(44, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(305, 403);
            this.Controls.Add(this.btnminimize);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btni);
            this.Controls.Add(this.lblpas);
            this.Controls.Add(this.lblusern);
            this.Controls.Add(this.txtpas);
            this.Controls.Add(this.txtusern);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btni;
        private System.Windows.Forms.Label lblpas;
        private System.Windows.Forms.Label lblusern;
        private System.Windows.Forms.TextBox txtpas;
        private System.Windows.Forms.TextBox txtusern;

    }
}

