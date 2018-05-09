using System;

namespace Random_Walker
{
    partial class RandomWalkerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.walkerPictureBox = new System.Windows.Forms.PictureBox();
            this.checkBoxTopSteps = new System.Windows.Forms.CheckBox();
            this.numericTopSteps = new System.Windows.Forms.NumericUpDown();
            this.numericGridSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericCharaSize = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCenterChara = new System.Windows.Forms.Button();
            this.buttonChooseCharaColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBackColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericSpeed = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxGridInvisible = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonColorMax = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonColorMin = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.picMinColor = new System.Windows.Forms.PictureBox();
            this.picMaxColor = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericColorGranularity = new System.Windows.Forms.NumericUpDown();
            this.buttonInverse = new System.Windows.Forms.Button();
            this.checkBoxInverted = new System.Windows.Forms.CheckBox();
            this.buttonClearAndStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.walkerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTopSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGridSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCharaSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpeed)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColorGranularity)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(13, 13);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Resume";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // walkerPictureBox
            // 
            this.walkerPictureBox.Location = new System.Drawing.Point(17, 159);
            this.walkerPictureBox.Name = "walkerPictureBox";
            this.walkerPictureBox.Size = new System.Drawing.Size(623, 623);
            this.walkerPictureBox.TabIndex = 1;
            this.walkerPictureBox.TabStop = false;
            // 
            // checkBoxTopSteps
            // 
            this.checkBoxTopSteps.AutoSize = true;
            this.checkBoxTopSteps.Location = new System.Drawing.Point(14, 48);
            this.checkBoxTopSteps.Name = "checkBoxTopSteps";
            this.checkBoxTopSteps.Size = new System.Drawing.Size(75, 17);
            this.checkBoxTopSteps.TabIndex = 2;
            this.checkBoxTopSteps.Text = "Top Steps";
            this.checkBoxTopSteps.UseVisualStyleBackColor = true;
            this.checkBoxTopSteps.CheckedChanged += new System.EventHandler(this.checkBoxTopSteps_CheckedChanged);
            // 
            // numericTopSteps
            // 
            this.numericTopSteps.Location = new System.Drawing.Point(96, 48);
            this.numericTopSteps.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericTopSteps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTopSteps.Name = "numericTopSteps";
            this.numericTopSteps.Size = new System.Drawing.Size(60, 20);
            this.numericTopSteps.TabIndex = 3;
            this.numericTopSteps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTopSteps.ValueChanged += new System.EventHandler(this.numericTopSteps_ValueChanged);
            // 
            // numericGridSize
            // 
            this.numericGridSize.Location = new System.Drawing.Point(51, 23);
            this.numericGridSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericGridSize.Name = "numericGridSize";
            this.numericGridSize.Size = new System.Drawing.Size(60, 20);
            this.numericGridSize.TabIndex = 4;
            this.numericGridSize.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericGridSize.ValueChanged += new System.EventHandler(this.numericGridSize_ValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Size";
            // 
            // numericCharaSize
            // 
            this.numericCharaSize.Location = new System.Drawing.Point(51, 23);
            this.numericCharaSize.Name = "numericCharaSize";
            this.numericCharaSize.Size = new System.Drawing.Size(60, 20);
            this.numericCharaSize.TabIndex = 6;
            this.numericCharaSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericCharaSize.ValueChanged += new System.EventHandler(this.numericCharaSize_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCenterChara);
            this.groupBox1.Controls.Add(this.buttonChooseCharaColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericCharaSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(194, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 114);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character";
            // 
            // buttonCenterChara
            // 
            this.buttonCenterChara.Location = new System.Drawing.Point(12, 78);
            this.buttonCenterChara.Name = "buttonCenterChara";
            this.buttonCenterChara.Size = new System.Drawing.Size(99, 23);
            this.buttonCenterChara.TabIndex = 10;
            this.buttonCenterChara.Text = "Center";
            this.buttonCenterChara.UseVisualStyleBackColor = true;
            this.buttonCenterChara.Click += new System.EventHandler(this.buttonCenterChara_Click);
            // 
            // buttonChooseCharaColor
            // 
            this.buttonChooseCharaColor.Location = new System.Drawing.Point(51, 49);
            this.buttonChooseCharaColor.Name = "buttonChooseCharaColor";
            this.buttonChooseCharaColor.Size = new System.Drawing.Size(60, 23);
            this.buttonChooseCharaColor.TabIndex = 9;
            this.buttonChooseCharaColor.Text = "Choose";
            this.buttonChooseCharaColor.UseVisualStyleBackColor = true;
            this.buttonChooseCharaColor.Click += new System.EventHandler(this.buttonChooseCharaColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Color";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxGridInvisible);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericGridSize);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(329, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 114);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grid";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Choose";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Size";
            // 
            // buttonBackColor
            // 
            this.buttonBackColor.Location = new System.Drawing.Point(96, 74);
            this.buttonBackColor.Name = "buttonBackColor";
            this.buttonBackColor.Size = new System.Drawing.Size(60, 23);
            this.buttonBackColor.TabIndex = 12;
            this.buttonBackColor.Text = "Choose";
            this.buttonBackColor.UseVisualStyleBackColor = true;
            this.buttonBackColor.Click += new System.EventHandler(this.buttonBackColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Backcolor";
            // 
            // numericSpeed
            // 
            this.numericSpeed.Location = new System.Drawing.Point(96, 103);
            this.numericSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSpeed.Name = "numericSpeed";
            this.numericSpeed.Size = new System.Drawing.Size(60, 20);
            this.numericSpeed.TabIndex = 14;
            this.numericSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericSpeed.ValueChanged += new System.EventHandler(this.numericSpeed_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Speed (ms)";
            // 
            // checkBoxGridInvisible
            // 
            this.checkBoxGridInvisible.AutoSize = true;
            this.checkBoxGridInvisible.Location = new System.Drawing.Point(12, 82);
            this.checkBoxGridInvisible.Name = "checkBoxGridInvisible";
            this.checkBoxGridInvisible.Size = new System.Drawing.Size(64, 17);
            this.checkBoxGridInvisible.TabIndex = 16;
            this.checkBoxGridInvisible.Text = "Invisible";
            this.checkBoxGridInvisible.UseVisualStyleBackColor = true;
            this.checkBoxGridInvisible.CheckedChanged += new System.EventHandler(this.checkBoxGridInvisible_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxInverted);
            this.groupBox3.Controls.Add(this.buttonInverse);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.picMaxColor);
            this.groupBox3.Controls.Add(this.numericColorGranularity);
            this.groupBox3.Controls.Add(this.picMinColor);
            this.groupBox3.Controls.Add(this.buttonColorMin);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.buttonColorMax);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(464, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 133);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cell Colors";
            // 
            // buttonColorMax
            // 
            this.buttonColorMax.Location = new System.Drawing.Point(51, 49);
            this.buttonColorMax.Name = "buttonColorMax";
            this.buttonColorMax.Size = new System.Drawing.Size(81, 23);
            this.buttonColorMax.TabIndex = 9;
            this.buttonColorMax.Text = "Choose";
            this.buttonColorMax.UseVisualStyleBackColor = true;
            this.buttonColorMax.Click += new System.EventHandler(this.buttonColorMax_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Max";
            // 
            // buttonColorMin
            // 
            this.buttonColorMin.Location = new System.Drawing.Point(51, 22);
            this.buttonColorMin.Name = "buttonColorMin";
            this.buttonColorMin.Size = new System.Drawing.Size(81, 23);
            this.buttonColorMin.TabIndex = 18;
            this.buttonColorMin.Text = "Choose";
            this.buttonColorMin.UseVisualStyleBackColor = true;
            this.buttonColorMin.Click += new System.EventHandler(this.buttonColorMin_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Min";
            // 
            // picMinColor
            // 
            this.picMinColor.BackColor = System.Drawing.Color.Tomato;
            this.picMinColor.Location = new System.Drawing.Point(138, 24);
            this.picMinColor.Name = "picMinColor";
            this.picMinColor.Size = new System.Drawing.Size(20, 21);
            this.picMinColor.TabIndex = 19;
            this.picMinColor.TabStop = false;
            // 
            // picMaxColor
            // 
            this.picMaxColor.BackColor = System.Drawing.Color.LightGreen;
            this.picMaxColor.Location = new System.Drawing.Point(138, 51);
            this.picMaxColor.Name = "picMaxColor";
            this.picMaxColor.Size = new System.Drawing.Size(20, 21);
            this.picMaxColor.TabIndex = 20;
            this.picMaxColor.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Granularity";
            // 
            // numericColorGranularity
            // 
            this.numericColorGranularity.Location = new System.Drawing.Point(98, 81);
            this.numericColorGranularity.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericColorGranularity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericColorGranularity.Name = "numericColorGranularity";
            this.numericColorGranularity.Size = new System.Drawing.Size(60, 20);
            this.numericColorGranularity.TabIndex = 18;
            this.numericColorGranularity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericColorGranularity.ValueChanged += new System.EventHandler(this.numericColorGranularity_ValueChanged);
            // 
            // buttonInverse
            // 
            this.buttonInverse.Location = new System.Drawing.Point(12, 104);
            this.buttonInverse.Name = "buttonInverse";
            this.buttonInverse.Size = new System.Drawing.Size(61, 23);
            this.buttonInverse.TabIndex = 21;
            this.buttonInverse.Text = "Swap";
            this.buttonInverse.UseVisualStyleBackColor = true;
            this.buttonInverse.Click += new System.EventHandler(this.buttonInverse_Click);
            // 
            // checkBoxInverted
            // 
            this.checkBoxInverted.AutoSize = true;
            this.checkBoxInverted.Location = new System.Drawing.Point(94, 107);
            this.checkBoxInverted.Name = "checkBoxInverted";
            this.checkBoxInverted.Size = new System.Drawing.Size(65, 17);
            this.checkBoxInverted.TabIndex = 17;
            this.checkBoxInverted.Text = "Inverted";
            this.checkBoxInverted.UseVisualStyleBackColor = true;
            this.checkBoxInverted.CheckedChanged += new System.EventHandler(this.checkBoxInverted_CheckedChanged);
            // 
            // buttonClearAndStart
            // 
            this.buttonClearAndStart.Location = new System.Drawing.Point(96, 13);
            this.buttonClearAndStart.Name = "buttonClearAndStart";
            this.buttonClearAndStart.Size = new System.Drawing.Size(75, 23);
            this.buttonClearAndStart.TabIndex = 18;
            this.buttonClearAndStart.Text = "Restart";
            this.buttonClearAndStart.UseVisualStyleBackColor = true;
            this.buttonClearAndStart.Click += new System.EventHandler(this.buttonClearAndStart_Click);
            // 
            // RandomWalkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 794);
            this.Controls.Add(this.buttonClearAndStart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericSpeed);
            this.Controls.Add(this.buttonBackColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericTopSteps);
            this.Controls.Add(this.checkBoxTopSteps);
            this.Controls.Add(this.walkerPictureBox);
            this.Controls.Add(this.StartButton);
            this.Name = "RandomWalkerForm";
            this.Text = "Random Walker";
            ((System.ComponentModel.ISupportInitialize)(this.walkerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTopSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGridSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCharaSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpeed)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColorGranularity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void numericGridSize_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.PictureBox walkerPictureBox;
        private System.Windows.Forms.CheckBox checkBoxTopSteps;
        private System.Windows.Forms.NumericUpDown numericTopSteps;
        private System.Windows.Forms.NumericUpDown numericGridSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericCharaSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCenterChara;
        private System.Windows.Forms.Button buttonChooseCharaColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonBackColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxGridInvisible;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picMaxColor;
        private System.Windows.Forms.PictureBox picMinColor;
        private System.Windows.Forms.Button buttonColorMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonColorMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericColorGranularity;
        private System.Windows.Forms.Button buttonInverse;
        private System.Windows.Forms.CheckBox checkBoxInverted;
        private System.Windows.Forms.Button buttonClearAndStart;
    }
}

