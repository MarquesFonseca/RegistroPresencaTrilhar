
namespace RegistroPresencaTrilhar
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
            this.TxtDataNascimento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTurmaAtual = new System.Windows.Forms.TextBox();
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
            this.TxtAlergia = new System.Windows.Forms.TextBox();
            this.TxtRestrincaoAlimentar = new System.Windows.Forms.TextBox();
            this.TxtDeficienteAtipicos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
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
            this.linkLabelBuscarPeloPai.Location = new System.Drawing.Point(569, 9);
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
            this.linkLabelAtualizarDados.Location = new System.Drawing.Point(795, 9);
            this.linkLabelAtualizarDados.Name = "linkLabelAtualizarDados";
            this.linkLabelAtualizarDados.Size = new System.Drawing.Size(239, 29);
            this.linkLabelAtualizarDados.TabIndex = 3;
            this.linkLabelAtualizarDados.TabStop = true;
            this.linkLabelAtualizarDados.Text = "[F5] - Atualizar dados";
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
            this.BtnRegistrarPresenca.TabIndex = 8;
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
            this.TxtNomeCrianca.TabIndex = 7;
            // 
            // LblNomeCrianca
            // 
            this.LblNomeCrianca.AutoSize = true;
            this.LblNomeCrianca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeCrianca.Location = new System.Drawing.Point(225, 72);
            this.LblNomeCrianca.Name = "LblNomeCrianca";
            this.LblNomeCrianca.Size = new System.Drawing.Size(270, 37);
            this.LblNomeCrianca.TabIndex = 6;
            this.LblNomeCrianca.Text = "Nome da criança:";
            // 
            // TxtCodigoCadastro
            // 
            this.TxtCodigoCadastro.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCodigoCadastro.CausesValidation = false;
            this.TxtCodigoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.TxtCodigoCadastro.ForeColor = System.Drawing.Color.Red;
            this.TxtCodigoCadastro.Location = new System.Drawing.Point(16, 112);
            this.TxtCodigoCadastro.Name = "TxtCodigoCadastro";
            this.TxtCodigoCadastro.Size = new System.Drawing.Size(192, 57);
            this.TxtCodigoCadastro.TabIndex = 5;
            this.TxtCodigoCadastro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigoCadastro_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 37);
            this.label15.TabIndex = 4;
            this.label15.Text = "Código cad.:";
            // 
            // TxtIdadeCrianca
            // 
            this.TxtIdadeCrianca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtIdadeCrianca.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdadeCrianca.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtIdadeCrianca.Location = new System.Drawing.Point(394, 222);
            this.TxtIdadeCrianca.Name = "TxtIdadeCrianca";
            this.TxtIdadeCrianca.ReadOnly = true;
            this.TxtIdadeCrianca.Size = new System.Drawing.Size(625, 57);
            this.TxtIdadeCrianca.TabIndex = 14;
            // 
            // TxtDataNascimento
            // 
            this.TxtDataNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDataNascimento.Location = new System.Drawing.Point(77, 222);
            this.TxtDataNascimento.Name = "TxtDataNascimento";
            this.TxtDataNascimento.ReadOnly = true;
            this.TxtDataNascimento.Size = new System.Drawing.Size(311, 57);
            this.TxtDataNascimento.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data de nascimento:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Idade da criança:";
            // 
            // TxtTurmaAtual
            // 
            this.TxtTurmaAtual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTurmaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.TxtTurmaAtual.Location = new System.Drawing.Point(16, 222);
            this.TxtTurmaAtual.Name = "TxtTurmaAtual";
            this.TxtTurmaAtual.ReadOnly = true;
            this.TxtTurmaAtual.Size = new System.Drawing.Size(55, 57);
            this.TxtTurmaAtual.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 37);
            this.label3.TabIndex = 9;
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
            this.TxtDescricaoDeficienteAtipicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescricaoDeficienteAtipicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescricaoDeficienteAtipicos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtDescricaoDeficienteAtipicos.Location = new System.Drawing.Point(675, 376);
            this.TxtDescricaoDeficienteAtipicos.Multiline = true;
            this.TxtDescricaoDeficienteAtipicos.Name = "TxtDescricaoDeficienteAtipicos";
            this.TxtDescricaoDeficienteAtipicos.ReadOnly = true;
            this.TxtDescricaoDeficienteAtipicos.Size = new System.Drawing.Size(332, 146);
            this.TxtDescricaoDeficienteAtipicos.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(339, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(301, 37);
            this.label10.TabIndex = 12;
            this.label10.Text = "Restrição alimentar:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(339, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(330, 37);
            this.label13.TabIndex = 18;
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
            this.TxtDescicaoAlergia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescicaoAlergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescicaoAlergia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtDescicaoAlergia.Location = new System.Drawing.Point(3, 376);
            this.TxtDescicaoAlergia.Multiline = true;
            this.TxtDescicaoAlergia.Name = "TxtDescicaoAlergia";
            this.TxtDescicaoAlergia.ReadOnly = true;
            this.TxtDescicaoAlergia.Size = new System.Drawing.Size(330, 146);
            this.TxtDescicaoAlergia.TabIndex = 17;
            // 
            // TxtDescricaoRestricaoAlimentar
            // 
            this.TxtDescricaoRestricaoAlimentar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescricaoRestricaoAlimentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescricaoRestricaoAlimentar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtDescricaoRestricaoAlimentar.Location = new System.Drawing.Point(339, 376);
            this.TxtDescricaoRestricaoAlimentar.Multiline = true;
            this.TxtDescricaoRestricaoAlimentar.Name = "TxtDescricaoRestricaoAlimentar";
            this.TxtDescricaoRestricaoAlimentar.ReadOnly = true;
            this.TxtDescricaoRestricaoAlimentar.Size = new System.Drawing.Size(330, 146);
            this.TxtDescricaoRestricaoAlimentar.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(318, 37);
            this.label9.TabIndex = 16;
            this.label9.Text = "Descrição da alergia:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(675, 325);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(332, 37);
            this.label14.TabIndex = 20;
            this.label14.Text = "Descrições atípicas:";
            // 
            // TxtAlergia
            // 
            this.TxtAlergia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAlergia.BackColor = System.Drawing.SystemColors.Control;
            this.TxtAlergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAlergia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtAlergia.Location = new System.Drawing.Point(3, 259);
            this.TxtAlergia.Name = "TxtAlergia";
            this.TxtAlergia.ReadOnly = true;
            this.TxtAlergia.Size = new System.Drawing.Size(330, 53);
            this.TxtAlergia.TabIndex = 11;
            // 
            // TxtRestrincaoAlimentar
            // 
            this.TxtRestrincaoAlimentar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRestrincaoAlimentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRestrincaoAlimentar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtRestrincaoAlimentar.Location = new System.Drawing.Point(339, 259);
            this.TxtRestrincaoAlimentar.Name = "TxtRestrincaoAlimentar";
            this.TxtRestrincaoAlimentar.ReadOnly = true;
            this.TxtRestrincaoAlimentar.Size = new System.Drawing.Size(330, 53);
            this.TxtRestrincaoAlimentar.TabIndex = 13;
            // 
            // TxtDeficienteAtipicos
            // 
            this.TxtDeficienteAtipicos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDeficienteAtipicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDeficienteAtipicos.Location = new System.Drawing.Point(675, 259);
            this.TxtDeficienteAtipicos.Name = "TxtDeficienteAtipicos";
            this.TxtDeficienteAtipicos.ReadOnly = true;
            this.TxtDeficienteAtipicos.Size = new System.Drawing.Size(332, 53);
            this.TxtDeficienteAtipicos.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(675, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(297, 37);
            this.label11.TabIndex = 14;
            this.label11.Text = "Deficiente / Atípicos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 37);
            this.label12.TabIndex = 10;
            this.label12.Text = "Alergia:";
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefone.Location = new System.Drawing.Point(3, 151);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.ReadOnly = true;
            this.TxtTelefone.Size = new System.Drawing.Size(330, 53);
            this.TxtTelefone.TabIndex = 7;
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
            this.tableLayoutPanel1.Controls.Add(this.TxtAlergia, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.TxtRestrincaoAlimentar, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.TxtDeficienteAtipicos, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtTelefone, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtEmail, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 291);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1010, 525);
            this.tableLayoutPanel1.TabIndex = 33;
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
            this.statusStrip1.Size = new System.Drawing.Size(377, 72);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDiaSemana
            // 
            this.toolStripStatusLabelDiaSemana.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripStatusLabelDiaSemana.Name = "toolStripStatusLabelDiaSemana";
            this.toolStripStatusLabelDiaSemana.Size = new System.Drawing.Size(178, 65);
            this.toolStripStatusLabelDiaSemana.Text = "DiaSemana";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(28, 65);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabelDataHora
            // 
            this.toolStripStatusLabelDataHora.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripStatusLabelDataHora.Name = "toolStripStatusLabelDataHora";
            this.toolStripStatusLabelDataHora.Size = new System.Drawing.Size(154, 65);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 822);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1040, 72);
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
            this.statusStrip2.Size = new System.Drawing.Size(800, 72);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabelUltimaAtualizacao
            // 
            this.toolStripStatusLabelUltimaAtualizacao.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripStatusLabelUltimaAtualizacao.Name = "toolStripStatusLabelUltimaAtualizacao";
            this.toolStripStatusLabelUltimaAtualizacao.Size = new System.Drawing.Size(223, 65);
            this.toolStripStatusLabelUltimaAtualizacao.Text = "UltAtualizacao";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(28, 65);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabelTotalRegistros
            // 
            this.toolStripStatusLabelTotalRegistros.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripStatusLabelTotalRegistros.Name = "toolStripStatusLabelTotalRegistros";
            this.toolStripStatusLabelTotalRegistros.Size = new System.Drawing.Size(208, 65);
            this.toolStripStatusLabelTotalRegistros.Text = "TotalRegistos";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 894);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtIdadeCrianca);
            this.Controls.Add(this.TxtDataNascimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TxtTurmaAtual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnRegistrarPresenca);
            this.Controls.Add(this.TxtNomeCrianca);
            this.Controls.Add(this.LblNomeCrianca);
            this.Controls.Add(this.TxtCodigoCadastro);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.linkLabelBuscarPeloNome);
            this.Controls.Add(this.linkLabelBuscarPeloPai);
            this.Controls.Add(this.linkLabelBuscarPelaMae);
            this.Controls.Add(this.linkLabelAtualizarDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1052, 56);
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
        private System.Windows.Forms.TextBox TxtDataNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTurmaAtual;
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
        private System.Windows.Forms.TextBox TxtAlergia;
        private System.Windows.Forms.TextBox TxtRestrincaoAlimentar;
        private System.Windows.Forms.TextBox TxtDeficienteAtipicos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtTelefone;
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
    }
}