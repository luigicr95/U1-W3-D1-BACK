<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="U1_W3_D1_BACK.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cinema Multisala</h1>
            Nome: <asp:TextBox ID="Nome" runat="server"></asp:TextBox> <br />
            Cognome: <asp:TextBox ID="Cognome" runat="server"></asp:TextBox> <br />
            Sala: <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="1">SALA NORD</asp:ListItem>
                        <asp:ListItem Value="2">SALA EST</asp:ListItem>
                        <asp:ListItem Value="3">SALA SUD</asp:ListItem>
                  </asp:DropDownList>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Biglietto Ridotto"/>
            <br />
            <asp:Button ID="PrenotazioneButton" runat="server" Text="Prenota" OnClick="Prenotazione_Click" />
        </div>
        <div>
            Biglietti Sala Nord: <asp:Label ID="LabelNord" runat="server" Text=""></asp:Label>
            di cui ridotti: <asp:Label ID="RidottiNordLabel" runat="server" Text=""></asp:Label> <br />
            Biglietti Sala Est: <asp:Label ID="LabelEst" runat="server" Text=""></asp:Label>
            di cui ridotti: <asp:Label ID="RidottiEstLabel" runat="server" Text=""></asp:Label> <br />
            Biglietti Sala Sud: <asp:Label ID="LabelSud" runat="server" Text="Label"></asp:Label>
            di cui ridotti: <asp:Label ID="RidottiSudLabel" runat="server" Text=""></asp:Label>
        </div>
        <div>

        </div>
    </form>
</body>
</html>
