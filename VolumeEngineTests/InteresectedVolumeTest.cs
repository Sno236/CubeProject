using NUnit.Framework;
using static VolumeEngine.Common;

namespace VolumeEngine.Model.Tests
{
    [TestFixture]
    public class InteresectedVolumeTest
    {
        [Test]
        public void cubes_are_completely_overlapped()
        {
            var cubeA = Calculate().WithCordinates(2, 2, 2, 2).CreateCube();
            var cubeB = Calculate().WithCordinates(2, 2, 2, 2).CreateCube();

            Assert.AreEqual(8, cubeA.IntersectionVolumeWith(cubeB));
        }

        [Test]
        public void cubes_with_same_height_and_depth()
        {
            var cubeA = Calculate().WithCordinates(2, 2, 2, 2).CreateCube();
            var cubeB = Calculate().WithCordinates(3, 2, 2, 2).CreateCube();

            Assert.AreEqual(4, cubeA.IntersectionVolumeWith(cubeB));
        }

        [Test]
        public void cubes_with_same_width_and_depth()
        {
            var cubeA = Calculate().WithCordinates(2, 2, 2, 2).CreateCube();
            var cubeB = Calculate().WithCordinates(2, 3, 2, 2).CreateCube();

            Assert.AreEqual(4, cubeA.IntersectionVolumeWith(cubeB));
        }

        [Test]
        public void cubes_with_same_width_and_height()
        {
            var cubeA = Calculate().WithCordinates(2, 2, 2, 2).CreateCube();
            var cubeB = Calculate().WithCordinates(2, 2, 3, 2).CreateCube();

            Assert.AreEqual(4, cubeA.IntersectionVolumeWith(cubeB));
        }

        [Test]
        public void cubes_that_do_not_intersect()
        {
            var cubeA = Calculate().WithCordinates(2, 2, 2, 2).CreateCube();
            var cubeB = Calculate().WithCordinates(10, 10, 10, 2).CreateCube();

            Assert.AreEqual(0, cubeA.IntersectionVolumeWith(cubeB));
        }

        [Test]
        public void one_cube_is_contained_within_the_other()
        {
            var cubeA = Calculate().WithCordinates(2, 2, 2, 2).CreateCube();
            var cubeB = Calculate().WithCordinates(2, 2, 2, 1).CreateCube();

            Assert.AreEqual(1, cubeA.IntersectionVolumeWith(cubeB));
        }
       

    }
}