#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Resources.Core
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class ResourceManager 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyDictionary<string, global::Windows.ApplicationModel.Resources.Core.ResourceMap> AllResourceMaps
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyDictionary<string, ResourceMap> ResourceManager.AllResourceMaps is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyDictionary%3Cstring%2C%20ResourceMap%3E%20ResourceManager.AllResourceMaps");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Resources.Core.ResourceContext DefaultContext
		{
			get
			{
				throw new global::System.NotImplementedException("The member ResourceContext ResourceManager.DefaultContext is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ResourceContext%20ResourceManager.DefaultContext");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.ApplicationModel.Resources.Core.ResourceMap MainResourceMap
		{
			get
			{
				throw new global::System.NotImplementedException("The member ResourceMap ResourceManager.MainResourceMap is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ResourceMap%20ResourceManager.MainResourceMap");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.ApplicationModel.Resources.Core.ResourceManager Current
		{
			get
			{
				throw new global::System.NotImplementedException("The member ResourceManager ResourceManager.Current is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=ResourceManager%20ResourceManager.Current");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Resources.Core.ResourceManager.MainResourceMap.get
		// Forced skipping of method Windows.ApplicationModel.Resources.Core.ResourceManager.AllResourceMaps.get
		// Forced skipping of method Windows.ApplicationModel.Resources.Core.ResourceManager.DefaultContext.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void LoadPriFiles( global::System.Collections.Generic.IEnumerable<global::Windows.Storage.IStorageFile> files)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Resources.Core.ResourceManager", "void ResourceManager.LoadPriFiles(IEnumerable<IStorageFile> files)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void UnloadPriFiles( global::System.Collections.Generic.IEnumerable<global::Windows.Storage.IStorageFile> files)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Resources.Core.ResourceManager", "void ResourceManager.UnloadPriFiles(IEnumerable<IStorageFile> files)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Resources.Core.NamedResource> GetAllNamedResourcesForPackage( string packageName,  global::Windows.ApplicationModel.Resources.Core.ResourceLayoutInfo resourceLayoutInfo)
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<NamedResource> ResourceManager.GetAllNamedResourcesForPackage(string packageName, ResourceLayoutInfo resourceLayoutInfo) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CNamedResource%3E%20ResourceManager.GetAllNamedResourcesForPackage%28string%20packageName%2C%20ResourceLayoutInfo%20resourceLayoutInfo%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Resources.Core.ResourceMap> GetAllSubtreesForPackage( string packageName,  global::Windows.ApplicationModel.Resources.Core.ResourceLayoutInfo resourceLayoutInfo)
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<ResourceMap> ResourceManager.GetAllSubtreesForPackage(string packageName, ResourceLayoutInfo resourceLayoutInfo) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CResourceMap%3E%20ResourceManager.GetAllSubtreesForPackage%28string%20packageName%2C%20ResourceLayoutInfo%20resourceLayoutInfo%29");
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.Resources.Core.ResourceManager.Current.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool IsResourceReference( string resourceReference)
		{
			throw new global::System.NotImplementedException("The member bool ResourceManager.IsResourceReference(string resourceReference) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20ResourceManager.IsResourceReference%28string%20resourceReference%29");
		}
#endif
	}
}
