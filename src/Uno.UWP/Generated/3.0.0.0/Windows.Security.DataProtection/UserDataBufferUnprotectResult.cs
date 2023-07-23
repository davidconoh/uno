#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.DataProtection
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class UserDataBufferUnprotectResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Security.DataProtection.UserDataBufferUnprotectStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member UserDataBufferUnprotectStatus UserDataBufferUnprotectResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=UserDataBufferUnprotectStatus%20UserDataBufferUnprotectResult.Status");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Storage.Streams.IBuffer UnprotectedBuffer
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBuffer UserDataBufferUnprotectResult.UnprotectedBuffer is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IBuffer%20UserDataBufferUnprotectResult.UnprotectedBuffer");
			}
		}
#endif
		// Forced skipping of method Windows.Security.DataProtection.UserDataBufferUnprotectResult.Status.get
		// Forced skipping of method Windows.Security.DataProtection.UserDataBufferUnprotectResult.UnprotectedBuffer.get
	}
}
