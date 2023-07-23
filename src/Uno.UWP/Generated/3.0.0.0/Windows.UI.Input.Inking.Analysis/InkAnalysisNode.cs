#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Input.Inking.Analysis
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class InkAnalysisNode : global::Windows.UI.Input.Inking.Analysis.IInkAnalysisNode
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.Rect BoundingRect
		{
			get
			{
				throw new global::System.NotImplementedException("The member Rect InkAnalysisNode.BoundingRect is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=Rect%20InkAnalysisNode.BoundingRect");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Input.Inking.Analysis.IInkAnalysisNode> Children
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<IInkAnalysisNode> InkAnalysisNode.Children is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CIInkAnalysisNode%3E%20InkAnalysisNode.Children");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public uint Id
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint InkAnalysisNode.Id is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=uint%20InkAnalysisNode.Id");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.UI.Input.Inking.Analysis.InkAnalysisNodeKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member InkAnalysisNodeKind InkAnalysisNode.Kind is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=InkAnalysisNodeKind%20InkAnalysisNode.Kind");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.UI.Input.Inking.Analysis.IInkAnalysisNode Parent
		{
			get
			{
				throw new global::System.NotImplementedException("The member IInkAnalysisNode InkAnalysisNode.Parent is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IInkAnalysisNode%20InkAnalysisNode.Parent");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<global::Windows.Foundation.Point> RotatedBoundingRect
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<Point> InkAnalysisNode.RotatedBoundingRect is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CPoint%3E%20InkAnalysisNode.RotatedBoundingRect");
			}
		}
#endif
		// Forced skipping of method Windows.UI.Input.Inking.Analysis.InkAnalysisNode.Id.get
		// Forced skipping of method Windows.UI.Input.Inking.Analysis.InkAnalysisNode.Kind.get
		// Forced skipping of method Windows.UI.Input.Inking.Analysis.InkAnalysisNode.BoundingRect.get
		// Forced skipping of method Windows.UI.Input.Inking.Analysis.InkAnalysisNode.RotatedBoundingRect.get
		// Forced skipping of method Windows.UI.Input.Inking.Analysis.InkAnalysisNode.Children.get
		// Forced skipping of method Windows.UI.Input.Inking.Analysis.InkAnalysisNode.Parent.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::System.Collections.Generic.IReadOnlyList<uint> GetStrokeIds()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<uint> InkAnalysisNode.GetStrokeIds() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3Cuint%3E%20InkAnalysisNode.GetStrokeIds%28%29");
		}
#endif
		// Processing: Windows.UI.Input.Inking.Analysis.IInkAnalysisNode
	}
}
