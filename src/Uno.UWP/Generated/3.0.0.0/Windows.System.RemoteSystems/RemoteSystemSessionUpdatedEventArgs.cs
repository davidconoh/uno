#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.RemoteSystems
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class RemoteSystemSessionUpdatedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.System.RemoteSystems.RemoteSystemSessionInfo SessionInfo
		{
			get
			{
				throw new global::System.NotImplementedException("The member RemoteSystemSessionInfo RemoteSystemSessionUpdatedEventArgs.SessionInfo is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=RemoteSystemSessionInfo%20RemoteSystemSessionUpdatedEventArgs.SessionInfo");
			}
		}
#endif
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSessionUpdatedEventArgs.SessionInfo.get
	}
}
