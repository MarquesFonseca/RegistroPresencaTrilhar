namespace Trilhar.Forms
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastro_CadastroCriancaTrilhar = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioTesteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesTelaConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExibirCaixaPostalPesquisa_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExibirItensJaEntreguesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manterConsultaSempreAtualizadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PermiriBuscarPorLDINaPesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirListaDeEntregaParaConsultaSelecionadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeloLDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeloComumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirAvisosDeChegadaSelecionadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirListaDeEntregaParaConsultaSelecionadaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirListaLDIsExpediçãoPorOrdemDeDecrescenteAoLançamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirListaLDIsAssinaturasPorOrdemAlfabéticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirAvisoDeChegadaHOJEExcetoEntreguesECaixaPostalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.marcarSelecionadosComoAtualizadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcarSelecionadosComoNaoAtualizadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.removerLinhasSelecionadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.botao_CadastroCriancaTrilhar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.VisualizarListaObjetos_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerAtualizacaoNovosRegistros = new System.Windows.Forms.Timer(this.components);
            this.timerAtualizaDataHoraAtualBarraStatus = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.opçõesTelaConsultaToolStripMenuItem,
            this.viewMenu,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Stretch = false;
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastro_CadastroCriancaTrilhar,
            this.cadastroDeUsuárioToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairDoSistemaToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            resources.ApplyResources(this.cadastrosToolStripMenuItem, "cadastrosToolStripMenuItem");
            // 
            // menuCadastro_CadastroCriancaTrilhar
            // 
            this.menuCadastro_CadastroCriancaTrilhar.Name = "menuCadastro_CadastroCriancaTrilhar";
            resources.ApplyResources(this.menuCadastro_CadastroCriancaTrilhar, "menuCadastro_CadastroCriancaTrilhar");
            this.menuCadastro_CadastroCriancaTrilhar.Click += new System.EventHandler(this.menuCadastro_CadastroCriancaTrilhar_Click);
            // 
            // cadastroDeUsuárioToolStripMenuItem
            // 
            this.cadastroDeUsuárioToolStripMenuItem.Name = "cadastroDeUsuárioToolStripMenuItem";
            resources.ApplyResources(this.cadastroDeUsuárioToolStripMenuItem, "cadastroDeUsuárioToolStripMenuItem");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // sairDoSistemaToolStripMenuItem
            // 
            this.sairDoSistemaToolStripMenuItem.Name = "sairDoSistemaToolStripMenuItem";
            resources.ApplyResources(this.sairDoSistemaToolStripMenuItem, "sairDoSistemaToolStripMenuItem");
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatorioTesteToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            resources.ApplyResources(this.relatóriosToolStripMenuItem, "relatóriosToolStripMenuItem");
            // 
            // relatorioTesteToolStripMenuItem
            // 
            this.relatorioTesteToolStripMenuItem.Name = "relatorioTesteToolStripMenuItem";
            resources.ApplyResources(this.relatorioTesteToolStripMenuItem, "relatorioTesteToolStripMenuItem");
            // 
            // opçõesTelaConsultaToolStripMenuItem
            // 
            this.opçõesTelaConsultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExibirCaixaPostalPesquisa_toolStripMenuItem,
            this.ExibirItensJaEntreguesToolStripMenuItem,
            this.manterConsultaSempreAtualizadaToolStripMenuItem,
            this.PermiriBuscarPorLDINaPesquisaToolStripMenuItem,
            this.toolStripSeparator3,
            this.imprimirListaDeEntregaParaConsultaSelecionadaToolStripMenuItem,
            this.imprimirAvisosDeChegadaSelecionadosToolStripMenuItem,
            this.toolStripSeparator11,
            this.imprimirListaDeEntregaParaConsultaSelecionadaToolStripMenuItem1,
            this.imprimirListaLDIsExpediçãoPorOrdemDeDecrescenteAoLançamentoToolStripMenuItem,
            this.imprimirListaLDIsAssinaturasPorOrdemAlfabéticaToolStripMenuItem,
            this.imprimirAvisoDeChegadaHOJEExcetoEntreguesECaixaPostalToolStripMenuItem,
            this.toolStripSeparator6,
            this.marcarSelecionadosComoAtualizadoToolStripMenuItem,
            this.marcarSelecionadosComoNaoAtualizadoToolStripMenuItem,
            this.toolStripSeparator8,
            this.removerLinhasSelecionadasToolStripMenuItem});
            this.opçõesTelaConsultaToolStripMenuItem.Name = "opçõesTelaConsultaToolStripMenuItem";
            resources.ApplyResources(this.opçõesTelaConsultaToolStripMenuItem, "opçõesTelaConsultaToolStripMenuItem");
            // 
            // ExibirCaixaPostalPesquisa_toolStripMenuItem
            // 
            this.ExibirCaixaPostalPesquisa_toolStripMenuItem.CheckOnClick = true;
            this.ExibirCaixaPostalPesquisa_toolStripMenuItem.Name = "ExibirCaixaPostalPesquisa_toolStripMenuItem";
            resources.ApplyResources(this.ExibirCaixaPostalPesquisa_toolStripMenuItem, "ExibirCaixaPostalPesquisa_toolStripMenuItem");
            // 
            // ExibirItensJaEntreguesToolStripMenuItem
            // 
            this.ExibirItensJaEntreguesToolStripMenuItem.CheckOnClick = true;
            this.ExibirItensJaEntreguesToolStripMenuItem.Name = "ExibirItensJaEntreguesToolStripMenuItem";
            resources.ApplyResources(this.ExibirItensJaEntreguesToolStripMenuItem, "ExibirItensJaEntreguesToolStripMenuItem");
            // 
            // manterConsultaSempreAtualizadaToolStripMenuItem
            // 
            this.manterConsultaSempreAtualizadaToolStripMenuItem.Checked = true;
            this.manterConsultaSempreAtualizadaToolStripMenuItem.CheckOnClick = true;
            this.manterConsultaSempreAtualizadaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.manterConsultaSempreAtualizadaToolStripMenuItem.Name = "manterConsultaSempreAtualizadaToolStripMenuItem";
            resources.ApplyResources(this.manterConsultaSempreAtualizadaToolStripMenuItem, "manterConsultaSempreAtualizadaToolStripMenuItem");
            // 
            // PermiriBuscarPorLDINaPesquisaToolStripMenuItem
            // 
            this.PermiriBuscarPorLDINaPesquisaToolStripMenuItem.Checked = true;
            this.PermiriBuscarPorLDINaPesquisaToolStripMenuItem.CheckOnClick = true;
            this.PermiriBuscarPorLDINaPesquisaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PermiriBuscarPorLDINaPesquisaToolStripMenuItem.Name = "PermiriBuscarPorLDINaPesquisaToolStripMenuItem";
            resources.ApplyResources(this.PermiriBuscarPorLDINaPesquisaToolStripMenuItem, "PermiriBuscarPorLDINaPesquisaToolStripMenuItem");
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // imprimirListaDeEntregaParaConsultaSelecionadaToolStripMenuItem
            // 
            this.imprimirListaDeEntregaParaConsultaSelecionadaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeloLDIToolStripMenuItem,
            this.modeloComumToolStripMenuItem});
            this.imprimirListaDeEntregaParaConsultaSelecionadaToolStripMenuItem.Name = "imprimirListaDeEntregaParaConsultaSelecionadaToolStripMenuItem";
            resources.ApplyResources(this.imprimirListaDeEntregaParaConsultaSelecionadaToolStripMenuItem, "imprimirListaDeEntregaParaConsultaSelecionadaToolStripMenuItem");
            // 
            // modeloLDIToolStripMenuItem
            // 
            this.modeloLDIToolStripMenuItem.Name = "modeloLDIToolStripMenuItem";
            resources.ApplyResources(this.modeloLDIToolStripMenuItem, "modeloLDIToolStripMenuItem");
            // 
            // modeloComumToolStripMenuItem
            // 
            this.modeloComumToolStripMenuItem.Name = "modeloComumToolStripMenuItem";
            resources.ApplyResources(this.modeloComumToolStripMenuItem, "modeloComumToolStripMenuItem");
            // 
            // imprimirAvisosDeChegadaSelecionadosToolStripMenuItem
            // 
            this.imprimirAvisosDeChegadaSelecionadosToolStripMenuItem.Name = "imprimirAvisosDeChegadaSelecionadosToolStripMenuItem";
            resources.ApplyResources(this.imprimirAvisosDeChegadaSelecionadosToolStripMenuItem, "imprimirAvisosDeChegadaSelecionadosToolStripMenuItem");
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            resources.ApplyResources(this.toolStripSeparator11, "toolStripSeparator11");
            // 
            // imprimirListaDeEntregaParaConsultaSelecionadaToolStripMenuItem1
            // 
            this.imprimirListaDeEntregaParaConsultaSelecionadaToolStripMenuItem1.Name = "imprimirListaDeEntregaParaConsultaSelecionadaToolStripMenuItem1";
            resources.ApplyResources(this.imprimirListaDeEntregaParaConsultaSelecionadaToolStripMenuItem1, "imprimirListaDeEntregaParaConsultaSelecionadaToolStripMenuItem1");
            // 
            // imprimirListaLDIsExpediçãoPorOrdemDeDecrescenteAoLançamentoToolStripMenuItem
            // 
            this.imprimirListaLDIsExpediçãoPorOrdemDeDecrescenteAoLançamentoToolStripMenuItem.Name = "imprimirListaLDIsExpediçãoPorOrdemDeDecrescenteAoLançamentoToolStripMenuItem";
            resources.ApplyResources(this.imprimirListaLDIsExpediçãoPorOrdemDeDecrescenteAoLançamentoToolStripMenuItem, "imprimirListaLDIsExpediçãoPorOrdemDeDecrescenteAoLançamentoToolStripMenuItem");
            // 
            // imprimirListaLDIsAssinaturasPorOrdemAlfabéticaToolStripMenuItem
            // 
            this.imprimirListaLDIsAssinaturasPorOrdemAlfabéticaToolStripMenuItem.Name = "imprimirListaLDIsAssinaturasPorOrdemAlfabéticaToolStripMenuItem";
            resources.ApplyResources(this.imprimirListaLDIsAssinaturasPorOrdemAlfabéticaToolStripMenuItem, "imprimirListaLDIsAssinaturasPorOrdemAlfabéticaToolStripMenuItem");
            // 
            // imprimirAvisoDeChegadaHOJEExcetoEntreguesECaixaPostalToolStripMenuItem
            // 
            this.imprimirAvisoDeChegadaHOJEExcetoEntreguesECaixaPostalToolStripMenuItem.Name = "imprimirAvisoDeChegadaHOJEExcetoEntreguesECaixaPostalToolStripMenuItem";
            resources.ApplyResources(this.imprimirAvisoDeChegadaHOJEExcetoEntreguesECaixaPostalToolStripMenuItem, "imprimirAvisoDeChegadaHOJEExcetoEntreguesECaixaPostalToolStripMenuItem");
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // marcarSelecionadosComoAtualizadoToolStripMenuItem
            // 
            this.marcarSelecionadosComoAtualizadoToolStripMenuItem.Name = "marcarSelecionadosComoAtualizadoToolStripMenuItem";
            resources.ApplyResources(this.marcarSelecionadosComoAtualizadoToolStripMenuItem, "marcarSelecionadosComoAtualizadoToolStripMenuItem");
            // 
            // marcarSelecionadosComoNaoAtualizadoToolStripMenuItem
            // 
            this.marcarSelecionadosComoNaoAtualizadoToolStripMenuItem.Name = "marcarSelecionadosComoNaoAtualizadoToolStripMenuItem";
            resources.ApplyResources(this.marcarSelecionadosComoNaoAtualizadoToolStripMenuItem, "marcarSelecionadosComoNaoAtualizadoToolStripMenuItem");
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // removerLinhasSelecionadasToolStripMenuItem
            // 
            this.removerLinhasSelecionadasToolStripMenuItem.Name = "removerLinhasSelecionadasToolStripMenuItem";
            resources.ApplyResources(this.removerLinhasSelecionadasToolStripMenuItem, "removerLinhasSelecionadasToolStripMenuItem");
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            resources.ApplyResources(this.viewMenu, "viewMenu");
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            resources.ApplyResources(this.toolBarToolStripMenuItem, "toolBarToolStripMenuItem");
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            resources.ApplyResources(this.statusBarToolStripMenuItem, "statusBarToolStripMenuItem");
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            resources.ApplyResources(this.windowsMenu, "windowsMenu");
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            resources.ApplyResources(this.cascadeToolStripMenuItem, "cascadeToolStripMenuItem");
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            resources.ApplyResources(this.tileVerticalToolStripMenuItem, "tileVerticalToolStripMenuItem");
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            resources.ApplyResources(this.tileHorizontalToolStripMenuItem, "tileHorizontalToolStripMenuItem");
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            resources.ApplyResources(this.closeAllToolStripMenuItem, "closeAllToolStripMenuItem");
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            resources.ApplyResources(this.helpMenu, "helpMenu");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botao_CadastroCriancaTrilhar,
            this.toolStripSeparator9,
            this.VisualizarListaObjetos_toolStripButton});
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.Name = "toolStrip";
            // 
            // botao_CadastroCriancaTrilhar
            // 
            resources.ApplyResources(this.botao_CadastroCriancaTrilhar, "botao_CadastroCriancaTrilhar");
            this.botao_CadastroCriancaTrilhar.Name = "botao_CadastroCriancaTrilhar";
            this.botao_CadastroCriancaTrilhar.Click += new System.EventHandler(this.botao_CadastroCriancaTrilhar_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            // 
            // VisualizarListaObjetos_toolStripButton
            // 
            resources.ApplyResources(this.VisualizarListaObjetos_toolStripButton, "VisualizarListaObjetos_toolStripButton");
            this.VisualizarListaObjetos_toolStripButton.Name = "VisualizarListaObjetos_toolStripButton";
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Name = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            resources.ApplyResources(this.toolStripStatusLabel, "toolStripStatusLabel");
            this.toolStripStatusLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // timerAtualizaDataHoraAtualBarraStatus
            // 
            this.timerAtualizaDataHoraAtualBarraStatus.Enabled = true;
            this.timerAtualizaDataHoraAtualBarraStatus.Interval = 1000;
            // 
            // FormPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton VisualizarListaObjetos_toolStripButton;
        private System.Windows.Forms.ToolStripButton botao_CadastroCriancaTrilhar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem imprimirListaDeEntregaParaConsultaSelecionadaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ExibirCaixaPostalPesquisa_toolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ExibirItensJaEntreguesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.Timer timerAtualizacaoNovosRegistros;
        private System.Windows.Forms.ToolStripMenuItem imprimirListaDeEntregaParaConsultaSelecionadaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manterConsultaSempreAtualizadaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem PermiriBuscarPorLDINaPesquisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcarSelecionadosComoAtualizadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcarSelecionadosComoNaoAtualizadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem removerLinhasSelecionadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ToolStripMenuItem modeloLDIToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem modeloComumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirAvisosDeChegadaSelecionadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesTelaConsultaToolStripMenuItem;
        public System.Windows.Forms.Timer timerAtualizaDataHoraAtualBarraStatus;
        private System.Windows.Forms.ToolStripMenuItem imprimirListaLDIsAssinaturasPorOrdemAlfabéticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem imprimirAvisoDeChegadaHOJEExcetoEntreguesECaixaPostalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirListaLDIsExpediçãoPorOrdemDeDecrescenteAoLançamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioTesteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairDoSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro_CadastroCriancaTrilhar;
    }
}