namespace br.com.vinicius.projeto.analise.Forms
{
    partial class BoxForm
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
            this.lbBoxLoad = new System.Windows.Forms.ListBox();
            this.lbLoadAll = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSalvarCaixa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBoxLoad
            // 
            this.lbBoxLoad.FormattingEnabled = true;
            this.lbBoxLoad.Location = new System.Drawing.Point(12, 12);
            this.lbBoxLoad.Name = "lbBoxLoad";
            this.lbBoxLoad.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbBoxLoad.Size = new System.Drawing.Size(280, 381);
            this.lbBoxLoad.TabIndex = 0;
            // 
            // lbLoadAll
            // 
            this.lbLoadAll.FormattingEnabled = true;
            this.lbLoadAll.Location = new System.Drawing.Point(451, 12);
            this.lbLoadAll.Name = "lbLoadAll";
            this.lbLoadAll.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbLoadAll.Size = new System.Drawing.Size(280, 381);
            this.lbLoadAll.TabIndex = 1;
            this.lbLoadAll.SelectedIndexChanged += new System.EventHandler(this.lbLoadAll_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(298, 185);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(298, 214);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(147, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSalvarCaixa
            // 
            this.btnSalvarCaixa.Location = new System.Drawing.Point(298, 371);
            this.btnSalvarCaixa.Name = "btnSalvarCaixa";
            this.btnSalvarCaixa.Size = new System.Drawing.Size(145, 22);
            this.btnSalvarCaixa.TabIndex = 5;
            this.btnSalvarCaixa.Text = "Salvar";
            this.btnSalvarCaixa.UseVisualStyleBackColor = true;
            this.btnSalvarCaixa.Click += new System.EventHandler(this.btnSalvarCaixa_Click);
            // 
            // BoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 440);
            this.Controls.Add(this.btnSalvarCaixa);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbLoadAll);
            this.Controls.Add(this.lbBoxLoad);
            this.Name = "BoxForm";
            this.Text = "BoxForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBoxLoad;
        private System.Windows.Forms.ListBox lbLoadAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSalvarCaixa;
    }
}