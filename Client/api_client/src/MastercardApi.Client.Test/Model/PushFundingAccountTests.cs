/*
 * Token Connect API
 *
 * The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed. All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded. 
 *
 * The version of the OpenAPI document: 2.03
 * Contact: apisupport@mastercard.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using MastercardApi.Client.Api;
using MastercardApi.Client.Model;
using MastercardApi.Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace MastercardApi.Client.Test.Model
{
    /// <summary>
    ///  Class for testing PushFundingAccount
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PushFundingAccountTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PushFundingAccount
        //private PushFundingAccount instance;

        public PushFundingAccountTests()
        {
            // TODO uncomment below to create an instance of PushFundingAccount
            //instance = new PushFundingAccount();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PushFundingAccount
        /// </summary>
        [Fact]
        public void PushFundingAccountInstanceTest()
        {
            // TODO uncomment below to test "IsType" PushFundingAccount
            //Assert.IsType<PushFundingAccount>(instance);
        }


        /// <summary>
        /// Test the property 'EncryptedPayload'
        /// </summary>
        [Fact]
        public void EncryptedPayloadTest()
        {
            // TODO unit test for the property 'EncryptedPayload'
        }

    }

}