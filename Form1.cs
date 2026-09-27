using System;
using System.Drawing;
using System.Windows.Forms;

namespace uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 600;
            this.Height = 650;

            int sayac = 1;

            
            for (int satir = 0; satir < 10; satir++)
            {
                for (int sutun = 0; sutun < 10; sutun++)
                {
                    Button btn = new Button();
                    btn.Width = 50;
                    btn.Height = 50;
                    btn.Left = 20 + (sutun * 55); 
                    btn.Top = 20 + (satir * 55);  
                    btn.Text = sayac.ToString();
                    btn.BackColor = Color.LightGray;

                    
                    btn.MouseEnter += (s, ev) => {
                        if (btn.BackColor != Color.DodgerBlue)
                            btn.BackColor = Color.Yellow;
                    };

                    
                    btn.MouseLeave += (s, ev) => {
                        if (btn.BackColor != Color.DodgerBlue)
                            btn.BackColor = Color.LightGray;
                    };

                    
                    btn.Click += (s, ev) => {
                        if (btn.BackColor == Color.DodgerBlue)
                            btn.BackColor = Color.LightGray;
                        else
                            btn.BackColor = Color.DodgerBlue;
                    };

                    this.Controls.Add(btn);
                    sayac++;
                }
            }
        }
    }
}
