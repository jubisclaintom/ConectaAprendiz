namespace ConectaAprendiz
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnentrar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.logintext = new System.Windows.Forms.TextBox();
            this.pswdtext = new System.Windows.Forms.TextBox();
            this.hyperlink1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(530, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 102);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(530, 188);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 119);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnentrar
            // 
            this.btnentrar.Location = new System.Drawing.Point(640, 380);
            this.btnentrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(64, 27);
            this.btnentrar.TabIndex = 2;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = true;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click_1);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(732, 380);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(63, 27);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // logintext
            // 
            this.logintext.Location = new System.Drawing.Point(649, 106);
            this.logintext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logintext.Name = "logintext";
            this.logintext.Size = new System.Drawing.Size(174, 20);
            this.logintext.TabIndex = 4;
            // 
            // pswdtext
            // 
            this.pswdtext.Location = new System.Drawing.Point(649, 258);
            this.pswdtext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pswdtext.Name = "pswdtext";
            this.pswdtext.PasswordChar = '•';
            this.pswdtext.Size = new System.Drawing.Size(174, 20);
            this.pswdtext.TabIndex = 5;
            // 
            // hyperlink1
            // 
            this.hyperlink1.AutoSize = true;
            this.hyperlink1.LinkColor = System.Drawing.Color.DarkOrange;
            this.hyperlink1.Location = new System.Drawing.Point(686, 430);
            this.hyperlink1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hyperlink1.Name = "hyperlink1";
            this.hyperlink1.Size = new System.Drawing.Size(66, 13);
            this.hyperlink1.TabIndex = 6;
            this.hyperlink1.TabStop = true;
            this.hyperlink1.Text = "Cadastrar-se";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 414);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Conecta Aprendiz: Aprenda com Propósito, Conecte-se com Sucesso";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hyperlink1);
            this.Controls.Add(this.pswdtext);
            this.Controls.Add(this.logintext);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Login";
            this.Text = "ConectaAprendiz";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox logintext;
        private System.Windows.Forms.TextBox pswdtext;
        private System.Windows.Forms.LinkLabel hyperlink1;
        private System.Windows.Forms.Label label1;
    }
}

