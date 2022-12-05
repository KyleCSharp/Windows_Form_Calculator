namespace New_Win_Form_Calc
{
    public partial class Form1 : Form

    {
        Double resultVaule = 0;
        String operationPerfomed = "";
        bool isOperationClicked = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Button_Click(object sender, EventArgs e)
        {

            if (textBoxResult.Text == "0" || isOperationClicked || textBoxResult.Text == "NaN")
            {
                textBoxResult.Clear();
            }
            isOperationClicked = false;
            Button button = (Button)sender;
            textBoxResult.Text = textBoxResult.Text + button.Text;
        }
        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerfomed = button.Text;
            resultVaule = Double.Parse(textBoxResult.Text);
            labelBuffering.Text = resultVaule + " " + operationPerfomed;
            isOperationClicked = true;

        }
        private void ButtonCE_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            labelBuffering.Text = "0";
        }
        private void ButtonC_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            //resultVaule = 0;
        }
        private void ButtonEqual_Click(object sender, EventArgs e)
        {

            switch (operationPerfomed)
            {
                case "+":
                    textBoxResult.Text = (resultVaule + double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (resultVaule - double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (resultVaule / double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "X":
                    textBoxResult.Text = (resultVaule * double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;


            }

        }
    }
}