﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleASPNetApp
{
    public partial class _Default : Page
    {
        public string CurrentDateTime;
        protected void Page_Load(object sender, EventArgs e)
        {
            CurrentDateTime = System.DateTime.Now.ToString();
        }
    }
}