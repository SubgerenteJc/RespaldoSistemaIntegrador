// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.ReferenceNumber
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
  [DataContract(Name = "ReferenceNumber", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Dispatch")]
  [Serializable]
  public class ReferenceNumber : ConcurrencyBaseNested
  {
    [OptionalField]
    private int RefIdField;
    [OptionalField]
    private string RefNumberField;
    [OptionalField]
    private string RefTypeField;

    [DataMember]
    public int RefId
    {
      get
      {
        return this.RefIdField;
      }
      set
      {
        if (this.RefIdField.Equals(value))
          return;
        this.RefIdField = value;
        this.RaisePropertyChanged(nameof (RefId));
      }
    }

    [DataMember]
    public string RefNumber
    {
      get
      {
        return this.RefNumberField;
      }
      set
      {
        if ((object) this.RefNumberField == (object) value)
          return;
        this.RefNumberField = value;
        this.RaisePropertyChanged(nameof (RefNumber));
      }
    }

    [DataMember]
    public string RefType
    {
      get
      {
        return this.RefTypeField;
      }
      set
      {
        if ((object) this.RefTypeField == (object) value)
          return;
        this.RefTypeField = value;
        this.RaisePropertyChanged(nameof (RefType));
      }
    }
  }
}
