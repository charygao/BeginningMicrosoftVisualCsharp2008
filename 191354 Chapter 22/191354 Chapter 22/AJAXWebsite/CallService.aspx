<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CallService.aspx.cs" Inherits="CallService" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>

    <script type="text/javascript">
    
      var helloService;
      
      function pageLoad() {
        helloService = new HelloService();
        helloService.set_defaultSucceededCallback(helloSucceed);
        helloService.set_defaultFailedCallback(helloFailed);
        
        // helloService.Greeting("Test", helloSucceed, helloFailed, null);
        
      }
      
      function helloSucceed(result) {
         var d = document.getElementById("result");
         d.innerHTML = result;      
      }
      
      function helloFailed(error, userContext, methodName) {
      }
      
      function callService() {
        var l = document.getElementById("input");
      
        helloService.Greeting(l.value);
      }
      
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="HelloService.svc" />
            </Services>
        </asp:ScriptManager>
    </div>
    <input id="input" type="text" />
    <br />
    <input id="button1" type="button" value="Invoke Service..." onclick="callService();" />
    <div id="result" />
    <br />
    </form>
    <p>
    </p>
</body>
</html>
