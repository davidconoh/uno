#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.CustomAttributes
{
	[global::System.AttributeUsageAttribute(global::System.AttributeTargets.Delegate | global::System.AttributeTargets.Interface | global::System.AttributeTargets.Property | global::System.AttributeTargets.Method | global::System.AttributeTargets.Enum | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class MUXPropertyChangedCallbackMethodNameAttribute : global::System.Attribute
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public MUXPropertyChangedCallbackMethodNameAttribute() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.CustomAttributes.MUXPropertyChangedCallbackMethodNameAttribute", "MUXPropertyChangedCallbackMethodNameAttribute.MUXPropertyChangedCallbackMethodNameAttribute()");
		}
#endif
		// Forced skipping of method Microsoft.UI.Xaml.CustomAttributes.MUXPropertyChangedCallbackMethodNameAttribute.MUXPropertyChangedCallbackMethodNameAttribute()
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		public string value;
#endif
	}
}
