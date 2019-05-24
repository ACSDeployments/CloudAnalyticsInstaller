<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validation.aspx.cs" Inherits="ACSDeploymentsUniqueNameValidationService.validation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ACS Deployments Unique Name Validation Service</title>
</head>
<body>
    <form id="_formMain" runat="server">
        <div style="margin:auto;width:50%;text-align:center;">
			<asp:Panel ID="_pnlError" runat="server" Visible="false">
				Error! <asp:Label ID="_lblError" runat="server"></asp:Label>
			</asp:Panel>
			<asp:Panel ID="_pnlSuccess" runat="server" Visible="false">
				<div style="text-align:center">
				<table style="font-family:Verdana;width:75%;border-radius: 30px 30px 30px 30px;border: 1px solid #bde76b;background: linear-gradient(0deg,#bde76b 0,#FFFFFF);">
					<tr>
						<td colspan="2">&nbsp;</td>
					</tr>
					<tr>
						<td style="vertical-align:central;"><img src="img/success.png" /></td>
						<td style="vertical-align:central;font-weight:bold;text-align:left;">
							<asp:Label ID="_lblSuccesssType" runat="server"></asp:Label>&nbsp;you chose is AVAILABLE!<br /><br /><asp:Label ID="_lblSuccessValue" runat="server"></asp:Label>
						</td>
					</tr>
					<tr>
						<td colspan="2">&nbsp;</td>
					</tr>
					<tr>
						<td colspan="2" style="text-align:center;align-content:center">
							<div onclick="window.close();"  title="Click here to continue" style="cursor:pointer;margin:auto;width:50%;width:200px;border-radius: 30px 30px 30px 30px;border: 2px solid #808080;background-color:#f2e9e9;color:#000000;font-weight:bold;">
								Continue
							</div>
						</td>
					</tr>
					<tr>
						<td colspan="2">&nbsp;</td>
					</tr>
				</table>
				</div>
			</asp:Panel>
			<asp:Panel ID="_pnlFailure" runat="server" Visible="false">
				<div style="text-align:center">
				<table style="font-family:Verdana;width:75%;border-radius: 30px 30px 30px 30px;border: 1px solid red;background: linear-gradient(90deg,#FFFFFF 0,#ed5959);">
					<tr>
						<td colspan="2">&nbsp;</td>
					</tr>
					<tr>
						<td style="vertical-align:central;"><img src="img/failure2.png" width="200" height="200" style="border-radius: 30px 30px 30px 30px;border: 1px solid #FFFFFF;"/></td>
						<td style="vertical-align:central;font-weight:bold;text-align:left;">
							The <asp:Label ID="_lblFailureType" runat="server"></asp:Label>&nbsp;you chose is NOT AVAILABLE!<br /><br /><asp:Label ID="_lblFailureValue" runat="server"></asp:Label>
							<br />
							<br />
							<asp:Label ID="_lblFailureReason" runat="server"></asp:Label>
						</td>
					</tr>
					<tr>
						<td colspan="2">&nbsp;</td>
					</tr>
					<tr>
						<td colspan="2">
							<div onclick="window.close();" title="Click here to go back & change" style="cursor:pointer;margin:auto;width:50%;width:200px;border-radius: 30px 30px 30px 30px;border: 2px solid #808080;background-color:#f2e9e9;color:#000000;font-weight:bold;">
								Go Back & Change
							</div>
						</td>
					</tr>
					<tr>
						<td colspan="2">&nbsp;</td>
					</tr>
				</table>
				</div>
			</asp:Panel>
			
			<br /><br />
        </div>
	
		
    </form>
</body>
</html>
