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
    ///  Class for testing MediaContent
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MediaContentTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MediaContent
        //private MediaContent instance;

        public MediaContentTests()
        {
            // TODO uncomment below to create an instance of MediaContent
            //instance = new MediaContent();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MediaContent
        /// </summary>
        [Fact]
        public void MediaContentInstanceTest()
        {
            // TODO uncomment below to test "IsType" MediaContent
            //Assert.IsType<MediaContent>(instance);
        }


        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            // TODO unit test for the property 'Data'
        }
        /// <summary>
        /// Test the property 'Height'
        /// </summary>
        [Fact]
        public void HeightTest()
        {
            // TODO unit test for the property 'Height'
        }
        /// <summary>
        /// Test the property 'Width'
        /// </summary>
        [Fact]
        public void WidthTest()
        {
            // TODO unit test for the property 'Width'
        }

    }

}
