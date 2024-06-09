using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;

namespace FastDesign
{

    public class Program : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            application.CreateRibbonTab("FastDesign"); //Principal menu

                application.CreateRibbonPanel("FastDesign", "Edit Level"); //Second menu

                application.CreateRibbonPanel("FastDesign", "New Menu"); //Second menu

                application.CreateRibbonPanel("FastDesign", "New Menu1"); //Second menu

            return Result.Succeeded;
        }
    }
}
