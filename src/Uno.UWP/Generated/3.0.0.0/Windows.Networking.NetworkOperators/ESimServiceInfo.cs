#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class ESimServiceInfo 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Networking.NetworkOperators.ESimAuthenticationPreference AuthenticationPreference
		{
			get
			{
				throw new global::System.NotImplementedException("The member ESimAuthenticationPreference ESimServiceInfo.AuthenticationPreference is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ESimAuthenticationPreference%20ESimServiceInfo.AuthenticationPreference");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool IsESimUiEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool ESimServiceInfo.IsESimUiEnabled is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20ESimServiceInfo.IsESimUiEnabled");
			}
		}
#endif
		// Forced skipping of method Windows.Networking.NetworkOperators.ESimServiceInfo.AuthenticationPreference.get
		// Forced skipping of method Windows.Networking.NetworkOperators.ESimServiceInfo.IsESimUiEnabled.get
	}
}
