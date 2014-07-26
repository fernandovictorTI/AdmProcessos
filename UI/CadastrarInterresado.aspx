<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastrarInterresado.aspx.cs" Inherits="ProvaAdmProcessos.CadastrarInterresado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastrar Interessado</title>

    <!-- Bootstrap -->
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <br />
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h4><i class="glyphicon glyphicon-floppy-disk"></i> Cadastrar Interessado</h4>
                </div>
                <div class="panel-body">
                    <div class="col-md-12">
                        <div id="calDanger" runat="server" class="bs-callout bs-callout-danger" visible="false">
                            <h4>Insira os campos corretamente</h4>
                        </div>
                        <div id="calSucces" runat="server" class="bs-callout bs-callout-info" visible="false">
                            <h4>Interessado Cadastrado Corretamente</h4>
                        </div>
                        <div class="form-group">
                            <label>Nome</label>
                            <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>CPF</label><br />
                            <asp:TextBox ID="txtCpf" runat="server" CssClass="form-control" MaxLength="11"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Contato</label><br />
                            <asp:TextBox ID="txtContato" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Endereço</label>
                            <asp:TextBox ID="txtEndereco" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="5"></asp:TextBox>
                        </div>
                        <div class="well">
                            <a href="index.aspx" class="btn btn-danger" >Voltar</a>
                            <asp:Button ID="btnCadastrarInteressado" runat="server" CssClass="btn btn-primary" OnClick="btnCadastrarInteressado_Click" Text="Cadastrar" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
