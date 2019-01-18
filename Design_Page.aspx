<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PICOYPLACA.aspx.cs" Inherits="NewFolder1_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .pdd, td, tr
        {
            padding: 20px;
        }
        table, body
        {
            background-color: #EAFEDF;
        }
        .button
        {
            background-color: #4CAF50; /* Green */
            border: none;
            color: white;
            padding: 20px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-family: "Comic Sans MS" , cursive, sans-serif;
            font-size: 16px;
            margin: 4px 2px;
            cursor: pointer;
            border-radius: 4px;
        }
        body
        {
            font-weight: bold;
            font-family: "Comic Sans MS" , cursive, sans-serif;
        }
    </style>

</head>
<body>
    <form action="" name="form2" runat="server">
    <div>
        <center>
            <table>
                <tr>
                    <td colspan="2" align="center" style="text-decoration: underline; font-size: 30px;">
                        PICO Y PLACA PREDICTOR
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        License Plate Number :
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TextBox1" runat="server" placeholder="XXX-1111"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Date :
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TextBox2" runat="server" placeholder="YYYY/MM/DD"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Time :
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TextBox3" runat="server" placeholder="HH:MM"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="Button1" class="button" runat="server" Text="Check Status" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </center>
    </div>
    </form>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.0/jquery.validate.min.js" type="text/javascript"></script>

    <script>
        function licenceno{
            var exp=([A-Za-z]{2,3})-(\d{3,4})\w;

        }
    </script>
</body>
</html>
