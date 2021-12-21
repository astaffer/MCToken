using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MCToken.WebApi
{
    public interface IWebApiClient
    {
        Task GetAsync(Uri uri, int timeout = 0, CancellationToken cancellationToken = default, bool skipSslValidation = false);

        Task<TResult> GetAsync<TResult>(Uri uri, int timeout = 0, CancellationToken cancellationToken = default, bool skipSslValidation = false);

        Task PostAsync<TContent>(Uri uri, TContent content, int timeout = 0, CancellationToken cancellationToken = default, bool skipSslValidation = false);

        Task<TResult> PostAsync<TContent, TResult>(Uri uri, TContent content, int timeout = 0, CancellationToken cancellationToken = default, bool skipSslValidation = false);
    }
}
