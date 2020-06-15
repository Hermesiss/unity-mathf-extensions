namespace Trismegistus.MathfExtensions {
	public static class BitwiseExt {
		//int
		public static int BitComplement(this int a) => ~a;
		public static int BitLeftShift(this int a, int b) => a << b;
		public static int BitRightShift(this int a, int b) => a >> b;
		public static int BitAnd(this int a, int b) => a & b;
		public static int BitOr(this int a, int b) => a | b;
		public static int BitXor(this int a, int b) => a ^ b;

		//uint
		public static uint BitComplement(this uint a) => ~a;
		public static uint BitLeftShift(this uint a, int b) => a << b;
		public static uint BitRightShift(this uint a, int b) => a >> b;
		public static uint BitAnd(this uint a, uint b) => a & b;
		public static uint BitOr(this uint a, uint b) => a | b;
		public static uint BitXor(this uint a, uint b) => a ^ b;

		//long
		public static long BitComplement(this long a) => ~a;
		public static long BitLeftShift(this long a, int b) => a << b;
		public static long BitRightShift(this long a, int b) => a >> b;
		public static long BitAnd(this long a, long b) => a & b;
		public static long BitOr(this long a, long b) => a | b;
		public static long BitXor(this long a, long b) => a ^ b;

		//ulong
		public static ulong BitComplement(this ulong a) => ~a;
		public static ulong BitLeftShift(this ulong a, int b) => a << b;
		public static ulong BitRightShift(this ulong a, int b) => a >> b;
		public static ulong BitAnd(this ulong a, ulong b) => a & b;
		public static ulong BitOr(this ulong a, ulong b) => a | b;
		public static ulong BitXor(this ulong a, ulong b) => a ^ b;
		
		//sbyte
		public static int BitComplement(this sbyte a) => ~a;
		public static int BitLeftShift(this sbyte a, int b) => a << b;
		public static int BitRightShift(this sbyte a, int b) => a >> b;
		public static int BitAnd(this sbyte a, sbyte b) => a & b;
		public static int BitOr(this sbyte a, sbyte b) => a | b;
		public static int BitXor(this sbyte a, sbyte b) => a ^ b;
		
		//byte
		public static int BitComplement(this byte a) => ~a;
		public static int BitLeftShift(this byte a, int b) => a << b;
		public static int BitRightShift(this byte a, int b) => a >> b;
		public static int BitAnd(this byte a, byte b) => a & b;
		public static int BitOr(this byte a, byte b) => a | b;
		public static int BitXor(this byte a, byte b) => a ^ b;
		
		//short
		public static int BitComplement(this short a) => ~a;
		public static int BitLeftShift(this short a, int b) => a << b;
		public static int BitRightShift(this short a, int b) => a >> b;
		public static int BitAnd(this short a, short b) => a & b;
		public static int BitOr(this short a, short b) => a | b;
		public static int BitXor(this short a, short b) => a ^ b;
		
		//ushort
		public static int BitComplement(this ushort a) => ~a;
		public static int BitLeftShift(this ushort a, int b) => a << b;
		public static int BitRightShift(this ushort a, int b) => a >> b;
		public static int BitAnd(this ushort a, ushort b) => a & b;
		public static int BitOr(this ushort a, ushort b) => a | b;
		public static int BitXor(this ushort a, ushort b) => a ^ b;
		
		//char
		public static int BitComplement(this char a) => ~a;
		public static int BitLeftShift(this char a, int b) => a << b;
		public static int BitRightShift(this char a, int b) => a >> b;
		public static int BitAnd(this char a, char b) => a & b;
		public static int BitOr(this char a, char b) => a | b;
		public static int BitXor(this char a, char b) => a ^ b;
	}
}