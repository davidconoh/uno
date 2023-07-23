#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Background
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class CustomSystemEventTrigger : global::Windows.ApplicationModel.Background.IBackgroundTrigger
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Background.CustomSystemEventTriggerRecurrence Recurrence
		{
			get
			{
				throw new global::System.NotImplementedException("The member CustomSystemEventTriggerRecurrence CustomSystemEventTrigger.Recurrence is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CustomSystemEventTriggerRecurrence%20CustomSystemEventTrigger.Recurrence");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string TriggerId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CustomSystemEventTrigger.TriggerId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20CustomSystemEventTrigger.TriggerId");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public CustomSystemEventTrigger( string triggerId,  global::Windows.ApplicationModel.Background.CustomSystemEventTriggerRecurrence recurrence) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.CustomSystemEventTrigger", "CustomSystemEventTrigger.CustomSystemEventTrigger(string triggerId, CustomSystemEventTriggerRecurrence recurrence)");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Background.CustomSystemEventTrigger.CustomSystemEventTrigger(string, Windows.ApplicationModel.Background.CustomSystemEventTriggerRecurrence)
		// Forced skipping of method Windows.ApplicationModel.Background.CustomSystemEventTrigger.TriggerId.get
		// Forced skipping of method Windows.ApplicationModel.Background.CustomSystemEventTrigger.Recurrence.get
		// Processing: Windows.ApplicationModel.Background.IBackgroundTrigger
	}
}
