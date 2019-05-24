using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ACSDeploymentsUniqueNameValidationService
{
	public partial class validation : System.Web.UI.Page
	{
		protected void Page_Load( object sender , EventArgs e )
		{
			try
			{
				string type = Request.QueryString[ "type" ].ToString();

				string value = Request.QueryString[ "value" ].ToString();
				
				_lblFailureType.Text = type;
				_lblSuccesssType.Text = type;

				_lblFailureValue.Text = value;
				_lblSuccessValue.Text = value;

				_pnlSuccess.Visible = true;

			}
			catch( Exception ex )
			{
				_pnlError.Visible = false;
				_lblError.Text = ex.ToString();
			}
		}
	}
}