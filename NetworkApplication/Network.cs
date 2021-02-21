using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;

namespace NetworkC
{
    class Network
    {
        public struct Download
        {
            public string filename;
            public string url;
            public long size;
        }

        public enum ByteMeasurement
        {
            KB = 1024,
            MB = 1048576,
            GB = 1073741824
        }

        public static async Task<string> GetFileSize(Download download)
        {
            HttpClient Client = new HttpClient();
            HttpResponseMessage response = await Client.GetAsync(download.url, HttpCompletionOption.ResponseHeadersRead);
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                long bytes = (long)response.Content.Headers.ContentLength;
                return bytes.ToString();
            }
            else
            {
                throw new Exception("Bad Request.");
            }
        }
        
        public static string BytesToFormat(long bytes, ByteMeasurement measurement, bool AutoCalculate = false)
        {
            long final = 0;

            switch(measurement)
            {
                case ByteMeasurement.KB:
                    final = bytes / (long) ByteMeasurement.KB;
                    return final.ToString() + " KB";

                case ByteMeasurement.MB:
                    final = bytes / (long) ByteMeasurement.MB;
                    return final.ToString() + " MB";

                case ByteMeasurement.GB:
                    final = bytes / (long) ByteMeasurement.GB;
                    return final.ToString() + " GB";

                default:
                    return "";
            }
        }
    }
}
