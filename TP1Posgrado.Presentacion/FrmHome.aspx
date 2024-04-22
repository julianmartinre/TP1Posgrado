<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmHome.aspx.cs" Inherits="TP1Posgrado.Presentacion.FrmHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridALUMNO" runat="server"></asp:GridView>
        </div>
        <br />
        <div>
            <asp:GridView ID="GridALUMNOTELEFONO" runat="server"></asp:GridView>
        </div>
        <br />
        <div>
            <asp:GridView ID="GridALUMNOEMAIL" runat="server"></asp:GridView>
        </div>
        <br />
        <div>
            <asp:GridView ID="GridMATERIA" runat="server"></asp:GridView>
        </div>
        <br />
        <div>
            <asp:GridView ID="GridCALIFICACION" runat="server"></asp:GridView>
        </div>
        <br />
    </form>
</body>
</html>
