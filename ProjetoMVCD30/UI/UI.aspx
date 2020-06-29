<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UI.aspx.cs" Inherits="ProjetoMVCD30.UI.UI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
</head>
<body>
<form id="form1" class="form-signin"  runat="server">
        <div>
            <h1 class="h3 mb-3 font-weight-normal">Verificação</h1>
            <br />
            <asp:Label ID="msgerro" runat="server" ForeColor="Red" Text="." Visible="false"></asp:Label>

            <br />

            <asp:Label ID="lblCPFD30" runat="server" Text="CPF "></asp:Label>
            
            <asp:TextBox ID="txtCPFD30" type="text" runat="server" CssClass="form-control" ></asp:TextBox>
            <br />
            <asp:Label ID="lblNomeD30" runat="server" Text="Nome Completo "></asp:Label>
            <asp:TextBox ID="txtNomeD30" type="text" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Label ID="lblNomeMaeD30" runat="server" Text="Nome da Mãe "></asp:Label>
             <asp:TextBox ID="lblNomeMaeD30" type="text" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Button ID="btnSignin" class="btn btn-lg btn-primary btn-block" runat="server" Text="Verificar" OnClick="btnSignin_Click" />
            <br />
            

        </div>

        
       
        
    </form>
</body>
</html>
