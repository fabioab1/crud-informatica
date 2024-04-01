namespace CRUDInformatica
{
    partial class Inventario
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
            txt_id = new TextBox();
            label2 = new Label();
            txt_item = new TextBox();
            label3 = new Label();
            txt_marca = new TextBox();
            txt_modelo = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            btn_pesquisar = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lbl_nome = new Label();
            lbl_marca = new Label();
            lbl_quantidade = new Label();
            lbl_modelo = new Label();
            button1 = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 493);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(39, 490);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(100, 23);
            txt_id.TabIndex = 1;
            txt_id.KeyUp += txt_id_KeyUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 46);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Item:";
            // 
            // txt_item
            // 
            txt_item.Location = new Point(69, 43);
            txt_item.Name = "txt_item";
            txt_item.Size = new Size(481, 23);
            txt_item.TabIndex = 3;
            txt_item.KeyUp += txt_item_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 75);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Marca:";
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(69, 72);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(481, 23);
            txt_marca.TabIndex = 5;
            // 
            // txt_modelo
            // 
            txt_modelo.Location = new Point(69, 101);
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Size = new Size(481, 23);
            txt_modelo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 104);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Modelo:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(538, 354);
            dataGridView1.TabIndex = 8;
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.Location = new Point(145, 490);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(75, 23);
            btn_pesquisar.TabIndex = 9;
            btn_pesquisar.Text = "Pesquisar";
            btn_pesquisar.UseVisualStyleBackColor = true;
            btn_pesquisar.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(12, 516);
            label5.Name = "label5";
            label5.Size = new Size(70, 28);
            label5.TabIndex = 10;
            label5.Text = "Nome:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(12, 544);
            label6.Name = "label6";
            label6.Size = new Size(70, 28);
            label6.TabIndex = 11;
            label6.Text = "Marca:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(12, 572);
            label7.Name = "label7";
            label7.Size = new Size(85, 28);
            label7.TabIndex = 12;
            label7.Text = "Modelo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(12, 600);
            label8.Name = "label8";
            label8.Size = new Size(119, 28);
            label8.TabIndex = 13;
            label8.Text = "Quantidade:";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Segoe UI", 15F);
            lbl_nome.Location = new Point(103, 516);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(0, 28);
            lbl_nome.TabIndex = 14;
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Font = new Font("Segoe UI", 15F);
            lbl_marca.Location = new Point(103, 544);
            lbl_marca.Name = "lbl_marca";
            lbl_marca.Size = new Size(0, 28);
            lbl_marca.TabIndex = 15;
            // 
            // lbl_quantidade
            // 
            lbl_quantidade.AutoSize = true;
            lbl_quantidade.Font = new Font("Segoe UI", 15F);
            lbl_quantidade.Location = new Point(137, 600);
            lbl_quantidade.Name = "lbl_quantidade";
            lbl_quantidade.Size = new Size(0, 28);
            lbl_quantidade.TabIndex = 16;
            // 
            // lbl_modelo
            // 
            lbl_modelo.AutoSize = true;
            lbl_modelo.Font = new Font("Segoe UI", 15F);
            lbl_modelo.Location = new Point(103, 572);
            lbl_modelo.Name = "lbl_modelo";
            lbl_modelo.Size = new Size(0, 28);
            lbl_modelo.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(475, 634);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(103, 28);
            label9.TabIndex = 19;
            label9.Text = "Filtrar por:";
            label9.Click += label9_Click;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 669);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(lbl_modelo);
            Controls.Add(lbl_quantidade);
            Controls.Add(lbl_marca);
            Controls.Add(lbl_nome);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btn_pesquisar);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(txt_modelo);
            Controls.Add(txt_marca);
            Controls.Add(label3);
            Controls.Add(txt_item);
            Controls.Add(label2);
            Controls.Add(txt_id);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Inventario";
            Text = "Inventário";
            Load += Inventario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_id;
        private Label label2;
        private TextBox txt_item;
        private Label label3;
        private TextBox txt_marca;
        private TextBox txt_modelo;
        private Label label4;
        private DataGridView dataGridView1;
        private Button btn_pesquisar;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lbl_nome;
        private Label lbl_marca;
        private Label lbl_quantidade;
        private Label lbl_modelo;
        private Button button1;
        private Label label9;
    }
}