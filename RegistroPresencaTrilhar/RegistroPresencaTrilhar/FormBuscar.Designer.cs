
namespace RegistroPresencaTrilhar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCriancaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outroResponsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selecioneATurmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.valuesDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtCampoPesquisa = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valuesDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 78);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(661, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 54);
            this.button2.TabIndex = 0;
            this.button2.Text = "Campos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtCampoPesquisa);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(703, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 315);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoCadastroDataGridViewTextBoxColumn,
            this.nomeCriancaDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.maeDataGridViewTextBoxColumn,
            this.paiDataGridViewTextBoxColumn,
            this.outroResponsavelDataGridViewTextBoxColumn,
            this.selecioneATurmaDataGridViewTextBoxColumn,
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(842, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // codigoCadastroDataGridViewTextBoxColumn
            // 
            this.codigoCadastroDataGridViewTextBoxColumn.DataPropertyName = "CodigoCadastro";
            this.codigoCadastroDataGridViewTextBoxColumn.HeaderText = "CodigoCadastro";
            this.codigoCadastroDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codigoCadastroDataGridViewTextBoxColumn.Name = "codigoCadastroDataGridViewTextBoxColumn";
            this.codigoCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoCadastroDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomeCriancaDataGridViewTextBoxColumn
            // 
            this.nomeCriancaDataGridViewTextBoxColumn.DataPropertyName = "NomeCrianca";
            this.nomeCriancaDataGridViewTextBoxColumn.HeaderText = "NomeCrianca";
            this.nomeCriancaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomeCriancaDataGridViewTextBoxColumn.Name = "nomeCriancaDataGridViewTextBoxColumn";
            this.nomeCriancaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeCriancaDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataNascimentoDataGridViewTextBoxColumn.Width = 150;
            // 
            // maeDataGridViewTextBoxColumn
            // 
            this.maeDataGridViewTextBoxColumn.DataPropertyName = "Mae";
            this.maeDataGridViewTextBoxColumn.HeaderText = "Mae";
            this.maeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maeDataGridViewTextBoxColumn.Name = "maeDataGridViewTextBoxColumn";
            this.maeDataGridViewTextBoxColumn.ReadOnly = true;
            this.maeDataGridViewTextBoxColumn.Width = 150;
            // 
            // paiDataGridViewTextBoxColumn
            // 
            this.paiDataGridViewTextBoxColumn.DataPropertyName = "Pai";
            this.paiDataGridViewTextBoxColumn.HeaderText = "Pai";
            this.paiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.paiDataGridViewTextBoxColumn.Name = "paiDataGridViewTextBoxColumn";
            this.paiDataGridViewTextBoxColumn.ReadOnly = true;
            this.paiDataGridViewTextBoxColumn.Width = 150;
            // 
            // outroResponsavelDataGridViewTextBoxColumn
            // 
            this.outroResponsavelDataGridViewTextBoxColumn.DataPropertyName = "OutroResponsavel";
            this.outroResponsavelDataGridViewTextBoxColumn.HeaderText = "OutroResponsavel";
            this.outroResponsavelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.outroResponsavelDataGridViewTextBoxColumn.Name = "outroResponsavelDataGridViewTextBoxColumn";
            this.outroResponsavelDataGridViewTextBoxColumn.ReadOnly = true;
            this.outroResponsavelDataGridViewTextBoxColumn.Width = 150;
            // 
            // selecioneATurmaDataGridViewTextBoxColumn
            // 
            this.selecioneATurmaDataGridViewTextBoxColumn.DataPropertyName = "SelecioneATurma";
            this.selecioneATurmaDataGridViewTextBoxColumn.HeaderText = "SelecioneATurma";
            this.selecioneATurmaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.selecioneATurmaDataGridViewTextBoxColumn.Name = "selecioneATurmaDataGridViewTextBoxColumn";
            this.selecioneATurmaDataGridViewTextBoxColumn.ReadOnly = true;
            this.selecioneATurmaDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // enderecoEmailDataGridViewTextBoxColumn
            // 
            this.enderecoEmailDataGridViewTextBoxColumn.DataPropertyName = "EnderecoEmail";
            this.enderecoEmailDataGridViewTextBoxColumn.HeaderText = "EnderecoEmail";
            this.enderecoEmailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.enderecoEmailDataGridViewTextBoxColumn.Name = "enderecoEmailDataGridViewTextBoxColumn";
            this.enderecoEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoEmailDataGridViewTextBoxColumn.Width = 150;
            // 
            // alergiaDataGridViewTextBoxColumn
            // 
            this.alergiaDataGridViewTextBoxColumn.DataPropertyName = "Alergia";
            this.alergiaDataGridViewTextBoxColumn.HeaderText = "Alergia";
            this.alergiaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.alergiaDataGridViewTextBoxColumn.Name = "alergiaDataGridViewTextBoxColumn";
            this.alergiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.alergiaDataGridViewTextBoxColumn.Width = 150;
            // 
            // seAlergiaSimPreenchaAquiDataGridViewTextBoxColumn
            // 
            this.seAlergiaSimPreenchaAquiDataGridViewTextBoxColumn.DataPropertyName = "SeAlergiaSimPreenchaAqui";
            this.seAlergiaSimPreenchaAquiDataGridViewTextBoxColumn.HeaderText = "SeAlergiaSimPreenchaAqui";
            this.seAlergiaSimPreenchaAquiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.seAlergiaSimPreenchaAquiDataGridViewTextBoxColumn.Name = "seAlergiaSimPreenchaAquiDataGridViewTextBoxColumn";
            this.seAlergiaSimPreenchaAquiDataGridViewTextBoxColumn.ReadOnly = true;
            this.seAlergiaSimPreenchaAquiDataGridViewTextBoxColumn.Width = 150;
            // 
            // restrincaoAlimentarDataGridViewTextBoxColumn
            // 
            this.restrincaoAlimentarDataGridViewTextBoxColumn.DataPropertyName = "RestrincaoAlimentar";
            this.restrincaoAlimentarDataGridViewTextBoxColumn.HeaderText = "RestrincaoAlimentar";
            this.restrincaoAlimentarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.restrincaoAlimentarDataGridViewTextBoxColumn.Name = "restrincaoAlimentarDataGridViewTextBoxColumn";
            this.restrincaoAlimentarDataGridViewTextBoxColumn.ReadOnly = true;
            this.restrincaoAlimentarDataGridViewTextBoxColumn.Width = 150;
            // 
            // seRestrincaoAlimentarSimDescrevaDataGridViewTextBoxColumn
            // 
            this.seRestrincaoAlimentarSimDescrevaDataGridViewTextBoxColumn.DataPropertyName = "SeRestrincaoAlimentarSimDescreva";
            this.seRestrincaoAlimentarSimDescrevaDataGridViewTextBoxColumn.HeaderText = "SeRestrincaoAlimentarSimDescreva";
            this.seRestrincaoAlimentarSimDescrevaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.seRestrincaoAlimentarSimDescrevaDataGridViewTextBoxColumn.Name = "seRestrincaoAlimentarSimDescrevaDataGridViewTextBoxColumn";
            this.seRestrincaoAlimentarSimDescrevaDataGridViewTextBoxColumn.ReadOnly = true;
            this.seRestrincaoAlimentarSimDescrevaDataGridViewTextBoxColumn.Width = 150;
            // 
            // algumaDeficienciaOuSituacaoAtipicaDataGridViewTextBoxColumn
            // 
            this.algumaDeficienciaOuSituacaoAtipicaDataGridViewTextBoxColumn.DataPropertyName = "AlgumaDeficienciaOuSituacaoAtipica";
            this.algumaDeficienciaOuSituacaoAtipicaDataGridViewTextBoxColumn.HeaderText = "AlgumaDeficienciaOuSituacaoAtipica";
            this.algumaDeficienciaOuSituacaoAtipicaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.algumaDeficienciaOuSituacaoAtipicaDataGridViewTextBoxColumn.Name = "algumaDeficienciaOuSituacaoAtipicaDataGridViewTextBoxColumn";
            this.algumaDeficienciaOuSituacaoAtipicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.algumaDeficienciaOuSituacaoAtipicaDataGridViewTextBoxColumn.Width = 150;
            // 
            // seAlgumaDeficienciaDescrevaOsDetalhesDataGridViewTextBoxColumn
            // 
            this.seAlgumaDeficienciaDescrevaOsDetalhesDataGridViewTextBoxColumn.DataPropertyName = "SeAlgumaDeficienciaDescrevaOsDetalhes";
            this.seAlgumaDeficienciaDescrevaOsDetalhesDataGridViewTextBoxColumn.HeaderText = "SeAlgumaDeficienciaDescrevaOsDetalhes";
            this.seAlgumaDeficienciaDescrevaOsDetalhesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.seAlgumaDeficienciaDescrevaOsDetalhesDataGridViewTextBoxColumn.Name = "seAlgumaDeficienciaDescrevaOsDetalhesDataGridViewTextBoxColumn";
            this.seAlgumaDeficienciaDescrevaOsDetalhesDataGridViewTextBoxColumn.ReadOnly = true;
            this.seAlgumaDeficienciaDescrevaOsDetalhesDataGridViewTextBoxColumn.Width = 150;
            // 
            // batizadoDataGridViewTextBoxColumn
            // 
            this.batizadoDataGridViewTextBoxColumn.DataPropertyName = "Batizado";
            this.batizadoDataGridViewTextBoxColumn.HeaderText = "Batizado";
            this.batizadoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.batizadoDataGridViewTextBoxColumn.Name = "batizadoDataGridViewTextBoxColumn";
            this.batizadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.batizadoDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataBatismoDataGridViewTextBoxColumn
            // 
            this.dataBatismoDataGridViewTextBoxColumn.DataPropertyName = "DataBatismo";
            this.dataBatismoDataGridViewTextBoxColumn.HeaderText = "DataBatismo";
            this.dataBatismoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataBatismoDataGridViewTextBoxColumn.Name = "dataBatismoDataGridViewTextBoxColumn";
            this.dataBatismoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataBatismoDataGridViewTextBoxColumn.Width = 150;
            // 
            // igrejaBatizouDataGridViewTextBoxColumn
            // 
            this.igrejaBatizouDataGridViewTextBoxColumn.DataPropertyName = "IgrejaBatizou";
            this.igrejaBatizouDataGridViewTextBoxColumn.HeaderText = "IgrejaBatizou";
            this.igrejaBatizouDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.igrejaBatizouDataGridViewTextBoxColumn.Name = "igrejaBatizouDataGridViewTextBoxColumn";
            this.igrejaBatizouDataGridViewTextBoxColumn.ReadOnly = true;
            this.igrejaBatizouDataGridViewTextBoxColumn.Width = 150;
            // 
            // chamadaAzul910AnosDataGridViewTextBoxColumn
            // 
            this.chamadaAzul910AnosDataGridViewTextBoxColumn.DataPropertyName = "ChamadaAzul_9_10Anos";
            this.chamadaAzul910AnosDataGridViewTextBoxColumn.HeaderText = "ChamadaAzul_9_10Anos";
            this.chamadaAzul910AnosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chamadaAzul910AnosDataGridViewTextBoxColumn.Name = "chamadaAzul910AnosDataGridViewTextBoxColumn";
            this.chamadaAzul910AnosDataGridViewTextBoxColumn.ReadOnly = true;
            this.chamadaAzul910AnosDataGridViewTextBoxColumn.Width = 150;
            // 
            // chamadaAzulRoyal1112AnosDataGridViewTextBoxColumn
            // 
            this.chamadaAzulRoyal1112AnosDataGridViewTextBoxColumn.DataPropertyName = "ChamadaAzulRoyal_11_12Anos";
            this.chamadaAzulRoyal1112AnosDataGridViewTextBoxColumn.HeaderText = "ChamadaAzulRoyal_11_12Anos";
            this.chamadaAzulRoyal1112AnosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chamadaAzulRoyal1112AnosDataGridViewTextBoxColumn.Name = "chamadaAzulRoyal1112AnosDataGridViewTextBoxColumn";
            this.chamadaAzulRoyal1112AnosDataGridViewTextBoxColumn.ReadOnly = true;
            this.chamadaAzulRoyal1112AnosDataGridViewTextBoxColumn.Width = 150;
            // 
            // chamadaBranco011Me29DDataGridViewTextBoxColumn
            // 
            this.chamadaBranco011Me29DDataGridViewTextBoxColumn.DataPropertyName = "ChamadaBranco_0_11Me29D";
            this.chamadaBranco011Me29DDataGridViewTextBoxColumn.HeaderText = "ChamadaBranco_0_11Me29D";
            this.chamadaBranco011Me29DDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chamadaBranco011Me29DDataGridViewTextBoxColumn.Name = "chamadaBranco011Me29DDataGridViewTextBoxColumn";
            this.chamadaBranco011Me29DDataGridViewTextBoxColumn.ReadOnly = true;
            this.chamadaBranco011Me29DDataGridViewTextBoxColumn.Width = 150;
            // 
            // chamadaLaranja34AnosDataGridViewTextBoxColumn
            // 
            this.chamadaLaranja34AnosDataGridViewTextBoxColumn.DataPropertyName = "ChamadaLaranja_3_4Anos";
            this.chamadaLaranja34AnosDataGridViewTextBoxColumn.HeaderText = "ChamadaLaranja_3_4Anos";
            this.chamadaLaranja34AnosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chamadaLaranja34AnosDataGridViewTextBoxColumn.Name = "chamadaLaranja34AnosDataGridViewTextBoxColumn";
            this.chamadaLaranja34AnosDataGridViewTextBoxColumn.ReadOnly = true;
            this.chamadaLaranja34AnosDataGridViewTextBoxColumn.Width = 150;
            // 
            // chamadaLilas1AnoDataGridViewTextBoxColumn
            // 
            this.chamadaLilas1AnoDataGridViewTextBoxColumn.DataPropertyName = "ChamadaLilas_1Ano";
            this.chamadaLilas1AnoDataGridViewTextBoxColumn.HeaderText = "ChamadaLilas_1Ano";
            this.chamadaLilas1AnoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chamadaLilas1AnoDataGridViewTextBoxColumn.Name = "chamadaLilas1AnoDataGridViewTextBoxColumn";
            this.chamadaLilas1AnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.chamadaLilas1AnoDataGridViewTextBoxColumn.Width = 150;
            // 
            // chamadaLilas2AnosDataGridViewTextBoxColumn
            // 
            this.chamadaLilas2AnosDataGridViewTextBoxColumn.DataPropertyName = "ChamadaLilas_2_Anos";
            this.chamadaLilas2AnosDataGridViewTextBoxColumn.HeaderText = "ChamadaLilas_2_Anos";
            this.chamadaLilas2AnosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chamadaLilas2AnosDataGridViewTextBoxColumn.Name = "chamadaLilas2AnosDataGridViewTextBoxColumn";
            this.chamadaLilas2AnosDataGridViewTextBoxColumn.ReadOnly = true;
            this.chamadaLilas2AnosDataGridViewTextBoxColumn.Width = 150;
            // 
            // chamadaVerde78AnosDataGridViewTextBoxColumn
            // 
            this.chamadaVerde78AnosDataGridViewTextBoxColumn.DataPropertyName = "ChamadaVerde_7_8Anos";
            this.chamadaVerde78AnosDataGridViewTextBoxColumn.HeaderText = "ChamadaVerde_7_8Anos";
            this.chamadaVerde78AnosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chamadaVerde78AnosDataGridViewTextBoxColumn.Name = "chamadaVerde78AnosDataGridViewTextBoxColumn";
            this.chamadaVerde78AnosDataGridViewTextBoxColumn.ReadOnly = true;
            this.chamadaVerde78AnosDataGridViewTextBoxColumn.Width = 150;
            // 
            // chamadaVermelho56AnosDataGridViewTextBoxColumn
            // 
            this.chamadaVermelho56AnosDataGridViewTextBoxColumn.DataPropertyName = "ChamadaVermelho_5_6Anos";
            this.chamadaVermelho56AnosDataGridViewTextBoxColumn.HeaderText = "ChamadaVermelho_5_6Anos";
            this.chamadaVermelho56AnosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.chamadaVermelho56AnosDataGridViewTextBoxColumn.Name = "chamadaVermelho56AnosDataGridViewTextBoxColumn";
            this.chamadaVermelho56AnosDataGridViewTextBoxColumn.ReadOnly = true;
            this.chamadaVermelho56AnosDataGridViewTextBoxColumn.Width = 150;
            // 
            // valuesDTOBindingSource
            // 
            this.valuesDTOBindingSource.DataSource = typeof(RegistroPresencaTrilhar.ValuesDTO);
            // 
            // TxtCampoPesquisa
            // 
            this.TxtCampoPesquisa.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCampoPesquisa.CausesValidation = false;
            this.TxtCampoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCampoPesquisa.ForeColor = System.Drawing.Color.Red;
            this.TxtCampoPesquisa.Location = new System.Drawing.Point(12, 51);
            this.TxtCampoPesquisa.Name = "TxtCampoPesquisa";
            this.TxtCampoPesquisa.Size = new System.Drawing.Size(685, 35);
            this.TxtCampoPesquisa.TabIndex = 24;
            this.TxtCampoPesquisa.TextChanged += new System.EventHandler(this.TxtCampoPesquisa_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(12, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(235, 29);
            this.label15.TabIndex = 25;
            this.label15.Text = "Campo de pesquisa:";
            // 
            // FormBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(870, 549);
            this.Name = "FormBuscar";
            this.Text = "FormBuscar";
            this.Load += new System.EventHandler(this.FormBuscar_Load);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCriancaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outroResponsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selecioneATurmaDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.BindingSource valuesDTOBindingSource;
        private System.Windows.Forms.TextBox TxtCampoPesquisa;
        private System.Windows.Forms.Label label15;
    }
}