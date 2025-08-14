namespace WinFormsApp1
{
    public partial class Form1 : Form

    {
        private double valor1;
        private double valor2;


        private double resultado;

        private int operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = 1;
            valor1 = Convert.ToDouble(campoTexto.Text);
            campoTexto.Text = " ";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = 2;
            valor1 = Convert.ToDouble(campoTexto.Text);
            campoTexto.Text = " ";
        }


        private void btnDivision_Click(object sender, EventArgs e)
        {
            operacion = 3;
            valor1 = Convert.ToDouble(campoTexto.Text);
            campoTexto.Text = " ";
        }

       

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operacion = 4;
            valor1 = Convert.ToDouble(campoTexto.Text);
            campoTexto.Text = " ";
        }

       
        private void btnIgual_Click(object sender, EventArgs e)
        {
            // igual

            valor2 = Convert.ToDouble(campoTexto.Text);

            switch (operacion)
            {
                case 1: resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                       resultado = valor1 / valor2;
                    break;
                case 4:
                    resultado = valor1 * valor2;
                    break;
            }
            

            campoTexto.Text = resultado.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            // cero

            campoTexto.Text = campoTexto.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // uno
            campoTexto.Text = campoTexto.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //dos
            campoTexto.Text = campoTexto.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // tres
            campoTexto.Text = campoTexto.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            // cuatro
            campoTexto.Text = campoTexto.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            // cinco
            campoTexto.Text = campoTexto.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            // seis
            campoTexto.Text = campoTexto.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            // 7
            campoTexto.Text = campoTexto.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            // 8
            campoTexto.Text = campoTexto.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //9
            campoTexto.Text = campoTexto.Text + "9";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            campoTexto.Text = " ";
        }

      
    }
}
