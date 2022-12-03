namespace HexGuess {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private int randomNumber() {
            Random rnd = new Random();
            return rnd.Next(0, 255);
        }

        private String randomRGB() {
            int rnd1 = randomNumber();
            int rnd2 = randomNumber();
            int rnd3 = randomNumber();

            return rnd1.ToString() + ", " + rnd2.ToString() + ", " + rnd3.ToString();
        }



        private void createHexFromRGB() {
            String rgb = randomRGB();

            char[] hex = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            char[] code;

        }
    }
}