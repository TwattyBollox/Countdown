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
            daynightlabel = new Label();
            ResetButton = new Button();
            StopButton = new Button();
            StartButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            minslabel = new Label();
            secslabel = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // daynightlabel
            // 
            daynightlabel.AutoSize = true;
            daynightlabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            daynightlabel.Location = new Point(0, 0);
            daynightlabel.Name = "daynightlabel";
            daynightlabel.Size = new Size(97, 21);
            daynightlabel.TabIndex = 0;
            daynightlabel.Text = "Valheim Day";
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(132, 22);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(46, 23);
            ResetButton.TabIndex = 2;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(132, 43);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(46, 23);
            StopButton.TabIndex = 3;
            StopButton.Text = "Pause";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(132, 1);
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
            minslabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            minslabel.Location = new Point(17, 31);
            minslabel.Name = "minslabel";
            minslabel.Size = new Size(28, 21);
            minslabel.TabIndex = 5;
            minslabel.Text = "30";
            // 
            // secslabel
            // 
            secslabel.AutoSize = true;
            secslabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            secslabel.Location = new Point(44, 31);
            secslabel.Name = "secslabel";
            secslabel.Size = new Size(28, 21);
            secslabel.TabIndex = 6;
            secslabel.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(39, 34);
            label2.Name = "label2";
            label2.Size = new Size(10, 15);
            label2.TabIndex = 7;
            label2.Text = ":";
            // 
            // CountDownTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(210, 74);
            Controls.Add(label2);
            Controls.Add(secslabel);
            Controls.Add(minslabel);
            Controls.Add(StartButton);
            Controls.Add(StopButton);
            Controls.Add(ResetButton);
            Controls.Add(daynightlabel);
            Name = "CountDownTimer";
            Text = "Valheim Timer";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label daynightlabel;
        private Button ResetButton;
        private Button StopButton;
        private Button StartButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer1;
        private Label minslabel;
        private Label secslabel;
        private Label label2;
    }
}