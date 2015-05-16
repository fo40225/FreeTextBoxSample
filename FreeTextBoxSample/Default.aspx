<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FreeTextBoxSample.Default" ValidateRequest="false" %>
<%@ Register TagPrefix="FTB" Namespace="FreeTextBoxControls" Assembly="FreeTextBox" %>
<!DOCTYPE html>

<html>
<head runat="server">
    <meta charset="UTF-8" lang="zh-tw"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <FTB:FreeTextBox ID="FreeTextBox1" runat="Server" Language="zh-TW" Width="100%"/>
    </div>
    </form>
</body>
</html>
