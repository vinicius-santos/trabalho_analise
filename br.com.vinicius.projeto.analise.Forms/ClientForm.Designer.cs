﻿namespace br.com.vinicius.projeto.analise.Forms
{
    partial class ClientForm
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTxtCel = new System.Windows.Forms.MaskedTextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.dtvClient = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome *";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(60, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(259, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(388, 35);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(175, 20);
            this.txtMatricula.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cel";
            // 
            // mskTxtCel
            // 
            this.mskTxtCel.Location = new System.Drawing.Point(215, 58);
            this.mskTxtCel.Mask = "(99) 00000-0000";
            this.mskTxtCel.Name = "mskTxtCel";
            this.mskTxtCel.Size = new System.Drawing.Size(106, 20);
            this.mskTxtCel.TabIndex = 4;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(325, 35);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(57, 13);
            this.lblMatricula.TabIndex = 5;
            this.lblMatricula.Text = "Matricula *";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(327, 58);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(47, 13);
            this.lblCidade.TabIndex = 6;
            this.lblCidade.Text = "Cidade *";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(388, 61);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(175, 20);
            this.txtCidade.TabIndex = 7;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(7, 58);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(47, 13);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado *";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(60, 58);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(449, 391);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(121, 23);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(28, 410);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 11;
            // 
            // dtvClient
            // 
            this.dtvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvClient.Location = new System.Drawing.Point(10, 84);
            this.dtvClient.Name = "dtvClient";
            this.dtvClient.Size = new System.Drawing.Size(884, 301);
            this.dtvClient.TabIndex = 12;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(576, 391);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 23);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(703, 391);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(121, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 491);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dtvClient);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.mskTxtCel);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNome);
            this.KeyPreview = true;
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dtvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTxtCel;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DataGridView dtvClient;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
    }
}