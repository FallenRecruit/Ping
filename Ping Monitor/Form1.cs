using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;

namespace Ping_Monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Location = Properties.Settings.Default.Location;
            //https://youtu.be/8mjqXiggWNc?t=529
            Thread pingThread0 = new Thread(Ping88);
            pingThread0.IsBackground = true;
            pingThread0.Start();
            Thread pingThread1 = new Thread(Ping44);
            pingThread1.IsBackground = true;
            pingThread1.Start();
            Thread pingThread2 = new Thread(PingLauntel);
            pingThread2.IsBackground = true;
            pingThread2.Start();
            Thread pingThread3 = new Thread(PingMirror);
            pingThread3.IsBackground = true;
            pingThread3.Start();

        }

        private void Ping88()
        {

            string host = "8.8.8.8";
            Ping pinger = new Ping();
            while (true)
            {
                PingReply reply = pinger.Send(host);
                if (reply.RoundtripTime == 0)
                {
                    tOut88.Invoke((MethodInvoker)(() => tOut88.Text = (Convert.ToInt16(tOutMi.Text) + 1).ToString()));
                }
                else { ping88Lab.Invoke((MethodInvoker)(() => ping88Lab.Text = reply.RoundtripTime.ToString())); }

                Thread.Sleep(100);
            }
        }
        private void Ping44()
        {
            string host = "8.8.4.4";
            Ping pinger = new Ping();
            while (true)
            {
                PingReply reply = pinger.Send(host);
                if (reply.RoundtripTime == 0)
                {
                    tOut44.Invoke((MethodInvoker)(() => tOut44.Text = (Convert.ToInt16(tOutMi.Text) + 1).ToString()));
                }
                else { ping44Lab.Invoke((MethodInvoker)(() => ping44Lab.Text = reply.RoundtripTime.ToString())); }

                Thread.Sleep(100);
            }
        }
        private void PingLauntel()
        {
            string host = "launtel.net.au";
            IPAddress ip = null;
            GetResolvedConnecionIPAddress(host, out ip);
            host = ip.ToString();

            Ping pinger = new Ping();
            while (true)
            {
                PingReply reply = pinger.Send(host);
                if (reply.RoundtripTime == 0)
                {
                    tOutLt.Invoke((MethodInvoker)(() => tOutLt.Text = (Convert.ToInt16(tOutMi.Text) + 1).ToString()));
                }
                else { pingLauntelLab.Invoke((MethodInvoker)(() => pingLauntelLab.Text = reply.RoundtripTime.ToString())); }

                Thread.Sleep(100);
            }
        }
        private void PingMirror()
        {
            string host = "mirror.launtel.net.au";
            IPAddress ip = null;
            GetResolvedConnecionIPAddress(host, out ip);
            host = ip.ToString();

            Ping pinger = new Ping();
            while (true)
            {
                PingReply reply = pinger.Send(host);
                if (reply.RoundtripTime == 0)
                {
                    tOutMi.Invoke((MethodInvoker)(() => tOutMi.Text = (Convert.ToInt16(tOutMi.Text) + 1).ToString()));
                }
                else { pingMirrorLab.Invoke((MethodInvoker)(() => pingMirrorLab.Text = reply.RoundtripTime.ToString())); }
  
                Thread.Sleep(1000);
            }
        }

        public static bool GetResolvedConnecionIPAddress(string serverNameOrURL,
                   out IPAddress resolvedIPAddress)
        {
            bool isResolved = false;
            IPHostEntry hostEntry = null;
            IPAddress resolvIP = null;
            try
            {
                if (!IPAddress.TryParse(serverNameOrURL, out resolvIP))
                {
                    hostEntry = Dns.GetHostEntry(serverNameOrURL);

                    if (hostEntry != null && hostEntry.AddressList != null
                                 && hostEntry.AddressList.Length > 0)
                    {
                        if (hostEntry.AddressList.Length == 1)
                        {
                            resolvIP = hostEntry.AddressList[0];
                            isResolved = true;
                        }
                        else
                        {
                            foreach (IPAddress var in hostEntry.AddressList)
                            {
                                if (var.AddressFamily == AddressFamily.InterNetwork)
                                {
                                    resolvIP = var;
                                    isResolved = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    isResolved = true;
                }
            }
            catch (Exception ex)
            {
                isResolved = false;
                resolvIP = null;
            }
            finally
            {
                resolvedIPAddress = resolvIP;
            }

            return isResolved;
        }

        private void averageTimer_Tick(object sender, EventArgs e)
        {
            int average = 0;
            average = (Convert.ToInt16(ping88Lab.Text) + Convert.ToInt16(ping44Lab.Text) + Convert.ToInt16(pingLauntelLab.Text)) / 3;
            if      (average < 75)  { avLab.ForeColor = Color.Lime;  }
            else if (average < 100) { avLab.ForeColor = Color.Orange; }
            else if (average < 250) { avLab.ForeColor = Color.Red;    }
            avLab.Text = average.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Location = Location;
            Properties.Settings.Default.Save();
        }
    }
}
