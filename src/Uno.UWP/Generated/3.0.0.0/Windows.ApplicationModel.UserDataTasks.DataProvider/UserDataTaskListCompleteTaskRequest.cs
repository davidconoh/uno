#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
#endif
	public partial class UserDataTaskListCompleteTaskRequest 
	{
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string TaskId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string UserDataTaskListCompleteTaskRequest.TaskId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20UserDataTaskListCompleteTaskRequest.TaskId");
			}
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public string TaskListId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string UserDataTaskListCompleteTaskRequest.TaskListId is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=string%20UserDataTaskListCompleteTaskRequest.TaskListId");
			}
		}
#endif
		// Forced skipping of method Windows.ApplicationModel.UserDataTasks.DataProvider.UserDataTaskListCompleteTaskRequest.TaskListId.get
		// Forced skipping of method Windows.ApplicationModel.UserDataTasks.DataProvider.UserDataTaskListCompleteTaskRequest.TaskId.get
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction ReportCompletedAsync( string completedTaskId)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction UserDataTaskListCompleteTaskRequest.ReportCompletedAsync(string completedTaskId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20UserDataTaskListCompleteTaskRequest.ReportCompletedAsync%28string%20completedTaskId%29");
		}
#endif
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public global::Windows.Foundation.IAsyncAction ReportFailedAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction UserDataTaskListCompleteTaskRequest.ReportFailedAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IAsyncAction%20UserDataTaskListCompleteTaskRequest.ReportFailedAsync%28%29");
		}
#endif
	}
}
