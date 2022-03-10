using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AlterarTema
{
    public partial class Form1 : Form
    {


        [DllImport("user32.dll", CharSet = CharSet.Auto)]

        private static extern Int32 SystemParametersInfo(UInt32 action, UInt32 uParam, string vParam, UInt32 winIni);
       


        public Form1()
        {
            InitializeComponent();
        }

        String imgTemaVerde = "C:\\Users\\esvit\\Pictures\\Espaço\\VerdeTema.png";
        String imgTemaRoxo = "C:\\Users\\esvit\\Pictures\\Espaço\\RoxoTema.jpg";
        String imgTemaVermelho = "C:\\Users\\esvit\\Pictures\\Espaço\\RedTema.jpg";




        public void WallPaperSetting(string path)//Alterar imagem do windows.
        {
            SystemParametersInfo(0x14, 0, path, 0x01 | 0x02);
        }

        public virtual System.Drawing.Color Desktop { get; set; }


       

            public void ShowPropertiesOfGreen(PaintEventArgs e)
            {
                Color green = Color.FromName("Green");
                byte g = green.G;
                byte b = green.B;
                byte r = green.R;
                byte a = green.A;
                string text = String.Format("Slate Blue has these ARGB values: Alpha:{0}, " +
                    "red:{1}, green: {2}, blue {3}", new object[] { a, r, g, b });
                e.Graphics.DrawString(text,
                    new Font(this.Font, FontStyle.Italic),
                    new SolidBrush(green),
                    new RectangleF(new PointF(0.0F, 0.0F), this.Size));
            }

        


        private void button1_Click(object sender, EventArgs e)
        {

            if (TemaVerde.Checked)
            {

                WallPaperSetting(imgTemaVerde);
              
            }

            if (TemaRoxo.Checked)
            {
                WallPaperSetting(imgTemaRoxo);
            
            }

            if (TemaVermelho.Checked)
            {
                WallPaperSetting(imgTemaVermelho);
               

            }

        }

       
    }
}
