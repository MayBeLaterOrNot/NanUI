// THIS FILE IS PART OF NanUI PROJECT
// THE NanUI PROJECT IS AN OPENSOURCE LIBRARY LICENSED UNDER THE MIT License.
// COPYRIGHTS (C) Xuanchen Lin. ALL RIGHTS RESERVED.
// GITHUB: https://github.com/XuanchenLin/NanUI


using NetDimension.NanUI.CefGlue.Interop;

namespace NetDimension.NanUI.CefGlue;
/// <summary>
/// Class that manages custom scheme registrations.
/// </summary>
public sealed unsafe partial class CefSchemeRegistrar
{
    internal void ReleaseObject()
    {
        _self = null;
    }

    /// <summary>
    /// Register a custom scheme. This method should not be called for the
    /// built-in HTTP, HTTPS, FILE, FTP, ABOUT and DATA schemes.
    /// See cef_scheme_options_t for possible values for |options|.
    /// This function may be called on any thread. It should only be called once
    /// per unique |scheme_name| value. If |scheme_name| is already registered or
    /// if an error occurs this method will return false.
    /// </summary>
    public bool AddCustomScheme(string schemeName, CefSchemeOptions options)
    {
        if (schemeName == null)
            throw new ArgumentNullException(nameof(schemeName));

        fixed (char* schemeName_str = schemeName)
        {
            var n_schemeName = new cef_string_t(schemeName_str, schemeName.Length);
            return cef_scheme_registrar_t.add_custom_scheme(
                _self,
                &n_schemeName,
                (int)options
                ) != 0;
        }
    }
}
