using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Ch35Ex03
{
   // NOTE: If you change the interface name "IAppControlService" here, you must also update the reference to "IAppControlService" in App.config.
   [ServiceContract]
   public interface IAppControlService
   {
      [OperationContract]
      void SetRadius(int radius, string foreTo, int seconds);
   }
}
