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
            float temp;
            float hygroPerc;
            List<string> sensorStrings;
            List<string> sensorPaths = new List<string>() {
                @"/tmp/fineoffset.temperaturehumidity.135.tmp",
                @"/tmp/fineoffset.temperaturehumidity.199.tmp",
                @"/tmp/mandolyn.temperaturehumidity.11.tmp"
            };
            //string tempStr = "-2.6°	68%     	                    	                    	2018-11-26 15:39:54";

            sensorStrings = sshAttempt(sensorPaths);
            parseSensor(sensorStrings[0], out temp, out hygroPerc);
            aGauge1.Value = temp;
            txtTmpBoat.Text = temp.ToString();
            txtHygBoat.Text = hygroPerc + "%";

            parseSensor(sensorStrings[1], out temp, out hygroPerc);
            aGauge2.Value = temp;
            txtTmpShed.Text = temp.ToString();
            txtHy1Shed.Text = hygroPerc + "%";

            parseSensor(sensorStrings[2], out temp, out hygroPerc);
            aGauge3.Value = temp;
            txtHeatBox.Text = temp.ToString();
            txtHy2Shed.Text = hygroPerc + "%";
            
            //timer1.Enabled = true;
        }

        private void parseSensor(string sensorString, out float temp, out float hygroPerc)
        {
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

        private List<string> sshAttempt(List<string> sensorPaths)
        {
            List<string> res = new List<string>();

            try
            {
                var connectionInfo = new ConnectionInfo("liedholm.dynamic-dns.net",
                                                        2210,
                                                        "pi",
                                                        new PrivateKeyAuthenticationMethod("pi", new PrivateKeyFile("c:\\openssh.ppk")));
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
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
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

    }
}
