using System;
using System.Collections.Generic;
using System.Web;

namespace PracticeScriptLink.Classes
{
    public class FormObject
    {
        public RowObject CurrentRow;
        public string FormId;
        public bool MultipleIteration;
        public List<RowObject> OtherRows;
        public FormObject()
        {
            this.OtherRows = new List<RowObject>();
        }

        public FormObject(string FormId)
        {
            this.OtherRows = new List<RowObject>();
            this.FormId = FormId;
        }
    }
}