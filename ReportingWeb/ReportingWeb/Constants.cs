using System;

namespace ReportingWeb
{
    public static class Constants
    {
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