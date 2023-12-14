
namespace Projeto_Turismo
{
    partial class Frm_tur
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
            this.dateTimePicker_1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_2 = new System.Windows.Forms.DateTimePicker();
            this.Lbl_destino = new System.Windows.Forms.Label();
            this.Lbl_origem = new System.Windows.Forms.Label();
            this.Chk2 = new System.Windows.Forms.CheckBox();
            this.Chk1 = new System.Windows.Forms.CheckBox();
            this.Lbl_encontre = new System.Windows.Forms.Label();
            this.pic_nacionais = new System.Windows.Forms.PictureBox();
            this.pic_inter = new System.Windows.Forms.PictureBox();
            this.Lbl_nacionais = new System.Windows.Forms.Label();
            this.Lbl_inter = new System.Windows.Forms.Label();
            this.dateTimePicker_3 = new System.Windows.Forms.DateTimePicker();
            this.Cb_destino = new System.Windows.Forms.ComboBox();
            this.Cb_origem = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.Lbl_v1 = new System.Windows.Forms.Label();
            this.Lbl_v2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Lbl_linhas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nacionais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_inter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_1
            // 
            this.dateTimePicker_1.Location = new System.Drawing.Point(612, 292);
            this.dateTimePicker_1.Name = "dateTimePicker_1";
            this.dateTimePicker_1.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker_1.TabIndex = 15;
            // 
            // dateTimePicker_2
            // 
            this.dateTimePicker_2.Location = new System.Drawing.Point(921, 295);
            this.dateTimePicker_2.Name = "dateTimePicker_2";
            this.dateTimePicker_2.Size = new System.Drawing.Size(232, 20);
            this.dateTimePicker_2.TabIndex = 14;
            // 
            // Lbl_destino
            // 
            this.Lbl_destino.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_destino.ForeColor = System.Drawing.Color.Black;
            this.Lbl_destino.Location = new System.Drawing.Point(292, 228);
            this.Lbl_destino.Name = "Lbl_destino";
            this.Lbl_destino.Size = new System.Drawing.Size(205, 27);
            this.Lbl_destino.TabIndex = 13;
            this.Lbl_destino.Text = "Informe seu Destino:";
            // 
            // Lbl_origem
            // 
            this.Lbl_origem.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_origem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_origem.ForeColor = System.Drawing.Color.Black;
            this.Lbl_origem.Location = new System.Drawing.Point(23, 228);
            this.Lbl_origem.Name = "Lbl_origem";
            this.Lbl_origem.Size = new System.Drawing.Size(231, 27);
            this.Lbl_origem.TabIndex = 12;
            this.Lbl_origem.Text = "Informe sua Origem:";
            // 
            // Chk2
            // 
            this.Chk2.BackColor = System.Drawing.Color.Transparent;
            this.Chk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk2.ForeColor = System.Drawing.Color.HotPink;
            this.Chk2.Location = new System.Drawing.Point(1030, 210);
            this.Chk2.Name = "Chk2";
            this.Chk2.Size = new System.Drawing.Size(144, 26);
            this.Chk2.TabIndex = 11;
            this.Chk2.Text = "Ida e Volta";
            this.Chk2.UseVisualStyleBackColor = false;
            this.Chk2.CheckedChanged += new System.EventHandler(this.Chk2_CheckedChanged);
            // 
            // Chk1
            // 
            this.Chk1.BackColor = System.Drawing.Color.Transparent;
            this.Chk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk1.ForeColor = System.Drawing.Color.HotPink;
            this.Chk1.Location = new System.Drawing.Point(613, 209);
            this.Chk1.Name = "Chk1";
            this.Chk1.Size = new System.Drawing.Size(168, 24);
            this.Chk1.TabIndex = 10;
            this.Chk1.Text = "Somente Ida";
            this.Chk1.UseVisualStyleBackColor = false;
            this.Chk1.CheckedChanged += new System.EventHandler(this.Chk1_CheckedChanged);
            // 
            // Lbl_encontre
            // 
            this.Lbl_encontre.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_encontre.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_encontre.ForeColor = System.Drawing.Color.Pink;
            this.Lbl_encontre.Location = new System.Drawing.Point(52, 44);
            this.Lbl_encontre.Name = "Lbl_encontre";
            this.Lbl_encontre.Size = new System.Drawing.Size(616, 96);
            this.Lbl_encontre.TabIndex = 9;
            this.Lbl_encontre.Text = "Encontre os Melhores Preços e Boa Viagem!";
            // 
            // pic_nacionais
            // 
            this.pic_nacionais.Image = global::Projeto_Turismo.Properties.Resources.tnaci;
            this.pic_nacionais.Location = new System.Drawing.Point(67, 565);
            this.pic_nacionais.Name = "pic_nacionais";
            this.pic_nacionais.Size = new System.Drawing.Size(430, 244);
            this.pic_nacionais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_nacionais.TabIndex = 18;
            this.pic_nacionais.TabStop = false;
            // 
            // pic_inter
            // 
            this.pic_inter.Image = global::Projeto_Turismo.Properties.Resources._int;
            this.pic_inter.Location = new System.Drawing.Point(562, 565);
            this.pic_inter.Name = "pic_inter";
            this.pic_inter.Size = new System.Drawing.Size(441, 244);
            this.pic_inter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_inter.TabIndex = 19;
            this.pic_inter.TabStop = false;
            // 
            // Lbl_nacionais
            // 
            this.Lbl_nacionais.AutoSize = true;
            this.Lbl_nacionais.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_nacionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nacionais.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Lbl_nacionais.Location = new System.Drawing.Point(189, 520);
            this.Lbl_nacionais.Name = "Lbl_nacionais";
            this.Lbl_nacionais.Size = new System.Drawing.Size(188, 24);
            this.Lbl_nacionais.TabIndex = 20;
            this.Lbl_nacionais.Text = "Destinos Nacionais";
            this.Lbl_nacionais.Click += new System.EventHandler(this.label4_Click);
            // 
            // Lbl_inter
            // 
            this.Lbl_inter.AutoSize = true;
            this.Lbl_inter.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_inter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_inter.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Lbl_inter.Location = new System.Drawing.Point(642, 520);
            this.Lbl_inter.Name = "Lbl_inter";
            this.Lbl_inter.Size = new System.Drawing.Size(226, 24);
            this.Lbl_inter.TabIndex = 21;
            this.Lbl_inter.Text = "Destinos Internacionais";
            this.Lbl_inter.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateTimePicker_3
            // 
            this.dateTimePicker_3.Location = new System.Drawing.Point(1159, 295);
            this.dateTimePicker_3.Name = "dateTimePicker_3";
            this.dateTimePicker_3.Size = new System.Drawing.Size(232, 20);
            this.dateTimePicker_3.TabIndex = 22;
            // 
            // Cb_destino
            // 
            this.Cb_destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_destino.FormattingEnabled = true;
            this.Cb_destino.Items.AddRange(new object[] {
            "Foz do Iguaçu _ Parana",
            "Bonito_MS",
            "Rio de janeiro",
            "Fernando de Noronha",
            "Las Vegas",
            "Dubai",
            "Grecia",
            "Veneza"});
            this.Cb_destino.Location = new System.Drawing.Point(296, 287);
            this.Cb_destino.Name = "Cb_destino";
            this.Cb_destino.Size = new System.Drawing.Size(201, 28);
            this.Cb_destino.TabIndex = 23;
            this.Cb_destino.SelectedIndexChanged += new System.EventHandler(this.Cb_destino_SelectedIndexChanged);
            // 
            // Cb_origem
            // 
            this.Cb_origem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_origem.FormattingEnabled = true;
            this.Cb_origem.Items.AddRange(new object[] {
            "São Paulo - (Guarulhos)"});
            this.Cb_origem.Location = new System.Drawing.Point(27, 288);
            this.Cb_origem.Name = "Cb_origem";
            this.Cb_origem.Size = new System.Drawing.Size(211, 28);
            this.Cb_origem.TabIndex = 24;
            this.Cb_origem.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(772, 213);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(33, 20);
            this.numericUpDown1.TabIndex = 26;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(1168, 215);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(33, 20);
            this.numericUpDown2.TabIndex = 27;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // Lbl_v1
            // 
            this.Lbl_v1.AutoSize = true;
            this.Lbl_v1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_v1.Location = new System.Drawing.Point(608, 250);
            this.Lbl_v1.Name = "Lbl_v1";
            this.Lbl_v1.Size = new System.Drawing.Size(233, 25);
            this.Lbl_v1.TabIndex = 28;
            this.Lbl_v1.Text = "Valor das passagens";
            this.Lbl_v1.Visible = false;
            // 
            // Lbl_v2
            // 
            this.Lbl_v2.AutoSize = true;
            this.Lbl_v2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_v2.Location = new System.Drawing.Point(1039, 251);
            this.Lbl_v2.Name = "Lbl_v2";
            this.Lbl_v2.Size = new System.Drawing.Size(204, 24);
            this.Lbl_v2.TabIndex = 29;
            this.Lbl_v2.Text = "Valor das passagens";
            this.Lbl_v2.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(1071, 565);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(320, 244);
            this.listBox1.TabIndex = 30;
            // 
            // Lbl_linhas
            // 
            this.Lbl_linhas.AutoSize = true;
            this.Lbl_linhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_linhas.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Lbl_linhas.Location = new System.Drawing.Point(1174, 520);
            this.Lbl_linhas.Name = "Lbl_linhas";
            this.Lbl_linhas.Size = new System.Drawing.Size(0, 24);
            this.Lbl_linhas.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(1134, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Linhas Aéreas";
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_fechar.Location = new System.Drawing.Point(1343, 44);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(48, 47);
            this.Btn_fechar.TabIndex = 33;
            this.Btn_fechar.Text = "x";
            this.Btn_fechar.UseVisualStyleBackColor = false;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.HotPink;
            this.radioButton1.Location = new System.Drawing.Point(1259, 205);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(132, 33);
            this.radioButton1.TabIndex = 34;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Comprar";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Frm_tur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Projeto_Turismo.Properties.Resources.turis;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1444, 881);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Btn_fechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_linhas);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Lbl_v2);
            this.Controls.Add(this.Lbl_v1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Cb_origem);
            this.Controls.Add(this.Cb_destino);
            this.Controls.Add(this.dateTimePicker_3);
            this.Controls.Add(this.Lbl_inter);
            this.Controls.Add(this.Lbl_nacionais);
            this.Controls.Add(this.pic_inter);
            this.Controls.Add(this.pic_nacionais);
            this.Controls.Add(this.dateTimePicker_1);
            this.Controls.Add(this.dateTimePicker_2);
            this.Controls.Add(this.Lbl_destino);
            this.Controls.Add(this.Lbl_origem);
            this.Controls.Add(this.Chk2);
            this.Controls.Add(this.Chk1);
            this.Controls.Add(this.Lbl_encontre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_tur";
            this.Text = "Turismo";
            this.Load += new System.EventHandler(this.Frm_tur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_nacionais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_inter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker_1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_2;
        private System.Windows.Forms.Label Lbl_destino;
        private System.Windows.Forms.Label Lbl_origem;
        private System.Windows.Forms.CheckBox Chk2;
        private System.Windows.Forms.CheckBox Chk1;
        private System.Windows.Forms.Label Lbl_encontre;
        private System.Windows.Forms.PictureBox pic_nacionais;
        private System.Windows.Forms.PictureBox pic_inter;
        private System.Windows.Forms.Label Lbl_nacionais;
        private System.Windows.Forms.Label Lbl_inter;
        private System.Windows.Forms.DateTimePicker dateTimePicker_3;
        private System.Windows.Forms.ComboBox Cb_destino;
        private System.Windows.Forms.ComboBox Cb_origem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label Lbl_v1;
        private System.Windows.Forms.Label Lbl_v2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Lbl_linhas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_fechar;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

