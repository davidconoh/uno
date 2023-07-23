#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Holographic
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class HolographicFramePrediction 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<global::Windows.Graphics.Holographic.HolographicCameraPose> CameraPoses
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<HolographicCameraPose> HolographicFramePrediction.CameraPoses is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CHolographicCameraPose%3E%20HolographicFramePrediction.CameraPoses");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Perception.PerceptionTimestamp Timestamp
		{
			get
			{
				throw new global::System.NotImplementedException("The member PerceptionTimestamp HolographicFramePrediction.Timestamp is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PerceptionTimestamp%20HolographicFramePrediction.Timestamp");
			}
		}
#endif
		// Forced skipping of method Windows.Graphics.Holographic.HolographicFramePrediction.CameraPoses.get
		// Forced skipping of method Windows.Graphics.Holographic.HolographicFramePrediction.Timestamp.get
	}
}
