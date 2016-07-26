using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSurveilance
{
    public static class Constants
    {
        public static int MinPathCountPoints = 5;

        public static string StorageConnectionString
        {
            get
            {
                return String.Format("DefaultEndpointsProtocol=https;AccountName={0};AccountKey={1}", AccountName, AccountKey);
            }
        }

        private static string AccountName = "";

        private static string AccountKey = "";
    }
}
