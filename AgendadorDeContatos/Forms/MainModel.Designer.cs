namespace AgendadorDeContatos
{
    partial class MainModel
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonCadastro = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnDelete = new Button();
            btnConsultar = new Button();
            maskedTextBox1 = new MaskedTextBox();
            dataGridView1 = new DataGridView();
            btnAtualizacao = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            panel2 = new Panel();
            textBox5 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 272);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 8;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 313);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 9;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 352);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 8;
            label3.Text = "Telefone";
            // 
            // buttonCadastro
            // 
            buttonCadastro.Location = new Point(68, 409);
            buttonCadastro.Name = "buttonCadastro";
            buttonCadastro.Size = new Size(75, 23);
            buttonCadastro.TabIndex = 4;
            buttonCadastro.Text = "Cadastrar";
            buttonCadastro.UseVisualStyleBackColor = true;
            buttonCadastro.Click += buttonCadastro_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.ForeColor = SystemColors.InactiveCaptionText;
            textBox1.Location = new Point(68, 269);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(68, 310);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(335, 23);
            textBox2.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(277, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(172, 409);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 12;
            btnConsultar.Text = "Consulta";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(68, 349);
            maskedTextBox1.Mask = "(99) 0 0000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(179, 23);
            maskedTextBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(550, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 426);
            dataGridView1.TabIndex = 13;
            // 
            // btnAtualizacao
            // 
            btnAtualizacao.Location = new Point(166, 161);
            btnAtualizacao.Name = "btnAtualizacao";
            btnAtualizacao.Size = new Size(96, 23);
            btnAtualizacao.TabIndex = 10;
            btnAtualizacao.Text = "Atualização";
            btnAtualizacao.UseVisualStyleBackColor = true;
            btnAtualizacao.Click += btnAtualizacao_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 62);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 19;
            label4.Text = "Nome";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Window;
            textBox3.Location = new Point(93, 57);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(230, 23);
            textBox3.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(maskedTextBox2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnAtualizacao);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(391, 201);
            panel2.TabIndex = 19;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Window;
            textBox5.Location = new Point(93, 21);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(69, 23);
            textBox5.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 29);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 25;
            label7.Text = "ID";
            label7.UseMnemonic = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 93);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 23;
            label6.Text = "Email";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(93, 123);
            maskedTextBox2.Mask = "(99) 0 0000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(179, 23);
            maskedTextBox2.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 126);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 22;
            label5.Text = "Telefone";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Window;
            textBox4.Location = new Point(93, 90);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(230, 23);
            textBox4.TabIndex = 20;
            // 
            // MainModel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1014, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnDelete);
            Controls.Add(maskedTextBox1);
            Controls.Add(btnConsultar);
            Controls.Add(buttonCadastro);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MainModel";
            Text = "Agenda de Contato";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonCadastro;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnDelete;
        private Button btnConsultar;
        private MaskedTextBox maskedTextBox1;
        private DataGridView dataGridView1;
        private Button btnAtualizacao;
        private Label label4;
        private TextBox textBox3;
        private Panel panel2;
        private Label label6;
        private MaskedTextBox maskedTextBox2;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label7;
    }
}
