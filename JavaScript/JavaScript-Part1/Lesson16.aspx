<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson16.aspx.cs" Inherits="JavaScript_Part1.Lesson16" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lesson - 16 Closure</title>
    <script type="text/javascript">

        //A closure is an inner function that has
        //access to the outer function's variable
        //in addition to its own variables adn global
        //variables.

        //The inner function not only has access to the
        //outer function's variables, but also to its parameters.

        //You can create a closure by adding a function
        //inside another function.

        function addNumber(x, y)
        {
            
            var returnMessage = "The result is: ";
            function add() {
                return returnMessage + (x + y);
            }
            //return add(); //this is simply return the value
            return add; //this will return inner method definition.

        };
        var result = addNumber(4, 5);
        document.write(result, "<br/>");

        var result1 = addNumber(40, 50); //removing the set of prenthesis from inner function call.
        var functResult = result1(); //use parenthesis with closure to execute them
        document.write(functResult, "<br/>");

        var myresult = addNumber(30, 40)(); //we can execute like this too.
        document.write(myresult, "<br/>");
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
