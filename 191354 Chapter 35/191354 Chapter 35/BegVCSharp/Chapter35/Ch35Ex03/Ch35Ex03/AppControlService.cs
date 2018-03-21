using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Ch35Ex03
{
   // NOTE: If you change the class name "AppControlService" here, you must also update the reference to "AppControlService" in App.config.
   [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
   public class AppControlService : IAppControlService
   {
      private Window1 hostApp;

      public AppControlService(Window1 hostApp)
      {
         this.hostApp = hostApp;
      }

      public void SetRadius(int radius, string foreTo, int seconds)
      {
         hostApp.SetRadius(radius, foreTo, new TimeSpan(0, 0, seconds));
      }
   }
}
