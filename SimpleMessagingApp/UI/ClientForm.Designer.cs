namespace SimpleMessagingApp.UI
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            messageTextBox = new TextBox();
            label2 = new Label();
            nickNameTextBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(251, 125);
            button1.Name = "button1";
            button1.Size = new Size(146, 29);
            button1.TabIndex = 0;
            button1.Text = "Send Message";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 70);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 1;
            label1.Text = "Message";
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(141, 70);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(533, 27);
            messageTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 33);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 3;
            label2.Text = "Nick Name";
            // 
            // nickNameTextBox
            // 
            nickNameTextBox.Location = new Point(141, 33);
            nickNameTextBox.Name = "nickNameTextBox";
            nickNameTextBox.Size = new Size(533, 27);
            nickNameTextBox.TabIndex = 4;
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(692, 179);
            Controls.Add(nickNameTextBox);
            Controls.Add(label2);
            Controls.Add(messageTextBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "ServerForm";
            Text = "ServerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox messageTextBox;
        private Label label2;
        private TextBox nickNameTextBox;
    }
}