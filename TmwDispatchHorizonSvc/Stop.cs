// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.Stop
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
  [DataContract(Name = "Stop", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Dispatch")]
  [Serializable]
  public class Stop : StopBase
  {
    [OptionalField]
    private List<WindowsFormsApp1.TmwDispatchHorizonSvc.Freight> FreightField;
    [OptionalField]
    private List<ReferenceNumber> ReferenceNumbersField;

    [DataMember]
    public List<WindowsFormsApp1.TmwDispatchHorizonSvc.Freight> Freight
    {
      get
      {
        return this.FreightField;
      }
      set
      {
        if (this.FreightField == value)
          return;
        this.FreightField = value;
        this.RaisePropertyChanged(nameof (Freight));
      }
    }

    [DataMember]
    public List<ReferenceNumber> ReferenceNumbers
    {
      get
      {
        return this.ReferenceNumbersField;
      }
      set
      {
        if (this.ReferenceNumbersField == value)
          return;
        this.ReferenceNumbersField = value;
        this.RaisePropertyChanged(nameof (ReferenceNumbers));
      }
    }
  }
}
