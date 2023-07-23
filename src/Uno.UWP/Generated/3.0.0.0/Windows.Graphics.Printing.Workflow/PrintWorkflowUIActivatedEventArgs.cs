#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Printing.Workflow
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class PrintWorkflowUIActivatedEventArgs : global::Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser,global::Windows.ApplicationModel.Activation.IActivatedEventArgs
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Activation.ActivationKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivationKind PrintWorkflowUIActivatedEventArgs.Kind is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ActivationKind%20PrintWorkflowUIActivatedEventArgs.Kind");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Activation.ApplicationExecutionState PreviousExecutionState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationExecutionState PrintWorkflowUIActivatedEventArgs.PreviousExecutionState is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ApplicationExecutionState%20PrintWorkflowUIActivatedEventArgs.PreviousExecutionState");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Activation.SplashScreen SplashScreen
		{
			get
			{
				throw new global::System.NotImplementedException("The member SplashScreen PrintWorkflowUIActivatedEventArgs.SplashScreen is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SplashScreen%20PrintWorkflowUIActivatedEventArgs.SplashScreen");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User PrintWorkflowUIActivatedEventArgs.User is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=User%20PrintWorkflowUIActivatedEventArgs.User");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Graphics.Printing.Workflow.PrintWorkflowForegroundSession PrintWorkflowSession
		{
			get
			{
				throw new global::System.NotImplementedException("The member PrintWorkflowForegroundSession PrintWorkflowUIActivatedEventArgs.PrintWorkflowSession is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PrintWorkflowForegroundSession%20PrintWorkflowUIActivatedEventArgs.PrintWorkflowSession");
			}
		}
#endif
		// Forced skipping of method Windows.Graphics.Printing.Workflow.PrintWorkflowUIActivatedEventArgs.PrintWorkflowSession.get
		// Forced skipping of method Windows.Graphics.Printing.Workflow.PrintWorkflowUIActivatedEventArgs.Kind.get
		// Forced skipping of method Windows.Graphics.Printing.Workflow.PrintWorkflowUIActivatedEventArgs.PreviousExecutionState.get
		// Forced skipping of method Windows.Graphics.Printing.Workflow.PrintWorkflowUIActivatedEventArgs.SplashScreen.get
		// Forced skipping of method Windows.Graphics.Printing.Workflow.PrintWorkflowUIActivatedEventArgs.User.get
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgs
	}
}
