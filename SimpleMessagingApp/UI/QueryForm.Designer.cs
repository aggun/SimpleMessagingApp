namespace SimpleMessagingApp.UI
{
    partial class QueryForm
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
            label1 = new Label();
            serverNameComboBox = new ComboBox();
            clientNameComboBox = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            containsMessageTextBox = new TextBox();
            lastMessagesCountNumericUpDown = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lastMessagesCountNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(170, 33);
            label1.TabIndex = 0;
            label1.Text = "Server Nick Name";
            label1.UseCompatibleTextRendering = true;
            // 
            // serverNameComboBox
            // 
            serverNameComboBox.FormattingEnabled = true;
            serverNameComboBox.Location = new Point(270, 101);
            serverNameComboBox.Name = "serverNameComboBox";
            serverNameComboBox.Size = new Size(166, 28);
            serverNameComboBox.TabIndex = 1;
            // 
            // clientNameComboBox
            // 
            clientNameComboBox.FormattingEnabled = true;
            clientNameComboBox.Location = new Point(270, 150);
            clientNameComboBox.Name = "clientNameComboBox";
            clientNameComboBox.Size = new Size(166, 28);
            clientNameComboBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 146);
            label2.Name = "label2";
            label2.Size = new Size(165, 33);
            label2.TabIndex = 2;
            label2.Text = "Client Nick Name";
            label2.UseCompatibleTextRendering = true;
            // 
            // button1
            // 
            button1.Location = new Point(514, 101);
            button1.Name = "button1";
            button1.Size = new Size(124, 29);
            button1.TabIndex = 4;
            button1.Text = "Server Query";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(864, 441);
            dataGridView1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(514, 146);
            button2.Name = "button2";
            button2.Size = new Size(126, 29);
            button2.TabIndex = 6;
            button2.Text = "Client Query";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // containsMessageTextBox
            // 
            containsMessageTextBox.Location = new Point(270, 54);
            containsMessageTextBox.Name = "containsMessageTextBox";
            containsMessageTextBox.Size = new Size(166, 27);
            containsMessageTextBox.TabIndex = 7;
            // 
            // lastMessagesCountNumericUpDown
            // 
            lastMessagesCountNumericUpDown.Location = new Point(270, 12);
            lastMessagesCountNumericUpDown.Name = "lastMessagesCountNumericUpDown";
            lastMessagesCountNumericUpDown.Size = new Size(166, 27);
            lastMessagesCountNumericUpDown.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(246, 33);
            label3.TabIndex = 9;
            label3.Text = "Take Last Messages Count";
            label3.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 50);
            label4.Name = "label4";
            label4.Size = new Size(172, 33);
            label4.TabIndex = 10;
            label4.Text = "Contains Message";
            label4.UseCompatibleTextRendering = true;
            // 
            // QueryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(897, 656);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lastMessagesCountNumericUpDown);
            Controls.Add(containsMessageTextBox);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(clientNameComboBox);
            Controls.Add(label2);
            Controls.Add(serverNameComboBox);
            Controls.Add(label1);
            Name = "QueryForm";
            Text = "QueryForm";
            Load += QueryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lastMessagesCountNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox serverNameComboBox;
        private ComboBox clientNameComboBox;
        private Label label2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox containsMessageTextBox;
        private NumericUpDown lastMessagesCountNumericUpDown;
        private Label label3;
        private Label label4;
    }
}