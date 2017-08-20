using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASocketReceiver
{
    public partial class FormMain : Form, ILogger
    {
        private SocketListener _listener;

        private Dictionary<string, SymbolPanel> _panels;

        private Color _messageColor = Color.Black;

        /// <summary>
        /// ctor
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

            _panels = new Dictionary<string, SymbolPanel>();

            _listener = new SocketListener();
            _listener.OnMessage = OnScoketMessage;
            _listener.Logger = this;
        }

        /// <summary>
        /// event handler
        /// </summary>
        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonStart_Click(null, EventArgs.Empty);

            this.Text = string.Format("{0} (v {1})", this.Text, Assembly.GetExecutingAssembly().GetName().Version);
        }

        /// <summary>
        /// event handler
        /// </summary>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!_listener.IsStarted)
            {
                string msg = null;
                if (!ValidateInput(ref msg))
                {
                    MessageBox.Show(msg);
                    return;
                }

                try
                {
                    SocketListenerParams slp = new SocketListenerParams();
                    slp.PortNo = int.Parse(textPortNo.Text);
                    slp.IpAddress = "127.0.0.1";

                    _listener.Start(slp);

                    textStatus.Text = string.Format("Started to listen on port {0}", slp.PortNo);
                }
                catch (Exception ex)
                {
                    listCommon.Items.Add(string.Format("ERROR: {0}", ex.Message));
                }

                textPortNo.ReadOnly = true;
                buttonStart.Text = "Stop";
            }
            else
            {
                _listener.Stop();

                textStatus.Text = string.Empty;
                textPortNo.ReadOnly = false;
                buttonStart.Text = "Start";
            }
        }

        /// <summary>
        /// event handler
        /// </summary>
        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            foreach (string symbol in _panels.Keys)
                _panels[symbol].Remove();

            _panels.Clear();
        }

        /// <summary>
        /// Event handler.
        /// </summary>
        private void buttonRed_Click(object sender, EventArgs e)
        {
            _messageColor = Color.Red;

            UpdateMessageColor();
        }

        /// <summary>
        /// Event handler.
        /// </summary>
        private void buttonBlack_Click(object sender, EventArgs e)
        {
            _messageColor = Color.Black;

            UpdateMessageColor();
        }

        /// <summary>
        /// Event handler.
        /// </summary>
        private void menuItemDeleteAll_Click(object sender, EventArgs e)
        {
            listCommon.Items.Clear();
        }

        /// <summary>
        /// Event handler.
        /// </summary>
        private void menuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Update message color.
        /// </summary>
        private void UpdateMessageColor()
        {
            foreach (string symbol in _panels.Keys)
                _panels[symbol].SetMessageTextColor(_messageColor);
        }

        /// <summary>
        /// Socket message event.
        /// </summary>
        private void OnScoketMessage(SocketMessage message)
        {
            try
            {
                if (listCommon.InvokeRequired)
                    listCommon.Invoke(new Action(() => ProcessSocketMessage(message)));
                else
                    ProcessSocketMessage(message);
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Process socket message.
        /// </summary>
        private void ProcessSocketMessage(SocketMessage message)
        {
            if (string.IsNullOrWhiteSpace(message.Symbol))
                LogInfo(message.Message);
            else
                AddSymbolPanel(message);
        }

        /// <summary>
        /// Add or update symbol panel.
        /// </summary>
        private void AddSymbolPanel(SocketMessage message)
        {
            if (_panels.ContainsKey(message.Symbol))
            {
                _panels[message.Symbol].Message = message.Message;
            }
            else
            {
                SymbolPanel panel = new SymbolPanel(panelSymbolMessage, message.Symbol);
                panel.MessageColor = _messageColor;
                panel.Message = message.Message;

                _panels.Add(message.Symbol, panel);
            }

            if (checkActivateWindow.Checked && !string.IsNullOrWhiteSpace(message.Message))
                this.Activate();
        }

        /// <summary>
        /// Input validation.
        /// </summary>
        private bool ValidateInput(ref string message)
        {
            int tmp;
            if (string.IsNullOrWhiteSpace(textPortNo.Text))
            {
                message = "Port number is not set.";
                return false;
            }
            if (!int.TryParse(textPortNo.Text, out tmp))
            {
                message = string.Format("Port number is not in correct format: {0}.", textPortNo.Text);
                return false;
            }

            return true;
        }

        #region ILogger implementation

        public void LogInfo(string message)
        {
            InsertMessageItem(string.Format("{0}: {1}", DateTime.Now.ToString(), message));
        }

        public void LogError(Exception ex)
        {
            InsertMessageItem("ERROR: " + ex.Message);
        }

        public void LogError(string message)
        {
            InsertMessageItem("ERROR: " + message);
        }

        #endregion

        /// <summary>
        /// Insert item.
        /// </summary>
        private void InsertMessageItem(string item)
        {
            listCommon.Items.Insert(0, item);

            listCommon.TopIndex = 0;
        }
    }
}
