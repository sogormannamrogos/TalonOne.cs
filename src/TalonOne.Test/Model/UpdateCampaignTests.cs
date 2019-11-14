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
    ///  Class for testing UpdateCampaign
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UpdateCampaignTests
    {
        // TODO uncomment below to declare an instance variable for UpdateCampaign
        //private UpdateCampaign instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of UpdateCampaign
            //instance = new UpdateCampaign();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UpdateCampaign
        /// </summary>
        [Test]
        public void UpdateCampaignInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" UpdateCampaign
            //Assert.IsInstanceOfType<UpdateCampaign> (instance, "variable 'instance' is a UpdateCampaign");
        }


        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'StartTime'
        /// </summary>
        [Test]
        public void StartTimeTest()
        {
            // TODO unit test for the property 'StartTime'
        }
        /// <summary>
        /// Test the property 'EndTime'
        /// </summary>
        [Test]
        public void EndTimeTest()
        {
            // TODO unit test for the property 'EndTime'
        }
        /// <summary>
        /// Test the property 'Attributes'
        /// </summary>
        [Test]
        public void AttributesTest()
        {
            // TODO unit test for the property 'Attributes'
        }
        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'ActiveRulesetId'
        /// </summary>
        [Test]
        public void ActiveRulesetIdTest()
        {
            // TODO unit test for the property 'ActiveRulesetId'
        }
        /// <summary>
        /// Test the property 'Tags'
        /// </summary>
        [Test]
        public void TagsTest()
        {
            // TODO unit test for the property 'Tags'
        }
        /// <summary>
        /// Test the property 'Features'
        /// </summary>
        [Test]
        public void FeaturesTest()
        {
            // TODO unit test for the property 'Features'
        }
        /// <summary>
        /// Test the property 'CouponSettings'
        /// </summary>
        [Test]
        public void CouponSettingsTest()
        {
            // TODO unit test for the property 'CouponSettings'
        }
        /// <summary>
        /// Test the property 'ReferralSettings'
        /// </summary>
        [Test]
        public void ReferralSettingsTest()
        {
            // TODO unit test for the property 'ReferralSettings'
        }
        /// <summary>
        /// Test the property 'Limits'
        /// </summary>
        [Test]
        public void LimitsTest()
        {
            // TODO unit test for the property 'Limits'
        }

    }

}