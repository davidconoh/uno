#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Printing.Workflow
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class PrintWorkflowSpoolStreamContent 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Storage.Streams.IInputStream GetInputStream()
		{
			throw new global::System.NotImplementedException("The member IInputStream PrintWorkflowSpoolStreamContent.GetInputStream() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IInputStream%20PrintWorkflowSpoolStreamContent.GetInputStream%28%29");
		}
#endif
	}
}
