/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
    ///  Class for testing LoyaltyLedgerEntry
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LoyaltyLedgerEntryTests
    {
        // TODO uncomment below to declare an instance variable for LoyaltyLedgerEntry
        //private LoyaltyLedgerEntry instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LoyaltyLedgerEntry
            //instance = new LoyaltyLedgerEntry();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoyaltyLedgerEntry
        /// </summary>
        [Test]
        public void LoyaltyLedgerEntryInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" LoyaltyLedgerEntry
            //Assert.IsInstanceOf(typeof(LoyaltyLedgerEntry), instance);
        }


        /// <summary>
        /// Test the property 'Created'
        /// </summary>
        [Test]
        public void CreatedTest()
        {
            // TODO unit test for the property 'Created'
        }
        /// <summary>
        /// Test the property 'ProgramID'
        /// </summary>
        [Test]
        public void ProgramIDTest()
        {
            // TODO unit test for the property 'ProgramID'
        }
        /// <summary>
        /// Test the property 'CustomerProfileID'
        /// </summary>
        [Test]
        public void CustomerProfileIDTest()
        {
            // TODO unit test for the property 'CustomerProfileID'
        }
        /// <summary>
        /// Test the property 'CustomerSessionID'
        /// </summary>
        [Test]
        public void CustomerSessionIDTest()
        {
            // TODO unit test for the property 'CustomerSessionID'
        }
        /// <summary>
        /// Test the property 'EventID'
        /// </summary>
        [Test]
        public void EventIDTest()
        {
            // TODO unit test for the property 'EventID'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Test]
        public void AmountTest()
        {
            // TODO unit test for the property 'Amount'
        }
        /// <summary>
        /// Test the property 'StartDate'
        /// </summary>
        [Test]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }
        /// <summary>
        /// Test the property 'ExpiryDate'
        /// </summary>
        [Test]
        public void ExpiryDateTest()
        {
            // TODO unit test for the property 'ExpiryDate'
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
        /// Test the property 'SubLedgerID'
        /// </summary>
        [Test]
        public void SubLedgerIDTest()
        {
            // TODO unit test for the property 'SubLedgerID'
        }
        /// <summary>
        /// Test the property 'UserID'
        /// </summary>
        [Test]
        public void UserIDTest()
        {
            // TODO unit test for the property 'UserID'
        }

    }

}
