namespace LoginScreen
{
    public partial class Form1 : Form
    {
        string id = "admin";
        string pw = "superman";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 입력된 ID와 PW 값 가져옴
            string inputID = txtID.Text;
            string inputPW = txtPW.Text;

            if (inputID == id && inputPW == pw)
            {
                MessageBox.Show("로그인 성공.", "로그인", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("로그인 실패.", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
