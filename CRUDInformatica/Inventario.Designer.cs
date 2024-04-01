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
            button1 = new Button();
            label9 = new Label();
            numericUpDown1 = new NumericUpDown();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 510);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(207, 506);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(100, 23);
            txt_id.TabIndex = 1;
            txt_id.KeyUp += txt_id_KeyUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 43);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Item:";
            // 
            // txt_item
            // 
            txt_item.Location = new Point(69, 40);
            txt_item.Name = "txt_item";
            txt_item.Size = new Size(481, 23);
            txt_item.TabIndex = 3;
            txt_item.KeyUp += txt_item_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 72);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Marca:";
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(69, 69);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(481, 23);
            txt_marca.TabIndex = 5;
            // 
            // txt_modelo
            // 
            txt_modelo.Location = new Point(69, 98);
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Size = new Size(481, 23);
            txt_modelo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 101);
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
            dataGridView1.Location = new Point(12, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(538, 354);
            dataGridView1.TabIndex = 8;
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.Location = new Point(463, 506);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(87, 23);
            btn_pesquisar.TabIndex = 9;
            btn_pesquisar.Text = "Fazer retirada";
            btn_pesquisar.UseVisualStyleBackColor = true;
            btn_pesquisar.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(475, 551);
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(388, 506);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(69, 23);
            numericUpDown1.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(313, 510);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 21;
            label10.Text = "Quantidade";
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 586);
            Controls.Add(label10);
            Controls.Add(numericUpDown1);
            Controls.Add(label9);
            Controls.Add(button1);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private Button button1;
        private Label label9;
        private NumericUpDown numericUpDown1;
        private Label label10;
    }
}