#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class ESimDiscoverEvent 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string MatchingId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ESimDiscoverEvent.MatchingId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20ESimDiscoverEvent.MatchingId");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string RspServerAddress
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ESimDiscoverEvent.RspServerAddress is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20ESimDiscoverEvent.RspServerAddress");
			}
		}
#endif
		// Forced skipping of method Windows.Networking.NetworkOperators.ESimDiscoverEvent.MatchingId.get
		// Forced skipping of method Windows.Networking.NetworkOperators.ESimDiscoverEvent.RspServerAddress.get
	}
}
