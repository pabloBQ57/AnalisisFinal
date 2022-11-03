namespace Presentación.Administración
{
    partial class Reportes
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDonaciones = new System.Windows.Forms.DataGridView();
            this.dataGridViewGastos = new System.Windows.Forms.DataGridView();
            this.btnactualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(397, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTES";
            // 
            // dataGridViewDonaciones
            // 
            this.dataGridViewDonaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonaciones.Location = new System.Drawing.Point(22, 74);
            this.dataGridViewDonaciones.Name = "dataGridViewDonaciones";
            this.dataGridViewDonaciones.RowHeadersWidth = 51;
            this.dataGridViewDonaciones.RowTemplate.Height = 24;
            this.dataGridViewDonaciones.Size = new System.Drawing.Size(435, 150);
            this.dataGridViewDonaciones.TabIndex = 1;
            // 
            // dataGridViewGastos
            // 
            this.dataGridViewGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGastos.Location = new System.Drawing.Point(474, 74);
            this.dataGridViewGastos.Name = "dataGridViewGastos";
            this.dataGridViewGastos.RowHeadersWidth = 51;
            this.dataGridViewGastos.RowTemplate.Height = 24;
            this.dataGridViewGastos.Size = new System.Drawing.Size(426, 150);
            this.dataGridViewGastos.TabIndex = 2;
            // 
            // btnactualizar
            // 
            this.btnactualizar.ForeColor = System.Drawing.Color.Black;
            this.btnactualizar.Location = new System.Drawing.Point(402, 467);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(125, 33);
            this.btnactualizar.TabIndex = 3;
            this.btnactualizar.Text = "ACTUALIZAR";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(974, 526);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.dataGridViewGastos);
            this.Controls.Add(this.dataGridViewDonaciones);
            this.Controls.Add(this.label1);
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDonaciones;
        private System.Windows.Forms.DataGridView dataGridViewGastos;
        private System.Windows.Forms.Button btnactualizar;
    }
}