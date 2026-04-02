using System.Text.RegularExpressions;

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

            Regex idRegex = new System.Text.RegularExpressions.Regex(@"^[0-9a-zA-Z]{1,15}$");
            bool idCheck = idRegex.IsMatch(inputID);

            Regex pwRegex = new System.Text.RegularExpressions.Regex(@"^[0-9a-zA-Z]{6,20}$");
            bool pwCheck = pwRegex.IsMatch(inputPW);

            if (!idCheck)
            {
                lblErrorMsg.Visible = true;
            }
            else if (!pwCheck)
            {
                lblErrorMsg.Visible = true;
            }
            else if (inputID == id && inputPW == pw)
            {
                lblErrorMsg.Visible = false;
                MessageBox.Show("로그인 성공.", "로그인", MessageBoxButtons.OK); // 메시지 박스 출력
            }
            else
            {
                lblErrorMsg.Visible = true;
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enter 키 입력 방지
                txtPW.Focus(); // 포커스 이동
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enter 키 입력 방지
                btnLogin_Click(sender, e); // 로그인 버튼 클릭 이벤트 호출
            }
        }

        private void ckbPWShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPW.UseSystemPasswordChar = !txtPW.UseSystemPasswordChar; // 체크 박스를 누를 때마다 비밀번호 표시 여부 반전
        }

        private void txtCE_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtPW.Clear();
        }
    }
}
