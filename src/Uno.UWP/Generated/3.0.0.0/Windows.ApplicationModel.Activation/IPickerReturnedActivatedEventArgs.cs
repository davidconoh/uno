#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Activation
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial interface IPickerReturnedActivatedEventArgs : global::Windows.ApplicationModel.Activation.IActivatedEventArgs
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		string PickerOperationId
		{
			get;
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Activation.IPickerReturnedActivatedEventArgs.PickerOperationId.get
	}
}
