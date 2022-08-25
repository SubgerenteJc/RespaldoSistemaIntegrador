// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.FreightTank
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
  [DataContract(Name = "FreightTank", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Dispatch")]
  [Serializable]
  public class FreightTank : ValidityBase
  {
    [OptionalField]
    private Decimal GrossVolumeField;
    [OptionalField]
    private Decimal NetVolumeField;
    [OptionalField]
    private int OfrIdField;
    [OptionalField]
    private int TankNumberField;
    [OptionalField]
    private Decimal WeightField;
    [OptionalField]
    private int fbc_idField;

    [DataMember]
    public Decimal GrossVolume
    {
      get
      {
        return this.GrossVolumeField;
      }
      set
      {
        if (this.GrossVolumeField.Equals(value))
          return;
        this.GrossVolumeField = value;
        this.RaisePropertyChanged(nameof (GrossVolume));
      }
    }

    [DataMember]
    public Decimal NetVolume
    {
      get
      {
        return this.NetVolumeField;
      }
      set
      {
        if (this.NetVolumeField.Equals(value))
          return;
        this.NetVolumeField = value;
        this.RaisePropertyChanged(nameof (NetVolume));
      }
    }

    [DataMember]
    public int OfrId
    {
      get
      {
        return this.OfrIdField;
      }
      set
      {
        if (this.OfrIdField.Equals(value))
          return;
        this.OfrIdField = value;
        this.RaisePropertyChanged(nameof (OfrId));
      }
    }

    [DataMember]
    public int TankNumber
    {
      get
      {
        return this.TankNumberField;
      }
      set
      {
        if (this.TankNumberField.Equals(value))
          return;
        this.TankNumberField = value;
        this.RaisePropertyChanged(nameof (TankNumber));
      }
    }

    [DataMember]
    public Decimal Weight
    {
      get
      {
        return this.WeightField;
      }
      set
      {
        if (this.WeightField.Equals(value))
          return;
        this.WeightField = value;
        this.RaisePropertyChanged(nameof (Weight));
      }
    }

    [DataMember]
    public int fbc_id
    {
      get
      {
        return this.fbc_idField;
      }
      set
      {
        if (this.fbc_idField.Equals(value))
          return;
        this.fbc_idField = value;
        this.RaisePropertyChanged(nameof (fbc_id));
      }
    }
  }
}
