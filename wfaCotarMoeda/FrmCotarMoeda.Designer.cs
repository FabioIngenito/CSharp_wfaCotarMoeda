namespace wfaCotarMoeda
{
    partial class FrmCotarMoeda
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
            this.LblSelecionarMoeda = new System.Windows.Forms.Label();
            this.CmbMoeda = new System.Windows.Forms.ComboBox();
            this.BtnBuscarValor = new System.Windows.Forms.Button();
            this.LblValor = new System.Windows.Forms.Label();
            this.grbConexao = new System.Windows.Forms.GroupBox();
            this.rdoWebReferences = new System.Windows.Forms.RadioButton();
            this.rdoConnectedServices = new System.Windows.Forms.RadioButton();
            this.dtpCotarMoeda = new System.Windows.Forms.DateTimePicker();
            this.grbConexao.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblSelecionarMoeda
            // 
            this.LblSelecionarMoeda.AutoSize = true;
            this.LblSelecionarMoeda.Location = new System.Drawing.Point(12, 9);
            this.LblSelecionarMoeda.Name = "LblSelecionarMoeda";
            this.LblSelecionarMoeda.Size = new System.Drawing.Size(105, 13);
            this.LblSelecionarMoeda.TabIndex = 0;
            this.LblSelecionarMoeda.Text = "Selecionar a Moeda:";
            // 
            // CmbMoeda
            // 
            this.CmbMoeda.FormattingEnabled = true;
            this.CmbMoeda.Location = new System.Drawing.Point(12, 25);
            this.CmbMoeda.Name = "CmbMoeda";
            this.CmbMoeda.Size = new System.Drawing.Size(199, 21);
            this.CmbMoeda.TabIndex = 1;
            // 
            // BtnBuscarValor
            // 
            this.BtnBuscarValor.Location = new System.Drawing.Point(216, 78);
            this.BtnBuscarValor.Name = "BtnBuscarValor";
            this.BtnBuscarValor.Size = new System.Drawing.Size(164, 35);
            this.BtnBuscarValor.TabIndex = 6;
            this.BtnBuscarValor.Text = "&Buscar Valor";
            this.BtnBuscarValor.UseVisualStyleBackColor = true;
            this.BtnBuscarValor.Click += new System.EventHandler(this.BtnBuscarValor_Click);
            // 
            // LblValor
            // 
            this.LblValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor.Location = new System.Drawing.Point(217, 9);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(163, 66);
            this.LblValor.TabIndex = 5;
            this.LblValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbConexao
            // 
            this.grbConexao.Controls.Add(this.rdoWebReferences);
            this.grbConexao.Controls.Add(this.rdoConnectedServices);
            this.grbConexao.Location = new System.Drawing.Point(12, 52);
            this.grbConexao.Name = "grbConexao";
            this.grbConexao.Size = new System.Drawing.Size(198, 61);
            this.grbConexao.TabIndex = 2;
            this.grbConexao.TabStop = false;
            // 
            // rdoWebReferences
            // 
            this.rdoWebReferences.AutoSize = true;
            this.rdoWebReferences.Checked = true;
            this.rdoWebReferences.Location = new System.Drawing.Point(6, 36);
            this.rdoWebReferences.Name = "rdoWebReferences";
            this.rdoWebReferences.Size = new System.Drawing.Size(106, 17);
            this.rdoWebReferences.TabIndex = 4;
            this.rdoWebReferences.TabStop = true;
            this.rdoWebReferences.Text = "Web References";
            this.rdoWebReferences.UseVisualStyleBackColor = true;
            // 
            // rdoConnectedServices
            // 
            this.rdoConnectedServices.AutoSize = true;
            this.rdoConnectedServices.Location = new System.Drawing.Point(6, 13);
            this.rdoConnectedServices.Name = "rdoConnectedServices";
            this.rdoConnectedServices.Size = new System.Drawing.Size(121, 17);
            this.rdoConnectedServices.TabIndex = 3;
            this.rdoConnectedServices.Text = "Connected Services";
            this.rdoConnectedServices.UseVisualStyleBackColor = true;
            // 
            // dtpCotarMoeda
            // 
            this.dtpCotarMoeda.Location = new System.Drawing.Point(12, 120);
            this.dtpCotarMoeda.Name = "dtpCotarMoeda";
            this.dtpCotarMoeda.Size = new System.Drawing.Size(368, 20);
            this.dtpCotarMoeda.TabIndex = 7;
            this.dtpCotarMoeda.TabStop = false;
            this.dtpCotarMoeda.Value = new System.DateTime(1900, 1, 1, 12, 0, 0, 0);
            // 
            // FrmCotarMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 148);
            this.Controls.Add(this.dtpCotarMoeda);
            this.Controls.Add(this.grbConexao);
            this.Controls.Add(this.LblValor);
            this.Controls.Add(this.BtnBuscarValor);
            this.Controls.Add(this.CmbMoeda);
            this.Controls.Add(this.LblSelecionarMoeda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCotarMoeda";
            this.ShowIcon = false;
            this.Text = "Cotar Moeda";
            this.Load += new System.EventHandler(this.FrmCotarMoeda_Load);
            this.grbConexao.ResumeLayout(false);
            this.grbConexao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSelecionarMoeda;
        private System.Windows.Forms.ComboBox CmbMoeda;
        private System.Windows.Forms.Button BtnBuscarValor;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.GroupBox grbConexao;
        private System.Windows.Forms.RadioButton rdoConnectedServices;
        private System.Windows.Forms.RadioButton rdoWebReferences;
        private System.Windows.Forms.DateTimePicker dtpCotarMoeda;
    }
}

