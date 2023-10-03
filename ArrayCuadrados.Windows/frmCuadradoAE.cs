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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (cuadrado != null ) {
                txtLado.Text=cuadrado.GetLado().ToString();
            }
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
;               }
                cuadrado.SetLado(int.Parse(txtLado.Text));
                DialogResult = DialogResult.OK;
            }
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
