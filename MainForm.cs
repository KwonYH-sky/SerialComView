using System.IO.Ports;

namespace SerialComView
{
    public partial class MainForm : Form
    {
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
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            serialPort.PortName = selPortName.Text;
            serialPort.BaudRate = Convert.ToInt32(selBaudRate.Text);
            serialPort.Parity = SelParityToParity(selParity.SelectedIndex);

        }

        public static Parity SelParityToParity(int selIndex)
        {
            switch (selIndex)
            {
                case 0:
                    return Parity.None;
                case 1:
                    return Parity.Odd;
                case 2:
                    return Parity.Even;
                case 3:
                    return Parity.Mark;
                case 4:
                    return Parity.Space;
                default:
                    return Parity.None;
            }
        }
    }
}
