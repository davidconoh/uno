#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	[global::Windows.UI.Xaml.Markup.ContentPropertyAttribute(Name = "Items")]
#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
#endif
	public partial class MenuBarItem : global::Windows.UI.Xaml.Controls.Control
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string Title
		{
			get
			{
				return (string)this.GetValue(TitleProperty);
			}
			set
			{
				this.SetValue(TitleProperty, value);
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.MenuFlyoutItemBase> Items
		{
			get
			{
				return (global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.MenuFlyoutItemBase>)this.GetValue(ItemsProperty);
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ItemsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Items), typeof(global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.MenuFlyoutItemBase>), 
			typeof(global::Windows.UI.Xaml.Controls.MenuBarItem), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.MenuFlyoutItemBase>)));
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty TitleProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Title), typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.MenuBarItem), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(string)));
#endif
		// Skipping already declared method Windows.UI.Xaml.Controls.MenuBarItem.MenuBarItem()
		// Forced skipping of method Windows.UI.Xaml.Controls.MenuBarItem.MenuBarItem()
		// Forced skipping of method Windows.UI.Xaml.Controls.MenuBarItem.Title.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MenuBarItem.Title.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MenuBarItem.Items.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MenuBarItem.TitleProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MenuBarItem.ItemsProperty.get
	}
}
