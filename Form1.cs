namespace _3
{
    public partial class Form1 : Form
    {
        float f_num, Total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Botón Añadir
            listBox1.Items.Add(textBox1.Text);
            // Aquí es donde pasamos el parámetro
            f_num = float.Parse(textBox1.Text);
            Total += f_num; //  sumar f_num a Total
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Borra todos los elementos en el ListBox
            textBox2.Text = ""; // Borra el contenido del TextBox
            Total = 0; // Reinicia el valor de Total a 0
        }
    }
}