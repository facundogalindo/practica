namespace Csharp_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {

            try
            {

                string texto = "Hola: " + txt_Nombre.Text;
                txt_lbl_TextBox.Text = texto;
            }
            catch(Exception x)
            {
                MessageBox.Show("Error" + x);
            }
            
        }


    }
}
