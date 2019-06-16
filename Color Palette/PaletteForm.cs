using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorPalette
{
    public partial class PaletteForm : Form
    {
        ToolTip tooltip = new ToolTip();
        Color currentColor;
        public PaletteForm()
        {
            InitializeComponent();
            OnColorChanged(this, new EventArgs());
        }

        private void OnColorChanged(object sender, EventArgs e)
        {
            int r = sliderRed.Value,
                g = sliderGreen.Value,
                b = sliderBlue.Value;
            currentColor = Color.FromArgb(r, g, b);
            pnlColorPreview.BackColor = currentColor;
        }
        private void OnColorChangeOver(object sender, EventArgs e)
        {
            string hex = GetHexCode(currentColor);
            Clipboard.SetText(hex);
            tooltip.SetToolTip(pnlColorPreview, hex);
        }

        private string GetHexCode(Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        
    }
}
