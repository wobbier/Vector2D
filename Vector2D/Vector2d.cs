using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vector2D {
    public class Vector2D {

        // x and y fields
        private double x, y;

        // X Property
        public double X{
            get{
                return x;
            } set {
                x = value;
            }
        }

        // Y Property
        public double Y{
            get {
                return y;
            } set {
                y = value;
            }
        }

        // Parameterless constructor - Set vector to [1,1] if no values are given in instantiation
        public Vector2D() {
            X = 1;
            y = 1;
        }

        // Class Constructor
        public Vector2D(double xValue, double yValue) {
            X = xValue;
            y = yValue;
        }

        // mhgjg for easily being able to set both x and y at the same time, rather than having to set each property seperately
        // Not needed, but convenient to have
        public void setXY(double xValue, double yValue) {
            X = xValue;
            y = yValue;
        }

        // Negate X value
        public void negateX() {
            X *= -1;
        }

        // Negate Y value
        public void negateY() {
            Y *= -1;
        }

        // Add global vector to vector provided in parameter
        public void addVector(double xValue, double yValue) {
            X += xValue;
            Y += yValue;
        }

        // Subtract vector provided in parameter from global vector
        public void subtractVector(double xValue, double yValue) {
            X -= xValue;
            Y -= yValue;
        }

        // Multiply vector by paremeter provided scalar
        public void scalarMultiplication(double scalar) {
            X *= scalar;
            Y *= scalar;
        }

        // Get magnitude of vector
        public double getMagnitude() {
            return Math.Sqrt((X * X) + (Y * Y));
        }

        // Get the vector's angle, in degrees (Converted from radians)
        public double getAngleInDegrees() {
            return Math.Round(Math.Atan2(Y, X) * (180/Math.PI), 3);
        }

        // not in lab, but is useful
        public double RadiansToDegrees(double radians) {
            return Math.Round(radians * (180 / Math.PI));
        }

        // Normalize the vector, return the new vector
        public Vector2D Normalize() {
            Vector2D newVector = new Vector2D(Math.Round(X / getMagnitude(),3), Math.Round(Y / getMagnitude(),3));
            return newVector;

        }

        // Get the dot product of two vectors 
        public double GetDotProduct(Vector2D otherVector) {
            return ((X * otherVector.X) + (Y * otherVector.Y));
        }

        // Get the angle between two vectors
        public double GetAngleBetweenVector(Vector2D otherVector) {
            // return the angle (in degrees)
            return RadiansToDegrees(Math.Acos(GetDotProduct(otherVector) / (getMagnitude() * otherVector.getMagnitude())));

        }

        // Lerp between two vectors
        public Vector2D Lerp(Vector2D otherVector, double t) {
            // multiply vector a by 1-t
            X *= (1 - t);
            Y *= (1 - t);

            // multiply vector b by t
            otherVector.X *= t;
            otherVector.Y *= t;

            Vector2D newVector = new Vector2D((X + otherVector.X),(Y + otherVector.Y));
            return newVector;
        }

        // Rotate vector by given angle in degrees
        public Vector2D RotateVector(double angle) {
            Vector2D newVector = new Vector2D();

            // Make sure to convert given to an angle in degrees
            newVector.X = (Math.Cos(angle) - Y * Math.Sin(angle) * (180 / Math.PI));
            newVector.Y = (Math.Sin(angle) + Y * Math.Cos(angle) * (180 / Math.PI));

            return newVector;

        }
    }
}