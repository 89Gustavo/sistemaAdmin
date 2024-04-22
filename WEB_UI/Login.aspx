<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WEB_UI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div class="container box">
        <h1 class="title">Iniciar sesión</h1>

        <div class="field">
            <label class="label">Usuario</label>
            <div class="control">
                <asp:Textbox runat="server" id="usuario" class="input" type="text" placeholder="ej. Joe_Doe12"></asp:Textbox>
            </div>
        </div>

        <div class="field">
            <label class="label">Clave</label>
            <div class="control">
                <asp:Textbox runat="server" id="clave" class="input" type="password" placeholder="ej. Joe_Doe12"></asp:Textbox>
            </div>
        </div>

        <asp:Button runat="server" id="ingresar" class="button is-primary" text="Ingresar" OnClick="ingrese_Click"/>
    </div>
    </form>
</body>
</html>
