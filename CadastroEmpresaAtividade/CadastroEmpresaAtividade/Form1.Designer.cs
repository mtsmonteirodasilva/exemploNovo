namespace CadastroEmpresaAtividade
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_cnpj = new System.Windows.Forms.TextBox();
            this.tx_nomeFantasia = new System.Windows.Forms.TextBox();
            this.cb_situacaoCadastral = new System.Windows.Forms.ComboBox();
            this.rd_simples = new System.Windows.Forms.RadioButton();
            this.rd_lucro = new System.Windows.Forms.RadioButton();
            this.rd_lucroReal = new System.Windows.Forms.RadioButton();
            this.ms_dataInicioAtividade = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ms_telefone = new System.Windows.Forms.MaskedTextBox();
            this.tx_capitalSocial = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rd_filial = new System.Windows.Forms.RadioButton();
            this.rd_matriz = new System.Windows.Forms.RadioButton();
            this.rd_grande = new System.Windows.Forms.RadioButton();
            this.rd_medio = new System.Windows.Forms.RadioButton();
            this.rd_pequeno = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_naturezaJuridica = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ms_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tx_cidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_bairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tx_rua = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tx_razaoSocial = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Mono", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razão social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome fantasia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Situação cadastral";
            // 
            // tx_cnpj
            // 
            this.tx_cnpj.Location = new System.Drawing.Point(66, 118);
            this.tx_cnpj.Name = "tx_cnpj";
            this.tx_cnpj.Size = new System.Drawing.Size(179, 20);
            this.tx_cnpj.TabIndex = 5;
            // 
            // tx_nomeFantasia
            // 
            this.tx_nomeFantasia.Location = new System.Drawing.Point(134, 142);
            this.tx_nomeFantasia.Name = "tx_nomeFantasia";
            this.tx_nomeFantasia.Size = new System.Drawing.Size(111, 20);
            this.tx_nomeFantasia.TabIndex = 6;
            // 
            // cb_situacaoCadastral
            // 
            this.cb_situacaoCadastral.FormattingEnabled = true;
            this.cb_situacaoCadastral.Items.AddRange(new object[] {
            "Ativa",
            "Nula",
            "Suspensa",
            "Inapta",
            "Baixada"});
            this.cb_situacaoCadastral.Location = new System.Drawing.Point(404, 143);
            this.cb_situacaoCadastral.Name = "cb_situacaoCadastral";
            this.cb_situacaoCadastral.Size = new System.Drawing.Size(121, 21);
            this.cb_situacaoCadastral.TabIndex = 8;
            // 
            // rd_simples
            // 
            this.rd_simples.AutoSize = true;
            this.rd_simples.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_simples.Location = new System.Drawing.Point(10, 44);
            this.rd_simples.Name = "rd_simples";
            this.rd_simples.Size = new System.Drawing.Size(111, 18);
            this.rd_simples.TabIndex = 9;
            this.rd_simples.TabStop = true;
            this.rd_simples.Text = "Simples nacional";
            this.rd_simples.UseVisualStyleBackColor = true;
            // 
            // rd_lucro
            // 
            this.rd_lucro.AutoSize = true;
            this.rd_lucro.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_lucro.Location = new System.Drawing.Point(10, 70);
            this.rd_lucro.Name = "rd_lucro";
            this.rd_lucro.Size = new System.Drawing.Size(111, 18);
            this.rd_lucro.TabIndex = 10;
            this.rd_lucro.TabStop = true;
            this.rd_lucro.Text = "Lucro presumido";
            this.rd_lucro.UseVisualStyleBackColor = true;
            // 
            // rd_lucroReal
            // 
            this.rd_lucroReal.AutoSize = true;
            this.rd_lucroReal.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_lucroReal.Location = new System.Drawing.Point(10, 93);
            this.rd_lucroReal.Name = "rd_lucroReal";
            this.rd_lucroReal.Size = new System.Drawing.Size(75, 18);
            this.rd_lucroReal.TabIndex = 11;
            this.rd_lucroReal.TabStop = true;
            this.rd_lucroReal.Text = "Lucro real";
            this.rd_lucroReal.UseVisualStyleBackColor = true;
            // 
            // ms_dataInicioAtividade
            // 
            this.ms_dataInicioAtividade.Location = new System.Drawing.Point(425, 168);
            this.ms_dataInicioAtividade.Mask = "00/00/0000";
            this.ms_dataInicioAtividade.Name = "ms_dataInicioAtividade";
            this.ms_dataInicioAtividade.Size = new System.Drawing.Size(100, 20);
            this.ms_dataInicioAtividade.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data inicio atividade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Telefone";
            // 
            // ms_telefone
            // 
            this.ms_telefone.Location = new System.Drawing.Point(98, 166);
            this.ms_telefone.Mask = "(00) 000000000";
            this.ms_telefone.Name = "ms_telefone";
            this.ms_telefone.Size = new System.Drawing.Size(147, 20);
            this.ms_telefone.TabIndex = 17;
            // 
            // tx_capitalSocial
            // 
            this.tx_capitalSocial.Location = new System.Drawing.Point(133, 192);
            this.tx_capitalSocial.Name = "tx_capitalSocial";
            this.tx_capitalSocial.Size = new System.Drawing.Size(111, 20);
            this.tx_capitalSocial.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Capital social";
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cb_estado.Location = new System.Drawing.Point(318, 191);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(207, 21);
            this.cb_estado.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(251, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Estado";
            // 
            // rd_filial
            // 
            this.rd_filial.AutoSize = true;
            this.rd_filial.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_filial.Location = new System.Drawing.Point(13, 49);
            this.rd_filial.Name = "rd_filial";
            this.rd_filial.Size = new System.Drawing.Size(49, 18);
            this.rd_filial.TabIndex = 23;
            this.rd_filial.TabStop = true;
            this.rd_filial.Text = "Filial";
            this.rd_filial.UseVisualStyleBackColor = true;
            // 
            // rd_matriz
            // 
            this.rd_matriz.AutoSize = true;
            this.rd_matriz.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_matriz.Location = new System.Drawing.Point(13, 25);
            this.rd_matriz.Name = "rd_matriz";
            this.rd_matriz.Size = new System.Drawing.Size(57, 18);
            this.rd_matriz.TabIndex = 22;
            this.rd_matriz.TabStop = true;
            this.rd_matriz.Text = "Matriz";
            this.rd_matriz.UseVisualStyleBackColor = true;
            // 
            // rd_grande
            // 
            this.rd_grande.AutoSize = true;
            this.rd_grande.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_grande.Location = new System.Drawing.Point(13, 74);
            this.rd_grande.Name = "rd_grande";
            this.rd_grande.Size = new System.Drawing.Size(63, 18);
            this.rd_grande.TabIndex = 27;
            this.rd_grande.TabStop = true;
            this.rd_grande.Text = "Grande";
            this.rd_grande.UseVisualStyleBackColor = true;
            // 
            // rd_medio
            // 
            this.rd_medio.AutoSize = true;
            this.rd_medio.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_medio.Location = new System.Drawing.Point(13, 51);
            this.rd_medio.Name = "rd_medio";
            this.rd_medio.Size = new System.Drawing.Size(58, 18);
            this.rd_medio.TabIndex = 26;
            this.rd_medio.TabStop = true;
            this.rd_medio.Text = "Medio";
            this.rd_medio.UseVisualStyleBackColor = true;
            // 
            // rd_pequeno
            // 
            this.rd_pequeno.AutoSize = true;
            this.rd_pequeno.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_pequeno.Location = new System.Drawing.Point(13, 25);
            this.rd_pequeno.Name = "rd_pequeno";
            this.rd_pequeno.Size = new System.Drawing.Size(71, 18);
            this.rd_pequeno.TabIndex = 25;
            this.rd_pequeno.TabStop = true;
            this.rd_pequeno.Text = "Pequeno";
            this.rd_pequeno.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 21);
            this.label13.TabIndex = 29;
            this.label13.Text = "Natureza juridica";
            // 
            // cb_naturezaJuridica
            // 
            this.cb_naturezaJuridica.FormattingEnabled = true;
            this.cb_naturezaJuridica.Items.AddRange(new object[] {
            "EI - Empresario Individual",
            "MEI - Microempreendedor Individual",
            "Sociedade Anonima"});
            this.cb_naturezaJuridica.Location = new System.Drawing.Point(163, 218);
            this.cb_naturezaJuridica.Name = "cb_naturezaJuridica";
            this.cb_naturezaJuridica.Size = new System.Drawing.Size(82, 21);
            this.cb_naturezaJuridica.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 270);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 21);
            this.label14.TabIndex = 31;
            this.label14.Text = "Nome";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(252, 270);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 21);
            this.label15.TabIndex = 32;
            this.label15.Text = "CPF";
            // 
            // ms_cpf
            // 
            this.ms_cpf.Location = new System.Drawing.Point(296, 270);
            this.ms_cpf.Mask = "000.000.000.00";
            this.ms_cpf.Name = "ms_cpf";
            this.ms_cpf.Size = new System.Drawing.Size(100, 20);
            this.ms_cpf.TabIndex = 33;
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(73, 270);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(172, 20);
            this.tx_nome.TabIndex = 34;
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Location = new System.Drawing.Point(601, 451);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(130, 23);
            this.bt_cadastrar.TabIndex = 35;
            this.bt_cadastrar.Text = "Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_simples);
            this.groupBox1.Controls.Add(this.rd_lucro);
            this.groupBox1.Controls.Add(this.rd_lucroReal);
            this.groupBox1.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(534, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 111);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regime tributario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rd_matriz);
            this.groupBox2.Controls.Add(this.rd_filial);
            this.groupBox2.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(531, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 77);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rd_pequeno);
            this.groupBox3.Controls.Add(this.rd_medio);
            this.groupBox3.Controls.Add(this.rd_grande);
            this.groupBox3.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(531, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 118);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Porte da empresa";
            // 
            // tx_cidade
            // 
            this.tx_cidade.Location = new System.Drawing.Point(318, 217);
            this.tx_cidade.Name = "tx_cidade";
            this.tx_cidade.Size = new System.Drawing.Size(207, 20);
            this.tx_cidade.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 38;
            this.label7.Text = "Cidade";
            // 
            // tx_bairro
            // 
            this.tx_bairro.Location = new System.Drawing.Point(77, 244);
            this.tx_bairro.Name = "tx_bairro";
            this.tx_bairro.Size = new System.Drawing.Size(168, 20);
            this.tx_bairro.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 21);
            this.label11.TabIndex = 40;
            this.label11.Text = "Bairro";
            // 
            // tx_rua
            // 
            this.tx_rua.Location = new System.Drawing.Point(296, 245);
            this.tx_rua.Name = "tx_rua";
            this.tx_rua.Size = new System.Drawing.Size(229, 20);
            this.tx_rua.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(251, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 21);
            this.label12.TabIndex = 42;
            this.label12.Text = "Rua";
            // 
            // tx_razaoSocial
            // 
            this.tx_razaoSocial.Location = new System.Drawing.Point(362, 115);
            this.tx_razaoSocial.Name = "tx_razaoSocial";
            this.tx_razaoSocial.Size = new System.Drawing.Size(163, 20);
            this.tx_razaoSocial.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.tx_razaoSocial);
            this.Controls.Add(this.tx_rua);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tx_bairro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tx_cidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.ms_cpf);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cb_naturezaJuridica);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tx_capitalSocial);
            this.Controls.Add(this.ms_telefone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ms_dataInicioAtividade);
            this.Controls.Add(this.cb_situacaoCadastral);
            this.Controls.Add(this.tx_nomeFantasia);
            this.Controls.Add(this.tx_cnpj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_cnpj;
        private System.Windows.Forms.TextBox tx_nomeFantasia;
        private System.Windows.Forms.ComboBox cb_situacaoCadastral;
        private System.Windows.Forms.RadioButton rd_simples;
        private System.Windows.Forms.RadioButton rd_lucro;
        private System.Windows.Forms.RadioButton rd_lucroReal;
        private System.Windows.Forms.MaskedTextBox ms_dataInicioAtividade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox ms_telefone;
        private System.Windows.Forms.TextBox tx_capitalSocial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rd_filial;
        private System.Windows.Forms.RadioButton rd_matriz;
        private System.Windows.Forms.RadioButton rd_grande;
        private System.Windows.Forms.RadioButton rd_medio;
        private System.Windows.Forms.RadioButton rd_pequeno;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_naturezaJuridica;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox ms_cpf;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tx_cidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tx_bairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tx_rua;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tx_razaoSocial;
    }
}

