<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminBlog.aspx.cs" Inherits="DiziProje.AdminSayfalar.AdminBlog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>BAŞLIK</th>
            <th>TARİH</th>
            <th>TÜR</th>
            <th>KATEGORİ</th>
            <th>İŞLEMLER</th>
        </tr>

        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("BLOGID") %></td>
                    <td><%# Eval("BLOGBASLIK") %></td>
                    <td><%# Eval("BLOGTARIH") %></td>
                    <td><%# Eval("BLOGTUR") %></td>
                   <%-- <td><%# Eval("TURAD") %></td>--%>
                    <td><%# Eval("BLOGKATEGORI") %></td>
                   <%-- <td><%# Eval("KATEGORIAD") %></td>--%>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"BlogSil.aspx?BLOGID="+Eval("BLOGID") %>'
                            CssClass="btn btn-danger">SİL</asp:HyperLink>
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"BlogGuncelle.aspx?BLOGID="+Eval("BLOGID") %>'
                            CssClass="btn btn-info">GÜNCELLE</asp:HyperLink>
                    </td>
                </tr>

            </ItemTemplate>
        </asp:Repeater>

    </table>
    <a href="YeniBlog.aspx" class="btn btn-primary">Yeni Blog Ekle</a>
</asp:Content>
