﻿namespace Artigo
{
    partial class Artigo
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
            this.artigo_Titulo = new System.Windows.Forms.TextBox();
            this.artigo_Conteudo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Submeter = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aprovar = new System.Windows.Forms.Button();
            this.btn_Reprovar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Justificar = new System.Windows.Forms.Button();
            this.btn_listarArtigo = new System.Windows.Forms.Button();
            this.cmb_areaInter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // artigo_Titulo
            // 
            this.artigo_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artigo_Titulo.Location = new System.Drawing.Point(23, 45);
            this.artigo_Titulo.Multiline = true;
            this.artigo_Titulo.Name = "artigo_Titulo";
            this.artigo_Titulo.Size = new System.Drawing.Size(322, 32);
            this.artigo_Titulo.TabIndex = 0;
            // 
            // artigo_Conteudo
            // 
            this.artigo_Conteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artigo_Conteudo.Location = new System.Drawing.Point(23, 93);
            this.artigo_Conteudo.Multiline = true;
            this.artigo_Conteudo.Name = "artigo_Conteudo";
            this.artigo_Conteudo.Size = new System.Drawing.Size(1152, 523);
            this.artigo_Conteudo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titulo";
            // 
            // btn_Submeter
            // 
            this.btn_Submeter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Submeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submeter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Submeter.Location = new System.Drawing.Point(1055, 622);
            this.btn_Submeter.Name = "btn_Submeter";
            this.btn_Submeter.Size = new System.Drawing.Size(120, 61);
            this.btn_Submeter.TabIndex = 4;
            this.btn_Submeter.Text = "Submeter";
            this.btn_Submeter.UseVisualStyleBackColor = false;
            this.btn_Submeter.Click += new System.EventHandler(this.btn_Submeter_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancelar.Location = new System.Drawing.Point(917, 622);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(132, 61);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aprovar
            // 
            this.btn_Aprovar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Aprovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aprovar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Aprovar.Location = new System.Drawing.Point(1055, 12);
            this.btn_Aprovar.Name = "btn_Aprovar";
            this.btn_Aprovar.Size = new System.Drawing.Size(120, 65);
            this.btn_Aprovar.TabIndex = 6;
            this.btn_Aprovar.Text = "Aprovar";
            this.btn_Aprovar.UseVisualStyleBackColor = false;
            this.btn_Aprovar.Visible = false;
            this.btn_Aprovar.Click += new System.EventHandler(this.btn_Aprovar_Click);
            // 
            // btn_Reprovar
            // 
            this.btn_Reprovar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Reprovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reprovar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Reprovar.Location = new System.Drawing.Point(929, 12);
            this.btn_Reprovar.Name = "btn_Reprovar";
            this.btn_Reprovar.Size = new System.Drawing.Size(120, 65);
            this.btn_Reprovar.TabIndex = 7;
            this.btn_Reprovar.Text = "Reprovar";
            this.btn_Reprovar.UseVisualStyleBackColor = false;
            this.btn_Reprovar.Visible = false;
            this.btn_Reprovar.Click += new System.EventHandler(this.btn_Reprovar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deletar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Deletar.Location = new System.Drawing.Point(803, 12);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(120, 65);
            this.btn_Deletar.TabIndex = 8;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = false;
            this.btn_Deletar.Visible = false;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Justificar
            // 
            this.btn_Justificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Justificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Justificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Justificar.Location = new System.Drawing.Point(677, 12);
            this.btn_Justificar.Name = "btn_Justificar";
            this.btn_Justificar.Size = new System.Drawing.Size(120, 65);
            this.btn_Justificar.TabIndex = 9;
            this.btn_Justificar.Text = "Não rever";
            this.btn_Justificar.UseVisualStyleBackColor = false;
            this.btn_Justificar.Visible = false;
            this.btn_Justificar.Click += new System.EventHandler(this.btn_Justificar_Click);
            // 
            // btn_listarArtigo
            // 
            this.btn_listarArtigo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_listarArtigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listarArtigo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_listarArtigo.Location = new System.Drawing.Point(778, 622);
            this.btn_listarArtigo.Name = "btn_listarArtigo";
            this.btn_listarArtigo.Size = new System.Drawing.Size(133, 61);
            this.btn_listarArtigo.TabIndex = 10;
            this.btn_listarArtigo.Text = "Listar artigos";
            this.btn_listarArtigo.UseVisualStyleBackColor = false;
            this.btn_listarArtigo.Visible = false;
            this.btn_listarArtigo.Click += new System.EventHandler(this.btn_listarArtigo_Click);
            // 
            // cmb_areaInter
            // 
            this.cmb_areaInter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_areaInter.Location = new System.Drawing.Point(351, 45);
            this.cmb_areaInter.Name = "cmb_areaInter";
            this.cmb_areaInter.Size = new System.Drawing.Size(179, 32);
            this.cmb_areaInter.TabIndex = 0;
            this.cmb_areaInter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmd_AreaInteresse);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(345, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Área de interesse";
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Alterar.Location = new System.Drawing.Point(1055, 622);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(120, 61);
            this.btn_Alterar.TabIndex = 12;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            this.btn_Alterar.Visible = false;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // Artigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Artigo.Properties.Resources.books2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1187, 686);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_areaInter);
            this.Controls.Add(this.btn_listarArtigo);
            this.Controls.Add(this.btn_Justificar);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Reprovar);
            this.Controls.Add(this.btn_Aprovar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Submeter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.artigo_Conteudo);
            this.Controls.Add(this.artigo_Titulo);
            this.Name = "Artigo";
            this.Text = "Artigo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Artigo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox artigo_Titulo;
        private System.Windows.Forms.TextBox artigo_Conteudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Submeter;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aprovar;
        private System.Windows.Forms.Button btn_Reprovar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Justificar;
        private System.Windows.Forms.Button btn_listarArtigo;
        private System.Windows.Forms.ComboBox cmb_areaInter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Alterar;
    }
}