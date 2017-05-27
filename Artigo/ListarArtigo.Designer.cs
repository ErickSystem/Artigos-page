namespace Artigo
{
    partial class ListarArtigo
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
            this.datagrid_ListarArtigos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_ListarArtigos)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_ListarArtigos
            // 
            this.datagrid_ListarArtigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_ListarArtigos.Location = new System.Drawing.Point(232, 138);
            this.datagrid_ListarArtigos.Name = "datagrid_ListarArtigos";
            this.datagrid_ListarArtigos.Size = new System.Drawing.Size(794, 448);
            this.datagrid_ListarArtigos.TabIndex = 0;
            this.datagrid_ListarArtigos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_listarArtigoss);
            // 
            // ListarArtigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 643);
            this.Controls.Add(this.datagrid_ListarArtigos);
            this.Name = "ListarArtigo";
            this.Text = "ListarArtigo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListarArtigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_ListarArtigos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_ListarArtigos;
    }
}