namespace ProjetoAtendimento
{
    partial class Form1
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
            this.listsenha = new System.Windows.Forms.ListBox();
            this.btn_gerar = new System.Windows.Forms.Button();
            this.btn_listarsenhas = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_listaratendimentos = new System.Windows.Forms.Button();
            this.btn_chamar = new System.Windows.Forms.Button();
            this.listchamar = new System.Windows.Forms.ListBox();
            this.txtchamar = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listsenha
            // 
            this.listsenha.FormattingEnabled = true;
            this.listsenha.Location = new System.Drawing.Point(21, 100);
            this.listsenha.Margin = new System.Windows.Forms.Padding(2);
            this.listsenha.Name = "listsenha";
            this.listsenha.Size = new System.Drawing.Size(190, 95);
            this.listsenha.TabIndex = 0;
            // 
            // btn_gerar
            //                         
            this.btn_gerar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gerar.Location = new System.Drawing.Point(125, 217);
            this.btn_gerar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(86, 45);
            this.btn_gerar.TabIndex = 1;
            this.btn_gerar.Text = "Gerar Senha";           
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // btn_listarsenhas
            //                        
            this.btn_listarsenhas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listarsenhas.Location = new System.Drawing.Point(21, 215);
            this.btn_listarsenhas.Margin = new System.Windows.Forms.Padding(2);
            this.btn_listarsenhas.Name = "btn_listarsenhas";
            this.btn_listarsenhas.Size = new System.Drawing.Size(85, 47);
            this.btn_listarsenhas.TabIndex = 2;
            this.btn_listarsenhas.Text = "Listar Senhas";           
            this.btn_listarsenhas.Click += new System.EventHandler(this.btn_listarsenhas_Click);
            // 
            // btn_Adicionar
            //                         
            this.btn_Adicionar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));            
            this.btn_Adicionar.Location = new System.Drawing.Point(246, 153);
            this.btn_Adicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(104, 39);
            this.btn_Adicionar.TabIndex = 3;
            this.btn_Adicionar.Text = "Adicionar";           
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_listaratendimentos
            //                         
            this.btn_listaratendimentos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));           
            this.btn_listaratendimentos.Location = new System.Drawing.Point(412, 215);
            this.btn_listaratendimentos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_listaratendimentos.Name = "btn_listaratendimentos";
            this.btn_listaratendimentos.Size = new System.Drawing.Size(153, 47);
            this.btn_listaratendimentos.TabIndex = 4;
            this.btn_listaratendimentos.Text = "Listar Atendimentos";           
            this.btn_listaratendimentos.Click += new System.EventHandler(this.btn_listaratendimentos_Click);
            // 
            // btn_chamar
            //               
            this.btn_chamar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));           
            this.btn_chamar.Location = new System.Drawing.Point(414, 15);
            this.btn_chamar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_chamar.Name = "btn_chamar";
            this.btn_chamar.Size = new System.Drawing.Size(106, 39);
            this.btn_chamar.TabIndex = 5;
            this.btn_chamar.Text = "Chamar";          
            this.btn_chamar.Click += new System.EventHandler(this.btn_chamar_Click);
            // 
            // listchamar
            // 
            this.listchamar.FormattingEnabled = true;
            this.listchamar.Location = new System.Drawing.Point(376, 98);
            this.listchamar.Margin = new System.Windows.Forms.Padding(2);
            this.listchamar.Name = "listchamar";
            this.listchamar.Size = new System.Drawing.Size(281, 95);
            this.listchamar.TabIndex = 6;
            // 
            // txtchamar
            // 
            this.txtchamar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchamar.Location = new System.Drawing.Point(62, 23);
            this.txtchamar.Name = "txtchamar";
            this.txtchamar.Size = new System.Drawing.Size(332, 26);
            this.txtchamar.TabIndex = 7;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(34, 42);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(22, 24);
            this.lblQtd.TabIndex = 8;
            this.lblQtd.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Guichês existentes";
            // 
            // panel1
            //            
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblQtd);
            this.panel1.Location = new System.Drawing.Point(252, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 85);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Guichê";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;           
            this.ClientSize = new System.Drawing.Size(686, 279);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtchamar);
            this.Controls.Add(this.listchamar);
            this.Controls.Add(this.btn_chamar);
            this.Controls.Add(this.btn_listaratendimentos);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.btn_listarsenhas);
            this.Controls.Add(this.btn_gerar);
            this.Controls.Add(this.listsenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listsenha;
        private System.Windows.Forms.Button btn_gerar;
        private System.Windows.Forms.Button btn_listarsenhas;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_listaratendimentos;
        private System.Windows.Forms.Button btn_chamar;
        private System.Windows.Forms.ListBox listchamar;
        private System.Windows.Forms.TextBox txtchamar;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

