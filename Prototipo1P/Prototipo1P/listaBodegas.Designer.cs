
namespace Prototipo1P
{
    partial class listaBodegas
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
            this.dgvBodegas = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnActu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodegas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBodegas
            // 
            this.dgvBodegas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBodegas.Location = new System.Drawing.Point(12, 71);
            this.dgvBodegas.Name = "dgvBodegas";
            this.dgvBodegas.RowTemplate.Height = 25;
            this.dgvBodegas.Size = new System.Drawing.Size(480, 367);
            this.dgvBodegas.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Coral;
            this.btnRegresar.Location = new System.Drawing.Point(417, 24);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnActu
            // 
            this.btnActu.BackColor = System.Drawing.Color.IndianRed;
            this.btnActu.Location = new System.Drawing.Point(202, 12);
            this.btnActu.Name = "btnActu";
            this.btnActu.Size = new System.Drawing.Size(125, 51);
            this.btnActu.TabIndex = 2;
            this.btnActu.Text = "Actualizar";
            this.btnActu.UseVisualStyleBackColor = false;
            // 
            // listaBodegas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(504, 450);
            this.Controls.Add(this.btnActu);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dgvBodegas);
            this.Name = "listaBodegas";
            this.Text = "Listado Bodegas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodegas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBodegas;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnActu;
    }
}