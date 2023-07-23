#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Playback
{
#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
#endif
	public partial class MediaPlayer : global::System.IDisposable
	{
		// Skipping already declared property Volume
		// Skipping already declared property Position
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public double PlaybackRate
		{
			get
			{
				throw new global::System.NotImplementedException("The member double MediaPlayer.PlaybackRate is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=double%20MediaPlayer.PlaybackRate");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "double MediaPlayer.PlaybackRate");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public bool IsLoopingEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool MediaPlayer.IsLoopingEnabled is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20MediaPlayer.IsLoopingEnabled");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "bool MediaPlayer.IsLoopingEnabled");
			}
		}
#endif
		// Skipping already declared property IsMuted
		// Skipping already declared property AutoPlay
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public global::Windows.Media.Playback.MediaPlayerState CurrentState
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaPlayerState MediaPlayer.CurrentState is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MediaPlayerState%20MediaPlayer.CurrentState");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public global::System.TimeSpan NaturalDuration
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan MediaPlayer.NaturalDuration is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=TimeSpan%20MediaPlayer.NaturalDuration");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.Playback.PlaybackMediaMarkerSequence PlaybackMediaMarkers
		{
			get
			{
				throw new global::System.NotImplementedException("The member PlaybackMediaMarkerSequence MediaPlayer.PlaybackMediaMarkers is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PlaybackMediaMarkerSequence%20MediaPlayer.PlaybackMediaMarkers");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public bool IsProtected
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool MediaPlayer.IsProtected is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20MediaPlayer.IsProtected");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public double BufferingProgress
		{
			get
			{
				throw new global::System.NotImplementedException("The member double MediaPlayer.BufferingProgress is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=double%20MediaPlayer.BufferingProgress");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public bool CanPause
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool MediaPlayer.CanPause is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20MediaPlayer.CanPause");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public bool CanSeek
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool MediaPlayer.CanSeek is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20MediaPlayer.CanSeek");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public global::Windows.Media.Playback.MediaPlayerAudioDeviceType AudioDeviceType
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaPlayerAudioDeviceType MediaPlayer.AudioDeviceType is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MediaPlayerAudioDeviceType%20MediaPlayer.AudioDeviceType");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "MediaPlayerAudioDeviceType MediaPlayer.AudioDeviceType");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public global::Windows.Media.Playback.MediaPlayerAudioCategory AudioCategory
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaPlayerAudioCategory MediaPlayer.AudioCategory is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MediaPlayerAudioCategory%20MediaPlayer.AudioCategory");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "MediaPlayerAudioCategory MediaPlayer.AudioCategory");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.SystemMediaTransportControls SystemMediaTransportControls
		{
			get
			{
				throw new global::System.NotImplementedException("The member SystemMediaTransportControls MediaPlayer.SystemMediaTransportControls is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=SystemMediaTransportControls%20MediaPlayer.SystemMediaTransportControls");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public global::System.TimeSpan TimelineControllerPositionOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan MediaPlayer.TimelineControllerPositionOffset is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=TimeSpan%20MediaPlayer.TimelineControllerPositionOffset");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "TimeSpan MediaPlayer.TimelineControllerPositionOffset");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.MediaTimelineController TimelineController
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaTimelineController MediaPlayer.TimelineController is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MediaTimelineController%20MediaPlayer.TimelineController");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "MediaTimelineController MediaPlayer.TimelineController");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.Playback.StereoscopicVideoRenderMode StereoscopicVideoRenderMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member StereoscopicVideoRenderMode MediaPlayer.StereoscopicVideoRenderMode is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=StereoscopicVideoRenderMode%20MediaPlayer.StereoscopicVideoRenderMode");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "StereoscopicVideoRenderMode MediaPlayer.StereoscopicVideoRenderMode");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public bool RealTimePlayback
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool MediaPlayer.RealTimePlayback is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20MediaPlayer.RealTimePlayback");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "bool MediaPlayer.RealTimePlayback");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Devices.Enumeration.DeviceInformation AudioDevice
		{
			get
			{
				throw new global::System.NotImplementedException("The member DeviceInformation MediaPlayer.AudioDevice is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=DeviceInformation%20MediaPlayer.AudioDevice");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "DeviceInformation MediaPlayer.AudioDevice");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public double AudioBalance
		{
			get
			{
				throw new global::System.NotImplementedException("The member double MediaPlayer.AudioBalance is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=double%20MediaPlayer.AudioBalance");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "double MediaPlayer.AudioBalance");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.Playback.MediaPlaybackCommandManager CommandManager
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaPlaybackCommandManager MediaPlayer.CommandManager is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MediaPlaybackCommandManager%20MediaPlayer.CommandManager");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.Playback.MediaBreakManager BreakManager
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaBreakManager MediaPlayer.BreakManager is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MediaBreakManager%20MediaPlayer.BreakManager");
			}
		}
#endif
		// Skipping already declared property PlaybackSession
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool IsVideoFrameServerEnabled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool MediaPlayer.IsVideoFrameServerEnabled is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20MediaPlayer.IsVideoFrameServerEnabled");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "bool MediaPlayer.IsVideoFrameServerEnabled");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.Audio.AudioStateMonitor AudioStateMonitor
		{
			get
			{
				throw new global::System.NotImplementedException("The member AudioStateMonitor MediaPlayer.AudioStateMonitor is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=AudioStateMonitor%20MediaPlayer.AudioStateMonitor");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.Protection.MediaProtectionManager ProtectionManager
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaProtectionManager MediaPlayer.ProtectionManager is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=MediaProtectionManager%20MediaPlayer.ProtectionManager");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "MediaProtectionManager MediaPlayer.ProtectionManager");
			}
		}
#endif
		// Skipping already declared property Source
		// Skipping already declared method Windows.Media.Playback.MediaPlayer.MediaPlayer()
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.MediaPlayer()
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.AutoPlay.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.AutoPlay.set
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.NaturalDuration.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.Position.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.Position.set
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.BufferingProgress.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.CurrentState.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.CanSeek.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.CanPause.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.IsLoopingEnabled.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.IsLoopingEnabled.set
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.IsProtected.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.IsMuted.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.IsMuted.set
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.PlaybackRate.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.PlaybackRate.set
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.Volume.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.Volume.set
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.PlaybackMediaMarkers.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.MediaOpened.add
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.MediaOpened.remove
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.MediaEnded.add
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.MediaEnded.remove
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.MediaFailed.add
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.MediaFailed.remove
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.CurrentStateChanged.add
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.CurrentStateChanged.remove
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.PlaybackMediaMarkerReached.add
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.PlaybackMediaMarkerReached.remove
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.MediaPlayerRateChanged.add
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.MediaPlayerRateChanged.remove
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.VolumeChanged.add
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.VolumeChanged.remove
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.SeekCompleted.add
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.SeekCompleted.remove
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.BufferingStarted.add
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.BufferingStarted.remove
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.BufferingEnded.add
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.BufferingEnded.remove
		// Skipping already declared method Windows.Media.Playback.MediaPlayer.Play()
		// Skipping already declared method Windows.Media.Playback.MediaPlayer.Pause()
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public void SetUriSource( global::System.Uri value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "void MediaPlayer.SetUriSource(Uri value)");
		}
#endif
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.ProtectionManager.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.ProtectionManager.set
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public void SetFileSource( global::Windows.Storage.IStorageFile file)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "void MediaPlayer.SetFileSource(IStorageFile file)");
		}
#endif
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public void SetStreamSource( global::Windows.Storage.Streams.IRandomAccessStream stream)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "void MediaPlayer.SetStreamSource(IRandomAccessStream stream)");
		}
#endif
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public void SetMediaSource( global::Windows.Media.Core.IMediaSource source)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "void MediaPlayer.SetMediaSource(IMediaSource source)");
		}
#endif
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.Source.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.Source.set
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.SystemMediaTransportControls.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.AudioCategory.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.AudioCategory.set
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.AudioDeviceType.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.AudioDeviceType.set
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void AddAudioEffect( string activatableClassId,  bool effectOptional,  global::Windows.Foundation.Collections.IPropertySet configuration)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "void MediaPlayer.AddAudioEffect(string activatableClassId, bool effectOptional, IPropertySet configuration)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void RemoveAllEffects()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "void MediaPlayer.RemoveAllEffects()");
		}
#endif
		// Skipping already declared method Windows.Media.Playback.MediaPlayer.Dispose()
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.IsMutedChanged.add
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.IsMutedChanged.remove
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.SourceChanged.add
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.SourceChanged.remove
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.AudioBalance.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.AudioBalance.set
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.RealTimePlayback.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.RealTimePlayback.set
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.StereoscopicVideoRenderMode.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.StereoscopicVideoRenderMode.set
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.BreakManager.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.CommandManager.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.AudioDevice.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.AudioDevice.set
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.TimelineController.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.TimelineController.set
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.TimelineControllerPositionOffset.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.TimelineControllerPositionOffset.set
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.PlaybackSession.get
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public void StepForwardOneFrame()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "void MediaPlayer.StepForwardOneFrame()");
		}
#endif
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public void StepBackwardOneFrame()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "void MediaPlayer.StepBackwardOneFrame()");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Media.Casting.CastingSource GetAsCastingSource()
		{
			throw new global::System.NotImplementedException("The member CastingSource MediaPlayer.GetAsCastingSource() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=CastingSource%20MediaPlayer.GetAsCastingSource%28%29");
		}
#endif
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public void SetSurfaceSize( global::Windows.Foundation.Size size)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "void MediaPlayer.SetSurfaceSize(Size size)");
		}
#endif
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.GetSurface(Windows.UI.Composition.Compositor)
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void AddVideoEffect( string activatableClassId,  bool effectOptional,  global::Windows.Foundation.Collections.IPropertySet effectConfiguration)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "void MediaPlayer.AddVideoEffect(string activatableClassId, bool effectOptional, IPropertySet effectConfiguration)");
		}
#endif
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.VideoFrameAvailable.add
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.VideoFrameAvailable.remove
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.IsVideoFrameServerEnabled.get
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.IsVideoFrameServerEnabled.set
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void CopyFrameToVideoSurface( global::Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface destination)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "void MediaPlayer.CopyFrameToVideoSurface(IDirect3DSurface destination)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void CopyFrameToVideoSurface( global::Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface destination,  global::Windows.Foundation.Rect targetRectangle)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "void MediaPlayer.CopyFrameToVideoSurface(IDirect3DSurface destination, Rect targetRectangle)");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void CopyFrameToStereoscopicVideoSurfaces( global::Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface destinationLeftEye,  global::Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface destinationRightEye)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "void MediaPlayer.CopyFrameToStereoscopicVideoSurfaces(IDirect3DSurface destinationLeftEye, IDirect3DSurface destinationRightEye)");
		}
#endif
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.SubtitleFrameChanged.add
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.SubtitleFrameChanged.remove
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool RenderSubtitlesToSurface( global::Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface destination)
		{
			throw new global::System.NotImplementedException("The member bool MediaPlayer.RenderSubtitlesToSurface(IDirect3DSurface destination) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20MediaPlayer.RenderSubtitlesToSurface%28IDirect3DSurface%20destination%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool RenderSubtitlesToSurface( global::Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface destination,  global::Windows.Foundation.Rect targetRectangle)
		{
			throw new global::System.NotImplementedException("The member bool MediaPlayer.RenderSubtitlesToSurface(IDirect3DSurface destination, Rect targetRectangle) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20MediaPlayer.RenderSubtitlesToSurface%28IDirect3DSurface%20destination%2C%20Rect%20targetRectangle%29");
		}
#endif
		// Forced skipping of method Windows.Media.Playback.MediaPlayer.AudioStateMonitor.get
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Media.Playback.MediaPlayer, object> BufferingEnded
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "event TypedEventHandler<MediaPlayer, object> MediaPlayer.BufferingEnded");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "event TypedEventHandler<MediaPlayer, object> MediaPlayer.BufferingEnded");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Media.Playback.MediaPlayer, object> BufferingStarted
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "event TypedEventHandler<MediaPlayer, object> MediaPlayer.BufferingStarted");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "event TypedEventHandler<MediaPlayer, object> MediaPlayer.BufferingStarted");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Media.Playback.MediaPlayer, object> CurrentStateChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "event TypedEventHandler<MediaPlayer, object> MediaPlayer.CurrentStateChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "event TypedEventHandler<MediaPlayer, object> MediaPlayer.CurrentStateChanged");
			}
		}
#endif
		// Skipping already declared event Windows.Media.Playback.MediaPlayer.MediaEnded
		// Skipping already declared event Windows.Media.Playback.MediaPlayer.MediaFailed
		// Skipping already declared event Windows.Media.Playback.MediaPlayer.MediaOpened
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Media.Playback.MediaPlayer, global::Windows.Media.Playback.MediaPlayerRateChangedEventArgs> MediaPlayerRateChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "event TypedEventHandler<MediaPlayer, MediaPlayerRateChangedEventArgs> MediaPlayer.MediaPlayerRateChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "event TypedEventHandler<MediaPlayer, MediaPlayerRateChangedEventArgs> MediaPlayer.MediaPlayerRateChanged");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Media.Playback.MediaPlayer, global::Windows.Media.Playback.PlaybackMediaMarkerReachedEventArgs> PlaybackMediaMarkerReached
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "event TypedEventHandler<MediaPlayer, PlaybackMediaMarkerReachedEventArgs> MediaPlayer.PlaybackMediaMarkerReached");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "event TypedEventHandler<MediaPlayer, PlaybackMediaMarkerReachedEventArgs> MediaPlayer.PlaybackMediaMarkerReached");
			}
		}
#endif
		// Skipping already declared event Windows.Media.Playback.MediaPlayer.SeekCompleted
		// Skipping already declared event Windows.Media.Playback.MediaPlayer.VolumeChanged
		// Skipping already declared event Windows.Media.Playback.MediaPlayer.IsMutedChanged
		// Skipping already declared event Windows.Media.Playback.MediaPlayer.SourceChanged
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Media.Playback.MediaPlayer, object> VideoFrameAvailable
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "event TypedEventHandler<MediaPlayer, object> MediaPlayer.VideoFrameAvailable");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "event TypedEventHandler<MediaPlayer, object> MediaPlayer.VideoFrameAvailable");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || false || false || false || false || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.Media.Playback.MediaPlayer, object> SubtitleFrameChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "event TypedEventHandler<MediaPlayer, object> MediaPlayer.SubtitleFrameChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlayer", "event TypedEventHandler<MediaPlayer, object> MediaPlayer.SubtitleFrameChanged");
			}
		}
#endif
		// Processing: System.IDisposable
	}
}
