/*******************************************************************************
The content of this file includes portions of the proprietary AUDIOKINETIC Wwise
Technology released in source code form as part of the game integration package.
The content of this file may not be used without valid licenses to the
AUDIOKINETIC Wwise Technology.
Note that the use of the game engine is subject to the Unity(R) Terms of
Service at https://unity3d.com/legal/terms-of-service
 
License Usage
 
Licensees holding valid licenses to the AUDIOKINETIC Wwise Technology may use
this file in accordance with the end user license agreement provided with the
software or, alternatively, in accordance with the terms contained
in a written agreement between you and Audiokinetic Inc.
Copyright (c) 2024 Audiokinetic Inc.
*******************************************************************************/
#if UNITY_EDITOR
public class WwiseSoundBankRefArray
{
    private global::System.IntPtr swigCPtr;
    protected bool swigCMemOwn;

    internal WwiseSoundBankRefArray(global::System.IntPtr cPtr, bool cMemoryOwn)
    {
        swigCMemOwn = cMemoryOwn;
        swigCPtr = cPtr;
    }

    internal static global::System.IntPtr getCPtr(WwiseSoundBankRefArray obj)
    {
        return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;
    }

    internal virtual void setCPtr(global::System.IntPtr cPtr)
    {
        Dispose();
        swigCPtr = cPtr;
    }

    ~WwiseSoundBankRefArray()
    {
        Dispose(false);
    }

    public void Dispose()
    {
        Dispose(true);
        global::System.GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        lock (this)
        {
            if (swigCPtr != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    WwiseProjectDatabase.DeleteSoundBanksArrayRef(swigCPtr);
                }

                swigCPtr = global::System.IntPtr.Zero;
            }

            global::System.GC.SuppressFinalize(this);
        }
    }
    public WwiseSoundBankRefArray(global::System.IntPtr cPtr) : this(cPtr, true)
    {
    }
    
    public WwiseSoundBankRefArray() : this(WwiseProjectDatabase.GetAllSoundBanksRef(), true)
    {
    }

    public WwiseSoundBankRef this[int index]
    {
        get { return new WwiseSoundBankRef(WwiseProjectDatabase.GetSoundBankRefIndex(swigCPtr, index), false); }
    }
}
#endif