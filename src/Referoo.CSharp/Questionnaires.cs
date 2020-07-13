using Newtonsoft.Json;
using Referoo.CSharp.Models;
using System;

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

        /// <summary>
        /// This endpoint will return an array of questionnaires linked to this account in order of creation date. Only public or published questionaires will be returned. Draft items are not accessible.
        /// </summary>
        /// <param name="offset">The number of items to skip before starting to collect the result set</param>
        /// <param name="limit">The numbers of items to return. Up to 50 items can be returned at a time</param>
        /// <returns></returns>
        public GetQuestionnairesResponse ListQuestionnaires(long? offset, long? limit)
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
