/* 
 * Phone.com API
 *
 * This is a Phone.com api Swagger definition
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apisupport@phone.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing CallsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CallsApiTests
    {
        private CallsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CallsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CallsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CallsApi
            //Assert.IsInstanceOfType(typeof(CallsApi), instance, "instance is a CallsApi");
        }

        
        /// <summary>
        /// Test CreateAccountCall
        /// </summary>
        [Test]
        public void CreateAccountCallTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountId = null;
            //CreateCallParams data = null;
            //var response = instance.CreateAccountCall(accountId, data);
            //Assert.IsInstanceOf<CallFull> (response, "response is CallFull");
        }
        
    }

}
