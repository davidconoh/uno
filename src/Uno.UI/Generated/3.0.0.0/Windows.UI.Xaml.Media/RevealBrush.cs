#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media
{
#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
#endif
	public partial class RevealBrush : global::Windows.UI.Xaml.Media.XamlCompositionBrushBase
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.UI.Xaml.ApplicationTheme TargetTheme
		{
			get
			{
				return (global::Windows.UI.Xaml.ApplicationTheme)this.GetValue(TargetThemeProperty);
			}
			set
			{
				this.SetValue(TargetThemeProperty, value);
			}
		}
#endif
		// Skipping already declared property Color
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool AlwaysUseFallback
		{
			get
			{
				return (bool)this.GetValue(AlwaysUseFallbackProperty);
			}
			set
			{
				this.SetValue(AlwaysUseFallbackProperty, value);
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty AlwaysUseFallbackProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(AlwaysUseFallback), typeof(bool), 
			typeof(global::Windows.UI.Xaml.Media.RevealBrush), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
#endif
		// Skipping already declared property ColorProperty
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty StateProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.RegisterAttached(
			"State", typeof(global::Windows.UI.Xaml.Media.RevealBrushState), 
			typeof(global::Windows.UI.Xaml.Media.RevealBrush), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.RevealBrushState)));
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty TargetThemeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(TargetTheme), typeof(global::Windows.UI.Xaml.ApplicationTheme), 
			typeof(global::Windows.UI.Xaml.Media.RevealBrush), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.ApplicationTheme)));
#endif
		// Skipping already declared method Windows.UI.Xaml.Media.RevealBrush.RevealBrush()
		// Forced skipping of method Windows.UI.Xaml.Media.RevealBrush.RevealBrush()
		// Forced skipping of method Windows.UI.Xaml.Media.RevealBrush.Color.get
		// Forced skipping of method Windows.UI.Xaml.Media.RevealBrush.Color.set
		// Forced skipping of method Windows.UI.Xaml.Media.RevealBrush.TargetTheme.get
		// Forced skipping of method Windows.UI.Xaml.Media.RevealBrush.TargetTheme.set
		// Forced skipping of method Windows.UI.Xaml.Media.RevealBrush.AlwaysUseFallback.get
		// Forced skipping of method Windows.UI.Xaml.Media.RevealBrush.AlwaysUseFallback.set
		// Forced skipping of method Windows.UI.Xaml.Media.RevealBrush.ColorProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.RevealBrush.TargetThemeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.RevealBrush.AlwaysUseFallbackProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.RevealBrush.StateProperty.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void SetState( global::Windows.UI.Xaml.UIElement element,  global::Windows.UI.Xaml.Media.RevealBrushState value)
		{
			element.SetValue(StateProperty, value);
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.Media.RevealBrushState GetState( global::Windows.UI.Xaml.UIElement element)
		{
			return (global::Windows.UI.Xaml.Media.RevealBrushState)element.GetValue(StateProperty);
		}
#endif
	}
}
