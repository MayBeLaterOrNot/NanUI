﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefMediaAccessCallback : IDisposable
    {
        internal static CefMediaAccessCallback FromNative(cef_media_access_callback_t* ptr)
        {
            return new CefMediaAccessCallback(ptr);
        }
        
        internal static CefMediaAccessCallback FromNativeOrNull(cef_media_access_callback_t* ptr)
        {
            if (ptr == null) return null;
            return new CefMediaAccessCallback(ptr);
        }
        
        private cef_media_access_callback_t* _self;
        
        private CefMediaAccessCallback(cef_media_access_callback_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefMediaAccessCallback()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
            GC.SuppressFinalize(this);
        }
        
        internal void AddRef()
        {
            cef_media_access_callback_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_media_access_callback_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_media_access_callback_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_media_access_callback_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_media_access_callback_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}