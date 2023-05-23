namespace Login
{
    partial class F_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Login));
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_ContraseñaLogin = new System.Windows.Forms.TextBox();
            this.cb_rolLogin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Location = new System.Drawing.Point(139, 314);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(251, 26);
            this.txtUsuarioLogin.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_ContraseñaLogin
            // 
            this.txt_ContraseñaLogin.Location = new System.Drawing.Point(139, 401);
            this.txt_ContraseñaLogin.Name = "txt_ContraseñaLogin";
            this.txt_ContraseñaLogin.Size = new System.Drawing.Size(251, 26);
            this.txt_ContraseñaLogin.TabIndex = 2;
            // 
            // cb_rolLogin
            // 
            this.cb_rolLogin.Font = new System.Drawing.Font("Leelawadee UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_rolLogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cb_rolLogin.FormattingEnabled = true;
            this.cb_rolLogin.Items.AddRange(new object[] {
            "Médico",
            "Recepcionista",
            "Administrador"});
            this.cb_rolLogin.Location = new System.Drawing.Point(139, 229);
            this.cb_rolLogin.Name = "cb_rolLogin";
            this.cb_rolLogin.Size = new System.Drawing.Size(251, 29);
            this.cb_rolLogin.TabIndex = 3;
            this.cb_rolLogin.Text = "Seleccione ocupación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(254)))));
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(209, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(254)))));
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(227, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "usuario";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(254)))));
            this.btnIngresar.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIngresar.Location = new System.Drawing.Point(168, 492);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(188, 54);
            this.btnIngresar.TabIndex = 25;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(538, 697);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_rolLogin);
            this.Controls.Add(this.txt_ContraseñaLogin);
            this.Controls.Add(this.txtUsuarioLogin);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Login";
            this.Load += new System.EventHandler(this.F_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_ContraseñaLogin;
        private System.Windows.Forms.ComboBox cb_rolLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresar;
    }
}

