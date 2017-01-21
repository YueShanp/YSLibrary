using System.Net;

namespace YSLibrary.RestClient
{
    public interface IRestfulResponse
    {
        string RequestID { get; set; }

        string RequestedUrl { get; set; }

        bool IsSuccessStatusCode { get; set; }

        HttpStatusCode StatusCode { get; set; }

        string MessageCode { get; set; }

        string[] ReasonPhrase { get; set; }
    }
}
