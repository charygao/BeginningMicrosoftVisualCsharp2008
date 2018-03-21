using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentedClasses
{
   /// <summary>
   /// Base class for garden contents.
   /// </summary>
   /// <remarks>
   /// <para>
   /// All garden contents have the basic properties <see cref="GardenContent.XPos" />
   /// and <see cref="GardenContent.YPos" /> specifying position, and the readonly 
   /// properties <see cref="GardenContent.Width" /> and 
   /// <see cref="GardenContent.Depth" /> specifying dimensions.
   /// </para>
   /// <para>
   /// An ASCII representation of the object can be obtained by overrides of the 
   /// <see cref="GardenContent.GetPlan" /> method.
   /// </para>
   /// </remarks>
   /// <seealso cref="DocumentedClasses.Garden"/>
   public abstract class GardenContent
   {
      private int xPos;
      private int yPos;
      private int width;
      private int depth;

      /// <summary>
      /// x position of the object.
      /// </summary>
      /// <value>An <see langword="int" /> value.</value>
      public int XPos
      {
         get
         {
            return xPos;
         }
         set
         {
            xPos = value;
         }
      }

      /// <summary>
      /// y position of the object.
      /// </summary>
      /// <value>An <see langword="int" /> value.</value>
      public int YPos
      {
         get
         {
            return yPos;
         }
         set
         {
            yPos = value;
         }
      }

      /// <summary>
      /// Width of the object (size on x-axis).
      /// </summary>
      /// <value>An <see langword="int" /> value.</value>
      public int Width
      {
         get
         {
            return width;
         }
         protected set
         {
            width = value;
         }
      }

      /// <summary>
      /// Depth of the object (size on y-axis).
      /// </summary>
      /// <value>An <see langword="int" /> value.</value>
      public int Depth
      {
         get
         {
            return depth;
         }
         protected set
         {
            depth = value;
         }
      }

      /// <summary>
      /// Default Constructor
      /// </summary>
      public GardenContent()
      {

      }

      /// <summary>
      /// Obtains a <see langword="char" /> array representing how the object will look in a garden plan, 
      /// using a simple ASCII representation.
      /// </summary>
      /// <returns>
      /// returns a <see langword="char" /> array, where the dimensions of the array are 
      /// determined by the <see cref="GardenContent.Width">Width</see> 
      /// and <see cref="GardenContent.Depth">Depth</see> properties.
      /// </returns>
      public char[,] GetPlan()
      {
         return Plan;
      }

      /// <summary>
      /// Internal implementation for <see cref="GetPlan"/>.
      /// </summary>
      /// <returns>
      /// returns a <see langword="char" /> array, where the dimensions of the array are 
      /// determined by the <see cref="GardenContent.Width">Width</see> 
      /// and <see cref="GardenContent.Depth">Depth</see> properties.
      /// </returns>
      protected abstract char[,] Plan
      {
         get;
      }
   }
}
