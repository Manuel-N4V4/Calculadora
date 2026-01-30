namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operacion;

        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMultiplicacion obj3 = new Clases.ClsMultiplicacion();
        Clases.ClsDivision obj4 = new Clases.ClsDivision();

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "7";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "4";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "1";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "0";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "8";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "5";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "9";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "6";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "3";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            Pantalla.Text += ".";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            operacion = "Raiz";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Pantalla.Text);

            double Sum;
            double Res;
            double Mul;
            double Div;

            switch(operacion)
            {
                case "+":
                    Sum = obj.Sumar((primero), (segundo));
                    Pantalla.Text = Sum.ToString();
                    break;
                case "-":
                    Res = obj2.Resta((primero),(segundo));
                    Pantalla.Text = Res.ToString();
                    break;
                case "*":
                    Mul = obj3.Multiplicacion((primero), (segundo));
                    Pantalla.Text = Mul.ToString();
                    break;
                case "/":
                    Div = obj4.Division((primero), (segundo));
                    Pantalla.Text = Div.ToString();
                    break;
            }

            /* SWITCH ANTIGUO DE LA CALCULADORA ANTIGUA
            switch(operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primero - segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = primero * segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = primero / segundo;
                    Pantalla.Text = resultado.ToString();
                    break;
                case "Raiz":
                    resultado = Math.Sqrt(primero);
                    Pantalla.Text += resultado.ToString();
                    break;
            }
            */
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "2";
        }
    }
}
