using System;
using Microsoft.Azure.Management.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;

namespace ACSDeploymentsUniqueNameValidationService
{

	public static class MicrosoftAzureServiceConnector
	{

		#region Fields

		//private static string _connectionString = string.Empty;

		private static string _azureClientID = string.Empty;
		private static string _azureClientSecret = string.Empty;
		private static string _azureSubscriptionID = string.Empty;
		private static string _azureTenantID = string.Empty;

		#endregion

		#region Properties

		//public static string ConnectionString
		//{
		//	get => _connectionString;
		//	set => _connectionString = value;
		//}

		/// <summary>
		/// Gets the AzureClientID
		/// </summary>
		public static string AzureClientID
		{
			get => _azureClientID;
		}

		/// <summary>
		/// Gets the AzureClientSecret
		/// </summary>
		public static string AzureClientSecret
		{
			get => _azureClientSecret;
		}

		/// <summary>
		/// Gets the AzureSubscriptionID
		/// </summary>
		public static string AzureSubscriptionID
		{
			get => _azureSubscriptionID;
		}

		/// <summary>
		/// Gets the AzureTenantID
		/// </summary>
		public static string AzureTenantID
		{
			get => _azureTenantID;
		}

		#endregion

		#region Methods

		public static IAzure Connect( string azureClientID , string azureClientSecret , string azureSubscriptionID , string azureTenantID )
		{

			IAzure azure;

			try
			{

				//Logger.AddServiceLog( "ACS.ITSM.Connect.Business.MicrosoftAzureServiceConnector.Connect() - Start" , false );

				_azureClientID = azureClientID;
				_azureClientSecret = azureClientSecret;
				_azureSubscriptionID = azureSubscriptionID;
				_azureTenantID = azureTenantID;

				azure = GetAzureObject();

				//Logger.AddServiceLog( "ACS.ITSM.Connect.Business.MicrosoftAzureServiceConnector.Connect() - Complete" , false );


			}
			catch( Exception ex )
			{
				//Logger.AddServiceLog( "ACS.ITSM.Connect.Business.MicrosoftAzureServiceConnector.Connect() - Unhandled Exception: " + ex.ToString() , true );

				throw;
			}

			return azure;

		}

		private static IAzure GetAzureObject()
		{

			IAzure azure;
			AzureCredentials credentials;

			try
			{

				//Logger.AddServiceLog( "ACS.ITSM.Connect.Business.MicrosoftAzureServiceConnector.GetAzureObject() - Start" , false );

				credentials = SdkContext.AzureCredentialsFactory.FromServicePrincipal( AzureClientID , AzureClientSecret , AzureTenantID , AzureEnvironment.AzureGlobalCloud );

				azure = Azure
					.Configure()
					.WithLogLevel( HttpLoggingDelegatingHandler.Level.Basic )
					.Authenticate( credentials )
					.WithSubscription( AzureSubscriptionID );

				//Logger.AddServiceLog( "ACS.ITSM.Connect.Business.MicrosoftAzureServiceConnector.GetAzureObject() - Complete" , false );

			}
			catch( Exception ex )
			{
				//Logger.AddServiceLog( "ACS.ITSM.Connect.Business.MicrosoftAzureServiceConnector.GetAzureObject() - Unhandled Exception: " + ex.ToString() , true );

				throw;
			}

			return azure;

		}

		#endregion

	}
}