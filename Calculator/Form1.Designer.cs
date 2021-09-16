
namespace Calculator
{
    partial class Form1
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
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.optSoma = new System.Windows.Forms.RadioButton();
            this.optSubtrai = new System.Windows.Forms.RadioButton();
            this.optMultiplica = new System.Windows.Forms.RadioButton();
            this.optDivide = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(12, 32);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 23);
            this.txtValor1.TabIndex = 0;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(155, 32);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 23);
            this.txtValor2.TabIndex = 1;
            // 
            // optSoma
            // 
            this.optSoma.AutoSize = true;
            this.optSoma.Location = new System.Drawing.Point(12, 61);
            this.optSoma.Name = "optSoma";
            this.optSoma.Size = new System.Drawing.Size(55, 19);
            this.optSoma.TabIndex = 2;
            this.optSoma.TabStop = true;
            this.optSoma.Text = "Soma";
            this.optSoma.UseVisualStyleBackColor = true;
            // 
            // optSubtrai
            // 
            this.optSubtrai.AutoSize = true;
            this.optSubtrai.Location = new System.Drawing.Point(12, 87);
            this.optSubtrai.Name = "optSubtrai";
            this.optSubtrai.Size = new System.Drawing.Size(78, 19);
            this.optSubtrai.TabIndex = 3;
            this.optSubtrai.TabStop = true;
            this.optSubtrai.Text = "Subtração";
            this.optSubtrai.UseVisualStyleBackColor = true;
            // 
            // optMultiplica
            // 
            this.optMultiplica.AutoSize = true;
            this.optMultiplica.Location = new System.Drawing.Point(12, 113);
            this.optMultiplica.Name = "optMultiplica";
            this.optMultiplica.Size = new System.Drawing.Size(97, 19);
            this.optMultiplica.TabIndex = 4;
            this.optMultiplica.TabStop = true;
            this.optMultiplica.Text = "Multiplicação";
            this.optMultiplica.UseVisualStyleBackColor = true;
            // 
            // optDivide
            // 
            this.optDivide.AutoSize = true;
            this.optDivide.Location = new System.Drawing.Point(13, 139);
            this.optDivide.Name = "optDivide";
            this.optDivide.Size = new System.Drawing.Size(63, 19);
            this.optDivide.TabIndex = 5;
            this.optDivide.TabStop = true;
            this.optDivide.Text = "Divisão";
            this.optDivide.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resultado:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(81, 165);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 15);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "0";
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Location = new System.Drawing.Point(12, 189);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(100, 23);
            this.cmdCalcular.TabIndex = 8;
            this.cmdCalcular.Text = "OK";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.cmdCalcular_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.Location = new System.Drawing.Point(155, 189);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(100, 23);
            this.cmdSair.TabIndex = 9;
            this.cmdSair.Text = "Sair";
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Número 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Número 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 223);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmdCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optDivide);
            this.Controls.Add(this.optMultiplica);
            this.Controls.Add(this.optSubtrai);
            this.Controls.Add(this.optSoma);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Name = "Form1";
            this.Text = "Calculadora C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.RadioButton optSoma;
        private System.Windows.Forms.RadioButton optSubtrai;
        private System.Windows.Forms.RadioButton optMultiplica;
        private System.Windows.Forms.RadioButton optDivide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button cmdCalcular;
        private System.Windows.Forms.Button cmdSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

