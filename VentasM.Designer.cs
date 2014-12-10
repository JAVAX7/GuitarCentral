namespace GuitarCentral
{
    partial class VentasM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasM));
            this.btncancel = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnInd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncancel.Location = new System.Drawing.Point(4, 233);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(96, 23);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnT.Location = new System.Drawing.Point(107, 124);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(197, 44);
            this.btnT.TabIndex = 4;
            this.btnT.Text = "Todos los regisrtros";
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnInd
            // 
            this.btnInd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInd.Location = new System.Drawing.Point(108, 67);
            this.btnInd.Name = "btnInd";
            this.btnInd.Size = new System.Drawing.Size(197, 44);
            this.btnInd.TabIndex = 3;
            this.btnInd.Text = "Registro Individual";
            this.btnInd.UseVisualStyleBackColor = false;
            this.btnInd.Click += new System.EventHandler(this.btnInd_Click);
            // 
            // VentasM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(414, 261);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnInd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentasM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnInd;
    }
}