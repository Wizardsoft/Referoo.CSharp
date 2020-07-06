using Newtonsoft.Json;
using Referoo.CSharp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Referoo.CSharp
{
    public class Questionnaires
    {
        #region Singleton Pattern
        private static object syncObject = new object();
        private static Questionnaires instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        public static Questionnaires Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (instance == null)
                    {
                        instance = new Questionnaires();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        public GetQuestionnairesResponse ListQuestionnaires(Int64? offset, Int64? limit)
        {
            var url = $"questionnaires/?";

            if (offset != null)
                url += $"offset={offset}&";

            if (limit != null)
                url += $"limit={limit}&";

            var json = HttpHelpers.HttpGet(url);
            var retVal = JsonConvert.DeserializeObject<GetQuestionnairesResponse>(json);
            return retVal;
        }
    }
}
