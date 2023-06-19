namespace Prova2
{
    partial class Servico
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lb_Label5 = new Label();
            comboBox1 = new ComboBox();
            cb_Servico = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 37);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Computador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 100);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 225);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 2;
            label3.Text = "Tipo de pagamento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 158);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Servico";
            // 
            // lb_Label5
            // 
            lb_Label5.AutoSize = true;
            lb_Label5.Location = new Point(37, 288);
            lb_Label5.Name = "lb_Label5";
            lb_Label5.Size = new Size(81, 20);
            lb_Label5.TabIndex = 4;
            lb_Label5.Text = "Valor Final:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dinheiro", "Pix", "Cartao" });
            comboBox1.Location = new Point(182, 222);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // cb_Servico
            // 
            cb_Servico.FormattingEnabled = true;
            cb_Servico.Items.AddRange(new object[] { "Formatacao", "Limpeza", "Troca de Peça" });
            cb_Servico.Location = new Point(108, 150);
            cb_Servico.Name = "cb_Servico";
            cb_Servico.Size = new Size(151, 28);
            cb_Servico.TabIndex = 6;
            cb_Servico.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GrayText;
            button1.Location = new Point(94, 358);
            button1.Name = "button1";
            button1.Size = new Size(139, 40);
            button1.TabIndex = 9;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(543, 358);
            button2.Name = "button2";
            button2.Size = new Size(125, 40);
            button2.TabIndex = 10;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // Servico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(cb_Servico);
            Controls.Add(comboBox1);
            Controls.Add(lb_Label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Servico";
            Text = "Servico";
            Load += Servico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lb_Label5;
        private ComboBox comboBox1;
        private ComboBox cb_Servico;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}