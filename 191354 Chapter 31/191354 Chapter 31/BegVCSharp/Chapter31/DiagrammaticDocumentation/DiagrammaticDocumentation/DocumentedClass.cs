using System;
using System.Collections.Generic;
using System.Text;

namespace DiagrammaticDocumentation
{
   /// <summary>
   /// This class allows you to factorize a number according to certain rules.
   /// </summary>
   /// <remarks>Use GetFactor() to factorize a number according to the rules defined by the IncludeOne and IncludeSelf properties.</remarks>
   public class DocumentedClass
   {
      /// <summary>
      /// Include 1 in GetFactors() result.
      /// </summary>
      /// <remarks>If this property is set to true, then GetFactors() will include 1 in its long[] result.</remarks>
      /// <value>A bool value.</value>
      public bool IncludeOne
      {
         get
         {
            throw new System.NotImplementedException();
         }
         set
         {
         }
      }

      /// <summary>
      /// Include self in GetFactors() result.
      /// </summary>
      /// <remarks>If this property is set to true, then GetFactors() will include its numberToFactor parameter in its long[] result.</remarks>
      /// <value>A bool value.</value>
      public bool IncludeSelf
      {
         get
         {
            throw new System.NotImplementedException();
         }
         set
         {
         }
      }
      /// <summary>
      /// Gets the factors of a number.
      /// </summary>
      /// <remarks>
      /// This method is used to obtain the factors of a number, that is, all the numbers that the number can be divided by without leaving a remainder.
      /// If IncludeOne and IncludeSelf are both true and the result returned consists of exactly two numbers (the number itself and one) then the number is prime.
      /// </remarks>
      /// <returns>Returns a long array.</returns>
      public long[] GetFactors()
      {
         throw new System.NotImplementedException();
      }
   }
}
