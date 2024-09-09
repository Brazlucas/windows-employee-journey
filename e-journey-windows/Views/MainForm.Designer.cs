namespace e_journey_windows.Views
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // Componentes da interface do usuário
        private System.Windows.Forms.MaskedTextBox maskedTxtEntrada;
        private System.Windows.Forms.MaskedTextBox maskedTxtAlmocoSaida;
        private System.Windows.Forms.MaskedTextBox maskedTxtAlmocoRetorno;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.CheckBox chkNotification;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.maskedTxtEntrada = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtAlmocoSaida = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtAlmocoRetorno = new System.Windows.Forms.MaskedTextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.chkNotification = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();

            // 
            // maskedTxtEntrada
            // 
            this.maskedTxtEntrada.Location = new System.Drawing.Point(15, 25);
            this.maskedTxtEntrada.Mask = "00:00";
            this.maskedTxtEntrada.Name = "maskedTxtEntrada";
            this.maskedTxtEntrada.Size = new System.Drawing.Size(100, 20);
            this.maskedTxtEntrada.TabIndex = 0;
            this.maskedTxtEntrada.ValidatingType = typeof(System.DateTime);

            // 
            // maskedTxtAlmocoSaida
            // 
            this.maskedTxtAlmocoSaida.Location = new System.Drawing.Point(15, 65);
            this.maskedTxtAlmocoSaida.Mask = "00:00";
            this.maskedTxtAlmocoSaida.Name = "maskedTxtAlmocoSaida";
            this.maskedTxtAlmocoSaida.Size = new System.Drawing.Size(100, 20);
            this.maskedTxtAlmocoSaida.TabIndex = 1;
            this.maskedTxtAlmocoSaida.ValidatingType = typeof(System.DateTime);

            // 
            // maskedTxtAlmocoRetorno
            // 
            this.maskedTxtAlmocoRetorno.Location = new System.Drawing.Point(15, 105);
            this.maskedTxtAlmocoRetorno.Mask = "00:00";
            this.maskedTxtAlmocoRetorno.Name = "maskedTxtAlmocoRetorno";
            this.maskedTxtAlmocoRetorno.Size = new System.Drawing.Size(100, 20);
            this.maskedTxtAlmocoRetorno.TabIndex = 2;
            this.maskedTxtAlmocoRetorno.ValidatingType = typeof(System.DateTime);

            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 145);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 245);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Salvar e Minimizar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(15, 185);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 4;

            // 
            // chkNotification
            // 
            this.chkNotification.AutoSize = true;
            this.chkNotification.Location = new System.Drawing.Point(15, 215);
            this.chkNotification.Name = "chkNotification";
            this.chkNotification.Size = new System.Drawing.Size(118, 17);
            this.chkNotification.TabIndex = 5;
            this.chkNotification.Text = "Receber notificação";
            this.chkNotification.UseVisualStyleBackColor = true;

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 300); // Ajusta o tamanho do formulário para acomodar todos os elementos
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkNotification);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.maskedTxtAlmocoRetorno);
            this.Controls.Add(this.maskedTxtAlmocoSaida);
            this.Controls.Add(this.maskedTxtEntrada);
            this.Name = "MainForm";
            this.Text = "Calculadora de Jornada de Trabalho";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
