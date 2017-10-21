﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;

namespace MCFly.Core.FieldTypes
{
    public class DateTime: FieldType
    {
        public DateTime()
        {
           
         
            BackOfficeEditView = UIOMatic.Constants.FieldEditors.DateTime;
            PropertyType = typeof(System.DateTime);
        }

        public override IEnumerable<string> RequiredJSFiles()
        {
            return "/App_Plugins/MCFly/assets/datepicker.min.js".AsEnumerableOfOne();
        }

        public override IEnumerable<string> RequiredCssFiles()
        {
            return "/App_Plugins/MCFly/assets/datepicker.min.css".AsEnumerableOfOne();
        }
       
    }
}