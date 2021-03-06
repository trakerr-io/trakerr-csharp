/* 
 * Trakerr API
 *
 * Get your application events and errors to Trakerr via the *Trakerr API*.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Trakerr.Client;
using IO.Trakerr.Model;

namespace IO.Trakerr.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEventsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Submit an application event or error to Trakerr
        /// </summary>
        /// <remarks>
        ///  The events endpoint submits an application event or an application error / exception with an optional stacktrace field to Trakerr.  ##### Sample POST request body: &#x60;&#x60;&#x60; {  \&quot;apiKey\&quot;: \&quot;a9a2807a2e8fd4602adae9e8f819790a267213234083\&quot;,  \&quot;classification\&quot;: \&quot;Error\&quot;,  \&quot;eventType\&quot;: \&quot;System.Exception\&quot;,  \&quot;eventMessage\&quot;: \&quot;This is a test exception.\&quot;,  \&quot;eventTime\&quot;: 1479477482291,  \&quot;eventStacktrace\&quot;: [    {      \&quot;type\&quot;: \&quot;System.Exception\&quot;,      \&quot;message\&quot;: \&quot;This is a test exception.\&quot;,      \&quot;traceLines\&quot;: [        {          \&quot;function\&quot;: \&quot;Main\&quot;,          \&quot;line\&quot;: 19,          \&quot;file\&quot;: \&quot;TrakerrSampleApp\\\\Program.cs\&quot;        }      ]    }  ],  \&quot;contextAppVersion\&quot;: \&quot;1.0\&quot;,  \&quot;contextEnvName\&quot;: \&quot;development\&quot;,  \&quot;contextEnvHostname\&quot;: \&quot;trakerr.io\&quot;,  \&quot;contextAppOS\&quot;: \&quot;Win32NT Service Pack 1\&quot;,  \&quot;contextAppOSVersion\&quot;: \&quot;6.1.7601.65536\&quot; } &#x60;&#x60;&#x60; ##### Sample POST response body (200 OK): &#x60;&#x60;&#x60; { } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="IO.Trakerr.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Event to submit</param>
        /// <returns></returns>
        void EventsPost (AppEvent data);

        /// <summary>
        /// Submit an application event or error to Trakerr
        /// </summary>
        /// <remarks>
        ///  The events endpoint submits an application event or an application error / exception with an optional stacktrace field to Trakerr.  ##### Sample POST request body: &#x60;&#x60;&#x60; {  \&quot;apiKey\&quot;: \&quot;a9a2807a2e8fd4602adae9e8f819790a267213234083\&quot;,  \&quot;classification\&quot;: \&quot;Error\&quot;,  \&quot;eventType\&quot;: \&quot;System.Exception\&quot;,  \&quot;eventMessage\&quot;: \&quot;This is a test exception.\&quot;,  \&quot;eventTime\&quot;: 1479477482291,  \&quot;eventStacktrace\&quot;: [    {      \&quot;type\&quot;: \&quot;System.Exception\&quot;,      \&quot;message\&quot;: \&quot;This is a test exception.\&quot;,      \&quot;traceLines\&quot;: [        {          \&quot;function\&quot;: \&quot;Main\&quot;,          \&quot;line\&quot;: 19,          \&quot;file\&quot;: \&quot;TrakerrSampleApp\\\\Program.cs\&quot;        }      ]    }  ],  \&quot;contextAppVersion\&quot;: \&quot;1.0\&quot;,  \&quot;contextEnvName\&quot;: \&quot;development\&quot;,  \&quot;contextEnvHostname\&quot;: \&quot;trakerr.io\&quot;,  \&quot;contextAppOS\&quot;: \&quot;Win32NT Service Pack 1\&quot;,  \&quot;contextAppOSVersion\&quot;: \&quot;6.1.7601.65536\&quot; } &#x60;&#x60;&#x60; ##### Sample POST response body (200 OK): &#x60;&#x60;&#x60; { } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="IO.Trakerr.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Event to submit</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> EventsPostWithHttpInfo (AppEvent data);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Submit an application event or error to Trakerr
        /// </summary>
        /// <remarks>
        ///  The events endpoint submits an application event or an application error / exception with an optional stacktrace field to Trakerr.  ##### Sample POST request body: &#x60;&#x60;&#x60; {  \&quot;apiKey\&quot;: \&quot;a9a2807a2e8fd4602adae9e8f819790a267213234083\&quot;,  \&quot;classification\&quot;: \&quot;Error\&quot;,  \&quot;eventType\&quot;: \&quot;System.Exception\&quot;,  \&quot;eventMessage\&quot;: \&quot;This is a test exception.\&quot;,  \&quot;eventTime\&quot;: 1479477482291,  \&quot;eventStacktrace\&quot;: [    {      \&quot;type\&quot;: \&quot;System.Exception\&quot;,      \&quot;message\&quot;: \&quot;This is a test exception.\&quot;,      \&quot;traceLines\&quot;: [        {          \&quot;function\&quot;: \&quot;Main\&quot;,          \&quot;line\&quot;: 19,          \&quot;file\&quot;: \&quot;TrakerrSampleApp\\\\Program.cs\&quot;        }      ]    }  ],  \&quot;contextAppVersion\&quot;: \&quot;1.0\&quot;,  \&quot;contextEnvName\&quot;: \&quot;development\&quot;,  \&quot;contextEnvHostname\&quot;: \&quot;trakerr.io\&quot;,  \&quot;contextAppOS\&quot;: \&quot;Win32NT Service Pack 1\&quot;,  \&quot;contextAppOSVersion\&quot;: \&quot;6.1.7601.65536\&quot; } &#x60;&#x60;&#x60; ##### Sample POST response body (200 OK): &#x60;&#x60;&#x60; { } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="IO.Trakerr.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Event to submit</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task EventsPostAsync (AppEvent data);

        /// <summary>
        /// Submit an application event or error to Trakerr
        /// </summary>
        /// <remarks>
        ///  The events endpoint submits an application event or an application error / exception with an optional stacktrace field to Trakerr.  ##### Sample POST request body: &#x60;&#x60;&#x60; {  \&quot;apiKey\&quot;: \&quot;a9a2807a2e8fd4602adae9e8f819790a267213234083\&quot;,  \&quot;classification\&quot;: \&quot;Error\&quot;,  \&quot;eventType\&quot;: \&quot;System.Exception\&quot;,  \&quot;eventMessage\&quot;: \&quot;This is a test exception.\&quot;,  \&quot;eventTime\&quot;: 1479477482291,  \&quot;eventStacktrace\&quot;: [    {      \&quot;type\&quot;: \&quot;System.Exception\&quot;,      \&quot;message\&quot;: \&quot;This is a test exception.\&quot;,      \&quot;traceLines\&quot;: [        {          \&quot;function\&quot;: \&quot;Main\&quot;,          \&quot;line\&quot;: 19,          \&quot;file\&quot;: \&quot;TrakerrSampleApp\\\\Program.cs\&quot;        }      ]    }  ],  \&quot;contextAppVersion\&quot;: \&quot;1.0\&quot;,  \&quot;contextEnvName\&quot;: \&quot;development\&quot;,  \&quot;contextEnvHostname\&quot;: \&quot;trakerr.io\&quot;,  \&quot;contextAppOS\&quot;: \&quot;Win32NT Service Pack 1\&quot;,  \&quot;contextAppOSVersion\&quot;: \&quot;6.1.7601.65536\&quot; } &#x60;&#x60;&#x60; ##### Sample POST response body (200 OK): &#x60;&#x60;&#x60; { } &#x60;&#x60;&#x60; 
        /// </remarks>
        /// <exception cref="IO.Trakerr.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Event to submit</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> EventsPostAsyncWithHttpInfo (AppEvent data);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class EventsApi : IEventsApi
    {
        private IO.Trakerr.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = IO.Trakerr.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EventsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Trakerr.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Trakerr.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Submit an application event or error to Trakerr  The events endpoint submits an application event or an application error / exception with an optional stacktrace field to Trakerr.  ##### Sample POST request body: &#x60;&#x60;&#x60; {  \&quot;apiKey\&quot;: \&quot;a9a2807a2e8fd4602adae9e8f819790a267213234083\&quot;,  \&quot;classification\&quot;: \&quot;Error\&quot;,  \&quot;eventType\&quot;: \&quot;System.Exception\&quot;,  \&quot;eventMessage\&quot;: \&quot;This is a test exception.\&quot;,  \&quot;eventTime\&quot;: 1479477482291,  \&quot;eventStacktrace\&quot;: [    {      \&quot;type\&quot;: \&quot;System.Exception\&quot;,      \&quot;message\&quot;: \&quot;This is a test exception.\&quot;,      \&quot;traceLines\&quot;: [        {          \&quot;function\&quot;: \&quot;Main\&quot;,          \&quot;line\&quot;: 19,          \&quot;file\&quot;: \&quot;TrakerrSampleApp\\\\Program.cs\&quot;        }      ]    }  ],  \&quot;contextAppVersion\&quot;: \&quot;1.0\&quot;,  \&quot;contextEnvName\&quot;: \&quot;development\&quot;,  \&quot;contextEnvHostname\&quot;: \&quot;trakerr.io\&quot;,  \&quot;contextAppOS\&quot;: \&quot;Win32NT Service Pack 1\&quot;,  \&quot;contextAppOSVersion\&quot;: \&quot;6.1.7601.65536\&quot; } &#x60;&#x60;&#x60; ##### Sample POST response body (200 OK): &#x60;&#x60;&#x60; { } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="IO.Trakerr.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Event to submit</param>
        /// <returns></returns>
        public void EventsPost (AppEvent data)
        {
             EventsPostWithHttpInfo(data);
        }

        /// <summary>
        /// Submit an application event or error to Trakerr  The events endpoint submits an application event or an application error / exception with an optional stacktrace field to Trakerr.  ##### Sample POST request body: &#x60;&#x60;&#x60; {  \&quot;apiKey\&quot;: \&quot;a9a2807a2e8fd4602adae9e8f819790a267213234083\&quot;,  \&quot;classification\&quot;: \&quot;Error\&quot;,  \&quot;eventType\&quot;: \&quot;System.Exception\&quot;,  \&quot;eventMessage\&quot;: \&quot;This is a test exception.\&quot;,  \&quot;eventTime\&quot;: 1479477482291,  \&quot;eventStacktrace\&quot;: [    {      \&quot;type\&quot;: \&quot;System.Exception\&quot;,      \&quot;message\&quot;: \&quot;This is a test exception.\&quot;,      \&quot;traceLines\&quot;: [        {          \&quot;function\&quot;: \&quot;Main\&quot;,          \&quot;line\&quot;: 19,          \&quot;file\&quot;: \&quot;TrakerrSampleApp\\\\Program.cs\&quot;        }      ]    }  ],  \&quot;contextAppVersion\&quot;: \&quot;1.0\&quot;,  \&quot;contextEnvName\&quot;: \&quot;development\&quot;,  \&quot;contextEnvHostname\&quot;: \&quot;trakerr.io\&quot;,  \&quot;contextAppOS\&quot;: \&quot;Win32NT Service Pack 1\&quot;,  \&quot;contextAppOSVersion\&quot;: \&quot;6.1.7601.65536\&quot; } &#x60;&#x60;&#x60; ##### Sample POST response body (200 OK): &#x60;&#x60;&#x60; { } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="IO.Trakerr.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Event to submit</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> EventsPostWithHttpInfo (AppEvent data)
        {
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling EventsApi->EventsPost");

            var localVarPath = "/events";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (data != null && data.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                localVarPostBody = data; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EventsPost", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Submit an application event or error to Trakerr  The events endpoint submits an application event or an application error / exception with an optional stacktrace field to Trakerr.  ##### Sample POST request body: &#x60;&#x60;&#x60; {  \&quot;apiKey\&quot;: \&quot;a9a2807a2e8fd4602adae9e8f819790a267213234083\&quot;,  \&quot;classification\&quot;: \&quot;Error\&quot;,  \&quot;eventType\&quot;: \&quot;System.Exception\&quot;,  \&quot;eventMessage\&quot;: \&quot;This is a test exception.\&quot;,  \&quot;eventTime\&quot;: 1479477482291,  \&quot;eventStacktrace\&quot;: [    {      \&quot;type\&quot;: \&quot;System.Exception\&quot;,      \&quot;message\&quot;: \&quot;This is a test exception.\&quot;,      \&quot;traceLines\&quot;: [        {          \&quot;function\&quot;: \&quot;Main\&quot;,          \&quot;line\&quot;: 19,          \&quot;file\&quot;: \&quot;TrakerrSampleApp\\\\Program.cs\&quot;        }      ]    }  ],  \&quot;contextAppVersion\&quot;: \&quot;1.0\&quot;,  \&quot;contextEnvName\&quot;: \&quot;development\&quot;,  \&quot;contextEnvHostname\&quot;: \&quot;trakerr.io\&quot;,  \&quot;contextAppOS\&quot;: \&quot;Win32NT Service Pack 1\&quot;,  \&quot;contextAppOSVersion\&quot;: \&quot;6.1.7601.65536\&quot; } &#x60;&#x60;&#x60; ##### Sample POST response body (200 OK): &#x60;&#x60;&#x60; { } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="IO.Trakerr.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Event to submit</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task EventsPostAsync (AppEvent data)
        {
             await EventsPostAsyncWithHttpInfo(data);

        }

        /// <summary>
        /// Submit an application event or error to Trakerr  The events endpoint submits an application event or an application error / exception with an optional stacktrace field to Trakerr.  ##### Sample POST request body: &#x60;&#x60;&#x60; {  \&quot;apiKey\&quot;: \&quot;a9a2807a2e8fd4602adae9e8f819790a267213234083\&quot;,  \&quot;classification\&quot;: \&quot;Error\&quot;,  \&quot;eventType\&quot;: \&quot;System.Exception\&quot;,  \&quot;eventMessage\&quot;: \&quot;This is a test exception.\&quot;,  \&quot;eventTime\&quot;: 1479477482291,  \&quot;eventStacktrace\&quot;: [    {      \&quot;type\&quot;: \&quot;System.Exception\&quot;,      \&quot;message\&quot;: \&quot;This is a test exception.\&quot;,      \&quot;traceLines\&quot;: [        {          \&quot;function\&quot;: \&quot;Main\&quot;,          \&quot;line\&quot;: 19,          \&quot;file\&quot;: \&quot;TrakerrSampleApp\\\\Program.cs\&quot;        }      ]    }  ],  \&quot;contextAppVersion\&quot;: \&quot;1.0\&quot;,  \&quot;contextEnvName\&quot;: \&quot;development\&quot;,  \&quot;contextEnvHostname\&quot;: \&quot;trakerr.io\&quot;,  \&quot;contextAppOS\&quot;: \&quot;Win32NT Service Pack 1\&quot;,  \&quot;contextAppOSVersion\&quot;: \&quot;6.1.7601.65536\&quot; } &#x60;&#x60;&#x60; ##### Sample POST response body (200 OK): &#x60;&#x60;&#x60; { } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <exception cref="IO.Trakerr.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Event to submit</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> EventsPostAsyncWithHttpInfo (AppEvent data)
        {
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling EventsApi->EventsPost");

            var localVarPath = "/events";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (data != null && data.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                localVarPostBody = data; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EventsPost", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
