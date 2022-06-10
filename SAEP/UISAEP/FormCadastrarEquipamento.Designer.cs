namespace UISAEP
{
    partial class FormCadastrarEquipamento
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
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.descricaoDetalhadaTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.pictureBoxEquipamento = new System.Windows.Forms.PictureBox();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.buttonCarregarImagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquipamento)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(12, 296);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(101, 23);
            this.buttonCadastrar.TabIndex = 12;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // descricaoDetalhadaTextBox
            // 
            this.descricaoDetalhadaTextBox.Location = new System.Drawing.Point(372, 40);
            this.descricaoDetalhadaTextBox.Multiline = true;
            this.descricaoDetalhadaTextBox.Name = "descricaoDetalhadaTextBox";
            this.descricaoDetalhadaTextBox.Size = new System.Drawing.Size(712, 207);
            this.descricaoDetalhadaTextBox.TabIndex = 11;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(372, 12);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(712, 22);
            this.descricaoTextBox.TabIndex = 10;
            // 
            // pictureBoxEquipamento
            // 
            this.pictureBoxEquipamento.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxEquipamento.Name = "pictureBoxEquipamento";
            this.pictureBoxEquipamento.Size = new System.Drawing.Size(354, 235);
            this.pictureBoxEquipamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEquipamento.TabIndex = 9;
            this.pictureBoxEquipamento.TabStop = false;
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.Location = new System.Drawing.Point(372, 253);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(61, 21);
            this.checkBoxAtivo.TabIndex = 13;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // buttonCarregarImagem
            // 
            this.buttonCarregarImagem.Location = new System.Drawing.Point(12, 251);
            this.buttonCarregarImagem.Name = "buttonCarregarImagem";
            this.buttonCarregarImagem.Size = new System.Drawing.Size(354, 23);
            this.buttonCarregarImagem.TabIndex = 14;
            this.buttonCarregarImagem.Text = "Carregar imagem";
            this.buttonCarregarImagem.UseVisualStyleBackColor = true;
            this.buttonCarregarImagem.Click += new System.EventHandler(this.buttonCarregarImagem_Click);
            // 
            // FormCadastrarEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 337);
            this.Controls.Add(this.buttonCarregarImagem);
            this.Controls.Add(this.checkBoxAtivo);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.descricaoDetalhadaTextBox);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.pictureBoxEquipamento);
            this.Name = "FormCadastrarEquipamento";
            this.Text = "FormCadastrarEquipamento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquipamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.TextBox descricaoDetalhadaTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.PictureBox pictureBoxEquipamento;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.Button buttonCarregarImagem;
    }
}