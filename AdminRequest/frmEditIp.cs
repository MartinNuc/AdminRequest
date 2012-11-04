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

namespace AdminRequest
{
    public partial class frmEditIp : Form
    {
        public String Username { get; set; }
        public IPAddress Ip { get; set; }
        public PhysicalAddress Mac { get; set; }

        public bool EditMode { get; set; }

        public frmEditIp()
        {
            EditMode = true;
            InitializeComponent();
        }

        private void frmEditIp_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Username;
            if (Mac != null)
            {
                MacAddrConvertable macVariable = new MacAddrConvertable(Mac.GetAddressBytes());
                macMac.Text = macVariable.Address;
            }
            if (Ip != null)
                ipAddress.IPAddress = Ip;

            if (EditMode == false)
                btnAdd.Text = "Přidat";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Username = txtUsername.Text;
            Ip = ipAddress.IPAddress;
            MacAddrConvertable macVariable = new MacAddrConvertable();
            macVariable.Address = macMac.Text;
            Mac = macVariable.ConvertToPhysicalAddress();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
