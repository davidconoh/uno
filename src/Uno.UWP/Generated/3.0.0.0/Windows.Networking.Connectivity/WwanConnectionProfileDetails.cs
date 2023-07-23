#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Connectivity
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class WwanConnectionProfileDetails 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string AccessPointName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string WwanConnectionProfileDetails.AccessPointName is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20WwanConnectionProfileDetails.AccessPointName");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string HomeProviderId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string WwanConnectionProfileDetails.HomeProviderId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20WwanConnectionProfileDetails.HomeProviderId");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Networking.Connectivity.WwanNetworkIPKind IPKind
		{
			get
			{
				throw new global::System.NotImplementedException("The member WwanNetworkIPKind WwanConnectionProfileDetails.IPKind is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WwanNetworkIPKind%20WwanConnectionProfileDetails.IPKind");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<global::System.Guid> PurposeGuids
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<Guid> WwanConnectionProfileDetails.PurposeGuids is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CGuid%3E%20WwanConnectionProfileDetails.PurposeGuids");
			}
		}
#endif
		// Forced skipping of method Windows.Networking.Connectivity.WwanConnectionProfileDetails.HomeProviderId.get
		// Forced skipping of method Windows.Networking.Connectivity.WwanConnectionProfileDetails.AccessPointName.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Networking.Connectivity.WwanNetworkRegistrationState GetNetworkRegistrationState()
		{
			throw new global::System.NotImplementedException("The member WwanNetworkRegistrationState WwanConnectionProfileDetails.GetNetworkRegistrationState() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WwanNetworkRegistrationState%20WwanConnectionProfileDetails.GetNetworkRegistrationState%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Networking.Connectivity.WwanDataClass GetCurrentDataClass()
		{
			throw new global::System.NotImplementedException("The member WwanDataClass WwanConnectionProfileDetails.GetCurrentDataClass() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=WwanDataClass%20WwanConnectionProfileDetails.GetCurrentDataClass%28%29");
		}
#endif
		// Forced skipping of method Windows.Networking.Connectivity.WwanConnectionProfileDetails.IPKind.get
		// Forced skipping of method Windows.Networking.Connectivity.WwanConnectionProfileDetails.PurposeGuids.get
	}
}
