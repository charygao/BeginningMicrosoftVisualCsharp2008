using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

[ServiceContract(Namespace = "")]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class HelloService
{
   [WebGet]
	[OperationContract]
	public string Greeting(string name)
	{
		return "Hello, " + name;
	}
}
