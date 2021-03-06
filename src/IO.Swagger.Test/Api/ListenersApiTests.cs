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
    ///  Class for testing ListenersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ListenersApiTests
    {
        private ListenersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ListenersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ListenersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ListenersApi
            //Assert.IsInstanceOfType(typeof(ListenersApi), instance, "instance is a ListenersApi");
        }

        
        /// <summary>
        /// Test CreateAccountListener
        /// </summary>
        [Test]
        public void CreateAccountListenerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountId = null;
            //CreateListenerParams data = null;
            //var response = instance.CreateAccountListener(accountId, data);
            //Assert.IsInstanceOf<ListenerFull> (response, "response is ListenerFull");
        }
        
        /// <summary>
        /// Test DeleteAccountListener
        /// </summary>
        [Test]
        public void DeleteAccountListenerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountId = null;
            //int? listenerId = null;
            //var response = instance.DeleteAccountListener(accountId, listenerId);
            //Assert.IsInstanceOf<DeleteEntry> (response, "response is DeleteEntry");
        }
        
        /// <summary>
        /// Test GetAccountListener
        /// </summary>
        [Test]
        public void GetAccountListenerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountId = null;
            //int? listenerId = null;
            //var response = instance.GetAccountListener(accountId, listenerId);
            //Assert.IsInstanceOf<ListenerFull> (response, "response is ListenerFull");
        }
        
        /// <summary>
        /// Test ListAccountListeners
        /// </summary>
        [Test]
        public void ListAccountListenersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountId = null;
            //List<string> filtersId = null;
            //string sortId = null;
            //int? limit = null;
            //int? offset = null;
            //string fields = null;
            //var response = instance.ListAccountListeners(accountId, filtersId, sortId, limit, offset, fields);
            //Assert.IsInstanceOf<ListListeners> (response, "response is ListListeners");
        }
        
        /// <summary>
        /// Test ReplaceAccountListener
        /// </summary>
        [Test]
        public void ReplaceAccountListenerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountId = null;
            //int? listenerId = null;
            //CreateListenerParams data = null;
            //var response = instance.ReplaceAccountListener(accountId, listenerId, data);
            //Assert.IsInstanceOf<ListenerFull> (response, "response is ListenerFull");
        }
        
    }

}
