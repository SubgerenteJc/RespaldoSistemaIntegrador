// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.mx.com.pilgrims.wslogistica.WSL_GetInfoEmbarqueCompletedEventArgs
// Assembly: Sl_Pilgrims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 918EA6D9-19C7-408C-9F5D-82D307420CD2
// Assembly location: D:\Salida\Sl_Pilgrims 05_2019\Application Files\Sl_Pilgrims_1_0_0_50\Sl_Pilgrims.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;

namespace WindowsFormsApp1.mx.com.pilgrims.wslogistica
{
  [GeneratedCode("System.Web.Services", "4.7.2556.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  public class WSL_GetInfoEmbarqueCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal WSL_GetInfoEmbarqueCompletedEventArgs(
      object[] results,
      Exception exception,
      bool cancelled,
      object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public XmlNode Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (XmlNode) this.results[0];
      }
    }
  }
}
