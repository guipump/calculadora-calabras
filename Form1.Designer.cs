namespace CalculadoraCalabresa
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.igual = new System.Windows.Forms.Button();
            this.virgula = new System.Windows.Forms.Button();
            this.ponto = new System.Windows.Forms.Button();
            this.multiplicaçao = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.subtraçao = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.adicao = new System.Windows.Forms.Button();
            this.copiar = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Turquoise;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxDisplay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(540, 589);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDisplay.Font = new System.Drawing.Font("MV Boli", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplay.Location = new System.Drawing.Point(3, 3);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(534, 141);
            this.textBoxDisplay.TabIndex = 0;
            this.textBoxDisplay.Text = "9999999";
            this.textBoxDisplay.TextChanged += new System.EventHandler(this.textBoxdisplay_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.2809F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.90637F));
            this.tableLayoutPanel2.Controls.Add(this.igual, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.virgula, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.ponto, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.multiplicaçao, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.button3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.divisao, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.button6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.subtraçao, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.button9, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button8, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.adicao, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.copiar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.apagar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.limpar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button0, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 150);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(534, 436);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // igual
            // 
            this.igual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.Location = new System.Drawing.Point(403, 351);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(128, 82);
            this.igual.TabIndex = 19;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // virgula
            // 
            this.virgula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.virgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virgula.Location = new System.Drawing.Point(269, 351);
            this.virgula.Name = "virgula";
            this.virgula.Size = new System.Drawing.Size(128, 82);
            this.virgula.TabIndex = 18;
            this.virgula.Text = ",";
            this.virgula.UseVisualStyleBackColor = true;
            this.virgula.Click += new System.EventHandler(this.virgula_Click);
            // 
            // ponto
            // 
            this.ponto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ponto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ponto.Location = new System.Drawing.Point(3, 351);
            this.ponto.Name = "ponto";
            this.ponto.Size = new System.Drawing.Size(127, 82);
            this.ponto.TabIndex = 17;
            this.ponto.Text = ".";
            this.ponto.UseVisualStyleBackColor = true;
            this.ponto.Click += new System.EventHandler(this.ponto_Click);
            // 
            // multiplicaçao
            // 
            this.multiplicaçao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplicaçao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicaçao.Location = new System.Drawing.Point(403, 264);
            this.multiplicaçao.Name = "multiplicaçao";
            this.multiplicaçao.Size = new System.Drawing.Size(128, 81);
            this.multiplicaçao.TabIndex = 16;
            this.multiplicaçao.Text = "x";
            this.multiplicaçao.UseVisualStyleBackColor = true;
            this.multiplicaçao.Click += new System.EventHandler(this.multiplicaçao_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(269, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 81);
            this.button3.TabIndex = 15;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(136, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 81);
            this.button2.TabIndex = 14;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 81);
            this.button1.TabIndex = 13;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // divisao
            // 
            this.divisao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisao.Location = new System.Drawing.Point(403, 177);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(128, 81);
            this.divisao.TabIndex = 12;
            this.divisao.Text = "%";
            this.divisao.UseVisualStyleBackColor = true;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(269, 177);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 81);
            this.button6.TabIndex = 11;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(136, 177);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 81);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 81);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // subtraçao
            // 
            this.subtraçao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subtraçao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtraçao.Location = new System.Drawing.Point(403, 90);
            this.subtraçao.Name = "subtraçao";
            this.subtraçao.Size = new System.Drawing.Size(128, 81);
            this.subtraçao.TabIndex = 8;
            this.subtraçao.Text = "-";
            this.subtraçao.UseVisualStyleBackColor = true;
            this.subtraçao.Click += new System.EventHandler(this.subtraçao_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(269, 90);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(128, 81);
            this.button9.TabIndex = 7;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(136, 90);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(127, 81);
            this.button8.TabIndex = 6;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(3, 90);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(127, 81);
            this.button7.TabIndex = 5;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // adicao
            // 
            this.adicao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicao.Location = new System.Drawing.Point(403, 3);
            this.adicao.Name = "adicao";
            this.adicao.Size = new System.Drawing.Size(128, 81);
            this.adicao.TabIndex = 4;
            this.adicao.Text = "+";
            this.adicao.UseVisualStyleBackColor = true;
            this.adicao.Click += new System.EventHandler(this.adicao_Click);
            // 
            // copiar
            // 
            this.copiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copiar.Location = new System.Drawing.Point(269, 3);
            this.copiar.Name = "copiar";
            this.copiar.Size = new System.Drawing.Size(128, 81);
            this.copiar.TabIndex = 3;
            this.copiar.Text = "copiar";
            this.copiar.UseVisualStyleBackColor = true;
            this.copiar.Click += new System.EventHandler(this.copiar_Click);
            // 
            // apagar
            // 
            this.apagar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagar.Location = new System.Drawing.Point(136, 3);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(127, 81);
            this.apagar.TabIndex = 2;
            this.apagar.Text = "apagar";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // limpar
            // 
            this.limpar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.Location = new System.Drawing.Point(3, 3);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(127, 81);
            this.limpar.TabIndex = 1;
            this.limpar.Text = "limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.Control;
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(136, 351);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(127, 82);
            this.button0.TabIndex = 0;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 621);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Calculadora do Calabras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button virgula;
        private System.Windows.Forms.Button ponto;
        private System.Windows.Forms.Button multiplicaçao;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button subtraçao;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button adicao;
        private System.Windows.Forms.Button copiar;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button limpar;
    }
}

