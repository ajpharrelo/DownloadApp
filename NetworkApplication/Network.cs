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
            KiB = 1024,
            MiB = 1024*1024,
            GiB = 1024*1024*1024
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
                throw new Exception("Bad Request\n" + "Status: " + response.StatusCode.ToString());
            }
        }
        
        public static string BytesToFormat(long bytes, ByteMeasurement measurement, bool AutoCalculate = false)
        {
            long final = 0;

            switch(measurement)
            {
                case ByteMeasurement.KiB:
                    final = bytes / (long) ByteMeasurement.KiB;
                    return final.ToString() + " KB";

                case ByteMeasurement.MiB:
                    final = bytes / (long) ByteMeasurement.MiB;
                    return final.ToString() + " MB";

                case ByteMeasurement.GiB:
                    final = bytes / (long) ByteMeasurement.GiB;
                    return final.ToString() + " GB";

                default:
                    return "";
            }
        }

        // Overload to return bytes in designated unit based on size.
        public static string BytesToFormat(long bytes, bool AutoCalculate = false)
        {
            if(bytes >= 1024 && bytes < (long) ByteMeasurement.MiB)
            {
                return (bytes / (long)ByteMeasurement.KiB).ToString() + " KB";
            }

            if (bytes >= 1024 * 1024 && bytes < (long) ByteMeasurement.GiB)
            {
                return (bytes / (long)ByteMeasurement.MiB).ToString() + " MB";
            }

            if (bytes >= (long) ByteMeasurement.GiB)
            {
                return (bytes / (long)ByteMeasurement.GiB).ToString() + " GB";
            }

            // If bytes is not greater than at least 1024, then return the value in bytes.
            return bytes.ToString() + " Bytes";
        }
    }
}
