#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Store
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class StorePrice 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string CurrencyCode
		{
			get
			{
				throw new global::System.NotImplementedException("The member string StorePrice.CurrencyCode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20StorePrice.CurrencyCode");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string FormattedBasePrice
		{
			get
			{
				throw new global::System.NotImplementedException("The member string StorePrice.FormattedBasePrice is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20StorePrice.FormattedBasePrice");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string FormattedPrice
		{
			get
			{
				throw new global::System.NotImplementedException("The member string StorePrice.FormattedPrice is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20StorePrice.FormattedPrice");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string FormattedRecurrencePrice
		{
			get
			{
				throw new global::System.NotImplementedException("The member string StorePrice.FormattedRecurrencePrice is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20StorePrice.FormattedRecurrencePrice");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool IsOnSale
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool StorePrice.IsOnSale is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20StorePrice.IsOnSale");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.DateTimeOffset SaleEndDate
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset StorePrice.SaleEndDate is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DateTimeOffset%20StorePrice.SaleEndDate");
			}
		}
#endif
		// Forced skipping of method Windows.Services.Store.StorePrice.FormattedBasePrice.get
		// Forced skipping of method Windows.Services.Store.StorePrice.FormattedPrice.get
		// Forced skipping of method Windows.Services.Store.StorePrice.IsOnSale.get
		// Forced skipping of method Windows.Services.Store.StorePrice.SaleEndDate.get
		// Forced skipping of method Windows.Services.Store.StorePrice.CurrencyCode.get
		// Forced skipping of method Windows.Services.Store.StorePrice.FormattedRecurrencePrice.get
	}
}
