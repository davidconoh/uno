#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Services.Store
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class StoreSubscriptionInfo 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint BillingPeriod
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint StoreSubscriptionInfo.BillingPeriod is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20StoreSubscriptionInfo.BillingPeriod");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Services.Store.StoreDurationUnit BillingPeriodUnit
		{
			get
			{
				throw new global::System.NotImplementedException("The member StoreDurationUnit StoreSubscriptionInfo.BillingPeriodUnit is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StoreDurationUnit%20StoreSubscriptionInfo.BillingPeriodUnit");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool HasTrialPeriod
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool StoreSubscriptionInfo.HasTrialPeriod is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20StoreSubscriptionInfo.HasTrialPeriod");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint TrialPeriod
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint StoreSubscriptionInfo.TrialPeriod is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20StoreSubscriptionInfo.TrialPeriod");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Services.Store.StoreDurationUnit TrialPeriodUnit
		{
			get
			{
				throw new global::System.NotImplementedException("The member StoreDurationUnit StoreSubscriptionInfo.TrialPeriodUnit is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StoreDurationUnit%20StoreSubscriptionInfo.TrialPeriodUnit");
			}
		}
#endif
		// Forced skipping of method Windows.Services.Store.StoreSubscriptionInfo.BillingPeriod.get
		// Forced skipping of method Windows.Services.Store.StoreSubscriptionInfo.BillingPeriodUnit.get
		// Forced skipping of method Windows.Services.Store.StoreSubscriptionInfo.HasTrialPeriod.get
		// Forced skipping of method Windows.Services.Store.StoreSubscriptionInfo.TrialPeriod.get
		// Forced skipping of method Windows.Services.Store.StoreSubscriptionInfo.TrialPeriodUnit.get
	}
}
