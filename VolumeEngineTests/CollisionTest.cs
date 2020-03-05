using NUnit.Framework;
using static VolumeEngine.Common;

namespace VolumeEngineTests
{
    [TestFixture]
    class CollisionTest
    {
        [Test]
        public void cubes_that_do_not_touch()
        {
            var cubeA = Calculate().WithCordinates(2, 2, 2,2).CreateCube();
            var cubeB = Calculate().WithCordinates(10, 10, 10,2).CreateCube();

            Assert.IsFalse(cubeA.CollidesWith(cubeB));
        }

        [Test]
        public void cubes_that_overlap()
        {
            var cubeA = Calculate().WithCordinates(2, 2, 2,2).CreateCube();
            var cubeB = Calculate().WithCordinates(3, 2, 2,2).CreateCube();

            Assert.IsTrue(cubeA.CollidesWith(cubeB));
        }

        [Test]
        public void cubes_that_touch()
        {
            var cubeA = Calculate().WithCordinates(2, 2, 2,2).CreateCube();
            var cubeB = Calculate().WithCordinates(4, 2, 2,2).CreateCube();

            Assert.IsTrue(cubeA.CollidesWith(cubeB));
        }
    }
}
