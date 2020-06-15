using System;
using NUnit.Framework;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Trismegistus.MathfExtensions.Tests {
	public class MathfExtensionsTests {
		[Test]
		public void ClosestPowerOfTwo() {
			Assert.True(Tester(MathfExt.ClosestPowerOfTwo,
				Mathf.ClosestPowerOfTwo,
				() => Random.Range(0, 10000)));
		}

		[Test]
		public void IsPowerOfTwo() {
			Assert.True(Tester(MathfExt.IsPowerOfTwo,
				Mathf.IsPowerOfTwo,
				() => Random.Range(0, 10000)));
		}

		[Test]
		public void NextPowerOfTwo() {
			Assert.True(Tester(MathfExt.NextPowerOfTwo,
				Mathf.NextPowerOfTwo,
				() => Random.Range(0, 10000)));
		}

		[Test]
		public void GammaToLinearSpace() {
			Assert.True(Tester(MathfExt.GammaToLinearSpace,
				Mathf.GammaToLinearSpace,
				() => Random.Range(0, 10f)));
		}

		[Test]
		public void LinearToGammaSpace() {
			Assert.True(Tester(MathfExt.LinearToGammaSpace,
				Mathf.LinearToGammaSpace,
				() => Random.Range(0, 10f)));
		}

		[Test]
		public void CorrelatedColorTemperatureToRGB() {
			Assert.True(Tester(MathfExt.CorrelatedColorTemperatureToRGB,
				Mathf.CorrelatedColorTemperatureToRGB,
				() => Random.Range(0, 100f)));
		}

		[Test]
		public void FloatToHalf() {
			Assert.True(Tester(MathfExt.FloatToHalf,
				Mathf.FloatToHalf,
				() => Random.Range(0, 100f)));
		}

		[Test]
		public void EllipseSectorArea() {
			var a = Random.Range(1, 10f);
			var b = Random.Range(1, 10f);
			var a1 = Random.Range(0, 360f);
			var a2 = Random.Range(0, 360f);

			var resultMathf = a * b * .5f * (Mathf.Atan(a / b * Mathf.Tan(a2)) - Mathf.Atan(a / b * Mathf.Tan(a1)));

			var resultExt = a * b * .5f * ((a / b * a2.Tan()).Atan() - (a / b * a1.Tan()).Atan());

			Assert.True(resultMathf.Equals(resultExt));
		}

		private static bool Tester<TIn, TOut>(Func<TIn, TOut> left, Func<TIn, TOut> right, Func<TIn> valueProvider,
			int repetitions = 100) {
			for (var i = 0; i < repetitions; i++) {
				var val = valueProvider();
				if (!left(val).Equals(right(val))) {
					Debug.LogError($"{left} and {right} don't match!");
					return false;
				}
			}

			return true;
		}
	}
}