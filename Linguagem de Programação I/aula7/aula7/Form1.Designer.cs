namespace aula7
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btParar = new System.Windows.Forms.Button();
            this.btIniciar = new System.Windows.Forms.Button();
            this.btIniciarParar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(484, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(448, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tempo";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // btParar
            // 
            this.btParar.BackColor = System.Drawing.Color.Transparent;
            this.btParar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btParar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btParar.Location = new System.Drawing.Point(100, 40);
            this.btParar.Name = "btParar";
            this.btParar.Size = new System.Drawing.Size(170, 101);
            this.btParar.TabIndex = 2;
            this.btParar.Text = "Parar";
            this.btParar.UseVisualStyleBackColor = false;
            this.btParar.Click += new System.EventHandler(this.BtParar_Click);
            // 
            // btIniciar
            // 
            this.btIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btIniciar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btIniciar.Location = new System.Drawing.Point(100, 219);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(170, 101);
            this.btIniciar.TabIndex = 3;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = false;
            this.btIniciar.Click += new System.EventHandler(this.BtIniciar_Click);
            this.btIniciar.MouseHover += new System.EventHandler(this.BtIniciar_Click);
            // 
            // btIniciarParar
            // 
            this.btIniciarParar.BackColor = System.Drawing.Color.Transparent;
            this.btIniciarParar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btIniciarParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIniciarParar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btIniciarParar.Location = new System.Drawing.Point(51, 405);
            this.btIniciarParar.Name = "btIniciarParar";
            this.btIniciarParar.Size = new System.Drawing.Size(279, 101);
            this.btIniciarParar.TabIndex = 4;
            this.btIniciarParar.Text = "Iniciar + Parar";
            this.btIniciarParar.UseVisualStyleBackColor = false;
            this.btIniciarParar.MouseLeave += new System.EventHandler(this.BtIniciarParar_MouseLeave);
            this.btIniciarParar.MouseHover += new System.EventHandler(this.BtIniciarParar_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::aula7.Properties.Resources.neon_tropical_monstera_leaf_banner;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(694, 542);
            this.Controls.Add(this.btIniciarParar);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.btParar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Cóe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.BtIniciar_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btParar;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Button btIniciarParar;
    }
}

