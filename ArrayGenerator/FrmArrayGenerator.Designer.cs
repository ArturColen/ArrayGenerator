namespace ArrayGenerator
{
    partial class FrmArrayGenerator
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArrayGenerator));
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lstElements = new System.Windows.Forms.ListBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnQtZeros = new System.Windows.Forms.Button();
            this.btnLowest = new System.Windows.Forms.Button();
            this.btnBiggest = new System.Windows.Forms.Button();
            this.btnFillIn = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 37);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(308, 24);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantidade de elementos do vetor:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(12, 64);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(557, 109);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.Text = "0";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstElements
            // 
            this.lstElements.FormattingEnabled = true;
            this.lstElements.ItemHeight = 24;
            this.lstElements.Location = new System.Drawing.Point(589, 64);
            this.lstElements.Name = "lstElements";
            this.lstElements.Size = new System.Drawing.Size(399, 508);
            this.lstElements.TabIndex = 4;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Khaki;
            this.pnlButtons.Controls.Add(this.btnAverage);
            this.pnlButtons.Controls.Add(this.btnQtZeros);
            this.pnlButtons.Controls.Add(this.btnLowest);
            this.pnlButtons.Controls.Add(this.btnBiggest);
            this.pnlButtons.Controls.Add(this.btnFillIn);
            this.pnlButtons.Controls.Add(this.btnCreate);
            this.pnlButtons.Location = new System.Drawing.Point(12, 191);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(557, 381);
            this.pnlButtons.TabIndex = 5;
            // 
            // btnAverage
            // 
            this.btnAverage.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAverage.Enabled = false;
            this.btnAverage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAverage.ForeColor = System.Drawing.Color.White;
            this.btnAverage.Location = new System.Drawing.Point(3, 311);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(551, 53);
            this.btnAverage.TabIndex = 5;
            this.btnAverage.Text = "Média";
            this.btnAverage.UseVisualStyleBackColor = false;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnQtZeros
            // 
            this.btnQtZeros.BackColor = System.Drawing.Color.DarkGreen;
            this.btnQtZeros.Enabled = false;
            this.btnQtZeros.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQtZeros.ForeColor = System.Drawing.Color.White;
            this.btnQtZeros.Location = new System.Drawing.Point(3, 252);
            this.btnQtZeros.Name = "btnQtZeros";
            this.btnQtZeros.Size = new System.Drawing.Size(551, 53);
            this.btnQtZeros.TabIndex = 4;
            this.btnQtZeros.Text = "Quantidade de zeros";
            this.btnQtZeros.UseVisualStyleBackColor = false;
            this.btnQtZeros.Click += new System.EventHandler(this.btnQtZeros_Click);
            // 
            // btnLowest
            // 
            this.btnLowest.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLowest.Enabled = false;
            this.btnLowest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowest.ForeColor = System.Drawing.Color.White;
            this.btnLowest.Location = new System.Drawing.Point(3, 193);
            this.btnLowest.Name = "btnLowest";
            this.btnLowest.Size = new System.Drawing.Size(551, 53);
            this.btnLowest.TabIndex = 3;
            this.btnLowest.Text = "Menor valor";
            this.btnLowest.UseVisualStyleBackColor = false;
            this.btnLowest.Click += new System.EventHandler(this.btnLowest_Click);
            // 
            // btnBiggest
            // 
            this.btnBiggest.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBiggest.Enabled = false;
            this.btnBiggest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiggest.ForeColor = System.Drawing.Color.White;
            this.btnBiggest.Location = new System.Drawing.Point(3, 134);
            this.btnBiggest.Name = "btnBiggest";
            this.btnBiggest.Size = new System.Drawing.Size(551, 53);
            this.btnBiggest.TabIndex = 2;
            this.btnBiggest.Text = "Maior valor";
            this.btnBiggest.UseVisualStyleBackColor = false;
            this.btnBiggest.Click += new System.EventHandler(this.btnBiggest_Click);
            // 
            // btnFillIn
            // 
            this.btnFillIn.BackColor = System.Drawing.Color.DarkGreen;
            this.btnFillIn.Enabled = false;
            this.btnFillIn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFillIn.ForeColor = System.Drawing.Color.White;
            this.btnFillIn.Location = new System.Drawing.Point(3, 75);
            this.btnFillIn.Name = "btnFillIn";
            this.btnFillIn.Size = new System.Drawing.Size(551, 53);
            this.btnFillIn.TabIndex = 1;
            this.btnFillIn.Text = "Preencher o valor";
            this.btnFillIn.UseVisualStyleBackColor = false;
            this.btnFillIn.Click += new System.EventHandler(this.btnFillIn_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCreate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(3, 16);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(551, 53);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Criar o vetor";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(14, 590);
            this.lblResults.Name = "lblResults";
            this.lblResults.Padding = new System.Windows.Forms.Padding(370, 5, 370, 5);
            this.lblResults.Size = new System.Drawing.Size(973, 68);
            this.lblResults.TabIndex = 7;
            this.lblResults.Text = "Resultados";
            // 
            // FrmArrayGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.lstElements);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmArrayGenerator";
            this.Text = "Gerador de arrays";
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ListBox lstElements;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnQtZeros;
        private System.Windows.Forms.Button btnLowest;
        private System.Windows.Forms.Button btnBiggest;
        private System.Windows.Forms.Button btnFillIn;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblResults;
    }
}

