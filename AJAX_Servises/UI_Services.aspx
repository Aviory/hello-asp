<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UI_Services.aspx.cs" Inherits="AJAX_Servises.UI_Services" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>WinFirmServiceUI</title>
    <script type="text/javascript">
        window.onload = function ()
        {
            AJAX_Servises.WebService.HelloWorld(onComlete, onError);
        }
        function onComlete(result)
        {
            alert(result);
        }
        function onError(error)
        {
            alert(error._message);
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="sm" runat="server">
            <Services>
                <asp:ServiceReference Path ="~/WebService.asmx" />
            </Services>
        </asp:ScriptManager>
    </div>
    </form>
</body>
</html>
