﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMDbWebApp
{
    /// <summary>
    /// Deze pagina handelt de fouten van de website af. Als pagina's niet bestaan, of wanneer er een fout optreedt
    /// </summary>
    public partial class Errorpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "404 Error | IMDb";
            string exception = Request.QueryString["exception"];
            lblFout.Text = "De gevonden fout is: " + exception;
        }
    }
}