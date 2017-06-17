namespace Artigo
{
    partial class AreaInteresse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.text_areaInteresse = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_Areas = new System.Windows.Forms.DataGridView();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_ListarAreas = new System.Windows.Forms.Button();
            this.grid_Revisores = new System.Windows.Forms.DataGridView();
            this.btn_AssociarRevisor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.codigo_revisor = new System.Windows.Forms.NumericUpDown();
            this.btn_ListarRevisor = new System.Windows.Forms.Button();
            this.cmd_Areas = new System.Windows.Forms.ComboBox();
            this.btn_Criarnovo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Areas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Revisores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigo_revisor)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salvar
            // 
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(57, 595);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(201, 77);
            this.btn_salvar.TabIndex = 0;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // text_areaInteresse
            // 
            this.text_areaInteresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_areaInteresse.Location = new System.Drawing.Point(56, 540);
            this.text_areaInteresse.Margin = new System.Windows.Forms.Padding(4);
            this.text_areaInteresse.Name = "text_areaInteresse";
            this.text_areaInteresse.Size = new System.Drawing.Size(454, 29);
            this.text_areaInteresse.TabIndex = 1;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(1102, 595);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(151, 77);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 469);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastrar área de interesse";
            // 
            // grid_Areas
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_Areas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Areas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Areas.Location = new System.Drawing.Point(24, 69);
            this.grid_Areas.Margin = new System.Windows.Forms.Padding(4);
            this.grid_Areas.Name = "grid_Areas";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            this.grid_Areas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Areas.Size = new System.Drawing.Size(519, 372);
            this.grid_Areas.TabIndex = 4;
            this.grid_Areas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_double);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Enabled = false;
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.Location = new System.Drawing.Point(24, 13);
            this.btn_Alterar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(140, 52);
            this.btn_Alterar.TabIndex = 5;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Location = new System.Drawing.Point(172, 13);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(140, 52);
            this.btn_Excluir.TabIndex = 6;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Visible = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_ListarAreas
            // 
            this.btn_ListarAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListarAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListarAreas.Location = new System.Drawing.Point(310, 595);
            this.btn_ListarAreas.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ListarAreas.Name = "btn_ListarAreas";
            this.btn_ListarAreas.Size = new System.Drawing.Size(200, 77);
            this.btn_ListarAreas.TabIndex = 7;
            this.btn_ListarAreas.Text = "Ver areas";
            this.btn_ListarAreas.UseVisualStyleBackColor = true;
            this.btn_ListarAreas.Click += new System.EventHandler(this.btn_ListarAreas_Click);
            // 
            // grid_Revisores
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_Revisores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_Revisores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Revisores.Location = new System.Drawing.Point(587, 69);
            this.grid_Revisores.Margin = new System.Windows.Forms.Padding(4);
            this.grid_Revisores.Name = "grid_Revisores";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue;
            this.grid_Revisores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_Revisores.Size = new System.Drawing.Size(653, 372);
            this.grid_Revisores.TabIndex = 8;
            // 
            // btn_AssociarRevisor
            // 
            this.btn_AssociarRevisor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AssociarRevisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AssociarRevisor.Location = new System.Drawing.Point(613, 595);
            this.btn_AssociarRevisor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AssociarRevisor.Name = "btn_AssociarRevisor";
            this.btn_AssociarRevisor.Size = new System.Drawing.Size(201, 77);
            this.btn_AssociarRevisor.TabIndex = 12;
            this.btn_AssociarRevisor.Text = "Associar";
            this.btn_AssociarRevisor.UseVisualStyleBackColor = true;
            this.btn_AssociarRevisor.Click += new System.EventHandler(this.btn_AssociarRevisor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(647, 445);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 92);
            this.label2.TabIndex = 11;
            this.label2.Text = "Digite o código do revisor e\r\nselecione a area de interesse";
            // 
            // codigo_revisor
            // 
            this.codigo_revisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigo_revisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo_revisor.Location = new System.Drawing.Point(613, 541);
            this.codigo_revisor.Margin = new System.Windows.Forms.Padding(4);
            this.codigo_revisor.Name = "codigo_revisor";
            this.codigo_revisor.Size = new System.Drawing.Size(201, 29);
            this.codigo_revisor.TabIndex = 12;
            // 
            // btn_ListarRevisor
            // 
            this.btn_ListarRevisor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListarRevisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListarRevisor.Location = new System.Drawing.Point(866, 595);
            this.btn_ListarRevisor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ListarRevisor.Name = "btn_ListarRevisor";
            this.btn_ListarRevisor.Size = new System.Drawing.Size(200, 77);
            this.btn_ListarRevisor.TabIndex = 13;
            this.btn_ListarRevisor.Text = "Ver revisor";
            this.btn_ListarRevisor.UseVisualStyleBackColor = true;
            this.btn_ListarRevisor.Click += new System.EventHandler(this.btn_VerRevisor);
            // 
            // cmd_Areas
            // 
            this.cmd_Areas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Areas.FormattingEnabled = true;
            this.cmd_Areas.Location = new System.Drawing.Point(866, 541);
            this.cmd_Areas.Name = "cmd_Areas";
            this.cmd_Areas.Size = new System.Drawing.Size(200, 32);
            this.cmd_Areas.TabIndex = 14;
            this.cmd_Areas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cm_Areas);
            // 
            // btn_Criarnovo
            // 
            this.btn_Criarnovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Criarnovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Criarnovo.Location = new System.Drawing.Point(57, 595);
            this.btn_Criarnovo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Criarnovo.Name = "btn_Criarnovo";
            this.btn_Criarnovo.Size = new System.Drawing.Size(201, 77);
            this.btn_Criarnovo.TabIndex = 15;
            this.btn_Criarnovo.Text = "Cria novo";
            this.btn_Criarnovo.UseVisualStyleBackColor = true;
            this.btn_Criarnovo.Visible = false;
            this.btn_Criarnovo.Click += new System.EventHandler(this.btn_Criarnovo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(172, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(855, 59);
            this.label3.TabIndex = 16;
            this.label3.Text = "Clique duas vezes em cima da area para alterar";
            // 
            // AreaInteresse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Artigo.Properties.Resources.library_books;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1266, 685);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Criarnovo);
            this.Controls.Add(this.cmd_Areas);
            this.Controls.Add(this.btn_ListarRevisor);
            this.Controls.Add(this.codigo_revisor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_AssociarRevisor);
            this.Controls.Add(this.grid_Revisores);
            this.Controls.Add(this.btn_ListarAreas);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.grid_Areas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.text_areaInteresse);
            this.Controls.Add(this.btn_salvar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AreaInteresse";
            this.Text = "AreaInteresse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AreaInteresse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Areas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Revisores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigo_revisor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox text_areaInteresse;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_Areas;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_ListarAreas;
        private System.Windows.Forms.DataGridView grid_Revisores;
        private System.Windows.Forms.Button btn_AssociarRevisor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown codigo_revisor;
        private System.Windows.Forms.Button btn_ListarRevisor;
        private System.Windows.Forms.ComboBox cmd_Areas;
        private System.Windows.Forms.Button btn_Criarnovo;
        private System.Windows.Forms.Label label3;
    }
}