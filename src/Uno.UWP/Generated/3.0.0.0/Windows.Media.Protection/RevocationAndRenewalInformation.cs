#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Protection
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class RevocationAndRenewalInformation 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IList<global::Windows.Media.Protection.RevocationAndRenewalItem> Items
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<RevocationAndRenewalItem> RevocationAndRenewalInformation.Items is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IList%3CRevocationAndRenewalItem%3E%20RevocationAndRenewalInformation.Items");
			}
		}
#endif
		// Forced skipping of method Windows.Media.Protection.RevocationAndRenewalInformation.Items.get
	}
}
