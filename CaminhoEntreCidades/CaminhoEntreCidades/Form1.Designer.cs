namespace CaminhoEntreCidades
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbxOrigem = new System.Windows.Forms.ComboBox();
            this.pbMapa = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numCusto = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluirCaminho = new System.Windows.Forms.Button();
            this.btnAlterarCaminho = new System.Windows.Forms.Button();
            this.btnExibirCaminho = new System.Windows.Forms.Button();
            this.btnIncluirCaminho = new System.Windows.Forms.Button();
            this.numTempo = new System.Windows.Forms.NumericUpDown();
            this.numDistancia = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnExcluirCidade = new System.Windows.Forms.Button();
            this.btnAlterarCidade = new System.Windows.Forms.Button();
            this.btnExibirCidade = new System.Windows.Forms.Button();
            this.btnIncluirCidade = new System.Windows.Forms.Button();
            this.numYCidade = new System.Windows.Forms.NumericUpDown();
            this.numXCidade = new System.Windows.Forms.NumericUpDown();
            this.txtNomeCidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYCidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXCidade)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1176, 626);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbxDestino);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbxOrigem);
            this.tabPage1.Controls.Add(this.pbMapa);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.numCusto);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnExcluirCaminho);
            this.tabPage1.Controls.Add(this.btnAlterarCaminho);
            this.tabPage1.Controls.Add(this.btnExibirCaminho);
            this.tabPage1.Controls.Add(this.btnIncluirCaminho);
            this.tabPage1.Controls.Add(this.numTempo);
            this.tabPage1.Controls.Add(this.numDistancia);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.btnExcluirCidade);
            this.tabPage1.Controls.Add(this.btnAlterarCidade);
            this.tabPage1.Controls.Add(this.btnExibirCidade);
            this.tabPage1.Controls.Add(this.btnIncluirCidade);
            this.tabPage1.Controls.Add(this.numYCidade);
            this.tabPage1.Controls.Add(this.numXCidade);
            this.tabPage1.Controls.Add(this.txtNomeCidade);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1168, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbxOrigem
            // 
            this.cbxOrigem.FormattingEnabled = true;
            this.cbxOrigem.Location = new System.Drawing.Point(29, 258);
            this.cbxOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.cbxOrigem.Name = "cbxOrigem";
            this.cbxOrigem.Size = new System.Drawing.Size(160, 24);
            this.cbxOrigem.TabIndex = 50;
            // 
            // pbMapa
            // 
            this.pbMapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMapa.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbMapa.InitialImage")));
            this.pbMapa.Location = new System.Drawing.Point(516, 28);
            this.pbMapa.Margin = new System.Windows.Forms.Padding(4);
            this.pbMapa.Name = "pbMapa";
            this.pbMapa.Size = new System.Drawing.Size(641, 443);
            this.pbMapa.TabIndex = 49;
            this.pbMapa.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 377);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(439, 185);
            this.dataGridView1.TabIndex = 48;
            // 
            // numCusto
            // 
            this.numCusto.Location = new System.Drawing.Point(321, 309);
            this.numCusto.Margin = new System.Windows.Forms.Padding(4);
            this.numCusto.Name = "numCusto";
            this.numCusto.Size = new System.Drawing.Size(107, 22);
            this.numCusto.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 295);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Custo";
            // 
            // btnExcluirCaminho
            // 
            this.btnExcluirCaminho.Location = new System.Drawing.Point(136, 341);
            this.btnExcluirCaminho.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirCaminho.Name = "btnExcluirCaminho";
            this.btnExcluirCaminho.Size = new System.Drawing.Size(100, 28);
            this.btnExcluirCaminho.TabIndex = 45;
            this.btnExcluirCaminho.Text = "Excluir";
            this.btnExcluirCaminho.UseVisualStyleBackColor = true;
            // 
            // btnAlterarCaminho
            // 
            this.btnAlterarCaminho.Location = new System.Drawing.Point(247, 341);
            this.btnAlterarCaminho.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterarCaminho.Name = "btnAlterarCaminho";
            this.btnAlterarCaminho.Size = new System.Drawing.Size(100, 28);
            this.btnAlterarCaminho.TabIndex = 44;
            this.btnAlterarCaminho.Text = "Alterar";
            this.btnAlterarCaminho.UseVisualStyleBackColor = true;
            // 
            // btnExibirCaminho
            // 
            this.btnExibirCaminho.Location = new System.Drawing.Point(365, 341);
            this.btnExibirCaminho.Margin = new System.Windows.Forms.Padding(4);
            this.btnExibirCaminho.Name = "btnExibirCaminho";
            this.btnExibirCaminho.Size = new System.Drawing.Size(100, 28);
            this.btnExibirCaminho.TabIndex = 43;
            this.btnExibirCaminho.Text = "Exibir";
            this.btnExibirCaminho.UseVisualStyleBackColor = true;
            // 
            // btnIncluirCaminho
            // 
            this.btnIncluirCaminho.Location = new System.Drawing.Point(28, 341);
            this.btnIncluirCaminho.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluirCaminho.Name = "btnIncluirCaminho";
            this.btnIncluirCaminho.Size = new System.Drawing.Size(100, 28);
            this.btnIncluirCaminho.TabIndex = 42;
            this.btnIncluirCaminho.Text = "Incluir";
            this.btnIncluirCaminho.UseVisualStyleBackColor = true;
            // 
            // numTempo
            // 
            this.numTempo.Location = new System.Drawing.Point(172, 309);
            this.numTempo.Margin = new System.Windows.Forms.Padding(4);
            this.numTempo.Name = "numTempo";
            this.numTempo.Size = new System.Drawing.Size(107, 22);
            this.numTempo.TabIndex = 41;
            // 
            // numDistancia
            // 
            this.numDistancia.Location = new System.Drawing.Point(29, 309);
            this.numDistancia.Margin = new System.Windows.Forms.Padding(4);
            this.numDistancia.Name = "numDistancia";
            this.numDistancia.Size = new System.Drawing.Size(107, 22);
            this.numDistancia.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 295);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Distância";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(168, 295);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "Tempo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 239);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Cidade Origem";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 198);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 36);
            this.label12.TabIndex = 35;
            this.label12.Text = "Caminhos";
            // 
            // btnExcluirCidade
            // 
            this.btnExcluirCidade.Location = new System.Drawing.Point(137, 142);
            this.btnExcluirCidade.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirCidade.Name = "btnExcluirCidade";
            this.btnExcluirCidade.Size = new System.Drawing.Size(100, 28);
            this.btnExcluirCidade.TabIndex = 34;
            this.btnExcluirCidade.Text = "Excluir";
            this.btnExcluirCidade.UseVisualStyleBackColor = true;
            // 
            // btnAlterarCidade
            // 
            this.btnAlterarCidade.Location = new System.Drawing.Point(248, 142);
            this.btnAlterarCidade.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterarCidade.Name = "btnAlterarCidade";
            this.btnAlterarCidade.Size = new System.Drawing.Size(100, 28);
            this.btnAlterarCidade.TabIndex = 33;
            this.btnAlterarCidade.Text = "Alterar";
            this.btnAlterarCidade.UseVisualStyleBackColor = true;
            // 
            // btnExibirCidade
            // 
            this.btnExibirCidade.Location = new System.Drawing.Point(367, 142);
            this.btnExibirCidade.Margin = new System.Windows.Forms.Padding(4);
            this.btnExibirCidade.Name = "btnExibirCidade";
            this.btnExibirCidade.Size = new System.Drawing.Size(100, 28);
            this.btnExibirCidade.TabIndex = 32;
            this.btnExibirCidade.Text = "Exibir";
            this.btnExibirCidade.UseVisualStyleBackColor = true;
            // 
            // btnIncluirCidade
            // 
            this.btnIncluirCidade.Location = new System.Drawing.Point(27, 142);
            this.btnIncluirCidade.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluirCidade.Name = "btnIncluirCidade";
            this.btnIncluirCidade.Size = new System.Drawing.Size(100, 28);
            this.btnIncluirCidade.TabIndex = 31;
            this.btnIncluirCidade.Text = "Incluir";
            this.btnIncluirCidade.UseVisualStyleBackColor = true;
            // 
            // numYCidade
            // 
            this.numYCidade.DecimalPlaces = 4;
            this.numYCidade.Location = new System.Drawing.Point(367, 84);
            this.numYCidade.Margin = new System.Windows.Forms.Padding(4);
            this.numYCidade.Name = "numYCidade";
            this.numYCidade.Size = new System.Drawing.Size(107, 22);
            this.numYCidade.TabIndex = 30;
            // 
            // numXCidade
            // 
            this.numXCidade.DecimalPlaces = 4;
            this.numXCidade.Location = new System.Drawing.Point(241, 82);
            this.numXCidade.Margin = new System.Windows.Forms.Padding(4);
            this.numXCidade.Name = "numXCidade";
            this.numXCidade.Size = new System.Drawing.Size(107, 22);
            this.numXCidade.TabIndex = 29;
            // 
            // txtNomeCidade
            // 
            this.txtNomeCidade.Location = new System.Drawing.Point(27, 84);
            this.txtNomeCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCidade.MaxLength = 15;
            this.txtNomeCidade.Name = "txtNomeCidade";
            this.txtNomeCidade.Size = new System.Drawing.Size(183, 22);
            this.txtNomeCidade.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(237, 63);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "X";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(363, 62);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Y";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 59);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 18);
            this.label15.TabIndex = 25;
            this.label15.Text = "Nome";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 17);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 36);
            this.label16.TabIndex = 24;
            this.label16.Text = "Cidade";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1168, 597);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Árvore";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1157, 564);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // cbxDestino
            // 
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Location = new System.Drawing.Point(230, 258);
            this.cbxDestino.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(160, 24);
            this.cbxDestino.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Cidade Destino";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 641);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYCidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXCidade)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExcluirCaminho;
        private System.Windows.Forms.Button btnAlterarCaminho;
        private System.Windows.Forms.Button btnExibirCaminho;
        private System.Windows.Forms.Button btnIncluirCaminho;
        private System.Windows.Forms.NumericUpDown numTempo;
        private System.Windows.Forms.NumericUpDown numDistancia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnExcluirCidade;
        private System.Windows.Forms.Button btnAlterarCidade;
        private System.Windows.Forms.Button btnExibirCidade;
        private System.Windows.Forms.Button btnIncluirCidade;
        private System.Windows.Forms.NumericUpDown numYCidade;
        private System.Windows.Forms.NumericUpDown numXCidade;
        private System.Windows.Forms.TextBox txtNomeCidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numCusto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbMapa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbxOrigem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxDestino;
        private System.Windows.Forms.Label label2;
    }
}

