namespace Artigo
{
    partial class Status_artigos
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
            this.datagrid_status = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_status)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_status
            // 
            this.datagrid_status.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_status.Location = new System.Drawing.Point(66, 124);
            this.datagrid_status.Name = "datagrid_status";
            this.datagrid_status.Size = new System.Drawing.Size(1092, 486);
            this.datagrid_status.TabIndex = 0;
            this.datagrid_status.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrids_status);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visão geral dos artigos submetidos";
            // 
            // Status_artigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagrid_status);
            this.Name = "Status_artigos";
            this.Text = "Status_artigos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Status_artigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_status;
        private System.Windows.Forms.Label label1;
    }
}