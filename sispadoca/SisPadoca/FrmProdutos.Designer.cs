namespace SisPadoca
{
    partial class FrmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            PbProduto = new PictureBox();
            LblNCM = new Label();
            TxtNCM = new TextBox();
            TxbDescricao = new TextBox();
            LblDescricao = new Label();
            TxtCodigodeBarras = new TextBox();
            LblCodigoBarras = new Label();
            LblUnidadeMedida = new Label();
            BtnNovo = new Button();
            BtnEditar = new Button();
            BtnExcluir = new Button();
            BtnLimpar = new Button();
            BtnFechar = new Button();
            CbUnidadeMedida = new ComboBox();
            TxtLote = new TextBox();
            LblLote = new Label();
            ((System.ComponentModel.ISupportInitialize)PbProduto).BeginInit();
            SuspendLayout();
            // 
            // PbProduto
            // 
            PbProduto.Image = (Image)resources.GetObject("PbProduto.Image");
            PbProduto.Location = new Point(28, 29);
            PbProduto.Name = "PbProduto";
            PbProduto.Size = new Size(184, 233);
            PbProduto.SizeMode = PictureBoxSizeMode.StretchImage;
            PbProduto.TabIndex = 0;
            PbProduto.TabStop = false;
            // 
            // LblNCM
            // 
            LblNCM.AutoSize = true;
            LblNCM.Location = new Point(238, 32);
            LblNCM.Name = "LblNCM";
            LblNCM.Size = new Size(52, 25);
            LblNCM.TabIndex = 1;
            LblNCM.Text = "NCM";
            // 
            // TxtNCM
            // 
            TxtNCM.Location = new Point(238, 60);
            TxtNCM.Name = "TxtNCM";
            TxtNCM.Size = new Size(239, 31);
            TxtNCM.TabIndex = 2;
            // 
            // TxbDescricao
            // 
            TxbDescricao.Location = new Point(238, 150);
            TxbDescricao.Name = "TxbDescricao";
            TxbDescricao.Size = new Size(239, 31);
            TxbDescricao.TabIndex = 4;
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Location = new Point(238, 122);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(88, 25);
            LblDescricao.TabIndex = 3;
            LblDescricao.Text = "Descrição";
            // 
            // TxtCodigodeBarras
            // 
            TxtCodigodeBarras.Location = new Point(238, 234);
            TxtCodigodeBarras.Name = "TxtCodigodeBarras";
            TxtCodigodeBarras.Size = new Size(239, 31);
            TxtCodigodeBarras.TabIndex = 6;
            // 
            // LblCodigoBarras
            // 
            LblCodigoBarras.AutoSize = true;
            LblCodigoBarras.Location = new Point(238, 206);
            LblCodigoBarras.Name = "LblCodigoBarras";
            LblCodigoBarras.Size = new Size(149, 25);
            LblCodigoBarras.TabIndex = 5;
            LblCodigoBarras.Text = "Código de Barras";
            // 
            // LblUnidadeMedida
            // 
            LblUnidadeMedida.AutoSize = true;
            LblUnidadeMedida.Location = new Point(499, 122);
            LblUnidadeMedida.Name = "LblUnidadeMedida";
            LblUnidadeMedida.Size = new Size(143, 25);
            LblUnidadeMedida.TabIndex = 7;
            LblUnidadeMedida.Text = "Unidade medida";
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(28, 327);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(145, 76);
            BtnNovo.TabIndex = 9;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(196, 327);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(145, 76);
            BtnEditar.TabIndex = 10;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(360, 327);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(145, 76);
            BtnExcluir.TabIndex = 11;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(626, 327);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(145, 76);
            BtnLimpar.TabIndex = 12;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(786, 327);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(145, 76);
            BtnFechar.TabIndex = 13;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            // 
            // CbUnidadeMedida
            // 
            CbUnidadeMedida.FormattingEnabled = true;
            CbUnidadeMedida.Items.AddRange(new object[] { "Unitário", "Kilo", "Dúzia" });
            CbUnidadeMedida.Location = new Point(499, 150);
            CbUnidadeMedida.Name = "CbUnidadeMedida";
            CbUnidadeMedida.Size = new Size(182, 33);
            CbUnidadeMedida.TabIndex = 14;
            // 
            // TxtLote
            // 
            TxtLote.Location = new Point(499, 231);
            TxtLote.Name = "TxtLote";
            TxtLote.Size = new Size(239, 31);
            TxtLote.TabIndex = 16;
            // 
            // LblLote
            // 
            LblLote.AutoSize = true;
            LblLote.Location = new Point(499, 206);
            LblLote.Name = "LblLote";
            LblLote.Size = new Size(46, 25);
            LblLote.TabIndex = 15;
            LblLote.Text = "Lote";
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(935, 414);
            Controls.Add(TxtLote);
            Controls.Add(LblLote);
            Controls.Add(CbUnidadeMedida);
            Controls.Add(BtnFechar);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(BtnNovo);
            Controls.Add(LblUnidadeMedida);
            Controls.Add(TxtCodigodeBarras);
            Controls.Add(LblCodigoBarras);
            Controls.Add(TxbDescricao);
            Controls.Add(LblDescricao);
            Controls.Add(TxtNCM);
            Controls.Add(LblNCM);
            Controls.Add(PbProduto);
            Name = "FrmProdutos";
            Text = "FrmProdutos";
            Load += FrmProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)PbProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PbProduto;
        private Label LblNCM;
        private TextBox TxtNCM;
        private TextBox TxbDescricao;
        private Label LblDescricao;
        private TextBox TxtCodigodeBarras;
        private Label LblCodigoBarras;
        private Label LblUnidadeMedida;
        private Button BtnNovo;
        private Button BtnEditar;
        private Button BtnExcluir;
        private Button BtnLimpar;
        private Button BtnFechar;
        private ComboBox CbUnidadeMedida;
        private TextBox TxtLote;
        private Label LblLote;
    }
}