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

            if (!string.IsNullOrWhiteSpace(typedMsg))
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string finalMsg = $"[{timestamp}] {typedMsg}";

                lstMsgbox.Items.Add(finalMsg);
                txtInput.Focus();
                txtInput.Clear();

                lblMsgCount.Text = $"현재 대화: {lstMsgbox.Items.Count}개";
            }

        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSend.PerformClick();
            }
        }
    }
}
