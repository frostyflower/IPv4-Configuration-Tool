namespace ip_config.Forms {
    partial class AdvIpSetting {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdIPList = new System.Windows.Forms.DataGridView();
            this.ipAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subnetMasks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defGateways = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metrics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGate = new System.Windows.Forms.TextBox();
            this.txtMask = new System.Windows.Forms.TextBox();
            this.txtMetric = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.txtBit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOctet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.adapterCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.refListBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdIPList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdIPList
            // 
            this.grdIPList.AllowUserToAddRows = false;
            this.grdIPList.AllowUserToResizeColumns = false;
            this.grdIPList.AllowUserToResizeRows = false;
            this.grdIPList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdIPList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdIPList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdIPList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdIPList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdIPList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ipAddress,
            this.subnetMasks,
            this.defGateways,
            this.metrics});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdIPList.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdIPList.Location = new System.Drawing.Point(12, 123);
            this.grdIPList.Name = "grdIPList";
            this.grdIPList.RowHeadersVisible = false;
            this.grdIPList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.grdIPList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdIPList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdIPList.ShowCellToolTips = false;
            this.grdIPList.ShowEditingIcon = false;
            this.grdIPList.ShowRowErrors = false;
            this.grdIPList.Size = new System.Drawing.Size(460, 226);
            this.grdIPList.TabIndex = 15;
            // 
            // ipAddress
            // 
            this.ipAddress.HeaderText = "IP Addresses";
            this.ipAddress.Name = "ipAddress";
            // 
            // subnetMasks
            // 
            this.subnetMasks.HeaderText = "Subnet Masks";
            this.subnetMasks.Name = "subnetMasks";
            // 
            // defGateways
            // 
            this.defGateways.HeaderText = "Gateways";
            this.defGateways.Name = "defGateways";
            // 
            // metrics
            // 
            this.metrics.HeaderText = "Metrics";
            this.metrics.Name = "metrics";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(91, 39);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(120, 20);
            this.txtIp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "IP Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Subnet Mask:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Gateway:";
            // 
            // txtGate
            // 
            this.txtGate.Location = new System.Drawing.Point(91, 97);
            this.txtGate.Name = "txtGate";
            this.txtGate.Size = new System.Drawing.Size(120, 20);
            this.txtGate.TabIndex = 3;
            this.txtGate.Enter += new System.EventHandler(this.txtGate_Enter);
            // 
            // txtMask
            // 
            this.txtMask.Location = new System.Drawing.Point(91, 69);
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(120, 20);
            this.txtMask.TabIndex = 2;
            this.txtMask.Enter += new System.EventHandler(this.txtMask_Enter);
            // 
            // txtMetric
            // 
            this.txtMetric.Location = new System.Drawing.Point(259, 67);
            this.txtMetric.Name = "txtMetric";
            this.txtMetric.Size = new System.Drawing.Size(25, 20);
            this.txtMetric.TabIndex = 5;
            this.txtMetric.Text = "1";
            this.txtMetric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Metric:";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(397, 8);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // txtBit
            // 
            this.txtBit.Location = new System.Drawing.Point(259, 41);
            this.txtBit.Name = "txtBit";
            this.txtBit.Size = new System.Drawing.Size(25, 20);
            this.txtBit.TabIndex = 4;
            this.txtBit.Text = "24";
            this.txtBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Prefix:";
            // 
            // txtOctet
            // 
            this.txtOctet.Location = new System.Drawing.Point(259, 96);
            this.txtOctet.Name = "txtOctet";
            this.txtOctet.Size = new System.Drawing.Size(25, 20);
            this.txtOctet.TabIndex = 6;
            this.txtOctet.Text = "1";
            this.txtOctet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Octet:";
            // 
            // clearBtn
            // 
            this.clearBtn.ForeColor = System.Drawing.Color.Red;
            this.clearBtn.Location = new System.Drawing.Point(397, 66);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Delete All";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(397, 94);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 10;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // adapterCombo
            // 
            this.adapterCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adapterCombo.FormattingEnabled = true;
            this.adapterCombo.Location = new System.Drawing.Point(91, 10);
            this.adapterCombo.Name = "adapterCombo";
            this.adapterCombo.Size = new System.Drawing.Size(120, 21);
            this.adapterCombo.Sorted = true;
            this.adapterCombo.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "NIC:";
            // 
            // refListBtn
            // 
            this.refListBtn.Location = new System.Drawing.Point(217, 10);
            this.refListBtn.Name = "refListBtn";
            this.refListBtn.Size = new System.Drawing.Size(67, 23);
            this.refListBtn.TabIndex = 32;
            this.refListBtn.Text = "Refresh";
            this.refListBtn.UseVisualStyleBackColor = true;
            this.refListBtn.Click += new System.EventHandler(this.refListBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.ForeColor = System.Drawing.Color.Red;
            this.delBtn.Location = new System.Drawing.Point(397, 37);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 8;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // AdvIpSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.refListBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.adapterCombo);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.txtOctet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.txtMetric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMask);
            this.Controls.Add(this.txtGate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.grdIPList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdvIpSetting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced IP Setting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdvIpSetting_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grdIPList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdIPList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn subnetMasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn defGateways;
        private System.Windows.Forms.DataGridViewTextBoxColumn metrics;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGate;
        private System.Windows.Forms.TextBox txtMask;
        private System.Windows.Forms.TextBox txtMetric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox txtBit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOctet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.ComboBox adapterCombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button refListBtn;
        private System.Windows.Forms.Button delBtn;
    }
}