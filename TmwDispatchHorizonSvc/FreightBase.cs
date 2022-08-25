// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.FreightBase
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
  [DataContract(Name = "FreightBase", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Dispatch")]
  [KnownType(typeof (Freight))]
  [Serializable]
  public class FreightBase : ValidityBase
  {
    [OptionalField]
    private string AccountOfField;
    [OptionalField]
    private string AssetField;
    [OptionalField]
    private double CountField;
    [OptionalField]
    private double Count2Field;
    [OptionalField]
    private string Count2UnitField;
    [OptionalField]
    private string CountUnitField;
    [OptionalField]
    private string DescriptionOverrideField;
    [OptionalField]
    private double LengthField;
    [OptionalField]
    private string LengthUnitField;
    [OptionalField]
    private int LinkedDeliveryFreightNumberField;
    [OptionalField]
    private double OrderedVolumeField;
    [OptionalField]
    private double QuantityField;
    [OptionalField]
    private string QuantityUnitField;
    [OptionalField]
    private string SupplierField;
    [OptionalField]
    private double VolumeField;
    [OptionalField]
    private double Volume2Field;
    [OptionalField]
    private string Volume2UnitField;
    [OptionalField]
    private string VolumeUnitField;
    [OptionalField]
    private double WeightField;
    [OptionalField]
    private string WeightUnitField;
    [OptionalField]
    private string cmd_codeField;
    [OptionalField]
    private string fgt_actual_unitField;
    [OptionalField]
    private int fgt_numberField;
    [OptionalField]
    private string unitField;

    [DataMember]
    public string AccountOf
    {
      get
      {
        return this.AccountOfField;
      }
      set
      {
        if ((object) this.AccountOfField == (object) value)
          return;
        this.AccountOfField = value;
        this.RaisePropertyChanged(nameof (AccountOf));
      }
    }

    [DataMember]
    public string Asset
    {
      get
      {
        return this.AssetField;
      }
      set
      {
        if ((object) this.AssetField == (object) value)
          return;
        this.AssetField = value;
        this.RaisePropertyChanged(nameof (Asset));
      }
    }

    [DataMember]
    public double Count
    {
      get
      {
        return this.CountField;
      }
      set
      {
        if (this.CountField.Equals(value))
          return;
        this.CountField = value;
        this.RaisePropertyChanged(nameof (Count));
      }
    }

    [DataMember]
    public double Count2
    {
      get
      {
        return this.Count2Field;
      }
      set
      {
        if (this.Count2Field.Equals(value))
          return;
        this.Count2Field = value;
        this.RaisePropertyChanged(nameof (Count2));
      }
    }

    [DataMember]
    public string Count2Unit
    {
      get
      {
        return this.Count2UnitField;
      }
      set
      {
        if ((object) this.Count2UnitField == (object) value)
          return;
        this.Count2UnitField = value;
        this.RaisePropertyChanged(nameof (Count2Unit));
      }
    }

    [DataMember]
    public string CountUnit
    {
      get
      {
        return this.CountUnitField;
      }
      set
      {
        if ((object) this.CountUnitField == (object) value)
          return;
        this.CountUnitField = value;
        this.RaisePropertyChanged(nameof (CountUnit));
      }
    }

    [DataMember]
    public string DescriptionOverride
    {
      get
      {
        return this.DescriptionOverrideField;
      }
      set
      {
        if ((object) this.DescriptionOverrideField == (object) value)
          return;
        this.DescriptionOverrideField = value;
        this.RaisePropertyChanged(nameof (DescriptionOverride));
      }
    }

    [DataMember]
    public double Length
    {
      get
      {
        return this.LengthField;
      }
      set
      {
        if (this.LengthField.Equals(value))
          return;
        this.LengthField = value;
        this.RaisePropertyChanged(nameof (Length));
      }
    }

    [DataMember]
    public string LengthUnit
    {
      get
      {
        return this.LengthUnitField;
      }
      set
      {
        if ((object) this.LengthUnitField == (object) value)
          return;
        this.LengthUnitField = value;
        this.RaisePropertyChanged(nameof (LengthUnit));
      }
    }

    [DataMember]
    public int LinkedDeliveryFreightNumber
    {
      get
      {
        return this.LinkedDeliveryFreightNumberField;
      }
      set
      {
        if (this.LinkedDeliveryFreightNumberField.Equals(value))
          return;
        this.LinkedDeliveryFreightNumberField = value;
        this.RaisePropertyChanged(nameof (LinkedDeliveryFreightNumber));
      }
    }

    [DataMember]
    public double OrderedVolume
    {
      get
      {
        return this.OrderedVolumeField;
      }
      set
      {
        if (this.OrderedVolumeField.Equals(value))
          return;
        this.OrderedVolumeField = value;
        this.RaisePropertyChanged(nameof (OrderedVolume));
      }
    }

    [DataMember]
    public double Quantity
    {
      get
      {
        return this.QuantityField;
      }
      set
      {
        if (this.QuantityField.Equals(value))
          return;
        this.QuantityField = value;
        this.RaisePropertyChanged(nameof (Quantity));
      }
    }

    [DataMember]
    public string QuantityUnit
    {
      get
      {
        return this.QuantityUnitField;
      }
      set
      {
        if ((object) this.QuantityUnitField == (object) value)
          return;
        this.QuantityUnitField = value;
        this.RaisePropertyChanged(nameof (QuantityUnit));
      }
    }

    [DataMember]
    public string Supplier
    {
      get
      {
        return this.SupplierField;
      }
      set
      {
        if ((object) this.SupplierField == (object) value)
          return;
        this.SupplierField = value;
        this.RaisePropertyChanged(nameof (Supplier));
      }
    }

    [DataMember]
    public double Volume
    {
      get
      {
        return this.VolumeField;
      }
      set
      {
        if (this.VolumeField.Equals(value))
          return;
        this.VolumeField = value;
        this.RaisePropertyChanged(nameof (Volume));
      }
    }

    [DataMember]
    public double Volume2
    {
      get
      {
        return this.Volume2Field;
      }
      set
      {
        if (this.Volume2Field.Equals(value))
          return;
        this.Volume2Field = value;
        this.RaisePropertyChanged(nameof (Volume2));
      }
    }

    [DataMember]
    public string Volume2Unit
    {
      get
      {
        return this.Volume2UnitField;
      }
      set
      {
        if ((object) this.Volume2UnitField == (object) value)
          return;
        this.Volume2UnitField = value;
        this.RaisePropertyChanged(nameof (Volume2Unit));
      }
    }

    [DataMember]
    public string VolumeUnit
    {
      get
      {
        return this.VolumeUnitField;
      }
      set
      {
        if ((object) this.VolumeUnitField == (object) value)
          return;
        this.VolumeUnitField = value;
        this.RaisePropertyChanged(nameof (VolumeUnit));
      }
    }

    [DataMember]
    public double Weight
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
    public string WeightUnit
    {
      get
      {
        return this.WeightUnitField;
      }
      set
      {
        if ((object) this.WeightUnitField == (object) value)
          return;
        this.WeightUnitField = value;
        this.RaisePropertyChanged(nameof (WeightUnit));
      }
    }

    [DataMember]
    public string cmd_code
    {
      get
      {
        return this.cmd_codeField;
      }
      set
      {
        if ((object) this.cmd_codeField == (object) value)
          return;
        this.cmd_codeField = value;
        this.RaisePropertyChanged(nameof (cmd_code));
      }
    }

    [DataMember]
    public string fgt_actual_unit
    {
      get
      {
        return this.fgt_actual_unitField;
      }
      set
      {
        if ((object) this.fgt_actual_unitField == (object) value)
          return;
        this.fgt_actual_unitField = value;
        this.RaisePropertyChanged(nameof (fgt_actual_unit));
      }
    }

    [DataMember]
    public int fgt_number
    {
      get
      {
        return this.fgt_numberField;
      }
      set
      {
        if (this.fgt_numberField.Equals(value))
          return;
        this.fgt_numberField = value;
        this.RaisePropertyChanged(nameof (fgt_number));
      }
    }

    [DataMember]
    public string unit
    {
      get
      {
        return this.unitField;
      }
      set
      {
        if ((object) this.unitField == (object) value)
          return;
        this.unitField = value;
        this.RaisePropertyChanged(nameof (unit));
      }
    }
  }
}
