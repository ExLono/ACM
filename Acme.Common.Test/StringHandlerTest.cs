using System;
using Xunit;

namespace Acme.Common.Test
{
    public class StringHandlerTest
    {
        [Fact]
        public void InsertSpaceByBigLetter()
        {
            var sourse = "SonicCrew";
            var expected = "Sonic Crew";

            var actual = sourse.InsertSpace();

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CheckDoubleSpaceOnBigLetter()
        {
            var sourse = "Sonic Crew";
            var expected = "Sonic Crew";

            var actual = sourse.InsertSpace();

            Assert.Equal(expected, actual);
        }
    }
}
