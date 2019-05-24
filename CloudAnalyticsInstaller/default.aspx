<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CloudAnalyticsInstaller._default" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cloud Analytics Installer</title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
			<br /><br />
			<table style="border:1px solid black;width:50%">
				
				<tr>
					<td colspan="2" style="align-content:center;text-align:center;background-color:black;color:white">Cloud Analytics Installer</td>
				</tr>
				<tr>
					<td colspan="2">&nbsp;</td>
				</tr>
				<tr>
					<td style="text-align:right;">
						<asp:Label ID="_lblLocation" runat="server" Text="Location:"></asp:Label>
					</td>
					<td>
						<asp:DropDownList ID="_ddlLocation" runat="server" >
							<asp:ListItem></asp:ListItem>
							<asp:ListItem Text="(US) East US" Value="East US"></asp:ListItem>
							<asp:ListItem Text="(US) East US 2" Value="East US 2"></asp:ListItem>
						</asp:DropDownList>
					</td>
				</tr>
				<!--<tr>
					<td style="text-align:right;">
						<asp:Label ID="_lblResourceGroup" runat="server" Text="Resource Group:"></asp:Label>
					</td>
					<td>
						<asp:TextBox ID="_txtResourceGroup" runat="server" Text=""></asp:TextBox>
					</td>
				</tr>-->
				<tr>
					<td style="text-align:right;">
						<asp:Label ID="_lblSQLServerEdition" runat="server" Text="SQL Server Edition:"></asp:Label>
					</td>
					<td>
						<asp:DropDownList ID="_ddlSQLServerEdition" runat="server" >
							<asp:ListItem></asp:ListItem>
							<asp:ListItem Text="Basic" Value="Basic"></asp:ListItem>
							<asp:ListItem Text="Standard" Value="Standard"></asp:ListItem>
							<asp:ListItem Text="Premium" Value="Premium"></asp:ListItem>
						</asp:DropDownList>
					</td>
				</tr>
				<tr>
					<td style="text-align:right;">
						<asp:Label ID="_lblSSQLServerName" runat="server" Text="SQL Server Name:"></asp:Label>
					</td>
					<td>
						<asp:TextBox ID="_txtSQLServerName" runat="server" Text=""></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td style="text-align:right;">
						<asp:Label ID="_lblSQLServerLogin" runat="server" Text="SQL Server Login:"></asp:Label>
					</td>
					<td>
						<asp:TextBox ID="_txtSQLServerLogin" runat="server"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td style="text-align:right;">
						<asp:Label ID="_lblSQLServerPassword" runat="server" Text="SQL Server Password:"></asp:Label>
					</td>
					<td>
						<asp:TextBox ID="_txtSQLServerPassword" runat="server"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td style="text-align:right;">
						<asp:Label ID="_lblSQLServerDatabase" runat="server" Text="SQL Server Database:"></asp:Label>
					</td>
					<td>
						<asp:TextBox ID="_txtSQLServerDatabase" runat="server"></asp:TextBox>
					</td>
				</tr>

				<tr>
					<td style="text-align:right;">
						<asp:Label ID="_lblAppServicePlanName" runat="server" Text="Web App Service Plan Name"></asp:Label>
					</td>
					<td>
						<asp:TextBox ID="_txtAppServicePlanName" runat="server" Text=""></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td style="text-align:right;">
						<asp:Label ID="_lblWebAppName" runat="server" Text="Web App Name"></asp:Label>
					</td>
					<td>
						<asp:TextBox ID="_txtWebAppName" runat="server" Text=""></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td style="text-align:right;">
						<asp:Label ID="_lblLicenseKey" runat="server" Text="30 Day Trial Key"></asp:Label>
					</td>
					<td>
						<asp:TextBox ID="_txtLicenseKey" runat="server" Text="XXXX-PRE-SETKEY-XXX"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td colspan="2">&nbsp;</td>
				</tr>
				<tr>
					<td colspan="2" style="text-align:right">
						<asp:Button ID="_btnInstall" runat="server" Text="Install Cloud Analytics" />
					</td>
				</tr>
				<tr>
					<td colspan="2">&nbsp;</td>
				</tr>
			</table>
        </div>
    </form>
</body>
</html>