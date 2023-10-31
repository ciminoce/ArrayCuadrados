namespace ArrayCuadrados.Windows
{
	partial class frmCuadradoAE
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
			components = new System.ComponentModel.Container();
			label1 = new Label();
			txtLado = new TextBox();
			btnOK = new Button();
			btnCancelar = new Button();
			errorProvider1 = new ErrorProvider(components);
			label2 = new Label();
			cboColores = new ComboBox();
			gbxBordes = new GroupBox();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(26, 26);
			label1.Name = "label1";
			label1.Size = new Size(98, 15);
			label1.TabIndex = 0;
			label1.Text = "Medida del Lado:";
			// 
			// txtLado
			// 
			txtLado.Location = new Point(130, 23);
			txtLado.Name = "txtLado";
			txtLado.Size = new Size(100, 23);
			txtLado.TabIndex = 1;
			// 
			// btnOK
			// 
			btnOK.Image = Properties.Resources.ok_24px;
			btnOK.Location = new Point(39, 148);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(95, 56);
			btnOK.TabIndex = 2;
			btnOK.Text = "OK";
			btnOK.TextImageRelation = TextImageRelation.ImageAboveText;
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += btnOK_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.Image = Properties.Resources.cancel_24px;
			btnCancelar.Location = new Point(360, 148);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(95, 56);
			btnCancelar.TabIndex = 2;
			btnCancelar.Text = "Cancelar";
			btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(26, 71);
			label2.Name = "label2";
			label2.Size = new Size(81, 15);
			label2.TabIndex = 0;
			label2.Text = "Color Relleno:";
			// 
			// cboColores
			// 
			cboColores.DropDownStyle = ComboBoxStyle.DropDownList;
			cboColores.FormattingEnabled = true;
			cboColores.Location = new Point(131, 69);
			cboColores.Name = "cboColores";
			cboColores.Size = new Size(153, 23);
			cboColores.TabIndex = 3;
			// 
			// gbxBordes
			// 
			gbxBordes.Location = new Point(312, 21);
			gbxBordes.Name = "gbxBordes";
			gbxBordes.Size = new Size(179, 108);
			gbxBordes.TabIndex = 4;
			gbxBordes.TabStop = false;
			gbxBordes.Text = " Tipos de Bordes ";
			// 
			// frmCuadradoAE
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(518, 216);
			ControlBox = false;
			Controls.Add(gbxBordes);
			Controls.Add(cboColores);
			Controls.Add(btnCancelar);
			Controls.Add(btnOK);
			Controls.Add(txtLado);
			Controls.Add(label2);
			Controls.Add(label1);
			MaximumSize = new Size(534, 255);
			MinimumSize = new Size(534, 255);
			Name = "frmCuadradoAE";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmCuadradoAE";
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtLado;
		private Button btnOK;
		private Button btnCancelar;
		private ErrorProvider errorProvider1;
		private ComboBox cboColores;
		private Label label2;
		private GroupBox gbxBordes;
	}
}