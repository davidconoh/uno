#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Email.DataProvider
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class EmailMailboxMoveFolderRequestEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Email.DataProvider.EmailMailboxMoveFolderRequest Request
		{
			get
			{
				throw new global::System.NotImplementedException("The member EmailMailboxMoveFolderRequest EmailMailboxMoveFolderRequestEventArgs.Request is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=EmailMailboxMoveFolderRequest%20EmailMailboxMoveFolderRequestEventArgs.Request");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Email.DataProvider.EmailMailboxMoveFolderRequestEventArgs.Request.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral EmailMailboxMoveFolderRequestEventArgs.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Deferral%20EmailMailboxMoveFolderRequestEventArgs.GetDeferral%28%29");
		}
#endif
	}
}
