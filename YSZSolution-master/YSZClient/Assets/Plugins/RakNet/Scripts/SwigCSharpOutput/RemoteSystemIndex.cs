/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class RemoteSystemIndex : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RemoteSystemIndex(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RemoteSystemIndex obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RemoteSystemIndex() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_RemoteSystemIndex(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public uint index {
    set {
      RakNetPINVOKE.RemoteSystemIndex_index_set(swigCPtr, value);
    } 
    get {
      uint ret = RakNetPINVOKE.RemoteSystemIndex_index_get(swigCPtr);
      return ret;
    } 
  }

  public RemoteSystemIndex next {
    set {
      RakNetPINVOKE.RemoteSystemIndex_next_set(swigCPtr, RemoteSystemIndex.getCPtr(value));
    } 
    get {
      IntPtr cPtr = RakNetPINVOKE.RemoteSystemIndex_next_get(swigCPtr);
      RemoteSystemIndex ret = (cPtr == IntPtr.Zero) ? null : new RemoteSystemIndex(cPtr, false);
      return ret;
    } 
  }

  public RemoteSystemIndex() : this(RakNetPINVOKE.new_RemoteSystemIndex(), true) {
  }

}

}
