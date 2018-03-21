using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextBoxTest
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();

         this.buttonOK.Enabled = false;

         // Tag values for testing if the data is valid
         this.textBoxAddress.Tag = false;
         this.textBoxAge.Tag = false;
         this.textBoxName.Tag = false;
         this.textBoxOccupation.Tag = false;

         // Subscriptions to events
         this.textBoxName.Validating += new CancelEventHandler(textBoxEmpty_Validating);
         this.textBoxAddress.Validating += new CancelEventHandler(textBoxEmpty_Validating);
         this.textBoxOccupation.Validating += new CancelEventHandler(textBoxOccupation_Validating);
         this.textBoxAge.Validating += new CancelEventHandler(textBoxEmpty_Validating);
      }

      void textBoxOccupation_Validating(object sender, CancelEventArgs e)
      {
         // Cast the sender object to a textbox.
         TextBox tb = (TextBox)sender;

         // Check if the values are correct.
         if (tb.Text.CompareTo("Programmer") == 0 || tb.Text.Length == 0)
         {
            tb.Tag = true;
            tb.BackColor = System.Drawing.SystemColors.Window;
         }
         else
         {
            tb.Tag = false;
            tb.BackColor = Color.Red;
         }

         // Set the state of the OK button.
         ValidateOK();
      }

      void textBoxEmpty_Validating(object sender, CancelEventArgs e)
      {
         // We know the sender is a TextBox, so we cast the sender object to that.
         TextBox tb = (TextBox)sender;

         // If the text is empty we set the background color of the 
         // Textbox to red to indicate a problem. We use the tag value
         // of the control to indicate if the control contains valid
         // information.
         if (tb.Text.Length == 0)
         {
            tb.BackColor = Color.Red;
            tb.Tag = false;

            // In this case we do not want to cancel further processing,
            // but if we had wanted to do this, we would have added this line:
            // e.Cancel = true;
         }
         else
         {
            tb.BackColor = System.Drawing.SystemColors.Window;
            tb.Tag = true;
         }

         // Finally, we call ValidateOK which will set the value of
         // the OK button.
         ValidateOK();
      }

      private void buttonOK_Click(object sender, EventArgs e)
      {
         // No testing for invalid values are made, as that should
         // not be necessary

         string output;

         // Concatenate the text values of the four TextBoxes.
         output = "Name: " + this.textBoxName.Text + "\r\n";
         output += "Address: " + this.textBoxAddress.Text + "\r\n";
         output += "Occupation: " + this.textBoxOccupation.Text + "\r\n";
         output += "Age: " + this.textBoxAge.Text;

         // Insert the new text.
         this.textBoxOutput.Text = output;
      }

      private void buttonHelp_Click(object sender, EventArgs e)
      {
         // Write a short description of each TextBox in the Output TextBox.
         string output;

         output = "Name = Your name\r\n";
         output += "Address = Your address\r\n";
         output += "Occupation = Only allowed value is 'Programmer'\r\n";
         output += "Age = Your age";

         // Insert the new text.
         this.textBoxOutput.Text = output;
      }

      private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
      {
         if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            e.Handled = true; // Remove the character
      }

      private void textBox_TextChanged(object sender, EventArgs e)
      {
         // Cast the sender object to a Textbox
         TextBox tb = (TextBox)sender;

         // Test if the data is valid and set the tag and background
         // color accordingly.
         if (tb.Text.Length == 0 && tb != textBoxOccupation)
         {


            tb.Tag = false;
            tb.BackColor = Color.Red;
         }
         else if (tb == textBoxOccupation &&
                   (tb.Text.Length != 0 && tb.Text.CompareTo("Programmer") != 0))
         {
            // Don't set the color here, as it will color change while the user
            // is typing.
            tb.Tag = false;
         }
         else
         {
            tb.Tag = true;
            tb.BackColor = SystemColors.Window;
         }

         // Call ValidateOK to set the OK button.
         ValidateOK();
      }

      private void ValidateOK()
      {
         // Set the OK button to enabled if all the Tags are true.
         this.buttonOK.Enabled = ((bool)(this.textBoxAddress.Tag) &&
                                 (bool)(this.textBoxAge.Tag) &&
                                 (bool)(this.textBoxName.Tag) &&
                                 (bool)(this.textBoxOccupation.Tag));
      }
   }
}
