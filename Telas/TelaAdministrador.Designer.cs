
namespace Caça_frutas.Telas
{
    partial class TelaAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAdministrador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExpulsar = new System.Windows.Forms.PictureBox();
            this.btnDepositar = new System.Windows.Forms.PictureBox();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.listViewJogadores = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNivel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSaldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIdade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpulsar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDepositar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnDepositar);
            this.panel1.Controls.Add(this.btnExpulsar);
            this.panel1.Controls.Add(this.lblAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 325);
            this.panel1.TabIndex = 0;
            // 
            // btnExpulsar
            // 
            this.btnExpulsar.BackColor = System.Drawing.Color.Transparent;
            this.btnExpulsar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpulsar.Image = ((System.Drawing.Image)(resources.GetObject("btnExpulsar.Image")));
            this.btnExpulsar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExpulsar.Location = new System.Drawing.Point(401, 269);
            this.btnExpulsar.Name = "btnExpulsar";
            this.btnExpulsar.Size = new System.Drawing.Size(39, 29);
            this.btnExpulsar.TabIndex = 14;
            this.btnExpulsar.TabStop = false;
            this.btnExpulsar.Click += new System.EventHandler(this.btnExpulsar_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.Transparent;
            this.btnDepositar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepositar.Image = ((System.Drawing.Image)(resources.GetObject("btnDepositar.Image")));
            this.btnDepositar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDepositar.Location = new System.Drawing.Point(263, 268);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(39, 29);
            this.btnDepositar.TabIndex = 13;
            this.btnDepositar.TabStop = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // txtBonus
            // 
            this.txtBonus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.txtBonus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBonus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.txtBonus.Location = new System.Drawing.Point(156, 271);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(92, 20);
            this.txtBonus.TabIndex = 12;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(27)))));
            this.lblAdmin.Location = new System.Drawing.Point(226, 12);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(46, 21);
            this.lblAdmin.TabIndex = 11;
            this.lblAdmin.Text = "Adm";
            // 
            // listViewJogadores
            // 
            this.listViewJogadores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewJogadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chNivel,
            this.chSaldo,
            this.chIdade});
            this.listViewJogadores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewJogadores.ForeColor = System.Drawing.Color.OrangeRed;
            this.listViewJogadores.FullRowSelect = true;
            this.listViewJogadores.GridLines = true;
            this.listViewJogadores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewJogadores.HideSelection = false;
            this.listViewJogadores.Location = new System.Drawing.Point(43, 48);
            this.listViewJogadores.Name = "listViewJogadores";
            this.listViewJogadores.Size = new System.Drawing.Size(413, 190);
            this.listViewJogadores.TabIndex = 10;
            this.listViewJogadores.UseCompatibleStateImageBehavior = false;
            this.listViewJogadores.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Nome de Usuário";
            this.chName.Width = 150;
            // 
            // chNivel
            // 
            this.chNivel.Text = "Nivel";
            this.chNivel.Width = 100;
            // 
            // chSaldo
            // 
            this.chSaldo.DisplayIndex = 3;
            this.chSaldo.Text = "Saldo";
            this.chSaldo.Width = 100;
            // 
            // chIdade
            // 
            this.chIdade.DisplayIndex = 2;
            this.chIdade.Text = "Idade";
            // 
            // TelaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 325);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.listViewJogadores);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caça-Frutas  -- ADM";
            this.Load += new System.EventHandler(this.TelaAdministrador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpulsar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDepositar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnExpulsar;
        private System.Windows.Forms.PictureBox btnDepositar;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.ListView listViewJogadores;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chNivel;
        private System.Windows.Forms.ColumnHeader chSaldo;
        private System.Windows.Forms.ColumnHeader chIdade;
    }
}