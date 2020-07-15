using System;

namespace Referoo.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var accessToken = "1";
            var refreshToken = "1";

            var referooClient = new Referoo.NetStandard.ReferooClient(accessToken, refreshToken, true);

            var questionnaries = referooClient.Questionnaires.ListQuestionnaires();
        }
    }
}
