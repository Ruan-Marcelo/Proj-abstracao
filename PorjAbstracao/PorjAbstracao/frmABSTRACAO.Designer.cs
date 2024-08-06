namespace PorjAbstracao
{
    partial class frmABSTRACAO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABSTRACAO));
            this.btnBebe = new System.Windows.Forms.Button();
            this.btnMae = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBebe
            // 
            this.btnBebe.BackColor = System.Drawing.Color.White;
            this.btnBebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBebe.Location = new System.Drawing.Point(90, 129);
            this.btnBebe.Name = "btnBebe";
            this.btnBebe.Size = new System.Drawing.Size(291, 78);
            this.btnBebe.TabIndex = 0;
            this.btnBebe.Text = "Bebê";
            this.btnBebe.UseVisualStyleBackColor = false;
            this.btnBebe.Click += new System.EventHandler(this.btnBebe_Click);
            // 
            // btnMae
            // 
            this.btnMae.BackColor = System.Drawing.Color.White;
            this.btnMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMae.Location = new System.Drawing.Point(90, 355);
            this.btnMae.Name = "btnMae";
            this.btnMae.Size = new System.Drawing.Size(291, 82);
            this.btnMae.TabIndex = 1;
            this.btnMae.Text = "Mãe";
            this.btnMae.UseVisualStyleBackColor = false;
            this.btnMae.Click += new System.EventHandler(this.btnMae_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.BackColor = System.Drawing.Color.White;
            this.btnMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedico.Location = new System.Drawing.Point(90, 239);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(291, 87);
            this.btnMedico.TabIndex = 2;
            this.btnMedico.Text = "Médico";
            this.btnMedico.UseVisualStyleBackColor = false;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(90, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 34);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Maternidade";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pebebe");
            this.imageList1.Images.SetKeyName(1, "maternidade");
            // 
            // button2
            // 
            this.button2.Image = global::PorjAbstracao.Properties.Resources.download;
            this.button2.Location = new System.Drawing.Point(509, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 200);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::PorjAbstracao.Properties.Resources.download__1_;
            this.button1.Location = new System.Drawing.Point(509, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 218);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmABSTRACAO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(788, 493);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMedico);
            this.Controls.Add(this.btnMae);
            this.Controls.Add(this.btnBebe);
            this.Name = "frmABSTRACAO";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBebe;
        private System.Windows.Forms.Button btnMae;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
    }
}

