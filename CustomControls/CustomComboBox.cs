using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Video_Encoder__NET_Core_Version_.Properties;

namespace Video_Encoder__NET_Core_Version_ {
    /// <summary>
    /// Allows to change the border of ComboBox. Code inspired by: https://stackoverflow.com/q/52541869/8233240
    /// </summary>
    public class CustomComboBox : ComboBox {
        private const int WM_PAINT = 0xF;
        private readonly int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;
        protected override void WndProc(ref Message m) {
            base.WndProc(ref m);

            /// Supposedly reduces flicker.
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true); // seems to make no difference

            if (m.Msg == WM_PAINT) {
                using (var g = Graphics.FromHwnd(Handle)) {
                    using var b = new SolidBrush(Color.FromArgb(48, 48, 48));
                    /// Fills arrow box
                    g.FillRectangle(b, Width - buttonWidth, 0, buttonWidth, Height);

                    using (var p = new Pen(this.BorderColor, 2)) {
                        /// Draws border around control
                        g.DrawRectangle(p, 0, 0, Width, Height);

                        /// Draws additional border around button
                        p.Width = 1;
                        g.DrawRectangle(p, Width - buttonWidth, 0, buttonWidth, Height);

                        /// Fixes white line on border of button and text box
                        p.Color = this.BackColor;
                        g.DrawLine(p, new Point(Width - buttonWidth - 1, 1), new Point(Width - buttonWidth - 1, Height - 2));
                    }

                    /// Draw Icon
                    var iconPadding = 3;
                    if (buttonWidth < Height) {
                        g.DrawIcon(Resources.dropdownIcon,
                            new Rectangle(
                                Width - buttonWidth + iconPadding,
                                ((Height / 2) - (buttonWidth / 2)) + iconPadding,
                                buttonWidth - (iconPadding * 2),
                                buttonWidth - (iconPadding * 2)));
                    } else {
                        g.DrawIcon(Resources.dropdownIcon,
                            new Rectangle(
                                Width - buttonWidth + iconPadding,
                                ((buttonWidth / 2) - (Height / 2)) + iconPadding,
                                Height - (iconPadding * 2),
                                Height - (iconPadding * 2)));
                    }
                }
            }
        }

        public CustomComboBox() {

            BorderColor = Color.DimGray;
            //DoubleBuffered = true;
            this.Enter += PlaceholderChanger;
            this.Leave += PlaceholderChanger;
        }

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "DimGray")]
        public Color BorderColor { get; set; }


        #region /// Control Attributes ///
        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(AppearanceTypes.Active)]
        [Description("Changes the style of the text from foreground to background. " +
                     "Is automatically adjusted if you have a value in PlaceholderText")]
        #endregion
        public enum AppearanceTypes { Active, Passive };
        private AppearanceTypes _TextAppearance = AppearanceTypes.Active;
        public AppearanceTypes TextAppearance {
            get { return _TextAppearance; }
            set {
                _TextAppearance = value;
                ChangeAppearance();
            }
        }

        private void ChangeAppearance() {
            switch (_TextAppearance) {
                case AppearanceTypes.Active:
                    this.ForeColor = SystemColors.Control;
                    this.Font = new Font(this.Font, FontStyle.Regular);
                    break;
                case AppearanceTypes.Passive:
                    this.ForeColor = Color.FromArgb(110, 110, 110);
                    //this.Font = new Font(this.Font, FontStyle.Italic);
                    break;
            }
        }

        /// Very dirty solution but it's too much work to render text through the control
        private void PlaceholderChanger(object sender = null, EventArgs e = null) {
            if (!(string.IsNullOrWhiteSpace(this._PlaceholderText))) {  /// If the PlaceholderText string isn't empty
                if (this.Text == this.renderedText) {                     /// If the current text and text to be rendered are the same
                    this.Text = "";                                         /// Set the text to blank
                    this.TextAppearance = AppearanceTypes.Active;           /// And the Appearance Type to active
                } else if (string.IsNullOrWhiteSpace(this.Text)) {        /// OR if the current Text is empty
                    this.TextAppearance = AppearanceTypes.Passive;          /// Set the Appearance type to passive
                    this.Text = this.renderedText;                          /// And set the text to the text to be rendered
                } else {
                    this.TextAppearance = AppearanceTypes.Active;
                }
            } else {                                                    /// If the PlaceholderText IS empty
                this.Text = "";                                          /// Set the text to empty
                this.TextAppearance = AppearanceTypes.Active;            /// And Appearance type to active
            }
        }

        public void CalculatePlaceholderText(object sender = null, EventArgs e = null) {
            using (Graphics g = Graphics.FromHwnd(this.Handle)) {
                int controlSize = this.Width;
                ///ControlSize will return a false value when it first runs, before the form has the correct size
                ///∴ This function will fail on its first execution

                /// Measuring space width this way ↓ is inaccurate as it does not account for character kerning
                //float spaceSize = g.MeasureString(" ", this.Font).Width;  

                /// Using this different method, kerning is accounted for and the space width is more accurate
                float spaceSize = g.MeasureString("| |", this.Font).Width - g.MeasureString("||", this.Font).Width;

                float stringSize = g.MeasureString(_PlaceholderText, this.Font).Width;
                double numberOfSpaces = Math.Round(((controlSize - stringSize) / 2) / spaceSize, 0);
                if (numberOfSpaces > 0) {
                    renderedText = new string(' ', (int)numberOfSpaces) + _PlaceholderText;
                    Debug.WriteLine(this.Name + ": Text Rendering Calculated!");
                } else {
                    renderedText = "";
                    Debug.WriteLine(this.Name + ": Text Rendering Unsuccessful. Rendered text is blank");
                }
            }
        }

        #region /// Control Attributes ///
        [Browsable(true)]
        [Category("Misc")]
        [DefaultValue("")]
        [Description("Specifies the PlaceholderText of the CustomComboBox control. " +
                 "The PlaceholderText is displayed in the control when the Text property is null or empty " +
                 "and can be used to guide the user what input is expected by the control.")]
        #endregion
        private string renderedText;
        private string _PlaceholderText;
        public string PlaceholderText {
            get { return _PlaceholderText; }
            set {
                _PlaceholderText = value;
                this.Text = "";
                CalculatePlaceholderText();
                PlaceholderChanger();
            }

        }

    }
}
