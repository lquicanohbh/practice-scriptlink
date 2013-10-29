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
            var returnOptionObject = new OptionObject();
            switch (scriptName)
            {
                case "test":
                    returnOptionObject = MyTestFunction(optionObject);
                    break;
                default:
                    break;
            }
            return returnOptionObject;
        }

        private OptionObject MyTestFunction(OptionObject optionObject)
        {
            var returnOptionObject = new OptionObject();
            returnOptionObject.EntityID = optionObject.EntityID;
            returnOptionObject.EpisodeNumber = optionObject.EpisodeNumber;
            returnOptionObject.Facility = optionObject.Facility;
            returnOptionObject.OptionId = optionObject.OptionId;
            returnOptionObject.OptionStaffId = optionObject.OptionStaffId;
            returnOptionObject.OptionUserId = optionObject.OptionUserId;
            returnOptionObject.SystemCode = optionObject.SystemCode;
            returnOptionObject.ErrorCode = 3;
            returnOptionObject.ErrorMesg = "Hello World!";
            return returnOptionObject;
        }
    }
}
