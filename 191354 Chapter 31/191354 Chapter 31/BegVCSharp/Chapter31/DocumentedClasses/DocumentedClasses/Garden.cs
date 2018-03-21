using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentedClasses
{
   /// <summary>
   /// Class representing a garden, and the contents of that garden.
   /// </summary>
   /// <remarks>
   /// <para>
   /// Use the <see cref="Add" /> method to add contents, 
   /// which must inherit from <see cref="GardenContent" />.
   /// </para>
   /// <para>
   /// Once contents have been added the garden can be visualised using the 
   /// <see cref="GetPlan" /> method.
   /// </para>
   /// <para>
   /// Suitable classes for adding include:
   /// <list type="table">
   /// <listheader>
   /// <term>Class</term>
   /// <description>Description</description>
   /// </listheader>
   /// <item>
   /// <term><see cref="Flower" /></term>
   /// <description>Represents a flower, size 1x1.</description>
   /// </item>
   /// <item>
   /// <term><see cref="Tree" /></term>
   /// <description>Represents a tree, size 2x2.</description>
   /// </item>
   /// <item>
   /// <term><see cref="Bush" /></term>
   /// <description>Represents a bush, size 2x2.</description>
   /// </item>
   /// <item>
   /// <term><see cref="Sprinkler" /></term>
   /// <description>Represents a sprinkler, size 1x1.</description>
   /// </item>
   /// <item>
   /// <term><see cref="Statue" /></term>
   /// <description>Represents a statue, size 1x1.</description>
   /// </item>
   /// <item>
   /// <term><see cref="Bench" /></term>
   /// <description>Represents a bench, size 5x2.</description>
   /// </item>
   /// </list>
   /// </para>
   /// </remarks>
   /// <example>
   /// The following code adds a flower to the middle of a garden:
   /// <code>
   /// Garden myGarden = new Garden(11, 11);
   /// Garden.Add(new Flower(5, 5));
   /// </code>
   /// </example>
   /// <exception cref="System.ArgumentException">This exception is thrown if an object is added and doesn't fit in the garden.</exception>
   /// <seealso cref="GardenContent"/>
   public class Garden
   {
      private List<GardenContent> contents;
      private int width;
      private int depth;

      /// <summary>
      /// Constructor that sets the dimensions of the <c>Garden</c> object.
      /// </summary>
      /// <param name="gardenWidth">Width of the <c>Garden</c> object (size on x-axis).</param>
      /// <param name="gardenDepth">Depth of the <c>Garden</c> object (size on y-axis).</param>
      public Garden(int gardenWidth, int gardenDepth)
      {
         width = gardenWidth;
         depth = gardenDepth;
         contents = new List<GardenContent>();
      }

      /// <summary>
      /// Width of the garden (size on x-axis).
      /// </summary>
      /// <value>
      /// An <see langword="int" /> value.
      /// </value>
      public int Width
      {
         get
         {
            return width;
         }
      }

      /// <summary>
      /// Depth of the garden (size on y-axis).
      /// </summary>
      /// <value>
      /// An <see langword="int" /> value.
      /// </value>
      public int Depth
      {
         get
         {
            return depth;
         }
      }

      /// <summary>
      /// Adds an object to the garden.
      /// </summary>
      /// <param name="newContent">The object to add, which must inherit from <see cref="GardenContent" />.</param>
      public void Add(GardenContent newContent)
      {
         // Check is inside garden
         if (newContent.XPos < 0 || newContent.XPos + newContent.Width > width 
            || newContent.YPos < 0 || newContent.YPos + newContent.Depth > depth)
         {
            throw new ArgumentException("That object doesn't fit in the garden!");
         }
         contents.Add(newContent);
      }

      /// <summary>
      /// Removes an object from the garden.
      /// </summary>
      /// <param name="oldContent">The object to add, which must inherit from <see cref="GardenContent" />.</param>
      public void Remove(GardenContent oldContent)
      {
         contents.Remove(oldContent);
      }

      /// <summary>
      /// Determines whether an object is in the garden.
      /// </summary>
      /// <param name="content">The object to look for, which must inherit from <see cref="GardenContent" />.</param>
      /// <returns>A <see langword="bool" /> value, stating whether the object is in the garden.</returns>
      public bool Contains(GardenContent content)
      {
         return contents.Contains(content);
      }

      /// <summary>
      /// Obtains the ASCII character at location (x, y) in the garden plan, taking garden objects into account.
      /// </summary>
      /// <returns>returns a <see langword="char" /> array, where the dimensions of the array are determined by the 
      /// <seealso cref="Width">Width</seealso> and <seealso cref="Width">Depth</seealso> properties.</returns>
      /// <param name="x">x position to examine.</param>
      /// <param name="y">y position to examine.</param>
      public char GetChar(int x, int y)
      {
         foreach (GardenContent item in contents)
         {
            if (x >= item.XPos && x < (item.XPos + item.Width) &&
               y >= item.YPos && y < (item.YPos + item.Depth))
            {
               int internalX = x - item.XPos;
               int internalY = y - item.YPos;
               return item.GetPlan()[internalY, internalX];
            }
         }
         return '.';
      }

      /// <summary>
      /// Obtains a <see langword="char" /> array showing the garden and all its contents. 
      /// Individual objects are shown according to their ASCII representation.
      /// </summary>
      public char[,] GetPlan()
      {
         char[,] plan = new char[width, depth];
         for (int x = 0; x < width; x++)
         {
            for (int y = 0; y < depth; y++)
            {
               plan[x, y] = GetChar(x, y);
            }
         }
         return plan;
      }
   }
}
