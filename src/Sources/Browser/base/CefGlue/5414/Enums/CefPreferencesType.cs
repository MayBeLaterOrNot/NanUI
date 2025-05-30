// THIS FILE IS PART OF NanUI PROJECT
// THE NanUI PROJECT IS AN OPENSOURCE LIBRARY LICENSED UNDER THE MIT License.
// COPYRIGHTS (C) Xuanchen Lin. ALL RIGHTS RESERVED.
// GITHUB: https://github.com/XuanchenLin/NanUI

namespace NetDimension.NanUI.CefGlue;

/// <summary>
/// Preferences type passed to
/// CefBrowserProcessHandler::OnRegisterCustomPreferences.
/// </summary>
public enum CefPreferencesType
{
    /// <summary>
    /// Global preferences registered a single time at application startup.
    /// </summary>
    Global,

    /// <summary>
    /// Request context preferences registered each time a new CefRequestContext
    /// is created.
    /// </summary>
    RequestContext,
}
