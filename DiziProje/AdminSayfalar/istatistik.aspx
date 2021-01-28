<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="istatistik.aspx.cs" Inherits="DiziProje.AdminSayfalar.istatistik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table table-bordered">
        <tr>
            <td>
                Toplam Blog Sayısı: <asp:Label ID="Lable1"  runat="server" Text="Label1"></asp:Label>
            </td>
             <td>
                Toplam Yorum Sayısı: <asp:Label ID="Lable2"  runat="server" Text="Label"></asp:Label>
            </td>
             <td>
                Toplam Filim Sayısı: <asp:Label ID="Label3"  runat="server" Text="Label"></asp:Label>
            </td>
             <td>
                Toplam Dizi Sayısı: <asp:Label ID="Label4"  runat="server" Text="Label"></asp:Label>
            </td>
        </tr>

        <tr>
           
             <td>
                Toplam Animasyon Sayısı: <asp:Label ID="Label5"  runat="server" Text="Label"></asp:Label>
            </td>
             <td>
                Toplam Belgesel Sayısı: <asp:Label ID="Label7"  runat="server" Text="Label"></asp:Label>
            </td>
             <td>
                Toplam Çizgi Filim Sayısı: <asp:Label ID="Label8"  runat="server" Text="Label"></asp:Label>
            </td>
             <td>
                En fazla Yorumu  Olan Blog: <asp:Label ID="Label6"  runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
