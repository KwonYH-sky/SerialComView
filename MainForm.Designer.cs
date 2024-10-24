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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            selPortName = new ComboBox();
            serialGroupBox = new GroupBox();
            portStatusLabel = new Label();
            closeBtn = new Button();
            openBtn = new Button();
            writeTimeOutLabel = new Label();
            selWriteTimeout = new ComboBox();
            readTimeoutLabel = new Label();
            selReadTimeout = new ComboBox();
            handshakeLabel = new Label();
            selHandshake = new ComboBox();
            stopBitsLabel = new Label();
            selStopBits = new ComboBox();
            parityLabel = new Label();
            selParity = new ComboBox();
            dataBitsLabel = new Label();
            selDataBits = new ComboBox();
            baudRateLabel = new Label();
            selBaudRate = new ComboBox();
            portNmLabel = new Label();
            dataRxRiTextBox = new RichTextBox();
            dataRxGrupBox = new GroupBox();
            dataTxGroupBox = new GroupBox();
            loopTimeTextBox = new TextBox();
            loopTxCheck = new CheckBox();
            dataSendBtn = new Button();
            dataTxTextBox = new TextBox();
            serialGroupBox.SuspendLayout();
            dataRxGrupBox.SuspendLayout();
            dataTxGroupBox.SuspendLayout();
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
            serialGroupBox.Controls.Add(portStatusLabel);
            serialGroupBox.Controls.Add(closeBtn);
            serialGroupBox.Controls.Add(openBtn);
            serialGroupBox.Controls.Add(writeTimeOutLabel);
            serialGroupBox.Controls.Add(selWriteTimeout);
            serialGroupBox.Controls.Add(readTimeoutLabel);
            serialGroupBox.Controls.Add(selReadTimeout);
            serialGroupBox.Controls.Add(handshakeLabel);
            serialGroupBox.Controls.Add(selHandshake);
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
            // portStatusLabel
            // 
            portStatusLabel.AutoSize = true;
            portStatusLabel.Font = new Font("맑은 고딕", 16F);
            portStatusLabel.Location = new Point(81, 315);
            portStatusLabel.Name = "portStatusLabel";
            portStatusLabel.Size = new Size(67, 30);
            portStatusLabel.TabIndex = 17;
            portStatusLabel.Text = "Close";
            // 
            // closeBtn
            // 
            closeBtn.Enabled = false;
            closeBtn.Location = new Point(117, 386);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(112, 34);
            closeBtn.TabIndex = 16;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // openBtn
            // 
            openBtn.Location = new Point(6, 386);
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(105, 34);
            openBtn.TabIndex = 2;
            openBtn.Text = "Open";
            openBtn.UseVisualStyleBackColor = true;
            openBtn.Click += openBtn_Click;
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
            selWriteTimeout.Items.AddRange(new object[] { "500" });
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
            selReadTimeout.Items.AddRange(new object[] { "500" });
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
            // selHandshake
            // 
            selHandshake.DropDownStyle = ComboBoxStyle.DropDownList;
            selHandshake.FormattingEnabled = true;
            selHandshake.Items.AddRange(new object[] { "None", "XOnXOff", "RequestToSend", "RequestToSendXOnXOff" });
            selHandshake.Location = new Point(99, 167);
            selHandshake.Name = "selHandshake";
            selHandshake.Size = new Size(124, 23);
            selHandshake.TabIndex = 10;
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
            selStopBits.Items.AddRange(new object[] { "One", "Two", "OnePointFive (특정 기기 호환안됨)" });
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
            selParity.Items.AddRange(new object[] { "None", "Odd", "Even", "Mark", "Spec" });
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
            // dataRxRiTextBox
            // 
            dataRxRiTextBox.Location = new Point(16, 22);
            dataRxRiTextBox.Name = "dataRxRiTextBox";
            dataRxRiTextBox.Size = new Size(371, 284);
            dataRxRiTextBox.TabIndex = 18;
            dataRxRiTextBox.Text = "";
            // 
            // dataRxGrupBox
            // 
            dataRxGrupBox.Controls.Add(dataRxRiTextBox);
            dataRxGrupBox.Location = new Point(272, 12);
            dataRxGrupBox.Name = "dataRxGrupBox";
            dataRxGrupBox.Size = new Size(405, 323);
            dataRxGrupBox.TabIndex = 19;
            dataRxGrupBox.TabStop = false;
            dataRxGrupBox.Text = "데이터";
            // 
            // dataTxGroupBox
            // 
            dataTxGroupBox.Controls.Add(loopTimeTextBox);
            dataTxGroupBox.Controls.Add(loopTxCheck);
            dataTxGroupBox.Controls.Add(dataSendBtn);
            dataTxGroupBox.Controls.Add(dataTxTextBox);
            dataTxGroupBox.Enabled = false;
            dataTxGroupBox.Location = new Point(272, 341);
            dataTxGroupBox.Name = "dataTxGroupBox";
            dataTxGroupBox.Size = new Size(405, 97);
            dataTxGroupBox.TabIndex = 20;
            dataTxGroupBox.TabStop = false;
            dataTxGroupBox.Text = "데이터 보내기";
            // 
            // loopTimeTextBox
            // 
            loopTimeTextBox.Enabled = false;
            loopTimeTextBox.Location = new Point(336, 22);
            loopTimeTextBox.Name = "loopTimeTextBox";
            loopTimeTextBox.Size = new Size(51, 23);
            loopTimeTextBox.TabIndex = 20;
            // 
            // loopTxCheck
            // 
            loopTxCheck.AutoSize = true;
            loopTxCheck.Location = new Point(274, 24);
            loopTxCheck.Name = "loopTxCheck";
            loopTxCheck.Size = new Size(56, 19);
            loopTxCheck.TabIndex = 19;
            loopTxCheck.Text = "반복?";
            loopTxCheck.UseVisualStyleBackColor = true;
            loopTxCheck.CheckedChanged += loopTxCheck_CheckedChanged;
            // 
            // dataSendBtn
            // 
            dataSendBtn.Location = new Point(16, 57);
            dataSendBtn.Name = "dataSendBtn";
            dataSendBtn.Size = new Size(371, 34);
            dataSendBtn.TabIndex = 1;
            dataSendBtn.Text = "Data Send";
            dataSendBtn.UseVisualStyleBackColor = true;
            dataSendBtn.Click += DataSendBtn_ClickEvent;
            // 
            // dataTxTextBox
            // 
            dataTxTextBox.Location = new Point(16, 22);
            dataTxTextBox.Name = "dataTxTextBox";
            dataTxTextBox.Size = new Size(219, 23);
            dataTxTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 450);
            Controls.Add(dataTxGroupBox);
            Controls.Add(serialGroupBox);
            Controls.Add(dataRxGrupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "SerialComView";
            Load += MainForm_Load;
            serialGroupBox.ResumeLayout(false);
            serialGroupBox.PerformLayout();
            dataRxGrupBox.ResumeLayout(false);
            dataTxGroupBox.ResumeLayout(false);
            dataTxGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox selPortName;
        private GroupBox serialGroupBox;
        private Label portNmLabel;
        private Label readTimeoutLabel;
        private ComboBox selReadTimeout;
        private Label handshakeLabel;
        private ComboBox selHandshake;
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
        private Button openBtn;
        private Button closeBtn;
        private Label portStatusLabel;
        private RichTextBox dataRxRiTextBox;
        private GroupBox dataRxGrupBox;
        private GroupBox dataTxGroupBox;
        private Button dataSendBtn;
        private TextBox dataTxTextBox;
        private CheckBox loopTxCheck;
        private TextBox loopTimeTextBox;
    }
}
