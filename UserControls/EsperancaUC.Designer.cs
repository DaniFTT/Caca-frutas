
namespace Caça_frutas.UserControls
{
    partial class EsperancaUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsperancaUC));
            this.btnDiminuiBet = new System.Windows.Forms.PictureBox();
            this.btnAumentaBet = new System.Windows.Forms.PictureBox();
            this.lvTotal = new System.Windows.Forms.ListView();
            this.chTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLucroE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblValorEsperanca = new System.Windows.Forms.Label();
            this.lvEsperanca = new System.Windows.Forms.ListView();
            this.chPaga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGanha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLucro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLucroP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPLucro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btTelaDiagrama = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnDiminuiBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAumentaBet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDiminuiBet
            // 
            this.btnDiminuiBet.BackColor = System.Drawing.Color.Transparent;
            this.btnDiminuiBet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiminuiBet.Image = ((System.Drawing.Image)(resources.GetObject("btnDiminuiBet.Image")));
            this.btnDiminuiBet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDiminuiBet.Location = new System.Drawing.Point(3, 118);
            this.btnDiminuiBet.Name = "btnDiminuiBet";
            this.btnDiminuiBet.Size = new System.Drawing.Size(37, 37);
            this.btnDiminuiBet.TabIndex = 19;
            this.btnDiminuiBet.TabStop = false;
            this.btnDiminuiBet.Click += new System.EventHandler(this.btnDiminuiBet_Click);
            // 
            // btnAumentaBet
            // 
            this.btnAumentaBet.BackColor = System.Drawing.Color.Transparent;
            this.btnAumentaBet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAumentaBet.Image = ((System.Drawing.Image)(resources.GetObject("btnAumentaBet.Image")));
            this.btnAumentaBet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAumentaBet.Location = new System.Drawing.Point(92, 118);
            this.btnAumentaBet.Name = "btnAumentaBet";
            this.btnAumentaBet.Size = new System.Drawing.Size(37, 37);
            this.btnAumentaBet.TabIndex = 20;
            this.btnAumentaBet.TabStop = false;
            this.btnAumentaBet.Click += new System.EventHandler(this.btnAumentaBet_Click);
            // 
            // lvTotal
            // 
            this.lvTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvTotal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTotal,
            this.chE,
            this.chLucroE});
            this.lvTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTotal.ForeColor = System.Drawing.Color.OrangeRed;
            this.lvTotal.FullRowSelect = true;
            this.lvTotal.GridLines = true;
            this.lvTotal.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvTotal.HideSelection = false;
            this.lvTotal.Location = new System.Drawing.Point(141, 125);
            this.lvTotal.Name = "lvTotal";
            this.lvTotal.Size = new System.Drawing.Size(281, 22);
            this.lvTotal.TabIndex = 18;
            this.lvTotal.UseCompatibleStateImageBehavior = false;
            this.lvTotal.View = System.Windows.Forms.View.Details;
            // 
            // chTotal
            // 
            this.chTotal.Text = "Total";
            this.chTotal.Width = 70;
            // 
            // chE
            // 
            this.chE.Text = "Ganha";
            this.chE.Width = 75;
            // 
            // chLucroE
            // 
            this.chLucroE.Width = 135;
            // 
            // lblValorEsperanca
            // 
            this.lblValorEsperanca.AutoSize = true;
            this.lblValorEsperanca.BackColor = System.Drawing.Color.Transparent;
            this.lblValorEsperanca.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorEsperanca.ForeColor = System.Drawing.Color.Orange;
            this.lblValorEsperanca.Location = new System.Drawing.Point(38, 123);
            this.lblValorEsperanca.Name = "lblValorEsperanca";
            this.lblValorEsperanca.Size = new System.Drawing.Size(45, 23);
            this.lblValorEsperanca.TabIndex = 21;
            this.lblValorEsperanca.Text = "1,00";
            // 
            // lvEsperanca
            // 
            this.lvEsperanca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEsperanca.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPaga,
            this.chGanha,
            this.chLucro,
            this.chLucroP,
            this.chPLucro});
            this.lvEsperanca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEsperanca.ForeColor = System.Drawing.Color.OrangeRed;
            this.lvEsperanca.FullRowSelect = true;
            this.lvEsperanca.GridLines = true;
            this.lvEsperanca.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvEsperanca.HideSelection = false;
            this.lvEsperanca.Location = new System.Drawing.Point(3, 5);
            this.lvEsperanca.Name = "lvEsperanca";
            this.lvEsperanca.Size = new System.Drawing.Size(423, 110);
            this.lvEsperanca.TabIndex = 17;
            this.lvEsperanca.TileSize = new System.Drawing.Size(424, 132);
            this.lvEsperanca.UseCompatibleStateImageBehavior = false;
            this.lvEsperanca.View = System.Windows.Forms.View.Details;
            // 
            // chPaga
            // 
            this.chPaga.Text = "Paga";
            this.chPaga.Width = 67;
            // 
            // chGanha
            // 
            this.chGanha.Text = "Ganha";
            this.chGanha.Width = 71;
            // 
            // chLucro
            // 
            this.chLucro.Text = "Lucro";
            this.chLucro.Width = 70;
            // 
            // chLucroP
            // 
            this.chLucroP.DisplayIndex = 4;
            this.chLucroP.Text = "Lucro x P(Lucro)";
            this.chLucroP.Width = 135;
            // 
            // chPLucro
            // 
            this.chPLucro.DisplayIndex = 3;
            this.chPLucro.Text = "(P)Lucro";
            this.chPLucro.Width = 75;
            // 
            // btTelaDiagrama
            // 
            this.btTelaDiagrama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTelaDiagrama.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btTelaDiagrama.FlatAppearance.BorderSize = 2;
            this.btTelaDiagrama.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btTelaDiagrama.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btTelaDiagrama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTelaDiagrama.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTelaDiagrama.ForeColor = System.Drawing.Color.Orange;
            this.btTelaDiagrama.Location = new System.Drawing.Point(199, 153);
            this.btTelaDiagrama.Name = "btTelaDiagrama";
            this.btTelaDiagrama.Size = new System.Drawing.Size(213, 30);
            this.btTelaDiagrama.TabIndex = 22;
            this.btTelaDiagrama.Text = "Diagrama Em Árvoré/Tabela";
            this.btTelaDiagrama.UseVisualStyleBackColor = true;
            this.btTelaDiagrama.Click += new System.EventHandler(this.btTelaDiagrama_Click);
            // 
            // EsperancaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btTelaDiagrama);
            this.Controls.Add(this.lvEsperanca);
            this.Controls.Add(this.lblValorEsperanca);
            this.Controls.Add(this.lvTotal);
            this.Controls.Add(this.btnDiminuiBet);
            this.Controls.Add(this.btnAumentaBet);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EsperancaUC";
            this.Size = new System.Drawing.Size(431, 215);
            this.Load += new System.EventHandler(this.EsperancaUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDiminuiBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAumentaBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox btnDiminuiBet;
        public System.Windows.Forms.PictureBox btnAumentaBet;
        private System.Windows.Forms.ListView lvTotal;
        private System.Windows.Forms.ColumnHeader chTotal;
        private System.Windows.Forms.ColumnHeader chE;
        private System.Windows.Forms.ColumnHeader chLucroE;
        private System.Windows.Forms.Label lblValorEsperanca;
        private System.Windows.Forms.ListView lvEsperanca;
        private System.Windows.Forms.ColumnHeader chPaga;
        private System.Windows.Forms.ColumnHeader chGanha;
        private System.Windows.Forms.ColumnHeader chLucro;
        private System.Windows.Forms.ColumnHeader chLucroP;
        private System.Windows.Forms.Button btTelaDiagrama;
        private System.Windows.Forms.ColumnHeader chPLucro;
    }
}
