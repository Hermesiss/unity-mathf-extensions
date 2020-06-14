using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Internal;

namespace Trismegistus.MathfExtensions {
	public static class MathfExtensions {
		/// <summary>
		///   <para>Returns the closest power of two value.</para>
		/// </summary>
		/// <param name="value"></param>
		public static int ClosestPowerOfTwo(this int value) => Mathf.ClosestPowerOfTwo(value);

		/// <summary>
		///   <para>Returns true if the value is power of two.</para>
		/// </summary>
		/// <param name="value"></param>
		public static bool IsPowerOfTwo(this int value) => Mathf.IsPowerOfTwo(value);

		/// <summary>
		///   <para>Returns the next power of two that is equal to, or greater than, the argument.</para>
		/// </summary>
		/// <param name="value"></param>
		public static int NextPowerOfTwo(this int value) => Mathf.NextPowerOfTwo(value);

		/// <summary>
		///   <para>Converts the given value from gamma (sRGB) to linear color space.</para>
		/// </summary>
		/// <param name="value"></param>
		public static float GammaToLinearSpace(this float value) => Mathf.GammaToLinearSpace(value);

		/// <summary>
		///   <para>Converts the given value from linear to gamma (sRGB) color space.</para>
		/// </summary>
		/// <param name="value"></param>
		public static float LinearToGammaSpace(this float value) => Mathf.LinearToGammaSpace(value);

		/// <summary>
		///   <para>Convert a color temperature in Kelvin to RGB color.</para>
		/// </summary>
		/// <param name="kelvin">Temperature in Kelvin. Range 1000 to 40000 Kelvin.</param>
		/// <returns>
		///   <para>Correlated Color Temperature as floating point RGB color.</para>
		/// </returns>
		public static Color CorrelatedColorTemperatureToRGB(this float kelvin) =>
			Mathf.CorrelatedColorTemperatureToRGB(kelvin);

		public static ushort FloatToHalf(this float val) => Mathf.FloatToHalf(val);

		public static float HalfToFloat(this ushort val) => Mathf.HalfToFloat(val);

		/// <summary>
		///   <para>Generate 2D Perlin noise.</para>
		/// </summary>
		/// <param name="point">Coordinates of sample point</param>
		/// <returns>
		///   <para>Value between 0.0 and 1.0. (Return value might be slightly below 0.0 or beyond 1.0.)</para>
		/// </returns>
		public static float PerlinNoise(this Vector2 point) => Mathf.PerlinNoise(point.x, point.y);

		/// <summary>
		///   <para>Returns the sine of angle f.</para>
		/// </summary>
		/// <param name="f">The input angle, in radians.</param>
		/// <returns>
		///   <para>The return value between -1 and +1.</para>
		/// </returns>
		public static float Sin(this float f) => Mathf.Sin(f);


		/// <summary>
		///   <para>Returns the cosine of angle f.</para>
		/// </summary>
		/// <param name="f">The input angle, in radians.</param>
		/// <returns>
		///   <para>The return value between -1 and 1.</para>
		/// </returns>
		public static float Cos(this float f) => Mathf.Cos(f);

		/// <summary>
		///   <para>Returns the tangent of angle f in radians.</para>
		/// </summary>
		/// <param name="f"></param>
		public static float Tan(this float f) => Mathf.Tan(f);

		/// <summary>
		///   <para>Returns the arc-sine of f - the angle in radians whose sine is f.</para>
		/// </summary>
		/// <param name="f"></param>
		public static float Asin(this float f) => Mathf.Asin(f);

		/// <summary>
		///   <para>Returns the arc-cosine of f - the angle in radians whose cosine is f.</para>
		/// </summary>
		/// <param name="f"></param>
		public static float Acos(this float f) => Mathf.Acos(f);

		/// <summary>
		///   <para>Returns the arc-tangent of f - the angle in radians whose tangent is f.</para>
		/// </summary>
		/// <param name="f"></param>
		public static float Atan(this float f) => Mathf.Atan(f);

		/// <summary>
		///   <para>Returns the angle in radians whose Tan is y/x.</para>
		/// </summary>
		/// <param name="point"></param>
		public static float Atan2(this Vector2 point) => Mathf.Atan2(point.x, point.y);

		/// <summary>
		///   <para>Returns square root of f.</para>
		/// </summary>
		/// <param name="f"></param>
		public static float Sqrt(this float f) => Mathf.Sqrt(f);

		/// <summary>
		///   <para>Returns the absolute value of f.</para>
		/// </summary>
		/// <param name="f"></param>
		public static float Abs(this float f) => Mathf.Abs(f);


		/// <summary>
		///   <para>Returns the absolute value of value.</para>
		/// </summary>
		/// <param name="value"></param>
		public static int Abs(this int value) => Mathf.Abs(value);

		/// <summary>
		///   <para>Returns the smallest of two or more values.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		public static float Min(this float a, float b) => Mathf.Min(a, b);


		/// <summary>
		///   <para>Returns the smallest of two or more values.</para>
		/// </summary>
		/// <param name="value"></param>
		/// <param name="values"></param>
		public static float Min(this float value, params float[] values) => Mathf.Min(values.Append(value).ToArray());

		/// <summary>
		///   <para>Returns the smallest of two or more values.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		public static int Min(this int a, int b) => Mathf.Min(a, b);


		/// <summary>
		///   <para>Returns the smallest of two or more values.</para>
		/// </summary>
		/// <param name="value"></param>
		/// <param name="values"></param>
		public static int Min(this int value, params int[] values) => Mathf.Min(values.Append(value).ToArray());

		/// <summary>
		///   <para>Returns largest of two or more values.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		public static float Max(this float a, float b) => Mathf.Max(a, b);

		/// <summary>
		///   <para>Returns largest of two or more values.</para>
		/// </summary>
		/// <param name="value"></param>
		/// <param name="values"></param>
		public static float Max(this float value, params float[] values) => Mathf.Max(values.Append(value).ToArray());

		/// <summary>
		///   <para>Returns the largest of two or more values.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="values"></param>
		public static int Max(int a, int b) => Mathf.Max(a, b);

		/// <summary>
		///   <para>Returns the largest of two or more values.</para>
		/// </summary>
		/// <param name="value"></param>
		/// <param name="values"></param>
		public static int Max(this int value, params int[] values) => Mathf.Max(values.Append(value).ToArray());

		/// <summary>
		///   <para>Returns f raised to power p.</para>
		/// </summary>
		/// <param name="f"></param>
		/// <param name="p"></param>
		public static float Pow(this float f, float p) => Mathf.Pow(f, p);


		/// <summary>
		///   <para>Returns e raised to the specified power.</para>
		/// </summary>
		/// <param name="power"></param>
		public static float Exp(this float power) => Mathf.Exp(power);

		/// <summary>
		///   <para>Returns the logarithm of a specified number in a specified base.</para>
		/// </summary>
		/// <param name="f"></param>
		/// <param name="p">Base</param>
		public static float Log(this float f, float p) => Mathf.Log(f, p);

		/// <summary>
		///   <para>Returns the natural (base e) logarithm of a specified number.</para>
		/// </summary>
		/// <param name="f"></param>
		public static float Log(this float f) => Mathf.Log(f);

		/// <summary>
		///   <para>Returns the base 10 logarithm of a specified number.</para>
		/// </summary>
		/// <param name="f"></param>
		public static float Log10(this float f) => Mathf.Log10(f);

		/// <summary>
		///   <para>Returns the smallest integer greater to or equal to f.</para>
		/// </summary>
		/// <param name="f"></param>
		public static float Ceil(this float f) => Mathf.Ceil(f);


		/// <summary>
		///   <para>Returns the largest integer smaller than or equal to f.</para>
		/// </summary>
		/// <param name="f"></param>
		public static float Floor(this float f) => Mathf.Floor(f);

		/// <summary>
		///   <para>Returns f rounded to the nearest integer.</para>
		/// </summary>
		/// <param name="f"></param>
		public static float Round(this float f) => Mathf.Round(f);

		/// <summary>
		///   <para>Returns the smallest integer greater to or equal to f.</para>
		/// </summary>
		/// <param name="f"></param>
		public static int CeilToInt(this float f) => Mathf.CeilToInt(f);

		/// <summary>
		///   <para>Returns the largest integer smaller to or equal to f.</para>
		/// </summary>
		/// <param name="f"></param>
		public static int FloorToInt(this float f) => Mathf.FloorToInt(f);

		/// <summary>
		///   <para>Returns f rounded to the nearest integer.</para>
		/// </summary>
		/// <param name="f"></param>
		public static int RoundToInt(this float f) => Mathf.RoundToInt(f);

		/// <summary>
		///   <para>Returns the sign of f.</para>
		/// </summary>
		/// <param name="f"></param>
		public static float Sign(this float f) => Mathf.Sign(f);

		/// <summary>
		///   <para>Clamps the given value between the given minimum float and maximum float values.  Returns the given value if it is within the min and max range.</para>
		/// </summary>
		/// <param name="value">The floating point value to restrict inside the range defined by the min and max values.</param>
		/// <param name="min">The minimum floating point value to compare against.</param>
		/// <param name="max">The maximum floating point value to compare against.</param>
		/// <returns>
		///   <para>The float result between the min and max values.</para>
		/// </returns>
		public static float Clamp(this float value, float min, float max) => Mathf.Clamp(value, min, max);

		/// <summary>
		///   <para>Clamps the given value between a range defined by the given minimum integer and maximum integer values. Returns the given value if it is within min and max.</para>
		/// </summary>
		/// <param name="value">The integer point value to restrict inside the min-to-max range</param>
		/// <param name="min">The minimum integer point value to compare against.</param>
		/// <param name="max">The maximum  integer point value to compare against.</param>
		/// <returns>
		///   <para>The int result between min and max values.</para>
		/// </returns>
		public static int Clamp(this int value, int min, int max) => Mathf.Clamp(value, min, max);

		/// <summary>
		///   <para>Clamps value between 0 and 1 and returns value.</para>
		/// </summary>
		/// <param name="value"></param>
		public static float Clamp01(this float value) => Mathf.Clamp01(value);

		/// <summary>
		///   <para>Linearly interpolates between a and b by t.</para>
		/// </summary>
		/// <param name="a">The start value.</param>
		/// <param name="b">The end value.</param>
		/// <param name="t">The interpolation value between the two floats.</param>
		/// <returns>
		///   <para>The interpolated float result between the two float values.</para>
		/// </returns>
		public static float Lerp(this float t, float a, float b) => Mathf.Lerp(a, b, t);

		/// <summary>
		///   <para>Linearly interpolates between a and b by t with no limit to t.</para>
		/// </summary>
		/// <param name="a">The start value.</param>
		/// <param name="b">The end value.</param>
		/// <param name="t">The interpolation between the two floats.</param>
		/// <returns>
		///   <para>The float value as a result from the linear interpolation.</para>
		/// </returns>
		public static float LerpUnclamped(this float t, float a, float b) => Mathf.LerpUnclamped(a, b, t);

		/// <summary>
		///   <para>Same as Lerp but makes sure the values interpolate correctly when they wrap around 360 degrees.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		public static float LerpAngle(this float t, float a, float b) => Mathf.LerpAngle(a, b, t);

		/// <summary>
		///   <para>Moves a value current towards target.</para>
		/// </summary>
		/// <param name="current">The current value.</param>
		/// <param name="target">The value to move towards.</param>
		/// <param name="maxDelta">The maximum change that should be applied to the value.</param>
		public static float MoveTowards(this float current, float target, float maxDelta) =>
			Mathf.MoveTowards(current, target, maxDelta);

		/// <summary>
		///   <para>Same as MoveTowards but makes sure the values interpolate correctly when they wrap around 360 degrees.</para>
		/// </summary>
		/// <param name="current"></param>
		/// <param name="target"></param>
		/// <param name="maxDelta"></param>
		public static float MoveTowardsAngle(this float current, float target, float maxDelta) =>
			Mathf.MoveTowardsAngle(current, target, maxDelta);

		/// <summary>
		///   <para>Interpolates between min and max with smoothing at the limits.</para>
		/// </summary>
		/// <param name="from"></param>
		/// <param name="to"></param>
		/// <param name="t"></param>
		public static float SmoothStep(this float t, float from, float to) => Mathf.SmoothStep(from, to, t);

		public static float Gamma(this float value, float absmax, float gamma) => Mathf.Gamma(value, absmax, gamma);

		/// <summary>
		///   <para>Compares two floating point values and returns true if they are similar.</para>
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		public static bool Approximately(this float a, float b) => Mathf.Approximately(a, b);

		public static float SmoothDamp(
			this float current,
			float target,
			ref float currentVelocity,
			float smoothTime,
			float maxSpeed) =>
			Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed);

		public static float SmoothDamp(
			this float current,
			float target,
			ref float currentVelocity,
			float smoothTime)
			=> Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime);

		public static float SmoothDamp(
			this float current,
			float target,
			ref float currentVelocity,
			float smoothTime,
			[DefaultValue("Mathf.Infinity")] float maxSpeed,
			[DefaultValue("Time.deltaTime")] float deltaTime) =>
			Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);

		public static float SmoothDampAngle(
			this float current,
			float target,
			ref float currentVelocity,
			float smoothTime,
			float maxSpeed) {
			float deltaTime = Time.deltaTime;
			return Mathf.SmoothDampAngle(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		public static float SmoothDampAngle(
			float current,
			float target,
			ref float currentVelocity,
			float smoothTime)
			=> Mathf.SmoothDampAngle(current, target, ref currentVelocity, smoothTime);

		public static float SmoothDampAngle(
			this float current,
			float target,
			ref float currentVelocity,
			float smoothTime,
			[DefaultValue("Mathf.Infinity")] float maxSpeed,
			[DefaultValue("Time.deltaTime")] float deltaTime)
			=> Mathf.SmoothDampAngle(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);

		/// <summary>
		///   <para>Loops the value t, so that it is never larger than length and never smaller than 0.</para>
		/// </summary>
		/// <param name="t"></param>
		/// <param name="length"></param>
		public static float Repeat(this float t, float length) => Mathf.Repeat(t, length);

		/// <summary>
		///   <para>PingPongs the value t, so that it is never larger than length and never smaller than 0.</para>
		/// </summary>
		/// <param name="t"></param>
		/// <param name="length"></param>
		public static float PingPong(this float t, float length) => Mathf.PingPong(t, length);

		/// <summary>
		///   <para>Calculates the linear parameter t that produces the interpolant value within the range [a, b].</para>
		/// </summary>
		/// <param name="a">Start value.</param>
		/// <param name="b">End value.</param>
		/// <param name="value">Value between start and end.</param>
		/// <returns>
		///   <para>Percentage of value between start and end.</para>
		/// </returns>
		public static float InverseLerp(this float value, float a, float b) => Mathf.InverseLerp(a, b, value);

		/// <summary>
		///   <para>Calculates the shortest difference between two given angles given in degrees.</para>
		/// </summary>
		/// <param name="current"></param>
		/// <param name="target"></param>
		public static float DeltaAngle(this float current, float target) => Mathf.DeltaAngle(current, target);
	}
}