namespace br.com.vinicius.projeto.analise.Forms
{
    partial class FolhaForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnSalvarLaudo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(838, 364);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(720, 382);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(130, 23);
            this.btnPDF.TabIndex = 1;
            this.btnPDF.Text = "Gerar PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnSalvarLaudo
            // 
            this.btnSalvarLaudo.Location = new System.Drawing.Point(584, 381);
            this.btnSalvarLaudo.Name = "btnSalvarLaudo";
            this.btnSalvarLaudo.Size = new System.Drawing.Size(119, 23);
            this.btnSalvarLaudo.TabIndex = 2;
            this.btnSalvarLaudo.Text = "Salvar Laudo";
            this.btnSalvarLaudo.UseVisualStyleBackColor = true;
            this.btnSalvarLaudo.Click += new System.EventHandler(this.btnSalvarLaudo_Click);
            // 
            // FolhaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 445);
            this.Controls.Add(this.btnSalvarLaudo);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FolhaForm";
            this.Text = "FolhaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnSalvarLaudo;
    }
}