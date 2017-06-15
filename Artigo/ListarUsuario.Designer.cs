namespace Artigo
{
    partial class ListarUsuario
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
            this.data_Grid = new System.Windows.Forms.DataGridView();
            this.text_consulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // data_Grid
            // 
            this.data_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Grid.Location = new System.Drawing.Point(340, 229);
            this.data_Grid.Name = "data_Grid";
            this.data_Grid.Size = new System.Drawing.Size(608, 327);
            this.data_Grid.TabIndex = 0;
            this.data_Grid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Grid_CellContentDoubleClick);
            // 
            // text_consulta
            // 
            this.text_consulta.Location = new System.Drawing.Point(340, 180);
            this.text_consulta.Name = "text_consulta";
            this.text_consulta.Size = new System.Drawing.Size(608, 20);
            this.text_consulta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultar usuário";
            // 
            // ListarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Artigo.Properties.Resources.library1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1194, 636);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_consulta);
            this.Controls.Add(this.data_Grid);
            this.Name = "ListarUsuario";
            this.Text = "Listar usuário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_Grid;
        private System.Windows.Forms.TextBox text_consulta;
        private System.Windows.Forms.Label label1;
    }
}