using NodaTime;
using NodaTime.Text;
using System.IO.Ports;
using System.Linq.Expressions;

namespace Controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Logs.Text += Environment.NewLine + "User entered - ";
            Time(Logs);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Logs.Text += Environment.NewLine + "Red button pressed - ";
            Time(Logs);
            try
            {
                send_to_chip("r");
            }
            catch (Exception ex)
            {
                Logs.Text += Environment.NewLine + "Error - " + ex.ToString();

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Logs.Text += Environment.NewLine + "Blue Button pressed - ";
            Time(Logs);
            try
            {
                send_to_chip("b");
            }
            catch (Exception ex)
            {
                Logs.Text += Environment.NewLine + "Error - " + ex.ToString();

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Logs.Text += Environment.NewLine + "All buttons were shut - ";
            Time(Logs);
            try
            {
                send_to_chip("x");
            }
            catch (Exception ex)
            {
                Logs.Text += Environment.NewLine + "Error - " + ex.ToString();

            }
        }

        static void Time(TextBox Logs)
        {
            Instant now = SystemClock.Instance.GetCurrentInstant();
            DateTimeZone zone = DateTimeZoneProviders.Tzdb["Europe/Moscow"];
            ZonedDateTime zonedTime = now.InZone(zone);

            var pattern = ZonedDateTimePattern.CreateWithInvariantCulture(
                "dd.MM.yyyy HH:mm:ss", DateTimeZoneProviders.Tzdb);
            Logs.Text += pattern.Format(zonedTime);
            Logs.SelectionStart = Logs.Text.Length;
            Logs.ScrollToCaret();

        }
        static void send_to_chip(string a)
        {
            SerialPort port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.Write(a);
            port.Close();

        }

        private void Logs_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


