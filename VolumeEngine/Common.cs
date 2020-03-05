using System;

namespace VolumeEngine
{
    public class Common
    {
        private Point center;
        private double edgeLength;
        public static Common Calculate()
        {
            return new Common();
        }

        //Create the cubes with given co-ordinates and edge length
        public Common WithCordinates(double x, double y, double z, double length)
        {
            center = new Point(x, y, z);
            edgeLength = length;
            return this;
        }
        public Cube CreateCube()
        {
            return new Cube(center, edgeLength);
        }
    }

    public struct Cube
    {
        private Edge xCoordinate;
        private Edge yCoordinate;
        private Edge zCoordinate;

        //Find new start and end points after intersection
        public Cube(Point center, double edgeLength)
        {
            xCoordinate = new Edge(center.X, edgeLength);
            yCoordinate = new Edge(center.Y, edgeLength);
            zCoordinate = new Edge(center.Z, edgeLength);
        }

        // Check the intersection points to get volume
        public double IntersectionVolumeWith(Cube cube) =>
                xCoordinate.Overlap(cube.xCoordinate)
                * yCoordinate.Overlap(cube.yCoordinate)
                * zCoordinate.Overlap(cube.zCoordinate);

        // Check axial collision
        public bool CollidesWith(Cube cube) =>
                xCoordinate.Collides(cube.xCoordinate)
                || yCoordinate.Collides(cube.yCoordinate)
                || zCoordinate.Collides(cube.zCoordinate);
    }

    public struct Edge
    {
        private double startPoint;
        private double endPoint;

        public Edge(double centerPoint, double length)
        {
            startPoint = centerPoint - length / 2.0;
            endPoint = centerPoint + length / 2.0;
        }

        public double Overlap(Edge edge) =>
            Math.Max(0, Difference(edge));

        public bool Collides(Edge edge) =>
            Difference(edge) >= 0;

        private double Difference(Edge edge) =>
            Math.Min(endPoint, edge.endPoint) - Math.Max(startPoint, edge.startPoint);
    }

    public struct Point
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }










}
