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
<<<<<<< HEAD
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
=======
        <div class="container">
            <br />
            <div class="panel-group" id="accordion">
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <h4 class="panel-title">
                            <a data-toggle="collapse" data-parent="#accordion" href="#collapseTwo"><i class="glyphicon glyphicon-th-list"></i>Listar Interessado
                            </a>
                        </h4>
                    </div>
                    <div id="collapseTwo" class="panel-collapse collapse">
                        <div class="panel-body">
                            <br />
                            <asp:GridView ID="gvInteressado" CssClass="table table-striped" runat="server" AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="gvInteressado_RowCommand">
                                <Columns>
                                    <asp:TemplateField HeaderText="Nome">
                                        <ItemTemplate>
                                            <asp:Label ID="lblNome" runat="server" Text='<%#Eval("Nome")%>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Cpf">
                                        <ItemTemplate>
                                            <asp:Label ID="lblCpf" runat="server" Text='<%#Eval("Cpf")%>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Contato">
                                        <ItemTemplate>
                                            <asp:Label ID="lblContato" runat="server" Text='<%#Eval("Contato")%>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Endereco">
                                        <ItemTemplate>
                                            <asp:Label ID="lblEndereco" runat="server" Text='<%#Eval("Endereco")%>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lkbEditar" runat="server" CommandName="Editar" CommandArgument='<%#Eval("Id")%>' CssClass="btn btn-default"><i class="glyphicon glyphicon-pencil"></i></asp:LinkButton>
                                            <asp:LinkButton ID="lkbExcluir" runat="server" CommandName="Excluir" CommandArgument='<%#Eval("Id")%>' CssClass="btn btn-default"><i class="glyphicon glyphicon-trash"></i></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <h4 class="panel-title"><a data-toggle="collapse" data-parent="#accordion" href="#cadastrarInteressado"><i class="glyphicon glyphicon-floppy-disk"></i>Cadastrar Interessado</a></h4>
                    </div>
                    <div id="cadastrarInteressado" class="panel-collapse collapse in">
                        <div class="panel-body">
                            <div class="col-md-12">
                                <div id="calDanger" runat="server" class="bs-callout bs-callout-danger" visible="false">
                                    <h4>Insira os campos corretamente</h4>
                                </div>
                                <div id="calSucces" runat="server" class="bs-callout bs-callout-info" visible="false">
                                    <h4>Interessado Cadastrado Corretamente</h4>
                                </div>
                                <div class="form-group">
                                    <label>ID</label>
                                    <asp:TextBox ID="txtId" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
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
                                    <asp:Button ID="btnCadastrarInteressado" runat="server" CssClass="btn btn-primary" OnClick="btnCadastrarInteressado_Click" Text="Cadastrar" />
                                </div>
                            </div>
>>>>>>> funcionalidade_filtrar
                        </div>
                    </div>
                </div>
            </div>
<<<<<<< HEAD
=======
            <div class="well">
                <a href="index.aspx" class="btn btn-danger">Voltar</a>
            </div>
>>>>>>> funcionalidade_filtrar
        </div>
    </form>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
