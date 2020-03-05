using VolumeEngine.Model;

namespace VolumeEngine.ViewModel
{

    public class CubeViewModel
    {
        public CubeModel NewCube { get; set; }
        public CubeViewModel()
        {
            NewCube = new CubeModel();
        }

        public void Calculate()
        {
            NewCube.CalculateIntersectingVolume();
        }
    }
}
