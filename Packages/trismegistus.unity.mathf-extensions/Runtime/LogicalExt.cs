namespace Trismegistus.MathfExtensions {
	public static class LogicalExt {
		public static bool Neg(this bool a) => !a;
		public static bool And(this bool a, bool b) => a & b;
		public static bool Or(this bool a, bool b) => a | b;
		public static bool Xor(this bool a, bool b) => a ^ b;
		public static bool AndCond(this bool a, bool b) => a && b;
		public static bool OrCond(this bool a, bool b) => a || b;
	}
}