<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WEB_UI.Login" %>



<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="contenido/css/Login.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
	<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.1/css/all.css" integrity="sha384-gfdkjb5BdAXd+lj+gudLWI+BXq4IuLW5IT+brZEZsLFm++aCMlF1V92rMkPaX4PP" crossorigin="anonymous">
      <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
    <script src="contenido/js/alertas.js"></script>
</head>
<body>
    <div class="container h-100">
        <div class="d-flex justify-content-center h-100">
            <div class="user_card">
                <div class="d-flex justify-content-center">
					<div class="brand_logo_container">
						<%--<img src="https://cdn.freebiesupply.com/logos/large/2x/pinterest-circle-logo-png-transparent.png" class="brand_logo" alt="Logo">--%>
                        <img src="contenido/dist/img/AdminLTELogo.png" class="brand_logo" alt="Logo" />
					</div>
				</div>
                <div class="d-flex justify-content-center form_container">
                    <form id="form1" runat="server">
                       <div class="input-group mb-3">
							<div class="input-group-append">
								<span class="input-group-text"><i class="fas fa-user"></i></span>
							</div>
                             <asp:Textbox   type="text" name=""  class="form-control input_user"   placeholder="usurio25"  runat="server" id="usuario" required></asp:Textbox>
						</div>
                        <div class="input-group mb-2">
							<div class="input-group-append">
								<span class="input-group-text"><i class="fas fa-key"></i></span>
							</div>
							<asp:Textbox runat="server" id="clave"  class="form-control input_pass" type="password" placeholder="*******" required></asp:Textbox>
						</div>

                        <div class="input-group mb-2">
				            <div class="input-group-append">
					            <span class="input-group-text"><i class="fa fa-building"></i></span>
				            </div>
				            <asp:Textbox runat="server" id="Textbox2"  class="form-control input_pass" type="text" value="Empresa" placeholder="" ReadOnly></asp:Textbox>
                        </div>

                     
                       
                    <asp:Button runat="server" id="ingresar" class="btn login_btn is-primary" text="Ingresar" OnClick="ingrese_Click"/>
                
                </form>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
