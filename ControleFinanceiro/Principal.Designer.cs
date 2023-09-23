namespace ControleFinanceiro
{
    partial class PGMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadDiv = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadDiv
            // 
            this.btnCadDiv.Location = new System.Drawing.Point(43, 32);
            this.btnCadDiv.Name = "btnCadDiv";
            this.btnCadDiv.Size = new System.Drawing.Size(278, 24);
            this.btnCadDiv.TabIndex = 0;
            this.btnCadDiv.Text = "Divida\r\n";
            this.btnCadDiv.UseVisualStyleBackColor = true;
            this.btnCadDiv.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.Location = new System.Drawing.Point(43, 62);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(278, 24);
            this.btnEntrada.TabIndex = 1;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(43, 92);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(278, 24);
            this.btnFiltro.TabIndex = 2;
            this.btnFiltro.Text = "Periodos";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(43, 122);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(278, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // PGMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(363, 194);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.btnCadDiv);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "PGMain";
            this.Text = "CONTROLE FINANCEIRO";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCadDiv;
        private Button btnEntrada;
        private Button btnFiltro;
        private Button btnSair;
    }
}