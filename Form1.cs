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
            string typedMsg = txtInput.Text;

            if (!string.IsNullOrWhiteSpace(typedMsg))
            {
                lstMsgbox.Items.Add(typedMsg);
                txtInput.Focus();
                txtInput.Clear();
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
