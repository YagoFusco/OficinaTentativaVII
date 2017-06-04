namespace TrabalhoFinal
{
    partial class Administração
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
            this.cbVehicle = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMotor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txService = new System.Windows.Forms.TextBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veículo:";
            // 
            // cbVehicle
            // 
            this.cbVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVehicle.FormattingEnabled = true;
            this.cbVehicle.Items.AddRange(new object[] {
            "A10",
            "A20",
            "AGILE",
            "ASTRA",
            "ASTROVAN",
            "BEL AIR",
            "BLAZER",
            "BONANZA",
            "BRASIL",
            "BRASINCA",
            "C10",
            "C14",
            "C20",
            "CALIBRA",
            "CAMARO",
            "CAPRICE",
            "CAPITIVA",
            "CARAVAN",
            "CELTA",
            "CHEVELLE",
            "CHEVETTE",
            "CHEVY 500",
            "CLASSIC",
            "COBALT",
            "CORSA",
            "CORVETTE",
            "CRUZE",
            "D10",
            "D20",
            "DE LUXE",
            "EL CAMINO",
            "FLEETMASTER",
            "GRAND BLAZER",
            "HHR",
            "IMPALA",
            "IPANEMA",
            "KADETT",
            "LUMINA",
            "MALIBU",
            "MARAJÓ",
            "MASTER",
            "MERIVA",
            "MONTANA",
            "MONTE CARLO",
            "MONZA",
            "OMEGA",
            "ONIX",
            "OPALA",
            "PICK UP",
            "PRISMA",
            "RAMONA",
            "S10",
            "SILVERADO",
            "SONIC",
            "SPACE VAN",
            "SPIN",
            "SS",
            "SSR",
            "SUBURBAN",
            "SUPREMA",
            "TAHOE",
            "TIGRA",
            "TRACKER",
            "TRAFIC",
            "TRAILBLAZER",
            "VECTRA",
            "VERANEIO",
            "ZAFIRA"});
            this.cbVehicle.Location = new System.Drawing.Point(65, 11);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(207, 21);
            this.cbVehicle.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Motorização:";
            // 
            // cbMotor
            // 
            this.cbMotor.FormattingEnabled = true;
            this.cbMotor.Items.AddRange(new object[] {
            "1.0",
            "1.4",
            "1.6",
            "1.8",
            "2.0",
            "2.2",
            "2.4",
            "3.0",
            "3.6",
            "4.1"});
            this.cbMotor.Location = new System.Drawing.Point(86, 38);
            this.cbMotor.Name = "cbMotor";
            this.cbMotor.Size = new System.Drawing.Size(186, 21);
            this.cbMotor.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Serviço oferecido:";
            // 
            // txService
            // 
            this.txService.Location = new System.Drawing.Point(111, 65);
            this.txService.Name = "txService";
            this.txService.Size = new System.Drawing.Size(161, 20);
            this.txService.TabIndex = 15;
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(15, 91);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(257, 55);
            this.btRegister.TabIndex = 16;
            this.btRegister.Text = "Cadastrar Serviço";
            this.btRegister.UseVisualStyleBackColor = true;
            // 
            // Administração
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.txService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMotor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbVehicle);
            this.Controls.Add(this.label1);
            this.Name = "Administração";
            this.Text = "Cadastro de serviço";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMotor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbVehicle;
        private System.Windows.Forms.TextBox txService;
        private System.Windows.Forms.Button btRegister;
    }
}