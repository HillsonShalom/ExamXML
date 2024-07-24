namespace ExamXML
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
            year = new ComboBox();
            month = new ComboBox();
            dayM = new ComboBox();
            dayW = new ComboBox();
            label1 = new Label();
            sendButton = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // year
            // 
            year.FormattingEnabled = true;
            year.Location = new Point(38, 52);
            year.Name = "year";
            year.Size = new Size(151, 28);
            year.TabIndex = 0;
            year.SelectedIndexChanged += buttonEnableBack;
            // 
            // month
            // 
            month.FormattingEnabled = true;
            month.Location = new Point(222, 52);
            month.Name = "month";
            month.Size = new Size(151, 28);
            month.TabIndex = 1;
            month.SelectedIndexChanged += buttonEnableBack;
            // 
            // dayM
            // 
            dayM.FormattingEnabled = true;
            dayM.Location = new Point(400, 52);
            dayM.Name = "dayM";
            dayM.Size = new Size(151, 28);
            dayM.TabIndex = 2;
            dayM.SelectedIndexChanged += buttonEnableBack;
            // 
            // dayW
            // 
            dayW.FormattingEnabled = true;
            dayW.Location = new Point(587, 52);
            dayW.Name = "dayW";
            dayW.Size = new Size(151, 28);
            dayW.TabIndex = 3;
            dayW.SelectedIndexChanged += buttonEnableBack;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(101, 389);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 4;
            label1.Text = "הנוסח המלא";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(98, 272);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(94, 29);
            sendButton.TabIndex = 5;
            sendButton.Text = "שלח";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(250, 134);
            listView1.Name = "listView1";
            listView1.Size = new Size(488, 244);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(sendButton);
            Controls.Add(label1);
            Controls.Add(dayW);
            Controls.Add(dayM);
            Controls.Add(month);
            Controls.Add(year);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox year;
        private ComboBox month;
        private ComboBox dayM;
        private ComboBox dayW;
        private Label label1;
        private Button sendButton;
        private ListView listView1;
    }
}
