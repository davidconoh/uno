#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Capture
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class AdvancedPhotoCapture 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Media.Capture.AdvancedCapturedPhoto> CaptureAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<AdvancedCapturedPhoto> AdvancedPhotoCapture.CaptureAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CAdvancedCapturedPhoto%3E%20AdvancedPhotoCapture.CaptureAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::Windows.Media.Capture.AdvancedCapturedPhoto> CaptureAsync( object context)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<AdvancedCapturedPhoto> AdvancedPhotoCapture.CaptureAsync(object context) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CAdvancedCapturedPhoto%3E%20AdvancedPhotoCapture.CaptureAsync%28object%20context%29");
		}
#endif
		// Forced skipping of method Windows.Media.Capture.AdvancedPhotoCapture.OptionalReferencePhotoCaptured.add
		// Forced skipping of method Windows.Media.Capture.AdvancedPhotoCapture.OptionalReferencePhotoCaptured.remove
		// Forced skipping of method Windows.Media.Capture.AdvancedPhotoCapture.AllPhotosCaptured.add
		// Forced skipping of method Windows.Media.Capture.AdvancedPhotoCapture.AllPhotosCaptured.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction FinishAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction AdvancedPhotoCapture.FinishAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20AdvancedPhotoCapture.FinishAsync%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Media.Capture.AdvancedPhotoCapture, object> AllPhotosCaptured
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Capture.AdvancedPhotoCapture", "event TypedEventHandler<AdvancedPhotoCapture, object> AdvancedPhotoCapture.AllPhotosCaptured");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Capture.AdvancedPhotoCapture", "event TypedEventHandler<AdvancedPhotoCapture, object> AdvancedPhotoCapture.AllPhotosCaptured");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Media.Capture.AdvancedPhotoCapture, global::Windows.Media.Capture.OptionalReferencePhotoCapturedEventArgs> OptionalReferencePhotoCaptured
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Capture.AdvancedPhotoCapture", "event TypedEventHandler<AdvancedPhotoCapture, OptionalReferencePhotoCapturedEventArgs> AdvancedPhotoCapture.OptionalReferencePhotoCaptured");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Capture.AdvancedPhotoCapture", "event TypedEventHandler<AdvancedPhotoCapture, OptionalReferencePhotoCapturedEventArgs> AdvancedPhotoCapture.OptionalReferencePhotoCaptured");
			}
		}
#endif
	}
}
