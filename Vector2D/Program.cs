using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vector2D {
    class Program {
        static void Main(string[] args) {

            // Create object of vector2d class and set x and y values
            //Vector2D vector = new Vector2D(2, -5);
            //Vector2D vector = new Vector2D(3, 1);
            //Vector2D vector2 = new Vector2D(-3, -4);

            Vector2D vector = new Vector2D(1.6,3.7);
            Vector2D vector2 = new Vector2D(-2.2,2.4);

            //Vector2D vector = new Vector2D(-3, 4);

                // Negating X and Y
            //vector.negateX();
            //vector.negateY();
            //Console.WriteLine("Negate X: {0}\nNegate Y: {1}", vector.X, vector.Y);

                // Add parameter provided vector to existing vector (vector addition)
            //vector.addVector(4, 5);
            //Console.WriteLine("Vector addition: vector + [4, 5] = [{0}, {1}]", vector.X, vector.Y);

                // Subtract vector parameter provided vector from existing vector
            //vector.subtractVector(3, 8);
            //Console.WriteLine("Vector subtraction: vector - [3, 8] = [{0}, {1}]", vector.X, vector.Y);

                // Multiply vector by paremeter provided scalar
            //vector.scalarMultiplication(7);
            //Console.WriteLine("Scalar Multiplication: vector * 7 = [{0}, {1}]",vector.X, vector.Y);

                // Get magnitude of vector
            //Console.WriteLine("Magnitude of vector vector is {0}", vector.getMagnitude());

                // Get angle of vector in degrees
            //Console.WriteLine("Angle of vector vector is {0}", vector.getAngleInDegrees());

                // Normalize
            //Console.WriteLine("Vector normalized is [{0}, {1}]", vector.Normalize().X, vector.Normalize().Y);

                // Get dot product of vector and vector2
            //Console.WriteLine("Dot product of vector and vector2 is {0}", vector.GetDotProduct(vector2));

                // Get angle between vectors
            Console.WriteLine("Angle between vector and vector2 is {0} degrees", vector.GetAngleBetweenVector(vector2));

                // Lerp
            //Console.WriteLine("Returned vector of lerp 0.7 between vector and vector is: [{0}, {1}]", vector.Lerp(vector2, 0.7).X, vector.Lerp(vector2, 0.7).Y);

            //Console.WriteLine(vector.RotateVector(20).X + " ;;;;;;; " + vector.RotateVector(20).Y);
            //Console.WriteLine("Vector rotated 60 degrees is: [{0}, {1}]", Math.Round((vector.RotateVector(60).X),3), Math.Round((vector.RotateVector(60).Y),3));

            Console.ReadLine();
        }
    }
}
