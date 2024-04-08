namespace AulaNivia_Condicional
{
    partial class Form3
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
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblsalario = new System.Windows.Forms.Label();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btmCalcular = new System.Windows.Forms.Button();
            this.btmLimpar = new System.Windows.Forms.Button();
            this.btmVoltar = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(216, 45);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 0;
            this.lblIdade.Text = "Idade:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(216, 77);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(32, 13);
            this.lblSexo.TabIndex = 1;
            this.lblSexo.Text = "sexo:";
            // 
            // lblsalario
            // 
            this.lblsalario.AutoSize = true;
            this.lblsalario.Location = new System.Drawing.Point(217, 110);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(42, 13);
            this.lblsalario.TabIndex = 2;
            this.lblsalario.Text = "Salário:";
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(283, 45);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(100, 20);
            this.txtidade.TabIndex = 3;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(283, 77);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(100, 20);
            this.txtSexo.TabIndex = 4;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(283, 110);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 5;
            // 
            // btmCalcular
            // 
            this.btmCalcular.Location = new System.Drawing.Point(295, 241);
            this.btmCalcular.Name = "btmCalcular";
            this.btmCalcular.Size = new System.Drawing.Size(75, 23);
            this.btmCalcular.TabIndex = 6;
            this.btmCalcular.Text = "Calcular";
            this.btmCalcular.UseVisualStyleBackColor = true;
            this.btmCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btmLimpar
            // 
            this.btmLimpar.Location = new System.Drawing.Point(295, 329);
            this.btmLimpar.Name = "btmLimpar";
            this.btmLimpar.Size = new System.Drawing.Size(75, 23);
            this.btmLimpar.TabIndex = 7;
            this.btmLimpar.Text = "Limpar";
            this.btmLimpar.UseVisualStyleBackColor = true;
            // 
            // btmVoltar
            // 
            this.btmVoltar.Location = new System.Drawing.Point(295, 358);
            this.btmVoltar.Name = "btmVoltar";
            this.btmVoltar.Size = new System.Drawing.Size(75, 23);
            this.btmVoltar.TabIndex = 8;
            this.btmVoltar.Text = "Voltar";
            this.btmVoltar.UseVisualStyleBackColor = true;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(226, 198);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(53, 13);
            this.lblresultado.TabIndex = 10;
            this.lblresultado.Text = "resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(285, 195);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 11;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btmVoltar);
            this.Controls.Add(this.btmLimpar);
            this.Controls.Add(this.btmCalcular);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.lblsalario);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblIdade);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblsalario;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btmCalcular;
        private System.Windows.Forms.Button btmLimpar;
        private System.Windows.Forms.Button btmVoltar;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtResultado;
    }
}