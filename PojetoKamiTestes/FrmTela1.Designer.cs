namespace PojetoKamiTestes
{
    partial class Frm_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lOJAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_criarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_pedidoAndto = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_financeiro = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_estoque = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUÁRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_funcionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_resetSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sair = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.msk_usuario = new System.Windows.Forms.MaskedTextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_novaSenha = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlText;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOJAToolStripMenuItem,
            this.uSUÁRIOToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(710, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lOJAToolStripMenuItem
            // 
            this.lOJAToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.lOJAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_criarPedido,
            this.btn_pedidoAndto,
            this.btn_financeiro,
            this.btn_estoque});
            this.lOJAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOJAToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lOJAToolStripMenuItem.Name = "lOJAToolStripMenuItem";
            this.lOJAToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.lOJAToolStripMenuItem.Text = "LOJA";
            // 
            // btn_criarPedido
            // 
            this.btn_criarPedido.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_criarPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_criarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btn_criarPedido.Image")));
            this.btn_criarPedido.Name = "btn_criarPedido";
            this.btn_criarPedido.Size = new System.Drawing.Size(215, 36);
            this.btn_criarPedido.Text = "Criar Pedido";
            // 
            // btn_pedidoAndto
            // 
            this.btn_pedidoAndto.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_pedidoAndto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_pedidoAndto.Image = ((System.Drawing.Image)(resources.GetObject("btn_pedidoAndto.Image")));
            this.btn_pedidoAndto.Name = "btn_pedidoAndto";
            this.btn_pedidoAndto.Size = new System.Drawing.Size(215, 36);
            this.btn_pedidoAndto.Text = "Pedido em Andamento";
            // 
            // btn_financeiro
            // 
            this.btn_financeiro.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_financeiro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_financeiro.Image = ((System.Drawing.Image)(resources.GetObject("btn_financeiro.Image")));
            this.btn_financeiro.Name = "btn_financeiro";
            this.btn_financeiro.Size = new System.Drawing.Size(215, 36);
            this.btn_financeiro.Text = "Financeiro";
            // 
            // btn_estoque
            // 
            this.btn_estoque.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_estoque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_estoque.Image = ((System.Drawing.Image)(resources.GetObject("btn_estoque.Image")));
            this.btn_estoque.Name = "btn_estoque";
            this.btn_estoque.Size = new System.Drawing.Size(215, 36);
            this.btn_estoque.Text = "Estoque";
            // 
            // uSUÁRIOToolStripMenuItem
            // 
            this.uSUÁRIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_funcionarios,
            this.btn_resetSenha});
            this.uSUÁRIOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uSUÁRIOToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uSUÁRIOToolStripMenuItem.Name = "uSUÁRIOToolStripMenuItem";
            this.uSUÁRIOToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.uSUÁRIOToolStripMenuItem.Text = "USUÁRIO";
            // 
            // btn_funcionarios
            // 
            this.btn_funcionarios.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_funcionarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_funcionarios.Image = ((System.Drawing.Image)(resources.GetObject("btn_funcionarios.Image")));
            this.btn_funcionarios.Name = "btn_funcionarios";
            this.btn_funcionarios.Size = new System.Drawing.Size(250, 22);
            this.btn_funcionarios.Text = "Gerenciamento de Funcionários";
            // 
            // btn_resetSenha
            // 
            this.btn_resetSenha.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_resetSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_resetSenha.Image = ((System.Drawing.Image)(resources.GetObject("btn_resetSenha.Image")));
            this.btn_resetSenha.Name = "btn_resetSenha";
            this.btn_resetSenha.Size = new System.Drawing.Size(250, 22);
            this.btn_resetSenha.Text = "Reset de Senha";
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sAIRToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sAIRToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            // 
            // sair
            // 
            this.sair.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("sair.ImageStream")));
            this.sair.TransparentColor = System.Drawing.Color.Transparent;
            this.sair.Images.SetKeyName(0, "sair.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(201, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(215, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // msk_usuario
            // 
            this.msk_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk_usuario.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msk_usuario.Location = new System.Drawing.Point(312, 225);
            this.msk_usuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.msk_usuario.Mask = "000,000,000-00";
            this.msk_usuario.Name = "msk_usuario";
            this.msk_usuario.Size = new System.Drawing.Size(163, 23);
            this.msk_usuario.TabIndex = 3;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(312, 277);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_senha.MaxLength = 8;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(163, 23);
            this.txt_senha.TabIndex = 4;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_login.Location = new System.Drawing.Point(312, 336);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(163, 33);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "ENTRAR";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // btn_novaSenha
            // 
            this.btn_novaSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_novaSenha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_novaSenha.FlatAppearance.BorderSize = 0;
            this.btn_novaSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novaSenha.Location = new System.Drawing.Point(312, 378);
            this.btn_novaSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_novaSenha.Name = "btn_novaSenha";
            this.btn_novaSenha.Size = new System.Drawing.Size(163, 28);
            this.btn_novaSenha.TabIndex = 6;
            this.btn_novaSenha.Text = "Esqueci a senha";
            this.btn_novaSenha.UseVisualStyleBackColor = true;
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(710, 546);
            this.Controls.Add(this.btn_novaSenha);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.msk_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KAMI KAMI Yakissoba";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lOJAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_criarPedido;
        private System.Windows.Forms.ToolStripMenuItem btn_pedidoAndto;
        private System.Windows.Forms.ToolStripMenuItem btn_financeiro;
        private System.Windows.Forms.ToolStripMenuItem btn_estoque;
        private System.Windows.Forms.ToolStripMenuItem uSUÁRIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_funcionarios;
        private System.Windows.Forms.ToolStripMenuItem btn_resetSenha;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.ImageList sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox msk_usuario;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_novaSenha;
    }
}

