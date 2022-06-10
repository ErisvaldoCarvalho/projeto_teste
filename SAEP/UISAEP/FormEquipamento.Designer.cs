
namespace UISAEP
{
    partial class FormEquipamento
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
            this.equipamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoDetalhadaTextBox = new System.Windows.Forms.TextBox();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonComentarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.equipamentoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // equipamentoDataGridView
            // 
            this.equipamentoDataGridView.AllowUserToAddRows = false;
            this.equipamentoDataGridView.AllowUserToDeleteRows = false;
            this.equipamentoDataGridView.AllowUserToOrderColumns = true;
            this.equipamentoDataGridView.AutoGenerateColumns = false;
            this.equipamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.equipamentoDataGridView.DataSource = this.equipamentoBindingSource;
            this.equipamentoDataGridView.Location = new System.Drawing.Point(12, 301);
            this.equipamentoDataGridView.Name = "equipamentoDataGridView";
            this.equipamentoDataGridView.ReadOnly = true;
            this.equipamentoDataGridView.RowHeadersWidth = 51;
            this.equipamentoDataGridView.RowTemplate.Height = 24;
            this.equipamentoDataGridView.Size = new System.Drawing.Size(1072, 350);
            this.equipamentoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DescricaoDetalhada";
            this.dataGridViewTextBoxColumn4.HeaderText = "DescricaoDetalhada";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // equipamentoBindingSource
            // 
            this.equipamentoBindingSource.DataSource = typeof(Model.Equipamento);
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.equipamentoBindingSource, "Imagem", true));
            this.pictureBox1.Location = new System.Drawing.Point(12, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipamentoBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(372, 60);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.ReadOnly = true;
            this.descricaoTextBox.Size = new System.Drawing.Size(712, 22);
            this.descricaoTextBox.TabIndex = 3;
            this.descricaoTextBox.TextChanged += new System.EventHandler(this.descricaoTextBox_TextChanged);
            // 
            // descricaoDetalhadaTextBox
            // 
            this.descricaoDetalhadaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipamentoBindingSource, "DescricaoDetalhada", true));
            this.descricaoDetalhadaTextBox.Location = new System.Drawing.Point(372, 88);
            this.descricaoDetalhadaTextBox.Multiline = true;
            this.descricaoDetalhadaTextBox.Name = "descricaoDetalhadaTextBox";
            this.descricaoDetalhadaTextBox.ReadOnly = true;
            this.descricaoDetalhadaTextBox.Size = new System.Drawing.Size(712, 176);
            this.descricaoDetalhadaTextBox.TabIndex = 5;
            this.descricaoDetalhadaTextBox.TextChanged += new System.EventHandler(this.descricaoDetalhadaTextBox_TextChanged);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(928, 12);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 23);
            this.buttonInserir.TabIndex = 6;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(1009, 12);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 7;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(479, 270);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 9;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonComentarios
            // 
            this.buttonComentarios.Location = new System.Drawing.Point(372, 270);
            this.buttonComentarios.Name = "buttonComentarios";
            this.buttonComentarios.Size = new System.Drawing.Size(101, 23);
            this.buttonComentarios.TabIndex = 8;
            this.buttonComentarios.Text = "Comentários";
            this.buttonComentarios.UseVisualStyleBackColor = true;
            this.buttonComentarios.Click += new System.EventHandler(this.buttonComentarios_Click);
            // 
            // FormEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 663);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonComentarios);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.descricaoDetalhadaTextBox);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.equipamentoDataGridView);
            this.Name = "FormEquipamento";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormEquipamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipamentoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource equipamentoBindingSource;
        private System.Windows.Forms.DataGridView equipamentoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox descricaoDetalhadaTextBox;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonComentarios;
    }
}

