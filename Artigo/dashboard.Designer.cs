namespace Artigo
{
    partial class Dashboard
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
            this.btn_Artigos = new System.Windows.Forms.Button();
            this.label_user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_tipoUser = new System.Windows.Forms.Label();
            this.btn_Status = new System.Windows.Forms.Button();
            this.btn_areaInteresse = new System.Windows.Forms.Button();
            this.btn_endiados = new System.Windows.Forms.Button();
            this.btn_cadastro_user = new System.Windows.Forms.Button();
            this.btn_revisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Artigos
            // 
            this.btn_Artigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Artigos.Location = new System.Drawing.Point(120, 129);
            this.btn_Artigos.Name = "btn_Artigos";
            this.btn_Artigos.Size = new System.Drawing.Size(99, 136);
            this.btn_Artigos.TabIndex = 1;
            this.btn_Artigos.Text = "Criar artigos";
            this.btn_Artigos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Artigos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Artigos.UseVisualStyleBackColor = true;
            this.btn_Artigos.Click += new System.EventHandler(this.btn_Artigos_Click);
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(183, 44);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(0, 24);
            this.label_user.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuário logado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data:";
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data.Location = new System.Drawing.Point(75, 79);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(0, 24);
            this.label_data.TabIndex = 6;
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(1100, 9);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo de usuario";
            // 
            // label_tipoUser
            // 
            this.label_tipoUser.AutoSize = true;
            this.label_tipoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tipoUser.Location = new System.Drawing.Point(183, 9);
            this.label_tipoUser.Name = "label_tipoUser";
            this.label_tipoUser.Size = new System.Drawing.Size(0, 24);
            this.label_tipoUser.TabIndex = 8;
            // 
            // btn_Status
            // 
            this.btn_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Status.Location = new System.Drawing.Point(236, 129);
            this.btn_Status.Name = "btn_Status";
            this.btn_Status.Size = new System.Drawing.Size(99, 136);
            this.btn_Status.TabIndex = 10;
            this.btn_Status.Text = "Status aprovação";
            this.btn_Status.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Status.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Status.UseVisualStyleBackColor = true;
            this.btn_Status.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_areaInteresse
            // 
            this.btn_areaInteresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_areaInteresse.Location = new System.Drawing.Point(12, 285);
            this.btn_areaInteresse.Name = "btn_areaInteresse";
            this.btn_areaInteresse.Size = new System.Drawing.Size(99, 136);
            this.btn_areaInteresse.TabIndex = 11;
            this.btn_areaInteresse.Text = "Área de interesse";
            this.btn_areaInteresse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_areaInteresse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_areaInteresse.UseVisualStyleBackColor = true;
            this.btn_areaInteresse.Visible = false;
            this.btn_areaInteresse.Click += new System.EventHandler(this.btn_areaInteresse_Click);
            // 
            // btn_endiados
            // 
            this.btn_endiados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_endiados.Location = new System.Drawing.Point(353, 129);
            this.btn_endiados.Name = "btn_endiados";
            this.btn_endiados.Size = new System.Drawing.Size(99, 136);
            this.btn_endiados.TabIndex = 12;
            this.btn_endiados.Text = "Enviados";
            this.btn_endiados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_endiados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_endiados.UseVisualStyleBackColor = true;
            this.btn_endiados.Click += new System.EventHandler(this.btn_endiados_Click);
            // 
            // btn_cadastro_user
            // 
            this.btn_cadastro_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastro_user.Image = global::Artigo.Properties.Resources.user_img;
            this.btn_cadastro_user.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cadastro_user.Location = new System.Drawing.Point(12, 128);
            this.btn_cadastro_user.Name = "btn_cadastro_user";
            this.btn_cadastro_user.Size = new System.Drawing.Size(99, 137);
            this.btn_cadastro_user.TabIndex = 0;
            this.btn_cadastro_user.Text = "Cadastrar Usuário";
            this.btn_cadastro_user.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cadastro_user.UseVisualStyleBackColor = true;
            this.btn_cadastro_user.Visible = false;
            this.btn_cadastro_user.Click += new System.EventHandler(this.btn_cadastro);
            // 
            // btn_revisar
            // 
            this.btn_revisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_revisar.Location = new System.Drawing.Point(472, 129);
            this.btn_revisar.Name = "btn_revisar";
            this.btn_revisar.Size = new System.Drawing.Size(99, 136);
            this.btn_revisar.TabIndex = 13;
            this.btn_revisar.Text = "Revisar artigos";
            this.btn_revisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_revisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_revisar.UseVisualStyleBackColor = true;
            this.btn_revisar.Visible = false;
            this.btn_revisar.Click += new System.EventHandler(this.btn_revisarArtigo);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 661);
            this.Controls.Add(this.btn_revisar);
            this.Controls.Add(this.btn_endiados);
            this.Controls.Add(this.btn_areaInteresse);
            this.Controls.Add(this.btn_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_tipoUser);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.btn_Artigos);
            this.Controls.Add(this.btn_cadastro_user);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastro_user;
        private System.Windows.Forms.Button btn_Artigos;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_tipoUser;
        private System.Windows.Forms.Button btn_Status;
        private System.Windows.Forms.Button btn_areaInteresse;
        private System.Windows.Forms.Button btn_endiados;
        private System.Windows.Forms.Button btn_revisar;
    }
}

