using ArrayCuadrados.Datos;
using ArrayCuadrados.Entidades;

namespace ArrayCuadrados.Windows
{
    public partial class frmPrincipal : Form
    {
        private RepositorioDeCuadrados repo;
        private List<Cuadrado> lista;
        public frmPrincipal()
        {
            InitializeComponent();
            repo = new RepositorioDeCuadrados();
            txtCantidad.Text = repo.GetCantidad().ToString();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmCuadradoAE frm = new frmCuadradoAE() { Text = "Agregar Cuadrado" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            Cuadrado cuadrado = frm.GetCuadrado();
            repo.Agregar(cuadrado);
            txtCantidad.Text = repo.GetCantidad().ToString();

            DataGridViewRow r = ConstruirFila();
            SetearFila(r, cuadrado);
            AgregarFila(r);

            MessageBox.Show("Registro agregado", "Mensaje", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Cuadrado cuadrado)
        {
            r.Cells[colLado.Index].Value = cuadrado.GetLado();
            r.Cells[colSuperficie.Index].Value = cuadrado.GetSuperficie();
            r.Cells[colPerimetro.Index].Value = cuadrado.GetPerimetro();

            r.Tag = cuadrado;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("¿Desea dar de baja el cuadrado?",
                "Confirmar Baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            var filaSeleccionada = dgvDatos.SelectedRows[0];
            Cuadrado cuadrado = filaSeleccionada.Tag as Cuadrado;
            repo.Borrar(cuadrado);
            txtCantidad.Text = repo.GetCantidad().ToString();

            QuitarFila(filaSeleccionada);
            MessageBox.Show("Registro borrado", "Mensaje", MessageBoxButtons.OK,
    MessageBoxIcon.Information);

        }

        private void QuitarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Remove(r);
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var filaSeleccionada = dgvDatos.SelectedRows[0];
           
            Cuadrado cuadrado = (Cuadrado)filaSeleccionada.Tag;
            int ladoAnterior = cuadrado.GetLado();
            frmCuadradoAE frm = new frmCuadradoAE() { Text = "Editar Cuadrado" };
            frm.SetCuadrado(cuadrado);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            cuadrado = frm.GetCuadrado();
            repo.Editar(ladoAnterior, cuadrado);
            SetearFila(filaSeleccionada, cuadrado);
            MessageBox.Show("Registro editado", "Mensaje", MessageBoxButtons.OK,
MessageBoxIcon.Information);

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (repo.GetCantidad()>0)
            {
                lista = repo.GetLista();
                MostrarDatosEnGrilla();
            }
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var cuadrado in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, cuadrado);
                AgregarFila(r);
            }
        }
    }
}
