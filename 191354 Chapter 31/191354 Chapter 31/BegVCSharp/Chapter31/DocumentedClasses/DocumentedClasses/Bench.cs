using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentedClasses
{
   /// <summary>
   /// <c>Bench</c> object. See <see cref="GardenContent" /> for member details.
   /// </summary>
   public class Bench : Utility
   {
      /// <summary>
      /// <c>Bench</c> constructor.
      /// </summary>
      /// <param name="x">x position of <c>Bench</c> object.</param>
      /// <param name="y">y position of <c>Bench</c> object.</param>
      public Bench(int x, int y)
      {
         XPos = x;
         YPos = y;
         Width = 5;
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
               {'=','=','=','=','='},
               {'|','-','-','-','|'}
            };
            return plan;
         }
      }
   }
}
