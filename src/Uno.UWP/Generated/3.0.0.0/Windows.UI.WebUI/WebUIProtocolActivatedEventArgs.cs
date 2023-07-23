#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.WebUI
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class WebUIProtocolActivatedEventArgs : global::Windows.ApplicationModel.Activation.IProtocolActivatedEventArgs,global::Windows.ApplicationModel.Activation.IActivatedEventArgs,global::Windows.ApplicationModel.Activation.IProtocolActivatedEventArgsWithCallerPackageFamilyNameAndData,global::Windows.ApplicationModel.Activation.IApplicationViewActivatedEventArgs,global::Windows.UI.WebUI.IActivatedEventArgsDeferral,global::Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Activation.ActivationKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivationKind WebUIProtocolActivatedEventArgs.Kind is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ActivationKind%20WebUIProtocolActivatedEventArgs.Kind");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Activation.ApplicationExecutionState PreviousExecutionState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationExecutionState WebUIProtocolActivatedEventArgs.PreviousExecutionState is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ApplicationExecutionState%20WebUIProtocolActivatedEventArgs.PreviousExecutionState");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Activation.SplashScreen SplashScreen
		{
			get
			{
				throw new global::System.NotImplementedException("The member SplashScreen WebUIProtocolActivatedEventArgs.SplashScreen is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SplashScreen%20WebUIProtocolActivatedEventArgs.SplashScreen");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User WebUIProtocolActivatedEventArgs.User is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=User%20WebUIProtocolActivatedEventArgs.User");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public int CurrentlyShownApplicationViewId
		{
			get
			{
				throw new global::System.NotImplementedException("The member int WebUIProtocolActivatedEventArgs.CurrentlyShownApplicationViewId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=int%20WebUIProtocolActivatedEventArgs.CurrentlyShownApplicationViewId");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Uri Uri
		{
			get
			{
				throw new global::System.NotImplementedException("The member Uri WebUIProtocolActivatedEventArgs.Uri is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Uri%20WebUIProtocolActivatedEventArgs.Uri");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string CallerPackageFamilyName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string WebUIProtocolActivatedEventArgs.CallerPackageFamilyName is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20WebUIProtocolActivatedEventArgs.CallerPackageFamilyName");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.Collections.ValueSet Data
		{
			get
			{
				throw new global::System.NotImplementedException("The member ValueSet WebUIProtocolActivatedEventArgs.Data is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ValueSet%20WebUIProtocolActivatedEventArgs.Data");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.UI.WebUI.ActivatedOperation ActivatedOperation
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivatedOperation WebUIProtocolActivatedEventArgs.ActivatedOperation is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ActivatedOperation%20WebUIProtocolActivatedEventArgs.ActivatedOperation");
			}
		}
#endif
		// Forced skipping of method Windows.UI.WebUI.WebUIProtocolActivatedEventArgs.Uri.get
		// Forced skipping of method Windows.UI.WebUI.WebUIProtocolActivatedEventArgs.Kind.get
		// Forced skipping of method Windows.UI.WebUI.WebUIProtocolActivatedEventArgs.PreviousExecutionState.get
		// Forced skipping of method Windows.UI.WebUI.WebUIProtocolActivatedEventArgs.SplashScreen.get
		// Forced skipping of method Windows.UI.WebUI.WebUIProtocolActivatedEventArgs.CallerPackageFamilyName.get
		// Forced skipping of method Windows.UI.WebUI.WebUIProtocolActivatedEventArgs.Data.get
		// Forced skipping of method Windows.UI.WebUI.WebUIProtocolActivatedEventArgs.CurrentlyShownApplicationViewId.get
		// Forced skipping of method Windows.UI.WebUI.WebUIProtocolActivatedEventArgs.ActivatedOperation.get
		// Forced skipping of method Windows.UI.WebUI.WebUIProtocolActivatedEventArgs.User.get
		// Processing: Windows.ApplicationModel.Activation.IProtocolActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IProtocolActivatedEventArgsWithCallerPackageFamilyNameAndData
		// Processing: Windows.ApplicationModel.Activation.IApplicationViewActivatedEventArgs
		// Processing: Windows.UI.WebUI.IActivatedEventArgsDeferral
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
	}
}
