namespace AppWinForms
{
    partial class CadastroVeiculo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxbQtdPortas = new System.Windows.Forms.TextBox();
            this.TxbModelo = new System.Windows.Forms.TextBox();
            this.TxbMarca = new System.Windows.Forms.TextBox();
            this.TxbCor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro veiculo";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cor: ";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modelo: ";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Qtd. portas: ";
            // 
            // TxbQtdPortas
            // 
            this.TxbQtdPortas.Location = new System.Drawing.Point(23, 221);
            this.TxbQtdPortas.Name = "TxbQtdPortas";
            this.TxbQtdPortas.Size = new System.Drawing.Size(232, 20);
            this.TxbQtdPortas.TabIndex = 5;
            // 
            // TxbModelo
            // 
            this.TxbModelo.Location = new System.Drawing.Point(23, 170);
            this.TxbModelo.Name = "TxbModelo";
            this.TxbModelo.Size = new System.Drawing.Size(232, 20);
            this.TxbModelo.TabIndex = 6;
            // 
            // TxbMarca
            // 
            this.TxbMarca.Location = new System.Drawing.Point(23, 121);
            this.TxbMarca.Name = "TxbMarca";
            this.TxbMarca.Size = new System.Drawing.Size(232, 20);
            this.TxbMarca.TabIndex = 7;
            // 
            // TxbCor
            // 
            this.TxbCor.Location = new System.Drawing.Point(23, 73);
            this.TxbCor.Name = "TxbCor";
            this.TxbCor.Size = new System.Drawing.Size(232, 20);
            this.TxbCor.TabIndex = 8;
            this.TxbCor.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // CadastroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 369);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxbCor);
            this.Controls.Add(this.TxbMarca);
            this.Controls.Add(this.TxbModelo);
            this.Controls.Add(this.TxbQtdPortas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroVeiculo";
            this.Text = "CadastroVeiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxbQtdPortas;
        private System.Windows.Forms.TextBox TxbModelo;
        private System.Windows.Forms.TextBox TxbMarca;
        private System.Windows.Forms.TextBox TxbCor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}