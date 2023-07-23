#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Activation
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class VoiceCommandActivatedEventArgs : global::Windows.ApplicationModel.Activation.IVoiceCommandActivatedEventArgs,global::Windows.ApplicationModel.Activation.IActivatedEventArgs,global::Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Activation.ActivationKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivationKind VoiceCommandActivatedEventArgs.Kind is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ActivationKind%20VoiceCommandActivatedEventArgs.Kind");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Activation.ApplicationExecutionState PreviousExecutionState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationExecutionState VoiceCommandActivatedEventArgs.PreviousExecutionState is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ApplicationExecutionState%20VoiceCommandActivatedEventArgs.PreviousExecutionState");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Activation.SplashScreen SplashScreen
		{
			get
			{
				throw new global::System.NotImplementedException("The member SplashScreen VoiceCommandActivatedEventArgs.SplashScreen is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SplashScreen%20VoiceCommandActivatedEventArgs.SplashScreen");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User VoiceCommandActivatedEventArgs.User is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=User%20VoiceCommandActivatedEventArgs.User");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.SpeechRecognition.SpeechRecognitionResult Result
		{
			get
			{
				throw new global::System.NotImplementedException("The member SpeechRecognitionResult VoiceCommandActivatedEventArgs.Result is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SpeechRecognitionResult%20VoiceCommandActivatedEventArgs.Result");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Activation.VoiceCommandActivatedEventArgs.Result.get
		// Forced skipping of method Windows.ApplicationModel.Activation.VoiceCommandActivatedEventArgs.Kind.get
		// Forced skipping of method Windows.ApplicationModel.Activation.VoiceCommandActivatedEventArgs.PreviousExecutionState.get
		// Forced skipping of method Windows.ApplicationModel.Activation.VoiceCommandActivatedEventArgs.SplashScreen.get
		// Forced skipping of method Windows.ApplicationModel.Activation.VoiceCommandActivatedEventArgs.User.get
		// Processing: Windows.ApplicationModel.Activation.IVoiceCommandActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
	}
}
