<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="_default.aspx.cs" Inherits="EF.Data.Repository.Library1._default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>


<asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>



    <div id = "dvGrid" style ="padding:10px;width:550px">

<asp:UpdatePanel ID="UpdatePanel1" runat="server">

<ContentTemplate>

<asp:GridView ID="grdPerson" runat="server"  Width = "550px"

AutoGenerateColumns = "false" Font-Names = "Arial" 

Font-Size = "11pt" AlternatingRowStyle-BackColor = "#C2D69B"  

HeaderStyle-BackColor = "Black" AllowPaging ="true" HeaderStyle-ForeColor="White"  ShowFooter = "true"  

OnPageIndexChanging = "OnPaging" onrowediting="EditPerson"

onrowupdating="UpdatePerson"  onrowcancelingedit="CancelEdit"

PageSize = "10" >

<Columns>

<asp:TemplateField ItemStyle-Width = "30px"  HeaderText = "ID">

    <ItemTemplate>

        <asp:Label ID="lblId" runat="server" 

        Text='<%# Eval("Id")%>'></asp:Label>

    </ItemTemplate> 

    <FooterTemplate>

        <asp:TextBox ID="txtId" Width = "40px" 

            MaxLength = "5" runat="server"></asp:TextBox>

    </FooterTemplate> 

</asp:TemplateField> 

<asp:TemplateField ItemStyle-Width = "100px"  HeaderText = "Name">

    <ItemTemplate>

        <asp:Label ID="lblName" runat="server" 

                Text='<%# Eval("Name")%>'></asp:Label>

    </ItemTemplate>

    <EditItemTemplate>

        <asp:TextBox ID="txtName" runat="server" 

            Text='<%# Eval("Name")%>'></asp:TextBox>

    </EditItemTemplate>  

    <FooterTemplate>

        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>

    </FooterTemplate> 

</asp:TemplateField>



<asp:TemplateField>

    <ItemTemplate>

        <asp:LinkButton ID="lnkRemove" runat="server" 

            CommandArgument = '<%# Eval("Id")%>' 

         OnClientClick = "return confirm('Do you want to delete?')"

        Text = "Delete" OnClick = "DeletePerson"></asp:LinkButton>

    </ItemTemplate>

    <FooterTemplate>

        <asp:Button ID="btnAdd" runat="server" Text="Add" 

            OnClick = "AddNewPerson" />

    </FooterTemplate> 

</asp:TemplateField> 

<asp:CommandField  ShowEditButton="True" /> 

</Columns> 

<AlternatingRowStyle BackColor="#C2D69B"  />

</asp:GridView> 

</ContentTemplate> 

<Triggers>

<asp:AsyncPostBackTrigger ControlID = "grdPerson" /> 

</Triggers> 

</asp:UpdatePanel> 

</div>

 


        



    </div>
    </form>
</body>
</html>
