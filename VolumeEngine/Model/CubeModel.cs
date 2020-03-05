using System;
using System.ComponentModel;
using static VolumeEngine.Common;

namespace VolumeEngine.Model
{
    public class CubeModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        #region Properties
        private double _lengthCubeA;
        private double _widthCubeA;
        private double _heightCubeA;
        private double _positionCubeA;
        private double _lengthCubeB;
        private double _widthCubeB;
        private double _heightCubeB;
        private double _positionCubeB;
        private double _volume;
        private string _validationMessage;

        public double LengthCubeA
        {
            get { return _lengthCubeA; }
            set
            {
                _lengthCubeA = value;
                OnPropertyChanged(nameof(LengthCubeA));
            }
        }

        public double WidthCubeA
        {
            get { return _widthCubeA; }
            set
            {
                _widthCubeA = value;
                OnPropertyChanged(nameof(WidthCubeA));
            }
        }

        public double HeightCubeA
        {
            get { return _heightCubeA; }
            set
            {
                _heightCubeA = value;

                OnPropertyChanged(nameof(HeightCubeA));
            }
        }

        public double PositionCubeA
        {
            get { return _positionCubeA; }
            set
            {
                _positionCubeA = value;

                OnPropertyChanged(nameof(PositionCubeA));
            }
        }
        public double LengthCubeB
        {
            get { return _lengthCubeB; }
            set
            {
                _lengthCubeB = value;
                OnPropertyChanged(nameof(LengthCubeB));
            }
        }

        public double WidthCubeB
        {
            get { return _widthCubeB; }
            set
            {
                _widthCubeB = value;
                OnPropertyChanged(nameof(WidthCubeB));
            }
        }

        public double HeightCubeB
        {
            get { return _heightCubeB; }
            set
            {
                _heightCubeB = value;

                OnPropertyChanged(nameof(HeightCubeB));
            }
        }

        public double PositionCubeB
        {
            get { return _positionCubeB; }
            set
            {
                _positionCubeB = value;

                OnPropertyChanged(nameof(PositionCubeB));
            }
        }

        public double IntersectingVolume
        {
            get { return _volume; }
            set
            {
                _volume = value;

                OnPropertyChanged(nameof(IntersectingVolume));
            }
        }

        public string ValidationMessage
        {
            get { return _validationMessage; }
            set
            {
                _validationMessage = value;

                OnPropertyChanged(nameof(ValidationMessage));
            }
        }
        #endregion

        #region Methods

        public void CalculateIntersectingVolume()
        {
            //Calculate edge length using cube root of volume
            //var edgeLengthA = Math.Ceiling(Math.Pow((WidthCubeA * HeightCubeA * LengthCubeA), (double)1 / 3));
            //var edgeLengthB = Math.Ceiling(Math.Pow((WidthCubeB * HeightCubeB * LengthCubeB), (double)1 / 3));

            var cubeA = Calculate().WithCordinates(WidthCubeA, HeightCubeA, LengthCubeA, PositionCubeA).CreateCube();
            var cubeB = Calculate().WithCordinates(WidthCubeB, HeightCubeB, LengthCubeB, PositionCubeB).CreateCube();
            IntersectingVolume = cubeA.IntersectionVolumeWith(cubeB);
        }



        #endregion

        #region events
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
