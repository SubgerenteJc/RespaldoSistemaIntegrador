// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.Leg
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
  [DataContract(Name = "Leg", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Dispatch")]
  [Serializable]
  public class Leg : ConcurrencyNestedAndValidityBase
  {
    [OptionalField]
    private string BookedBranchField;
    [OptionalField]
    private string CarrierField;
    [OptionalField]
    private string CarrierContactField;
    [OptionalField]
    private string CarrierDriverField;
    [OptionalField]
    private string CarrierDriverPhoneField;
    [OptionalField]
    private string CarrierTruckField;
    [OptionalField]
    private string Driver1Field;
    [OptionalField]
    private string Driver2Field;
    [OptionalField]
    private string ExecutingBranchField;
    [OptionalField]
    private string OutStatusField;
    [OptionalField]
    private int? ShiftIdField;
    [OptionalField]
    private int? ShiftSequenceField;
    [OptionalField]
    private int TotalMilesField;
    [OptionalField]
    private string TractorField;
    [OptionalField]
    private string lgh_booked_revtype1Field;
    [OptionalField]
    private int lgh_numberField;
    [OptionalField]
    private string lgh_type1Field;
    [OptionalField]
    private string lgh_type2Field;
    [OptionalField]
    private string lgh_type3Field;
    [OptionalField]
    private string lgh_type4Field;

    [DataMember]
    public string BookedBranch
    {
      get
      {
        return this.BookedBranchField;
      }
      set
      {
        if ((object) this.BookedBranchField == (object) value)
          return;
        this.BookedBranchField = value;
        this.RaisePropertyChanged(nameof (BookedBranch));
      }
    }

    [DataMember]
    public string Carrier
    {
      get
      {
        return this.CarrierField;
      }
      set
      {
        if ((object) this.CarrierField == (object) value)
          return;
        this.CarrierField = value;
        this.RaisePropertyChanged(nameof (Carrier));
      }
    }

    [DataMember]
    public string CarrierContact
    {
      get
      {
        return this.CarrierContactField;
      }
      set
      {
        if ((object) this.CarrierContactField == (object) value)
          return;
        this.CarrierContactField = value;
        this.RaisePropertyChanged(nameof (CarrierContact));
      }
    }

    [DataMember]
    public string CarrierDriver
    {
      get
      {
        return this.CarrierDriverField;
      }
      set
      {
        if ((object) this.CarrierDriverField == (object) value)
          return;
        this.CarrierDriverField = value;
        this.RaisePropertyChanged(nameof (CarrierDriver));
      }
    }

    [DataMember]
    public string CarrierDriverPhone
    {
      get
      {
        return this.CarrierDriverPhoneField;
      }
      set
      {
        if ((object) this.CarrierDriverPhoneField == (object) value)
          return;
        this.CarrierDriverPhoneField = value;
        this.RaisePropertyChanged(nameof (CarrierDriverPhone));
      }
    }

    [DataMember]
    public string CarrierTruck
    {
      get
      {
        return this.CarrierTruckField;
      }
      set
      {
        if ((object) this.CarrierTruckField == (object) value)
          return;
        this.CarrierTruckField = value;
        this.RaisePropertyChanged(nameof (CarrierTruck));
      }
    }

    [DataMember]
    public string Driver1
    {
      get
      {
        return this.Driver1Field;
      }
      set
      {
        if ((object) this.Driver1Field == (object) value)
          return;
        this.Driver1Field = value;
        this.RaisePropertyChanged(nameof (Driver1));
      }
    }

    [DataMember]
    public string Driver2
    {
      get
      {
        return this.Driver2Field;
      }
      set
      {
        if ((object) this.Driver2Field == (object) value)
          return;
        this.Driver2Field = value;
        this.RaisePropertyChanged(nameof (Driver2));
      }
    }

    [DataMember]
    public string ExecutingBranch
    {
      get
      {
        return this.ExecutingBranchField;
      }
      set
      {
        if ((object) this.ExecutingBranchField == (object) value)
          return;
        this.ExecutingBranchField = value;
        this.RaisePropertyChanged(nameof (ExecutingBranch));
      }
    }

    [DataMember]
    public string OutStatus
    {
      get
      {
        return this.OutStatusField;
      }
      set
      {
        if ((object) this.OutStatusField == (object) value)
          return;
        this.OutStatusField = value;
        this.RaisePropertyChanged(nameof (OutStatus));
      }
    }

    [DataMember]
    public int? ShiftId
    {
      get
      {
        return this.ShiftIdField;
      }
      set
      {
        if (this.ShiftIdField.Equals((object) value))
          return;
        this.ShiftIdField = value;
        this.RaisePropertyChanged(nameof (ShiftId));
      }
    }

    [DataMember]
    public int? ShiftSequence
    {
      get
      {
        return this.ShiftSequenceField;
      }
      set
      {
        if (this.ShiftSequenceField.Equals((object) value))
          return;
        this.ShiftSequenceField = value;
        this.RaisePropertyChanged(nameof (ShiftSequence));
      }
    }

    [DataMember]
    public int TotalMiles
    {
      get
      {
        return this.TotalMilesField;
      }
      set
      {
        if (this.TotalMilesField.Equals(value))
          return;
        this.TotalMilesField = value;
        this.RaisePropertyChanged(nameof (TotalMiles));
      }
    }

    [DataMember]
    public string Tractor
    {
      get
      {
        return this.TractorField;
      }
      set
      {
        if ((object) this.TractorField == (object) value)
          return;
        this.TractorField = value;
        this.RaisePropertyChanged(nameof (Tractor));
      }
    }

    [DataMember]
    public string lgh_booked_revtype1
    {
      get
      {
        return this.lgh_booked_revtype1Field;
      }
      set
      {
        if ((object) this.lgh_booked_revtype1Field == (object) value)
          return;
        this.lgh_booked_revtype1Field = value;
        this.RaisePropertyChanged(nameof (lgh_booked_revtype1));
      }
    }

    [DataMember]
    public int lgh_number
    {
      get
      {
        return this.lgh_numberField;
      }
      set
      {
        if (this.lgh_numberField.Equals(value))
          return;
        this.lgh_numberField = value;
        this.RaisePropertyChanged(nameof (lgh_number));
      }
    }

    [DataMember]
    public string lgh_type1
    {
      get
      {
        return this.lgh_type1Field;
      }
      set
      {
        if ((object) this.lgh_type1Field == (object) value)
          return;
        this.lgh_type1Field = value;
        this.RaisePropertyChanged(nameof (lgh_type1));
      }
    }

    [DataMember]
    public string lgh_type2
    {
      get
      {
        return this.lgh_type2Field;
      }
      set
      {
        if ((object) this.lgh_type2Field == (object) value)
          return;
        this.lgh_type2Field = value;
        this.RaisePropertyChanged(nameof (lgh_type2));
      }
    }

    [DataMember]
    public string lgh_type3
    {
      get
      {
        return this.lgh_type3Field;
      }
      set
      {
        if ((object) this.lgh_type3Field == (object) value)
          return;
        this.lgh_type3Field = value;
        this.RaisePropertyChanged(nameof (lgh_type3));
      }
    }

    [DataMember]
    public string lgh_type4
    {
      get
      {
        return this.lgh_type4Field;
      }
      set
      {
        if ((object) this.lgh_type4Field == (object) value)
          return;
        this.lgh_type4Field = value;
        this.RaisePropertyChanged(nameof (lgh_type4));
      }
    }
  }
}
