namespace Prova2
{
    partial class Tela
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
            br_Servico = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // br_Servico
            // 
            br_Servico.BackColor = SystemColors.ControlDarkDark;
            br_Servico.Location = new Point(307, 343);
            br_Servico.Name = "br_Servico";
            br_Servico.Size = new Size(148, 59);
            br_Servico.TabIndex = 0;
            br_Servico.Text = "Servico";
            br_Servico.UseVisualStyleBackColor = false;
            br_Servico.Click += br_Servico_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(282, 110);
            label1.Name = "label1";
            label1.Size = new Size(205, 28);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de Servico:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(br_Servico);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button br_Servico;
        private Label label1;
    }
}