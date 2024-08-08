namespace ip_config {
    partial class MainFrm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.adapterCombo = new System.Windows.Forms.ComboBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.refListBtn = new System.Windows.Forms.Button();
            this.txtMask = new System.Windows.Forms.TextBox();
            this.txtGate = new System.Windows.Forms.TextBox();
            this.txtDnsSecond = new System.Windows.Forms.TextBox();
            this.txtDnsFirst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dhcpBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBit = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.advBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(281, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(697, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // adapterCombo
            // 
            this.adapterCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adapterCombo.FormattingEnabled = true;
            this.adapterCombo.Location = new System.Drawing.Point(6, 19);
            this.adapterCombo.Name = "adapterCombo";
            this.adapterCombo.Size = new System.Drawing.Size(164, 21);
            this.adapterCombo.Sorted = true;
            this.adapterCombo.TabIndex = 10;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(101, 47);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(100, 20);
            this.txtIp.TabIndex = 1;
            // 
            // refListBtn
            // 
            this.refListBtn.Location = new System.Drawing.Point(176, 17);
            this.refListBtn.Name = "refListBtn";
            this.refListBtn.Size = new System.Drawing.Size(75, 23);
            this.refListBtn.TabIndex = 11;
            this.refListBtn.Text = "Refresh";
            this.refListBtn.UseVisualStyleBackColor = true;
            this.refListBtn.Click += new System.EventHandler(this.refListBtn_Click);
            // 
            // txtMask
            // 
            this.txtMask.Location = new System.Drawing.Point(101, 75);
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(150, 20);
            this.txtMask.TabIndex = 2;
            this.txtMask.Enter += new System.EventHandler(this.txtMask_Enter);
            // 
            // txtGate
            // 
            this.txtGate.Location = new System.Drawing.Point(101, 101);
            this.txtGate.Name = "txtGate";
            this.txtGate.Size = new System.Drawing.Size(150, 20);
            this.txtGate.TabIndex = 3;
            this.txtGate.Enter += new System.EventHandler(this.txtGate_Enter);
            // 
            // txtDnsSecond
            // 
            this.txtDnsSecond.Location = new System.Drawing.Point(101, 171);
            this.txtDnsSecond.Name = "txtDnsSecond";
            this.txtDnsSecond.Size = new System.Drawing.Size(150, 20);
            this.txtDnsSecond.TabIndex = 5;
            // 
            // txtDnsFirst
            // 
            this.txtDnsFirst.Location = new System.Drawing.Point(101, 145);
            this.txtDnsFirst.Name = "txtDnsFirst";
            this.txtDnsFirst.Size = new System.Drawing.Size(150, 20);
            this.txtDnsFirst.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Subnet Mask:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Default Gateway:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Primary DNS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Secondary DNS:";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.dhcpBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBit);
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.advBtn);
            this.groupBox1.Controls.Add(this.adapterCombo);
            this.groupBox1.Controls.Add(this.txtIp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.refListBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMask);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDnsFirst);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDnsSecond);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 239);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // dhcpBtn
            // 
            this.dhcpBtn.Location = new System.Drawing.Point(101, 197);
            this.dhcpBtn.Name = "dhcpBtn";
            this.dhcpBtn.Size = new System.Drawing.Size(69, 23);
            this.dhcpBtn.TabIndex = 17;
            this.dhcpBtn.Text = "DHCP";
            this.dhcpBtn.UseVisualStyleBackColor = true;
            this.dhcpBtn.Click += new System.EventHandler(this.dhcpBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "/";
            // 
            // txtBit
            // 
            this.txtBit.Location = new System.Drawing.Point(226, 47);
            this.txtBit.Name = "txtBit";
            this.txtBit.Size = new System.Drawing.Size(25, 20);
            this.txtBit.TabIndex = 8;
            this.txtBit.Text = "24";
            this.txtBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(176, 197);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // advBtn
            // 
            this.advBtn.Location = new System.Drawing.Point(9, 197);
            this.advBtn.Name = "advBtn";
            this.advBtn.Size = new System.Drawing.Size(86, 23);
            this.advBtn.TabIndex = 7;
            this.advBtn.Text = "Advanced";
            this.advBtn.UseVisualStyleBackColor = true;
            this.advBtn.Click += new System.EventHandler(this.advBtn_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 274);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Text = "IP Config Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox adapterCombo;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Button refListBtn;
        private System.Windows.Forms.TextBox txtMask;
        private System.Windows.Forms.TextBox txtGate;
        private System.Windows.Forms.TextBox txtDnsSecond;
        private System.Windows.Forms.TextBox txtDnsFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button advBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBit;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button dhcpBtn;
    }
}

