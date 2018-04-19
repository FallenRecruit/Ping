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
using System.Diagnostics;

namespace Ping_Monitor
{
    public partial class Form1 : Form
    {
        List<int?> pingList1;
        List<int?> pingList2;

        public Form1()
        {
            InitializeComponent();

            pingList1 = new List<int?> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            pingList2 = new List<int?> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Location = Properties.Settings.Default.Location;
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
            Thread pingThread4 = new Thread(PingJupiter);
            pingThread4.IsBackground = true;
            pingThread4.Start();
            Thread pingThread5 = new Thread(PingSaturn);
            pingThread5.IsBackground = true;
            pingThread5.Start();
            Thread pingThread6 = new Thread(PingMurcury);
            pingThread6.IsBackground = true;
            pingThread6.Start();
            Thread pingThread7 = new Thread(PingVenus);
            pingThread7.IsBackground = true;
            pingThread7.Start();
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
                    tOut88.Invoke((MethodInvoker)(() => tOut88.Text = (Convert.ToInt16(tOut88.Text) + 1).ToString()));
                }
                else { ping88Lab.Invoke((MethodInvoker)(() => ping88Lab.Text = reply.RoundtripTime.ToString())); }

                Thread.Sleep(200);
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
                    tOut44.Invoke((MethodInvoker)(() => tOut44.Text = (Convert.ToInt16(tOut44.Text) + 1).ToString()));
                }
                else { ping44Lab.Invoke((MethodInvoker)(() => ping44Lab.Text = reply.RoundtripTime.ToString())); }

                Thread.Sleep(200);
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
                    tOutLt.Invoke((MethodInvoker)(() => tOutLt.Text = (Convert.ToInt16(tOutLt.Text) + 1).ToString()));
                }
                else { pingLauntelLab.Invoke((MethodInvoker)(() => pingLauntelLab.Text = reply.RoundtripTime.ToString())); }

                Thread.Sleep(200);
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

                Thread.Sleep(200);
            }
        }
        private void PingJupiter()
        {
            string host = "jupiter.launtel.net.au";
            IPAddress ip = null;
            GetResolvedConnecionIPAddress(host, out ip);
            host = ip.ToString();

            Ping pinger = new Ping();
            while (true)
            {
                PingReply reply = pinger.Send(host);
                if (reply.RoundtripTime == 0)
                {
                    tOutJu.Invoke((MethodInvoker)(() => tOutJu.Text = (Convert.ToInt16(tOutJu.Text) + 1).ToString()));
                }
                else { pingJupiterLab.Invoke((MethodInvoker)(() => pingJupiterLab.Text = reply.RoundtripTime.ToString())); }

                Thread.Sleep(200);
            }
        }
        private void PingSaturn()
        {
            string host = "saturn.launtel.net.au";
            IPAddress ip = null;
            GetResolvedConnecionIPAddress(host, out ip);
            host = ip.ToString();

            Ping pinger = new Ping();
            while (true)
            {
                PingReply reply = pinger.Send(host);
                if (reply.RoundtripTime == 0)
                {
                    tOutSa.Invoke((MethodInvoker)(() => tOutSa.Text = (Convert.ToInt16(tOutSa.Text) + 1).ToString()));
                }
                else { pingSaturnLab.Invoke((MethodInvoker)(() => pingSaturnLab.Text = reply.RoundtripTime.ToString())); }

                Thread.Sleep(200);
            }
        }
        private void PingMurcury()
        {
            string host = "mercury.launtel.net.au";
            IPAddress ip = null;
            GetResolvedConnecionIPAddress(host, out ip);
            host = ip.ToString();

            Ping pinger = new Ping();
            while (true)
            {
                PingReply reply = pinger.Send(host);
                if (reply.RoundtripTime == 0)
                {
                    tOutMe.Invoke((MethodInvoker)(() => tOutMe.Text = (Convert.ToInt16(tOutMe.Text) + 1).ToString()));
                }
                else { pingMercuryLab.Invoke((MethodInvoker)(() => pingMercuryLab.Text = reply.RoundtripTime.ToString())); }

                Thread.Sleep(200);
            }
        }
        private void PingVenus()
        {
            string host = "venus.launtel.net.au";
            IPAddress ip = null;
            GetResolvedConnecionIPAddress(host, out ip);
            host = ip.ToString();

            Ping pinger = new Ping();
            while (true)
            {
                PingReply reply = pinger.Send(host);
                if (reply.RoundtripTime == 0)
                {
                    tOutVe.Invoke((MethodInvoker)(() => tOutVe.Text = (Convert.ToInt16(tOutVe.Text) + 1).ToString()));
                }
                else { pingVenusLab.Invoke((MethodInvoker)(() => pingVenusLab.Text = reply.RoundtripTime.ToString())); }

                Thread.Sleep(200);
            }
        }

        public static bool GetResolvedConnecionIPAddress(string serverNameOrURL, out IPAddress resolvedIPAddress)
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
            if (average < 75)  { avLab.ForeColor = Color.Lime;  }
            else if (average < 100) { avLab.ForeColor = Color.Orange; }
            else if (average < 250) { avLab.ForeColor = Color.Red;    }
            avLab.Text = average.ToString();

            average = (Convert.ToInt16(pingMirrorLab.Text) + Convert.ToInt16(pingJupiterLab.Text) + Convert.ToInt16(pingSaturnLab.Text) + Convert.ToInt16(pingMercuryLab.Text) + Convert.ToInt16(pingVenusLab.Text)) / 5;
            if (average < 75) { avLab2.ForeColor = Color.Lime; }
            else if (average < 100) { avLab2.ForeColor = Color.Orange; }
            else if (average < 250) { avLab2.ForeColor = Color.Red; }
            avLab2.Text = average.ToString();

            pingList1.RemoveAt(0); // Remove the item at index 1
            pingList1.Add(Convert.ToInt32(avLab.Text)); // Add a null to the end of the list

            pingList2.RemoveAt(0); // Remove the item at index 1
            pingList2.Add(Convert.ToInt32(avLab2.Text)); // Add a null to the end of the list

            int max = 0;
            int min = 0;

            max = Convert.ToInt32(pingList1.Max());
            min = Convert.ToInt32(pingList1.Min());

            jitLab1.Text = max - min + "±";

            max = Convert.ToInt32(pingList2.Max());
            min = Convert.ToInt32(pingList2.Min());

            jitLab2.Text = max - min + "±";

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Location = Location;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tOut44.Text = "0";
            tOut88.Text = "0";
            tOutLt.Text = "0";
            tOutMi.Text = "0";
            tOutJu.Text = "0";
            tOutSa.Text = "0";
            tOutMe.Text = "0";
            tOutVe.Text = "0";
        }
    }
}
