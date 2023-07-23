#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input.Inking
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class InkRecognizerContainer : global::Windows.UI.Input.Inking.IInkRecognizerContainer
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public InkRecognizerContainer() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Input.Inking.InkRecognizerContainer", "InkRecognizerContainer.InkRecognizerContainer()");
		}
#endif
		// Forced skipping of method Windows.UI.Input.Inking.InkRecognizerContainer.InkRecognizerContainer()
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void SetDefaultRecognizer( global::Windows.UI.Input.Inking.InkRecognizer recognizer)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Input.Inking.InkRecognizerContainer", "void InkRecognizerContainer.SetDefaultRecognizer(InkRecognizer recognizer)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Input.Inking.InkRecognitionResult>> RecognizeAsync( global::Windows.UI.Input.Inking.InkStrokeContainer strokeCollection,  global::Windows.UI.Input.Inking.InkRecognitionTarget recognitionTarget)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<InkRecognitionResult>> InkRecognizerContainer.RecognizeAsync(InkStrokeContainer strokeCollection, InkRecognitionTarget recognitionTarget) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncOperation%3CIReadOnlyList%3CInkRecognitionResult%3E%3E%20InkRecognizerContainer.RecognizeAsync%28InkStrokeContainer%20strokeCollection%2C%20InkRecognitionTarget%20recognitionTarget%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Input.Inking.InkRecognizer> GetRecognizers()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<InkRecognizer> InkRecognizerContainer.GetRecognizers() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CInkRecognizer%3E%20InkRecognizerContainer.GetRecognizers%28%29");
		}
#endif
		// Processing: Windows.UI.Input.Inking.IInkRecognizerContainer
	}
}
