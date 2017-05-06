namespace Artigo
{
    partial class Cadastrar
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
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdPerfil = new System.Windows.Forms.ComboBox();
            this.label_perfil = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Listar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(42, 126);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(375, 20);
            this.textUsuario.TabIndex = 1;
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(42, 199);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(375, 20);
            this.textSenha.TabIndex = 3;
            this.textSenha.TextChanged += new System.EventHandler(this.textSenha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // cmdPerfil
            // 
            this.cmdPerfil.FormattingEnabled = true;
            this.cmdPerfil.Items.AddRange(new object[] {
            "ND",
            "Gerente",
            "Autor",
            "Revisor"});
            this.cmdPerfil.Location = new System.Drawing.Point(42, 270);
            this.cmdPerfil.Name = "cmdPerfil";
            this.cmdPerfil.Size = new System.Drawing.Size(121, 21);
            this.cmdPerfil.TabIndex = 4;
            this.cmdPerfil.Visible = false;
            // 
            // label_perfil
            // 
            this.label_perfil.AutoSize = true;
            this.label_perfil.Location = new System.Drawing.Point(39, 244);
            this.label_perfil.Name = "label_perfil";
            this.label_perfil.Size = new System.Drawing.Size(30, 13);
            this.label_perfil.TabIndex = 5;
            this.label_perfil.Text = "Perfil";
            this.label_perfil.Visible = false;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(169, 317);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(121, 34);
            this.btn_Cadastrar.TabIndex = 6;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(42, 317);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(121, 34);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Listar
            // 
            this.btn_Listar.Location = new System.Drawing.Point(296, 317);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(121, 34);
            this.btn_Listar.TabIndex = 8;
            this.btn_Listar.Text = "Listar";
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Visible = false;
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(170, 317);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(120, 34);
            this.btn_alterar.TabIndex = 9;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Visible = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(42, 70);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(375, 20);
            this.text_nome.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nome";
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(423, 317);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(121, 34);
            this.btn_Excluir.TabIndex = 12;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Visible = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 393);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_Listar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.label_perfil);
            this.Controls.Add(this.cmdPerfil);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.label1);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmdPerfil;
        private System.Windows.Forms.Label label_perfil;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Listar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Excluir;
    }
}