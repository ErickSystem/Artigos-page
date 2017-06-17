namespace Artigo
{
    partial class Justificar
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
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.text_Justificativa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Salvar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Salvar.Location = new System.Drawing.Point(260, 554);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(187, 80);
            this.btn_Salvar.TabIndex = 0;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = false;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // text_Justificativa
            // 
            this.text_Justificativa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_Justificativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Justificativa.Location = new System.Drawing.Point(98, 114);
            this.text_Justificativa.Multiline = true;
            this.text_Justificativa.Name = "text_Justificativa";
            this.text_Justificativa.Size = new System.Drawing.Size(574, 412);
            this.text_Justificativa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Justificativa";
            // 
            // Justificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Artigo.Properties.Resources.books3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 667);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Justificativa);
            this.Controls.Add(this.btn_Salvar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Justificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Justificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.TextBox text_Justificativa;
        private System.Windows.Forms.Label label1;
    }
}