namespace HexGuess {
    public partial class Form1 : Form {
        String? correct;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            startGame();
        }

        private void startGame() {
            String[] hexVal = new String[3];
            String[] rgbVal = new String[3];

            hexVal[0] = createHex();
            hexVal[1] = createHex();
            hexVal[2] = createHex();
            rgbVal[0] = createRgbFromHex(hexVal[0]);
            rgbVal[1] = createRgbFromHex(hexVal[1]);
            rgbVal[2] = createRgbFromHex(hexVal[2]);

            hex1.Text = hexVal[0];
            hex2.Text = hexVal[1];
            hex3.Text = hexVal[2];
            rgb1.Text = rgbVal[0];
            rgb2.Text = rgbVal[1];
            rgb3.Text = rgbVal[2];

            correct = chooseColour(rgbVal);
            lblOutput.Text = "";
        }

        private String chooseColour(String[] rgb) {
            // first randomly choose which one to use
            Random rnd = new Random();
            int chosen = rnd.Next(0, 2);

            String[] numbers = rgb[chosen].Split(",");

            int num1 = Convert.ToInt32(numbers[0]);
            int num2 = Convert.ToInt32(numbers[1]);
            int num3 = Convert.ToInt32(numbers[2]);


            colourBox.BackColor = Color.FromArgb(255, num1, num2, num3);

            return rgb[chosen];
        }

        // grabs two hex values starting at place
        private String getHexSubstring(String hex, int place) {
            return hex.Substring(place, 2);
        }

        private String createRgbFromHex(String hex) {
            String val1 = getHexSubstring(hex, 0);
            String val2 = getHexSubstring(hex, 2);
            String val3 = getHexSubstring(hex, 4);

            int rgb1 = Convert.ToInt32(val1, 16);
            int rgb2 = Convert.ToInt32(val2, 16);
            int rgb3 = Convert.ToInt32(val3, 16);

            return String.Format("{0:000}", rgb1) + ","
                + String.Format("{0:000}", rgb2) + ","
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

        private void choose1_Click(object sender, EventArgs e) {
            if (rgb1.Text.Equals(correct)) {
                lblOutput.Text = "Correct!";
            } else {
                lblOutput.Text = "Incorrect, try again!";
            }
        }

        private void choose2_Click(object sender, EventArgs e) {
            if (rgb2.Text.Equals(correct)) {
                lblOutput.Text = "Correct!";
            } else {
                lblOutput.Text = "Incorrect, try again!";
            }
        }

        private void choose3_Click(object sender, EventArgs e) {
            if (rgb3.Text.Equals(correct)) {
                lblOutput.Text = "Correct!";
            } else {
                lblOutput.Text = "Incorrect, try again!";
            }
        }

        private void playAgainButton_Click(object sender, EventArgs e) {
            startGame();
        }
    }
}