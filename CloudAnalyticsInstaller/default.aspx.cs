using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CloudAnalyticsInstaller
{
	public partial class _default : System.Web.UI.Page
	{

		#region Methods

		protected void Page_Load( object sender , EventArgs e )
		{

			//UserPasswordCredential credential;
			//AuthenticationContext authenticationContext;
			//AuthenticationResult authenticationResult;
			//TokenCredentials tokenCredentials;

			try
			{

				try
				{
					_ddlLocation.SelectedValue = ConfigurationManager.AppSettings[ "setupLocation" ].ToString();
				}
				catch { }
				try
				{
					_txtSQLServerName.Text = ConfigurationManager.AppSettings[ "setupsqlServerName" ].ToString();
				}
				catch{}

				try
				{
					_txtSQLServerLogin.Text = ConfigurationManager.AppSettings[ "setupsqlServerLogin" ].ToString();
				}
				catch
				{ }

				try
				{
					_txtSQLServerPassword.Text = ConfigurationManager.AppSettings[ "setupsqlServerPassword" ].ToString();
				}
				catch { }

				try
				{
					_txtSQLServerName.Text = ConfigurationManager.AppSettings[ "setupsqlDbName" ].ToString();
				}
				catch
				{ }

				try
				{
					_ddlSQLServerEdition.SelectedValue = ConfigurationManager.AppSettings[ "setupsqlServerEdition" ].ToString();
				}
				catch { }

				try
				{
					_txtAppServicePlanName.Text = ConfigurationManager.AppSettings[ "setupappPlanName" ].ToString();
				}
				catch
				{
				}

				try
				{
					_txtWebAppName.Text = ConfigurationManager.AppSettings[ "setupappServiceName" ].ToString();
				}
				catch
				{

				}

				//foreach( string s in Request.Headers.AllKeys )
				//{
				//	Response.Write( s + ": " + Request.Headers[ s ].ToString() + "<BR><BR>" );
				//}

				//"setupLocation": "[parameters('location')]",
				//"setupsqlServerName": "[parameters('sqlServerName')]",
				//"setupsqlServerLogin": "[parameters('sqlServerLogin')]",
				//"setupsqlServerPassword": "[parameters('sqlServerPassword')]",
				//"setupsqlServerEdition": "[parameters('sqlServerEdition')]",
				//"setupsqlDbName": "[parameters('sqlDbName')]",
				//"setupappServiceName": "[parameters('appServiceName')]",
				//"setupappPlanName": "[parameters('appPlanName')]"

				//_client.DefaultRequestHeaders.Accept.Clear();
				//_client.DefaultRequestHeaders.Authorization =
				//	new AuthenticationHeaderValue( "Bearer" , Request.Headers[ "X-MS-TOKEN-AAD-ACCESS-TOKEN" ] );

				//credential = new UserPasswordCredential( "ddenault@appliedcloudsystems.com" , "a85aSd90!!" );

				//authenticationContext = new AuthenticationContext( "AuthorityURL" );

				//authenticationResult = authenticationContext.A( ResourceUrl , ApplicationId , credential );

				//authenticationResult = authenticationContext.AcquireTokenAsync( ResourceUrl , ApplicationId , credential );

				//if( authenticationResult == null )
				//{
				//result.ErrorMessage = "Authentication Failed.";
				//return result;
				//}

				//tokenCredentials = new TokenCredentials( authenticationResult.AccessToken , TokenType );


			}
			catch( Exception ex )
			{
				Response.Write( ex.ToString() );
			}
		}

		#endregion

	}

}