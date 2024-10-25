using System.IO.Ports;

namespace SerialComView
{
    public partial class MainForm : Form
    {
        private bool isLoopTx;
        SerialPort serialPort = new SerialPort();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                selPortName.Items.Add(port);
            }

            selPortName.SelectedIndex = 0;
            selBaudRate.SelectedIndex = 4;
            selDataBits.SelectedIndex = 0;
            selParity.SelectedIndex = 0;
            selStopBits.SelectedIndex = 0;
            selHandshake.SelectedIndex = 0;
            selReadTimeout.SelectedIndex = 0;
            selWriteTimeout.SelectedIndex = 0;

            portStatusLabel.Text = "Close";
            portStatusLabel.ForeColor = Color.Red;

            dataRxRiTextBox.ReadOnly = true;

        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            serialPort.PortName = selPortName.Text;
            serialPort.BaudRate = Convert.ToInt32(selBaudRate.Text);
            serialPort.DataBits = Convert.ToInt32(selDataBits.Text);
            serialPort.Parity = SelParityToParity(selParity.SelectedIndex);
            serialPort.StopBits = SelStopBitsToStopBits(selStopBits.SelectedIndex);
            serialPort.Handshake = SelHandshakeToHandshake(selHandshake.SelectedIndex);
            serialPort.ReadTimeout = Convert.ToInt32(selReadTimeout.Text);
            serialPort.WriteTimeout = Convert.ToInt32(selWriteTimeout.Text);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            try { serialPort.Open(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (serialPort.IsOpen)
            {
                portStatusLabel.Text = "Open";
                portStatusLabel.ForeColor = Color.Green;

                SetControl(false);
                dataRxRiTextBox.Text = "";
            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (loopSendTimer.Enabled)
            {
                StopLoopTransmission();
                loopSendTimer.Dispose();
            }
            serialPort.Close();
            serialPort.Dispose();

            if (!serialPort.IsOpen)
            {
                portStatusLabel.Text = "Close";
                portStatusLabel.ForeColor = Color.Red;
                SetControl(true);
            }
        }


        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();

            this.Invoke(new Action(() =>
            {
                dataRxRiTextBox.SelectionColor = Color.Blue;
                if (!string.IsNullOrEmpty(indata))
                    dataRxRiTextBox.AppendText(indata);
            }));

        }

        private void DataSendBtn_ClickEvent(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                if (isLoopTx)
                {
                    StopLoopTransmission();
                    return;
                }

                if (loopTxCheck.Checked)
                {
                    isLoopTx = true;
                    int loopInterval = Convert.ToInt32(loopTimeTextBox.Text);
                    loopSendTimer.Interval = loopInterval <= 0 ? 10 : loopInterval;
                    loopSendTimer.Start();

                    loopTxCheck.Enabled = false;
                    loopTimeTextBox.Enabled = false;
                    dataTxTextBox.Enabled = false;

                    dataSendBtn.Text = "메시지 전송중지";

                }
                else
                {
                    serialPort.Write(dataTxTextBox.Text);
                    dataRxRiTextBox.SelectionColor = Color.Red;
                    if (!string.IsNullOrEmpty(dataTxTextBox.Text))
                        dataRxRiTextBox.AppendText(dataTxTextBox.Text);
                }
            }
            else
                MessageBox.Show("포트 닫혀있음", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void loopTxCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (loopTxCheck.Checked)
                loopTimeTextBox.Enabled = true;
            else
                loopTimeTextBox.Enabled = false;
        }

        private void loopSendTimer_Tick(object sender, EventArgs e)
        {
            this.Invoke(() =>
            {
                serialPort.Write(dataTxTextBox.Text);
                dataRxRiTextBox.SelectionColor = Color.Red;
                if (!string.IsNullOrEmpty(dataTxTextBox.Text))
                    dataRxRiTextBox.AppendText(dataTxTextBox.Text);
            });
        }

        private void loopTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            int loopInterval = Convert.ToInt32(loopTimeTextBox.Text);
            loopTimeTextBox.Text = loopInterval <= 0 ? "10" : loopInterval.ToString();
        }

        private void StopLoopTransmission()
        {
            isLoopTx = false;
            loopSendTimer.Stop();
            loopTxCheck.Enabled = true;
            loopTimeTextBox.Enabled = true;
            dataTxTextBox.Enabled = true;

            dataSendBtn.Text = "Data Send";
            return;
        }

        public static Parity SelParityToParity(int selIndex) => selIndex switch
        {
            0 => Parity.None,
            1 => Parity.Odd,
            2 => Parity.Even,
            3 => Parity.Mark,
            4 => Parity.Space,
            _ => Parity.None,
        };

        public static StopBits SelStopBitsToStopBits(int selIndex) => selIndex switch
        {
            0 => StopBits.One,
            1 => StopBits.Two,
            2 => StopBits.OnePointFive,
            _ => StopBits.One,
        };

        public static Handshake SelHandshakeToHandshake(int selIndex) => selIndex switch
        {
            0 => Handshake.None,
            1 => Handshake.RequestToSend,
            2 => Handshake.RequestToSendXOnXOff,
            3 => Handshake.XOnXOff,
            _ => Handshake.None,
        };

        private void SetControl(bool isClose)
        {
            selPortName.Enabled = isClose;
            selBaudRate.Enabled = isClose;
            selDataBits.Enabled = isClose;
            selParity.Enabled = isClose;
            selStopBits.Enabled = isClose;
            selHandshake.Enabled = isClose;
            selReadTimeout.Enabled = isClose;
            selWriteTimeout.Enabled = isClose;

            openBtn.Enabled = isClose;
            closeBtn.Enabled = !isClose;

            dataTxGroupBox.Enabled = !isClose;
        }

    }
}
