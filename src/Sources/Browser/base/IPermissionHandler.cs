// THIS FILE IS PART OF NanUI PROJECT
// THE NanUI PROJECT IS AN OPENSOURCE LIBRARY LICENSED UNDER THE MIT License.
// COPYRIGHTS (C) Xuanchen Lin. ALL RIGHTS RESERVED.
// GITHUB: https://github.com/XuanchenLin/NanUI

namespace NetDimension.NanUI.Browser;
public interface IPermissionHandler
{
    bool OnRequestMediaAccessPermission(CefBrowser browser, CefFrame frame, string requestingOrigin, CefMediaAccessPermissionTypes requestedPermissions, CefMediaAccessCallback callback);
    bool OnShowPermissionPrompt(CefBrowser browser, ulong promptId, string requestingOrigin, CefPermissionRequestTypes requestedPermissions, CefPermissionPromptCallback callback);
    void OnDismissPermissionPrompt(CefBrowser browser, ulong promptId, CefPermissionRequestResult result);
}
