#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Activation
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class ContactPanelActivatedEventArgs : global::Windows.ApplicationModel.Activation.IContactPanelActivatedEventArgs,global::Windows.ApplicationModel.Activation.IActivatedEventArgs,global::Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Activation.ActivationKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivationKind ContactPanelActivatedEventArgs.Kind is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ActivationKind%20ContactPanelActivatedEventArgs.Kind");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Activation.ApplicationExecutionState PreviousExecutionState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationExecutionState ContactPanelActivatedEventArgs.PreviousExecutionState is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ApplicationExecutionState%20ContactPanelActivatedEventArgs.PreviousExecutionState");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Activation.SplashScreen SplashScreen
		{
			get
			{
				throw new global::System.NotImplementedException("The member SplashScreen ContactPanelActivatedEventArgs.SplashScreen is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SplashScreen%20ContactPanelActivatedEventArgs.SplashScreen");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User ContactPanelActivatedEventArgs.User is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=User%20ContactPanelActivatedEventArgs.User");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Contacts.Contact Contact
		{
			get
			{
				throw new global::System.NotImplementedException("The member Contact ContactPanelActivatedEventArgs.Contact is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Contact%20ContactPanelActivatedEventArgs.Contact");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Contacts.ContactPanel ContactPanel
		{
			get
			{
				throw new global::System.NotImplementedException("The member ContactPanel ContactPanelActivatedEventArgs.ContactPanel is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ContactPanel%20ContactPanelActivatedEventArgs.ContactPanel");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Activation.ContactPanelActivatedEventArgs.ContactPanel.get
		// Forced skipping of method Windows.ApplicationModel.Activation.ContactPanelActivatedEventArgs.Contact.get
		// Forced skipping of method Windows.ApplicationModel.Activation.ContactPanelActivatedEventArgs.Kind.get
		// Forced skipping of method Windows.ApplicationModel.Activation.ContactPanelActivatedEventArgs.PreviousExecutionState.get
		// Forced skipping of method Windows.ApplicationModel.Activation.ContactPanelActivatedEventArgs.SplashScreen.get
		// Forced skipping of method Windows.ApplicationModel.Activation.ContactPanelActivatedEventArgs.User.get
		// Processing: Windows.ApplicationModel.Activation.IContactPanelActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
	}
}
