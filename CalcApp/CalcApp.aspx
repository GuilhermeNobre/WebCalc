<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CalcApp.aspx.cs" Inherits="CalcApp.CalcApp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
    <tr>
        <td style="width: 110px">
            <br />
&nbsp;NÚMERO 1<br />
        </td>
        <td style="width: 173px">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td style="width: 39px">
            <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" Text="+" />
        </td>
        <td style="width: 38px">
            <asp:Button ID="ButtonMulti" runat="server" Text="*" OnClick="ButtonMulti_Click" />
        </td>
        <td style="width: 92px">RESULTADO</td>
    </tr>
    <tr>
        <td style="width: 110px">
            <br />
&nbsp;NÚMERO 2<br />
        </td>
        <td style="width: 173px">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td style="width: 39px">
            <asp:Button ID="ButtonSub" runat="server" Text="-" OnClick="ButtonSub_Click" />
        </td>
        <td style="width: 38px">
            <asp:Button ID="ButtonDiv" runat="server" Text="/" OnClick="ButtonDiv_Click" />
        </td>
        <td style="width: 92px">
            <asp:Label ID="LabelResult" runat="server" Text="Label" Visible="False"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
