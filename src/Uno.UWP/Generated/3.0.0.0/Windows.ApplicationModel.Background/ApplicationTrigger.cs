#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Background
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class ApplicationTrigger : global::Windows.ApplicationModel.Background.IBackgroundTrigger
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ApplicationTrigger() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.ApplicationTrigger", "ApplicationTrigger.ApplicationTrigger()");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Background.ApplicationTrigger.ApplicationTrigger()
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Background.ApplicationTriggerResult> RequestAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ApplicationTriggerResult> ApplicationTrigger.RequestAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CApplicationTriggerResult%3E%20ApplicationTrigger.RequestAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Background.ApplicationTriggerResult> RequestAsync( global::Windows.Foundation.Collections.ValueSet arguments)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ApplicationTriggerResult> ApplicationTrigger.RequestAsync(ValueSet arguments) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CApplicationTriggerResult%3E%20ApplicationTrigger.RequestAsync%28ValueSet%20arguments%29");
		}
#endif
		// Processing: Windows.ApplicationModel.Background.IBackgroundTrigger
	}
}
