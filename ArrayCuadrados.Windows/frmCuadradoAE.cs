using ArrayCuadrados.Entidades;

namespace ArrayCuadrados.Windows
{
	public partial class frmCuadradoAE : Form
	{
		public frmCuadradoAE()
		{
			InitializeComponent();
		}
		private Cuadrado cuadrado;
		List<TipoDeBorde> listaBordes = Enum.GetValues(typeof(TipoDeBorde))
			.Cast<TipoDeBorde>()
			.ToList();

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			CargarDatosComboColorRelleno();
			CrearBotonesOpcionBordes();
			if (cuadrado != null)
			{
				txtLado.Text = cuadrado.GetLado().ToString();
				cboColores.SelectedItem = cuadrado.ColorRelleno;
				SelectRadioButton(cuadrado.TipoDeBorde);
			}
		}

		private void SelectRadioButton(TipoDeBorde tipoDeBorde)
		{
			var key = $"rbt{tipoDeBorde.ToString()}";
			var rb =(RadioButton) gbxBordes.Controls.Find(key, true)[0];
			rb.Checked = true;
		}

		private void CrearBotonesOpcionBordes()
		{
			int x = 13;
			int y = 21;
			bool check = true;
			foreach (var itemBorde in listaBordes)
			{
				RadioButton rb = new RadioButton
				{
					Name=$"rbt{itemBorde.ToString()}",
					Text = itemBorde.ToString(),
					Location = new Point(x, y),
					Checked = check
				};
				gbxBordes.Controls.Add(rb);
				y += 20;
				check = false;
			}
		}

		private void CargarDatosComboColorRelleno()
		{
			var listaColores = Enum.GetValues(typeof(ColorRelleno)).Cast<ColorRelleno>().ToList();
			cboColores.DataSource = listaColores;
			cboColores.SelectedIndex = 0;
		}

		public Cuadrado GetCuadrado()
		{
			return cuadrado;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (ValidarDatos())
			{
				if (cuadrado == null)
				{
					cuadrado = new Cuadrado()
;
				}
				cuadrado.SetLado(int.Parse(txtLado.Text));
				cuadrado.ColorRelleno =(ColorRelleno) cboColores.SelectedItem;
				cuadrado.TipoDeBorde = ObtenerTipoDeBorde();
				DialogResult = DialogResult.OK;
			}
		}

		private TipoDeBorde ObtenerTipoDeBorde()
		{
			TipoDeBorde tipo = 0;
			foreach (var itemBorde in listaBordes)
			{
				var key = $"rbt{itemBorde.ToString()}";
				var rb = (RadioButton)gbxBordes.Controls.Find(key, true)[0];
				if (rb.Checked)
				{
					tipo = itemBorde;
					break;
				}
			}
			return tipo;
		}

		private bool ValidarDatos()
		{
			bool valido = true;
			errorProvider1.Clear();
			if (!int.TryParse(txtLado.Text, out int lado))
			{
				valido = false;
				errorProvider1.SetError(txtLado, "Número mal ingresado");

			}
			else if (lado <= 0)
			{
				valido = false;
				errorProvider1.SetError(txtLado, "Valor del lado no válido");
			}
			return valido;
		}

		public void SetCuadrado(Cuadrado? cuadrado)
		{
			this.cuadrado = cuadrado;
		}
	}
}
