namespace LactecProjetoClientes
{
    partial class Menu
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
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.ButtomListarClientes = new System.Windows.Forms.Button();
            this.ButtomInserirClientes = new System.Windows.Forms.Button();
            this.ButtomBuscarClientes = new System.Windows.Forms.Button();
            this.ButtomSair = new System.Windows.Forms.Button();
            this.ButtomExcluirClientes = new System.Windows.Forms.Button();
            this.ButtomOrdenarClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Location = new System.Drawing.Point(93, 12);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.Size = new System.Drawing.Size(443, 400);
            this.dataGridViewMenu.TabIndex = 0;
            // 
            // ButtomListarClientes
            // 
            this.ButtomListarClientes.Location = new System.Drawing.Point(12, 12);
            this.ButtomListarClientes.Name = "ButtomListarClientes";
            this.ButtomListarClientes.Size = new System.Drawing.Size(75, 75);
            this.ButtomListarClientes.TabIndex = 1;
            this.ButtomListarClientes.Text = "Listar clientes";
            this.ButtomListarClientes.UseVisualStyleBackColor = true;
            this.ButtomListarClientes.Click += new System.EventHandler(this.ButtomListarClientes_Click);
            // 
            // ButtomInserirClientes
            // 
            this.ButtomInserirClientes.Location = new System.Drawing.Point(12, 174);
            this.ButtomInserirClientes.Name = "ButtomInserirClientes";
            this.ButtomInserirClientes.Size = new System.Drawing.Size(75, 75);
            this.ButtomInserirClientes.TabIndex = 2;
            this.ButtomInserirClientes.Text = "Inserir";
            this.ButtomInserirClientes.UseVisualStyleBackColor = true;
            this.ButtomInserirClientes.Click += new System.EventHandler(this.ButtomInserirClientes_Click);
            // 
            // ButtomBuscarClientes
            // 
            this.ButtomBuscarClientes.Location = new System.Drawing.Point(12, 255);
            this.ButtomBuscarClientes.Name = "ButtomBuscarClientes";
            this.ButtomBuscarClientes.Size = new System.Drawing.Size(75, 75);
            this.ButtomBuscarClientes.TabIndex = 3;
            this.ButtomBuscarClientes.Text = "Buscar";
            this.ButtomBuscarClientes.UseVisualStyleBackColor = true;
            this.ButtomBuscarClientes.Click += new System.EventHandler(this.ButtomBuscarClientes_Click);
            // 
            // ButtomSair
            // 
            this.ButtomSair.Location = new System.Drawing.Point(458, 418);
            this.ButtomSair.Name = "ButtomSair";
            this.ButtomSair.Size = new System.Drawing.Size(75, 23);
            this.ButtomSair.TabIndex = 4;
            this.ButtomSair.Text = "Sair";
            this.ButtomSair.UseVisualStyleBackColor = true;
            this.ButtomSair.Click += new System.EventHandler(this.ButtomSair_Click);
            // 
            // ButtomExcluirClientes
            // 
            this.ButtomExcluirClientes.Location = new System.Drawing.Point(12, 336);
            this.ButtomExcluirClientes.Name = "ButtomExcluirClientes";
            this.ButtomExcluirClientes.Size = new System.Drawing.Size(75, 75);
            this.ButtomExcluirClientes.TabIndex = 5;
            this.ButtomExcluirClientes.Text = "Excluir";
            this.ButtomExcluirClientes.UseVisualStyleBackColor = true;
            this.ButtomExcluirClientes.Click += new System.EventHandler(this.ButtonExluirClientes_Click);
            // 
            // ButtomOrdenarClientes
            // 
            this.ButtomOrdenarClientes.Location = new System.Drawing.Point(12, 93);
            this.ButtomOrdenarClientes.Name = "ButtomOrdenarClientes";
            this.ButtomOrdenarClientes.Size = new System.Drawing.Size(75, 75);
            this.ButtomOrdenarClientes.TabIndex = 6;
            this.ButtomOrdenarClientes.Text = "Listar Clientes Ordenados";
            this.ButtomOrdenarClientes.UseVisualStyleBackColor = true;
            this.ButtomOrdenarClientes.Click += new System.EventHandler(this.ButtonOrdenarClientes_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 444);
            this.Controls.Add(this.ButtomOrdenarClientes);
            this.Controls.Add(this.ButtomExcluirClientes);
            this.Controls.Add(this.ButtomSair);
            this.Controls.Add(this.ButtomBuscarClientes);
            this.Controls.Add(this.ButtomInserirClientes);
            this.Controls.Add(this.ButtomListarClientes);
            this.Controls.Add(this.dataGridViewMenu);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.Button ButtomListarClientes;
        private System.Windows.Forms.Button ButtomInserirClientes;
        private System.Windows.Forms.Button ButtomBuscarClientes;
        private System.Windows.Forms.Button ButtomSair;
        private System.Windows.Forms.Button ButtomExcluirClientes;
        private System.Windows.Forms.Button ButtomOrdenarClientes;
    }
}

