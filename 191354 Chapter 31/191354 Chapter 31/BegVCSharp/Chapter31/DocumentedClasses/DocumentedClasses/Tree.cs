using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentedClasses
{
   /// <summary>
   /// <c>Tree</c> object. See <see cref="GardenContent" /> for member details.
   /// </summary>
   public class Tree : Plant
   {
      /// <summary>
      /// <c>Tree</c> constructor.
      /// </summary>
      /// <param name="x">x position of <c>Tree</c> object.</param>
      /// <param name="y">y position of <c>Tree</c> object.</param>
      public Tree(int x, int y)
      {
         XPos = x;
         YPos = y;
         Width = 5;
         Depth = 3;
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
               {'\\','/','"','\\','/'},
               {'(',' ','O',' ',')'},
               {'/','\\','_', '/','\\'}
            };
            return plan;
         }
      }
   }
}
