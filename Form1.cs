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
                MessageBox.Show("로그인 성공.", "로그인", MessageBoxButtons.OK); // 메시지 박스 출력
                lblErrorMsg.Visible = false; // 오류 메시지 숨김
            }
            else
            {
                // MessageBox.Show("로그인 실패.", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblErrorMsg.Visible = true; //오류 메시지 보이기
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
