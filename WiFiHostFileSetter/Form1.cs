using NativeWifi;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NativeWifi.Wlan;

namespace WiFiHostFileSetter
{
    public partial class Form1 : Form
    {
        WlanClient wlan = new WlanClient();
        bool listening = false;
        Settings settings;

        bool once = true;


        WlanInterfaceState wlanState = WlanInterfaceState.Disconnected;
        string currentSsid = "";

        const string defaultHost = @"# This is a sample HOSTS file
#
# Comments (such as these) may be inserted on individual
# lines or following the machine name denoted by a '#' symbol.
#
# For example:
#
#      102.54.94.97     rhino.acme.com          # source server
#       38.25.63.10     x.acme.com              # x client host

# localhost name resolution is handled within DNS itself.
#	127.0.0.1       localhost
#	::1             localhost";

        public Form1()
        {
            InitializeComponent();

            /// Try load settings from disk
            Settings s = new Settings().Load();

            if (s == null)
                settings = new Settings();
            else
                settings = s;

            hostFileEditor.Text = defaultHost;

            /// Populate UI from settings file
            wlanCombobox.Text = settings.networkInterface;
            intervalUpDown.Value = settings.interval;
            askChk.Checked = settings.askBeforeSwitch;
            autoStartChk.Checked = settings.autoStart;
            startHidden.Checked = settings.startHidden;

            watchdog.Interval = 1000 * settings.interval;

            if (settings.autoStart)
            {
                enableBtn_Click(null, null);
            }
            
            if (settings.hosts.Keys.Count > 0)
                ssidList.Text = settings.hosts.Keys.ElementAt(0);
        }

        private void enableBtn_Click(object sender, EventArgs e)
        {
            listening = !listening;
            enableBtn.Enabled = false;

            if (listening)
                watchdog.Start();
            else
                watchdog.Stop();
        }


        private void wlanCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wlanCombobox.Text == "")
                enableBtn.Enabled = false;
            else
                enableBtn.Enabled = true;

            settings.networkInterface = wlanCombobox.Text;
            settings.Save();
        }

        private void intervalUpDown_ValueChanged(object sender, EventArgs e)
        {
            settings.interval = Convert.ToInt32(intervalUpDown.Value);
            settings.Save();
        }

        private void ssidList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool exists = false;
            foreach (KeyValuePair<string, string> p in settings.hosts)
            {
                if (p.Key == ssidList.Text)
                {
                    hostFileEditor.Text = p.Value;
                    exists = true;
                }
            }

            if (!exists)
            {
                settings.hosts.Add(ssidList.Text, hostFileEditor.Text);
                settings.Save();
            }
        }


        private void watchdog_Tick(object sender, EventArgs e)
        {
            /// Get the interface state
            WlanInterfaceState state = WlanInterfaceState.Disconnected;
            String ssid = "";

            foreach (WlanClient.WlanInterface wlanInterface in wlan.Interfaces)
            {
                if ($"{wlanInterface.InterfaceName} ({wlanInterface.InterfaceDescription})" == settings.networkInterface)
                {
                    try
                    {
                        ssid = wlanInterface.CurrentConnection.profileName;
                        state = wlanInterface.CurrentConnection.isState;
                    }
                    catch (Exception ex) { }
                }
            }

            bool updateHost = false;

            if (currentSsid != ssid)
                updateHost = true;
            else if (wlanState != state)
                updateHost = true;

            if (updateHost && state == WlanInterfaceState.Connected)
            {
                watchdog.Stop();

                bool update = true;
                if (!settings.hosts.ContainsKey(ssid))
                {
                    DialogResult res = MessageBox.Show($"The current SSID does not have a host config yet, should we create one now?", "WiFi Connection changed", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (res == DialogResult.Yes)
                    {
                        settings.hosts.Add(ssid, defaultHost);
                        settings.Save();

                        uiUpdater_Tick(null, null);
                        update = true;
                    }
                    else
                        update = false;
                }
                else if (settings.askBeforeSwitch)
                {
                    DialogResult res = MessageBox.Show($"The SSID or status has changed\nCurrent SSID is {ssid} and the connection status is {state}\nWas {currentSsid} | {wlanState}\n\nSwitch host file?", "WiFi Connection changed", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    
                    if (res == DialogResult.No)
                        update = false;
                }

                if (update)
                {
                    /// Update host file >>
                    try
                    {
                        File.WriteAllText(@"C:\Windows\System32\drivers\etc\hosts", settings.hosts[ssid]);

                        notifyIcon1.Text = $"Using host file for SSID {ssid}";

                        notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                        notifyIcon1.BalloonTipText = $"Host file has succesfully been applied.\nNow using host file for SSID {ssid}";
                        notifyIcon1.BalloonTipTitle = "Host file applied";

                        notifyIcon1.ShowBalloonTip(1000);
                    }
                    catch (UnauthorizedAccessException uaex)
                    {
                        MessageBox.Show("Failed to update host file!\nMake sure this program is running with admin rights!");
                    }
                }

                currentSsid = ssid;
                wlanState = state;

                watchdog.Start();
                GC.Collect();
            }
        }

        private void autoStartChk_CheckedChanged(object sender, EventArgs e)
        {
            settings.autoStart = autoStartChk.Checked;
            settings.Save();
        }

        private void askChk_CheckedChanged(object sender, EventArgs e)
        {
            settings.askBeforeSwitch = askChk.Checked;
            settings.Save();
        }

        private void uiUpdater_Tick(object sender, EventArgs e)
        {
            if (uiUpdater.Interval == 100)
            {
                uiUpdater.Interval = 5000;

                if (settings.startHidden)
                    this.Hide();
            }

            wlanCombobox.Items.Clear();
            ssidList.Items.Clear();

            WlanInterfaceState state = WlanInterfaceState.Disconnected;
            String ssid = "";

            /// Update interface & SSID list
            foreach (WlanClient.WlanInterface wlanInterface in wlan.Interfaces)
            {
                wlanCombobox.Items.Add($"{wlanInterface.InterfaceName} ({wlanInterface.InterfaceDescription})");

                /// Get the interface state
                if ($"{wlanInterface.InterfaceName} ({wlanInterface.InterfaceDescription})" == settings.networkInterface)
                {
                    try
                    {
                        ssid = wlanInterface.CurrentConnection.profileName;
                        state = wlanInterface.CurrentConnection.isState;
                    }
                    catch (Exception ex) { }
                }
            }

            /// Load any missing SSID's from settings file
            if (settings.hosts != null)
                foreach (KeyValuePair<String, String> s in settings.hosts)
                {
                    if (!ssidList.Items.Contains(s.Key))
                    {
                        ssidList.Items.Add(s.Key);
                    }
                }

            /// Make sure we have a selected interface that exists
            if (!wlanCombobox.Items.Contains(wlanCombobox.Text))
            {
                wlanCombobox.Text = "";
            }


            /// Update misc labels and visibilities
            statusLabel.Text = !listening ? $"Status: Idle (WLAN: {ssid} {state.ToString()})" : $"Status: Running (WLAN: {ssid} {state.ToString()})";
            enableBtn.Text = !listening ? "Start" : "Stop";

            if (wlanCombobox.Text == "")
                enableBtn.Enabled = false;
            else
                enableBtn.Enabled = true;

            settingsBox.Enabled = !listening;

            if (once)
            { ssidList.Text = currentSsid; once = false; }
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            if (applyBtn.Enabled)
            {
                /// Update host file >>
                try
                {
                    File.WriteAllText(@"C:\Windows\System32\drivers\etc\hosts", hostFileEditor.Text);

                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.BalloonTipText = "Host file has succesfully been applied.";
                    notifyIcon1.BalloonTipTitle = "Host file applied";

                    notifyIcon1.ShowBalloonTip(1000);
                }
                catch (IOException ioex)
                {
                    MessageBox.Show("Failed to update host file!\nMake sure this program is running with admin rights!");
                }

                hostFileEditor_TextChanged(null, null);
            }
        }

        private void saveApplyBtn_Click(object sender, EventArgs e)
        {
            if (saveApplyBtn.Enabled)
            {
                settings.hosts[ssidList.Text] = hostFileEditor.Text;
                settings.Save();

                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "Host file has succesfully been saved.";
                notifyIcon1.BalloonTipTitle = "Host file saved";

                notifyIcon1.ShowBalloonTip(1000);

                hostFileEditor_TextChanged(null, null);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.Visible)
                this.Hide();
            else
                this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Visible)
                this.Hide();
            else
                this.Show();
        }

        private void hostFileEditor_TextChanged(object sender, EventArgs e)
        {
            if (settings.hosts.ContainsKey(ssidList.Text) && hostFileEditor.Text != settings.hosts[ssidList.Text])
                saveApplyBtn.Enabled = true;
            else
                saveApplyBtn.Enabled = false;

            if (File.ReadAllText(@"C:\Windows\System32\drivers\etc\hosts") != hostFileEditor.Text)
                applyBtn.Enabled = true;
            else
                applyBtn.Enabled = false;
        }

        private void startHidden_CheckedChanged(object sender, EventArgs e)
        {
            settings.startHidden = startHidden.Checked;
            settings.Save();
        }
    }
}
