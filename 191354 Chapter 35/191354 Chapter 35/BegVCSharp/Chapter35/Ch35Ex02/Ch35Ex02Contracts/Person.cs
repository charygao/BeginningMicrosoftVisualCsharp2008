﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Ch35Ex02Contracts
{
   [DataContract]
   public class Person
   {
      [DataMember]
      public string Name { get; set; }

      [DataMember]
      public int Mark { get; set; }
   }
}