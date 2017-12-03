namespace br.com.vinicius.projeto.analise.Forms
{
    partial class CadastroReceitaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeReceita = new System.Windows.Forms.Label();
            this.txtNomeReceita = new System.Windows.Forms.TextBox();
            this.txtComoFazer = new System.Windows.Forms.TextBox();
            this.lblComoFazer = new System.Windows.Forms.Label();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.cbIngredientes = new System.Windows.Forms.ComboBox();
            this.Salvar = new System.Windows.Forms.Button();
            this.txtMostraIngredientes = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cadastro de Receitas";
            // 
            // lblNomeReceita
            // 
            this.lblNomeReceita.AutoSize = true;
            this.lblNomeReceita.Location = new System.Drawing.Point(34, 55);
            this.lblNomeReceita.Name = "lblNomeReceita";
            this.lblNomeReceita.Size = new System.Drawing.Size(75, 13);
            this.lblNomeReceita.TabIndex = 7;
            this.lblNomeReceita.Text = "Nome Receita";
            // 
            // txtNomeReceita
            // 
            this.txtNomeReceita.Location = new System.Drawing.Point(116, 55);
            this.txtNomeReceita.Name = "txtNomeReceita";
            this.txtNomeReceita.Size = new System.Drawing.Size(228, 20);
            this.txtNomeReceita.TabIndex = 8;
            // 
            // txtComoFazer
            // 
            this.txtComoFazer.Location = new System.Drawing.Point(116, 81);
            this.txtComoFazer.Multiline = true;
            this.txtComoFazer.Name = "txtComoFazer";
            this.txtComoFazer.Size = new System.Drawing.Size(440, 89);
            this.txtComoFazer.TabIndex = 9;
            // 
            // lblComoFazer
            // 
            this.lblComoFazer.AutoSize = true;
            this.lblComoFazer.Location = new System.Drawing.Point(35, 84);
            this.lblComoFazer.Name = "lblComoFazer";
            this.lblComoFazer.Size = new System.Drawing.Size(60, 13);
            this.lblComoFazer.TabIndex = 10;
            this.lblComoFazer.Text = "Como fazer";
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Location = new System.Drawing.Point(34, 199);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(65, 13);
            this.lblIngredientes.TabIndex = 11;
            this.lblIngredientes.Text = "Ingredientes";
            // 
            // cbIngredientes
            // 
            this.cbIngredientes.FormattingEnabled = true;
            this.cbIngredientes.Location = new System.Drawing.Point(116, 199);
            this.cbIngredientes.Name = "cbIngredientes";
            this.cbIngredientes.Size = new System.Drawing.Size(266, 21);
            this.cbIngredientes.TabIndex = 12;
            this.cbIngredientes.SelectedIndexChanged += new System.EventHandler(this.cbIngredientes_SelectedIndexChanged);
            this.cbIngredientes.DropDownClosed += new System.EventHandler(this.cbIngredientes_DropDownClosed);
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(37, 357);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(528, 23);
            this.Salvar.TabIndex = 13;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // txtMostraIngredientes
            // 
            this.txtMostraIngredientes.Location = new System.Drawing.Point(116, 226);
            this.txtMostraIngredientes.Multiline = true;
            this.txtMostraIngredientes.Name = "txtMostraIngredientes";
            this.txtMostraIngredientes.Size = new System.Drawing.Size(440, 89);
            this.txtMostraIngredientes.TabIndex = 14;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(59, 338);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 15;
            // 
            // CadastroReceitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 398);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtMostraIngredientes);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.cbIngredientes);
            this.Controls.Add(this.lblIngredientes);
            this.Controls.Add(this.lblComoFazer);
            this.Controls.Add(this.txtComoFazer);
            this.Controls.Add(this.txtNomeReceita);
            this.Controls.Add(this.lblNomeReceita);
            this.Controls.Add(this.label1);
            this.Name = "CadastroReceitaForm";
            this.Text = "CadastroReceita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeReceita;
        private System.Windows.Forms.TextBox txtNomeReceita;
        private System.Windows.Forms.TextBox txtComoFazer;
        private System.Windows.Forms.Label lblComoFazer;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.ComboBox cbIngredientes;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.TextBox txtMostraIngredientes;
        private System.Windows.Forms.Label lblMessage;
    }
}