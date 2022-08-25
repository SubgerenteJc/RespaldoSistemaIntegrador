// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.ConcurrencyAndValidityBase
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
  [DataContract(Name = "ConcurrencyAndValidityBase", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Base")]
  [KnownType(typeof (ValidationErrorCollection))]
  [KnownType(typeof (ValidationDispatch))]
  [KnownType(typeof (DispatchHorizon))]
  [Serializable]
  public class ConcurrencyAndValidityBase : ConcurrencyBase
  {
    [OptionalField]
    private List<ValidityIssue> ValidityIssuesField;

    [DataMember]
    public List<ValidityIssue> ValidityIssues
    {
      get
      {
        return this.ValidityIssuesField;
      }
      set
      {
        if (this.ValidityIssuesField == value)
          return;
        this.ValidityIssuesField = value;
        this.RaisePropertyChanged(nameof (ValidityIssues));
      }
    }
  }
}
