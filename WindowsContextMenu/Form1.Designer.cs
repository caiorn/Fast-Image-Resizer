namespace WindowsContextMenu
{
    partial class Form1
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
            this.nudLarguraWidth = new System.Windows.Forms.NumericUpDown();
            this.nudAlturaHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudLarguraWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlturaHeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudLarguraWidth
            // 
            this.nudLarguraWidth.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudLarguraWidth.Location = new System.Drawing.Point(93, 32);
            this.nudLarguraWidth.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudLarguraWidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudLarguraWidth.Name = "nudLarguraWidth";
            this.nudLarguraWidth.Size = new System.Drawing.Size(65, 20);
            this.nudLarguraWidth.TabIndex = 0;
            this.nudLarguraWidth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // nudAlturaHeight
            // 
            this.nudAlturaHeight.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAlturaHeight.Location = new System.Drawing.Point(93, 60);
            this.nudAlturaHeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudAlturaHeight.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAlturaHeight.Name = "nudAlturaHeight";
            this.nudAlturaHeight.Size = new System.Drawing.Size(65, 20);
            this.nudAlturaHeight.TabIndex = 1;
            this.nudAlturaHeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Largura maxima:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudLarguraWidth);
            this.groupBox1.Controls.Add(this.nudAlturaHeight);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 88);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurar Dimenções";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Altura maxima:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 127);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(114, 127);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 161);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração de Atalho de Corte";
            ((System.ComponentModel.ISupportInitialize)(this.nudLarguraWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlturaHeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudLarguraWidth;
        private System.Windows.Forms.NumericUpDown nudAlturaHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
    }
}

