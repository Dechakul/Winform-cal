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
            //input �Ѻ��Ҩҡ Textbox
            double Radius = 0;
            //Radius = Convert.ToDouble(txtRadius.Test);
            if (double.TryParse(txtRadius.Text, out Radius) == false)
            {
                MessageBox.Show("��͡���������١��ͧ", "Error!!");
                txtRadius.Focus(); //����� Cursor ��� Textbox
                txtRadius.SelectAll(); //���Select ��ͤ��� TextBox
                return;
            }

            //process �ӹǳ��鹷�� �ٵ� pr*r*r
            double CircleArea = Math.PI * Math.Pow(Radius, 2);
            //Math.PI ����� Pi
            //Math.Pow(x,y) x ¡���ѧ y

            //output ����ʴ����lblResult
            lblResult.Text = CircleArea.ToString("0.00");

            txtRadius.Focus(); //����� Cursor ��� Textbox
            txtRadius.SelectAll(); //���Select ��ͤ��� TextBox
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            //input �Ѻ��Ҩҡ Textbox
            double Radius = 0;
            //Radius = Convert.ToDouble(txtRadius.Test);
            if (double.TryParse(txtHeight.Text, out Radius) == false)
            {
                MessageBox.Show("��͡���������١��ͧ", "Error!!");
                txtRadius.Focus(); //����� Cursor ��� Textbox
                txtRadius.SelectAll(); //���Select ��ͤ��� TextBox
                return;
            }

            //process �ӹǳ��鹷�� �ٵ� pr*r*r
            double TriangleArea = Math.PI * Math.Pow(Radius, 2);
            //Math.PI ����� Pi
            //Math.Pow(x,y) x ¡���ѧ y

            //output ����ʴ����lblResult
            lblResult.Text = TriangleArea.ToString("0.00");

            txtHeight.Focus(); //����� Cursor ��� Textbox
            txtHeight.SelectAll(); //���Select ��ͤ��� TextBox
        }
    }
}
