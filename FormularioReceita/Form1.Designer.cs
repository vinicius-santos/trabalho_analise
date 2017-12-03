namespace FormularioReceita
{
    partial class Form1
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
            this.btnCadastroReceita = new System.Windows.Forms.Button();
            this.btnCadastrarIngrediente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroReceita
            // 
            this.btnCadastroReceita.Location = new System.Drawing.Point(233, 146);
            this.btnCadastroReceita.Name = "btnCadastroReceita";
            this.btnCadastroReceita.Size = new System.Drawing.Size(263, 23);
            this.btnCadastroReceita.TabIndex = 3;
            this.btnCadastroReceita.Text = "Cadastro Receita";
            this.btnCadastroReceita.UseVisualStyleBackColor = true;
            this.btnCadastroReceita.Click += new System.EventHandler(this.btnCadastroReceita_Click);
            // 
            // btnCadastrarIngrediente
            // 
            this.btnCadastrarIngrediente.Location = new System.Drawing.Point(233, 84);
            this.btnCadastrarIngrediente.Name = "btnCadastrarIngrediente";
            this.btnCadastrarIngrediente.Size = new System.Drawing.Size(263, 23);
            this.btnCadastrarIngrediente.TabIndex = 2;
            this.btnCadastrarIngrediente.Text = "Cadastro Ingrediente";
            this.btnCadastrarIngrediente.UseVisualStyleBackColor = true;
            this.btnCadastrarIngrediente.Click += new System.EventHandler(this.btnCadastrarIngrediente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 319);
            this.Controls.Add(this.btnCadastroReceita);
            this.Controls.Add(this.btnCadastrarIngrediente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroReceita;
        private System.Windows.Forms.Button btnCadastrarIngrediente;
    }
}

