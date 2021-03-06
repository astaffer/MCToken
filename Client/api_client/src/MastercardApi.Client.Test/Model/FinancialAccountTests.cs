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
    ///  Class for testing FinancialAccount
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class FinancialAccountTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for FinancialAccount
        //private FinancialAccount instance;

        public FinancialAccountTests()
        {
            // TODO uncomment below to create an instance of FinancialAccount
            //instance = new FinancialAccount();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FinancialAccount
        /// </summary>
        [Fact]
        public void FinancialAccountInstanceTest()
        {
            // TODO uncomment below to test "IsType" FinancialAccount
            //Assert.IsType<FinancialAccount>(instance);
        }


        /// <summary>
        /// Test the property 'FinancialAccountId'
        /// </summary>
        [Fact]
        public void FinancialAccountIdTest()
        {
            // TODO unit test for the property 'FinancialAccountId'
        }
        /// <summary>
        /// Test the property 'InterbankCardAssociationId'
        /// </summary>
        [Fact]
        public void InterbankCardAssociationIdTest()
        {
            // TODO unit test for the property 'InterbankCardAssociationId'
        }
        /// <summary>
        /// Test the property 'CountryCode'
        /// </summary>
        [Fact]
        public void CountryCodeTest()
        {
            // TODO unit test for the property 'CountryCode'
        }

    }

}
