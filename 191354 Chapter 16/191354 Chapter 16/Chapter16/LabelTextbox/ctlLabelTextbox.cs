using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabelTextbox
{
    public partial class ctlLabelTextbox : UserControl
    {
        // Enumeration of the two possible positions
        public enum PositionEnum
        {
            Right,
            Below
        }

        // Member field that will hold the choices the user makes
        private PositionEnum mPosition = PositionEnum.Right;
        private int mTextboxMargin = 0;
        private string mLabelText = "";

        public event System.EventHandler PositionChanged;

        public ctlLabelTextbox()
        {
            InitializeComponent();
        }

        public PositionEnum Position
        {
            get
            {
                return mPosition;
            }
            set
            {
                mPosition = value;
                MoveControls();
                if (PositionChanged != null) // Make sure there are subscribers
                {
                    PositionChanged(this, new EventArgs());
                }

            }
        }

        public int TextboxMargin
        {
            get
            {
                return mTextboxMargin;
            }
            set
            {
                mTextboxMargin = value;
                MoveControls();
            }
        }

        private void ctlLabelTextbox_Load(object sender, EventArgs e)
        {
            lblTextBox.Text = this.Name; // Add a text to the label
            // Set the height of the control.
            this.Height = txtLabelText.Height > lblTextBox.Height ? txtLabelText.Height : lblTextBox.Height;
            MoveControls(); // Move the controls.
        }

        private void ctlLabelTextbox_SizeChanged(object sender, EventArgs e)
        {
            MoveControls();
        }

        private void MoveControls()
        {
            switch (mPosition)
            {
                case PositionEnum.Below:
                    // Place the top of the Textbox just below the label.
                    this.txtLabelText.Top = this.lblTextBox.Bottom;
                    this.txtLabelText.Left = this.lblTextBox.Left;

                    // Change the width of the Textbox to equal the width of the control.
                    this.txtLabelText.Width = this.Width;
                    this.Height = txtLabelText.Height + lblTextBox.Height;
                    break;
                case PositionEnum.Right:
                    // Set the top of the textbox to equal that of the label.
                    txtLabelText.Top = lblTextBox.Top;

                    // If the margin is zero, we'll place the text box next to the label.
                    if (mTextboxMargin == 0)
                    {
                        int width = this.Width - lblTextBox.Width - 3;
                        txtLabelText.Left = lblTextBox.Right + 3;
                        txtLabelText.Width = width;
                    }
                    else
                    {
                        // If the margin isn't zero, we place the text box where the user 
                        // has specified.
                        txtLabelText.Left = mTextboxMargin;
                        txtLabelText.Width = this.Right - mTextboxMargin;
                    }
                    this.Height = txtLabelText.Height > lblTextBox.Height ?
                                            txtLabelText.Height : lblTextBox.Height;
                    break;
            }
        }

        public string LabelText
        {
            get
            {
                return mLabelText;
            }
            set
            {
                mLabelText = value;
                lblTextBox.Text = mLabelText; MoveControls();
            }
        }

        public string TextboxText
        {
            get
            {
                return txtLabelText.Text;
            }
            set
            {
                txtLabelText.Text = value;
            }
        }

        private void txtLabelText_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }

        private void txtLabelText_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        private void txtLabelText_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e); 
        }

    }
}
