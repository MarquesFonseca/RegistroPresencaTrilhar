
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
            this.TxtCodigoCadastro = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtIdadeCrianca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtOutroResponsavel = new System.Windows.Forms.TextBox();
            this.TxtPai = new System.Windows.Forms.TextBox();
            this.TxtMae = new System.Windows.Forms.TextBox();
            this.TxtDescricaoDeficienteAtipicos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDescicaoAlergia = new System.Windows.Forms.TextBox();
            this.TxtDescricaoRestricaoAlimentar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtCmbAlergia = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCmbRestrincaoAlimentar = new System.Windows.Forms.ComboBox();
            this.TxtCmbDeficienteAtipicos = new System.Windows.Forms.ComboBox();
            this.TxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.TxtMaskedDataNascimento = new System.Windows.Forms.DateTimePicker();
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
            this.TxtDataNascimento = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabelBuscarPeloNome
            // 
            this.linkLabelBuscarPeloNome.AutoSize = true;
            this.linkLabelBuscarPeloNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBuscarPeloNome.Location = new System.Drawing.Point(8, 6);
            this.linkLabelBuscarPeloNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelBuscarPeloNome.Name = "linkLabelBuscarPeloNome";
            this.linkLabelBuscarPeloNome.Size = new System.Drawing.Size(177, 20);
            this.linkLabelBuscarPeloNome.TabIndex = 0;
            this.linkLabelBuscarPeloNome.TabStop = true;
            this.linkLabelBuscarPeloNome.Text = "[F1] - Buscar pelo nome";
            this.linkLabelBuscarPeloNome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBuscarPeloNome_LinkClicked);
            // 
            // linkLabelBuscarPeloPai
            // 
            this.linkLabelBuscarPeloPai.AutoSize = true;
            this.linkLabelBuscarPeloPai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBuscarPeloPai.Location = new System.Drawing.Point(379, 6);
            this.linkLabelBuscarPeloPai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelBuscarPeloPai.Name = "linkLabelBuscarPeloPai";
            this.linkLabelBuscarPeloPai.Size = new System.Drawing.Size(158, 20);
            this.linkLabelBuscarPeloPai.TabIndex = 2;
            this.linkLabelBuscarPeloPai.TabStop = true;
            this.linkLabelBuscarPeloPai.Text = "[F3] - Buscar pelo pai";
            this.linkLabelBuscarPeloPai.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBuscarPeloPai_LinkClicked);
            // 
            // linkLabelBuscarPelaMae
            // 
            this.linkLabelBuscarPelaMae.AutoSize = true;
            this.linkLabelBuscarPelaMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBuscarPelaMae.Location = new System.Drawing.Point(198, 6);
            this.linkLabelBuscarPelaMae.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelBuscarPelaMae.Name = "linkLabelBuscarPelaMae";
            this.linkLabelBuscarPelaMae.Size = new System.Drawing.Size(168, 20);
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
            this.linkLabelAtualizarDados.Location = new System.Drawing.Point(505, 6);
            this.linkLabelAtualizarDados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelAtualizarDados.Name = "linkLabelAtualizarDados";
            this.linkLabelAtualizarDados.Size = new System.Drawing.Size(176, 20);
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
            this.BtnRegistrarPresenca.Location = new System.Drawing.Point(457, 70);
            this.BtnRegistrarPresenca.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRegistrarPresenca.Name = "BtnRegistrarPresenca";
            this.BtnRegistrarPresenca.Size = new System.Drawing.Size(224, 43);
            this.BtnRegistrarPresenca.TabIndex = 13;
            this.BtnRegistrarPresenca.Text = "Registrar presença";
            this.BtnRegistrarPresenca.UseVisualStyleBackColor = true;
            // 
            // TxtNomeCrianca
            // 
            this.TxtNomeCrianca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNomeCrianca.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.TxtNomeCrianca.Location = new System.Drawing.Point(150, 73);
            this.TxtNomeCrianca.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNomeCrianca.Name = "TxtNomeCrianca";
            this.TxtNomeCrianca.ReadOnly = true;
            this.TxtNomeCrianca.Size = new System.Drawing.Size(298, 41);
            this.TxtNomeCrianca.TabIndex = 12;
            // 
            // LblNomeCrianca
            // 
            this.LblNomeCrianca.AutoSize = true;
            this.LblNomeCrianca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeCrianca.Location = new System.Drawing.Point(150, 47);
            this.LblNomeCrianca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNomeCrianca.Name = "LblNomeCrianca";
            this.LblNomeCrianca.Size = new System.Drawing.Size(183, 26);
            this.LblNomeCrianca.TabIndex = 11;
            this.LblNomeCrianca.Text = "Nome da criança:";
            // 
            // TxtCodigoCadastro
            // 
            this.TxtCodigoCadastro.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCodigoCadastro.CausesValidation = false;
            this.TxtCodigoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.TxtCodigoCadastro.ForeColor = System.Drawing.Color.Red;
            this.TxtCodigoCadastro.Location = new System.Drawing.Point(11, 73);
            this.TxtCodigoCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCodigoCadastro.Name = "TxtCodigoCadastro";
            this.TxtCodigoCadastro.Size = new System.Drawing.Size(129, 41);
            this.TxtCodigoCadastro.TabIndex = 10;
            this.TxtCodigoCadastro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigoCadastro_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 47);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 26);
            this.label15.TabIndex = 9;
            this.label15.Text = "Código cad.:";
            // 
            // TxtIdadeCrianca
            // 
            this.TxtIdadeCrianca.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.TxtIdadeCrianca.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtIdadeCrianca.Location = new System.Drawing.Point(221, 143);
            this.TxtIdadeCrianca.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIdadeCrianca.Name = "TxtIdadeCrianca";
            this.TxtIdadeCrianca.ReadOnly = true;
            this.TxtIdadeCrianca.Size = new System.Drawing.Size(387, 41);
            this.TxtIdadeCrianca.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data de nascimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Idade da criança:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(612, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "Turma atual:";
            // 
            // TxtOutroResponsavel
            // 
            this.TxtOutroResponsavel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtOutroResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOutroResponsavel.Location = new System.Drawing.Point(450, 27);
            this.TxtOutroResponsavel.Margin = new System.Windows.Forms.Padding(2);
            this.TxtOutroResponsavel.Name = "TxtOutroResponsavel";
            this.TxtOutroResponsavel.ReadOnly = true;
            this.TxtOutroResponsavel.Size = new System.Drawing.Size(221, 38);
            this.TxtOutroResponsavel.TabIndex = 5;
            // 
            // TxtPai
            // 
            this.TxtPai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPai.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPai.Location = new System.Drawing.Point(226, 27);
            this.TxtPai.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPai.Name = "TxtPai";
            this.TxtPai.ReadOnly = true;
            this.TxtPai.Size = new System.Drawing.Size(220, 38);
            this.TxtPai.TabIndex = 3;
            // 
            // TxtMae
            // 
            this.TxtMae.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMae.Location = new System.Drawing.Point(2, 27);
            this.TxtMae.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMae.Name = "TxtMae";
            this.TxtMae.ReadOnly = true;
            this.TxtMae.Size = new System.Drawing.Size(220, 38);
            this.TxtMae.TabIndex = 1;
            // 
            // TxtDescricaoDeficienteAtipicos
            // 
            this.TxtDescricaoDeficienteAtipicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescricaoDeficienteAtipicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescricaoDeficienteAtipicos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtDescricaoDeficienteAtipicos.Location = new System.Drawing.Point(450, 244);
            this.TxtDescricaoDeficienteAtipicos.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDescricaoDeficienteAtipicos.Multiline = true;
            this.TxtDescricaoDeficienteAtipicos.Name = "TxtDescricaoDeficienteAtipicos";
            this.TxtDescricaoDeficienteAtipicos.ReadOnly = true;
            this.TxtDescricaoDeficienteAtipicos.Size = new System.Drawing.Size(221, 62);
            this.TxtDescricaoDeficienteAtipicos.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(226, 140);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 26);
            this.label10.TabIndex = 14;
            this.label10.Text = "Restrição alimentar:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(226, 211);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(220, 26);
            this.label13.TabIndex = 16;
            this.label13.Text = "Descrição alimentar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(450, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Outro responsável:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nome do pai:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome da mãe:";
            // 
            // TxtDescicaoAlergia
            // 
            this.TxtDescicaoAlergia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescicaoAlergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescicaoAlergia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtDescicaoAlergia.Location = new System.Drawing.Point(2, 244);
            this.TxtDescicaoAlergia.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDescicaoAlergia.Multiline = true;
            this.TxtDescicaoAlergia.Name = "TxtDescicaoAlergia";
            this.TxtDescicaoAlergia.ReadOnly = true;
            this.TxtDescicaoAlergia.Size = new System.Drawing.Size(220, 62);
            this.TxtDescicaoAlergia.TabIndex = 13;
            // 
            // TxtDescricaoRestricaoAlimentar
            // 
            this.TxtDescricaoRestricaoAlimentar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescricaoRestricaoAlimentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescricaoRestricaoAlimentar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtDescricaoRestricaoAlimentar.Location = new System.Drawing.Point(226, 244);
            this.TxtDescricaoRestricaoAlimentar.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDescricaoRestricaoAlimentar.Multiline = true;
            this.TxtDescricaoRestricaoAlimentar.Name = "TxtDescricaoRestricaoAlimentar";
            this.TxtDescricaoRestricaoAlimentar.ReadOnly = true;
            this.TxtDescricaoRestricaoAlimentar.Size = new System.Drawing.Size(220, 62);
            this.TxtDescricaoRestricaoAlimentar.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 211);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 26);
            this.label9.TabIndex = 12;
            this.label9.Text = "Descrição da alergia:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(450, 211);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(221, 26);
            this.label14.TabIndex = 20;
            this.label14.Text = "Descrições atípicas:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(450, 140);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 26);
            this.label11.TabIndex = 18;
            this.label11.Text = "Deficiente / Atípicos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(2, 140);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 26);
            this.label12.TabIndex = 10;
            this.label12.Text = "Alergia:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(226, 98);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.ReadOnly = true;
            this.TxtEmail.Size = new System.Drawing.Size(220, 38);
            this.TxtEmail.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 27);
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
            this.tableLayoutPanel1.Controls.Add(this.TxtCmbAlergia, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.TxtOutroResponsavel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtPai, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtMae, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtDescricaoDeficienteAtipicos, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtDescicaoAlergia, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.TxtDescricaoRestricaoAlimentar, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label14, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtEmail, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtCmbRestrincaoAlimentar, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.TxtCmbDeficienteAtipicos, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.TxtTelefone, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 189);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(673, 261);
            this.tableLayoutPanel1.TabIndex = 22;
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
            this.TxtCmbAlergia.Location = new System.Drawing.Point(3, 169);
            this.TxtCmbAlergia.Name = "TxtCmbAlergia";
            this.TxtCmbAlergia.Size = new System.Drawing.Size(218, 41);
            this.TxtCmbAlergia.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(226, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "Endereço de email:";
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
            this.TxtCmbRestrincaoAlimentar.Location = new System.Drawing.Point(227, 169);
            this.TxtCmbRestrincaoAlimentar.Name = "TxtCmbRestrincaoAlimentar";
            this.TxtCmbRestrincaoAlimentar.Size = new System.Drawing.Size(218, 41);
            this.TxtCmbRestrincaoAlimentar.TabIndex = 15;
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
            this.TxtCmbDeficienteAtipicos.Location = new System.Drawing.Point(451, 169);
            this.TxtCmbDeficienteAtipicos.Name = "TxtCmbDeficienteAtipicos";
            this.TxtCmbDeficienteAtipicos.Size = new System.Drawing.Size(219, 41);
            this.TxtCmbDeficienteAtipicos.TabIndex = 19;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TxtTelefone.Location = new System.Drawing.Point(2, 98);
            this.TxtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTelefone.Mask = "(99) 00000-0000";
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.ReadOnly = true;
            this.TxtTelefone.Size = new System.Drawing.Size(220, 38);
            this.TxtTelefone.TabIndex = 7;
            // 
            // TxtMaskedDataNascimento
            // 
            this.TxtMaskedDataNascimento.CustomFormat = "";
            this.TxtMaskedDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.TxtMaskedDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtMaskedDataNascimento.Location = new System.Drawing.Point(48, 143);
            this.TxtMaskedDataNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.TxtMaskedDataNascimento.Name = "TxtMaskedDataNascimento";
            this.TxtMaskedDataNascimento.Size = new System.Drawing.Size(206, 41);
            this.TxtMaskedDataNascimento.TabIndex = 16;
            this.TxtMaskedDataNascimento.Value = new System.DateTime(2023, 2, 24, 0, 0, 0, 0);
            this.TxtMaskedDataNascimento.ValueChanged += new System.EventHandler(this.TxtMaskedDataNascimento_ValueChanged);
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
            this.statusStrip1.Location = new System.Drawing.Point(533, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(256, 35);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDiaSemana
            // 
            this.toolStripStatusLabelDiaSemana.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripStatusLabelDiaSemana.Name = "toolStripStatusLabelDiaSemana";
            this.toolStripStatusLabelDiaSemana.Size = new System.Drawing.Size(121, 30);
            this.toolStripStatusLabelDiaSemana.Text = "DiaSemana";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(18, 30);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabelDataHora
            // 
            this.toolStripStatusLabelDataHora.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripStatusLabelDataHora.Name = "toolStripStatusLabelDataHora";
            this.toolStripStatusLabelDataHora.Size = new System.Drawing.Size(105, 30);
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 533F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.statusStrip1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.statusStrip2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 452);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(693, 35);
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
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip2.Size = new System.Drawing.Size(533, 35);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabelUltimaAtualizacao
            // 
            this.toolStripStatusLabelUltimaAtualizacao.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripStatusLabelUltimaAtualizacao.Name = "toolStripStatusLabelUltimaAtualizacao";
            this.toolStripStatusLabelUltimaAtualizacao.Size = new System.Drawing.Size(149, 30);
            this.toolStripStatusLabelUltimaAtualizacao.Text = "UltAtualizacao";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(18, 30);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabelTotalRegistros
            // 
            this.toolStripStatusLabelTotalRegistros.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripStatusLabelTotalRegistros.Name = "toolStripStatusLabelTotalRegistros";
            this.toolStripStatusLabelTotalRegistros.Size = new System.Drawing.Size(139, 30);
            this.toolStripStatusLabelTotalRegistros.Text = "TotalRegistos";
            // 
            // BtnNovo
            // 
            this.BtnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.Location = new System.Drawing.Point(231, 32);
            this.BtnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(82, 29);
            this.BtnNovo.TabIndex = 4;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(415, 32);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(82, 29);
            this.BtnExcluir.TabIndex = 6;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.Location = new System.Drawing.Point(323, 32);
            this.BtnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(82, 29);
            this.BtnAlterar.TabIndex = 5;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(599, 32);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(82, 29);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(507, 32);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(82, 29);
            this.BtnSalvar.TabIndex = 7;
            this.BtnSalvar.Text = "Salvar";
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
            this.CmbTurmaAtual.Location = new System.Drawing.Point(550, 143);
            this.CmbTurmaAtual.Name = "CmbTurmaAtual";
            this.CmbTurmaAtual.Size = new System.Drawing.Size(68, 41);
            this.CmbTurmaAtual.TabIndex = 21;
            // 
            // TxtTurmaAtual
            // 
            this.TxtTurmaAtual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTurmaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTurmaAtual.Location = new System.Drawing.Point(613, 143);
            this.TxtTurmaAtual.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTurmaAtual.Name = "TxtTurmaAtual";
            this.TxtTurmaAtual.ReadOnly = true;
            this.TxtTurmaAtual.Size = new System.Drawing.Size(68, 41);
            this.TxtTurmaAtual.TabIndex = 20;
            // 
            // TxtDataNascimento
            // 
            this.TxtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.TxtDataNascimento.Location = new System.Drawing.Point(10, 143);
            this.TxtDataNascimento.Name = "TxtDataNascimento";
            this.TxtDataNascimento.ReadOnly = true;
            this.TxtDataNascimento.Size = new System.Drawing.Size(206, 41);
            this.TxtDataNascimento.TabIndex = 15;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbTurmaAtual);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.LblNomeCrianca);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.TxtIdadeCrianca);
            this.Controls.Add(this.TxtTurmaAtual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnRegistrarPresenca);
            this.Controls.Add(this.TxtNomeCrianca);
            this.Controls.Add(this.TxtCodigoCadastro);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.linkLabelBuscarPeloNome);
            this.Controls.Add(this.linkLabelBuscarPeloPai);
            this.Controls.Add(this.linkLabelBuscarPelaMae);
            this.Controls.Add(this.linkLabelAtualizarDados);
            this.Controls.Add(this.TxtMaskedDataNascimento);
            this.Controls.Add(this.TxtDataNascimento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(703, 50);
            this.Name = "Principal";
            this.Text = "Cadastro Trilhar - Registro de presença";
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
        private System.Windows.Forms.TextBox TxtCodigoCadastro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtIdadeCrianca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtOutroResponsavel;
        private System.Windows.Forms.TextBox TxtPai;
        private System.Windows.Forms.TextBox TxtMae;
        private System.Windows.Forms.TextBox TxtDescricaoDeficienteAtipicos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDescicaoAlergia;
        private System.Windows.Forms.TextBox TxtDescricaoRestricaoAlimentar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.DateTimePicker TxtMaskedDataNascimento;
        private System.Windows.Forms.TextBox TxtDataNascimento;
    }
}