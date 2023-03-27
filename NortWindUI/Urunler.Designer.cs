namespace NortWindUI
{
    partial class Urunler
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
            this.dataGridViewUrunler = new System.Windows.Forms.DataGridView();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.comboBoxtedarikciler = new System.Windows.Forms.ComboBox();
            this.comboBoxKatad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxurunadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericFiyat = new System.Windows.Forms.NumericUpDown();
            this.numericMiktar = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMiktar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUrunler
            // 
            this.dataGridViewUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrunler.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewUrunler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewUrunler.Location = new System.Drawing.Point(0, 172);
            this.dataGridViewUrunler.Name = "dataGridViewUrunler";
            this.dataGridViewUrunler.RowHeadersWidth = 51;
            this.dataGridViewUrunler.RowTemplate.Height = 24;
            this.dataGridViewUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUrunler.Size = new System.Drawing.Size(800, 278);
            this.dataGridViewUrunler.TabIndex = 0;
            this.dataGridViewUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUrunler_CellClick);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(600, 12);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(99, 35);
            this.buttonGuncelle.TabIndex = 20;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // comboBoxtedarikciler
            // 
            this.comboBoxtedarikciler.FormattingEnabled = true;
            this.comboBoxtedarikciler.Location = new System.Drawing.Point(254, 42);
            this.comboBoxtedarikciler.Name = "comboBoxtedarikciler";
            this.comboBoxtedarikciler.Size = new System.Drawing.Size(226, 24);
            this.comboBoxtedarikciler.TabIndex = 18;
            // 
            // comboBoxKatad
            // 
            this.comboBoxKatad.FormattingEnabled = true;
            this.comboBoxKatad.Location = new System.Drawing.Point(254, 12);
            this.comboBoxKatad.Name = "comboBoxKatad";
            this.comboBoxKatad.Size = new System.Drawing.Size(226, 24);
            this.comboBoxKatad.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tedarikçi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kategori Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Miktarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fiyatı";
            // 
            // textBoxurunadi
            // 
            this.textBoxurunadi.Location = new System.Drawing.Point(62, 12);
            this.textBoxurunadi.Name = "textBoxurunadi";
            this.textBoxurunadi.Size = new System.Drawing.Size(100, 22);
            this.textBoxurunadi.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Adı";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Kategori Ekle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Urun Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericFiyat
            // 
            this.numericFiyat.Location = new System.Drawing.Point(62, 41);
            this.numericFiyat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericFiyat.Name = "numericFiyat";
            this.numericFiyat.Size = new System.Drawing.Size(100, 22);
            this.numericFiyat.TabIndex = 21;
            // 
            // numericMiktar
            // 
            this.numericMiktar.Location = new System.Drawing.Point(62, 69);
            this.numericMiktar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericMiktar.Name = "numericMiktar";
            this.numericMiktar.Size = new System.Drawing.Size(100, 22);
            this.numericMiktar.TabIndex = 22;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(98, 28);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.silToolStripMenuItem.Text = "SİL";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericMiktar);
            this.Controls.Add(this.numericFiyat);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.comboBoxtedarikciler);
            this.Controls.Add(this.comboBoxKatad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxurunadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewUrunler);
            this.Name = "Urunler";
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMiktar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUrunler;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.ComboBox comboBoxtedarikciler;
        private System.Windows.Forms.ComboBox comboBoxKatad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxurunadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericFiyat;
        private System.Windows.Forms.NumericUpDown numericMiktar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}