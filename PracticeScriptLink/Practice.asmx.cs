using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using PracticeScriptLink.Classes;

namespace PracticeScriptLink
{
    /// <summary>
    /// Summary description for Practice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class Practice : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetVersion()
        {
            return "Version 1.0";
        }
        [WebMethod]
        public OptionObject RunScript(OptionObject optionObject, string scriptName)
        {
            switch (scriptName)
            {
                case "test":
                    break;
                default:
                    break;
            }
        }
    }
}
