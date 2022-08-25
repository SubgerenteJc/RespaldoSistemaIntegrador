// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.ExtraDataItem
// Assembly: Sl_Pilgrims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 918EA6D9-19C7-408C-9F5D-82D307420CD2
// Assembly location: D:\Salida\Sl_Pilgrims 05_2019\Application Files\Sl_Pilgrims_1_0_0_50\Sl_Pilgrims.exe

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace WindowsFormsApp1.TmwDispatchHorizonSvc
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "ExtraDataItem", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Dispatch")]
  [Serializable]
  public class ExtraDataItem : ConcurrencyBaseNested
  {
    [OptionalField]
    private string KeyField;
    [OptionalField]
    private string ValueField;

    [DataMember]
    public string Key
    {
      get
      {
        return this.KeyField;
      }
      set
      {
        if ((object) this.KeyField == (object) value)
          return;
        this.KeyField = value;
        this.RaisePropertyChanged(nameof (Key));
      }
    }

    [DataMember]
    public string Value
    {
      get
      {
        return this.ValueField;
      }
      set
      {
        if ((object) this.ValueField == (object) value)
          return;
        this.ValueField = value;
        this.RaisePropertyChanged(nameof (Value));
      }
    }
  }
}
