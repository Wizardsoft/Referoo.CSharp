using System;

namespace Referoo.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var accessToken = "";
            var refreshToken = "";

            var referooClient = new Referoo.CSharp.ReferooClient(accessToken, refreshToken, true);

            var questionnaries = referooClient.Questionnaires.ListQuestionnaires();
        }
    }
}
