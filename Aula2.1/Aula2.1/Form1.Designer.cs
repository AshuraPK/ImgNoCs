namespace Aula2._1
{
    partial class Form_img
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_img));
            this.cad_Filmes = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.genero = new System.Windows.Forms.Label();
            this.ano = new System.Windows.Forms.Label();
            this.avaliacao = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox_ano = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8_cadastrado = new System.Windows.Forms.Label();
            this.button_cadast = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.titulo_baixo = new System.Windows.Forms.Label();
            this.genero_2 = new System.Windows.Forms.Label();
            this.ano_filme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cad_Filmes
            // 
            this.cad_Filmes.AutoSize = true;
            this.cad_Filmes.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cad_Filmes.Location = new System.Drawing.Point(318, 9);
            this.cad_Filmes.Name = "cad_Filmes";
            this.cad_Filmes.Size = new System.Drawing.Size(211, 28);
            this.cad_Filmes.TabIndex = 0;
            this.cad_Filmes.Text = "Cadastro de Filmes";
            this.cad_Filmes.Click += new System.EventHandler(this.label1_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(60, 99);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(40, 16);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "Titulo";
            // 
            // genero
            // 
            this.genero.AutoSize = true;
            this.genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genero.Location = new System.Drawing.Point(60, 139);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(52, 16);
            this.genero.TabIndex = 2;
            this.genero.Text = "Genero";
            // 
            // ano
            // 
            this.ano.AutoSize = true;
            this.ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ano.Location = new System.Drawing.Point(60, 175);
            this.ano.Name = "ano";
            this.ano.Size = new System.Drawing.Size(31, 16);
            this.ano.TabIndex = 3;
            this.ano.Text = "Ano";
            // 
            // avaliacao
            // 
            this.avaliacao.AutoSize = true;
            this.avaliacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avaliacao.Location = new System.Drawing.Point(60, 214);
            this.avaliacao.Name = "avaliacao";
            this.avaliacao.Size = new System.Drawing.Size(68, 16);
            this.avaliacao.TabIndex = 4;
            this.avaliacao.Text = "Avaliação";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 214);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(57, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_ano
            // 
            this.textBox_ano.Location = new System.Drawing.Point(97, 175);
            this.textBox_ano.Name = "textBox_ano";
            this.textBox_ano.Size = new System.Drawing.Size(130, 20);
            this.textBox_ano.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(118, 138);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(160, 20);
            this.textBox4.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(344, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label8_cadastrado
            // 
            this.label8_cadastrado.AutoSize = true;
            this.label8_cadastrado.BackColor = System.Drawing.SystemColors.Window;
            this.label8_cadastrado.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8_cadastrado.Location = new System.Drawing.Point(458, 233);
            this.label8_cadastrado.Name = "label8_cadastrado";
            this.label8_cadastrado.Size = new System.Drawing.Size(184, 38);
            this.label8_cadastrado.TabIndex = 13;
            this.label8_cadastrado.Text = "Cadastrado!";
            this.label8_cadastrado.Visible = false;
            this.label8_cadastrado.Click += new System.EventHandler(this.label8_cadastrado_Click);
            // 
            // button_cadast
            // 
            this.button_cadast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cadast.Location = new System.Drawing.Point(190, 283);
            this.button_cadast.Name = "button_cadast";
            this.button_cadast.Size = new System.Drawing.Size(75, 23);
            this.button_cadast.TabIndex = 14;
            this.button_cadast.Text = "Cadastro";
            this.button_cadast.UseVisualStyleBackColor = true;
            this.button_cadast.Click += new System.EventHandler(this.button_cadast_Click_1);
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(52, 283);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(75, 23);
            this.button_limpar.TabIndex = 15;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Avaliação";
            // 
            // titulo_baixo
            // 
            this.titulo_baixo.AutoSize = true;
            this.titulo_baixo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_baixo.Location = new System.Drawing.Point(539, 93);
            this.titulo_baixo.Name = "titulo_baixo";
            this.titulo_baixo.Size = new System.Drawing.Size(0, 19);
            this.titulo_baixo.TabIndex = 17;
            this.titulo_baixo.Click += new System.EventHandler(this.titulo_baixo_Click);
            // 
            // genero_2
            // 
            this.genero_2.AutoSize = true;
            this.genero_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genero_2.Location = new System.Drawing.Point(710, 394);
            this.genero_2.Name = "genero_2";
            this.genero_2.Size = new System.Drawing.Size(0, 16);
            this.genero_2.TabIndex = 18;
            this.genero_2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ano_filme
            // 
            this.ano_filme.AutoSize = true;
            this.ano_filme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ano_filme.Location = new System.Drawing.Point(530, 394);
            this.ano_filme.Name = "ano_filme";
            this.ano_filme.Size = new System.Drawing.Size(0, 16);
            this.ano_filme.TabIndex = 19;
            // 
            // Form_img
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ano_filme);
            this.Controls.Add(this.genero_2);
            this.Controls.Add(this.titulo_baixo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_cadast);
            this.Controls.Add(this.label8_cadastrado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox_ano);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.avaliacao);
            this.Controls.Add(this.ano);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.cad_Filmes);
            this.Name = "Form_img";
            this.Text = "Filme Img";
            this.Load += new System.EventHandler(this.Form_img_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cad_Filmes;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label genero;
        private System.Windows.Forms.Label ano;
        private System.Windows.Forms.Label avaliacao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox_ano;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8_cadastrado;
        private System.Windows.Forms.Button button_cadast;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titulo_baixo;
        private System.Windows.Forms.Label genero_2;
        private System.Windows.Forms.Label ano_filme;
    }
}

