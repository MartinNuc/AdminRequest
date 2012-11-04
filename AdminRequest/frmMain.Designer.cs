namespace AdminRequest
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listIpAddresses = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateIp = new System.Windows.Forms.Button();
            this.btnEditIp = new System.Windows.Forms.Button();
            this.btnRemoveIp = new System.Windows.Forms.Button();
            this.lblFirstIp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtStationCount = new System.Windows.Forms.TextBox();
            this.txtNode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ipPTP = new IPAddressControlLib.IPAddressControl();
            this.macRouter = new ISEAGE.May610.Diagrammer.matb();
            this.label6 = new System.Windows.Forms.Label();
            this.macRouterPTP = new ISEAGE.May610.Diagrammer.matb();
            this.label7 = new System.Windows.Forms.Label();
            this.macClient = new ISEAGE.May610.Diagrammer.matb();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioClient = new System.Windows.Forms.RadioButton();
            this.radioSwitch = new System.Windows.Forms.RadioButton();
            this.radioPTP = new System.Windows.Forms.RadioButton();
            this.radioTransparentRouter = new System.Windows.Forms.RadioButton();
            this.btnAddIp = new System.Windows.Forms.Button();
            this.ipFirst = new IPAddressControlLib.IPAddressControl();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSwitchName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // listIpAddresses
            // 
            this.listIpAddresses.FormattingEnabled = true;
            this.listIpAddresses.Location = new System.Drawing.Point(417, 113);
            this.listIpAddresses.Name = "listIpAddresses";
            this.listIpAddresses.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listIpAddresses.Size = new System.Drawing.Size(252, 264);
            this.listIpAddresses.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP uzivatele:";
            // 
            // btnGenerateIp
            // 
            this.btnGenerateIp.Location = new System.Drawing.Point(557, 54);
            this.btnGenerateIp.Name = "btnGenerateIp";
            this.btnGenerateIp.Size = new System.Drawing.Size(96, 23);
            this.btnGenerateIp.TabIndex = 13;
            this.btnGenerateIp.Text = "Generovat IP";
            this.btnGenerateIp.UseVisualStyleBackColor = true;
            this.btnGenerateIp.Click += new System.EventHandler(this.btnGenerateIp_Click);
            // 
            // btnEditIp
            // 
            this.btnEditIp.Location = new System.Drawing.Point(675, 142);
            this.btnEditIp.Name = "btnEditIp";
            this.btnEditIp.Size = new System.Drawing.Size(75, 23);
            this.btnEditIp.TabIndex = 16;
            this.btnEditIp.Text = "Upravit";
            this.btnEditIp.UseVisualStyleBackColor = true;
            this.btnEditIp.Click += new System.EventHandler(this.btnEditIp_Click);
            // 
            // btnRemoveIp
            // 
            this.btnRemoveIp.Location = new System.Drawing.Point(675, 171);
            this.btnRemoveIp.Name = "btnRemoveIp";
            this.btnRemoveIp.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveIp.TabIndex = 17;
            this.btnRemoveIp.Text = "Odstranit";
            this.btnRemoveIp.UseVisualStyleBackColor = true;
            this.btnRemoveIp.Click += new System.EventHandler(this.btnRemoveIp_Click);
            // 
            // lblFirstIp
            // 
            this.lblFirstIp.AutoSize = true;
            this.lblFirstIp.Location = new System.Drawing.Point(302, 31);
            this.lblFirstIp.Name = "lblFirstIp";
            this.lblFirstIp.Size = new System.Drawing.Size(108, 13);
            this.lblFirstIp.TabIndex = 6;
            this.lblFirstIp.Text = "Jedna z IP z rozsahu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Počet stanic (vcetne AP):";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(124, 56);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(131, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtStationCount
            // 
            this.txtStationCount.Location = new System.Drawing.Point(417, 56);
            this.txtStationCount.Name = "txtStationCount";
            this.txtStationCount.Size = new System.Drawing.Size(134, 20);
            this.txtStationCount.TabIndex = 12;
            // 
            // txtNode
            // 
            this.txtNode.Location = new System.Drawing.Point(124, 27);
            this.txtNode.Name = "txtNode";
            this.txtNode.Size = new System.Drawing.Size(131, 20);
            this.txtNode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Node:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSwitchName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ipPTP);
            this.groupBox1.Controls.Add(this.macRouter);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.macRouterPTP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.macClient);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.radioClient);
            this.groupBox1.Controls.Add(this.radioSwitch);
            this.groupBox1.Controls.Add(this.radioPTP);
            this.groupBox1.Controls.Add(this.radioTransparentRouter);
            this.groupBox1.Location = new System.Drawing.Point(36, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 295);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pripojeni";
            // 
            // ipPTP
            // 
            this.ipPTP.AllowInternalTab = false;
            this.ipPTP.AutoHeight = true;
            this.ipPTP.BackColor = System.Drawing.SystemColors.Window;
            this.ipPTP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipPTP.Enabled = false;
            this.ipPTP.Location = new System.Drawing.Point(150, 148);
            this.ipPTP.MinimumSize = new System.Drawing.Size(87, 20);
            this.ipPTP.Name = "ipPTP";
            this.ipPTP.ReadOnly = false;
            this.ipPTP.Size = new System.Drawing.Size(168, 20);
            this.ipPTP.TabIndex = 9;
            this.ipPTP.Text = "10.26..";
            // 
            // macRouter
            // 
            this.macRouter.BackColor = System.Drawing.SystemColors.Window;
            this.macRouter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.macRouter.Location = new System.Drawing.Point(150, 50);
            this.macRouter.Name = "macRouter";
            this.macRouter.Size = new System.Drawing.Size(168, 22);
            this.macRouter.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "MAC routeru:";
            // 
            // macRouterPTP
            // 
            this.macRouterPTP.BackColor = System.Drawing.SystemColors.Window;
            this.macRouterPTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.macRouterPTP.Enabled = false;
            this.macRouterPTP.Location = new System.Drawing.Point(150, 120);
            this.macRouterPTP.Name = "macRouterPTP";
            this.macRouterPTP.Size = new System.Drawing.Size(168, 22);
            this.macRouterPTP.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "MAC klienta:";
            // 
            // macClient
            // 
            this.macClient.BackColor = System.Drawing.SystemColors.Window;
            this.macClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.macClient.Enabled = false;
            this.macClient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.macClient.Location = new System.Drawing.Point(150, 251);
            this.macClient.Name = "macClient";
            this.macClient.Size = new System.Drawing.Size(168, 22);
            this.macClient.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "MAC klienta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "IP z PTP rozsahu:";
            // 
            // radioClient
            // 
            this.radioClient.AutoSize = true;
            this.radioClient.Location = new System.Drawing.Point(17, 230);
            this.radioClient.Name = "radioClient";
            this.radioClient.Size = new System.Drawing.Size(97, 17);
            this.radioClient.TabIndex = 6;
            this.radioClient.Text = "Primo wifi klient";
            this.radioClient.UseVisualStyleBackColor = true;
            this.radioClient.CheckedChanged += new System.EventHandler(this.radioClient_CheckedChanged);
            // 
            // radioSwitch
            // 
            this.radioSwitch.AutoSize = true;
            this.radioSwitch.Location = new System.Drawing.Point(17, 179);
            this.radioSwitch.Name = "radioSwitch";
            this.radioSwitch.Size = new System.Drawing.Size(96, 17);
            this.radioSwitch.TabIndex = 5;
            this.radioSwitch.Text = "Na LAN switch";
            this.radioSwitch.UseVisualStyleBackColor = true;
            this.radioSwitch.CheckedChanged += new System.EventHandler(this.radioSwitch_CheckedChanged);
            // 
            // radioPTP
            // 
            this.radioPTP.AutoSize = true;
            this.radioPTP.Location = new System.Drawing.Point(17, 94);
            this.radioPTP.Name = "radioPTP";
            this.radioPTP.Size = new System.Drawing.Size(104, 17);
            this.radioPTP.TabIndex = 4;
            this.radioPTP.Text = "Pres PTP rozsah";
            this.radioPTP.UseVisualStyleBackColor = true;
            this.radioPTP.CheckedChanged += new System.EventHandler(this.radioPTP_CheckedChanged);
            // 
            // radioTransparentRouter
            // 
            this.radioTransparentRouter.AutoSize = true;
            this.radioTransparentRouter.Checked = true;
            this.radioTransparentRouter.Location = new System.Drawing.Point(17, 27);
            this.radioTransparentRouter.Name = "radioTransparentRouter";
            this.radioTransparentRouter.Size = new System.Drawing.Size(140, 17);
            this.radioTransparentRouter.TabIndex = 3;
            this.radioTransparentRouter.TabStop = true;
            this.radioTransparentRouter.Text = "Pres transparentni router";
            this.radioTransparentRouter.UseVisualStyleBackColor = true;
            this.radioTransparentRouter.CheckedChanged += new System.EventHandler(this.radioTransparentRouter_CheckedChanged);
            // 
            // btnAddIp
            // 
            this.btnAddIp.Location = new System.Drawing.Point(675, 113);
            this.btnAddIp.Name = "btnAddIp";
            this.btnAddIp.Size = new System.Drawing.Size(75, 23);
            this.btnAddIp.TabIndex = 15;
            this.btnAddIp.Text = "Pridat IP";
            this.btnAddIp.UseVisualStyleBackColor = true;
            this.btnAddIp.Click += new System.EventHandler(this.btnAddIp_Click);
            // 
            // ipFirst
            // 
            this.ipFirst.AllowInternalTab = false;
            this.ipFirst.AutoHeight = true;
            this.ipFirst.BackColor = System.Drawing.SystemColors.Window;
            this.ipFirst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipFirst.Location = new System.Drawing.Point(416, 27);
            this.ipFirst.MinimumSize = new System.Drawing.Size(87, 20);
            this.ipFirst.Name = "ipFirst";
            this.ipFirst.ReadOnly = false;
            this.ipFirst.Size = new System.Drawing.Size(135, 20);
            this.ipFirst.TabIndex = 11;
            this.ipFirst.Text = "10.26..";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 38);
            this.button1.TabIndex = 18;
            this.button1.Text = "Vygenerovat soubory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Nazev switche:";
            // 
            // txtSwitchName
            // 
            this.txtSwitchName.Enabled = false;
            this.txtSwitchName.Location = new System.Drawing.Point(150, 200);
            this.txtSwitchName.Name = "txtSwitchName";
            this.txtSwitchName.Size = new System.Drawing.Size(168, 20);
            this.txtSwitchName.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Username:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ipFirst);
            this.Controls.Add(this.btnAddIp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStationCount);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFirstIp);
            this.Controls.Add(this.btnRemoveIp);
            this.Controls.Add(this.btnEditIp);
            this.Controls.Add(this.btnGenerateIp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listIpAddresses);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Admin Request";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listIpAddresses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerateIp;
        private System.Windows.Forms.Button btnEditIp;
        private System.Windows.Forms.Button btnRemoveIp;
        private System.Windows.Forms.Label lblFirstIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtStationCount;
        private System.Windows.Forms.TextBox txtNode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioPTP;
        private System.Windows.Forms.RadioButton radioTransparentRouter;
        private System.Windows.Forms.RadioButton radioSwitch;
        private System.Windows.Forms.Button btnAddIp;
        private System.Windows.Forms.RadioButton radioClient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private IPAddressControlLib.IPAddressControl ipPTP;
        private ISEAGE.May610.Diagrammer.matb macRouter;
        private System.Windows.Forms.Label label6;
        private ISEAGE.May610.Diagrammer.matb macRouterPTP;
        private System.Windows.Forms.Label label7;
        private ISEAGE.May610.Diagrammer.matb macClient;
        private IPAddressControlLib.IPAddressControl ipFirst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSwitchName;
        private System.Windows.Forms.Label label11;
    }
}

