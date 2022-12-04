namespace HexGuess {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.colourBox = new System.Windows.Forms.PictureBox();
            this.hex1 = new System.Windows.Forms.Label();
            this.hex2 = new System.Windows.Forms.Label();
            this.hex3 = new System.Windows.Forms.Label();
            this.rgb1 = new System.Windows.Forms.Label();
            this.rgb2 = new System.Windows.Forms.Label();
            this.rgb3 = new System.Windows.Forms.Label();
            this.choose1 = new System.Windows.Forms.Button();
            this.choose2 = new System.Windows.Forms.Button();
            this.choose3 = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblHex = new System.Windows.Forms.Label();
            this.lblRgb = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.colourBox)).BeginInit();
            this.SuspendLayout();
            // 
            // colourBox
            // 
            this.colourBox.Location = new System.Drawing.Point(269, 12);
            this.colourBox.Name = "colourBox";
            this.colourBox.Size = new System.Drawing.Size(239, 170);
            this.colourBox.TabIndex = 0;
            this.colourBox.TabStop = false;
            // 
            // hex1
            // 
            this.hex1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hex1.Location = new System.Drawing.Point(161, 221);
            this.hex1.Name = "hex1";
            this.hex1.Size = new System.Drawing.Size(100, 19);
            this.hex1.TabIndex = 1;
            this.hex1.Text = "label1";
            this.hex1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hex2
            // 
            this.hex2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hex2.Location = new System.Drawing.Point(338, 221);
            this.hex2.Name = "hex2";
            this.hex2.Size = new System.Drawing.Size(100, 19);
            this.hex2.TabIndex = 2;
            this.hex2.Text = "label2";
            this.hex2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hex3
            // 
            this.hex3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hex3.Location = new System.Drawing.Point(511, 221);
            this.hex3.Name = "hex3";
            this.hex3.Size = new System.Drawing.Size(100, 19);
            this.hex3.TabIndex = 3;
            this.hex3.Text = "label3";
            this.hex3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rgb1
            // 
            this.rgb1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgb1.Location = new System.Drawing.Point(141, 259);
            this.rgb1.Name = "rgb1";
            this.rgb1.Size = new System.Drawing.Size(141, 19);
            this.rgb1.TabIndex = 4;
            this.rgb1.Text = "label4";
            this.rgb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rgb2
            // 
            this.rgb2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgb2.Location = new System.Drawing.Point(318, 259);
            this.rgb2.Name = "rgb2";
            this.rgb2.Size = new System.Drawing.Size(141, 19);
            this.rgb2.TabIndex = 5;
            this.rgb2.Text = "label5";
            this.rgb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rgb3
            // 
            this.rgb3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgb3.Location = new System.Drawing.Point(491, 259);
            this.rgb3.Name = "rgb3";
            this.rgb3.Size = new System.Drawing.Size(141, 19);
            this.rgb3.TabIndex = 6;
            this.rgb3.Text = "label6";
            this.rgb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choose1
            // 
            this.choose1.Location = new System.Drawing.Point(174, 295);
            this.choose1.Name = "choose1";
            this.choose1.Size = new System.Drawing.Size(75, 23);
            this.choose1.TabIndex = 7;
            this.choose1.Text = "Choose";
            this.choose1.UseVisualStyleBackColor = true;
            this.choose1.Click += new System.EventHandler(this.choose1_Click);
            // 
            // choose2
            // 
            this.choose2.Location = new System.Drawing.Point(351, 295);
            this.choose2.Name = "choose2";
            this.choose2.Size = new System.Drawing.Size(75, 23);
            this.choose2.TabIndex = 8;
            this.choose2.Text = "Choose";
            this.choose2.UseVisualStyleBackColor = true;
            this.choose2.Click += new System.EventHandler(this.choose2_Click);
            // 
            // choose3
            // 
            this.choose3.Location = new System.Drawing.Point(524, 295);
            this.choose3.Name = "choose3";
            this.choose3.Size = new System.Drawing.Size(75, 23);
            this.choose3.TabIndex = 9;
            this.choose3.Text = "Choose";
            this.choose3.UseVisualStyleBackColor = true;
            this.choose3.Click += new System.EventHandler(this.choose3_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.Location = new System.Drawing.Point(78, 357);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(620, 19);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.Text = "label7";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHex.Location = new System.Drawing.Point(33, 221);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(77, 19);
            this.lblHex.TabIndex = 11;
            this.lblHex.Text = "Hex Code";
            // 
            // lblRgb
            // 
            this.lblRgb.AutoSize = true;
            this.lblRgb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRgb.Location = new System.Drawing.Point(30, 259);
            this.lblRgb.Name = "lblRgb";
            this.lblRgb.Size = new System.Drawing.Size(80, 19);
            this.lblRgb.TabIndex = 12;
            this.lblRgb.Text = "RGB Code";
            // 
            // playAgainButton
            // 
            this.playAgainButton.Location = new System.Drawing.Point(351, 410);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(75, 23);
            this.playAgainButton.TabIndex = 13;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.lblRgb);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.choose3);
            this.Controls.Add(this.choose2);
            this.Controls.Add(this.choose1);
            this.Controls.Add(this.rgb3);
            this.Controls.Add(this.rgb2);
            this.Controls.Add(this.rgb1);
            this.Controls.Add(this.hex3);
            this.Controls.Add(this.hex2);
            this.Controls.Add(this.hex1);
            this.Controls.Add(this.colourBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colourBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox colourBox;
        private Label hex1;
        private Label hex2;
        private Label hex3;
        private Label rgb1;
        private Label rgb2;
        private Label rgb3;
        private Button choose1;
        private Button choose2;
        private Button choose3;
        private Label lblOutput;
        private Label lblHex;
        private Label lblRgb;
        private Button playAgainButton;
    }
}