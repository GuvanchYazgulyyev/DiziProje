﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Hakkimda.aspx.cs" Inherits="DiziProje.Hakkimda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">

        <div class="about-section">
            <div class="about-grid">
                <h3>Hakkımızda</h3>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <p>
                            <%# Eval("ACIKLAMA") %>
                        </p>
                    </ItemTemplate>
                </asp:Repeater>

            </div>
        </div>
    </div>




</asp:Content>
