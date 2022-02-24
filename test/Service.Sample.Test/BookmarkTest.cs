using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ExpectedObjects;

namespace TDD.Domain.Test
{
    public class BookmarkTest
    {

        [Fact(DisplayName = "NewBookmark")]
        public void CreateBookmark()
        {
            var bookmarkExpected = new
            {
                CategoryId = Category.Personalizado,
                Name = "Google",
                URL = "https://www.google.com/",
                NewTab = true
            };

            var bookmark = new Bookmark(bookmarkExpected.CategoryId, bookmarkExpected.Name, bookmarkExpected.URL, bookmarkExpected.NewTab);

            bookmarkExpected.ToExpectedObject().ShouldMatch(bookmark);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void CreateBookmark_NameEmptyOrNull(string name)
        {
            var bookmarkExpected = new
            {
                CategoryId = Category.Personalizado,
                URL = "https://github.com/",
                NewTab = true
            };

            Assert.Throws<ArgumentException>(() => new Bookmark(bookmarkExpected.CategoryId, name, bookmarkExpected.URL, bookmarkExpected.NewTab));
        }
    }
}
