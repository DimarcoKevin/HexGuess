namespace HexGuess {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            startGame();
        }

        private void startGame() {
            String num1 = randomRGB();
            String num2 = randomRGB();
            String num3 = randomRGB();

            rgb1.Text = num1;
            rgb2.Text = num2;   
            rgb3.Text = num3;
        }

        private int randomNumber() {
            Random rnd = new Random();
            return rnd.Next(0, 255);
        }

        private String randomRGB() {
            return String.Format("{0:000}", randomNumber()) + ", "
                +  String.Format("{0:000}", randomNumber()) + ", "
                +  String.Format("{0:000}", randomNumber());
        }



        private void createHexFromRGB() {
            String rgb = randomRGB();

            char[] hex = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            char[] code;

        }
    }
}