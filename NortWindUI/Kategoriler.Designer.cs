namespace NortWindUI
{
    partial class Kategoriler
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
            this.dataGridViewKategoriler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategoriler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKategoriler
            // 
            this.dataGridViewKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKategoriler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewKategoriler.Location = new System.Drawing.Point(0, 222);
            this.dataGridViewKategoriler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewKategoriler.Name = "dataGridViewKategoriler";
            this.dataGridViewKategoriler.RowHeadersWidth = 51;
            this.dataGridViewKategoriler.RowTemplate.Height = 24;
            this.dataGridViewKategoriler.Size = new System.Drawing.Size(1000, 392);
            this.dataGridViewKategoriler.TabIndex = 0;
            // 
            // Kategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 614);
            this.Controls.Add(this.dataGridViewKategoriler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Kategoriler";
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.Kategoriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategoriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKategoriler;
    }
}