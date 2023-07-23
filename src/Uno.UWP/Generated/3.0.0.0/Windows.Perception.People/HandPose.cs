#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Perception.People
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class HandPose 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool TryGetJoint( global::Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem,  global::Windows.Perception.People.HandJointKind joint, out global::Windows.Perception.People.JointPose jointPose)
		{
			throw new global::System.NotImplementedException("The member bool HandPose.TryGetJoint(SpatialCoordinateSystem coordinateSystem, HandJointKind joint, out JointPose jointPose) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20HandPose.TryGetJoint%28SpatialCoordinateSystem%20coordinateSystem%2C%20HandJointKind%20joint%2C%20out%20JointPose%20jointPose%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public bool TryGetJoints( global::Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem,  global::Windows.Perception.People.HandJointKind[] joints,  global::Windows.Perception.People.JointPose[] jointPoses)
		{
			throw new global::System.NotImplementedException("The member bool HandPose.TryGetJoints(SpatialCoordinateSystem coordinateSystem, HandJointKind[] joints, JointPose[] jointPoses) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20HandPose.TryGetJoints%28SpatialCoordinateSystem%20coordinateSystem%2C%20HandJointKind%5B%5D%20joints%2C%20JointPose%5B%5D%20jointPoses%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Perception.People.JointPose GetRelativeJoint( global::Windows.Perception.People.HandJointKind joint,  global::Windows.Perception.People.HandJointKind referenceJoint)
		{
			throw new global::System.NotImplementedException("The member JointPose HandPose.GetRelativeJoint(HandJointKind joint, HandJointKind referenceJoint) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=JointPose%20HandPose.GetRelativeJoint%28HandJointKind%20joint%2C%20HandJointKind%20referenceJoint%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public void GetRelativeJoints( global::Windows.Perception.People.HandJointKind[] joints,  global::Windows.Perception.People.HandJointKind[] referenceJoints,  global::Windows.Perception.People.JointPose[] jointPoses)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Perception.People.HandPose", "void HandPose.GetRelativeJoints(HandJointKind[] joints, HandJointKind[] referenceJoints, JointPose[] jointPoses)");
		}
#endif
	}
}
