namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string typedMsg = txtInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(typedMsg))
            {
                return;
            }

            if (typedMsg.Length > 50)
            {
                MessageBox.Show("메시지는 50자 이하로 입력하세요.");
                return;
            }

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string finalMsg = $"[{timestamp}] {typedMsg}";

            lstMsgbox.Items.Add(finalMsg);
            txtInput.Focus();
            txtInput.Clear();

            lblMsgCount.Text = $"현재 대화: {lstMsgbox.Items.Count}개";

        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSend.PerformClick();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstMsgbox.SelectedIndex != -1)
            {
                lstMsgbox.Items.RemoveAt(lstMsgbox.SelectedIndex);

                lblMsgCount.Text = $"현재 대화: {lstMsgbox.Items.Count}개";
            }
            else
            {
                MessageBox.Show("삭제할 메시지를 선택하세요.");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            lstMsgbox.Items.Clear();

            lblMsgCount.Text = "현재 대화: 0개";
        }
    }
}
