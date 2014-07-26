<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastrarProcesso.aspx.cs" Inherits="ProvaAdmProcessos.CadastrarProcesso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastrar Processo</title>

    <!-- Bootstrap -->
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <br />
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h4><i class="glyphicon glyphicon-floppy-disk"></i>Cadastrar Processo</h4>
                </div>
                <div class="panel-body">
                    <div class="col-md-12">
                        <div id="calDanger" runat="server" class="bs-callout bs-callout-danger" visible="false">
                            <h4>Insira os campos corretamente</h4>
                        </div>
                        <div id="calSucces" runat="server" class="bs-callout bs-callout-info" visible="false">
                            <h4>Processo Cadastrado Corretamente</h4>
                        </div>
                        <div class="form-group">
                            <label>Número</label>
                            <asp:TextBox ID="txtNumero" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Categoria</label><br />
                            <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>Interessado</label><br />
                            <asp:DropDownList ID="ddlInteressado" runat="server" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>Data Julgamento</label>
                            <asp:TextBox ID="txtDataJulgamento" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Valor da Açâo</label>
                            <asp:TextBox ID="txtValorAcao" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Descricao</label>
                            <asp:TextBox ID="txtDescricao" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="5"></asp:TextBox>
                        </div>
                        <div class="well">
                            <a href="index.aspx" class="btn btn-danger" >Voltar</a>
                            <asp:Button ID="btnCadastrarProcesso" runat="server" CssClass="btn btn-primary" OnClick="btnCadastrarProcesso_Click" Text="Cadastrar" />
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
