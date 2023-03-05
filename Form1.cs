namespace ejemploclases_proj_2_parcial2
{
    public partial class Form1 : Form
    {
                       //nombre de la clase
        calculo_aumento clasecal = new calculo_aumento(); // intacia (intaciamos la clase dentro del formulario). declaracion de la clase
        mantenimiento mant = new mantenimiento(); //para llamar la clase

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 18; i < 80; i++)
            {
                cbedad.Items.Add(i);
            }

            txttotalaumento.Enabled = false; 
            btnagregar.Enabled = false;
            btnmodificar.Enabled = false;

        }

        private void btncalcularuamento_Click(object sender, EventArgs e)
        {
            clasecal.Fecha = dtpinicio.Value.Year; // Fecha es la variable public de la clase claculo aumento

            clasecal.Pago = Convert.ToDouble(txtsalario.Text);
                                                  //los parametros del metodo *calculo* (año)(salario) se completan con la informacion que le pedimos antes, o que se llena antes
            txttotalaumento.Text = clasecal.calculo(clasecal.Fecha, clasecal.Pago).ToString();

            clasecal.habilitar_botones(this); //this - el formulario completo
                                              // para habilitar lso botnones despues de calcular
            
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            mant.FechaAumento = dtpaumento.Value;

            int fila = dgvdetalle.Rows.Add();

            mant.insertar(txtnombre.Text, Convert.ToInt32(cbedad.SelectedItem), dtpinicio.Value, Convert.ToDouble(txtsalario.Text), Convert.ToDouble(txttotalaumento.Text), dgvdetalle, fila);

        }














    }
}