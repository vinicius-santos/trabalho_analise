namespace br.com.vinicius.projeto.analise.Forms
{
    partial class AnalysisForm
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lblSolicitante = new System.Windows.Forms.Label();
            this.cbSolicitante = new System.Windows.Forms.ComboBox();
            this.lblTipoAnalise = new System.Windows.Forms.Label();
            this.cbTipoAnalise = new System.Windows.Forms.ComboBox();
            this.lblQtdAmostra = new System.Windows.Forms.Label();
            this.cbQtdAmostra = new System.Windows.Forms.ComboBox();
            this.gpDadosCliente = new System.Windows.Forms.GroupBox();
            this.lblCidadeShow = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblMatriculaShow = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblTelefoneShow = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gpDadosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(30, 37);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(100, 37);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(279, 21);
            this.cbCliente.TabIndex = 1;
            this.cbCliente.DropDownClosed += new System.EventHandler(this.cbCliente_DropDownClosed);
            // 
            // lblSolicitante
            // 
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Location = new System.Drawing.Point(13, 76);
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.Size = new System.Drawing.Size(56, 13);
            this.lblSolicitante.TabIndex = 2;
            this.lblSolicitante.Text = "Solicitante";
            // 
            // cbSolicitante
            // 
            this.cbSolicitante.FormattingEnabled = true;
            this.cbSolicitante.Location = new System.Drawing.Point(100, 76);
            this.cbSolicitante.Name = "cbSolicitante";
            this.cbSolicitante.Size = new System.Drawing.Size(279, 21);
            this.cbSolicitante.TabIndex = 3;
            this.cbSolicitante.SelectedIndexChanged += new System.EventHandler(this.cbSolicitante_SelectedIndexChanged);
            // 
            // lblTipoAnalise
            // 
            this.lblTipoAnalise.AutoSize = true;
            this.lblTipoAnalise.Location = new System.Drawing.Point(5, 125);
            this.lblTipoAnalise.Name = "lblTipoAnalise";
            this.lblTipoAnalise.Size = new System.Drawing.Size(64, 13);
            this.lblTipoAnalise.TabIndex = 4;
            this.lblTipoAnalise.Text = "Tipo análise";
            // 
            // cbTipoAnalise
            // 
            this.cbTipoAnalise.FormattingEnabled = true;
            this.cbTipoAnalise.Location = new System.Drawing.Point(100, 122);
            this.cbTipoAnalise.Name = "cbTipoAnalise";
            this.cbTipoAnalise.Size = new System.Drawing.Size(220, 21);
            this.cbTipoAnalise.TabIndex = 5;
            // 
            // lblQtdAmostra
            // 
            this.lblQtdAmostra.AutoSize = true;
            this.lblQtdAmostra.Location = new System.Drawing.Point(5, 178);
            this.lblQtdAmostra.Name = "lblQtdAmostra";
            this.lblQtdAmostra.Size = new System.Drawing.Size(65, 13);
            this.lblQtdAmostra.TabIndex = 6;
            this.lblQtdAmostra.Text = "Qtd Amostra";
            // 
            // cbQtdAmostra
            // 
            this.cbQtdAmostra.FormattingEnabled = true;
            this.cbQtdAmostra.Location = new System.Drawing.Point(100, 178);
            this.cbQtdAmostra.Name = "cbQtdAmostra";
            this.cbQtdAmostra.Size = new System.Drawing.Size(95, 21);
            this.cbQtdAmostra.TabIndex = 7;
            this.cbQtdAmostra.DropDownClosed += new System.EventHandler(this.cbQtdAmostra_DropDownClosed);
            // 
            // gpDadosCliente
            // 
            this.gpDadosCliente.Controls.Add(this.lblCidadeShow);
            this.gpDadosCliente.Controls.Add(this.lblCidade);
            this.gpDadosCliente.Controls.Add(this.lblMatriculaShow);
            this.gpDadosCliente.Controls.Add(this.lblMatricula);
            this.gpDadosCliente.Controls.Add(this.lblTelefoneShow);
            this.gpDadosCliente.Controls.Add(this.lblTelefone);
            this.gpDadosCliente.Location = new System.Drawing.Point(385, 12);
            this.gpDadosCliente.Name = "gpDadosCliente";
            this.gpDadosCliente.Size = new System.Drawing.Size(350, 131);
            this.gpDadosCliente.TabIndex = 8;
            this.gpDadosCliente.TabStop = false;
            this.gpDadosCliente.Text = "Dados cliente";
            // 
            // lblCidadeShow
            // 
            this.lblCidadeShow.AutoSize = true;
            this.lblCidadeShow.Location = new System.Drawing.Point(61, 72);
            this.lblCidadeShow.Name = "lblCidadeShow";
            this.lblCidadeShow.Size = new System.Drawing.Size(0, 13);
            this.lblCidadeShow.TabIndex = 5;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(6, 72);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 4;
            this.lblCidade.Text = "Cidade";
            // 
            // lblMatriculaShow
            // 
            this.lblMatriculaShow.AutoSize = true;
            this.lblMatriculaShow.Location = new System.Drawing.Point(61, 49);
            this.lblMatriculaShow.Name = "lblMatriculaShow";
            this.lblMatriculaShow.Size = new System.Drawing.Size(0, 13);
            this.lblMatriculaShow.TabIndex = 3;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(6, 49);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(52, 13);
            this.lblMatricula.TabIndex = 2;
            this.lblMatricula.Text = "Matrícula";
            // 
            // lblTelefoneShow
            // 
            this.lblTelefoneShow.AutoSize = true;
            this.lblTelefoneShow.Location = new System.Drawing.Point(61, 25);
            this.lblTelefoneShow.Name = "lblTelefoneShow";
            this.lblTelefoneShow.Size = new System.Drawing.Size(0, 13);
            this.lblTelefoneShow.TabIndex = 1;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(6, 25);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(39, 13);
            this.lblTelefone.TabIndex = 0;
            this.lblTelefone.Text = "Celular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 216);
            this.dataGridView1.TabIndex = 9;
            // 
            // AnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 454);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gpDadosCliente);
            this.Controls.Add(this.cbQtdAmostra);
            this.Controls.Add(this.lblQtdAmostra);
            this.Controls.Add(this.cbTipoAnalise);
            this.Controls.Add(this.lblTipoAnalise);
            this.Controls.Add(this.cbSolicitante);
            this.Controls.Add(this.lblSolicitante);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.lblCliente);
            this.Name = "AnalysisForm";
            this.Text = "AnalysisForm";
            this.Load += new System.EventHandler(this.AnalysisForm_Load);
            this.gpDadosCliente.ResumeLayout(false);
            this.gpDadosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lblSolicitante;
        private System.Windows.Forms.ComboBox cbSolicitante;
        private System.Windows.Forms.Label lblTipoAnalise;
        private System.Windows.Forms.ComboBox cbTipoAnalise;
        private System.Windows.Forms.Label lblQtdAmostra;
        private System.Windows.Forms.ComboBox cbQtdAmostra;
        private System.Windows.Forms.GroupBox gpDadosCliente;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblTelefoneShow;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblMatriculaShow;
        private System.Windows.Forms.Label lblCidadeShow;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}