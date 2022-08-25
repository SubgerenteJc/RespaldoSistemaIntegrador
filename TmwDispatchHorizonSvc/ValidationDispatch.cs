// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.ValidationDispatch
// Assembly: Sl_Pilgrims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 918EA6D9-19C7-408C-9F5D-82D307420CD2
// Assembly location: D:\Salida\Sl_Pilgrims 05_2019\Application Files\Sl_Pilgrims_1_0_0_50\Sl_Pilgrims.exe

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace WindowsFormsApp1.TmwDispatchHorizonSvc
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "ValidationDispatch", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Validation")]
  [Serializable]
  public class ValidationDispatch : ConcurrencyAndValidityBase
  {
    [OptionalField]
    private DispatchHorizon DispatchField;
    [OptionalField]
    private List<ExtraDataItem> ExtraDataField;
    [OptionalField]
    private LegAndOrderMap KeyMapField;
    [OptionalField]
    private ValidationReturnObject ValidationResultsField;

    [DataMember]
    public DispatchHorizon Dispatch
    {
      get
      {
        return this.DispatchField;
      }
      set
      {
        if (this.DispatchField == value)
          return;
        this.DispatchField = value;
        this.RaisePropertyChanged(nameof (Dispatch));
      }
    }

    [DataMember]
    public List<ExtraDataItem> ExtraData
    {
      get
      {
        return this.ExtraDataField;
      }
      set
      {
        if (this.ExtraDataField == value)
          return;
        this.ExtraDataField = value;
        this.RaisePropertyChanged(nameof (ExtraData));
      }
    }

    [DataMember]
    public LegAndOrderMap KeyMap
    {
      get
      {
        return this.KeyMapField;
      }
      set
      {
        if (this.KeyMapField == value)
          return;
        this.KeyMapField = value;
        this.RaisePropertyChanged(nameof (KeyMap));
      }
    }

    [DataMember]
    public ValidationReturnObject ValidationResults
    {
      get
      {
        return this.ValidationResultsField;
      }
      set
      {
        if (this.ValidationResultsField == value)
          return;
        this.ValidationResultsField = value;
        this.RaisePropertyChanged(nameof (ValidationResults));
      }
    }
  }
}
