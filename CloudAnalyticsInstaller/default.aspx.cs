using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
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

				foreach( string s in Request.Headers.AllKeys )
				{
					Response.Write( s + ": " + Request.Headers[ s ].ToString() + "<BR><BR>" );
				}

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