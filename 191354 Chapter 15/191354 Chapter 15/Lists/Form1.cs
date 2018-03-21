using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lists
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();

         // Add a tenth element to the CheckedListBox.
         this.checkedListBoxPossibleValue.Items.Add("Ten");
      }

      private void buttonMove_Click(object sender, EventArgs e)
      {
         // Check if there are any checked items in the CheckedListBox.
         if (this.checkedListBoxPossibleValue.CheckedItems.Count > 0)
         {
            // Clear the ListBox we'll move the selections to
            this.listBoxSelected.Items.Clear();

            // Loop through the CheckedItems collection of the CheckedListBox
            // and add the items in the Selected ListBox
            foreach (string item in this.checkedListBoxPossibleValue.CheckedItems)
            {
               this.listBoxSelected.Items.Add(item.ToString());
            }

            // Clear all the checks in the CheckedListBox
            for (int i = 0; i < this.checkedListBoxPossibleValue.Items.Count; i++)
               this.checkedListBoxPossibleValue.SetItemChecked(i, false);
         }
      }
   }
}
