using System;
using System.Collections.Generic;
using System.Web;

namespace PracticeScriptLink.Classes
{
    public class FieldObject
    {
        public string Enabled;
        public string FieldNumber;
        public string FieldValue;
        public string Lock;
        public string Required;

        public FieldObject()
        {
        }
        public FieldObject(string fieldNumber)
        {
            this.FieldNumber = fieldNumber;
        }
    }
}