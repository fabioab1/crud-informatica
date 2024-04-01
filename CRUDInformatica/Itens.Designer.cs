namespace CRUDInformatica
{
    partial class Itens
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
            txt_item = new TextBox();
            label2 = new Label();
            txt_marca = new TextBox();
            txt_modelo = new TextBox();
            num_quantidade = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            btn_add = new Button();
            btn_salvar = new Button();
            btn_buscar = new Button();
            btn_editar = new Button();
            btn_apagar = new Button();
            btn_voltar = new Button();
            txt_id = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)num_quantidade).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Item:";
            // 
            // txt_item
            // 
            txt_item.Location = new Point(87, 41);
            txt_item.Name = "txt_item";
            txt_item.Size = new Size(355, 23);
            txt_item.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Marca:";
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(87, 70);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(355, 23);
            txt_marca.TabIndex = 3;
            // 
            // txt_modelo
            // 
            txt_modelo.Location = new Point(87, 99);
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Size = new Size(355, 23);
            txt_modelo.TabIndex = 4;
            // 
            // num_quantidade
            // 
            num_quantidade.Location = new Point(87, 128);
            num_quantidade.Name = "num_quantidade";
            num_quantidade.Size = new Size(120, 23);
            num_quantidade.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Modelo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 130);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 7;
            label4.Text = "Quantidade:";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(12, 172);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 8;
            btn_add.Text = "Adicionar";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(93, 172);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(75, 23);
            btn_salvar.TabIndex = 9;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(174, 172);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(75, 23);
            btn_buscar.TabIndex = 10;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(255, 172);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(75, 23);
            btn_editar.TabIndex = 11;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_apagar
            // 
            btn_apagar.Location = new Point(336, 172);
            btn_apagar.Name = "btn_apagar";
            btn_apagar.Size = new Size(75, 23);
            btn_apagar.TabIndex = 12;
            btn_apagar.Text = "Apagar";
            btn_apagar.UseVisualStyleBackColor = true;
            btn_apagar.Click += btn_apagar_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(12, 226);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(75, 23);
            btn_voltar.TabIndex = 13;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(87, 12);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(100, 23);
            txt_id.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 15);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 15;
            label5.Text = "ID:";
            // 
            // Itens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 261);
            Controls.Add(label5);
            Controls.Add(txt_id);
            Controls.Add(btn_voltar);
            Controls.Add(btn_apagar);
            Controls.Add(btn_editar);
            Controls.Add(btn_buscar);
            Controls.Add(btn_salvar);
            Controls.Add(btn_add);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(num_quantidade);
            Controls.Add(txt_modelo);
            Controls.Add(txt_marca);
            Controls.Add(label2);
            Controls.Add(txt_item);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Itens";
            Text = "Itens";
            ((System.ComponentModel.ISupportInitialize)num_quantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_item;
        private Label label2;
        private TextBox txt_marca;
        private TextBox txt_modelo;
        private NumericUpDown num_quantidade;
        private Label label3;
        private Label label4;
        private Button btn_add;
        private Button btn_salvar;
        private Button btn_buscar;
        private Button btn_editar;
        private Button btn_apagar;
        private Button btn_voltar;
        private TextBox txt_id;
        private Label label5;
    }
}