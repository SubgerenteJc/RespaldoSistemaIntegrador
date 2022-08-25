// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.Move
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
  [DataContract(Name = "Move", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Dispatch")]
  [Serializable]
  public class Move : ConcurrencyNestedAndValidityBase
  {
    [OptionalField]
    private List<Leg> LegsField;
    [OptionalField]
    private List<Stop> StopsField;
    [OptionalField]
    private int mov_numberField;

    [DataMember]
    public List<Leg> Legs
    {
      get
      {
        return this.LegsField;
      }
      set
      {
        if (this.LegsField == value)
          return;
        this.LegsField = value;
        this.RaisePropertyChanged(nameof (Legs));
      }
    }

    [DataMember]
    public List<Stop> Stops
    {
      get
      {
        return this.StopsField;
      }
      set
      {
        if (this.StopsField == value)
          return;
        this.StopsField = value;
        this.RaisePropertyChanged(nameof (Stops));
      }
    }

    [DataMember]
    public int mov_number
    {
      get
      {
        return this.mov_numberField;
      }
      set
      {
        if (this.mov_numberField.Equals(value))
          return;
        this.mov_numberField = value;
        this.RaisePropertyChanged(nameof (mov_number));
      }
    }
  }
}
