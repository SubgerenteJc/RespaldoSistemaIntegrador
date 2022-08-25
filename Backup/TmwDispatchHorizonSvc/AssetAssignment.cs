// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.AssetAssignment
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
  [DataContract(Name = "AssetAssignment", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Activity")]
  [Serializable]
  public class AssetAssignment : AssetTypeAndId
  {
    [OptionalField]
    private int AssignNumberField;
    [OptionalField]
    private bool ControllingField;
    [OptionalField]
    private DateTime EndDateField;
    [OptionalField]
    private int EndEventField;
    [OptionalField]
    private int EndStopField;
    [OptionalField]
    private int LegNumberField;
    [OptionalField]
    private int MoveNumberField;
    [OptionalField]
    private DateTime StartDateField;
    [OptionalField]
    private int StartEventField;
    [OptionalField]
    private int StartStopField;
    [OptionalField]
    private string StatusField;

    [DataMember]
    public int AssignNumber
    {
      get
      {
        return this.AssignNumberField;
      }
      set
      {
        if (this.AssignNumberField.Equals(value))
          return;
        this.AssignNumberField = value;
        this.RaisePropertyChanged(nameof (AssignNumber));
      }
    }

    [DataMember]
    public bool Controlling
    {
      get
      {
        return this.ControllingField;
      }
      set
      {
        if (this.ControllingField.Equals(value))
          return;
        this.ControllingField = value;
        this.RaisePropertyChanged(nameof (Controlling));
      }
    }

    [DataMember]
    public DateTime EndDate
    {
      get
      {
        return this.EndDateField;
      }
      set
      {
        if (this.EndDateField.Equals(value))
          return;
        this.EndDateField = value;
        this.RaisePropertyChanged(nameof (EndDate));
      }
    }

    [DataMember]
    public int EndEvent
    {
      get
      {
        return this.EndEventField;
      }
      set
      {
        if (this.EndEventField.Equals(value))
          return;
        this.EndEventField = value;
        this.RaisePropertyChanged(nameof (EndEvent));
      }
    }

    [DataMember]
    public int EndStop
    {
      get
      {
        return this.EndStopField;
      }
      set
      {
        if (this.EndStopField.Equals(value))
          return;
        this.EndStopField = value;
        this.RaisePropertyChanged(nameof (EndStop));
      }
    }

    [DataMember]
    public int LegNumber
    {
      get
      {
        return this.LegNumberField;
      }
      set
      {
        if (this.LegNumberField.Equals(value))
          return;
        this.LegNumberField = value;
        this.RaisePropertyChanged(nameof (LegNumber));
      }
    }

    [DataMember]
    public int MoveNumber
    {
      get
      {
        return this.MoveNumberField;
      }
      set
      {
        if (this.MoveNumberField.Equals(value))
          return;
        this.MoveNumberField = value;
        this.RaisePropertyChanged(nameof (MoveNumber));
      }
    }

    [DataMember]
    public DateTime StartDate
    {
      get
      {
        return this.StartDateField;
      }
      set
      {
        if (this.StartDateField.Equals(value))
          return;
        this.StartDateField = value;
        this.RaisePropertyChanged(nameof (StartDate));
      }
    }

    [DataMember]
    public int StartEvent
    {
      get
      {
        return this.StartEventField;
      }
      set
      {
        if (this.StartEventField.Equals(value))
          return;
        this.StartEventField = value;
        this.RaisePropertyChanged(nameof (StartEvent));
      }
    }

    [DataMember]
    public int StartStop
    {
      get
      {
        return this.StartStopField;
      }
      set
      {
        if (this.StartStopField.Equals(value))
          return;
        this.StartStopField = value;
        this.RaisePropertyChanged(nameof (StartStop));
      }
    }

    [DataMember]
    public string Status
    {
      get
      {
        return this.StatusField;
      }
      set
      {
        if ((object) this.StatusField == (object) value)
          return;
        this.StatusField = value;
        this.RaisePropertyChanged(nameof (Status));
      }
    }
  }
}
