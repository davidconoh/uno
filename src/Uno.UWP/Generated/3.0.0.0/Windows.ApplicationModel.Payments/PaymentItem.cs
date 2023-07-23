#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Payments
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class PaymentItem 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool Pending
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool PaymentItem.Pending is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20PaymentItem.Pending");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Payments.PaymentItem", "bool PaymentItem.Pending");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string Label
		{
			get
			{
				throw new global::System.NotImplementedException("The member string PaymentItem.Label is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20PaymentItem.Label");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Payments.PaymentItem", "string PaymentItem.Label");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Payments.PaymentCurrencyAmount Amount
		{
			get
			{
				throw new global::System.NotImplementedException("The member PaymentCurrencyAmount PaymentItem.Amount is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PaymentCurrencyAmount%20PaymentItem.Amount");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Payments.PaymentItem", "PaymentCurrencyAmount PaymentItem.Amount");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public PaymentItem( string label,  global::Windows.ApplicationModel.Payments.PaymentCurrencyAmount amount) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Payments.PaymentItem", "PaymentItem.PaymentItem(string label, PaymentCurrencyAmount amount)");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentItem.PaymentItem(string, Windows.ApplicationModel.Payments.PaymentCurrencyAmount)
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentItem.Label.get
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentItem.Label.set
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentItem.Amount.get
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentItem.Amount.set
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentItem.Pending.get
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentItem.Pending.set
	}
}
