using Newtonsoft.Json;
using Referoo.NetStandard.Models;

namespace Referoo.NetStandard
{
    public class Brands
    {
        #region Singleton Pattern
        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static Brands instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        public static Brands Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (instance == null)
                    {
                        instance = new Brands();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        public GetBrandsResponse GetBrands()
        {
            var url = "brands";
            var json = HttpHelpers.HttpGet(url);
            var retVal = JsonConvert.DeserializeObject<GetBrandsResponse>(json);
            return retVal;
        }
    }
}
