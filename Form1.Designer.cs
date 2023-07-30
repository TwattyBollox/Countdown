namespace Countdown
{
    partial class CountDownTimer
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timerlabel = new Label();
            ResetButton = new Button();
            StopButton = new Button();
            StartButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            minslabel = new Label();
            secslabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "New Day In:";
            // 
            // timerlabel
            // 
            timerlabel.AutoSize = true;
            timerlabel.Location = new Point(66, 34);
            timerlabel.Name = "timerlabel";
            timerlabel.Size = new Size(77, 15);
            timerlabel.TabIndex = 1;
            timerlabel.Text = "1260 seconds";
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(83, 137);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(43, 23);
            ResetButton.TabIndex = 2;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(107, 108);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(46, 23);
            StopButton.TabIndex = 3;
            StopButton.Text = "Pause";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(58, 108);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(46, 23);
            StartButton.TabIndex = 4;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            // 
            // minslabel
            // 
            minslabel.AutoSize = true;
            minslabel.Location = new Point(82, 68);
            minslabel.Name = "minslabel";
            minslabel.Size = new Size(19, 15);
            minslabel.TabIndex = 5;
            minslabel.Text = "21";
            // 
            // secslabel
            // 
            secslabel.AutoSize = true;
            secslabel.Location = new Point(107, 68);
            secslabel.Name = "secslabel";
            secslabel.Size = new Size(19, 15);
            secslabel.TabIndex = 6;
            secslabel.Text = "00";
            // 
            // CountDownTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(209, 170);
            Controls.Add(secslabel);
            Controls.Add(minslabel);
            Controls.Add(StartButton);
            Controls.Add(StopButton);
            Controls.Add(ResetButton);
            Controls.Add(timerlabel);
            Controls.Add(label1);
            Name = "CountDownTimer";
            Text = "Valheim Timer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label timerlabel;
        private Button ResetButton;
        private Button StopButton;
        private Button StartButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer1;
        private Label minslabel;
        private Label secslabel;
    }
}