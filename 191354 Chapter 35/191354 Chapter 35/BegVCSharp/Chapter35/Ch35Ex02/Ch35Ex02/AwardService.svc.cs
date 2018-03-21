using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Ch35Ex02Contracts;

namespace Ch35Ex02
{
   // NOTE: If you change the class name "AwardService" here, you must also update the reference to "AwardService" in Web.config.
   public class AwardService : IAwardService
   {
      private int passMark;

      public void SetPassMark(int passMark)
      {
         this.passMark = passMark;
      }

      public Person[] GetAwardedPeople(Person[] peopleToTest)
      {
         List<Person> result = new List<Person>();
         foreach (Person person in peopleToTest)
         {
            if (person.Mark > passMark)
            {
               result.Add(person);
            }
         }
         return result.ToArray();
      }
   }
}
