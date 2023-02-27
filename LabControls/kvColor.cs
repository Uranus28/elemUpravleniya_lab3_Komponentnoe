using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabControls
{
    public partial class kvColor : UserControl
    {
        private Color color;
        public struct Rect
        {
            public int x, y, h, w;
        }
        //свойство типа Color для установки/получения текущего цвета.
        public Color CurColor
        {
            get => color;
            set { color = value; }
        }
        //ициниализация квадрата
        public Rect kv = new Rect { x = 170, y = 10, h = 120, w = 180 };

        public kvColor()
        {
            InitializeComponent();
            //MessageBox.Show((numberBoxRed.Hex).ToString() + (numberBoxGreen.Hex).ToString() + (numberBoxBlue.Hex).ToString());
            //MessageBox.Show((numberBoxRed.Text) + (numberBoxGreen.Text) + (numberBoxBlue.Text));
            color = Color.Black;
        }
        //Элемент должен иметь событие, вызываемое при смене цвета в нем
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //красит прямоугольниk
            e.Graphics.FillRectangle(new SolidBrush(color), kv.x, kv.y, kv.w, kv.h);
            //изменяет цвет текста при смене цвет из квадрата
            numberBoxRed.ForeColor = Color.FromArgb(color.R, 0, 0);
            numberBoxGreen.ForeColor = Color.FromArgb(0, color.G, 0);
            numberBoxBlue.ForeColor = Color.FromArgb(0, 0, color.B);
        }

        //int to hex
        public string _Hex(string s)
        {
            int x;
            int.TryParse(s, out x);
            return String.Format("{0:X}", x);
        }
        //hex to int
        public string _Dec(string s)
        {
            int x = Convert.ToInt32(s, 16);
            return x.ToString();            
        }
        //проверка на обновление значений
        public bool t = true;
        //проверка флажка для смены системы счисления
        
        private void radioBtnDec_CheckedChanged(object sender, EventArgs e)
        {
            numberBoxRed.Hex = radioBtnHex.Checked;
            numberBoxGreen.Hex = radioBtnHex.Checked;
            numberBoxBlue.Hex = radioBtnHex.Checked;
            //MessageBox.Show((numberBoxRed.Hex).ToString() + (numberBoxGreen.Hex).ToString() + (numberBoxBlue.Hex).ToString());
            t = false;
            if (radioBtnDec.Checked)
            {
                numberBoxRed.Text = _Dec(numberBoxRed.Text);
                numberBoxGreen.Text = _Dec(numberBoxGreen.Text);
                numberBoxBlue.Text = _Dec(numberBoxBlue.Text);
            }
            else
            {
                numberBoxRed.Text = _Hex(numberBoxRed.Text);
                numberBoxGreen.Text = _Hex(numberBoxGreen.Text);
                numberBoxBlue.Text = _Hex(numberBoxBlue.Text);
            }
            t = true;
        }
        //Вывод квадрата
        private void DrawKv()
        {
            var graphics = CreateGraphics();
            var kvadrat = new Rectangle(kv.x, kv.y, kv.w, kv.h);
            OnPaint(new PaintEventArgs(graphics, kvadrat));
        }
        public void newCol()
        {
            int r, g, b;
            if (t)
            {
                if (radioBtnDec.Checked)//если dec
                {
                    int.TryParse(numberBoxRed.Text, out r);
                    int.TryParse(numberBoxGreen.Text, out g);
                    int.TryParse(numberBoxBlue.Text, out b);
                }
                else//если hex
                {
                    r = Convert.ToInt32(numberBoxRed.Text, 16);
                    g = Convert.ToInt32(numberBoxGreen.Text, 16);
                    b = Convert.ToInt32(numberBoxBlue.Text, 16);
                }
                CurColor = Color.FromArgb(r, g, b);
            }
           
        }
       
        private void kvColor_Load(object sender, EventArgs e)
        {

        }

        private void numberBoxRed_TextChanged_1(object sender, EventArgs e)
        {
            //изменяеtn цвет
            newCol();
            //красит квадрат
            DrawKv();
        }

        private void numberBoxGreen_TextChanged(object sender, EventArgs e)
        {
            //изменяеtn цвет
            newCol();
            //красит квадрат
            DrawKv();
        }

        private void numberBoxBlue_TextChanged(object sender, EventArgs e)
        {
            //изменяеtn цвет
            newCol();
            //красит квадрат
            DrawKv();
        }
    }
}
