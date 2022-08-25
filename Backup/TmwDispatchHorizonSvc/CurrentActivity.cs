// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.CurrentActivity
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
  [DataContract(Name = "CurrentActivity", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Activity")]
  [Serializable]
  public class CurrentActivity : CurrrentActivityBase
  {
    [OptionalField]
    private List<AssetAssignment> LinkedAssignmentsField;

    [DataMember]
    public List<AssetAssignment> LinkedAssignments
    {
      get
      {
        return this.LinkedAssignmentsField;
      }
      set
      {
        if (this.LinkedAssignmentsField == value)
          return;
        this.LinkedAssignmentsField = value;
        this.RaisePropertyChanged(nameof (LinkedAssignments));
      }
    }
  }
}
