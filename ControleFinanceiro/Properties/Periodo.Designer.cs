namespace ControleFinanceiro.Properties
{
    partial class Periodo
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
            this.tblPeriodo = new System.Windows.Forms.DataGridView();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.Inicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltroDivida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkDiv = new System.Windows.Forms.CheckBox();
            this.checkEntrada = new System.Windows.Forms.CheckBox();
            this.lblvalor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblPeriodo)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPeriodo
            // 
            this.tblPeriodo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblPeriodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPeriodo.Location = new System.Drawing.Point(257, 18);
            this.tblPeriodo.Name = "tblPeriodo";
            this.tblPeriodo.RowTemplate.Height = 25;
            this.tblPeriodo.Size = new System.Drawing.Size(567, 420);
            this.tblPeriodo.TabIndex = 0;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(12, 36);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(82, 23);
            this.dtInicio.TabIndex = 1;
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(12, 95);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(82, 23);
            this.dtFinal.TabIndex = 2;
            // 
            // Inicio
            // 
            this.Inicio.AutoSize = true;
            this.Inicio.Location = new System.Drawing.Point(12, 18);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(82, 15);
            this.Inicio.TabIndex = 3;
            this.Inicio.Text = "Periodo Inicial";
            this.Inicio.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Periodo Final";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(12, 153);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(100, 23);
            this.BtnFiltrar.TabIndex = 5;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(137, 153);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(103, 23);
            this.BtnLimpar.TabIndex = 6;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(12, 192);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 23);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(137, 192);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(103, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descrição";
            // 
            // txtFiltroDivida
            // 
            this.txtFiltroDivida.Location = new System.Drawing.Point(112, 36);
            this.txtFiltroDivida.Name = "txtFiltroDivida";
            this.txtFiltroDivida.Size = new System.Drawing.Size(128, 23);
            this.txtFiltroDivida.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Valor Total:";
            // 
            // checkDiv
            // 
            this.checkDiv.AutoSize = true;
            this.checkDiv.Location = new System.Drawing.Point(115, 72);
            this.checkDiv.Name = "checkDiv";
            this.checkDiv.Size = new System.Drawing.Size(59, 19);
            this.checkDiv.TabIndex = 14;
            this.checkDiv.Text = "Divida";
            this.checkDiv.UseVisualStyleBackColor = true;
            // 
            // checkEntrada
            // 
            this.checkEntrada.AutoSize = true;
            this.checkEntrada.Location = new System.Drawing.Point(115, 100);
            this.checkEntrada.Name = "checkEntrada";
            this.checkEntrada.Size = new System.Drawing.Size(66, 19);
            this.checkEntrada.TabIndex = 15;
            this.checkEntrada.Text = "Entrada";
            this.checkEntrada.UseVisualStyleBackColor = true;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(87, 358);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(0, 15);
            this.lblvalor.TabIndex = 18;
            // 
            // Periodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 496);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.checkEntrada);
            this.Controls.Add(this.checkDiv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFiltroDivida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inicio);
            this.Controls.Add(this.dtFinal);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.tblPeriodo);
            this.Name = "Periodo";
            this.Text = "Periodo";
            ((System.ComponentModel.ISupportInitialize)(this.tblPeriodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView tblPeriodo;
        private DateTimePicker dtInicio;
        private DateTimePicker dtFinal;
        private Label Inicio;
        private Label label1;
        private Button BtnFiltrar;
        private Button BtnLimpar;
        private Button btnAtualizar;
        private Button btnSair;
        private Label label2;
        private TextBox txtFiltroDivida;
        private Label label3;
        private CheckBox checkDiv;
        private CheckBox checkEntrada;
        private Label lblvalor;
    }
}