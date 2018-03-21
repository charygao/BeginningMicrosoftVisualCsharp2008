#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace ColorConverter
{
  partial class Form1 : Form
  {
    private Color theColor;
    
    public Form1()
    {
      InitializeComponent();
      tbRed.Text = "0";
      tbGreen.Text = "0";
      tbBlue.Text = "0";
    }

    private void parseRGB()
    {
      int r, g, b;

      try
      {
        r = Int16.Parse(tbRed.Text);
      }
      catch (Exception)
      {
        r = 0;
      }
      r = Math.Min(r, 255);
      try
      {
        g = Int16.Parse(tbGreen.Text);
      }
      catch (Exception)
      {
        g = 0;
      }
      g = Math.Min(g, 255);
      try
      {
        b = Int16.Parse(tbBlue.Text);
      }
      catch (Exception)
      {
        b = 0;
      }
      b = Math.Min(b, 255);
      theColor = Color.FromArgb(r, g, b);
      tbHue.Text = theColor.GetHue().ToString();
      tbSat.Text = theColor.GetSaturation().ToString();
      tbBright.Text = theColor.GetBrightness().ToString();
      this.Invalidate();
    }

    private void tbRed_TextChanged(object sender, EventArgs e)
    {
      parseRGB();
    }

    private void tbGreen_TextChanged(object sender, EventArgs e)
    {
      parseRGB();
    }

    private void tbBlue_TextChanged(object sender, EventArgs e)
    {
      parseRGB();
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;
      
      SolidBrush backBrush = new SolidBrush(System.Drawing.SystemColors.Control);
      g.FillRectangle(backBrush, this.ClientRectangle);
      backBrush.Dispose();
      
      Rectangle r = new Rectangle(10, 80, 100, 40);
      SolidBrush b = new SolidBrush(theColor);
      g.SetClip(this.ClientRectangle);
      g.FillRectangle(b, r);
      b.Dispose();
    }
  }
}