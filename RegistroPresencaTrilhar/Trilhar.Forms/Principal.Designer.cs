
namespace Trilhar.Forms
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.linkLabelBuscarPeloNome = new System.Windows.Forms.LinkLabel();
            this.linkLabelBuscarPeloPai = new System.Windows.Forms.LinkLabel();
            this.linkLabelBuscarPelaMae = new System.Windows.Forms.LinkLabel();
            this.linkLabelAtualizarDados = new System.Windows.Forms.LinkLabel();
            this.BtnRegistrarPresenca = new System.Windows.Forms.Button();
            this.TxtNomeCrianca = new System.Windows.Forms.TextBox();
            this.LblNomeCrianca = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtIdadeCrianca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtOutroResponsavel = new System.Windows.Forms.TextBox();
            this.TxtPai = new System.Windows.Forms.TextBox();
            this.TxtMae = new System.Windows.Forms.TextBox();
            this.TxtDescricaoDeficienteAtipicos = new System.Windows.Forms.TextBox();
            this.LblRestrincaoAlimentar = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDescicaoAlergia = new System.Windows.Forms.TextBox();
            this.TxtDescricaoRestricaoAlimentar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LblDeficiente = new System.Windows.Forms.Label();
            this.LblAlergia = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCmbAlergia = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtCmbRestrincaoAlimentar = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtCmbDeficienteAtipicos = new System.Windows.Forms.ComboBox();
            this.TxtIgrejaBatismo = new System.Windows.Forms.TextBox();
            this.TxtCmbBatizado = new System.Windows.Forms.ComboBox();
            this.TxtDataBatismo = new System.Windows.Forms.MaskedTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDiaSemana = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDataHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUltimaAtualizacao = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTotalRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.CmbTurmaAtual = new System.Windows.Forms.ComboBox();
            this.TxtTurmaAtual = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.TxtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelBuscarPeloNome
            // 
            this.linkLabelBuscarPeloNome.AutoSize = true;
            this.linkLabelBuscarPeloNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBuscarPeloNome.Location = new System.Drawing.Point(12, 9);
            this.linkLabelBuscarPeloNome.Name = "linkLabelBuscarPeloNome";
            this.linkLabelBuscarPeloNome.Size = new System.Drawing.Size(270, 29);
            this.linkLabelBuscarPeloNome.TabIndex = 0;
            this.linkLabelBuscarPeloNome.TabStop = true;
            this.linkLabelBuscarPeloNome.Text = "[F1] - Buscar pelo nome";
            this.linkLabelBuscarPeloNome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBuscarPeloNome_LinkClicked);
            // 
            // linkLabelBuscarPeloPai
            // 
            this.linkLabelBuscarPeloPai.AutoSize = true;
            this.linkLabelBuscarPeloPai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBuscarPeloPai.Location = new System.Drawing.Point(568, 9);
            this.linkLabelBuscarPeloPai.Name = "linkLabelBuscarPeloPai";
            this.linkLabelBuscarPeloPai.Size = new System.Drawing.Size(242, 29);
            this.linkLabelBuscarPeloPai.TabIndex = 2;
            this.linkLabelBuscarPeloPai.TabStop = true;
            this.linkLabelBuscarPeloPai.Text = "[F3] - Buscar pelo pai";
            this.linkLabelBuscarPeloPai.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBuscarPeloPai_LinkClicked);
            // 
            // linkLabelBuscarPelaMae
            // 
            this.linkLabelBuscarPelaMae.AutoSize = true;
            this.linkLabelBuscarPelaMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBuscarPelaMae.Location = new System.Drawing.Point(297, 9);
            this.linkLabelBuscarPelaMae.Name = "linkLabelBuscarPelaMae";
            this.linkLabelBuscarPelaMae.Size = new System.Drawing.Size(255, 29);
            this.linkLabelBuscarPelaMae.TabIndex = 1;
            this.linkLabelBuscarPelaMae.TabStop = true;
            this.linkLabelBuscarPelaMae.Text = "[F2] - Buscar pela mãe";
            this.linkLabelBuscarPelaMae.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBuscarPelaMae_LinkClicked);
            // 
            // linkLabelAtualizarDados
            // 
            this.linkLabelAtualizarDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelAtualizarDados.AutoSize = true;
            this.linkLabelAtualizarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAtualizarDados.Location = new System.Drawing.Point(758, 9);
            this.linkLabelAtualizarDados.Name = "linkLabelAtualizarDados";
            this.linkLabelAtualizarDados.Size = new System.Drawing.Size(268, 29);
            this.linkLabelAtualizarDados.TabIndex = 3;
            this.linkLabelAtualizarDados.TabStop = true;
            this.linkLabelAtualizarDados.Text = "[F5] - Sincronizar dados";
            this.linkLabelAtualizarDados.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAtualizarDados_LinkClicked);
            // 
            // BtnRegistrarPresenca
            // 
            this.BtnRegistrarPresenca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegistrarPresenca.Enabled = false;
            this.BtnRegistrarPresenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.BtnRegistrarPresenca.Location = new System.Drawing.Point(686, 108);
            this.BtnRegistrarPresenca.Name = "BtnRegistrarPresenca";
            this.BtnRegistrarPresenca.Size = new System.Drawing.Size(336, 66);
            this.BtnRegistrarPresenca.TabIndex = 13;
            this.BtnRegistrarPresenca.Text = "Registrar presença";
            this.BtnRegistrarPresenca.UseVisualStyleBackColor = true;
            // 
            // TxtNomeCrianca
            // 
            this.TxtNomeCrianca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNomeCrianca.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.TxtNomeCrianca.Location = new System.Drawing.Point(225, 112);
            this.TxtNomeCrianca.Name = "TxtNomeCrianca";
            this.TxtNomeCrianca.ReadOnly = true;
            this.TxtNomeCrianca.Size = new System.Drawing.Size(445, 57);
            this.TxtNomeCrianca.TabIndex = 12;
            // 
            // LblNomeCrianca
            // 
            this.LblNomeCrianca.AutoSize = true;
            this.LblNomeCrianca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeCrianca.Location = new System.Drawing.Point(225, 72);
            this.LblNomeCrianca.Name = "LblNomeCrianca";
            this.LblNomeCrianca.Size = new System.Drawing.Size(270, 37);
            this.LblNomeCrianca.TabIndex = 11;
            this.LblNomeCrianca.Text = "Nome da criança:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 37);
            this.label15.TabIndex = 9;
            this.label15.Text = "Código cad.:";
            // 
            // TxtIdadeCrianca
            // 
            this.TxtIdadeCrianca.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.TxtIdadeCrianca.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtIdadeCrianca.Location = new System.Drawing.Point(332, 220);
            this.TxtIdadeCrianca.Name = "TxtIdadeCrianca";
            this.TxtIdadeCrianca.ReadOnly = true;
            this.TxtIdadeCrianca.Size = new System.Drawing.Size(578, 57);
            this.TxtIdadeCrianca.TabIndex = 17;
            this.TxtIdadeCrianca.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 37);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data de nascimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Idade da criança:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(918, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "Turma atual:";
            // 
            // TxtOutroResponsavel
            // 
            this.TxtOutroResponsavel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtOutroResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOutroResponsavel.Location = new System.Drawing.Point(675, 41);
            this.TxtOutroResponsavel.Name = "TxtOutroResponsavel";
            this.TxtOutroResponsavel.ReadOnly = true;
            this.TxtOutroResponsavel.Size = new System.Drawing.Size(332, 53);
            this.TxtOutroResponsavel.TabIndex = 5;
            // 
            // TxtPai
            // 
            this.TxtPai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPai.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPai.Location = new System.Drawing.Point(339, 41);
            this.TxtPai.Name = "TxtPai";
            this.TxtPai.ReadOnly = true;
            this.TxtPai.Size = new System.Drawing.Size(330, 53);
            this.TxtPai.TabIndex = 3;
            // 
            // TxtMae
            // 
            this.TxtMae.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMae.Location = new System.Drawing.Point(3, 41);
            this.TxtMae.Name = "TxtMae";
            this.TxtMae.ReadOnly = true;
            this.TxtMae.Size = new System.Drawing.Size(330, 53);
            this.TxtMae.TabIndex = 1;
            // 
            // TxtDescricaoDeficienteAtipicos
            // 
            this.TxtDescricaoDeficienteAtipicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDescricaoDeficienteAtipicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescricaoDeficienteAtipicos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtDescricaoDeficienteAtipicos.Location = new System.Drawing.Point(675, 489);
            this.TxtDescricaoDeficienteAtipicos.Multiline = true;
            this.TxtDescricaoDeficienteAtipicos.Name = "TxtDescricaoDeficienteAtipicos";
            this.TxtDescricaoDeficienteAtipicos.ReadOnly = true;
            this.TxtDescricaoDeficienteAtipicos.Size = new System.Drawing.Size(332, 123);
            this.TxtDescricaoDeficienteAtipicos.TabIndex = 27;
            // 
            // LblRestrincaoAlimentar
            // 
            this.LblRestrincaoAlimentar.AutoSize = true;
            this.LblRestrincaoAlimentar.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblRestrincaoAlimentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestrincaoAlimentar.Location = new System.Drawing.Point(339, 331);
            this.LblRestrincaoAlimentar.Name = "LblRestrincaoAlimentar";
            this.LblRestrincaoAlimentar.Size = new System.Drawing.Size(330, 37);
            this.LblRestrincaoAlimentar.TabIndex = 20;
            this.LblRestrincaoAlimentar.Text = "Restrição alimentar:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(339, 441);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(330, 37);
            this.label13.TabIndex = 22;
            this.label13.Text = "Descrição alimentar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(675, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 37);
            this.label6.TabIndex = 4;
            this.label6.Text = "Outro responsável:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nome do pai:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome da mãe:";
            // 
            // TxtDescicaoAlergia
            // 
            this.TxtDescicaoAlergia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDescicaoAlergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescicaoAlergia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtDescicaoAlergia.Location = new System.Drawing.Point(3, 489);
            this.TxtDescicaoAlergia.Multiline = true;
            this.TxtDescicaoAlergia.Name = "TxtDescicaoAlergia";
            this.TxtDescicaoAlergia.ReadOnly = true;
            this.TxtDescicaoAlergia.Size = new System.Drawing.Size(330, 123);
            this.TxtDescicaoAlergia.TabIndex = 19;
            // 
            // TxtDescricaoRestricaoAlimentar
            // 
            this.TxtDescricaoRestricaoAlimentar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDescricaoRestricaoAlimentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescricaoRestricaoAlimentar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtDescricaoRestricaoAlimentar.Location = new System.Drawing.Point(339, 489);
            this.TxtDescricaoRestricaoAlimentar.Multiline = true;
            this.TxtDescricaoRestricaoAlimentar.Name = "TxtDescricaoRestricaoAlimentar";
            this.TxtDescricaoRestricaoAlimentar.ReadOnly = true;
            this.TxtDescricaoRestricaoAlimentar.Size = new System.Drawing.Size(330, 123);
            this.TxtDescricaoRestricaoAlimentar.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 441);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(318, 37);
            this.label9.TabIndex = 18;
            this.label9.Text = "Descrição da alergia:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(675, 441);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(332, 37);
            this.label14.TabIndex = 26;
            this.label14.Text = "Descrições atípicas:";
            // 
            // LblDeficiente
            // 
            this.LblDeficiente.AutoSize = true;
            this.LblDeficiente.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblDeficiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeficiente.Location = new System.Drawing.Point(675, 331);
            this.LblDeficiente.Name = "LblDeficiente";
            this.LblDeficiente.Size = new System.Drawing.Size(332, 37);
            this.LblDeficiente.TabIndex = 24;
            this.LblDeficiente.Text = "Deficiente / Atípicos:";
            // 
            // LblAlergia
            // 
            this.LblAlergia.AutoSize = true;
            this.LblAlergia.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblAlergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlergia.Location = new System.Drawing.Point(3, 331);
            this.LblAlergia.Name = "LblAlergia";
            this.LblAlergia.Size = new System.Drawing.Size(330, 37);
            this.LblAlergia.TabIndex = 16;
            this.LblAlergia.Text = "Alergia:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(339, 151);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.ReadOnly = true;
            this.TxtEmail.Size = new System.Drawing.Size(330, 53);
            this.TxtEmail.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(329, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefone responsável:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.TxtOutroResponsavel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtPai, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtMae, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtEmail, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtTelefone, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtDescicaoAlergia, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.TxtDescricaoRestricaoAlimentar, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.TxtDescricaoDeficienteAtipicos, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.label14, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.LblAlergia, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtCmbAlergia, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.LblRestrincaoAlimentar, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtCmbRestrincaoAlimentar, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.LblDeficiente, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtCmbDeficienteAtipicos, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.TxtIgrejaBatismo, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.TxtCmbBatizado, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.TxtDataBatismo, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 291);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1010, 615);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(339, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(330, 37);
            this.label8.TabIndex = 8;
            this.label8.Text = "Endereço de email:";
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TxtTelefone.Location = new System.Drawing.Point(3, 151);
            this.TxtTelefone.Mask = "(99) 00000-0000";
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.ReadOnly = true;
            this.TxtTelefone.Size = new System.Drawing.Size(330, 53);
            this.TxtTelefone.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label10.Location = new System.Drawing.Point(3, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 37);
            this.label10.TabIndex = 10;
            this.label10.Text = "Batizado:";
            // 
            // TxtCmbAlergia
            // 
            this.TxtCmbAlergia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCmbAlergia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtCmbAlergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.TxtCmbAlergia.FormattingEnabled = true;
            this.TxtCmbAlergia.Items.AddRange(new object[] {
            "NÃO",
            "SIM"});
            this.TxtCmbAlergia.Location = new System.Drawing.Point(4, 378);
            this.TxtCmbAlergia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCmbAlergia.Name = "TxtCmbAlergia";
            this.TxtCmbAlergia.Size = new System.Drawing.Size(328, 60);
            this.TxtCmbAlergia.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label11.Location = new System.Drawing.Point(339, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 37);
            this.label11.TabIndex = 12;
            this.label11.Text = "Data batismo:";
            // 
            // TxtCmbRestrincaoAlimentar
            // 
            this.TxtCmbRestrincaoAlimentar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCmbRestrincaoAlimentar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtCmbRestrincaoAlimentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.TxtCmbRestrincaoAlimentar.FormattingEnabled = true;
            this.TxtCmbRestrincaoAlimentar.Items.AddRange(new object[] {
            "NÃO",
            "SIM"});
            this.TxtCmbRestrincaoAlimentar.Location = new System.Drawing.Point(340, 378);
            this.TxtCmbRestrincaoAlimentar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCmbRestrincaoAlimentar.Name = "TxtCmbRestrincaoAlimentar";
            this.TxtCmbRestrincaoAlimentar.Size = new System.Drawing.Size(328, 60);
            this.TxtCmbRestrincaoAlimentar.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label12.Location = new System.Drawing.Point(675, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(227, 37);
            this.label12.TabIndex = 14;
            this.label12.Text = "Igreja batismo:";
            // 
            // TxtCmbDeficienteAtipicos
            // 
            this.TxtCmbDeficienteAtipicos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCmbDeficienteAtipicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtCmbDeficienteAtipicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.TxtCmbDeficienteAtipicos.FormattingEnabled = true;
            this.TxtCmbDeficienteAtipicos.Items.AddRange(new object[] {
            "NÃO",
            "SIM"});
            this.TxtCmbDeficienteAtipicos.Location = new System.Drawing.Point(676, 378);
            this.TxtCmbDeficienteAtipicos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCmbDeficienteAtipicos.Name = "TxtCmbDeficienteAtipicos";
            this.TxtCmbDeficienteAtipicos.Size = new System.Drawing.Size(330, 60);
            this.TxtCmbDeficienteAtipicos.TabIndex = 25;
            // 
            // TxtIgrejaBatismo
            // 
            this.TxtIgrejaBatismo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtIgrejaBatismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TxtIgrejaBatismo.Location = new System.Drawing.Point(675, 259);
            this.TxtIgrejaBatismo.Name = "TxtIgrejaBatismo";
            this.TxtIgrejaBatismo.ReadOnly = true;
            this.TxtIgrejaBatismo.Size = new System.Drawing.Size(332, 53);
            this.TxtIgrejaBatismo.TabIndex = 15;
            // 
            // TxtCmbBatizado
            // 
            this.TxtCmbBatizado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCmbBatizado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtCmbBatizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.TxtCmbBatizado.FormattingEnabled = true;
            this.TxtCmbBatizado.Items.AddRange(new object[] {
            "NÃO",
            "SIM"});
            this.TxtCmbBatizado.Location = new System.Drawing.Point(3, 259);
            this.TxtCmbBatizado.Name = "TxtCmbBatizado";
            this.TxtCmbBatizado.Size = new System.Drawing.Size(330, 60);
            this.TxtCmbBatizado.TabIndex = 11;
            // 
            // TxtDataBatismo
            // 
            this.TxtDataBatismo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDataBatismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TxtDataBatismo.Location = new System.Drawing.Point(339, 259);
            this.TxtDataBatismo.Mask = "00/00/0000";
            this.TxtDataBatismo.Name = "TxtDataBatismo";
            this.TxtDataBatismo.ReadOnly = true;
            this.TxtDataBatismo.Size = new System.Drawing.Size(330, 53);
            this.TxtDataBatismo.TabIndex = 13;
            this.TxtDataBatismo.ValidatingType = typeof(System.DateTime);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDiaSemana,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelDataHora});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(800, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(378, 54);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDiaSemana
            // 
            this.toolStripStatusLabelDiaSemana.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripStatusLabelDiaSemana.Name = "toolStripStatusLabelDiaSemana";
            this.toolStripStatusLabelDiaSemana.Size = new System.Drawing.Size(178, 47);
            this.toolStripStatusLabelDiaSemana.Text = "DiaSemana";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(28, 47);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabelDataHora
            // 
            this.toolStripStatusLabelDataHora.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripStatusLabelDataHora.Name = "toolStripStatusLabelDataHora";
            this.toolStripStatusLabelDataHora.Size = new System.Drawing.Size(154, 47);
            this.toolStripStatusLabelDataHora.Text = "DataHora";
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.statusStrip1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.statusStrip2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 695);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1040, 54);
            this.tableLayoutPanel2.TabIndex = 35;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUltimaAtualizacao,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabelTotalRegistros});
            this.statusStrip2.Location = new System.Drawing.Point(0, 0);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip2.Size = new System.Drawing.Size(800, 54);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabelUltimaAtualizacao
            // 
            this.toolStripStatusLabelUltimaAtualizacao.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripStatusLabelUltimaAtualizacao.Name = "toolStripStatusLabelUltimaAtualizacao";
            this.toolStripStatusLabelUltimaAtualizacao.Size = new System.Drawing.Size(223, 47);
            this.toolStripStatusLabelUltimaAtualizacao.Text = "UltAtualizacao";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(28, 47);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabelTotalRegistros
            // 
            this.toolStripStatusLabelTotalRegistros.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripStatusLabelTotalRegistros.Name = "toolStripStatusLabelTotalRegistros";
            this.toolStripStatusLabelTotalRegistros.Size = new System.Drawing.Size(208, 47);
            this.toolStripStatusLabelTotalRegistros.Text = "TotalRegistos";
            // 
            // BtnNovo
            // 
            this.BtnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.Location = new System.Drawing.Point(346, 49);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(123, 45);
            this.BtnNovo.TabIndex = 4;
            this.BtnNovo.Text = "&Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(622, 49);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(123, 45);
            this.BtnExcluir.TabIndex = 6;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.Location = new System.Drawing.Point(484, 49);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(123, 45);
            this.BtnAlterar.TabIndex = 5;
            this.BtnAlterar.Text = "&Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(898, 49);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(123, 45);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(760, 49);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(123, 45);
            this.BtnSalvar.TabIndex = 7;
            this.BtnSalvar.Text = "&Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // CmbTurmaAtual
            // 
            this.CmbTurmaAtual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbTurmaAtual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTurmaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.CmbTurmaAtual.FormattingEnabled = true;
            this.CmbTurmaAtual.Items.AddRange(new object[] {
            "BRANCO/ROSA (0 A 11 M)",
            "LILÁS (1 ANO)",
            "LILÁS (2 ANOS)",
            "LARANJA 3-4 ANOS",
            "VERMELHO 5-6 ANOS",
            "VERDE 7-8 ANOS",
            "AZUL 9-10 ANOS",
            "AZUL ROYAL 11-12 ANOS"});
            this.CmbTurmaAtual.Location = new System.Drawing.Point(920, 220);
            this.CmbTurmaAtual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbTurmaAtual.Name = "CmbTurmaAtual";
            this.CmbTurmaAtual.Size = new System.Drawing.Size(100, 60);
            this.CmbTurmaAtual.TabIndex = 20;
            // 
            // TxtTurmaAtual
            // 
            this.TxtTurmaAtual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTurmaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTurmaAtual.Location = new System.Drawing.Point(920, 220);
            this.TxtTurmaAtual.Name = "TxtTurmaAtual";
            this.TxtTurmaAtual.ReadOnly = true;
            this.TxtTurmaAtual.Size = new System.Drawing.Size(100, 57);
            this.TxtTurmaAtual.TabIndex = 19;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.numericUpDown1.Location = new System.Drawing.Point(16, 112);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(196, 57);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyDown);
            // 
            // TxtDataNascimento
            // 
            this.TxtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.TxtDataNascimento.Location = new System.Drawing.Point(16, 220);
            this.TxtDataNascimento.Mask = "00/00/0000";
            this.TxtDataNascimento.Name = "TxtDataNascimento";
            this.TxtDataNascimento.ReadOnly = true;
            this.TxtDataNascimento.Size = new System.Drawing.Size(306, 57);
            this.TxtDataNascimento.TabIndex = 15;
            this.TxtDataNascimento.ValidatingType = typeof(System.DateTime);
            this.TxtDataNascimento.TextChanged += new System.EventHandler(this.TxtDataNascimento_TextChanged);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 749);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.TxtDataNascimento);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbTurmaAtual);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.LblNomeCrianca);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.TxtIdadeCrianca);
            this.Controls.Add(this.TxtTurmaAtual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnRegistrarPresenca);
            this.Controls.Add(this.TxtNomeCrianca);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.linkLabelBuscarPeloNome);
            this.Controls.Add(this.linkLabelBuscarPeloPai);
            this.Controls.Add(this.linkLabelBuscarPelaMae);
            this.Controls.Add(this.linkLabelAtualizarDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1040, 56);
            this.Name = "Principal";
            this.Text = "Cadastro de criança - Trilhar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Principal_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelBuscarPeloNome;
        private System.Windows.Forms.LinkLabel linkLabelBuscarPeloPai;
        private System.Windows.Forms.LinkLabel linkLabelBuscarPelaMae;
        private System.Windows.Forms.LinkLabel linkLabelAtualizarDados;
        private System.Windows.Forms.Button BtnRegistrarPresenca;
        private System.Windows.Forms.TextBox TxtNomeCrianca;
        private System.Windows.Forms.Label LblNomeCrianca;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtIdadeCrianca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtOutroResponsavel;
        private System.Windows.Forms.TextBox TxtPai;
        private System.Windows.Forms.TextBox TxtMae;
        private System.Windows.Forms.TextBox TxtDescricaoDeficienteAtipicos;
        private System.Windows.Forms.Label LblRestrincaoAlimentar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDescicaoAlergia;
        private System.Windows.Forms.TextBox TxtDescricaoRestricaoAlimentar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LblDeficiente;
        private System.Windows.Forms.Label LblAlergia;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDataHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDiaSemana;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUltimaAtualizacao;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotalRegistros;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.ComboBox CmbTurmaAtual;
        private System.Windows.Forms.TextBox TxtTurmaAtual;
        private System.Windows.Forms.ComboBox TxtCmbAlergia;
        private System.Windows.Forms.ComboBox TxtCmbRestrincaoAlimentar;
        private System.Windows.Forms.ComboBox TxtCmbDeficienteAtipicos;
        private System.Windows.Forms.MaskedTextBox TxtTelefone;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtIgrejaBatismo;
        private System.Windows.Forms.ComboBox TxtCmbBatizado;
        private System.Windows.Forms.MaskedTextBox TxtDataBatismo;
        private System.Windows.Forms.MaskedTextBox TxtDataNascimento;
    }
}