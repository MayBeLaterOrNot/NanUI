﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace WinFormium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using WinFormium.CefGlue.Interop;
    
    // Role: HANDLER
    public abstract unsafe partial class CefCookieAccessFilter
    {
        private static Dictionary<IntPtr, CefCookieAccessFilter> _roots = new Dictionary<IntPtr, CefCookieAccessFilter>();
        
        private int _refct;
        private cef_cookie_access_filter_t* _self;
        
        protected object SyncRoot { get { return this; } }
        
        private cef_cookie_access_filter_t.add_ref_delegate _ds0;
        private cef_cookie_access_filter_t.release_delegate _ds1;
        private cef_cookie_access_filter_t.has_one_ref_delegate _ds2;
        private cef_cookie_access_filter_t.has_at_least_one_ref_delegate _ds3;
        private cef_cookie_access_filter_t.can_send_cookie_delegate _ds4;
        private cef_cookie_access_filter_t.can_save_cookie_delegate _ds5;
        
        protected CefCookieAccessFilter()
        {
            _self = cef_cookie_access_filter_t.Alloc();
        
            _ds0 = new cef_cookie_access_filter_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_cookie_access_filter_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_cookie_access_filter_t.has_one_ref_delegate(has_one_ref);
            _self->_base._has_one_ref = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_cookie_access_filter_t.has_at_least_one_ref_delegate(has_at_least_one_ref);
            _self->_base._has_at_least_one_ref = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_cookie_access_filter_t.can_send_cookie_delegate(can_send_cookie);
            _self->_can_send_cookie = Marshal.GetFunctionPointerForDelegate(_ds4);
            _ds5 = new cef_cookie_access_filter_t.can_save_cookie_delegate(can_save_cookie);
            _self->_can_save_cookie = Marshal.GetFunctionPointerForDelegate(_ds5);
        }
        
        ~CefCookieAccessFilter()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_cookie_access_filter_t.Free(_self);
                _self = null;
            }
        }
        
        private void add_ref(cef_cookie_access_filter_t* self)
        {
            lock (SyncRoot)
            {
                var result = ++_refct;
                if (result == 1)
                {
                    lock (_roots) { _roots.Add((IntPtr)_self, this); }
                }
            }
        }
        
        private int release(cef_cookie_access_filter_t* self)
        {
            lock (SyncRoot)
            {
                var result = --_refct;
                if (result == 0)
                {
                    lock (_roots) { _roots.Remove((IntPtr)_self); }
                    return 1;
                }
                return 0;
            }
        }
        
        private int has_one_ref(cef_cookie_access_filter_t* self)
        {
            lock (SyncRoot) { return _refct == 1 ? 1 : 0; }
        }
        
        private int has_at_least_one_ref(cef_cookie_access_filter_t* self)
        {
            lock (SyncRoot) { return _refct != 0 ? 1 : 0; }
        }
        
        internal cef_cookie_access_filter_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_cookie_access_filter_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}