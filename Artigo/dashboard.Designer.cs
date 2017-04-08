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
            this.btn_cadastro_user = new System.Windows.Forms.Button();
            this.btn_Artigos = new System.Windows.Forms.Button();
            this.label_user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cadastro_user
            // 
            this.btn_cadastro_user.Image = global::Artigo.Properties.Resources.user_img;
            this.btn_cadastro_user.Location = new System.Drawing.Point(16, 113);
            this.btn_cadastro_user.Name = "btn_cadastro_user";
            this.btn_cadastro_user.Size = new System.Drawing.Size(140, 161);
            this.btn_cadastro_user.TabIndex = 0;
            this.btn_cadastro_user.Text = "Cadastrar Usuário";
            this.btn_cadastro_user.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cadastro_user.UseVisualStyleBackColor = true;
            this.btn_cadastro_user.Visible = false;
            this.btn_cadastro_user.Click += new System.EventHandler(this.btn_cadastro);
            // 
            // btn_Artigos
            // 
            this.btn_Artigos.Location = new System.Drawing.Point(162, 113);
            this.btn_Artigos.Name = "btn_Artigos";
            this.btn_Artigos.Size = new System.Drawing.Size(146, 160);
            this.btn_Artigos.TabIndex = 1;
            this.btn_Artigos.Text = "Artigos";
            this.btn_Artigos.UseVisualStyleBackColor = true;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(183, 25);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(0, 24);
            this.label_user.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuário Logado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data:";
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data.Location = new System.Drawing.Point(75, 60);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(0, 24);
            this.label_data.TabIndex = 6;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
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
    }
}

