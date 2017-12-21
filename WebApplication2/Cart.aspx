<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="WebApplication2.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <table>
            <tr>
                <td>
                     <asp:Button ID="btnGenerate" runat="server" Text="Generate Bill" OnClick="btnGenerate_Click" />
                </td>
            </tr>
             <tr>
                <td>
                     <asp:Button ID="btncontinue" runat="server" Text="Continue Shopping" OnClick="btncontinue_Click" />
                </td>
            </tr>
        </table>
        <tr>
            <td>
<asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            </td>
        </tr>

   
   
         </center>
</asp:Content>
