<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ObjectDemo.aspx.cs" Inherits="Scripting_ObjectDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    
        <script type="text/javascript">
    
    function Person(firstName, lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
    
    function toString()
    {
        return this.firstName + " " + this.lastName;
    }
    
    Person.prototype.constructor = Person;
    Person.prototype.toString = toString;

    function getPerson()
    {
        var p = new Person("Natalie", "Portman");
       // var label = document.getElementsByName("div1");
       var label = document.getElementById("div1");
       label.innerHTML = p.toString();
   
    }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="div1">
        </div>
        <br />
        
        <input id="Button1" type="button" value="button" onclick="getPerson();" />   
    
    </div>
    </form>
</body>
</html>
