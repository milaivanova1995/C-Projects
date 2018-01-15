<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editor.aspx.cs" Inherits="Online_Photo_Effects.View.Editor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        form fieldset input[type="submit"] {
            background-color: #008dde;
            border: none;
            border-radius: 3px;
            -moz-border-radius: 3px;
            -webkit-border-radius: 3px;
            color: #f4f4f4;
            cursor: pointer;
            font-family: 'Open Sans', Arial, Helvetica, sans-serif;
            height: 50px;
            text-transform: uppercase;
            width: 300px;
            -webkit-appearance: none;
        }

     

           


    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="fileUploader" runat="server" />
            <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
            <br />
            <asp:Image ID="imageBox" runat="server" />
            <br />
            <fieldset>
                <asp:Button ID="btnMagic1" runat="server" Text="Magic 1" OnClick="btnMagic1_Click" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnMagic2" runat="server" Text="Magic 2" OnClick="btnMagic2_Click" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnMagic3" runat="server" Text="Magic3" OnClick="btnMagic3_Click" />
            </fieldset>
        </div>
    </form>
</body>
</html>
