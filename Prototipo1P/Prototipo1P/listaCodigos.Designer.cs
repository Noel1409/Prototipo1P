
namespace Prototipo1P
{
    partial class listaCodigos
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
            this.dgvCodigos = new System.Windows.Forms.DataGridView();
            this.btnActu = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodigos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCodigos
            // 
            this.dgvCodigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCodigos.Location = new System.Drawing.Point(12, 77);
            this.dgvCodigos.Name = "dgvCodigos";
            this.dgvCodigos.RowTemplate.Height = 25;
            this.dgvCodigos.Size = new System.Drawing.Size(484, 361);
            this.dgvCodigos.TabIndex = 0;
            // 
            // btnActu
            // 
            this.btnActu.BackColor = System.Drawing.Color.BurlyWood;
            this.btnActu.Location = new System.Drawing.Point(196, 12);
            this.btnActu.Name = "btnActu";
            this.btnActu.Size = new System.Drawing.Size(118, 50);
            this.btnActu.TabIndex = 1;
            this.btnActu.Text = "Actualizar";
            this.btnActu.UseVisualStyleBackColor = false;
            this.btnActu.Click += new System.EventHandler(this.btnActu_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(421, 26);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // listaCodigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnActu);
            this.Controls.Add(this.dgvCodigos);
            this.Name = "listaCodigos";
            this.Text = "Listado Código - Líneas";
            this.Load += new System.EventHandler(this.listaCodigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodigos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCodigos;
        private System.Windows.Forms.Button btnActu;
        private System.Windows.Forms.Button btnRegresar;
    }
}