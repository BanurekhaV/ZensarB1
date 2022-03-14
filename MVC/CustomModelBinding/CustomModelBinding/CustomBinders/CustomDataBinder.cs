using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomModelBinding.Models;

namespace CustomModelBinding.CustomBinders
{
    public class CustomDataBinder : IModelBinder
    {
        public object BindModel(ControllerContext cc, ModelBindingContext bc)
        {
            var request = cc.HttpContext.Request;

            string title = request.Form.Get("Title");
            string date = request.Form.Get("Date");
            string month = request.Form.Get("Month");
            string year = request.Form.Get("Year");
            return new CustomModel()
            {
                Title = title,
                DateHired = date + "/" + month + "/" + year
            };

            
        }
    }
}