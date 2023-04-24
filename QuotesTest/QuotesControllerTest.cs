using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using Quotes;
using System;
using Xunit;

namespace QuotesTest
{
    public class QuotesControllerTest
    {

        [Fact]
        public void QuotesController_ldebau_QUOTE_TEST() {
            //Test Setup
            Guid testId = new Guid("7711cd41-7a19-4ea5-872b-5727b42676d8");
            string author = "Socrates";

            //Test the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            //Assert Values
            Assert.NotNull(okResult);               //Did it find the quote?
            Assert.Equal(author, resObj.Author);    //Is the author correct?
        }

        [Fact]
        public void QuotesController_amank99_QUOTE_TEST(){
            //Test Setup
            Guid testId = new Guid("9c9921fc-f681-4128-9b2c-6ed9ac1fb727");
            string author = "Unknown";

            //Test the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            //Assert Values
            Assert.NotNull(okResult);               //Did it find the quote?
            Assert.Equal(author, resObj.Author);    //Is the author correct?
        }

        [Fact]
        public void QuotesController_ctse_QUOTE_TEST() {
            // Arrange
            Guid testId = new Guid("e56874c9-63e0-489f-aa66-4e630307937d");
            string author = "Tony Stark";

            // Act
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }


        [Fact]
        public void QuotesController_Yanqi_Qiu_TEST()
        {
            // Test Setup
            Guid testId = new Guid("ce3b54ce-1ae6-48de-b3a9-88a9b44a9b2d");
            string author = "Yanqi Qiu";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_jguil_QUOTE_TEST(){
            //Test Setup
            Guid testId = new Guid("6184bf85-e016-412e-a608-b4076a835c9e");
            string author = "Bill Russell";

            //Test the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            //Assert Values
            Assert.NotNull(okResult);               //Did it find the quote?
            Assert.Equal(author, resObj.Author);    //Is the author correct?
        }

        [Fact]
        public void QuotesController_ymdiallo_QUOTE_TEST(){
            //Test Setup
            Guid testId = new Guid("bc1512ab-e542-49c6-88cd-3689329341d6");
            string author = "NBA Youngboy";

            //Test the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            //Assert Values
            Assert.NotNull(okResult);               //Did it find the quote?
            Assert.Equal(author, resObj.Author);    //Is the author correct?
        }

        [Fact]
        public void QuotesController_vcent_QUOTE_TEST()
        {
            // Test Setup
            Guid testId = new Guid("1ec7fb84-1df6-4efd-9855-669db8f6ffcc");
            string author = "Vincent Allen";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_Ravis_FutureQUOTE_TEST()
        {
            // Test setup
            Guid testId = new Guid("0bc56d59-41ac-4bcd-93b6-7c112dcba03a");
            string author = "Future";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert values
            Assert.NotNull(okResult);
            Assert.Equal(author, resObj.Author);
        }

        [Fact]
        public void QuotesController_joycerlz_QUOTE_TEST()
        {
            // Test setup
            Guid testId = new Guid("92f55faf-9757-4e80-8ba1-2144e8e4ae82");
            string author = "Helen Keller";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert values
            Assert.NotNull(okResult);
            Assert.Equal(author, resObj.Author);
        }

        [Fact]
        public void QuotesController_SHAUNS_NMUNTZ_TEST()
        {
            // Test Setup
            Guid testId = new Guid("8d4beb47-40b5-4884-98eb-39ee85e98552");
            string author = "Nelson Muntz";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_DTKACH_DTQUOTE_TEST()
        {
            // Test Setup
            Guid testId = new Guid("066b9256-023a-4f9b-bdaf-dd3bfa25ed9f");
            string author = "David Tkach";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_SHAUNS_EHQUOTE_TEST()
        {
            // Test Setup
            Guid testId = new Guid("9c021c24-925e-4d1a-ada7-3db7298f0bc9");
            string author = "Ernest Hemingway";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?

        }

        [Fact]
        public void QuotesController_ROBERT_OPPQUOTE_TEST()
        {
            // Test Setup

            Guid testId = new Guid("ae9afcfc-f45b-4636-b3d3-43c5afc0c01b");
            string author = "Robert Oppenheimer";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_socha_test()
        {
            Guid testId = new Guid("7a0fad07-7b68-45f1-80dd-a69dd9b9e6b0");
            string author = "socha";

            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            Assert.NotNull(okResult);
            Assert.Equal(author, resObj.Author);
        }

        [Fact]
        public void QuotesController_JERICHO_STQUOTE_TEST()
        {
            // Test Setup
            Guid testId = new Guid("08033ac6-94c3-4e46-a5eb-cf4ac71824e4");
            string author = "Sun Tzu";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }
        // ToDo: Unit Test QuotesLibrary Class
        [Fact]
        public void QuotesController_jplant_AURON_TEST()
        {
            // Test Setup
            Guid testId = new Guid("0891349b-90dd-48d5-908f-bf3face1ab10");
            string author = "Auron";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_ALEXLS1_MTQUOTE_TEST()
        {
            // Test Setup
            Guid testId = new Guid("{92dbc310-e67c-4b2c-862f-d975e85a4dfd}");
            string author = "Mark Twain";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_LinneaAW_GH_TEST()
        {
            // Test Setup
            Guid testId = new Guid("f472451e-3910-4492-b1e0-8f86c07eee35");
            string author = "Grace Hopper";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_Jesse_ZhongliQuote_test()
        {
            // Test Setup
            Guid testId = new Guid("3298ac87-d9f6-4128-a8a3-7e6021a9f369");
            string author = "Zhongli";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(
            new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult goodResult = result as OkObjectResult;
            Quote resObj = (Quote)goodResult.Value;

            // Assert Values
            Assert.NotNull(goodResult);
            Assert.Equal(author, resObj.Author);
        }

        [Fact]
        public void QuotesController_DINARA_SUNTZUQUOTE_TEST()
        {
            //Test Setup
            Guid testId = new Guid("896ecfa1-33ba-4264-9241-bd2086eb3a6a");
            string author = "Sun Tzu";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);
            Assert.Equal(author, resObj.Author);
        }

        [Fact]
        public void QuotesController_pdtiger1_HARPERLEEQUOTE_TEST()
        {
            // Test Setup
            Guid testId = new Guid("c4df3e6d-7f8b-4631-a8f5-9b706d379fc7");
            string author = "Harper Lee";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_leavelle_LEAVELLEQUOTE_TEST()
        {
            // Test Setup
            Guid testId = new Guid("53ff0d0f-562b-443b-a751-c2a4a63873ab");
            string author = "Leavelle";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_adinh12_ATGQUOTE_TEST()
        {
            // Test Setup
            Guid testId = new Guid("702498cf-e7fd-40a3-a588-d72299863de8");
            string author = "Alexander the Great";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_ARNOLD_SCHWARZENEGGER()
        {
            // Test Setup
            Guid testId = new Guid("24e3279d-292a-401c-8007-5e660f1742bc");
            string author = "Arnold Schwarzenegger";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_NMIHAI_DHQUOTE_TEST()
        {
            // Test Setup
            Guid testId = new Guid("9a498727-fe70-4574-8e4f-f8bd6d02a194");
            string author = "David Hockney";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_HARSTONJ_JWGQUOTE_TEST()
        {
            // Test Setup
            Guid testId = new Guid("638f3f2a-3755-4904-8479-d7b551894074");
            string author = "John W. Gardner";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_ARISTOTLE_QUOTE_TEST()
        {
            // Test Setup
            Guid testId = new Guid("8fb44472-a93f-4f1f-bc7e-e48884c7caa6");
            string author = "Aristotle";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_GABRIEL_IGLESIAS_TEST()
        {
            // Test Setup
            Guid testId = new Guid("0fd83908-b5c8-4ce1-a42f-d6689b2507be");
            string author = "Gabriel Iglesias";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_HARMINDERS_WALTDISNEY_TEST()
        {
            // Test Setup
            Guid testId = new Guid("1a55da74-0279-45f5-ad0f-48f3bc3ce5fa");
            string author = "Walt Disney";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_SUSHS_AFQUOTE_TEST()
        {
            // Test Setup
            Guid testId = new Guid("4336f007-9a2c-4282-b151-693582d3f1a3");
            string author = "Anne Frank";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_ADEMARIS_AHQUOTE_TEST()
        {
            // Arrange
            Guid testId = new Guid("ede30102-ad60-4417-b10f-e4cdcc63933c");  // control + shift + p -> "Insert GUID"
            string author = "Anne Hathaway";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_agtodako_TEST()
        {
            // Test Setup
            Guid testId = new Guid("1acbd32a-c257-412e-a72d-48de127ab4be");
            string author = "Edgar Allen Poe";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);                   // Did it find the quote?
            Assert.Equal(author, resObj.Author);  // is the author correct?
        }


        [Fact]
        public void QuotesController_DEREK_LAQUOTE_TEST()
        {
            // Arranged
            Guid testId = new Guid("cd24e9f0-4b4e-4a77-99e7-846bbc5e4e42");
            string author = "Derek Landy";

            // Act
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);                   // Did it find the quote?
            Assert.Equal(author, resObj.Author);  // is the author correct?
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_NBALZOTTI_DC_QUOTE_TEST()
        {
            // Test Setup
            Guid testId = new Guid("19a75a79-e115-403a-a1ac-1433e07ee879");
            string author = "Dale Carnegie";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_peter325_SH_TEST(){
            // arrange
            Guid testId = new Guid("206bae0b-ca20-408f-a2bb-2655fe4b8525");
            string author = "Sherlock Holmes";

            // Act
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Value
            Assert.NotNull(okResult);
            Assert.Equal(author, resObj.Author);
        }

            [Fact]
        public void QuotesController_kuang_TEST()
        {
            // Test Setup
            Guid testId = new Guid("1acbd32b-c257-412e-a72d-48de127ab4bf");
            string author = "Elon Musk";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_halimr_QUOTE_TEST()
        {
            // Test Setup
            Guid testId = new Guid("4171af6f-1efa-49b6-808b-f7794b6622ea");
            string author = "Inspirobot";

            // Get the return values of the Quotes "Get by ID" controller method
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert Values
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author); 
        }

        [Fact]
        public void QuotesController_ERIKLOPEZ_PELEQUOTE_TEST()
        {
            // Arrange
            Guid testId = new Guid("a23f523c-06d4-4675-bb6e-8c340e0aed46");
            string author = "Pele";

            // Act
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }
        
        [Fact]
        public void QuotesController_Amogh_Kapalli_RWQUOTE_TEST()
        {
            // Arrange
            Guid testId = new Guid("aaf5edf7-4b64-48ed-b780-8841ac825efa");
            string author = "Roy Williams";

            // Act
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;
            //Assert
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_OLIVERS_SPQUOTE_test()
        {
            //Arrange 
            Guid testId = new Guid("702b006d-c3d5-408a-9a27-552a5b86b78d");
            string author = "Steve Prefontaine";

            //Act 
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_AIDENS_YODAQUOTE_TEST()
        {
            //Arrange 
            Guid testId = new Guid("b491d736-80bf-41b2-866c-87c727651de6");
            string author = "Yoda";

            //Act 
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

        [Fact]
        public void QuotesController_MALACHY_UI_test() {
            // Arrange
            Guid testId = new Guid("22c08f16-3dae-4c6b-927d-8c940b1b437a");
            string author = "Uncle Iroh";

            // Act
            Quotes.Controllers.QuotesController qController = new Quotes.Controllers.QuotesController(new NullLogger<Quotes.Controllers.QuotesController>());
            IActionResult result = qController.Get(testId);
            OkObjectResult okResult = result as OkObjectResult;
            Quote resObj = (Quote)okResult.Value;

            // Assert
            Assert.NotNull(okResult);               // Did it find the quote?
            Assert.Equal(author, resObj.Author);    // Is the author correct?
        }

    }
}
