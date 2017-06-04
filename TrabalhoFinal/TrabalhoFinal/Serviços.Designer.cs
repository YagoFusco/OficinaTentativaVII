namespace TrabalhoFinal
{
    partial class Serviços
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txPlateCPF = new System.Windows.Forms.TextBox();
            this.dateTimeSchedule = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_Proprietário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Proprietário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serviço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Agendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSchedule = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSchedule);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.cbService);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimeSchedule);
            this.groupBox1.Controls.Add(this.txPlateCPF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agendar serviço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF do proprietário ou placa do veículo:";
            // 
            // txPlateCPF
            // 
            this.txPlateCPF.Location = new System.Drawing.Point(210, 22);
            this.txPlateCPF.Name = "txPlateCPF";
            this.txPlateCPF.Size = new System.Drawing.Size(198, 20);
            this.txPlateCPF.TabIndex = 1;
            // 
            // dateTimeSchedule
            // 
            this.dateTimeSchedule.Location = new System.Drawing.Point(180, 75);
            this.dateTimeSchedule.Name = "dateTimeSchedule";
            this.dateTimeSchedule.Size = new System.Drawing.Size(228, 20);
            this.dateTimeSchedule.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data do agendamento do serviço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Serviço a ser realizado:";
            // 
            // cbService
            // 
            this.cbService.FormattingEnabled = true;
            this.cbService.Items.AddRange(new object[] {
            "Revisão 10 mil km",
            "Revisão 20 mil km",
            "Revisão 30 mil km",
            "Revisão 40 mil km",
            "Revisão 50 mil km",
            "Revisão 60 mil km",
            "Revisão 70 mil km",
            "Revisão 80 mil km",
            "Revisão 90 mil km",
            "Revisão 100 mil km",
            "Revisão 110 mil km",
            "Revisão 120 mil km",
            "Troca de óleo",
            "Funilaria",
            "Pintura",
            "Funilaria e pintura",
            "Diagnóstico",
            "Alinhamento e balanceamento",
            "Troca de pneus",
            "Serviço de freios",
            "Outros"});
            this.cbService.Location = new System.Drawing.Point(129, 48);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(279, 21);
            this.cbService.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Placa,
            this.CPF_Proprietário,
            this.Nome_Proprietário,
            this.Serviço,
            this.Data_Agendamento});
            this.dataGridView1.Location = new System.Drawing.Point(6, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(583, 98);
            this.dataGridView1.TabIndex = 0;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            // 
            // CPF_Proprietário
            // 
            this.CPF_Proprietário.HeaderText = "CPF_Proprietário";
            this.CPF_Proprietário.Name = "CPF_Proprietário";
            // 
            // Nome_Proprietário
            // 
            this.Nome_Proprietário.HeaderText = "Nome_Proprietário";
            this.Nome_Proprietário.Name = "Nome_Proprietário";
            // 
            // Serviço
            // 
            this.Serviço.HeaderText = "Serviço";
            this.Serviço.Name = "Serviço";
            // 
            // Data_Agendamento
            // 
            this.Data_Agendamento.HeaderText = "Data_Agendamento";
            this.Data_Agendamento.Name = "Data_Agendamento";
            // 
            // btSchedule
            // 
            this.btSchedule.Location = new System.Drawing.Point(447, 25);
            this.btSchedule.Name = "btSchedule";
            this.btSchedule.Size = new System.Drawing.Size(114, 69);
            this.btSchedule.TabIndex = 6;
            this.btSchedule.Text = "Agendar";
            this.btSchedule.UseVisualStyleBackColor = true;
            // 
            // Serviços
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 254);
            this.Controls.Add(this.groupBox1);
            this.Name = "Serviços";
            this.Text = "Serviços";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeSchedule;
        private System.Windows.Forms.TextBox txPlateCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_Proprietário;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Proprietário;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serviço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Agendamento;
        private System.Windows.Forms.Button btSchedule;
    }
}