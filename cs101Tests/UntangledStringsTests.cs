using System;
using Xunit;
using cs101;

namespace cs101Tests
{
    public class UntangledStringTests
    {
        [Fact]
        public void SmokeTestShouldFail()
        {
            var actual = UntangledStrings.BlowSmoke();
            var expect = "barfoo";
            Assert.Equal(actual, expect);
        }

        [Fact]
        public void SmokeTestShouldPass()
        {
            var actual = UntangledStrings.BlowSmoke();
            var expect = "foo bar";
            Assert.Equal(actual, expect);
        }
    }
}
