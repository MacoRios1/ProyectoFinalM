<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProyectoFinalMacoRios._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Proyecto Final Maco Rios</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Resumen</h2>
            <p>
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </p>
            <p>
                <asp:GridView ID="GridView2" runat="server">
                </asp:GridView>
            </p>
            <p>
                <asp:GridView ID="GridView3" runat="server">
                </asp:GridView>
            </p>
            <p>
                <asp:GridView ID="GridView4" runat="server">
                </asp:GridView>
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Mostrar Resumen" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
        </div>
    </div>

</asp:Content>
