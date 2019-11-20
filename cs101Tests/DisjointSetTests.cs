using System;
using Xunit;
using cs101;

namespace cs101Tests
{
    public class DisjointSetTests
    {
        private DisjointSet _ds;
        public DisjointSetTests()
        {
            _ds = new DisjointSet(6);
            _ds.Union(0, 3);
            _ds.Union(1, 3);
            _ds.Union(2, 4);
        }
        
        [Fact]
        public void ShouldGiveCorrectComponentCount()
        {
            Assert.Equal(3, _ds.ComponentCount);
        }

        [Fact]
        public void ShouldCorrectlyJoinNodes()
        {
            var root0 = _ds.Find(0);
            var root1 = _ds.Find(1);
            Assert.Equal(root0, root1);
        }
    }
}
