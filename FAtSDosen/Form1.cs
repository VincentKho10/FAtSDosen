using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAtSDosen
{
    public partial class Form1 : Form
    {
        List<Task> tasks = new List<Task>();
        List<String> kehadiran;
        List<String> jadwal = new List<string>{"Pemrogramman Berorientasi Objek 2 Kelas_A", "Bahasa Indonesia Kelas_C", "Fenomologi Agama Kelas_B" };
        bool isWaiting = true;
        Process process = new Process {
            StartInfo =
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                FileName = "cmd.exe"
            }
        };
        private static readonly HttpClient client = new HttpClient();
        ThreadStart runPRef;
        Thread childPThread;
        ThreadStart runNetRef;
        Thread childNetThread;
        string ssid;
        string pass;
        private bool netIsUp;

        public Form1()
        {
            InitializeComponent();
            cbJadwal.DataSource = jadwal;
        }

        //private static async Task<String> ssidRepositories()
        //{
        //    client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Add("User-Agent",".NET Foundation Repository Reporter");
        //    var stringTask = client.GetStringAsync("https://www.passwordrandom.com/query?command=password&count=1&format=plain&scheme=CNCNNC#NNcc");

        //    var msg = await stringTask;
        //    return msg;
        //}

        private static async Task<String> randRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
            var stringTask = client.GetStringAsync("https://www.passwordrandom.com/query?command=password&count=1&format=plain&scheme=CvNvNNvCcvvCCNvcCVvNV#NNcc");

            var msg = await stringTask;
            return msg;
        }

        private void runPresensi()
        {
            isWaiting = true;
            while (isWaiting)
            {
                Thread.Sleep(5000);
                process.StartInfo.Arguments = "/C netsh wlan show hostednetwork | findstr /r /c:\"[^ ]:[^ ]\"";
                process.Start();

                string outpcmd = process.StandardOutput.ReadToEnd();
                List<String> splitting = Regex.Split(outpcmd,Environment.NewLine).ToList<String>();

                //if(outpcmd == "")
                //{
                //    netIsUp = false;
                //}
                //else
                //{
                //    netIsUp = true;
                //}

                if (kehadiran == null)
                {
                    kehadiran = splitting;
                    startQRPresensi();
                }
                else
                {
                    Console.WriteLine("hit");
                    if (splitting.Count > 2)
                    {
                        splitting.RemoveAt(splitting.Count() - 1);
                    }
                    kehadiran = kehadiran.Union(splitting).ToList<String>();

                    lsHosted.DataSource = kehadiran;
                }
                //Console.WriteLine(res.Value);
                //if (res.Value!="")
                //{
                //    lsHosted.Items.Add(res.Value);
                //    lsHosted.Refresh();
                //}
            }
        }

        private void btnPresensi_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("its a hit");
            //string strCmdText;
            //strCmdText = "/c echo Hello World";
            //System.Diagnostics.Process process = System.Diagnostics.Process.Start("CMD.exe", strCmdText);

            createShowQRPresensi();
            runPRef = new ThreadStart(runPresensi);
            childPThread = new Thread(runPRef);
            childPThread.Start();
            //runNetRef = new ThreadStart(checkNetConn);
            //childNetThread = new Thread(runNetRef);
            //childNetThread.Start();
        }

        //private void checkNetConn()
        //{
        //    isWaiting = true;
        //    while (isWaiting)
        //    {
        //        Thread.Sleep(5000);
        //        if (netIsUp)
        //        {
        //            netStatus.Text = "Connected";
        //            netStatus.ForeColor = Color.Green;
        //        }
        //        else
        //        {
        //            netStatus.Text = "Disconnected";
        //            netStatus.ForeColor = Color.Red;
        //            startQRPresensi();
        //        }
        //    }
        //}

        private async void createShowQRPresensi()
        {
            ssid = await randRepositories();
            pass = await randRepositories();
            startQRPresensi();
        }

        private void startQRPresensi()
        {
            process.StartInfo.Arguments = "/C netsh wlan set hostednetwork mode=allow ssid=" + ssid + " key=" + pass + " | netsh wlan start hostednetwork";
            process.Start();
            pbQrcode.ImageLocation = "http://api.qrserver.com/v1/create-qr-code/?data=" + ssid + ", " + pass + "&size=200x200";
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            childPThread.Abort();
            //childNetThread.Abort();
            isWaiting = false;
            childPThread.Abort();
            process.StartInfo.Arguments = "/C netsh wlan stop hostednetwork";
            process.Start();
            kehadiran.Clear();
        }
    }
}
