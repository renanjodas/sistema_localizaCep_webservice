namespace buscarCep
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtCep = new System.Windows.Forms.TextBox();
			this.btnBuscaCep = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtCep
			// 
			this.txtCep.Location = new System.Drawing.Point(86, 71);
			this.txtCep.Name = "txtCep";
			this.txtCep.Size = new System.Drawing.Size(100, 20);
			this.txtCep.TabIndex = 0;
			// 
			// btnBuscaCep
			// 
			this.btnBuscaCep.Location = new System.Drawing.Point(101, 122);
			this.btnBuscaCep.Name = "btnBuscaCep";
			this.btnBuscaCep.Size = new System.Drawing.Size(75, 23);
			this.btnBuscaCep.TabIndex = 1;
			this.btnBuscaCep.Text = "Buscar CEP";
			this.btnBuscaCep.UseVisualStyleBackColor = true;
			this.btnBuscaCep.Click += new System.EventHandler(this.btnBuscaCep_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 230);
			this.Controls.Add(this.btnBuscaCep);
			this.Controls.Add(this.txtCep);
			this.Name = "Form1";
			this.Text = "Exemplo WebService CEP";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtCep;
		private System.Windows.Forms.Button btnBuscaCep;
	}
}

