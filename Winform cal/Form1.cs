namespace Winform_cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi ^-^", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you Sure!?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCicleArea_Click(object sender, EventArgs e)
        {
            //input ÃÑº¤èÒ¨Ò¡ Textbox
            double Radius = 0;
            //Radius = Convert.ToDouble(txtRadius.Test);
            if (double.TryParse(txtRadius.Text, out Radius) == false)
            {
                MessageBox.Show("¡ÃÍ¡¢éÍÁÙÅäÁè¶Ù¡µéÍ§", "Error!!");
                txtRadius.Focus(); //ãËéÁÕ Cursor ·Õè Textbox
                txtRadius.SelectAll(); //ãËéSelect ¢éÍ¤ÇÒÁ TextBox
                return;
            }

            //process ¤Ó¹Ç³¾×é¹·Õè ÊÙµÃ pr*r*r
            //double CircleArea = Math.PI * Math.Pow(Radius, 2);
            //Math.PI ãËé¤èÒ Pi
            //Math.Pow(x,y) x Â¡¡ÓÅÑ§ y

            //output ¹Óä»áÊ´§·ÕèlblResult
            //lblResult.Text = CircleArea.ToString("0.00");

            txtRadius.Focus(); //ãËéÁÕ Cursor ·Õè Textbox
            txtRadius.SelectAll(); //ãËéSelect ¢éÍ¤ÇÒÁ TextBox
            DisplayCircleArea(Radius);
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            //input ÃÑº¤èÒ¨Ò¡ Textbox
            double Height = 0;
            double Width = 0;
            //Radius = Convert.ToDouble(txtRadius.Test);
            if (double.TryParse(txtHeight.Text, out Height) == false)
            {
                MessageBox.Show("¡ÃÍ¡¢éÍÁÙÅäÁè¶Ù¡µéÍ§", "Error!!");
                txtHeight.Focus(); //ãËéÁÕ Cursor ·Õè Textbox
                txtHeight.SelectAll(); //ãËéSelect ¢éÍ¤ÇÒÁ TextBox
                return;
            }
            if (double.TryParse(txtWidth.Text, out Width) == false)
            {
                MessageBox.Show("¡ÃÍ¡¢éÍÁÙÅäÁè¶Ù¡µéÍ§", "Error!!");
                txtWidth.Focus(); //ãËéÁÕ Cursor ·Õè Textbox
                txtWidth.SelectAll(); //ãËéSelect ¢éÍ¤ÇÒÁ TextBox
                return;
            }

            //process ¤Ó¹Ç³¾×é¹·Õè ÊÙµÃ pr*r*r
            //double TriangleArea = 0.5 * Height * Width;
            //Math.PI ãËé¤èÒ Pi
            //Math.Pow(x,y) x Â¡¡ÓÅÑ§ y

            //output ¹Óä»áÊ´§·ÕèlblResult
            //lblResult.Text = TriangleArea.ToString("0.00");

            txtHeight.Focus(); //ãËéÁÕ Cursor ·Õè Textbox
            txtHeight.SelectAll(); //ãËéSelect ¢éÍ¤ÇÒÁ TextBox
            DisplayTriangleArea(Height, Width);

        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            double Width = 0;
            //Radius = Convert.ToDouble(txtRadius.Test);
            if (double.TryParse(txtHexagonWidth.Text, out Width) == false)
            {
                MessageBox.Show("¡ÃÍ¡¢éÍÁÙÅäÁè¶Ù¡µéÍ§", "Error!!");
                txtHexagonWidth.Focus(); //ãËéÁÕ Cursor ·Õè Textbox
                txtHexagonWidth.SelectAll(); //ãËéSelect ¢éÍ¤ÇÒÁ TextBox
                return;
            }

            //process ¤Ó¹Ç³¾×é¹·Õè ÊÙµÃ pr*r*r
            //double HexArea = (3 * Math.Sqrt(3) * Math.Pow(Width, 2)) / 2;
            //Math.PI ãËé¤èÒ Pi
            //Math.Pow(x,y) x Â¡¡ÓÅÑ§ y

            //output ¹Óä»áÊ´§·ÕèlblResult
            //lblResult.Text = HexArea.ToString("0.00");

            txtHexagonWidth.Focus(); //ãËéÁÕ Cursor ·Õè Textbox
            txtHexagonWidth.SelectAll(); //ãËéSelect ¢éÍ¤ÇÒÁ TextBox
            DisplayHexagonArea(Width);

        }

        // Method แบบ Void ที่คำนวณและแสดงผลพื้นที่วงกลม
        private void DisplayCircleArea(double radius)
        {
            double circleArea = Math.PI * Math.Pow(radius, 2);
            lblResult.Text = circleArea.ToString("0.00");
            txtRadius.Focus();
            txtRadius.SelectAll();
        }

        // Method แบบ Void ที่คำนวณและแสดงผลพื้นที่สามเหลี่ยม
        private void DisplayTriangleArea(double height, double width)
        {
            double triangleArea = 0.5 * height * width;
            lblResult.Text = triangleArea.ToString("0.00");
            txtHeight.Focus();
            txtHeight.SelectAll();
        }

        // Method แบบ Void ที่คำนวณและแสดงผลพื้นที่หกเหลี่ยม
        private void DisplayHexagonArea(double width)
        {
            double hexArea = (3 * Math.Sqrt(3) * Math.Pow(width, 2)) / 2;
            lblResult.Text = hexArea.ToString("0.00");
            txtHexagonWidth.Focus();
            txtHexagonWidth.SelectAll();
        }

        // Method แบบ Return ค่า สำหรับคำนวณพื้นที่วงกลม
        private double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        // Method แบบ Return ค่า สำหรับคำนวณพื้นที่สามเหลี่ยม
        private double CalculateTriangleArea(double height, double width)
        {
            return 0.5 * height * width;
        }

        /// Method แบบ Return ค่า สำหรับคำนวณพื้นที่หกเหลี่ยม
        private double CalculateHexagonArea(double width)
        {
            return (3 * Math.Sqrt(3) * Math.Pow(width, 2)) / 2;
        }
    }
}
