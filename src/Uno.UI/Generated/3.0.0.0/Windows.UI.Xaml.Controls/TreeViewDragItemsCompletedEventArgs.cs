#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class TreeViewDragItemsCompletedEventArgs 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.DataTransfer.DataPackageOperation DropResult
		{
			get
			{
				throw new global::System.NotImplementedException("The member DataPackageOperation TreeViewDragItemsCompletedEventArgs.DropResult is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DataPackageOperation%20TreeViewDragItemsCompletedEventArgs.DropResult");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<object> Items
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<object> TreeViewDragItemsCompletedEventArgs.Items is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3Cobject%3E%20TreeViewDragItemsCompletedEventArgs.Items");
			}
		}
#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewDragItemsCompletedEventArgs.DropResult.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewDragItemsCompletedEventArgs.Items.get
	}
}
