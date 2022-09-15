namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "hesapla";
            label1.Text = "";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gun = 0, ay = 0, yil = 0, g, a, y;
            string gg = "0", aa = "0", yy = "0";
            gun = dateTimePicker1.Value.Day;
            ay = dateTimePicker1.Value.Month;
            yil = dateTimePicker1.Value.Year;
            DateTime dt = DateTime.Now;
            g =Convert.ToInt32( dt.Day);
            a = Convert.ToInt32(dt.Month);
            y = Convert.ToInt32(dt.Year);
            if (g >= gun) 
                gg = Convert.ToString(g - gun);
            else
            {
                if (ay == 1 || ay == 3 || ay == 5 || ay == 7 || ay == 8 || ay == 10 || ay == 12)
                {
                    gg = Convert.ToString((31 - gun) + g);
                }
                else if (ay == 4 || ay == 6 || ay == 9 || ay == 11)
                {
                    gg = Convert.ToString((30 - gun) + g);
                }
                else if (ay == 2) 
                {
                    gg = Convert.ToString((29 - gun) + g);
                }
                a--;
            }
            if (a >= ay) 
                aa = Convert.ToString(a - ay);
            else
            {
                y--;
                aa = Convert.ToString((12 - ay) + a);
            }
            if (y >= yil) 
                yy = Convert.ToString(y - yil);
            
            label1.Text = gg + " gun " + aa + " ay " + yy + " yýl ";
            label2.Text = "yaþ: " + yy;
        }
    }
}