/*
 * Token Connect API
 *
 * The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed. All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded. 
 *
 * The version of the OpenAPI document: 2.03
 * Contact: apisupport@mastercard.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using MastercardApi.Client.Client;
using MastercardApi.Client.Model;

namespace MastercardApi.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGetAssetsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve static Assets from MDES&#39;s repository, such as Token Requestors&#39; logos
        /// </summary>
        /// <remarks>
        /// This API is used to retrieve static Assets from MDES repository, such as the Token Requestor logo. Every Asset in the repository is referenced using an Asset ID. Once an Asset has been assigned to an Asset ID, the contents of the Asset will not change. If contents needs to change (for example, Token Requestor has supplied new artwork), they will be updated in the repository and be assigned a new Asset ID. Different types of Assets are supported in the repository, such as images and text files; for each type of Asset, multiple formats may be supported. For example, a single image asset may be supported in various file formats, or variant sizes. This allows the Issuer to select the most appropriate format to use for a particular target. 
        /// </remarks>
        /// <exception cref="MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assetId">An Asset ID corresponding to an individual Digital Asset. The Asset ID itself is supplied as a Get request in the form of https://{ENVIRONMENT URL GOES HERE}/mdes/issuer-assets/static/TODO/asset/tokenrequestor/{AssetID}. The Asset ID of a Token Requestor is returned as part of the Token Requestor Data from the getEligibleTokenRequestors Response. </param>
        /// <returns>AssetResponse</returns>
        AssetResponse GetAsset(string assetId);

        /// <summary>
        /// Retrieve static Assets from MDES&#39;s repository, such as Token Requestors&#39; logos
        /// </summary>
        /// <remarks>
        /// This API is used to retrieve static Assets from MDES repository, such as the Token Requestor logo. Every Asset in the repository is referenced using an Asset ID. Once an Asset has been assigned to an Asset ID, the contents of the Asset will not change. If contents needs to change (for example, Token Requestor has supplied new artwork), they will be updated in the repository and be assigned a new Asset ID. Different types of Assets are supported in the repository, such as images and text files; for each type of Asset, multiple formats may be supported. For example, a single image asset may be supported in various file formats, or variant sizes. This allows the Issuer to select the most appropriate format to use for a particular target. 
        /// </remarks>
        /// <exception cref="MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assetId">An Asset ID corresponding to an individual Digital Asset. The Asset ID itself is supplied as a Get request in the form of https://{ENVIRONMENT URL GOES HERE}/mdes/issuer-assets/static/TODO/asset/tokenrequestor/{AssetID}. The Asset ID of a Token Requestor is returned as part of the Token Requestor Data from the getEligibleTokenRequestors Response. </param>
        /// <returns>ApiResponse of AssetResponse</returns>
        ApiResponse<AssetResponse> GetAssetWithHttpInfo(string assetId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGetAssetsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve static Assets from MDES&#39;s repository, such as Token Requestors&#39; logos
        /// </summary>
        /// <remarks>
        /// This API is used to retrieve static Assets from MDES repository, such as the Token Requestor logo. Every Asset in the repository is referenced using an Asset ID. Once an Asset has been assigned to an Asset ID, the contents of the Asset will not change. If contents needs to change (for example, Token Requestor has supplied new artwork), they will be updated in the repository and be assigned a new Asset ID. Different types of Assets are supported in the repository, such as images and text files; for each type of Asset, multiple formats may be supported. For example, a single image asset may be supported in various file formats, or variant sizes. This allows the Issuer to select the most appropriate format to use for a particular target. 
        /// </remarks>
        /// <exception cref="MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assetId">An Asset ID corresponding to an individual Digital Asset. The Asset ID itself is supplied as a Get request in the form of https://{ENVIRONMENT URL GOES HERE}/mdes/issuer-assets/static/TODO/asset/tokenrequestor/{AssetID}. The Asset ID of a Token Requestor is returned as part of the Token Requestor Data from the getEligibleTokenRequestors Response. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetResponse</returns>
        System.Threading.Tasks.Task<AssetResponse> GetAssetAsync(string assetId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve static Assets from MDES&#39;s repository, such as Token Requestors&#39; logos
        /// </summary>
        /// <remarks>
        /// This API is used to retrieve static Assets from MDES repository, such as the Token Requestor logo. Every Asset in the repository is referenced using an Asset ID. Once an Asset has been assigned to an Asset ID, the contents of the Asset will not change. If contents needs to change (for example, Token Requestor has supplied new artwork), they will be updated in the repository and be assigned a new Asset ID. Different types of Assets are supported in the repository, such as images and text files; for each type of Asset, multiple formats may be supported. For example, a single image asset may be supported in various file formats, or variant sizes. This allows the Issuer to select the most appropriate format to use for a particular target. 
        /// </remarks>
        /// <exception cref="MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assetId">An Asset ID corresponding to an individual Digital Asset. The Asset ID itself is supplied as a Get request in the form of https://{ENVIRONMENT URL GOES HERE}/mdes/issuer-assets/static/TODO/asset/tokenrequestor/{AssetID}. The Asset ID of a Token Requestor is returned as part of the Token Requestor Data from the getEligibleTokenRequestors Response. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AssetResponse>> GetAssetWithHttpInfoAsync(string assetId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGetAssetsApi : IGetAssetsApiSync, IGetAssetsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GetAssetsApi : IGetAssetsApi
    {
        private MastercardApi.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GetAssetsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GetAssetsApi(string basePath)
        {
            this.Configuration = MastercardApi.Client.Client.Configuration.MergeConfigurations(
                MastercardApi.Client.Client.GlobalConfiguration.Instance,
                new MastercardApi.Client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new MastercardApi.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new MastercardApi.Client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = MastercardApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GetAssetsApi(MastercardApi.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = MastercardApi.Client.Client.Configuration.MergeConfigurations(
                MastercardApi.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new MastercardApi.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new MastercardApi.Client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = MastercardApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public GetAssetsApi(MastercardApi.Client.Client.ISynchronousClient client, MastercardApi.Client.Client.IAsynchronousClient asyncClient, MastercardApi.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = MastercardApi.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public MastercardApi.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public MastercardApi.Client.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public MastercardApi.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public MastercardApi.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Retrieve static Assets from MDES&#39;s repository, such as Token Requestors&#39; logos This API is used to retrieve static Assets from MDES repository, such as the Token Requestor logo. Every Asset in the repository is referenced using an Asset ID. Once an Asset has been assigned to an Asset ID, the contents of the Asset will not change. If contents needs to change (for example, Token Requestor has supplied new artwork), they will be updated in the repository and be assigned a new Asset ID. Different types of Assets are supported in the repository, such as images and text files; for each type of Asset, multiple formats may be supported. For example, a single image asset may be supported in various file formats, or variant sizes. This allows the Issuer to select the most appropriate format to use for a particular target. 
        /// </summary>
        /// <exception cref="MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assetId">An Asset ID corresponding to an individual Digital Asset. The Asset ID itself is supplied as a Get request in the form of https://{ENVIRONMENT URL GOES HERE}/mdes/issuer-assets/static/TODO/asset/tokenrequestor/{AssetID}. The Asset ID of a Token Requestor is returned as part of the Token Requestor Data from the getEligibleTokenRequestors Response. </param>
        /// <returns>AssetResponse</returns>
        public AssetResponse GetAsset(string assetId)
        {
            MastercardApi.Client.Client.ApiResponse<AssetResponse> localVarResponse = GetAssetWithHttpInfo(assetId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve static Assets from MDES&#39;s repository, such as Token Requestors&#39; logos This API is used to retrieve static Assets from MDES repository, such as the Token Requestor logo. Every Asset in the repository is referenced using an Asset ID. Once an Asset has been assigned to an Asset ID, the contents of the Asset will not change. If contents needs to change (for example, Token Requestor has supplied new artwork), they will be updated in the repository and be assigned a new Asset ID. Different types of Assets are supported in the repository, such as images and text files; for each type of Asset, multiple formats may be supported. For example, a single image asset may be supported in various file formats, or variant sizes. This allows the Issuer to select the most appropriate format to use for a particular target. 
        /// </summary>
        /// <exception cref="MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assetId">An Asset ID corresponding to an individual Digital Asset. The Asset ID itself is supplied as a Get request in the form of https://{ENVIRONMENT URL GOES HERE}/mdes/issuer-assets/static/TODO/asset/tokenrequestor/{AssetID}. The Asset ID of a Token Requestor is returned as part of the Token Requestor Data from the getEligibleTokenRequestors Response. </param>
        /// <returns>ApiResponse of AssetResponse</returns>
        public MastercardApi.Client.Client.ApiResponse<AssetResponse> GetAssetWithHttpInfo(string assetId)
        {
            // verify the required parameter 'assetId' is set
            if (assetId == null)
                throw new MastercardApi.Client.Client.ApiException(400, "Missing required parameter 'assetId' when calling GetAssetsApi->GetAsset");

            MastercardApi.Client.Client.RequestOptions localVarRequestOptions = new MastercardApi.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = MastercardApi.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = MastercardApi.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("AssetId", MastercardApi.Client.Client.ClientUtils.ParameterToString(assetId)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<AssetResponse>("/issuer-assets/1/0/asset/tokenrequestor/{AssetId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAsset", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve static Assets from MDES&#39;s repository, such as Token Requestors&#39; logos This API is used to retrieve static Assets from MDES repository, such as the Token Requestor logo. Every Asset in the repository is referenced using an Asset ID. Once an Asset has been assigned to an Asset ID, the contents of the Asset will not change. If contents needs to change (for example, Token Requestor has supplied new artwork), they will be updated in the repository and be assigned a new Asset ID. Different types of Assets are supported in the repository, such as images and text files; for each type of Asset, multiple formats may be supported. For example, a single image asset may be supported in various file formats, or variant sizes. This allows the Issuer to select the most appropriate format to use for a particular target. 
        /// </summary>
        /// <exception cref="MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assetId">An Asset ID corresponding to an individual Digital Asset. The Asset ID itself is supplied as a Get request in the form of https://{ENVIRONMENT URL GOES HERE}/mdes/issuer-assets/static/TODO/asset/tokenrequestor/{AssetID}. The Asset ID of a Token Requestor is returned as part of the Token Requestor Data from the getEligibleTokenRequestors Response. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AssetResponse</returns>
        public async System.Threading.Tasks.Task<AssetResponse> GetAssetAsync(string assetId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            MastercardApi.Client.Client.ApiResponse<AssetResponse> localVarResponse = await GetAssetWithHttpInfoAsync(assetId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve static Assets from MDES&#39;s repository, such as Token Requestors&#39; logos This API is used to retrieve static Assets from MDES repository, such as the Token Requestor logo. Every Asset in the repository is referenced using an Asset ID. Once an Asset has been assigned to an Asset ID, the contents of the Asset will not change. If contents needs to change (for example, Token Requestor has supplied new artwork), they will be updated in the repository and be assigned a new Asset ID. Different types of Assets are supported in the repository, such as images and text files; for each type of Asset, multiple formats may be supported. For example, a single image asset may be supported in various file formats, or variant sizes. This allows the Issuer to select the most appropriate format to use for a particular target. 
        /// </summary>
        /// <exception cref="MastercardApi.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="assetId">An Asset ID corresponding to an individual Digital Asset. The Asset ID itself is supplied as a Get request in the form of https://{ENVIRONMENT URL GOES HERE}/mdes/issuer-assets/static/TODO/asset/tokenrequestor/{AssetID}. The Asset ID of a Token Requestor is returned as part of the Token Requestor Data from the getEligibleTokenRequestors Response. </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AssetResponse)</returns>
        public async System.Threading.Tasks.Task<MastercardApi.Client.Client.ApiResponse<AssetResponse>> GetAssetWithHttpInfoAsync(string assetId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'assetId' is set
            if (assetId == null)
                throw new MastercardApi.Client.Client.ApiException(400, "Missing required parameter 'assetId' when calling GetAssetsApi->GetAsset");


            MastercardApi.Client.Client.RequestOptions localVarRequestOptions = new MastercardApi.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = MastercardApi.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = MastercardApi.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("AssetId", MastercardApi.Client.Client.ClientUtils.ParameterToString(assetId)); // path parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<AssetResponse>("/issuer-assets/1/0/asset/tokenrequestor/{AssetId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAsset", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
