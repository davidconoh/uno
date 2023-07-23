#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.RemoteSystems
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class RemoteSystemSessionInfo 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string ControllerDisplayName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string RemoteSystemSessionInfo.ControllerDisplayName is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20RemoteSystemSessionInfo.ControllerDisplayName");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string DisplayName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string RemoteSystemSessionInfo.DisplayName is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20RemoteSystemSessionInfo.DisplayName");
			}
		}
#endif
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSessionInfo.DisplayName.get
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSessionInfo.ControllerDisplayName.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.System.RemoteSystems.RemoteSystemSessionJoinResult> JoinAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<RemoteSystemSessionJoinResult> RemoteSystemSessionInfo.JoinAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CRemoteSystemSessionJoinResult%3E%20RemoteSystemSessionInfo.JoinAsync%28%29");
		}
#endif
	}
}
