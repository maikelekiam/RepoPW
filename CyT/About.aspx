<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="CyT.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style type="text/css">
        body {
            background-color: #666666;
        }

        #login {
            /*border:1px solid red;*/
            width: 280px;
            margin: 100px auto;
            background-color: #FFF;
            padding: 10px 10px;
            -webkit-box-shadow: 0 1px 5px #000;
            -moz-box-shadow: 0 1px 5px #000;
            box-shadow: 0 1px 5px #000;
        }

        #txtNome, #txtSenha {
            display: table;
            padding: 5px 10px;
            width: 250px;
        }

        #resposta {
            color: #3366FF;
            font-family: Verdana;
            font-weight: bold;
            text-shadow: 0 1px 2px #000;
            position: absolute;
            margin-top: -80px;
            margin-left: 500px;
        }

        #aviso {
            background-color: #FFFFCC;
            padding: 10px 10px;
            width: 130px;
            -webkit-box-shadow: 0 1px 3px #000;
            -webkit-border-radius: 3px;
            position: absolute;
            margin-top: -280px;
            margin-left: 550px;
            display: none;
        }

            #aviso label {
                display: table;
                font-family: Verdana;
            }
    </style>




    <br />
    <br />
    <br />
    <br />
    <br />
    <br />




    <div>
        <asp:TextBox runat="server" ID="txtNome" placeholder="Login..."></asp:TextBox>
        <asp:TextBox runat="server" ID="txtSenha" placeholder="Password..."></asp:TextBox>
        <input id="btnLogin" type="button" value="Apretar"
            onclick="Pintar()" />

        <%--<asp:Button runat="server" ID="btnLogin" Text="Login"></asp:TextBox>--%>
    </div>
    <span id="resposta"></span>
    <%--<asp:Label ID="resposta" runat="server"></asp:Label>--%>




    <script type="text/javascript">
        function Pintar() {
            $("#btnLogin").click(function () {
                var login = $('<%= txtNome.ClientID %>').val();
                var senha = $('<%= txtSenha.ClientID %>').val();
                //var login = $("#txtNome").val();
                //var senha = $("#txtSenha").val();
                $.ajax({
                    type: "POST",
                    url: "About.aspx/Login",
                    data: '{login: "' + $("#<%=txtNome.ClientID%>")[0].value +
                        '", senha: "' + $("#<%=txtSenha.ClientID%>")[0].value + '"}',

                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (data) {
                        $("#resposta").text(data.d);
                        //alert(data.d);
                    },
                    error: function (data) {
                        alert(data.d);
                    }
                });
            });
        };
    </script>

</asp:Content>
