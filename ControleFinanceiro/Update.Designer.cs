namespace ControleFinanceiro
{
    partial class Update
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
            this.CBOXCategoriaUpdate = new System.Windows.Forms.ComboBox();
            this.Categoria = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtUpdate = new System.Windows.Forms.DateTimePicker();
            this.btnLimparUpdate = new System.Windows.Forms.Button();
            this.btnCancelarUpdate = new System.Windows.Forms.Button();
            this.btnSalvarUpdate = new System.Windows.Forms.Button();
            this.txtValorUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricaoUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atualizar";
            // 
            // CBOXCategoriaUpdate
            // 
            this.CBOXCategoriaUpdate.FormattingEnabled = true;
            this.CBOXCategoriaUpdate.Items.AddRange(new object[] {
            "Adiantamento",
            "Pagamento",
            "Prestação de Serviço",
            "Renda",
            "13º",
            "Retorno de Investimento",
            "Outros"});
            this.CBOXCategoriaUpdate.Location = new System.Drawing.Point(300, 141);
            this.CBOXCategoriaUpdate.Name = "CBOXCategoriaUpdate";
            this.CBOXCategoriaUpdate.Size = new System.Drawing.Size(121, 23);
            this.CBOXCategoriaUpdate.TabIndex = 28;
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Location = new System.Drawing.Point(236, 144);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(58, 15);
            this.Categoria.TabIndex = 27;
            this.Categoria.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Data";
            // 
            // dtUpdate
            // 
            this.dtUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtUpdate.Location = new System.Drawing.Point(300, 247);
            this.dtUpdate.Name = "dtUpdate";
            this.dtUpdate.Size = new System.Drawing.Size(83, 23);
            this.dtUpdate.TabIndex = 25;
            // 
            // btnLimparUpdate
            // 
            this.btnLimparUpdate.Location = new System.Drawing.Point(408, 286);
            this.btnLimparUpdate.Name = "btnLimparUpdate";
            this.btnLimparUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnLimparUpdate.TabIndex = 24;
            this.btnLimparUpdate.Text = "Limpar";
            this.btnLimparUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCancelarUpdate
            // 
            this.btnCancelarUpdate.Location = new System.Drawing.Point(322, 286);
            this.btnCancelarUpdate.Name = "btnCancelarUpdate";
            this.btnCancelarUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarUpdate.TabIndex = 23;
            this.btnCancelarUpdate.Text = "Cancelar";
            this.btnCancelarUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSalvarUpdate
            // 
            this.btnSalvarUpdate.Location = new System.Drawing.Point(236, 286);
            this.btnSalvarUpdate.Name = "btnSalvarUpdate";
            this.btnSalvarUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarUpdate.TabIndex = 22;
            this.btnSalvarUpdate.Text = "Salvar";
            this.btnSalvarUpdate.UseVisualStyleBackColor = true;
            // 
            // txtValorUpdate
            // 
            this.txtValorUpdate.Location = new System.Drawing.Point(300, 214);
            this.txtValorUpdate.Name = "txtValorUpdate";
            this.txtValorUpdate.Size = new System.Drawing.Size(76, 23);
            this.txtValorUpdate.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Valor";
            // 
            // txtDescricaoUpdate
            // 
            this.txtDescricaoUpdate.Location = new System.Drawing.Point(300, 178);
            this.txtDescricaoUpdate.Name = "txtDescricaoUpdate";
            this.txtDescricaoUpdate.Size = new System.Drawing.Size(264, 23);
            this.txtDescricaoUpdate.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Descrição";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(300, 101);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(76, 23);
            this.txtID.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "ID";
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(382, 100);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(70, 23);
            this.btnBusca.TabIndex = 31;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(494, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 23);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBOXCategoriaUpdate);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtUpdate);
            this.Controls.Add(this.btnLimparUpdate);
            this.Controls.Add(this.btnCancelarUpdate);
            this.Controls.Add(this.btnSalvarUpdate);
            this.Controls.Add(this.txtValorUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricaoUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Update";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox CBOXCategoriaUpdate;
        private Label Categoria;
        private Label label3;
        private DateTimePicker dtUpdate;
        private Button btnLimparUpdate;
        private Button btnCancelarUpdate;
        private Button btnSalvarUpdate;
        private TextBox txtValorUpdate;
        private Label label2;
        private TextBox txtDescricaoUpdate;
        private Label label4;
        private TextBox txtID;
        private Label label5;
        private Button btnBusca;
        private Button btnDelete;
    }
}