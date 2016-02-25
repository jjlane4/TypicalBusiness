using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TypicalBusiness.Controllers
{
    /*
     * This allows the option to select the layout for a specific action
     * Set in the controller as [LayoutInjecter("_LayoutName")]
     */
    public class LayoutInjecterAttribute : ActionFilterAttribute
    {
        private readonly string _masterName;
        public LayoutInjecterAttribute(string masterName)
        {
            _masterName = masterName;
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            var result = filterContext.Result as ViewResult;
            if (result != null)
            {
                result.MasterName = _masterName;
            }
        }
    }
}