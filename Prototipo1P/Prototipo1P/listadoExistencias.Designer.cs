
namespace Prototipo1P
{
    partial class listadoExistencias
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
            this.dgvExitencias = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnActu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExitencias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExitencias
            // 
            this.dgvExitencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExitencias.Location = new System.Drawing.Point(12, 63);
            this.dgvExitencias.Name = "dgvExitencias";
            this.dgvExitencias.RowTemplate.Height = 25;
            this.dgvExitencias.Size = new System.Drawing.Size(450, 375);
            this.dgvExitencias.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(387, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnActu
            // 
            this.btnActu.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnActu.Location = new System.Drawing.Point(189, 8);
            this.btnActu.Name = "btnActu";
            this.btnActu.Size = new System.Drawing.Size(104, 49);
            this.btnActu.TabIndex = 2;
            this.btnActu.Text = "Actualizar";
            this.btnActu.UseVisualStyleBackColor = false;
            this.btnActu.Click += new System.EventHandler(this.btnActu_Click);
            // 
            // listadoExistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.btnActu);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dgvExitencias);
            this.Name = "listadoExistencias";
            this.Text = "Listado de Existencias";
            this.Load += new System.EventHandler(this.listadoExistencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExitencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExitencias;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnActu;
    }
}