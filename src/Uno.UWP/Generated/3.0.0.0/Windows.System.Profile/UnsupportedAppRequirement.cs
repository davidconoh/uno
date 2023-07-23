#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.Profile
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class UnsupportedAppRequirement 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.System.Profile.UnsupportedAppRequirementReasons Reasons
		{
			get
			{
				throw new global::System.NotImplementedException("The member UnsupportedAppRequirementReasons UnsupportedAppRequirement.Reasons is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=UnsupportedAppRequirementReasons%20UnsupportedAppRequirement.Reasons");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string Requirement
		{
			get
			{
				throw new global::System.NotImplementedException("The member string UnsupportedAppRequirement.Requirement is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20UnsupportedAppRequirement.Requirement");
			}
		}
#endif
		// Forced skipping of method Windows.System.Profile.UnsupportedAppRequirement.Requirement.get
		// Forced skipping of method Windows.System.Profile.UnsupportedAppRequirement.Reasons.get
	}
}
