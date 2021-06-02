
namespace Caça_frutas.Telas
{
    partial class TelaDiagrama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDiagrama));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbDiagrama = new System.Windows.Forms.TabPage();
            this.tbTabela = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tbDiagrama.SuspendLayout();
            this.tbTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbDiagrama);
            this.tabControl1.Controls.Add(this.tbTabela);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(542, 565);
            this.tabControl1.TabIndex = 0;
            // 
            // tbDiagrama
            // 
            this.tbDiagrama.AutoScroll = true;
            this.tbDiagrama.Controls.Add(this.pictureBox1);
            this.tbDiagrama.Location = new System.Drawing.Point(4, 22);
            this.tbDiagrama.Name = "tbDiagrama";
            this.tbDiagrama.Padding = new System.Windows.Forms.Padding(3);
            this.tbDiagrama.Size = new System.Drawing.Size(534, 539);
            this.tbDiagrama.TabIndex = 0;
            this.tbDiagrama.Text = "Diagrama em Árvore";
            this.tbDiagrama.UseVisualStyleBackColor = true;
            // 
            // tbTabela
            // 
            this.tbTabela.Controls.Add(this.pictureBox2);
            this.tbTabela.Location = new System.Drawing.Point(4, 22);
            this.tbTabela.Name = "tbTabela";
            this.tbTabela.Padding = new System.Windows.Forms.Padding(3);
            this.tbTabela.Size = new System.Drawing.Size(534, 539);
            this.tbTabela.TabIndex = 1;
            this.tbTabela.Text = "Tabela de Probabilidades";
            this.tbTabela.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 896);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(528, 533);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // TelaDiagrama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 565);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaDiagrama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagrama\\Probabilides";
            this.tabControl1.ResumeLayout(false);
            this.tbDiagrama.ResumeLayout(false);
            this.tbDiagrama.PerformLayout();
            this.tbTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbDiagrama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tbTabela;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}