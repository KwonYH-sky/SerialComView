namespace SerialComView
{
    partial class MainForm
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
            selPortName = new ComboBox();
            serialGroupBox = new GroupBox();
            closeBtn = new Button();
            openBth = new Button();
            writeTimeOutLabel = new Label();
            selWriteTimeout = new ComboBox();
            readTimeoutLabel = new Label();
            selReadTimeout = new ComboBox();
            handshakeLabel = new Label();
            selHandShake = new ComboBox();
            stopBitsLabel = new Label();
            selStopBits = new ComboBox();
            parityLabel = new Label();
            selParity = new ComboBox();
            dataBitsLabel = new Label();
            selDataBits = new ComboBox();
            baudRateLabel = new Label();
            selBaudRate = new ComboBox();
            portNmLabel = new Label();
            serialGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // selPortName
            // 
            selPortName.DropDownStyle = ComboBoxStyle.DropDownList;
            selPortName.FormattingEnabled = true;
            selPortName.Location = new Point(99, 22);
            selPortName.Name = "selPortName";
            selPortName.Size = new Size(124, 23);
            selPortName.TabIndex = 0;
            // 
            // serialGroupBox
            // 
            serialGroupBox.Controls.Add(closeBtn);
            serialGroupBox.Controls.Add(openBth);
            serialGroupBox.Controls.Add(writeTimeOutLabel);
            serialGroupBox.Controls.Add(selWriteTimeout);
            serialGroupBox.Controls.Add(readTimeoutLabel);
            serialGroupBox.Controls.Add(selReadTimeout);
            serialGroupBox.Controls.Add(handshakeLabel);
            serialGroupBox.Controls.Add(selHandShake);
            serialGroupBox.Controls.Add(stopBitsLabel);
            serialGroupBox.Controls.Add(selStopBits);
            serialGroupBox.Controls.Add(parityLabel);
            serialGroupBox.Controls.Add(selParity);
            serialGroupBox.Controls.Add(dataBitsLabel);
            serialGroupBox.Controls.Add(selDataBits);
            serialGroupBox.Controls.Add(baudRateLabel);
            serialGroupBox.Controls.Add(selBaudRate);
            serialGroupBox.Controls.Add(portNmLabel);
            serialGroupBox.Controls.Add(selPortName);
            serialGroupBox.Location = new Point(12, 12);
            serialGroupBox.Name = "serialGroupBox";
            serialGroupBox.Size = new Size(235, 426);
            serialGroupBox.TabIndex = 1;
            serialGroupBox.TabStop = false;
            serialGroupBox.Text = "시리얼 정보";
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(117, 386);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(112, 34);
            closeBtn.TabIndex = 16;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            // 
            // openBth
            // 
            openBth.Location = new Point(6, 386);
            openBth.Name = "openBth";
            openBth.Size = new Size(105, 34);
            openBth.TabIndex = 2;
            openBth.Text = "Open";
            openBth.UseVisualStyleBackColor = true;
            openBth.Click += openBtn_Click;
            // 
            // writeTimeOutLabel
            // 
            writeTimeOutLabel.AutoSize = true;
            writeTimeOutLabel.Location = new Point(6, 228);
            writeTimeOutLabel.Name = "writeTimeOutLabel";
            writeTimeOutLabel.Size = new Size(83, 15);
            writeTimeOutLabel.TabIndex = 15;
            writeTimeOutLabel.Text = "쓰기 타임아웃";
            // 
            // selWriteTimeout
            // 
            selWriteTimeout.FormattingEnabled = true;
            selWriteTimeout.Location = new Point(99, 225);
            selWriteTimeout.Name = "selWriteTimeout";
            selWriteTimeout.Size = new Size(124, 23);
            selWriteTimeout.TabIndex = 14;
            // 
            // readTimeoutLabel
            // 
            readTimeoutLabel.AutoSize = true;
            readTimeoutLabel.Location = new Point(6, 199);
            readTimeoutLabel.Name = "readTimeoutLabel";
            readTimeoutLabel.Size = new Size(83, 15);
            readTimeoutLabel.TabIndex = 13;
            readTimeoutLabel.Text = "읽기 타임아웃";
            // 
            // selReadTimeout
            // 
            selReadTimeout.FormattingEnabled = true;
            selReadTimeout.Location = new Point(99, 196);
            selReadTimeout.Name = "selReadTimeout";
            selReadTimeout.Size = new Size(124, 23);
            selReadTimeout.TabIndex = 12;
            // 
            // handshakeLabel
            // 
            handshakeLabel.AutoSize = true;
            handshakeLabel.Location = new Point(6, 170);
            handshakeLabel.Name = "handshakeLabel";
            handshakeLabel.Size = new Size(67, 15);
            handshakeLabel.TabIndex = 11;
            handshakeLabel.Text = "핸드세이크";
            // 
            // selHandShake
            // 
            selHandShake.DropDownStyle = ComboBoxStyle.DropDownList;
            selHandShake.FormattingEnabled = true;
            selHandShake.Location = new Point(99, 167);
            selHandShake.Name = "selHandShake";
            selHandShake.Size = new Size(124, 23);
            selHandShake.TabIndex = 10;
            // 
            // stopBitsLabel
            // 
            stopBitsLabel.AutoSize = true;
            stopBitsLabel.Location = new Point(6, 141);
            stopBitsLabel.Name = "stopBitsLabel";
            stopBitsLabel.Size = new Size(75, 15);
            stopBitsLabel.TabIndex = 9;
            stopBitsLabel.Text = "정지 비트 수";
            // 
            // selStopBits
            // 
            selStopBits.DropDownStyle = ComboBoxStyle.DropDownList;
            selStopBits.FormattingEnabled = true;
            selStopBits.Location = new Point(99, 138);
            selStopBits.Name = "selStopBits";
            selStopBits.Size = new Size(124, 23);
            selStopBits.TabIndex = 8;
            // 
            // parityLabel
            // 
            parityLabel.AutoSize = true;
            parityLabel.Location = new Point(6, 112);
            parityLabel.Name = "parityLabel";
            parityLabel.Size = new Size(43, 15);
            parityLabel.TabIndex = 7;
            parityLabel.Text = "패리티";
            // 
            // selParity
            // 
            selParity.DropDownStyle = ComboBoxStyle.DropDownList;
            selParity.FormattingEnabled = true;
            selParity.Location = new Point(99, 109);
            selParity.Name = "selParity";
            selParity.Size = new Size(124, 23);
            selParity.TabIndex = 6;
            // 
            // dataBitsLabel
            // 
            dataBitsLabel.AutoSize = true;
            dataBitsLabel.Location = new Point(6, 83);
            dataBitsLabel.Name = "dataBitsLabel";
            dataBitsLabel.Size = new Size(71, 15);
            dataBitsLabel.TabIndex = 5;
            dataBitsLabel.Text = "데이터 비트";
            // 
            // selDataBits
            // 
            selDataBits.DropDownStyle = ComboBoxStyle.DropDownList;
            selDataBits.FormattingEnabled = true;
            selDataBits.Items.AddRange(new object[] { "7", "8" });
            selDataBits.Location = new Point(99, 80);
            selDataBits.Name = "selDataBits";
            selDataBits.Size = new Size(124, 23);
            selDataBits.TabIndex = 4;
            // 
            // baudRateLabel
            // 
            baudRateLabel.AutoSize = true;
            baudRateLabel.Location = new Point(6, 54);
            baudRateLabel.Name = "baudRateLabel";
            baudRateLabel.Size = new Size(59, 15);
            baudRateLabel.TabIndex = 3;
            baudRateLabel.Text = "보 레이트";
            // 
            // selBaudRate
            // 
            selBaudRate.DropDownStyle = ComboBoxStyle.DropDownList;
            selBaudRate.FormattingEnabled = true;
            selBaudRate.Items.AddRange(new object[] { "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "56000", "57600", "115200" });
            selBaudRate.Location = new Point(99, 51);
            selBaudRate.Name = "selBaudRate";
            selBaudRate.Size = new Size(124, 23);
            selBaudRate.TabIndex = 2;
            // 
            // portNmLabel
            // 
            portNmLabel.AutoSize = true;
            portNmLabel.Location = new Point(6, 25);
            portNmLabel.Name = "portNmLabel";
            portNmLabel.Size = new Size(59, 15);
            portNmLabel.TabIndex = 1;
            portNmLabel.Text = "포트 이름";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(serialGroupBox);
            Name = "MainForm";
            Text = "SerialComView";
            Load += MainForm_Load;
            serialGroupBox.ResumeLayout(false);
            serialGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox selPortName;
        private GroupBox serialGroupBox;
        private Label portNmLabel;
        private Label readTimeoutLabel;
        private ComboBox selReadTimeout;
        private Label handshakeLabel;
        private ComboBox selHandShake;
        private Label stopBitsLabel;
        private ComboBox selStopBits;
        private Label parityLabel;
        private ComboBox selParity;
        private Label dataBitsLabel;
        private ComboBox selDataBits;
        private Label baudRateLabel;
        private ComboBox selBaudRate;
        private Label writeTimeOutLabel;
        private ComboBox selWriteTimeout;
        private Button openBth;
        private Button closeBtn;
    }
}
