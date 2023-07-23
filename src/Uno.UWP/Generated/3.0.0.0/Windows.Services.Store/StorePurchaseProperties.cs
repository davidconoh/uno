#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Store
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class StorePurchaseProperties 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string StorePurchaseProperties.Name is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20StorePurchaseProperties.Name");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Services.Store.StorePurchaseProperties", "string StorePurchaseProperties.Name");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string ExtendedJsonData
		{
			get
			{
				throw new global::System.NotImplementedException("The member string StorePurchaseProperties.ExtendedJsonData is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20StorePurchaseProperties.ExtendedJsonData");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Services.Store.StorePurchaseProperties", "string StorePurchaseProperties.ExtendedJsonData");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public StorePurchaseProperties( string name) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Services.Store.StorePurchaseProperties", "StorePurchaseProperties.StorePurchaseProperties(string name)");
		}
#endif
		// Forced skipping of method Windows.Services.Store.StorePurchaseProperties.StorePurchaseProperties(string)
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public StorePurchaseProperties() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Services.Store.StorePurchaseProperties", "StorePurchaseProperties.StorePurchaseProperties()");
		}
#endif
		// Forced skipping of method Windows.Services.Store.StorePurchaseProperties.StorePurchaseProperties()
		// Forced skipping of method Windows.Services.Store.StorePurchaseProperties.Name.get
		// Forced skipping of method Windows.Services.Store.StorePurchaseProperties.Name.set
		// Forced skipping of method Windows.Services.Store.StorePurchaseProperties.ExtendedJsonData.get
		// Forced skipping of method Windows.Services.Store.StorePurchaseProperties.ExtendedJsonData.set
	}
}
