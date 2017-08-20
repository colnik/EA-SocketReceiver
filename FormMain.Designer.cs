namespace EASocketReceiver
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupConnect = new System.Windows.Forms.GroupBox();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textPortNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSymbolMessage = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCommonMessage = new System.Windows.Forms.Panel();
            this.listCommon = new System.Windows.Forms.ListBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.checkActivateWindow = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuItemApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupConnect.SuspendLayout();
            this.panelCommonMessage.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupConnect
            // 
            this.groupConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupConnect.Controls.Add(this.textStatus);
            this.groupConnect.Controls.Add(this.buttonStart);
            this.groupConnect.Controls.Add(this.textPortNo);
            this.groupConnect.Controls.Add(this.label1);
            this.groupConnect.Location = new System.Drawing.Point(9, 23);
            this.groupConnect.Margin = new System.Windows.Forms.Padding(2);
            this.groupConnect.Name = "groupConnect";
            this.groupConnect.Padding = new System.Windows.Forms.Padding(2);
            this.groupConnect.Size = new System.Drawing.Size(505, 41);
            this.groupConnect.TabIndex = 0;
            this.groupConnect.TabStop = false;
            // 
            // textStatus
            // 
            this.textStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textStatus.Location = new System.Drawing.Point(180, 13);
            this.textStatus.Margin = new System.Windows.Forms.Padding(2);
            this.textStatus.Name = "textStatus";
            this.textStatus.ReadOnly = true;
            this.textStatus.Size = new System.Drawing.Size(320, 20);
            this.textStatus.TabIndex = 3;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(114, 12);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(63, 22);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textPortNo
            // 
            this.textPortNo.Location = new System.Drawing.Point(51, 13);
            this.textPortNo.Margin = new System.Windows.Forms.Padding(2);
            this.textPortNo.Name = "textPortNo";
            this.textPortNo.Size = new System.Drawing.Size(60, 20);
            this.textPortNo.TabIndex = 1;
            this.textPortNo.Text = "9422";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port No";
            // 
            // panelSymbolMessage
            // 
            this.panelSymbolMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSymbolMessage.AutoScroll = true;
            this.panelSymbolMessage.Location = new System.Drawing.Point(9, 97);
            this.panelSymbolMessage.Margin = new System.Windows.Forms.Padding(2);
            this.panelSymbolMessage.Name = "panelSymbolMessage";
            this.panelSymbolMessage.Size = new System.Drawing.Size(505, 323);
            this.panelSymbolMessage.TabIndex = 1;
            // 
            // panelCommonMessage
            // 
            this.panelCommonMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCommonMessage.Controls.Add(this.listCommon);
            this.panelCommonMessage.Location = new System.Drawing.Point(9, 426);
            this.panelCommonMessage.Margin = new System.Windows.Forms.Padding(2);
            this.panelCommonMessage.Name = "panelCommonMessage";
            this.panelCommonMessage.Size = new System.Drawing.Size(505, 137);
            this.panelCommonMessage.TabIndex = 2;
            // 
            // listCommon
            // 
            this.listCommon.ContextMenuStrip = this.contextMenuStrip;
            this.listCommon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCommon.FormattingEnabled = true;
            this.listCommon.Location = new System.Drawing.Point(0, 0);
            this.listCommon.Margin = new System.Windows.Forms.Padding(2);
            this.listCommon.Name = "listCommon";
            this.listCommon.Size = new System.Drawing.Size(505, 137);
            this.listCommon.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDeleteAll});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(125, 26);
            // 
            // menuItemDeleteAll
            // 
            this.menuItemDeleteAll.Name = "menuItemDeleteAll";
            this.menuItemDeleteAll.Size = new System.Drawing.Size(124, 22);
            this.menuItemDeleteAll.Text = "Delete All";
            this.menuItemDeleteAll.Click += new System.EventHandler(this.menuItemDeleteAll_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearAll.Location = new System.Drawing.Point(461, 69);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(53, 23);
            this.buttonClearAll.TabIndex = 3;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Location = new System.Drawing.Point(428, 72);
            this.buttonRed.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(15, 16);
            this.buttonRed.TabIndex = 4;
            this.buttonRed.Tag = "Red";
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonBlack
            // 
            this.buttonBlack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBlack.BackColor = System.Drawing.Color.Black;
            this.buttonBlack.Location = new System.Drawing.Point(401, 72);
            this.buttonBlack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(15, 16);
            this.buttonBlack.TabIndex = 5;
            this.buttonBlack.Tag = "Black";
            this.buttonBlack.UseVisualStyleBackColor = false;
            this.buttonBlack.Click += new System.EventHandler(this.buttonBlack_Click);
            // 
            // checkActivateWindow
            // 
            this.checkActivateWindow.AutoSize = true;
            this.checkActivateWindow.Checked = true;
            this.checkActivateWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkActivateWindow.Location = new System.Drawing.Point(10, 73);
            this.checkActivateWindow.Name = "checkActivateWindow";
            this.checkActivateWindow.Size = new System.Drawing.Size(113, 17);
            this.checkActivateWindow.TabIndex = 6;
            this.checkActivateWindow.Text = "Activate On Event";
            this.toolTip.SetToolTip(this.checkActivateWindow, "Activate window when socket message has received.");
            this.checkActivateWindow.UseVisualStyleBackColor = true;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemApplication});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(523, 24);
            this.menuMain.TabIndex = 7;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuItemApplication
            // 
            this.menuItemApplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemExit});
            this.menuItemApplication.Name = "menuItemApplication";
            this.menuItemApplication.Size = new System.Drawing.Size(80, 20);
            this.menuItemApplication.Text = "Application";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(152, 22);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 572);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.checkActivateWindow);
            this.Controls.Add(this.buttonBlack);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.panelCommonMessage);
            this.Controls.Add(this.panelSymbolMessage);
            this.Controls.Add(this.groupConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(402, 453);
            this.Name = "FormMain";
            this.Text = "EASocket Receiver";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupConnect.ResumeLayout(false);
            this.groupConnect.PerformLayout();
            this.panelCommonMessage.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupConnect;
        private System.Windows.Forms.TextBox textPortNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.FlowLayoutPanel panelSymbolMessage;
        private System.Windows.Forms.Panel panelCommonMessage;
        private System.Windows.Forms.ListBox listCommon;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeleteAll;
        private System.Windows.Forms.CheckBox checkActivateWindow;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemApplication;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
    }
}

