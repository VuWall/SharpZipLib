using System;
using NUnit.Framework;

namespace ICSharpCode.SharpZipLib.Tests.TestSupport
{
	/// <summary>
	/// Miscellaneous test utilities.
	/// </summary>
	public static class Utils
	{

		static void Compare(byte[] a, byte[] b)
		{
			if (a == null) {
				throw new ArgumentNullException(ICSharpCode.SharpZipLib.Name.Of(a));
			}

			if (b == null) {
				throw new ArgumentNullException(ICSharpCode.SharpZipLib.Name.Of(b));
			}

			Assert.AreEqual(a.Length, b.Length);
			for (int i = 0; i < a.Length; ++i) {
				Assert.AreEqual(a[i], b[i]);
			}
		}

	}
}
