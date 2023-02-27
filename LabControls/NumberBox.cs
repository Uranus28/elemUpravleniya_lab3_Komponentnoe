using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LabControls
{
    public partial class NumberBox : TextBox
    {

        public NumberBox()
        {
            InitializeComponent();
            Hex = false;
        }
        public NumberBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            Hex = false;
        }
        public bool Hex { get; set; }
        protected override void OnTextChanged(EventArgs e)
        {
            int i;
            if (Text == "")
                Text = "0";
            else
            {
                if (Text.Length > 1)
                    Text = Text.TrimStart('0');//число не может начинаться с 0
                if (Hex)
                {
                    i = Convert.ToInt32(Text, 16);
                    if (i > 255)
                    {
                        Text = "FF";
                    }
                }
                else
                {
                    int.TryParse(Text, out i);
                    //если число больше 255, ставим максимальное доступное число: 255
                    if (i > 255)
                    {
                        Text = "255";
                    }
                }
            }
            //Перевод в верх. регистр
            Text = Text.ToUpper();
            //курсор в конец строки после перевода регистра
            SelectionStart = Text.Length;

            base.OnTextChanged(e);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            //при десятичном вводе            
            if (!Hex)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)))
                    e.Handled = true;
                base.OnKeyPress(e);
            }
            //при шестнадцатеричном вводе
            else
            {
                //MessageBox.Show(Text);
                if (!HexSymb(e.KeyChar.ToString()) && !char.IsControl((e.KeyChar)))
                    e.Handled = true;

                base.OnKeyPress(e);
            }
        }
       

        //проверка на 16-ти ричность
        public bool HexSymb(string text)
        {
            string range = "abcdef0123456789";
            foreach (var i in text)
            {
                if (!range.Contains(i.ToString().ToLower()))
                {
                    return false;
                }

            }
            return true;
        }

    }
}
