
namespace Prototipo1P
{
    partial class frmGestionProductos
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnElim = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Location = new System.Drawing.Point(42, 32);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(107, 56);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo Producto";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModif
            // 
            this.btnModif.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnModif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModif.Location = new System.Drawing.Point(217, 32);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(107, 56);
            this.btnModif.TabIndex = 1;
            this.btnModif.Text = "Modificar Producto";
            this.btnModif.UseVisualStyleBackColor = false;
            this.btnModif.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnElim
            // 
            this.btnElim.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnElim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElim.Location = new System.Drawing.Point(42, 122);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(107, 56);
            this.btnElim.TabIndex = 3;
            this.btnElim.Text = "Eliminar Producto";
            this.btnElim.UseVisualStyleBackColor = false;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(267, 178);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(78, 23);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(183, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 63);
            this.label1.TabIndex = 5;
            this.label1.Text = "Para consultar, \r\nabrir el listado de \r\nexistencias";
            // 
            // frmGestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(357, 213);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnElim);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnNuevo);
            this.Name = "frmGestionProductos";
            this.Text = "Gestion Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
    }
}