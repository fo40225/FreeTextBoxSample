<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ftb.imagegallery.aspx.cs" Inherits="FreeTextBoxSample.ftb_imagegallery" ValidateRequest="false" %>
<%@ Register TagPrefix="FTB" Namespace="FreeTextBoxControls" Assembly="FreeTextBox" %>
<!DOCTYPE html>

<html>
<head runat="server">
    <meta charset="UTF-8" lang="zh-tw" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
    <div>
        <FTB:ImageGallery id="ImageGallery1" runat="Server"></FTB:ImageGallery>
    </div>
    </form>
</body>
</html>
