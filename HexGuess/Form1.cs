namespace HexGuess {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            startGame();
        }

        private void startGame() {
            String hexVal1 = createHex();
            String hexVal2 = createHex();
            String hexVal3 = createHex();
            String rgbVal1 = createRgbFromHex(hexVal1);
            String rgbVal2 = createRgbFromHex(hexVal2);
            String rgbVal3 = createRgbFromHex(hexVal3);

            hex1.Text = hexVal1;
            hex2.Text = hexVal2;
            hex3.Text = hexVal3;
            rgb1.Text = rgbVal1;
            rgb2.Text = rgbVal2;
            rgb3.Text = rgbVal3;
        }


        private String createRgbFromHex(String hex) {
            String val1 = hex.Substring(0,2);
            String val2 = hex.Substring(2,2);
            String val3 = hex.Substring(4,2);

            int rgb1 = Convert.ToInt32(val1, 16);
            int rgb2 = Convert.ToInt32(val2, 16);
            int rgb3 = Convert.ToInt32(val3, 16);

            return String.Format("{0:000}", rgb1) + ", "
                + String.Format("{0:000}", rgb2) + ", "
                + String.Format("{0:000}", rgb3);
        }

        private String createHex() {
            Random rnd = new Random();
            String test = "";
            char[] hex = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            for (int i = 0; i < 6; i++) {
                test += hex[rnd.Next(0, 15)];
            }

            return test;
        }
    }
}