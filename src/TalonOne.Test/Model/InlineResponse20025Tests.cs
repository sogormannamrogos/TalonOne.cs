/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using TalonOne.Api;
using TalonOne.Model;
using TalonOne.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace TalonOne.Test
{
    /// <summary>
    ///  Class for testing InlineResponse20025
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class InlineResponse20025Tests
    {
        // TODO uncomment below to declare an instance variable for InlineResponse20025
        //private InlineResponse20025 instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of InlineResponse20025
            //instance = new InlineResponse20025();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InlineResponse20025
        /// </summary>
        [Test]
        public void InlineResponse20025InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InlineResponse20025
            //Assert.IsInstanceOfType<InlineResponse20025> (instance, "variable 'instance' is a InlineResponse20025");
        }


        /// <summary>
        /// Test the property 'TotalResultSize'
        /// </summary>
        [Test]
        public void TotalResultSizeTest()
        {
            // TODO unit test for the property 'TotalResultSize'
        }
        /// <summary>
        /// Test the property 'HasMore'
        /// </summary>
        [Test]
        public void HasMoreTest()
        {
            // TODO unit test for the property 'HasMore'
        }
        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Test]
        public void DataTest()
        {
            // TODO unit test for the property 'Data'
        }

    }

}