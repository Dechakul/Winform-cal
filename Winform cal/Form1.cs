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
            //input รับค่าจาก Textbox
            double Radius = 0;
            //Radius = Convert.ToDouble(txtRadius.Test);
            if (double.TryParse(txtRadius.Text, out Radius) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Error!!");
                txtRadius.Focus(); //ให้มี Cursor ที่ Textbox
                txtRadius.SelectAll(); //ให้Select ข้อความ TextBox
                return;
            }

            //process คำนวณพื้นที่ สูตร pr*r*r
            double CircleArea = Math.PI * Math.Pow(Radius, 2);
            //Math.PI ให้ค่า Pi
            //Math.Pow(x,y) x ยกกำลัง y

            //output นำไปแสดงที่lblResult
            lblResult.Text = CircleArea.ToString("0.00");

            txtRadius.Focus(); //ให้มี Cursor ที่ Textbox
            txtRadius.SelectAll(); //ให้Select ข้อความ TextBox
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            //input รับค่าจาก Textbox
            double Height = 0;
            double Width = 0;
            //Radius = Convert.ToDouble(txtRadius.Test);
            if (double.TryParse(txtHeight.Text, out Height) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Error!!");
                txtHeight.Focus(); //ให้มี Cursor ที่ Textbox
                txtHeight.SelectAll(); //ให้Select ข้อความ TextBox
                return;
            }
            if (double.TryParse(txtWidth.Text, out Width) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Error!!");
                txtWidth.Focus(); //ให้มี Cursor ที่ Textbox
                txtWidth.SelectAll(); //ให้Select ข้อความ TextBox
                return;
            }

            //process คำนวณพื้นที่ สูตร pr*r*r
            double TriangleArea = 0.5 * Height * Width;
            //Math.PI ให้ค่า Pi
            //Math.Pow(x,y) x ยกกำลัง y

            //output นำไปแสดงที่lblResult
            lblResult.Text = TriangleArea.ToString("0.00");

            txtHeight.Focus(); //ให้มี Cursor ที่ Textbox
            txtHeight.SelectAll(); //ให้Select ข้อความ TextBox

        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            double Width = 0;
            //Radius = Convert.ToDouble(txtRadius.Test);
            if (double.TryParse(txtHexagonWidth.Text, out Width) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Error!!");
                txtHexagonWidth.Focus(); //ให้มี Cursor ที่ Textbox
                txtHexagonWidth.SelectAll(); //ให้Select ข้อความ TextBox
                return;
            }

            //process คำนวณพื้นที่ สูตร pr*r*r
            double HexArea = (3 * Math.Sqrt(3) * Math.Pow(Width, 2)) / 2;
            //Math.PI ให้ค่า Pi
            //Math.Pow(x,y) x ยกกำลัง y

            //output นำไปแสดงที่lblResult
            lblResult.Text = HexArea.ToString("0.00");

            txtHexagonWidth.Focus(); //ให้มี Cursor ที่ Textbox
            txtHexagonWidth.SelectAll(); //ให้Select ข้อความ TextBox
        }
    }
}
