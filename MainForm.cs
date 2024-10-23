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

        }
    }
}
