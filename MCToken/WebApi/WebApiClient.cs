
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MCToken.WebApi
{
    public class WebApiClient : IWebApiClient
    {
        private const string MEDIATYPE = "application/json";

        private readonly IHttpClientFactory _httpClientFactory;

        public WebApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task GetAsync(Uri uri, int timeout = 0, CancellationToken cancellationToken = default, bool skipSslValidation = false)
        {
            await DoRequestInternal(HttpMethod.Get, uri, timeout, null, cancellationToken, skipSslValidation);
        }

        public async Task<TResult> GetAsync<TResult>(Uri uri, int timeout = 0, CancellationToken cancellationToken = default, bool skipSslValidation = false)
        {
            var result = await DoRequestInternal<TResult>(HttpMethod.Get, uri, timeout, null, cancellationToken, skipSslValidation);
            return result;
        }

        public async Task PostAsync<TContent>(Uri uri, TContent content, int timeout = 0, CancellationToken cancellationToken = default, bool skipSslValidation = false)
        {
            await DoRequestInternal(HttpMethod.Post, uri, timeout, content, cancellationToken, skipSslValidation);
        }

        public async Task<TResult> PostAsync<TContent, TResult>(Uri uri, TContent content, int timeout = 0, CancellationToken cancellationToken = default, bool skipSslValidation = false)
        {
            var result = await DoRequestInternal<TResult>(HttpMethod.Post, uri, timeout, content, cancellationToken, skipSslValidation);
            return result;
        }

        private async Task<HttpResponseMessage> DoRequestInternal(HttpMethod httpMethod, Uri uri, int timeoutInSeconds = 0, object content = null, CancellationToken cancellationToken = default, bool skipSslValidation = false)
        {
            

            
            {
                var httpClient = skipSslValidation ? _httpClientFactory.CreateClient("SSLUntrusted") : _httpClientFactory.CreateClient();

                if (timeoutInSeconds > 0)
                    httpClient.Timeout = TimeSpan.FromSeconds(timeoutInSeconds);

                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(MEDIATYPE));

                var request = new HttpRequestMessage
                {
                    Method = httpMethod,
                    RequestUri = uri
                };

                if (content != null)
                {
                    var jsonContent = Serialization.SerializeUtf8(content);
                    request.Content = new StringContent(jsonContent, Encoding.UTF8, MEDIATYPE);
                    
                }
                else
                {
                   
                }

                var response = await httpClient.SendAsync(request, cancellationToken);

                if (response.Content != null)
                {
                    var contentString = await response.Content.ReadAsStringAsync();
                  
                }

                if (!response.IsSuccessStatusCode)
                    throw new WebApiException(response.ReasonPhrase, response.StatusCode);

                return response;
            }
           
        }

        private async Task<TResponse> DoRequestInternal<TResponse>(HttpMethod httpMethod, Uri uri, int timeoutInSeconds = 0, object content = null, CancellationToken cancellationToken = default, bool skipSslValidation = false)
        {
            var response = await DoRequestInternal(httpMethod, uri, timeoutInSeconds, content, cancellationToken, skipSslValidation);
            var responseContent = await response.Content.ReadAsStringAsync();
            var result = await Serialization.DeserializeUtf8Async<TResponse>(responseContent, cancellationToken);
            return result;
        }
    }
}
