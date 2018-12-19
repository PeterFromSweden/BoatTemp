using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet.Sftp;
using Renci.SshNet.Common;
using Renci.SshNet;
using System.IO;
using BoatTempCheck.Properties;

namespace WindowsFormsApp1
{
    public partial class BoatTempCheck : Form
    {
        public BoatTempCheck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearText();
            Application.DoEvents();

            try
            {
                float temp;
                float hygroPerc;
                List<string> sensorStrings;
                List<string> sensorPaths = new List<string>() {
                    @"/tmp/fineoffset.temperaturehumidity.135.tmp",
                    @"/tmp/fineoffset.temperaturehumidity.199.tmp",
                    @"/tmp/mandolyn.temperaturehumidity.11.tmp",
                    @"/tmp/fineoffset.temperaturehumidity.135.action.log",
                    @"/tmp/fineoffset.temperaturehumidity.135.2.action.log",
                    @"/tmp/fineoffset.temperaturehumidity.135.3.action.log",
                };
                //string tempStr = "-2.6°	68%     	                    	                    	2018-11-26 15:39:54";

                sensorStrings = SshAttempt(sensorPaths);
                ParseSensor(sensorStrings[0], out temp, out hygroPerc);
                aGauge1.Value = temp;
                txtTmpBoat.Text = temp.ToString();
                txtHygBoat.Text = hygroPerc + "%";

                ParseSensor(sensorStrings[1], out temp, out hygroPerc);
                aGauge2.Value = temp;
                txtTmpShed.Text = temp.ToString();
                txtHy1Shed.Text = hygroPerc + "%";

                ParseSensor(sensorStrings[2], out temp, out hygroPerc);
                aGauge3.Value = temp;
                txtHeatBox.Text = temp.ToString();
                txtHy2Shed.Text = hygroPerc + "%";

                textBox1.Text = Tail(sensorStrings[3]);
                textBox2.Text = Tail(sensorStrings[4]);
                textBox3.Text = Tail(sensorStrings[5]);
                //timer1.Enabled = true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void ParseSensor(string sensorString, out float temp, out float hygroPerc)
        {
            //temp = 0.0F;
            //hygroPerc = 0.0F;

            sensorString = System.Text.RegularExpressions.Regex.Replace(sensorString, @"\s+", " ");
            string[] sensorParts = sensorString.Split(null);
            string tempStr = new string((from c in sensorParts[0]
                                            where char.IsNumber(c) || char.IsPunctuation(c)
                                            select c).ToArray());
            float.TryParse(tempStr, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out temp);
            string hygroStr = new string((from c in sensorParts[1]
                                            where char.IsNumber(c)
                                            select c).ToArray());
            float.TryParse(hygroStr, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out hygroPerc);
        }

        private string Tail(string inputStr)
        {
            var reader = new StringReader(inputStr);
            string[] cacheOfThree = new string[3];
            int ix = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                cacheOfThree[ix] = line;
                ix = (ix + 1) % 3; // Next
                line = reader.ReadLine();
            }
            string res = "";
            // ix is at oldest already
            res += cacheOfThree[ix] + Environment.NewLine;
            ix = (ix + 1) % 3; // Next
            res += cacheOfThree[ix] + Environment.NewLine;
            ix = (ix + 1) % 3; // Next
            res += cacheOfThree[ix] + Environment.NewLine;
            return res;
        }

        private List<string> SshAttempt(List<string> sensorPaths)
        {
            List<string> res = new List<string>();

            var connectionInfo = new ConnectionInfo("liedholm.dynamic-dns.net",
                                                    2210,
                                                    "pi",
                                                    new PrivateKeyAuthenticationMethod("pi", new PrivateKeyFile(Settings.Default.opensshppk)));
            using (var client = new ScpClient(connectionInfo))
            {
                client.Connect();
                foreach (string sensorPath in sensorPaths)
                {
                    using (var stream = new MemoryStream())
                    {
                        client.Download(sensorPath, stream);
                        res.Add(Encoding.UTF8.GetString(stream.ToArray()));
                        Console.WriteLine(res.Last());
                    }
                }
            }

            return res;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            aGauge1.Value += 1;
            if (aGauge1.Value >= 40)
                aGauge1.Value = -40;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //openFileDialog1.FileName = Properties.Settings.Default.opensshppk;
            openFileDialog1.FileName = Settings.Default.opensshppk;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.opensshppk = openFileDialog1.FileName;
                Settings.Default.Save();
            }
        }

        private void BoatTempCheck_Load(object sender, EventArgs e)
        {
            ClearText();
        }

        private void ClearText()
        {
            txtTmpBoat.Text = "";
            txtHygBoat.Text = "";
            txtTmpShed.Text = "";
            txtHy1Shed.Text = "";
            txtHeatBox.Text = "";
            txtHy2Shed.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

    }
}
