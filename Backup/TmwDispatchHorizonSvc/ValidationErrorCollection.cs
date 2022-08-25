// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.ValidationErrorCollection
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
  [DataContract(Name = "ValidationErrorCollection", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Validation")]
  [Serializable]
  public class ValidationErrorCollection : ConcurrencyAndValidityBase
  {
    [OptionalField]
    private List<ExtraDataItem> ExtraDataField;
    [OptionalField]
    private List<ValidationError> ValidationErrorsField;

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
    public List<ValidationError> ValidationErrors
    {
      get
      {
        return this.ValidationErrorsField;
      }
      set
      {
        if (this.ValidationErrorsField == value)
          return;
        this.ValidationErrorsField = value;
        this.RaisePropertyChanged(nameof (ValidationErrors));
      }
    }
  }
}
