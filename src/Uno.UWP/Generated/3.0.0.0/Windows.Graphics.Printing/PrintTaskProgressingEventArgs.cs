#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Printing
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class PrintTaskProgressingEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint DocumentPageCount
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint PrintTaskProgressingEventArgs.DocumentPageCount is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20PrintTaskProgressingEventArgs.DocumentPageCount");
			}
		}
#endif
		// Forced skipping of method Windows.Graphics.Printing.PrintTaskProgressingEventArgs.DocumentPageCount.get
	}
}
