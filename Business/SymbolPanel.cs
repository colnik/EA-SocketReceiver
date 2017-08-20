using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASocketReceiver
{
    public class SymbolPanel
    {
        private string _symbol;
        private string _message;

        private FlowLayoutPanel _container;
        private TextBox _textMessage;
        private GroupBox _groupBox;
        private Color _messageColor = Color.Black;

        /// <summary>
        /// ctor
        /// </summary>
        public SymbolPanel(FlowLayoutPanel container, string symbol)
        {
            _container = container;
            _symbol = (symbol.Length > 20) ? symbol.Substring(0, 20) : symbol;

            CreatePanel();
        }

        /// <summary>
        /// Panel message.
        /// </summary>
        public string Message
        {
            get {  return _message;  }
            set
            {
                _message = value;

                UpdateMessage();
            }
        }

        /// <summary>
        /// Message color.
        /// </summary>
        public Color MessageColor
        {
            get { return _messageColor; }
            set 
            { 
                _messageColor = value;

                SetMessageTextColor(_messageColor);
            }
        }

        /// <summary>
        /// Remove panel from container.
        /// </summary>
        public void Remove()
        {
            _container.Controls.Remove(_groupBox);
        }

        /// <summary>
        /// Update textbox message foreground color.
        /// </summary>
        /// <param name="messageColor"></param>
        public void SetMessageTextColor(Color messageColor)
        {
            if (_textMessage == null)
                return;

            _textMessage.ForeColor = messageColor;
        }

        /// <summary>
        /// Create symbol panel in container.
        /// </summary>
        private void CreatePanel()
        {
            _groupBox = new GroupBox();
            _groupBox.Name = string.Format("symbol_group_{0}", _symbol);
            _groupBox.Size = new System.Drawing.Size(500, 54);
            _groupBox.Text = _symbol;
            _container.Controls.Add(_groupBox);

            _textMessage = new TextBox();
            _textMessage.ForeColor = MessageColor;
            _textMessage.Name = string.Format("symbol_text_{0}", _symbol);
            _textMessage.Location = new System.Drawing.Point(10, 20);
            _textMessage.Size = new Size(480, 23);
            _textMessage.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            _groupBox.Controls.Add(_textMessage);

            ReorderPanelControls();
        }

        /// <summary>
        /// update message
        /// </summary>
        private void UpdateMessage()
        {
            if (_textMessage == null || _message == null)
                return;

            _textMessage.Text = _message;
        }

        /// <summary>
        /// Reorder controls in flowLayout panel.
        /// </summary>
        private void ReorderPanelControls()
        {
            var boxOrderedByText = _container.Controls.Cast<GroupBox>().Select(x => new { BoxText = x.Text, BoxControl = x }).OrderBy(x => x.BoxText).ToList();

            foreach (var boxValue in boxOrderedByText)
            {
                _container.Controls.SetChildIndex(boxValue.BoxControl, boxOrderedByText.IndexOf(boxValue));
            }
        }
    }
}
