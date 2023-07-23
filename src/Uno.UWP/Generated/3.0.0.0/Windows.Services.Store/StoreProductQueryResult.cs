#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Store
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class StoreProductQueryResult 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Exception ExtendedError
		{
			get
			{
				throw new global::System.NotImplementedException("The member Exception StoreProductQueryResult.ExtendedError is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Exception%20StoreProductQueryResult.ExtendedError");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyDictionary<string, global::Windows.Services.Store.StoreProduct> Products
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyDictionary<string, StoreProduct> StoreProductQueryResult.Products is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyDictionary%3Cstring%2C%20StoreProduct%3E%20StoreProductQueryResult.Products");
			}
		}
#endif
		// Forced skipping of method Windows.Services.Store.StoreProductQueryResult.Products.get
		// Forced skipping of method Windows.Services.Store.StoreProductQueryResult.ExtendedError.get
	}
}
