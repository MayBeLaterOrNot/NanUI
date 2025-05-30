// THIS FILE IS PART OF NanUI PROJECT
// THE NanUI PROJECT IS AN OPENSOURCE LIBRARY LICENSED UNDER THE MIT License.
// COPYRIGHTS (C) Xuanchen Lin. ALL RIGHTS RESERVED.
// GITHUB: https://github.com/XuanchenLin/NanUI

namespace NetDimension.NanUI;

public class FramePageLoadErrorEventArgs : EventArgs
{
    public CefBrowser Browser { get; }
    public CefFrame Frame { get; }
    public CefErrorCode ErrorCode { get; }
    public string ErrorText { get; }
    public string FailedUrl { get; }

    public FramePageLoadErrorEventArgs(CefBrowser browser, CefFrame frame, CefErrorCode errorCode, string errorText, string failedUrl)
    {
        Browser = browser;
        Frame = frame;
        ErrorCode = errorCode;
        ErrorText = errorText;
        FailedUrl = failedUrl;
    }
}
