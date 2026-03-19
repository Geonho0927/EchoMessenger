namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lstMsgbox = new ListBox();
            txtInput = new TextBox();
            btnSend = new Button();
            lblMsgCount = new Label();
            btnDelete = new Button();
            btnDeleteAll = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Book Antiqua", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.MenuHighlight;
            lblTitle.Location = new Point(12, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(380, 57);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Echo Messenger";
            // 
            // lstMsgbox
            // 
            lstMsgbox.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lstMsgbox.FormattingEnabled = true;
            lstMsgbox.Location = new Point(22, 95);
            lstMsgbox.Name = "lstMsgbox";
            lstMsgbox.Size = new Size(748, 256);
            lstMsgbox.TabIndex = 1;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(22, 398);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(596, 23);
            txtInput.TabIndex = 2;
            txtInput.KeyDown += txtInput_KeyDown;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Chartreuse;
            btnSend.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSend.Location = new Point(646, 379);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(124, 59);
            btnSend.TabIndex = 3;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // lblMsgCount
            // 
            lblMsgCount.AutoSize = true;
            lblMsgCount.Font = new Font("문체부 돋음체", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblMsgCount.Location = new Point(22, 364);
            lblMsgCount.Name = "lblMsgCount";
            lblMsgCount.Size = new Size(140, 19);
            lblMsgCount.TabIndex = 4;
            lblMsgCount.Text = "현재 대화: 0개";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnDelete.Location = new Point(498, 27);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 56);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.FromArgb(255, 128, 128);
            btnDeleteAll.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnDeleteAll.Location = new Point(636, 26);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(134, 56);
            btnDeleteAll.TabIndex = 6;
            btnDeleteAll.Text = "대화 기록 삭제";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnDelete);
            Controls.Add(lblMsgCount);
            Controls.Add(btnSend);
            Controls.Add(txtInput);
            Controls.Add(lstMsgbox);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListBox lstMsgbox;
        private TextBox txtInput;
        private Button btnSend;
        private Label lblMsgCount;
        private Button btnDelete;
        private Button btnDeleteAll;
    }
}
