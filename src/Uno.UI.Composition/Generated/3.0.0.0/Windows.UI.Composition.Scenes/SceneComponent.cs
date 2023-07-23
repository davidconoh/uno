#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition.Scenes
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class SceneComponent : global::Windows.UI.Composition.Scenes.SceneObject
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.UI.Composition.Scenes.SceneComponentType ComponentType
		{
			get
			{
				throw new global::System.NotImplementedException("The member SceneComponentType SceneComponent.ComponentType is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SceneComponentType%20SceneComponent.ComponentType");
			}
		}
#endif
		// Forced skipping of method Windows.UI.Composition.Scenes.SceneComponent.ComponentType.get
	}
}
