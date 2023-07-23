#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Credentials
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class KeyCredentialOperationResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Storage.Streams.IBuffer Result
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBuffer KeyCredentialOperationResult.Result is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IBuffer%20KeyCredentialOperationResult.Result");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Security.Credentials.KeyCredentialStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member KeyCredentialStatus KeyCredentialOperationResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=KeyCredentialStatus%20KeyCredentialOperationResult.Status");
			}
		}
#endif
		// Forced skipping of method Windows.Security.Credentials.KeyCredentialOperationResult.Result.get
		// Forced skipping of method Windows.Security.Credentials.KeyCredentialOperationResult.Status.get
	}
}
