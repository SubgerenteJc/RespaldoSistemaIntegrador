// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.TMSOrderLineItemDetail
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
  [DataContract(Name = "TMSOrderLineItemDetail", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Dispatch")]
  [Serializable]
  public class TMSOrderLineItemDetail : ConcurrencyBaseNested
  {
    [OptionalField]
    private Decimal CasesField;
    [OptionalField]
    private string DeliveryCompanyIdField;
    [OptionalField]
    private string FreightClassField;
    [OptionalField]
    private Decimal ItemsField;
    [OptionalField]
    private int LineItemIdField;
    [OptionalField]
    private string LineItemType1Field;
    [OptionalField]
    private string LineItemType2Field;
    [OptionalField]
    private string LineItemType3Field;
    [OptionalField]
    private string LineItemType4Field;
    [OptionalField]
    private string LineItemType5Field;
    [OptionalField]
    private int LineNumberField;
    [OptionalField]
    private int OrderIdField;
    [OptionalField]
    private Decimal PalletsField;
    [OptionalField]
    private string PartDescriptionField;
    [OptionalField]
    private string PartNumberField;
    [OptionalField]
    private string PickupCompanyIdField;
    [OptionalField]
    private Decimal QuanityToShipField;
    [OptionalField]
    private QuanityToShipUnitEnum QuanityToShipUnitField;
    [OptionalField]
    private Decimal Quantity1Field;
    [OptionalField]
    private Decimal Quantity2Field;
    [OptionalField]
    private Decimal Quantity3Field;
    [OptionalField]
    private List<ReferenceNumber> ReferenceNumbersField;
    [OptionalField]
    private string RemarkField;
    [OptionalField]
    private string SKUField;
    [OptionalField]
    private string cmd_codeField;
    [OptionalField]
    private int? fgt_number_dropField;
    [OptionalField]
    private int? fgt_number_pickupField;
    [OptionalField]
    private int? ord_hdrnumberField;

    [DataMember]
    public Decimal Cases
    {
      get
      {
        return this.CasesField;
      }
      set
      {
        if (this.CasesField.Equals(value))
          return;
        this.CasesField = value;
        this.RaisePropertyChanged(nameof (Cases));
      }
    }

    [DataMember]
    public string DeliveryCompanyId
    {
      get
      {
        return this.DeliveryCompanyIdField;
      }
      set
      {
        if ((object) this.DeliveryCompanyIdField == (object) value)
          return;
        this.DeliveryCompanyIdField = value;
        this.RaisePropertyChanged(nameof (DeliveryCompanyId));
      }
    }

    [DataMember]
    public string FreightClass
    {
      get
      {
        return this.FreightClassField;
      }
      set
      {
        if ((object) this.FreightClassField == (object) value)
          return;
        this.FreightClassField = value;
        this.RaisePropertyChanged(nameof (FreightClass));
      }
    }

    [DataMember]
    public Decimal Items
    {
      get
      {
        return this.ItemsField;
      }
      set
      {
        if (this.ItemsField.Equals(value))
          return;
        this.ItemsField = value;
        this.RaisePropertyChanged(nameof (Items));
      }
    }

    [DataMember]
    public int LineItemId
    {
      get
      {
        return this.LineItemIdField;
      }
      set
      {
        if (this.LineItemIdField.Equals(value))
          return;
        this.LineItemIdField = value;
        this.RaisePropertyChanged(nameof (LineItemId));
      }
    }

    [DataMember]
    public string LineItemType1
    {
      get
      {
        return this.LineItemType1Field;
      }
      set
      {
        if ((object) this.LineItemType1Field == (object) value)
          return;
        this.LineItemType1Field = value;
        this.RaisePropertyChanged(nameof (LineItemType1));
      }
    }

    [DataMember]
    public string LineItemType2
    {
      get
      {
        return this.LineItemType2Field;
      }
      set
      {
        if ((object) this.LineItemType2Field == (object) value)
          return;
        this.LineItemType2Field = value;
        this.RaisePropertyChanged(nameof (LineItemType2));
      }
    }

    [DataMember]
    public string LineItemType3
    {
      get
      {
        return this.LineItemType3Field;
      }
      set
      {
        if ((object) this.LineItemType3Field == (object) value)
          return;
        this.LineItemType3Field = value;
        this.RaisePropertyChanged(nameof (LineItemType3));
      }
    }

    [DataMember]
    public string LineItemType4
    {
      get
      {
        return this.LineItemType4Field;
      }
      set
      {
        if ((object) this.LineItemType4Field == (object) value)
          return;
        this.LineItemType4Field = value;
        this.RaisePropertyChanged(nameof (LineItemType4));
      }
    }

    [DataMember]
    public string LineItemType5
    {
      get
      {
        return this.LineItemType5Field;
      }
      set
      {
        if ((object) this.LineItemType5Field == (object) value)
          return;
        this.LineItemType5Field = value;
        this.RaisePropertyChanged(nameof (LineItemType5));
      }
    }

    [DataMember]
    public int LineNumber
    {
      get
      {
        return this.LineNumberField;
      }
      set
      {
        if (this.LineNumberField.Equals(value))
          return;
        this.LineNumberField = value;
        this.RaisePropertyChanged(nameof (LineNumber));
      }
    }

    [DataMember]
    public int OrderId
    {
      get
      {
        return this.OrderIdField;
      }
      set
      {
        if (this.OrderIdField.Equals(value))
          return;
        this.OrderIdField = value;
        this.RaisePropertyChanged(nameof (OrderId));
      }
    }

    [DataMember]
    public Decimal Pallets
    {
      get
      {
        return this.PalletsField;
      }
      set
      {
        if (this.PalletsField.Equals(value))
          return;
        this.PalletsField = value;
        this.RaisePropertyChanged(nameof (Pallets));
      }
    }

    [DataMember]
    public string PartDescription
    {
      get
      {
        return this.PartDescriptionField;
      }
      set
      {
        if ((object) this.PartDescriptionField == (object) value)
          return;
        this.PartDescriptionField = value;
        this.RaisePropertyChanged(nameof (PartDescription));
      }
    }

    [DataMember]
    public string PartNumber
    {
      get
      {
        return this.PartNumberField;
      }
      set
      {
        if ((object) this.PartNumberField == (object) value)
          return;
        this.PartNumberField = value;
        this.RaisePropertyChanged(nameof (PartNumber));
      }
    }

    [DataMember]
    public string PickupCompanyId
    {
      get
      {
        return this.PickupCompanyIdField;
      }
      set
      {
        if ((object) this.PickupCompanyIdField == (object) value)
          return;
        this.PickupCompanyIdField = value;
        this.RaisePropertyChanged(nameof (PickupCompanyId));
      }
    }

    [DataMember]
    public Decimal QuanityToShip
    {
      get
      {
        return this.QuanityToShipField;
      }
      set
      {
        if (this.QuanityToShipField.Equals(value))
          return;
        this.QuanityToShipField = value;
        this.RaisePropertyChanged(nameof (QuanityToShip));
      }
    }

    [DataMember]
    public QuanityToShipUnitEnum QuanityToShipUnit
    {
      get
      {
        return this.QuanityToShipUnitField;
      }
      set
      {
        if (this.QuanityToShipUnitField.Equals((object) value))
          return;
        this.QuanityToShipUnitField = value;
        this.RaisePropertyChanged(nameof (QuanityToShipUnit));
      }
    }

    [DataMember]
    public Decimal Quantity1
    {
      get
      {
        return this.Quantity1Field;
      }
      set
      {
        if (this.Quantity1Field.Equals(value))
          return;
        this.Quantity1Field = value;
        this.RaisePropertyChanged(nameof (Quantity1));
      }
    }

    [DataMember]
    public Decimal Quantity2
    {
      get
      {
        return this.Quantity2Field;
      }
      set
      {
        if (this.Quantity2Field.Equals(value))
          return;
        this.Quantity2Field = value;
        this.RaisePropertyChanged(nameof (Quantity2));
      }
    }

    [DataMember]
    public Decimal Quantity3
    {
      get
      {
        return this.Quantity3Field;
      }
      set
      {
        if (this.Quantity3Field.Equals(value))
          return;
        this.Quantity3Field = value;
        this.RaisePropertyChanged(nameof (Quantity3));
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

    [DataMember]
    public string Remark
    {
      get
      {
        return this.RemarkField;
      }
      set
      {
        if ((object) this.RemarkField == (object) value)
          return;
        this.RemarkField = value;
        this.RaisePropertyChanged(nameof (Remark));
      }
    }

    [DataMember]
    public string SKU
    {
      get
      {
        return this.SKUField;
      }
      set
      {
        if ((object) this.SKUField == (object) value)
          return;
        this.SKUField = value;
        this.RaisePropertyChanged(nameof (SKU));
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
    public int? fgt_number_drop
    {
      get
      {
        return this.fgt_number_dropField;
      }
      set
      {
        if (this.fgt_number_dropField.Equals((object) value))
          return;
        this.fgt_number_dropField = value;
        this.RaisePropertyChanged(nameof (fgt_number_drop));
      }
    }

    [DataMember]
    public int? fgt_number_pickup
    {
      get
      {
        return this.fgt_number_pickupField;
      }
      set
      {
        if (this.fgt_number_pickupField.Equals((object) value))
          return;
        this.fgt_number_pickupField = value;
        this.RaisePropertyChanged(nameof (fgt_number_pickup));
      }
    }

    [DataMember]
    public int? ord_hdrnumber
    {
      get
      {
        return this.ord_hdrnumberField;
      }
      set
      {
        if (this.ord_hdrnumberField.Equals((object) value))
          return;
        this.ord_hdrnumberField = value;
        this.RaisePropertyChanged(nameof (ord_hdrnumber));
      }
    }
  }
}
