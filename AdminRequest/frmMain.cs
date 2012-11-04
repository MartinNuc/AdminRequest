using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using ISEAGE.May610.Diagrammer;
using System.IO;

namespace AdminRequest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGenerateIp_Click(object sender, EventArgs e)
        {
            listIpAddresses.Items.Clear();
            IPAddress SpecificIp;
            int StationsCount;
            try
            {
                SpecificIp = new IPAddress(ipFirst.GetAddressBytes());
                if (int.TryParse(txtStationCount.Text, out StationsCount) == false)
                    MessageBox.Show("Unable to parse station count.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            IPAddress Mask = SubnetMask.CreateByHostNumber(StationsCount);
            IPAddress FirstIp = IPAddressExtensions.GetNetworkAddress(SpecificIp, Mask);
            IPAddress LastIp = IPAddressExtensions.GetBroadcastAddress(SpecificIp, Mask);

            string BinaryHosts = Convert.ToString(StationsCount, 2);
            int IpCountInMask = (int) Math.Pow(2, BinaryHosts.Length);
            if (BinaryHosts.Contains('0') == false)
                IpCountInMask*=2;
            FirstIp = IPAddressExtensions.Increment(FirstIp); // first IP after network address
            for (int i = 0; i < IpCountInMask - 2; i++)
            {
                listIpAddresses.Items.Add(new IpListItem(txtUsername.Text, FirstIp, GetChosenMac()));

                // move to next IP
                FirstIp = IPAddressExtensions.Increment(FirstIp);
            }
        }

        private void btnAddIp_Click(object sender, EventArgs e)
        {
            frmEditIp frmEdit = new frmEditIp();
            frmEdit.EditMode = false;
            frmEdit.Username = txtUsername.Text;
            frmEdit.Mac = GetChosenMac();
            var result = frmEdit.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
                listIpAddresses.Items.Add(new IpListItem(frmEdit.Username, frmEdit.Ip, frmEdit.Mac));

        }

        private void DisableRadioButtons()
        {
            macClient.Enabled = false;
            macRouterPTP.Enabled = false;
            macRouter.Enabled = false;
            txtSwitchName.Enabled = false;

            ipPTP.Enabled = false;
        }

        private void radioTransparentRouter_CheckedChanged(object sender, EventArgs e)
        {
            DisableRadioButtons();
            macRouter.Enabled = true;
        }

        private void radioPTP_CheckedChanged(object sender, EventArgs e)
        {
            DisableRadioButtons();
            macRouterPTP.Enabled = true;
            ipPTP.Enabled = true;
        }

        private void radioSwitch_CheckedChanged(object sender, EventArgs e)
        {
            DisableRadioButtons();
            txtSwitchName.Enabled = true;
        }

        private void radioClient_CheckedChanged(object sender, EventArgs e)
        {
            DisableRadioButtons();
            macClient.Enabled = true;
        }

        private PhysicalAddress GetChosenMac()
        {
            if (radioClient.Checked)
            {
                MacAddrConvertable macVariable = new MacAddrConvertable();
                macVariable.Address = macClient.Text;
                return macVariable.ConvertToPhysicalAddress();
            }
            else if (radioPTP.Checked)
            {
                MacAddrConvertable macVariable = new MacAddrConvertable();
                macVariable.Address = macRouterPTP.Text;
                return macVariable.ConvertToPhysicalAddress();
            }
            else if (radioSwitch.Checked)
            {
                return null;
            }
            else if (radioTransparentRouter.Checked)
            {
                MacAddrConvertable macVariable = new MacAddrConvertable();
                macVariable.Address = macRouter.Text;
                return macVariable.ConvertToPhysicalAddress();
            }
            else
                throw new Exception("Not any of options");
        }

        private void btnEditIp_Click(object sender, EventArgs e)
        {
            if (listIpAddresses.SelectedItems.Count == 0)
                return;

            IpListItem item = (IpListItem) listIpAddresses.SelectedItem;
            
            frmEditIp frmEdit = new frmEditIp();
            frmEdit.Username = item.Username;
            frmEdit.Mac = item.Mac;
            frmEdit.Ip = item.Ip;
            var result = frmEdit.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                item.Ip = frmEdit.Ip;
                item.Username = frmEdit.Username;
                item.Mac = frmEdit.Mac;
                int index = listIpAddresses.SelectedIndex;
                listIpAddresses.Items.RemoveAt(index);
                listIpAddresses.Items.Insert(index, item);
            }

        }

        private void btnRemoveIp_Click(object sender, EventArgs e)
        {
            if (listIpAddresses.SelectedItems.Count > 0)
            {
                List<int> IndexesToRemove = new List<int>();
                foreach (int li in listIpAddresses.SelectedIndices)
                    IndexesToRemove.Add(li);
                foreach (int index in IndexesToRemove)
                    listIpAddresses.Items.RemoveAt(index);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
                a) NODE-datum-RangesWifi.csv
                b) NODE-datum-RangesPtP.csv
                c) NODE-datum-IPs.csv 
             */

            string OutputPath;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                OutputPath = folderBrowserDialog1.SelectedPath;
                DateTime date = DateTime.Now;

                if (radioClient.Checked)
                {
                    int StationsCount;
                    if (int.TryParse(txtStationCount.Text, out StationsCount) == false)
                    {
                        MessageBox.Show("Unable to parse station count.");
                        return;
                    }
                    /***************************************************************************/
                    // a) ranges wifi
                    string RangesWifiFilename = txtNode.Text + "-" + date.ToString("yyyyMMdd") + "-RangesWifi.csv";
                    StreamWriter file = new StreamWriter(Path.Combine(OutputPath, RangesWifiFilename));

                    IPAddress Mask = SubnetMask.CreateByHostNumber(StationsCount);
                    file.WriteLine(txtUsername.Text + ";"
                        + IPAddressExtensions.GetNetworkAddress(ipFirst.IPAddress, Mask) + "/" + SubnetMask.GetMaskBits(StationsCount) + ";"
                        + new MacAddrConvertable(macClient.Text)
                        + ";client");
                    file.Close();

                    /***************************************************************************/
                    // c) wifi client
                    string IPsFilename = txtNode.Text + "-" + date.ToString("yyyyMMdd") + "-IPs.csv";
                    file = new StreamWriter(Path.Combine(OutputPath, IPsFilename));
                    writeClientIps(file);
                    file.Close();
                }
                else if (radioPTP.Checked)
                {
                    int StationsCount;
                    if (int.TryParse(txtStationCount.Text, out StationsCount) == false)
                    {
                        MessageBox.Show("Unable to parse station count.");
                        return;
                    }

                    // ptp router
                    /***************************************************************************/
                    // a) NODE-datum-RangesWifi.csv
                    string RangesWifiFilename = txtNode.Text + "-" + date.ToString("yyyyMMdd") + "-RangesWifi.csv";
                    StreamWriter file = new StreamWriter(Path.Combine(OutputPath, RangesWifiFilename));
                    IPAddress Mask = SubnetMask.CreateByHostNumber(StationsCount);
                    file.WriteLine(txtUsername.Text + ";"
                        + IPAddressExtensions.GetNetworkAddress(ipFirst.IPAddress, Mask) + "/" + SubnetMask.GetMaskBits(StationsCount) + ";"
                        + new MacAddrConvertable(macClient.Text)
                        + ";client");
                    file.Close();

                    /***************************************************************************/
                    // b) ptp range
                    string RangesPtPFilename = txtNode.Text + "-" + date.ToString("yyyyMMdd") + "-RangesPtP.csv";
                    file = new StreamWriter(Path.Combine(OutputPath, RangesPtPFilename));

                    IPAddress PTPMask = SubnetMask.CreateByHostNumber(2);
                    IPAddress NetworkAddress = IPAddressExtensions.GetNetworkAddress(ipPTP.IPAddress, PTPMask);
                    // user ip range
                    IPAddress SpecificIp = new IPAddress(ipFirst.GetAddressBytes());
                    int NetworkMaskBits = SubnetMask.GetMaskBits(StationsCount);

                    IPAddress UsersNetwork = IPAddressExtensions.GetNetworkAddress(SpecificIp, Mask);
                    file.WriteLine(txtUsername.Text + ";"
                        + NetworkAddress + "/30" + ";"
                        + UsersNetwork + "/" + NetworkMaskBits);
                    file.Close();
                    /***************************************************************************/
                    // c) IPs
                    string IPsFilename = txtNode.Text + "-" + date.ToString("yyyyMMdd") + "-IPs.csv";
                    file = new StreamWriter(Path.Combine(OutputPath, IPsFilename));
                    writeClientIps(file);
                    file.Close();
                    /***************************************************************************/ 
                }
                else if (radioSwitch.Checked)
                {
                    /***************************************************************************/
                    // c) IPs
                    string IPsFilename = txtNode.Text + "-" + date.ToString("yyyyMMdd") + "-IPs.csv";
                    StreamWriter file = new StreamWriter(Path.Combine(OutputPath, IPsFilename));
                    foreach (IpListItem li in listIpAddresses.Items)
                        file.WriteLine(li.Username + ";" + li.Ip + ";" + new MacAddrConvertable(li.Mac) + ";" + txtSwitchName.Text);
                    file.Close();
                }
                else if (radioTransparentRouter.Checked)
                {
                    int StationsCount;
                    if (int.TryParse(txtStationCount.Text, out StationsCount) == false)
                    {
                        MessageBox.Show("Unable to parse station count.");
                        return;
                    }
                    // transparent router
                    /***************************************************************************/
                    // a) ranges wifi
                    string RangesWifiFilename = txtNode.Text + "-" + date.ToString("yyyyMMdd") + "-RangesWifi.csv";
                    StreamWriter file = new StreamWriter(Path.Combine(OutputPath, RangesWifiFilename));
                    IPAddress Mask = SubnetMask.CreateByHostNumber(StationsCount);
                    file.WriteLine(txtUsername.Text + ";"
                        + IPAddressExtensions.GetNetworkAddress(ipFirst.IPAddress, Mask) + "/" + SubnetMask.GetMaskBits(StationsCount) + ";"
                        + new MacAddrConvertable(macClient.Text)
                        + ";client");
                    file.Close();

                    /***************************************************************************/
                    // c) wifi client
                    string IPsFilename = txtNode.Text + "-" + date.ToString("yyyyMMdd") + "-IPs.csv";
                    file = new StreamWriter(Path.Combine(OutputPath, IPsFilename));
                    writeClientIps(file);
                    file.Close();
                }

            }
        }

        private void writeClientIps(StreamWriter Stream)
        {
            foreach (IpListItem li in listIpAddresses.Items)
                Stream.WriteLine(li.Username + ";" + li.Ip + ";" + new MacAddrConvertable(li.Mac));
        }
    }
}
