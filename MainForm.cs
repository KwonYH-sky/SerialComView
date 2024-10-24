using System.IO.Ports;

namespace SerialComView
{
    public partial class MainForm : Form
    {
        private bool isLoopTx;
        private Thread loopTxThread;

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

                selPortName.Enabled = false;
                selBaudRate.Enabled = false;
                selDataBits.Enabled = false;
                selParity.Enabled = false;
                selStopBits.Enabled = false;
                selHandshake.Enabled = false;
                selReadTimeout.Enabled = false;
                selWriteTimeout.Enabled = false;

                openBtn.Enabled = false;
                closeBtn.Enabled = true;

                dataRxRiTextBox.Text = "";
                dataTxGroupBox.Enabled = true;
            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            
            loopTxThread.Interrupt();
            serialPort.Close();
            serialPort.Dispose();

            if (!serialPort.IsOpen)
            {
                portStatusLabel.Text = "Close";
                portStatusLabel.ForeColor = Color.Red;

                selPortName.Enabled = true;
                selBaudRate.Enabled = true;
                selDataBits.Enabled = true;
                selParity.Enabled = true;
                selStopBits.Enabled = true;
                selHandshake.Enabled = true;
                selReadTimeout.Enabled = true;
                selWriteTimeout.Enabled = true;

                openBtn.Enabled = true;
                closeBtn.Enabled = false;

                dataTxGroupBox.Enabled = false;
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
                    isLoopTx = false;
                    loopTxThread.Join();
                    loopTxCheck.Enabled = true;
                    loopTimeTextBox.Enabled = true;
                    dataTxTextBox.Enabled = true;

                    dataSendBtn.Text = "Data Send";
                }

                if (loopTxCheck.Checked)
                {
                    isLoopTx = true;
                    loopTxThread = new Thread(() =>
                    {
                        int loopTime = Convert.ToInt32(loopTimeTextBox.Text);
                        while (isLoopTx)
                        {
                            this.Invoke(new Action(() =>
                            {
                                serialPort.Write(dataTxTextBox.Text);
                                dataRxRiTextBox.SelectionColor = Color.Red;
                                if (!string.IsNullOrEmpty(dataTxTextBox.Text))
                                    dataRxRiTextBox.AppendText(dataTxTextBox.Text);
                            }));

                            Thread.Sleep(loopTime);
                        }
                    });

                    loopTxCheck.Enabled = false;
                    loopTimeTextBox.Enabled = false;
                    dataTxTextBox.Enabled = false;

                    dataSendBtn.Text = "메시지 전송중지";

                    loopTxThread.Start();
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

        private void loopTxCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (loopTxCheck.Checked)
                loopTimeTextBox.Enabled = true;
            else
                loopTimeTextBox.Enabled = false;
        }
    }
}
