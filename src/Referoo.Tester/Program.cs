using System;

namespace Referoo.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var accessToken = "";
            var refreshToken = "";

            var referooClient = new Referoo.NetStandard.ReferooClient(accessToken, refreshToken);

            var questionnaries = referooClient.Questionnaires.ListQuestionnaires();
        }
    }
}
