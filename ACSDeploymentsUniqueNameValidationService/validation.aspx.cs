
using Microsoft.Azure.Management.Sql.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Microsoft.Azure.Management.Sql.Fluent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Azure.Management.Fluent;

namespace ACSDeploymentsUniqueNameValidationService
{
	public partial class validation : System.Web.UI.Page
	{

		#region Fields

		private string _result = string.Empty;

		#endregion

		#region Methods

		protected void Page_Load( object sender , EventArgs e )
		{
			try
			{ 

				string type = Request.QueryString[ "type" ].ToString();

				string value = Request.QueryString[ "value" ].ToString();
				

				_lblFailureValue.Text = value;
				_lblSuccessValue.Text = value;

				switch( type )
				{
					case "Microsoft.Sql/servers":

						_lblFailureType.Text = "SQL Server";
						_lblSuccesssType.Text = "SQL Server";

						_result = CheckSQLServerName( value.Replace( ".database.windows.net" , "" ) );

						if ( _result.Length > 0  )
						{
							_lblFailureReason.Text = _result;
							_pnlFailure.Visible = true;
							_pnlSuccess.Visible = false;
						}
						else
						{
							_pnlSuccess.Visible = true;
						}

						break;

					case "Microsoft.Web/sites":

						_lblFailureType.Text = "App Service Name";
						_lblSuccesssType.Text = "App Service Name";

						break;

				}
				
			}
			catch( Exception ex )
			{
				_pnlError.Visible = false;
				_lblError.Text = ex.ToString();
			}
		}

		private string CheckSQLServerName( string sqlServerName )
		{

			string returnValue = string.Empty;

			try
			{

				IAzure azure = MicrosoftAzureServiceConnector.Connect( "14758106-936d-4cf2-a56a-a61ea0f306bc" , "49ac55a3-b64b-4435-99ea-42c11ad0102c" , "5321d4b6-3766-4ce5-b820-3ece769bde38" , "43d92aa1-02a9-4639-9f45-992a257cd11f" );
				
			   ICheckNameAvailabilityResult result = azure.SqlServers.CheckNameAvailability( sqlServerName );
				
				if( !result.IsAvailable )
				{
					returnValue = result.UnavailabilityMessage;
				}

			}
			catch( Exception ex )
			{
				returnValue = ex.ToString();
			}
			
			return returnValue;

		}

		private void CheckWebAppName( string webAppName )
		{

		}

		#endregion

	}
	
}