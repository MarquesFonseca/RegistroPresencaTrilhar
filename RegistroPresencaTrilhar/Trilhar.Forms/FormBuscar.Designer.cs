
namespace Trilhar.Forms
{
    partial class FormBuscar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtCampoPesquisa = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.valuesDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCriancaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selecioneATurmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outroResponsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alergiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seAlergiaSimPreenchaAquiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restrincaoAlimentarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seRestrincaoAlimentarSimDescrevaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.algumaDeficienciaOuSituacaoAtipicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seAlgumaDeficienciaDescrevaOsDetalhesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batizadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBatismoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igrejaBatizouDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chamadaAzul910AnosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chamadaAzulRoyal1112AnosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chamadaBranco011Me29DDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chamadaLaranja34AnosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chamadaLilas1AnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chamadaLilas2AnosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chamadaVerde78AnosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chamadaVermelho56AnosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valuesDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnConfirmar);
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 78);
            this.panel1.TabIndex = 2;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnConfirmar.Location = new System.Drawing.Point(17, 12);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(386, 54);
            this.BtnConfirmar.TabIndex = 0;
            this.BtnConfirmar.Text = "&Retornar selecionado [Enter]";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnCancelar.Location = new System.Drawing.Point(703, 12);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(155, 54);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtCampoPesquisa);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(870, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // TxtCampoPesquisa
            // 
            this.TxtCampoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCampoPesquisa.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCampoPesquisa.CausesValidation = false;
            this.TxtCampoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCampoPesquisa.ForeColor = System.Drawing.Color.Red;
            this.TxtCampoPesquisa.Location = new System.Drawing.Point(12, 51);
            this.TxtCampoPesquisa.Name = "TxtCampoPesquisa";
            this.TxtCampoPesquisa.Size = new System.Drawing.Size(846, 35);
            this.TxtCampoPesquisa.TabIndex = 1;
            this.TxtCampoPesquisa.TextChanged += new System.EventHandler(this.TxtCampoPesquisa_TextChanged);
            this.TxtCampoPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCampoPesquisa_KeyDown);
            this.TxtCampoPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCampoPesquisa_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(12, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(235, 29);
            this.label15.TabIndex = 0;
            this.label15.Text = "Campo de &pesquisa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 371);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado da pesquisa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoCadastroDataGridViewTextBoxColumn,
            this.nomeCriancaDataGridViewTextBoxColumn,
            this.selecioneATurmaDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.maeDataGridViewTextBoxColumn,
            this.paiDataGridViewTextBoxColumn,
            this.outroResponsavelDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.enderecoEmailDataGridViewTextBoxColumn,
            this.alergiaDataGridViewTextBoxColumn,
            this.seAlergiaSimPreenchaAquiDataGridViewTextBoxColumn,
            this.restrincaoAlimentarDataGridViewTextBoxColumn,
            this.seRestrincaoAlimentarSimDescrevaDataGridViewTextBoxColumn,
            this.algumaDeficienciaOuSituacaoAtipicaDataGridViewTextBoxColumn,
            this.seAlgumaDeficienciaDescrevaOsDetalhesDataGridViewTextBoxColumn,
            this.batizadoDataGridViewTextBoxColumn,
            this.dataBatismoDataGridViewTextBoxColumn,
            this.igrejaBatizouDataGridViewTextBoxColumn,
            this.chamadaAzul910AnosDataGridViewTextBoxColumn,
            this.chamadaAzulRoyal1112AnosDataGridViewTextBoxColumn,
            this.chamadaBranco011Me29DDataGridViewTextBoxColumn,
            this.chamadaLaranja34AnosDataGridViewTextBoxColumn,
            this.chamadaLilas1AnoDataGridViewTextBoxColumn,
            this.chamadaLilas2AnosDataGridViewTextBoxColumn,
            this.chamadaVerde78AnosDataGridViewTextBoxColumn,
            this.chamadaVermelho56AnosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.valuesDTOBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(864, 346);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // valuesDTOBindingSource
            // 
            this.valuesDTOBindingSource.DataSource = typeof(Trilhar.Entidades.ValuesDTO);
            // 
            // codigoCadastroDataGridViewTextBoxColumn
            // 
            this.codigoCadastroDataGridViewTextBoxColumn.DataPropertyName = "CodigoCadastro";
            this.codigoCadastroDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoCadastroDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codigoCadastroDataGridViewTextBoxColumn.Name = "codigoCadastroDataGridViewTextBoxColumn";
            this.codigoCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoCadastroDataGridViewTextBoxColumn.Width = 117;
            // 
            // nomeCriancaDataGridViewTextBoxColumn
            // 
            this.nomeCriancaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nomeCriancaDataGridViewTextBoxColumn.DataPropertyName = "NomeCrianca";
            this.nomeCriancaDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeCriancaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomeCriancaDataGridViewTextBoxColumn.Name = "nomeCriancaDataGridViewTextBoxColumn";
            this.nomeCriancaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeCriancaDataGridViewTextBoxColumn.Width = 104;
            // 
            // selecioneATurmaDataGridViewTextBoxColumn
            // 
            this.selecioneATurmaDataGridViewTextBoxColumn.DataPropertyName = "SelecioneATurma";
            this.selecioneATurmaDataGridViewTextBoxColumn.HeaderText = "Turma";
            this.selecioneATurmaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.selecioneATurmaDataGridViewTextBoxColumn.Name = "selecioneATurmaDataGridViewTextBoxColumn";
            this.selecioneATurmaDataGridViewTextBoxColumn.ReadOnly = true;
            this.selecioneATurmaDataGridViewTextBoxColumn.Width = 110;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.FillWeight = 190F;
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "Data nascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataNascimentoDataGridViewTextBoxColumn.Width = 191;
            // 
            // maeDataGridViewTextBoxColumn
            // 
            this.maeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.maeDataGridViewTextBoxColumn.DataPropertyName = "Mae";
            this.maeDataGridViewTextBoxColumn.HeaderText = "Mãe";
            this.maeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maeDataGridViewTextBoxColumn.Name = "maeDataGridViewTextBoxColumn";
            this.maeDataGridViewTextBoxColumn.ReadOnly = true;
            this.maeDataGridViewTextBoxColumn.Width = 90;
            // 
            // paiDataGridViewTextBoxColumn
            // 
            this.paiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.paiDataGridViewTextBoxColumn.DataPropertyName = "Pai";
            this.paiDataGridViewTextBoxColumn.HeaderText = "Pai";
            this.paiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.paiDataGridViewTextBoxColumn.Name = "paiDataGridViewTextBoxColumn";
            this.paiDataGridViewTextBoxColumn.ReadOnly = true;
            this.paiDataGridViewTextBoxColumn.Width = 79;
            // 
            // outroResponsavelDataGridViewTextBoxColumn
            // 
            this.outroResponsavelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.outroResponsavelDataGridViewTextBoxColumn.DataPropertyName = "OutroResponsavel";
            this.outroResponsavelDataGridViewTextBoxColumn.HeaderText = "Outro responsável";
            this.outroResponsavelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.outroResponsavelDataGridViewTextBoxColumn.Name = "outroResponsavelDataGridViewTextBoxColumn";
            this.outroResponsavelDataGridViewTextBoxColumn.ReadOnly = true;
            this.outroResponsavelDataGridViewTextBoxColumn.Width = 206;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 133;
            // 
            // enderecoEmailDataGridViewTextBoxColumn
            // 
            this.enderecoEmailDataGridViewTextBoxColumn.DataPropertyName = "EnderecoEmail";
            this.enderecoEmailDataGridViewTextBoxColumn.HeaderText = "Endereco de email";
            this.enderecoEmailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.enderecoEmailDataGridViewTextBoxColumn.Name = "enderecoEmailDataGridViewTextBoxColumn";
            this.enderecoEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoEmailDataGridViewTextBoxColumn.Width = 161;
            // 
            // alergiaDataGridViewTextBoxColumn
            // 
            this.alergiaDataGridViewTextBoxColumn.DataPropertyName = "Alergia";
            this.alergiaDataGridViewTextBoxColumn.HeaderText = "Alergia";
            this.alergiaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.alergiaDataGridViewTextBoxColumn.Name = "alergiaDataGridViewTextBoxColumn";
            this.alergiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.alergiaDataGridViewTextBoxColumn.Width = 116;
            // 
            // seAlergiaSimPreenchaAquiDataGridViewTextBoxColumn
            // 
            this.seAlergiaSimPreenchaAquiDataGridViewTextBoxColumn.DataPropertyName = "SeAlergiaSimPreenchaAqui";
            this.seAlergiaSimPreenchaAquiDataGridViewTextBoxColumn.HeaderText = "Desc. alergia";
            this.seAlergiaSimPreenchaAquiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.seAlergiaSimPreenchaAquiDataGridViewTextBoxColumn.Name = "seAlergiaSimPreenchaAquiDataGridViewTextBoxColumn";
            this.seAlergiaSimPreenchaAquiDataGridViewTextBoxColumn.ReadOnly = true;
            this.seAlergiaSimPreenchaAquiDataGridViewTextBoxColumn.Width = 160;
            // 
            // restrincaoAlimentarDataGridViewTextBoxColumn
            // 
            this.restrincaoAlimentarDataGridViewTextBoxColumn.DataPropertyName = "RestrincaoAlimentar";
            this.restrincaoAlimentarDataGridViewTextBoxColumn.HeaderText = "Restrinção alimentar";
            this.restrincaoAlimentarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.restrincaoAlimentarDataGridViewTextBoxColumn.Name = "restrincaoAlimentarDataGridViewTextBoxColumn";
            this.restrincaoAlimentarDataGridViewTextBoxColumn.ReadOnly = true;
            this.restrincaoAlimentarDataGridViewTextBoxColumn.Width = 223;
            // 
            // seRestrincaoAlimentarSimDescrevaDataGridViewTextBoxColumn
            // 
            this.seRestrincaoAlimentarSimDescrevaDataGridViewTextBoxColumn.DataPropertyName = "SeRestrincaoAlimentarSimDescreva";
            this.seRestrincaoAlimentarSimDescrevaDataGridViewTextBoxColumn.HeaderText = "Desc. restrinção alim.";
            this.seRestrincaoAlimentarSimDescrevaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.seRestrincaoAlimentarSimDescrevaDataGridViewTextBoxColumn.Name = "seRestrincaoAlimentarSimDescrevaDataGridViewTextBoxColumn";
            this.seRestrincaoAlimentarSimDescrevaDataGridViewTextBoxColumn.ReadOnly = true;
            this.seRestrincaoAlimentarSimDescrevaDataGridViewTextBoxColumn.Width = 233;
            // 
            // algumaDeficienciaOuSituacaoAtipicaDataGridViewTextBoxColumn
            // 
            this.algumaDeficienciaOuSituacaoAtipicaDataGridViewTextBoxColumn.DataPropertyName = "AlgumaDeficienciaOuSituacaoAtipica";
            this.algumaDeficienciaOuSituacaoAtipicaDataGridViewTextBoxColumn.HeaderText = "Deficiência ou situação atípica";
            this.algumaDeficienciaOuSituacaoAtipicaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.algumaDeficienciaOuSituacaoAtipicaDataGridViewTextBoxColumn.Name = "algumaDeficienciaOuSituacaoAtipicaDataGridViewTextBoxColumn";
            this.algumaDeficienciaOuSituacaoAtipicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.algumaDeficienciaOuSituacaoAtipicaDataGridViewTextBoxColumn.Width = 252;
            // 
            // seAlgumaDeficienciaDescrevaOsDetalhesDataGridViewTextBoxColumn
            // 
            this.seAlgumaDeficienciaDescrevaOsDetalhesDataGridViewTextBoxColumn.DataPropertyName = "SeAlgumaDeficienciaDescrevaOsDetalhes";
            this.seAlgumaDeficienciaDescrevaOsDetalhesDataGridViewTextBoxColumn.HeaderText = "Desc. deficiência ou sit.";
            this.seAlgumaDeficienciaDescrevaOsDetalhesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.seAlgumaDeficienciaDescrevaOsDetalhesDataGridViewTextBoxColumn.Name = "seAlgumaDeficienciaDescrevaOsDetalhesDataGridViewTextBoxColumn";
            this.seAlgumaDeficienciaDescrevaOsDetalhesDataGridViewTextBoxColumn.ReadOnly = true;
            this.seAlgumaDeficienciaDescrevaOsDetalhesDataGridViewTextBoxColumn.Width = 226;
            // 
            // batizadoDataGridViewTextBoxColumn
            // 
            this.batizadoDataGridViewTextBoxColumn.DataPropertyName = "Batizado";
            this.batizadoDataGridViewTextBoxColumn.HeaderText = "Batizado";
            this.batizadoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.batizadoDataGridViewTextBoxColumn.Name = "batizadoDataGridViewTextBoxColumn";
            this.batizadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.batizadoDataGridViewTextBoxColumn.Width = 132;
            // 
            // dataBatismoDataGridViewTextBoxColumn
            // 
            this.dataBatismoDataGridViewTextBoxColumn.DataPropertyName = "DataBatismo";
            this.dataBatismoDataGridViewTextBoxColumn.HeaderText = "Data batismo";
            this.dataBatismoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataBatismoDataGridViewTextBoxColumn.Name = "dataBatismoDataGridViewTextBoxColumn";
            this.dataBatismoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataBatismoDataGridViewTextBoxColumn.Width = 160;
            // 
            // igrejaBatizouDataGridViewTextBoxColumn
            // 
            this.igrejaBatizouDataGridViewTextBoxColumn.DataPropertyName = "IgrejaBatizou";
            this.igrejaBatizouDataGridViewTextBoxColumn.HeaderText = "Igreja batismo";
            this.igrejaBatizouDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.igrejaBatizouDataGridViewTextBoxColumn.Name = "igrejaBatizouDataGridViewTextBoxColumn";
            this.igrejaBatizouDataGridViewTextBoxColumn.ReadOnly = true;
            this.igrejaBatizouDataGridViewTextBoxColumn.Width = 168;
            // 
            // chamadaAzul910AnosDataGridViewTextBoxColumn
            // 
            this.chamadaAzul910AnosDataGridViewTextBoxColumn.DataPropertyName = "ChamadaAzul_9_10Anos";
            this.chamadaAzul910AnosDataGridViewTextBoxColumn.HeaderText = "ChamadaAzul_9_10Anos";
            this.chamadaAzul910AnosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chamadaAzul910AnosDataGridViewTextBoxColumn.Name = "chamadaAzul910AnosDataGridViewTextBoxColumn";
            this.chamadaAzul910AnosDataGridViewTextBoxColumn.ReadOnly = true;
            this.chamadaAzul910AnosDataGridViewTextBoxColumn.Width = 294;
            // 
            // chamadaAzulRoyal1112AnosDataGridViewTextBoxColumn
            // 
            this.chamadaAzulRoyal1112AnosDataGridViewTextBoxColumn.DataPropertyName = "ChamadaAzulRoyal_11_12Anos";
            this.chamadaAzulRoyal1112AnosDataGridViewTextBoxColumn.HeaderText = "ChamadaAzulRoyal_11_12Anos";
            this.chamadaAzulRoyal1112AnosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chamadaAzulRoyal1112AnosDataGridViewTextBoxColumn.Name = "chamadaAzulRoyal1112AnosDataGridViewTextBoxColumn";
            this.chamadaAzulRoyal1112AnosDataGridViewTextBoxColumn.ReadOnly = true;
            this.chamadaAzulRoyal1112AnosDataGridViewTextBoxColumn.Width = 360;
            // 
            // chamadaBranco011Me29DDataGridViewTextBoxColumn
            // 
            this.chamadaBranco011Me29DDataGridViewTextBoxColumn.DataPropertyName = "ChamadaBranco_0_11Me29D";
            this.chamadaBranco011Me29DDataGridViewTextBoxColumn.HeaderText = "ChamadaBranco_0_11Me29D";
            this.chamadaBranco011Me29DDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chamadaBranco011Me29DDataGridViewTextBoxColumn.Name = "chamadaBranco011Me29DDataGridViewTextBoxColumn";
            this.chamadaBranco011Me29DDataGridViewTextBoxColumn.ReadOnly = true;
            this.chamadaBranco011Me29DDataGridViewTextBoxColumn.Width = 338;
            // 
            // chamadaLaranja34AnosDataGridViewTextBoxColumn
            // 
            this.chamadaLaranja34AnosDataGridViewTextBoxColumn.DataPropertyName = "ChamadaLaranja_3_4Anos";
            this.chamadaLaranja34AnosDataGridViewTextBoxColumn.HeaderText = "ChamadaLaranja_3_4Anos";
            this.chamadaLaranja34AnosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chamadaLaranja34AnosDataGridViewTextBoxColumn.Name = "chamadaLaranja34AnosDataGridViewTextBoxColumn";
            this.chamadaLaranja34AnosDataGridViewTextBoxColumn.ReadOnly = true;
            this.chamadaLaranja34AnosDataGridViewTextBoxColumn.Width = 311;
            // 
            // chamadaLilas1AnoDataGridViewTextBoxColumn
            // 
            this.chamadaLilas1AnoDataGridViewTextBoxColumn.DataPropertyName = "ChamadaLilas_1Ano";
            this.chamadaLilas1AnoDataGridViewTextBoxColumn.HeaderText = "ChamadaLilas_1Ano";
            this.chamadaLilas1AnoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chamadaLilas1AnoDataGridViewTextBoxColumn.Name = "chamadaLilas1AnoDataGridViewTextBoxColumn";
            this.chamadaLilas1AnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.chamadaLilas1AnoDataGridViewTextBoxColumn.Width = 249;
            // 
            // chamadaLilas2AnosDataGridViewTextBoxColumn
            // 
            this.chamadaLilas2AnosDataGridViewTextBoxColumn.DataPropertyName = "ChamadaLilas_2_Anos";
            this.chamadaLilas2AnosDataGridViewTextBoxColumn.HeaderText = "ChamadaLilas_2_Anos";
            this.chamadaLilas2AnosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chamadaLilas2AnosDataGridViewTextBoxColumn.Name = "chamadaLilas2AnosDataGridViewTextBoxColumn";
            this.chamadaLilas2AnosDataGridViewTextBoxColumn.ReadOnly = true;
            this.chamadaLilas2AnosDataGridViewTextBoxColumn.Width = 272;
            // 
            // chamadaVerde78AnosDataGridViewTextBoxColumn
            // 
            this.chamadaVerde78AnosDataGridViewTextBoxColumn.DataPropertyName = "ChamadaVerde_7_8Anos";
            this.chamadaVerde78AnosDataGridViewTextBoxColumn.HeaderText = "ChamadaVerde_7_8Anos";
            this.chamadaVerde78AnosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chamadaVerde78AnosDataGridViewTextBoxColumn.Name = "chamadaVerde78AnosDataGridViewTextBoxColumn";
            this.chamadaVerde78AnosDataGridViewTextBoxColumn.ReadOnly = true;
            this.chamadaVerde78AnosDataGridViewTextBoxColumn.Width = 297;
            // 
            // chamadaVermelho56AnosDataGridViewTextBoxColumn
            // 
            this.chamadaVermelho56AnosDataGridViewTextBoxColumn.DataPropertyName = "ChamadaVermelho_5_6Anos";
            this.chamadaVermelho56AnosDataGridViewTextBoxColumn.HeaderText = "ChamadaVermelho_5_6Anos";
            this.chamadaVermelho56AnosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chamadaVermelho56AnosDataGridViewTextBoxColumn.Name = "chamadaVermelho56AnosDataGridViewTextBoxColumn";
            this.chamadaVermelho56AnosDataGridViewTextBoxColumn.ReadOnly = true;
            this.chamadaVermelho56AnosDataGridViewTextBoxColumn.Width = 331;
            // 
            // FormBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 549);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(870, 549);
            this.Name = "FormBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "FormBuscar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBuscar_FormClosing);
            this.Load += new System.EventHandler(this.FormBuscar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBuscar_KeyDown);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valuesDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource valuesDTOBindingSource;
        private System.Windows.Forms.TextBox TxtCampoPesquisa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCriancaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selecioneATurmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outroResponsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alergiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seAlergiaSimPreenchaAquiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restrincaoAlimentarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seRestrincaoAlimentarSimDescrevaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn algumaDeficienciaOuSituacaoAtipicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seAlgumaDeficienciaDescrevaOsDetalhesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batizadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataBatismoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn igrejaBatizouDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chamadaAzul910AnosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chamadaAzulRoyal1112AnosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chamadaBranco011Me29DDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chamadaLaranja34AnosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chamadaLilas1AnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chamadaLilas2AnosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chamadaVerde78AnosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chamadaVermelho56AnosDataGridViewTextBoxColumn;
    }
}