<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ProvaAdmProcessos.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="br">
<head runat="server">
    <title>Administracao de Processos</title>

    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <h3><i class="glyphicon glyphicon-th-list"></i>Lista de Processos</h3>
                    <hr />
                </div>
                <div class="col-md-12">
                    <div class="panel-group" id="accordion">
                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <h4 class="panel-title"><a data-toggle="collapse" data-parent="#accordion" href="#filtrar">Filtrar Processo</a></h4>
                            </div>
                            <div id="filtrar" class="panel-collapse collapse">
                                <div class="panel-body">
                                    <div class="row">
                                        <div class="col-md-12">
                                            <label>Categoria</label><br />
                                            <div class="input-group">
                                                <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="form-control"></asp:DropDownList>
                                                <span class="input-group-btn">
                                                    <asp:Button ID="btnFiltrar" runat="server" CssClass="btn btn-primary" Text="Filtrar" OnClick="btnFiltrar_Click" />
                                                </span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-12">
                    <asp:GridView ID="gvProcesso" CssClass="table table-striped" runat="server" AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="gvProcesso_RowCommand">
                        <Columns>
                            <asp:TemplateField HeaderText="Numero">
                                <ItemTemplate>
                                    <asp:Label ID="lblNumero" runat="server" Text='<%#Eval("Numero")%>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Categoria">
                                <ItemTemplate>
                                    <asp:Label ID="lblCategoria" runat="server" Text='<%#Eval("DescricaoCategoria")%>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Interessado">
                                <ItemTemplate>
                                    <asp:Label ID="lblInteressado" runat="server" Text='<%#Eval("NomeInteressado")%>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Data Julgamento">
                                <ItemTemplate>
                                    <asp:Label ID="lblDataJulgamento" runat="server" Text='<%#Eval("DataJulgamento")%>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lkbEditar" runat="server" CommandName="Editar" CommandArgument='<%#Eval("Numero")%>' CssClass="btn btn-default"><i class="glyphicon glyphicon-pencil"></i></asp:LinkButton>
                                    <asp:LinkButton ID="lkbExcluir" runat="server" CommandName="Excluir" CommandArgument='<%#Eval("Numero")%>' CssClass="btn btn-default"><i class="glyphicon glyphicon-trash"></i></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
                <div class="col-md-12">
                    <a href="CadastrarProcesso.aspx" class="btn btn-primary">Cadastrar Processo</a>
                    <a href="CadastrarInterresado.aspx" class="btn btn-primary">Cadastrar Interessado</a>
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
