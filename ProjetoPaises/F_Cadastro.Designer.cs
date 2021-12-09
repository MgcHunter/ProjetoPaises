namespace ProjetoPaises
{
    partial class F_Cadastro
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
            this.BT_ADD = new System.Windows.Forms.Button();
            this.BT_Edit = new System.Windows.Forms.Button();
            this.BT_REMOVE = new System.Windows.Forms.Button();
            this.BT_Pesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TX_Cod = new System.Windows.Forms.TextBox();
            this.TX_Pais = new System.Windows.Forms.TextBox();
            this.TX_Populacao = new System.Windows.Forms.TextBox();
            this.TX_Area = new System.Windows.Forms.TextBox();
            this.BT_Listar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DG_Lista = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_ADD
            // 
            this.BT_ADD.Location = new System.Drawing.Point(48, 164);
            this.BT_ADD.Name = "BT_ADD";
            this.BT_ADD.Size = new System.Drawing.Size(75, 23);
            this.BT_ADD.TabIndex = 0;
            this.BT_ADD.Text = "Adicionar";
            this.BT_ADD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BT_ADD.UseVisualStyleBackColor = true;
            this.BT_ADD.Click += new System.EventHandler(this.BT_ADD_Click);
            // 
            // BT_Edit
            // 
            this.BT_Edit.Location = new System.Drawing.Point(129, 164);
            this.BT_Edit.Name = "BT_Edit";
            this.BT_Edit.Size = new System.Drawing.Size(75, 23);
            this.BT_Edit.TabIndex = 1;
            this.BT_Edit.Text = "Editar";
            this.BT_Edit.UseVisualStyleBackColor = true;
            this.BT_Edit.Click += new System.EventHandler(this.BT_Edit_Click);
            // 
            // BT_REMOVE
            // 
            this.BT_REMOVE.Location = new System.Drawing.Point(210, 164);
            this.BT_REMOVE.Name = "BT_REMOVE";
            this.BT_REMOVE.Size = new System.Drawing.Size(75, 23);
            this.BT_REMOVE.TabIndex = 2;
            this.BT_REMOVE.Text = "Remover";
            this.BT_REMOVE.UseVisualStyleBackColor = true;
            this.BT_REMOVE.Click += new System.EventHandler(this.BT_REMOVE_Click);
            // 
            // BT_Pesquisar
            // 
            this.BT_Pesquisar.Location = new System.Drawing.Point(291, 164);
            this.BT_Pesquisar.Name = "BT_Pesquisar";
            this.BT_Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.BT_Pesquisar.TabIndex = 3;
            this.BT_Pesquisar.Text = "Pesquisar";
            this.BT_Pesquisar.UseVisualStyleBackColor = true;
            this.BT_Pesquisar.Click += new System.EventHandler(this.BT_Pesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "País";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "População";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Área Total (Km)";
            // 
            // TX_Cod
            // 
            this.TX_Cod.Location = new System.Drawing.Point(6, 28);
            this.TX_Cod.Name = "TX_Cod";
            this.TX_Cod.Size = new System.Drawing.Size(100, 20);
            this.TX_Cod.TabIndex = 8;
            // 
            // TX_Pais
            // 
            this.TX_Pais.Location = new System.Drawing.Point(125, 28);
            this.TX_Pais.Name = "TX_Pais";
            this.TX_Pais.Size = new System.Drawing.Size(240, 20);
            this.TX_Pais.TabIndex = 9;
            // 
            // TX_Populacao
            // 
            this.TX_Populacao.Location = new System.Drawing.Point(6, 77);
            this.TX_Populacao.Name = "TX_Populacao";
            this.TX_Populacao.Size = new System.Drawing.Size(100, 20);
            this.TX_Populacao.TabIndex = 10;
            // 
            // TX_Area
            // 
            this.TX_Area.Location = new System.Drawing.Point(125, 77);
            this.TX_Area.Name = "TX_Area";
            this.TX_Area.Size = new System.Drawing.Size(100, 20);
            this.TX_Area.TabIndex = 11;
            // 
            // BT_Listar
            // 
            this.BT_Listar.Location = new System.Drawing.Point(372, 165);
            this.BT_Listar.Name = "BT_Listar";
            this.BT_Listar.Size = new System.Drawing.Size(75, 23);
            this.BT_Listar.TabIndex = 13;
            this.BT_Listar.Text = "Listar";
            this.BT_Listar.UseVisualStyleBackColor = true;
            this.BT_Listar.Click += new System.EventHandler(this.BT_Listar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TX_Area);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TX_Populacao);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TX_Pais);
            this.panel1.Controls.Add(this.TX_Cod);
            this.panel1.Location = new System.Drawing.Point(48, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 115);
            this.panel1.TabIndex = 14;
            // 
            // DG_Lista
            // 
            this.DG_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Lista.Location = new System.Drawing.Point(48, 203);
            this.DG_Lista.Name = "DG_Lista";
            this.DG_Lista.Size = new System.Drawing.Size(399, 176);
            this.DG_Lista.TabIndex = 15;
            // 
            // F_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 432);
            this.Controls.Add(this.DG_Lista);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BT_Listar);
            this.Controls.Add(this.BT_Pesquisar);
            this.Controls.Add(this.BT_REMOVE);
            this.Controls.Add(this.BT_Edit);
            this.Controls.Add(this.BT_ADD);
            this.Name = "F_Cadastro";
            this.Text = "Cadastro Países";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_ADD;
        private System.Windows.Forms.Button BT_Edit;
        private System.Windows.Forms.Button BT_REMOVE;
        private System.Windows.Forms.Button BT_Pesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TX_Cod;
        private System.Windows.Forms.TextBox TX_Pais;
        private System.Windows.Forms.TextBox TX_Populacao;
        private System.Windows.Forms.TextBox TX_Area;
        private System.Windows.Forms.Button BT_Listar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DG_Lista;
    }
}