#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.RemoteSystems
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class RemoteSystemSessionJoinRequestedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.System.RemoteSystems.RemoteSystemSessionJoinRequest JoinRequest
		{
			get
			{
				throw new global::System.NotImplementedException("The member RemoteSystemSessionJoinRequest RemoteSystemSessionJoinRequestedEventArgs.JoinRequest is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=RemoteSystemSessionJoinRequest%20RemoteSystemSessionJoinRequestedEventArgs.JoinRequest");
			}
		}
#endif
		// Forced skipping of method Windows.System.RemoteSystems.RemoteSystemSessionJoinRequestedEventArgs.JoinRequest.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral RemoteSystemSessionJoinRequestedEventArgs.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Deferral%20RemoteSystemSessionJoinRequestedEventArgs.GetDeferral%28%29");
		}
#endif
	}
}
