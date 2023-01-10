﻿using System.Threading.Tasks;
using Adyen.Model;
using Adyen.Model.Hop;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class HostedOnboardingPagesTest : BaseTest
    {
        /// <summary>
        /// test /getOnboardingUrl
        /// </summary>
        [TestMethod]
        public void TestGetOnboardingUrlSuccess()
        {
            Client client =
                CreateMockTestClientApiKeyBasedRequest(
                    "Mocks/hop/get-onboarding-url-success.json");
            HostedOnboardingPages hop = new HostedOnboardingPages(client);
            GetOnboardingUrlRequest getOnboardingUrlRequest = new GetOnboardingUrlRequest();
            GetOnboardingUrlResponse redirectResponse = hop.GetOnboardingUrl(getOnboardingUrlRequest, new RequestOptions());

            Assert.AreEqual("https://test.adyen.com/hop", redirectResponse.RedirectUrl);
            Assert.AreEqual("1234567890123456", redirectResponse.PspReference);
            Assert.AreEqual("success", redirectResponse.ResultCode);
            Assert.AreEqual(false, redirectResponse.SubmittedAsync);
        }

        /// <summary>
        /// test /getOnboardingUrl async
        /// </summary>
        [TestMethod]
        public async Task TestGetOnboardingUrlSuccessAsync()
        {
            Client client =
                CreateAsyncMockTestClientApiKeyBasedRequest(
                    "Mocks/hop/get-onboarding-url-success-async.json");
            HostedOnboardingPages hop = new HostedOnboardingPages(client);
            GetOnboardingUrlRequest getOnboardingUrlRequest = new GetOnboardingUrlRequest();
            GetOnboardingUrlResponse redirectResponse = await hop.GetOnboardingUrlAsync(getOnboardingUrlRequest, new RequestOptions());

            Assert.AreEqual("https://test.adyen.com/hop", redirectResponse.RedirectUrl);
            Assert.AreEqual("1234567890123456", redirectResponse.PspReference);
            Assert.AreEqual("success", redirectResponse.ResultCode);
            Assert.AreEqual(true, redirectResponse.SubmittedAsync);
        }
    }
}
