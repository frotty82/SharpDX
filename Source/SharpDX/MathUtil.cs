﻿// Copyright (c) 2010-2013 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// -----------------------------------------------------------------------------
// Original code from SlimMath project. http://code.google.com/p/slimmath/
// Greetings to SlimDX Group. Original code published with the following license:
// -----------------------------------------------------------------------------
/*
* Copyright (c) 2007-2011 SlimDX Group
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
*/
using System;

namespace SharpDX
{
    public static class MathUtil
    {
        /// <summary>
        /// The value for which all absolute numbers smaller than are considered equal to zero.
        /// </summary>
        public const float ZeroTolerance = 1e-6f;

        /// <summary>
        /// A value specifying the approximation of π which is 180 degrees.
        /// </summary>
        public const float Pi = (float)Math.PI;

        /// <summary>
        /// A value specifying the approximation of 2π which is 360 degrees.
        /// </summary>
        public const float TwoPi = (float)(2 * Math.PI);

        /// <summary>
        /// A value specifying the approximation of π/2 which is 90 degrees.
        /// </summary>
        public const float PiOverTwo = (float)(Math.PI / 2);

        /// <summary>
        /// A value specifying the approximation of π/4 which is 45 degrees.
        /// </summary>
        public const float PiOverFour = (float)(Math.PI / 4);

        /// <summary>
        /// Checks if a - b are almost equals within a float <see cref="Single.Epsilon"/>.
        /// </summary>
        /// <param name="a">The left value to compare.</param>
        /// <param name="b">The right value to compare.</param>
        /// <returns><c>true</c> if a almost equal to b within a float epsilon, <c>false</c> otherwise</returns>
        public static bool WithinEpsilon(float a, float b)
        {
            return WithinEpsilon(a, b, Single.Epsilon);
        }

        /// <summary>
        /// Checks if a - b are almost equals within a float epsilon.
        /// </summary>
        /// <param name="a">The left value to compare.</param>
        /// <param name="b">The right value to compare.</param>
        /// <param name="epsilon">Epsilon value</param>
        /// <returns><c>true</c> if a almost equal to b within a float epsilon, <c>false</c> otherwise</returns>
        public static bool WithinEpsilon(float a, float b, float epsilon)
        {
            float num = a - b;
            return ((-epsilon <= num) && (num <= epsilon));
        }

        /// <summary>
        /// Does something with arrays.
        /// </summary>
        /// <typeparam name="T">Most likely the type of elements in the array.</typeparam>
        /// <param name="value">Who knows what this is for.</param>
        /// <param name="count">Probably the length of the array.</param>
        /// <returns>An array of who knows what.</returns>
        public static T[] Array<T>(T value, int count)
        {
            T[] result = new T[count];
            for (int i = 0; i < count; i++)
                result[i] = value;

            return result;
        }

        /// <summary>
        /// Converts revolutions to degrees.
        /// </summary>
        /// <param name="revolution">The value to convert.</param>
        /// <returns>The converted value.</returns>
        public static float RevolutionsToDegrees(float revolution)
        {
            return revolution * 360.0f;
        }

        /// <summary>
        /// Converts revolutions to radians.
        /// </summary>
        /// <param name="revolution">The value to convert.</param>
        /// <returns>The converted value.</returns>
        public static float RevolutionsToRadians(float revolution)
        {
            return revolution * TwoPi;
        }

        /// <summary>
        /// Converts revolutions to gradians.
        /// </summary>
        /// <param name="revolution">The value to convert.</param>
        /// <returns>The converted value.</returns>
        public static float RevolutionsToGradians(float revolution)
        {
            return revolution * 400.0f;
        }

        /// <summary>
        /// Converts degrees to revolutions.
        /// </summary>
        /// <param name="degree">The value to convert.</param>
        /// <returns>The converted value.</returns>
        public static float DegreesToRevolutions(float degree)
        {
            return degree / 360.0f;
        }

        /// <summary>
        /// Converts degrees to radians.
        /// </summary>
        /// <param name="degree">The value to convert.</param>
        /// <returns>The converted value.</returns>
        public static float DegreesToRadians(float degree)
        {
            return degree * (Pi / 180.0f);
        }

        /// <summary>
        /// Converts radians to revolutions.
        /// </summary>
        /// <param name="radian">The value to convert.</param>
        /// <returns>The converted value.</returns>
        public static float RadiansToRevolutions(float radian)
        {
            return radian / TwoPi;
        }

        /// <summary>
        /// Converts radians to gradians.
        /// </summary>
        /// <param name="radian">The value to convert.</param>
        /// <returns>The converted value.</returns>
        public static float RadiansToGradians(float radian)
        {
            return radian * (200.0f / Pi);
        }

        /// <summary>
        /// Converts gradians to revolutions.
        /// </summary>
        /// <param name="gradian">The value to convert.</param>
        /// <returns>The converted value.</returns>
        public static float GradiansToRevolutions(float gradian)
        {
            return gradian / 400.0f;
        }

        /// <summary>
        /// Converts gradians to degrees.
        /// </summary>
        /// <param name="gradian">The value to convert.</param>
        /// <returns>The converted value.</returns>
        public static float GradiansToDegrees(float gradian)
        {
            return gradian * (9.0f / 10.0f);
        }

        /// <summary>
        /// Converts gradians to radians.
        /// </summary>
        /// <param name="gradian">The value to convert.</param>
        /// <returns>The converted value.</returns>
        public static float GradiansToRadians(float gradian)
        {
            return gradian * (Pi / 200.0f);
        }

        /// <summary>
        /// Converts radians to degrees.
        /// </summary>
        /// <param name="radian">The value to convert.</param>
        /// <returns>The converted value.</returns>
        public static float RadiansToDegrees(float radian)
        {
            return radian * (180.0f / Pi);
        }

        /// <summary>
        /// Clamps the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="min">The min.</param>
        /// <param name="max">The max.</param>
        /// <returns>The result of clamping a value between min and max</returns>
        public static float Clamp(float value, float min, float max)
        {
            return value < min ? min : value > max ? max : value;
        }
        
        /// <summary>
        /// Clamps the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="min">The min.</param>
        /// <param name="max">The max.</param>
        /// <returns>The result of clamping a value between min and max</returns>
        public static int Clamp(int value, int min, int max)
        {
            return value < min ? min : value > max ? max : value;
        }

        /// <summary>
        /// Interpolates between two values using a linear function by a given amount.
        /// </summary>
        /// <remarks>
        /// See http://www.encyclopediaofmath.org/index.php/Linear_interpolation and
        /// http://fgiesen.wordpress.com/2012/08/15/linear-interpolation-past-present-and-future/
        /// </remarks>
        /// <param name="from">Value to interpolate from.</param>
        /// <param name="to">Value to interpolate to.</param>
        /// <param name="amount">Interpolation amount.</param>
        /// <returns>The result of linear interpolation of values based on the amount.</returns>
        public static double Lerp(double from, double to, double amount)
        {
            return (1 - amount) * from + amount * to;
        }

        /// <summary>
        /// Interpolates between two values using a linear function by a given amount.
        /// </summary>
        /// <remarks>
        /// See http://www.encyclopediaofmath.org/index.php/Linear_interpolation and
        /// http://fgiesen.wordpress.com/2012/08/15/linear-interpolation-past-present-and-future/
        /// </remarks>
        /// <param name="from">Value to interpolate from.</param>
        /// <param name="to">Value to interpolate to.</param>
        /// <param name="amount">Interpolation amount.</param>
        /// <returns>The result of linear interpolation of values based on the amount.</returns>
        public static float Lerp(float from, float to, float amount)
        {
            return (1 - amount) * from + amount * to;
        }

        /// <summary>
        /// Interpolates between two values using a linear function by a given amount.
        /// </summary>
        /// <remarks>
        /// See http://www.encyclopediaofmath.org/index.php/Linear_interpolation and
        /// http://fgiesen.wordpress.com/2012/08/15/linear-interpolation-past-present-and-future/
        /// </remarks>
        /// <param name="from">Value to interpolate from.</param>
        /// <param name="to">Value to interpolate to.</param>
        /// <param name="amount">Interpolation amount.</param>
        /// <returns>The result of linear interpolation of values based on the amount.</returns>
        public static byte Lerp(byte from, byte to, float amount)
        {
            return (byte)Lerp((float)from, (float)to, amount);
        }

        /// <summary>
        /// Calculates the modulo of the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="modulo">The modulo.</param>
        /// <returns>The result of the modulo applied to value</returns>
        public static float Mod(float value, float modulo)
        {
            if (modulo == 0.0f)
            {
                return value;
            }

            return value % modulo;
        }

        /// <summary>
        /// Calculates the modulo 2*PI of the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the modulo applied to value</returns>
        public static float Mod2PI(float value)
        {
            return Mod(value, TwoPi);
        }

        /// <summary>
        /// Wraps the specified value into a range.
        /// </summary>
        /// <param name="value">The value to wrap.</param>
        /// <param name="min">The min.</param>
        /// <param name="max">The max.</param>
        /// <returns>Result of the wrapping.</returns>
        public static int Wrap(int value, int min, int max)
        {
            if (min == max) return min;

            int v = (((value - min) % (max - min)));
            if (value > max)
            {
                return min + v;
            }
            if (value < min)
            {
                return max + v;
            }

            return value;
        }

        /// <summary>
        /// Wraps the specified value into a range.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="min">The min.</param>
        /// <param name="max">The max.</param>
        /// <returns>Result of the wrapping.</returns>
        public static float Wrap(float value, float min, float max)
        {
            if (WithinEpsilon(min, max)) return min;

            float v = (((value - min) % (max - min)));
            if (value > max)
            {
                return min + v;
            }
            if (value < min)
            {
                return max + v;
            }

            return value;
        }
        
        /// <summary>
        /// Gauss function.
        /// </summary>
        /// <param name="amplitude">Curve amplitude.</param>
        /// <param name="x">Position X.</param>
        /// <param name="y">Position Y</param>
        /// <param name="radX">Radius X.</param>
        /// <param name="radY">Radius Y.</param>
        /// <param name="sigmaX">Curve sigma X.</param>
        /// <param name="sigmaY">Curve sigma Y.</param>
        /// <returns>The result of Gaussian function.</returns>
        public static float Gauss(float amplitude, float x, float y, float radX, float radY, float sigmaX, float sigmaY)
        {
            return (float)Gauss((double)amplitude, x, y, radX, radY, sigmaX, sigmaY);
        }

        /// <summary>
        /// Gauss function.
        /// </summary>
        /// <param name="amplitude">Curve amplitude.</param>
        /// <param name="x">Position X.</param>
        /// <param name="y">Position Y</param>
        /// <param name="radX">Radius X.</param>
        /// <param name="radY">Radius Y.</param>
        /// <param name="sigmaX">Curve sigma X.</param>
        /// <param name="sigmaY">Curve sigma Y.</param>
        /// <returns>The result of Gaussian function.</returns>
        public static double Gauss(double amplitude, double x, double y, double radX, double radY, double sigmaX, double sigmaY)
        {
            return (amplitude * Math.E) -
                (
                    Math.Pow(x - (radX / 2), 2) / (2 * Math.Pow(sigmaX, 2)) +
                    Math.Pow(y - (radY / 2), 2) / (2 * Math.Pow(sigmaY, 2))
                );
        }
        
        
#if NET35Plus                    
        /// <summary>
        /// Gets random <c>float</c> number within range.
        /// </summary>
        /// <param name="random">Current <see cref="System.Random"/>.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Maximum.</param>
        /// <returns>Random <c>float</c> number.</returns>
        public static float NextFloat(this Random random, float min, float max)
        {
            return Lerp(min, max, (float)random.NextDouble());
        }

        /// <summary>
        /// Gets random <c>double</c> number within range.
        /// </summary>
        /// <param name="random">Current <see cref="System.Random"/>.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Maximum.</param>
        /// <returns>Random <c>double</c> number.</returns>
        public static double NextDouble(this Random random, double min, double max)
        {
            return Lerp(min, max, random.NextDouble());
        } 
        
        /// <summary>
        /// Gets random <c>long</c> number.
        /// </summary>
        /// <param name="random">Current <see cref="System.Random"/>.</param>
        /// <returns>Random <c>long</c> number.</returns>
        public static long NextLong(this Random random)
        { 
            var buffer = new byte[sizeof(long)];
            random.NextBytes(buffer);
            return BitConverter.ToInt64(buffer, 0);
        }

        /// <summary>
        /// Gets random <c>long</c> number within range.
        /// </summary>
        /// <param name="random">Current <see cref="System.Random"/>.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Maximum.</param>
        /// <returns>Random <c>long</c> number.</returns>
        public static long NextLong(this Random random,long min,long max)
        {
            byte[] buf = new byte[sizeof(long)];
            random.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (max - min)) + min);
        } 

        /// <summary>
        /// Gets random <see cref="SharpDX.Vector2"/> within range.
        /// </summary>
        /// <param name="random">Current <see cref="System.Random"/>.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Maximum.</param>
        /// <returns>Random <see cref="SharpDX.Vector2"/>.</returns>
        public static Vector2 NextVector2(this Random random, Vector2 min, Vector2 max)
        {
            return new Vector2(random.NextFloat(min.X, max.X), random.NextFloat(min.Y, max.Y));
        }

        /// <summary>
        /// Gets random <see cref="SharpDX.Vector3"/> within range.
        /// </summary>
        /// <param name="random">Current <see cref="System.Random"/>.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Maximum.</param>
        /// <returns>Random <see cref="SharpDX.Vector3"/>.</returns>
        public static Vector3 NextVector3(this Random random, Vector3 min, Vector3 max)
        {
            return new Vector3(random.NextFloat(min.X, max.X), random.NextFloat(min.Y, max.Y), random.NextFloat(min.Z, max.Z));
        }

        /// <summary>
        /// Gets random <see cref="SharpDX.Vector4"/> within range.
        /// </summary>
        /// <param name="random">Current <see cref="System.Random"/>.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Maximum.</param>
        /// <returns>Random <see cref="SharpDX.Vector4"/>.</returns>
        public static Vector4 NextVector4(this Random random, Vector4 min, Vector4 max)
        {
            return new Vector4(random.NextFloat(min.X, max.X), random.NextFloat(min.Y, max.Y), random.NextFloat(min.Z, max.Z), random.NextFloat(min.W, max.W));
        }

        /// <summary>
        /// Gets random opaque <see cref="SharpDX.Color"/>.
        /// </summary>
        /// <param name="random">Current <see cref="System.Random"/>.</param>
        /// <returns>Random <see cref="SharpDX.Color"/>.</returns>
        public static Color NextColor(this Random random)
        {
            return new Color(random.NextFloat(0.0f, 1.0f), random.NextFloat(0.0f, 1.0f), random.NextFloat(0.0f, 1.0f), 1.0f);
        }

        /// <summary>
        /// Gets random opaque <see cref="SharpDX.Color"/>.
        /// </summary>
        /// <param name="random">Current <see cref="System.Random"/>.</param>
        /// <param name="minBrightness">Minimum brightness.</param>
        /// <param name="maxBrightness">Maximum brightness</param>
        /// <returns>Random <see cref="SharpDX.Color"/>.</returns>
        public static Color NextColor(this Random random, float minBrightness, float maxBrightness)
        {
            return new Color(random.NextFloat(minBrightness, maxBrightness), random.NextFloat(minBrightness, maxBrightness), random.NextFloat(minBrightness, maxBrightness), 1.0f);
        }

        /// <summary>
        /// Gets random <see cref="SharpDX.Color"/>.
        /// </summary>
        /// <param name="random">Current <see cref="System.Random"/>.</param>   
        /// <param name="minBrightness">Minimum brightness.</param>
        /// <param name="maxBrightness">Maximum brightness</param>
        /// <param name="alpha">Alpha value.</param>
        /// <returns>Random <see cref="SharpDX.Color"/>.</returns>
        public static Color NextColor(this Random random, float minBrightness, float maxBrightness, float alpha)
        {
            return new Color(random.NextFloat(minBrightness, maxBrightness), random.NextFloat(minBrightness, maxBrightness), random.NextFloat(minBrightness, maxBrightness), alpha);
        } 

        /// <summary>
        /// Gets random <see cref="SharpDX.Color"/>.
        /// </summary>
        /// <param name="random">Current <see cref="System.Random"/>.</param>
        /// <param name="minBrightness">Minimum brightness.</param>
        /// <param name="maxBrightness">Maximum brightness</param>
        /// <param name="minAlpha">Minimum alpha.</param>
        /// <param name="maxAlpha">Maximum alpha.</param>
        /// <returns>Random <see cref="SharpDX.Color"/>.</returns>
        public static Color NextColor(this Random random, float minBrightness, float maxBrightness, float minAlpha, float maxAlpha)
        {
            return new Color(random.NextFloat(minBrightness, maxBrightness), random.NextFloat(minBrightness, maxBrightness), random.NextFloat(minBrightness, maxBrightness), random.NextFloat(minAlpha, maxAlpha));
        }

        /// <summary>
        /// Gets random <see cref="SharpDX.Point"/>.
        /// </summary>
        /// <param name="random">Current <see cref="System.Random"/>.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Maximum.</param>
        /// <returns>Random <see cref="SharpDX.Point"/>.</returns>
        public static Point NextDPoint(this Random random,Point min,Point max)
        {
            return new Point(random.Next(min.X,max.X),random.Next(min.Y,max.Y));
        }

        /// <summary>
        /// Gets random <see cref="SharpDX.Vector2"/>.
        /// </summary>
        /// <param name="random">Current <see cref="System.Random"/>.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Maximum.</param>
        /// <returns>Random <see cref="SharpDX.Vector2"/>.</returns>
        public static Vector2 NextDPointF(this Random random, Vector2 min, Vector2 max)
        {
            return new Vector2(random.NextFloat(min.X, max.X), random.NextFloat(min.Y, max.Y));
        }
        
        /// <summary>
        /// Gets random <see cref="System.TimeSpan"/>.
        /// </summary>
        /// <param name="random">Current <see cref="System.Random"/>.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Maximum.</param>
        /// <returns>Random <see cref="System.TimeSpan"/>.</returns>
        public static TimeSpan NextTime(this Random random, TimeSpan min, TimeSpan max)
        { 
            return TimeSpan.FromTicks(random.NextLong(min.Ticks,max.Ticks));
        }
#else
        /// <summary>
        /// Gets random <c>float</c> number within range.
        /// </summary>
        /// <param name="random">A <see cref="System.Random"/> instance.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Maximum.</param>
        /// <returns>Random <c>float</c> number.</returns>
        public static float NextFloat(Random random, float min, float max)
        {
            return Lerp(min, max, (float)random.NextDouble());
        }

        /// <summary>
        /// Gets random <c>double</c> number within range.
        /// </summary>
        /// <param name="random">A <see cref="System.Random"/> instance.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Maximum.</param>
        /// <returns>Random <c>double</c> number.</returns>
        public static double NextDouble(Random random, double min, double max)
        {
            return Lerp(min, max, random.NextDouble());
        }

        /// <summary>
        /// Gets random <c>long</c> number.
        /// </summary>
        /// <param name="random">A <see cref="System.Random"/> instance.</param>
        /// <returns>Random <c>long</c> number.</returns>
        public static long NextLong(Random random)
        {
            var buffer = new byte[sizeof(long)];
            random.NextBytes(buffer);
            return BitConverter.ToInt64(buffer, 0);
        }

        /// <summary>
        /// Gets random <c>long</c> number within range.
        /// </summary>
        /// <param name="random">A <see cref="System.Random"/> instance.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Maximum.</param>
        /// <returns>Random <c>long</c> number.</returns>
        public static long NextLong(Random random, long min, long max)
        {
            byte[] buf = new byte[sizeof(long)];
            random.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (max - min)) + min);
        }

        /// <summary>
        /// Gets random <see cref="SharpDX.Vector2"/> within range.
        /// </summary>
        /// <param name="random">A <see cref="System.Random"/> instance.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Maximum.</param>
        /// <returns>Random <see cref="SharpDX.Vector2"/>.</returns>
        public static Vector2 NextVector2(Random random, Vector2 min, Vector2 max)
        {
            return new Vector2(NextFloat(random, min.X, max.X), NextFloat(random, min.Y, max.Y));
        }

        /// <summary>
        /// Gets random <see cref="SharpDX.Vector3"/> within range.
        /// </summary>
        /// <param name="random">A <see cref="System.Random"/> instance.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Maximum.</param>
        /// <returns>Random <see cref="SharpDX.Vector3"/>.</returns>
        public static Vector3 NextVector3(Random random, Vector3 min, Vector3 max)
        {
            return new Vector3(NextFloat(random, min.X, max.X), NextFloat(random, min.Y, max.Y), NextFloat(random, min.Z, max.Z));
        }

        /// <summary>
        /// Gets random <see cref="SharpDX.Vector4"/> within range.
        /// </summary>
        /// <param name="random">A <see cref="System.Random"/> instance.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Maximum.</param>
        /// <returns>Random <see cref="SharpDX.Vector4"/>.</returns>
        public static Vector4 NextVector4(Random random, Vector4 min, Vector4 max)
        {
            return new Vector4(NextFloat(random, min.X, max.X), NextFloat(random, min.Y, max.Y), NextFloat(random, min.Z, max.Z), NextFloat(random, min.W, max.W));
        }

        /// <summary>
        /// Gets random opaque <see cref="SharpDX.Color"/>.
        /// </summary>
        /// <param name="random">A <see cref="System.Random"/> instance.</param>
        /// <returns>Random <see cref="SharpDX.Color"/>.</returns>
        public static Color NextColor(Random random)
        {
            return new Color(NextFloat(random, 0.0f, 1.0f), NextFloat(random, 0.0f, 1.0f), NextFloat(random, 0.0f, 1.0f), 1.0f);
        }

        /// <summary>
        /// Gets random opaque <see cref="SharpDX.Color"/>.
        /// </summary>
        /// <param name="random">A <see cref="System.Random"/> instance.</param>
        /// <param name="minBrightness">Minimum brightness.</param>
        /// <param name="maxBrightness">Maximum brightness</param>
        /// <returns>Random <see cref="SharpDX.Color"/>.</returns>
        public static Color NextColor(Random random, float minBrightness, float maxBrightness)
        {
            return new Color(NextFloat(random, minBrightness, maxBrightness), NextFloat(random, minBrightness, maxBrightness), NextFloat(random, minBrightness, maxBrightness), 1.0f);
        }

        /// <summary>
        /// Gets random <see cref="SharpDX.Color"/>.
        /// </summary>
        /// <param name="random">A <see cref="System.Random"/> instance.</param>
        /// <param name="minBrightness">Minimum brightness.</param>
        /// <param name="maxBrightness">Maximum brightness</param>
        /// <param name="alpha">Alpha value.</param>
        /// <returns>Random <see cref="SharpDX.Color"/>.</returns>
        public static Color NextColor(Random random, float minBrightness, float maxBrightness, float alpha)
        {
            return new Color(NextFloat(random, minBrightness, maxBrightness), NextFloat(random, minBrightness, maxBrightness), NextFloat(random, minBrightness, maxBrightness), alpha);
        }

        /// <summary>
        /// Gets random <see cref="SharpDX.Color"/>.
        /// </summary>
        /// <param name="random">A <see cref="System.Random"/> instance.</param>
        /// <param name="minBrightness">Minimum brightness.</param>
        /// <param name="maxBrightness">Maximum brightness</param>
        /// <param name="minAlpha">Minimum alpha.</param>
        /// <param name="maxAlpha">Maximum alpha.</param>
        /// <returns>Random <see cref="SharpDX.Color"/>.</returns>
        public static Color NextColor(Random random, float minBrightness, float maxBrightness, float minAlpha, float maxAlpha)
        {
            return new Color(NextFloat(random, minBrightness, maxBrightness), NextFloat(random, minBrightness, maxBrightness), NextFloat(random, minBrightness, maxBrightness), NextFloat(random, minAlpha, maxAlpha));
        }

        /// <summary>
        /// Gets random <see cref="SharpDX.Point"/>.
        /// </summary>
        /// <param name="random">A <see cref="System.Random"/> instance.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Maximum.</param>
        /// <returns>Random <see cref="SharpDX.Point"/>.</returns>
        public static Point NextDPoint(Random random, Point min, Point max)
        {
            return new Point(random.Next(min.X, max.X), random.Next(min.Y, max.Y));
        }

        /// <summary>
        /// Gets random <see cref="SharpDX.Vector2"/>.
        /// </summary>
        /// <param name="random">A <see cref="System.Random"/> instance.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Maximum.</param>
        /// <returns>Random <see cref="SharpDX.Vector2"/>.</returns>
        public static Vector2 NextDPointF(Random random, Vector2 min, Vector2 max)
        {
            return new Vector2(NextFloat(random, min.X, max.X), NextFloat(random, min.Y, max.Y));
        }

        /// <summary>
        /// Gets random <see cref="System.TimeSpan"/>.
        /// </summary>
        /// <param name="random">A <see cref="System.Random"/> instance.</param>
        /// <param name="min">Minimum.</param>
        /// <param name="max">Maximum.</param>
        /// <returns>Random <see cref="System.TimeSpan"/>.</returns>
        public static TimeSpan NextTime(Random random, TimeSpan min, TimeSpan max)
        {
            return TimeSpan.FromTicks(NextLong(random, min.Ticks, max.Ticks));
        }
#endif
    }
}
