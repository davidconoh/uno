#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Ocr
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class OcrLine 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string Text
		{
			get
			{
				throw new global::System.NotImplementedException("The member string OcrLine.Text is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20OcrLine.Text");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<global::Windows.Media.Ocr.OcrWord> Words
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<OcrWord> OcrLine.Words is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3COcrWord%3E%20OcrLine.Words");
			}
		}
#endif
		// Forced skipping of method Windows.Media.Ocr.OcrLine.Words.get
		// Forced skipping of method Windows.Media.Ocr.OcrLine.Text.get
	}
}
