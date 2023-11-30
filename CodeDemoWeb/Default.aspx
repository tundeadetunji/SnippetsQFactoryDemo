<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="CodeDemoWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">

        <!--<div class="row">-->
        <div class="input-field col s12">
            <!--<i class="material-icons prefix"><i class="fa fa-user" aria-hidden="true"></i></i>-->
            <asp:DropDownList ID="TitleDropDown" runat="server"></asp:DropDownList>
            <label>Title</label>
        </div>
        <!--</div>-->

        <!--<div class="row">-->
        <div class="input-field col s12">
            <i class="material-icons prefix"><i class="fa fa-address-card" aria-hidden="true"></i></i>
            <asp:TextBox ID="NameTextBox" TextMode="SingleLine" ReadOnly="false" runat="server"></asp:TextBox>
            <label>Name</label>
        </div>
        <!--</div>-->


        <!--<div class="row">-->
        <div class="input-field col s12">
            <!--<i class="material-icons prefix"><i class="fa fa-user" aria-hidden="true"></i></i>-->
            <asp:DropDownList ID="GenderDropDown" runat="server"></asp:DropDownList>
            <label>Gender</label>
        </div>
        <!--</div>-->


        <!--<div class="row">-->
        <div class="input-field col s12">
            <i class="material-icons prefix"><i class="fa fa-user" aria-hidden="true"></i></i>
            <asp:TextBox ID="UsernameTextBox" TextMode="SingleLine" ReadOnly="false" runat="server"></asp:TextBox>
            <label>Username</label>
        </div>
        <!--</div>-->

        <!--<div class="row">-->
        <div class="input-field col s12">
            <i class="material-icons prefix"><i class="fa fa-lock" aria-hidden="true"></i></i>
            <asp:TextBox ID="PasswordTextBox" TextMode="Password" ReadOnly="false" runat="server"></asp:TextBox>
            <label>Password</label>
        </div>
        <!--</div>-->

        <asp:Button ID="SubmitButton" runat="server" Text="Save" CssClass="btn btn-large" OnClick="SubmitButton_Click" />
    </div>

</asp:Content>
