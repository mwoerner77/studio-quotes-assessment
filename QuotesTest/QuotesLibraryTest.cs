using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using System.Collections.Generic;
using System.Linq;
using Quotes;
using System;
using Xunit;

namespace QuotesTest
{
    public class QuotesLibraryTest
    {
        [Fact]
        public void QuotesLibrary_GetByID_TEST()
        { 
            // Test Setup
            Guid testId = new Guid("8d4beb47-40b5-4884-98eb-39ee85e98552");
            string author = "Nelson Muntz";

            QuotesLibrary library = QuotesLibrary.Instance;
            Quote result = library.GetByID(testId);

            // Assert Values
            Assert.NotNull(result);
            Assert.Equal(author, result.Author);
        }

        [Fact]
        public void QuotesLibrary_GetByIDNotFound_TEST()
        { 
            // Test Setup
            Guid testId = new Guid("496035e2-9aad-4e3b-9d48-70bb55e99a16");     // Guid not used

            QuotesLibrary library = QuotesLibrary.Instance;
            Quote result = library.GetByID(testId);

            Assert.Null(result);
        }

        [Fact]
        public void QuotesLibrary_GetByAuthorSingle_TEST()
        { 
            // Test Setup
            Guid testId = new Guid("8d4beb47-40b5-4884-98eb-39ee85e98552");
            string author = "Nelson Muntz";

            QuotesLibrary library = QuotesLibrary.Instance;
            List<Quote> resultList = library.GetByAuthor(author);

            Quote result = resultList.FirstOrDefault(quote => quote.Id == testId);

            // Assert Values
            Assert.NotNull(resultList);                 // Did it find the quote?
            Assert.Equal(author, result.Author);        // Is the author correct?
        }

        [Fact]
        public void QuotesLibrary_GetByAuthorMultiple_TEST()
        { 
            // Test Setup
            string author = "Oscar Wilde";

            QuotesLibrary library = QuotesLibrary.Instance;
            List<Quote> resultList = library.GetByAuthor(author);

            // Assert Values
            Assert.NotNull(resultList);                 // Did it find the quotes?
            Assert.True(resultList.Count >= 2);         // Did multiple quotes return?
        }

        [Fact]
        public void QuotesLibrary_GetByAuthorNotFound_TEST()
        { 
            // Test Setup
            string author = "I am not an author";

            QuotesLibrary library = QuotesLibrary.Instance;
            List<Quote> resultList = library.GetByAuthor(author);

            // Assert Values
            Assert.Null(resultList);               // No result = null
        }
    }
}