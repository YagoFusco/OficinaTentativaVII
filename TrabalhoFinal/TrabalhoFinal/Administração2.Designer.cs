namespace TrabalhoFinal
{
    partial class Administração2
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
            this.txNameFunc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txUserNameFunc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txPasswordFunc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFunction = new System.Windows.Forms.ComboBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txNameFunc
            // 
            this.txNameFunc.Location = new System.Drawing.Point(56, 12);
            this.txNameFunc.Name = "txNameFunc";
            this.txNameFunc.Size = new System.Drawing.Size(216, 20);
            this.txNameFunc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome de usuário:";
            // 
            // txUserNameFunc
            // 
            this.txUserNameFunc.Location = new System.Drawing.Point(108, 38);
            this.txUserNameFunc.Name = "txUserNameFunc";
            this.txUserNameFunc.Size = new System.Drawing.Size(164, 20);
            this.txUserNameFunc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // txPasswordFunc
            // 
            this.txPasswordFunc.Location = new System.Drawing.Point(59, 64);
            this.txPasswordFunc.Name = "txPasswordFunc";
            this.txPasswordFunc.Size = new System.Drawing.Size(213, 20);
            this.txPasswordFunc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Função/Cargo:";
            // 
            // cbFunction
            // 
            this.cbFunction.FormattingEnabled = true;
            this.cbFunction.Items.AddRange(new object[] {
            "Gerente",
            "Mecânico",
            "Borracheiro",
            "Instalador de acessórios"});
            this.cbFunction.Location = new System.Drawing.Point(97, 90);
            this.cbFunction.Name = "cbFunction";
            this.cbFunction.Size = new System.Drawing.Size(175, 21);
            this.cbFunction.TabIndex = 7;
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(15, 117);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(257, 55);
            this.btRegister.TabIndex = 8;
            this.btRegister.Text = "Cadastrar";
            this.btRegister.UseVisualStyleBackColor = true;
            // 
            // Administração2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 182);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.cbFunction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txPasswordFunc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txUserNameFunc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txNameFunc);
            this.Controls.Add(this.label1);
            this.Name = "Administração2";
            this.Text = "Cadastro de funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNameFunc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txUserNameFunc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txPasswordFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFunction;
        private System.Windows.Forms.Button btRegister;
    }
}