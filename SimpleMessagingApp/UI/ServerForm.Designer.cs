namespace SimpleMessagingApp
{
    partial class ServerForm
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
            label1 = new Label();
            nickNameTextBox = new TextBox();
            label2 = new Label();
            serverIpTextBox = new TextBox();
            portNumberBox = new NumericUpDown();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)portNumberBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 0;
            label1.Text = "Nick Name:";
            // 
            // nickNameTextBox
            // 
            nickNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nickNameTextBox.Location = new Point(130, 21);
            nickNameTextBox.Name = "nickNameTextBox";
            nickNameTextBox.Size = new Size(187, 34);
            nickNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuText;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 2;
            label2.Text = "Server IP:";
            // 
            // serverIpTextBox
            // 
            serverIpTextBox.Location = new Point(130, 68);
            serverIpTextBox.Name = "serverIpTextBox";
            serverIpTextBox.Size = new Size(187, 27);
            serverIpTextBox.TabIndex = 3;
            // 
            // portNumberBox
            // 
            portNumberBox.Location = new Point(130, 110);
            portNumberBox.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            portNumberBox.Name = "portNumberBox";
            portNumberBox.Size = new Size(187, 27);
            portNumberBox.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(149, 151);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuText;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 6;
            label3.Text = "Server Port:";
            // 
            // button2
            // 
            button2.Location = new Point(115, 186);
            button2.Name = "button2";
            button2.Size = new Size(163, 29);
            button2.TabIndex = 7;
            button2.Text = "Go To Client Form";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(371, 229);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(portNumberBox);
            Controls.Add(serverIpTextBox);
            Controls.Add(label2);
            Controls.Add(nickNameTextBox);
            Controls.Add(label1);
            Name = "ClientForm";
            Text = "TCP/IP Message App: Client";
            ((System.ComponentModel.ISupportInitialize)portNumberBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nickNameTextBox;
        private Label label2;
        private TextBox serverIpTextBox;
        private NumericUpDown portNumberBox;
        private Button button1;
        private Label label3;
        private Button button2;
        private TextBox messageTextBox;
        private Label label4;
    }
}