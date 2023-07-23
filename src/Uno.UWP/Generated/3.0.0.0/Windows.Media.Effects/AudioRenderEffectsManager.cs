#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Effects
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class AudioRenderEffectsManager 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string EffectsProviderSettingsLabel
		{
			get
			{
				throw new global::System.NotImplementedException("The member string AudioRenderEffectsManager.EffectsProviderSettingsLabel is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20AudioRenderEffectsManager.EffectsProviderSettingsLabel");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Storage.Streams.IRandomAccessStreamWithContentType EffectsProviderThumbnail
		{
			get
			{
				throw new global::System.NotImplementedException("The member IRandomAccessStreamWithContentType AudioRenderEffectsManager.EffectsProviderThumbnail is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IRandomAccessStreamWithContentType%20AudioRenderEffectsManager.EffectsProviderThumbnail");
			}
		}
#endif
		// Forced skipping of method Windows.Media.Effects.AudioRenderEffectsManager.AudioRenderEffectsChanged.add
		// Forced skipping of method Windows.Media.Effects.AudioRenderEffectsManager.AudioRenderEffectsChanged.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<global::Windows.Media.Effects.AudioEffect> GetAudioRenderEffects()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<AudioEffect> AudioRenderEffectsManager.GetAudioRenderEffects() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CAudioEffect%3E%20AudioRenderEffectsManager.GetAudioRenderEffects%28%29");
		}
#endif
		// Forced skipping of method Windows.Media.Effects.AudioRenderEffectsManager.EffectsProviderThumbnail.get
		// Forced skipping of method Windows.Media.Effects.AudioRenderEffectsManager.EffectsProviderSettingsLabel.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void ShowSettingsUI()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Effects.AudioRenderEffectsManager", "void AudioRenderEffectsManager.ShowSettingsUI()");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Media.Effects.AudioRenderEffectsManager, object> AudioRenderEffectsChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Effects.AudioRenderEffectsManager", "event TypedEventHandler<AudioRenderEffectsManager, object> AudioRenderEffectsManager.AudioRenderEffectsChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Effects.AudioRenderEffectsManager", "event TypedEventHandler<AudioRenderEffectsManager, object> AudioRenderEffectsManager.AudioRenderEffectsChanged");
			}
		}
#endif
	}
}
