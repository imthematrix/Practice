<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson10.aspx.cs" Inherits="JavaScript_Part1.Lesson10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lesson 10 - Arrays</title>
    <script type="text/javascript">
        var emptyArr = [];
        document.write("EmptyArray Length  = ", emptyArr.length);
        //this is similar to print method in python, we can write element separating them with commas to concatenate them.
        var myArray = new Array(10);
        //note: if we pass more than 1  element in the 'new' array creation syntax,
        //will cause
        document.write("<br/>", "MyArray size is: ", myArray.length);

        var myArray1 = [2, 4, 67, 12];
        document.write("<br/>", "First element is: ", myArray1[0]); 
        document.write("<br/>", "First element is: ", myArray1[myArray1.length - 1]);

        document.write("<br/>");

        //for (var i of myArray1) {
        //    document.write(i + "<br/>");
        //}
        for (var i = 0; i < myArray1.length; i++) {
            document.write(myArray1[ i] + " | ");
        }

        alert(myArray1);
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
