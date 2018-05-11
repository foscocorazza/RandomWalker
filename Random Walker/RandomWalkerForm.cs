using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Random_Walker
{
    public partial class RandomWalkerForm : Form
    {

        // Grid
        int gridSize;
        Pen gridPen = new Pen(Brushes.DarkSlateGray);
        List<Color> cellColors = new List<Color>();
        bool gridInvisible;

        // Character
        Point characterPosition;
        int characterSize;
        Brush characterBrush = Brushes.Blue;

        // Form
        Color bgColor = Color.WhiteSmoke;
        int StepsToReset = 13 / 2;

        // Speed
        System.Timers.Timer aTimer = new System.Timers.Timer();
        Random rnd = new Random(DateTime.Now.Millisecond);

        bool isPlaying = false;
        int[,] occurences;
        List<Point> inputs = new List<Point>();
        private int PercentagesFrequency;
        private int DisableLastMoves;
        private List<Point> lastMoves = new List<Point>();
        private List<int> probArray;
        private bool disabled;

        public RandomWalkerForm()
        {
            InitializeComponent();
            UpdateFromUI();
            Clear();
            
            // Inputs
            inputs.Clear();
            inputs.Add(new Point(1, 0));
            inputs.Add(new Point(-1, 0));
            inputs.Add(new Point(0, 1));
            inputs.Add(new Point(0, -1));

            // Handlers

            walkerPictureBox.Paint += new PaintEventHandler(WalkerPictureBox_Paint);
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Enabled = false; 
        }

        private void Clear()
        {
            lastMoves.Clear();
            MoveCharacterToCenter();
            occurences = new int[gridSize, gridSize];
            StartButton.Text = "Start";
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Start(false);
        }

        private void buttonClearAndStart_Click(object sender, EventArgs e)
        {
            Start(true);
        }

        private void Start(bool andClear)
        {
            if (andClear)
            {
                Clear();
                isPlaying = false;
            }

            if (!isPlaying)
            {
                aTimer.Start();
                StartButton.Text = "Pause";
                
            }
            else
            {
                aTimer.Stop();
                StartButton.Text = "Resume";
            }

          

            isPlaying = !isPlaying;
        }


        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            int steps = 1;
            if(StepsToReset > 0)
            {
                steps = GenerateRandomStepNumber();
            }

            for(int i = 0; i < steps; i++) {
                moveCharacter();
            }

            Redraw();
            occurences[characterPosition.X, characterPosition.Y]++;

            if (StepsToReset > 0)
            {
                characterPosition = new Point(gridSize / 2, gridSize / 2);
            }
            
        }

        private int GenerateRandomStepNumber()
        {
            if (probArray == null) GenerateRandomProbArray();
            return probArray[(int)(rnd.NextDouble() * (probArray.Count-1))];
        }

        private void GenerateRandomProbArray()
        {
            int MAX_ELEMENTS = 10;
            int Start = Math.Max(0, StepsToReset - MAX_ELEMENTS);
            probArray = new List<int>();
            for (int i = Start; i <= StepsToReset; i++)
            {
                for (int p = 0; p < Math.Pow(4, i - Start); p++)
                {
                    probArray.Add(i);
                }
            }
        }

        private void moveCharacter()
        {
            Point input;
            do
            {
                input = inputs[rnd.Next(inputs.Count)];
            } while (lastMoves.Contains(OppositeOf(input)));

            characterPosition.X += input.X;
            characterPosition.Y += input.Y;

            characterPosition = Cap(characterPosition, 0,  gridSize);

            lastMoves.Add(input);

            if(lastMoves.Count > DisableLastMoves && lastMoves.Count > 0)
            {
                lastMoves.RemoveAt(0);
            }
        }

        private Point OppositeOf(Point input)
        {
            return new Point(-input.X, -input.Y);
        }

        private static Point Cap(Point p, int min, int max)
        {
            if (p.X >= max){p.X = max - 1;}

            if (p.Y >= max){ p.Y = max - 1;}

            if (p.X < min){p.X = min;}

            if (p.Y < min) {p.Y = min;}

            return p;
        }

        private void WalkerPictureBox_Paint(object sender, PaintEventArgs pe)
        {
            if (disabled) return;
            Graphics g = pe.Graphics;
            g.Clear(bgColor);

            drawOccurences(g, PercentagesFrequency);
            drawGrid(g);
            drawCharacter(g);
        }

        private Rectangle coordToPixel(Point coord, int widthOffset = 0, int heightOffset = 0) {
            int h = walkerPictureBox.Size.Height, w = walkerPictureBox.Size.Width;
            double rowW = h * 1.0 / gridSize, colW = w * 1.0 / gridSize;

            Point pos = new Point((int)(coord.X * colW), (int)(coord.Y * rowW));
            return new Rectangle(pos, new Size((int)rowW + widthOffset, (int)colW + heightOffset));
        }

        private void drawCharacter(Graphics g)
        {
            System.Drawing.Drawing2D.SmoothingMode prev = g.SmoothingMode;
            g.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            RectangleF rect = coordToPixel(characterPosition);

            rect.X += rect.Width / 2 - characterSize / 2;
            rect.Y += rect.Height / 2 - characterSize / 2;
            rect.Size = new Size(characterSize, characterSize);

            g.FillEllipse(characterBrush, rect);

            g.SmoothingMode = prev;
        }

        private void drawOccurences(Graphics g, int PercentagesFrequency)
        {
            adjustOccurArrayIfNeeded();
            int SUM = 0;
            int max = int.MinValue, min = int.MaxValue;

            // Calculate the SUM
            for (int row = 0; row < gridSize; row++)
                for (int col = 0; col < gridSize; col++)
                {
                    SUM += occurences[row, col];
                }

            labelInputsGiven.Text = SUM.ToString();

            // Calc Max & Min
            for (int row = 0; row < gridSize; row++)
                for (int col = 0; col < gridSize; col++)
                {
                    int val = occurences[row, col];
                    if (val == 0) continue;
                    if (val > max) max = val;
                    if (val < min) min = val;
                }

            // Draw Rect
            for (int row = 0; row < gridSize; row++)
                for (int col = 0; col < gridSize; col++)
                {
                    int val = occurences[col, row];
                    if (val == 0) continue;
                    double percentile = (val - min + 0.0) / (max - min);
                    int idxColor = cellColors.Count - 1;
                    if (max - min > 0) {
                        idxColor = (int)(percentile * (cellColors.Count - 1));
                    }
                    Brush brush = new SolidBrush(cellColors[idxColor]);
                    Rectangle rect = coordToPixel(new Point(col, row), 1, 1);
                    g.FillRectangle(brush, rect );

                    if(PercentagesFrequency > 0 && (row+col) % PercentagesFrequency == 0)
                    {
                        StringFormat format = new StringFormat();
                        format.LineAlignment = StringAlignment.Center;
                        format.Alignment = StringAlignment.Center;
                        g.DrawString((val * 100.0 / SUM).ToString("0.0"), SystemFonts.DefaultFont, Brushes.Black, rect, format);
                    }

                }

        }

        private void drawGrid(Graphics g)
        {
            if (gridInvisible) return;

            int h = walkerPictureBox.Size.Height, w = walkerPictureBox.Size.Width;
            double rowW = h*1.0 / gridSize, colW = w * 1.0 / gridSize;

            for (double row = rowW; row < h; row+=rowW)
            {
                g.DrawLine(gridPen, new Point(0, (int)row), new Point(h, (int)row));
            }

            for (double col = colW; col < w; col+=colW)
            {
                g.DrawLine(gridPen, new Point((int)col, 0), new Point((int)col, w));
            }

            h--;
            w--;

            // Borders
            g.DrawLine(gridPen, new Point(0, 0), new Point(0, w));
            g.DrawLine(gridPen, new Point(0, 0), new Point(h, 0));
            g.DrawLine(gridPen, new Point(h, 0), new Point(h, w));
            g.DrawLine(gridPen, new Point(0, w), new Point(h, w));
        }

        private void checkBoxTopSteps_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFromUI();
        }

        private void UpdateFromUI()
        {
            if (checkBoxTopSteps.Checked)
            {
                StepsToReset = (int) numericTopSteps.Value;
                numericTopSteps.Enabled = true;
            } else
            {
                StepsToReset = -1;
                numericTopSteps.Enabled = false;
            }

            gridSize = (int) numericGridSize.Value;
            characterSize = (int)numericCharaSize.Value;
            aTimer.Interval = (double)numericSpeed.Value;
            gridInvisible = checkBoxGridInvisible.Checked;
            PercentagesFrequency = (int)numericPrcFrequency.Value;
            DisableLastMoves = (int)numericLastMoves.Value;
            disabled = !checkBoxDisable.Checked;

            adjustOccurArrayIfNeeded();

            generateColorGradient((int)numericColorGranularity.Value, checkBoxInverted.Checked);

            Redraw();
        }

        private void Redraw()
        {
            if(!disabled) walkerPictureBox.Invalidate();
        }

        private void generateColorGradient(int granularity, bool inverted)
        {
            cellColors.Clear();

            Color min = picMinColor.BackColor;
            Color max = picMaxColor.BackColor;

            if(!inverted) { 
                for (int i = 0; i < granularity; i++) {
                    cellColors.Add(InterpolateBetween(min, max, (float)i / (granularity - 1)));
                }
            } else {
                for (int i = 0; i < granularity; i++)
                {
                    cellColors.Insert(0, InterpolateBetween(min, max, (float)i / (granularity - 1)));
                }
            }


        }

        private void numericTopSteps_ValueChanged(object sender, EventArgs e)
        {
            UpdateFromUI();
            GenerateRandomProbArray();
        }

        private void numericGridSize_ValueChanged_1(object sender, EventArgs e)
        {
            UpdateFromUI();
        }

        T[,] ResizeArray<T>(T[,] original, int rows, int cols)
        {
            var newArray = new T[rows, cols];
            int minRows = Math.Min(rows, original.GetLength(0));
            int minCols = Math.Min(cols, original.GetLength(1));
            for (int i = 0; i < minRows; i++)
                for (int j = 0; j < minCols; j++)
                    newArray[i, j] = original[i, j];
            return newArray;
        }

        private void adjustOccurArrayIfNeeded()
        {
            if(occurences!=null && (occurences.GetLength(0) != gridSize || occurences.GetLength(1) != gridSize))
            {
                occurences = ResizeArray(occurences, gridSize, gridSize);
            }
        }

        private void numericCharaSize_ValueChanged(object sender, EventArgs e)
        {
            UpdateFromUI();
        }

        private void buttonChooseCharaColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                characterBrush = new SolidBrush(colorDialog.Color);
                Redraw();
            }
        }

        private void buttonCenterChara_Click(object sender, EventArgs e)
        {
            MoveCharacterToCenter();
            Redraw();
        }

        private void MoveCharacterToCenter()
        {
            characterPosition = new Point(gridSize / 2, gridSize / 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                gridPen = new Pen(colorDialog.Color);
                Redraw();
            }
        }

        private void buttonBackColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                bgColor = colorDialog.Color;
                Redraw();
            }
        }

        private void numericSpeed_ValueChanged(object sender, EventArgs e)
        {
            UpdateFromUI();
        }

        private void checkBoxGridInvisible_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFromUI();
        }

        private void buttonColorMin_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                picMinColor.BackColor = colorDialog.Color;
                UpdateFromUI();
            }
        }

        private void buttonColorMax_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                picMaxColor.BackColor = colorDialog.Color;
                UpdateFromUI();
            }
        }

        private void numericColorGranularity_ValueChanged(object sender, EventArgs e)
        {
            UpdateFromUI();
        }



        // Color interpolation

        public static Color InterpolateBetween( Color endPoint1,  Color endPoint2, float lambda)
        {
            if (lambda < 0 || lambda > 1)
            {
                throw new ArgumentOutOfRangeException("Lambda out of bounds");
            }


            float h = InterpolateBetween(endPoint1.GetHue(), endPoint2.GetHue(), lambda, 360);
            float s = InterpolateBetween(endPoint1.GetSaturation(), endPoint2.GetSaturation(), lambda, -1);
            float b = InterpolateBetween(endPoint1.GetBrightness(), endPoint2.GetBrightness(), lambda, -1);
            
            return HSBToRGBConversion(h/360,s,b);
        }

        public static float InterpolateBetween(float endPoint1, float endPoint2, float lambda, float wrapAt)
        {
            float range;
            if (endPoint1 < endPoint2 || wrapAt < 0)
            {
                range = endPoint2 - endPoint1;
                return endPoint1 + lambda * range;
            }


            range = (wrapAt - endPoint1) + endPoint2;
            return (endPoint1 + lambda * range) % (wrapAt+1);
        }


        public static Color HSBToRGBConversion(float hue, float saturation, float brightness)
        {
            float red, green, blue;

            if (saturation == 0)
            {
                red = green = blue = brightness; // achromatic
            }
            else
            {
                var q = brightness < 0.5 ? brightness * (1 + saturation) : brightness + saturation - brightness * saturation;
                var p = 2 * brightness - q;
                red = hue2rgb(p, q, hue + 1f / 3);
                green = hue2rgb(p, q, hue);
                blue = hue2rgb(p, q, hue - 1f / 3);
            }

            return Color.FromArgb((int)Math.Round(red * 255), (int)Math.Round(green * 255), (int)Math.Round(blue * 255));
        }

        public static float hue2rgb(float p, float q, float t)
        {
            if (t < 0) t += 1;
            if (t > 1) t -= 1;
            if (t < 1f / 6) return p + (q - p) * 6 * t;
            if (t < 1f / 2) return q;
            if (t < 2f / 3) return p + (q - p) * (2f / 3 - t) * 6;
            return p;
        }

        private void buttonInverse_Click(object sender, EventArgs e)
        {
            Color newMax = picMinColor.BackColor;
            picMinColor.BackColor = picMaxColor.BackColor;
            picMaxColor.BackColor = newMax;
            UpdateFromUI();
        }

        private void checkBoxInverted_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFromUI();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (isPlaying) Start(false);
            Clear();
            Redraw();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateFromUI();
        }

        private void numericLastMoves_ValueChanged(object sender, EventArgs e)
        {
            UpdateFromUI();
        }

        private void checkBoxDisable_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFromUI();
        }
    }
}
