using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentedClasses
{
   /// <summary>
   /// <c>Statue</c> object. See <see cref="GardenContent" /> for member details.
   /// </summary>
   public class Statue : Ornamentation
   {
      /// <summary>
      /// <c>Statue</c> constructor.
      /// </summary>
      /// <param name="x">x position of <c>Statue</c> object.</param>
      /// <param name="y">y position of <c>Statue</c> object.</param>
      public Statue(int x, int y)
      {
         XPos = x;
         YPos = y;
         Width = 2;
         Depth = 2;
      }

      /// <summary>
      /// Internal implementation for <see cref="GardenContent.GetPlan"/>.
      /// </summary>
      /// <returns>
      /// returns a <see langword="char" /> array, where the dimensions of the array are 
      /// determined by the <see cref="GardenContent.Width">Width</see> 
      /// and <see cref="GardenContent.Depth">Depth</see> properties.
      /// </returns>
      protected override char[,] Plan
      {
         get
         {
            char[,] plan = {
               {'/','\\'},
               {'\\','/'}
            };
            return plan;
         }
      }
   }
}
