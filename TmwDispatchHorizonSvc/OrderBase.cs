// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.OrderBase
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
  [DataContract(Name = "OrderBase", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Dispatch")]
  [KnownType(typeof (Order))]
  [Serializable]
  public class OrderBase : ConcurrencyNestedAndValidityBase
  {
    [OptionalField]
    private DateTime AvailableDateField;
    [OptionalField]
    private string BillToField;
    [OptionalField]
    private string BookedByField;
    [OptionalField]
    private DateTime BookedDateField;
    [OptionalField]
    private string BookedRevType1Field;
    [OptionalField]
    private DateTime DatePromisedField;
    [OptionalField]
    private string FromOrderField;
    [OptionalField]
    private string InvoiceStatusField;
    [OptionalField]
    private double LengthField;
    [OptionalField]
    private string LengthUnitField;
    [OptionalField]
    private int? MaxTemperatureField;
    [OptionalField]
    private int? MinTemperatureField;
    [OptionalField]
    private double? OdMileageField;
    [OptionalField]
    private int? OdMileageIdField;
    [OptionalField]
    private string OrderByField;
    [OptionalField]
    private string OrderContactField;
    [OptionalField]
    private string OrderNumberField;
    [OptionalField]
    private string OrderSourceField;
    [OptionalField]
    private string PriorityField;
    [OptionalField]
    private string RemarkField;
    [OptionalField]
    private string Remark2Field;
    [OptionalField]
    private string RevType1Field;
    [OptionalField]
    private string RevType2Field;
    [OptionalField]
    private string RevType3Field;
    [OptionalField]
    private string RevType4Field;
    [OptionalField]
    private string RouteField;
    [OptionalField]
    private string StatusField;
    [OptionalField]
    private string SubCompanyField;
    [OptionalField]
    private string TemperatureUnitsField;
    [OptionalField]
    private string TermsField;
    [OptionalField]
    private string TimeZoneField;
    [OptionalField]
    private double? TotalMileageField;
    [OptionalField]
    private int? TotalMileageIdField;
    [OptionalField]
    private string TrlType1Field;
    [OptionalField]
    private string TrlType2Field;
    [OptionalField]
    private string TrlType3Field;
    [OptionalField]
    private string TrlType4Field;
    [OptionalField]
    private string cmd_codeField;
    [OptionalField]
    private int ord_hdrnumberField;

    [DataMember]
    public DateTime AvailableDate
    {
      get
      {
        return this.AvailableDateField;
      }
      set
      {
        if (this.AvailableDateField.Equals(value))
          return;
        this.AvailableDateField = value;
        this.RaisePropertyChanged(nameof (AvailableDate));
      }
    }

    [DataMember]
    public string BillTo
    {
      get
      {
        return this.BillToField;
      }
      set
      {
        if ((object) this.BillToField == (object) value)
          return;
        this.BillToField = value;
        this.RaisePropertyChanged(nameof (BillTo));
      }
    }

    [DataMember]
    public string BookedBy
    {
      get
      {
        return this.BookedByField;
      }
      set
      {
        if ((object) this.BookedByField == (object) value)
          return;
        this.BookedByField = value;
        this.RaisePropertyChanged(nameof (BookedBy));
      }
    }

    [DataMember]
    public DateTime BookedDate
    {
      get
      {
        return this.BookedDateField;
      }
      set
      {
        if (this.BookedDateField.Equals(value))
          return;
        this.BookedDateField = value;
        this.RaisePropertyChanged(nameof (BookedDate));
      }
    }

    [DataMember]
    public string BookedRevType1
    {
      get
      {
        return this.BookedRevType1Field;
      }
      set
      {
        if ((object) this.BookedRevType1Field == (object) value)
          return;
        this.BookedRevType1Field = value;
        this.RaisePropertyChanged(nameof (BookedRevType1));
      }
    }

    [DataMember]
    public DateTime DatePromised
    {
      get
      {
        return this.DatePromisedField;
      }
      set
      {
        if (this.DatePromisedField.Equals(value))
          return;
        this.DatePromisedField = value;
        this.RaisePropertyChanged(nameof (DatePromised));
      }
    }

    [DataMember]
    public string FromOrder
    {
      get
      {
        return this.FromOrderField;
      }
      set
      {
        if ((object) this.FromOrderField == (object) value)
          return;
        this.FromOrderField = value;
        this.RaisePropertyChanged(nameof (FromOrder));
      }
    }

    [DataMember]
    public string InvoiceStatus
    {
      get
      {
        return this.InvoiceStatusField;
      }
      set
      {
        if ((object) this.InvoiceStatusField == (object) value)
          return;
        this.InvoiceStatusField = value;
        this.RaisePropertyChanged(nameof (InvoiceStatus));
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
    public int? MaxTemperature
    {
      get
      {
        return this.MaxTemperatureField;
      }
      set
      {
        if (this.MaxTemperatureField.Equals((object) value))
          return;
        this.MaxTemperatureField = value;
        this.RaisePropertyChanged(nameof (MaxTemperature));
      }
    }

    [DataMember]
    public int? MinTemperature
    {
      get
      {
        return this.MinTemperatureField;
      }
      set
      {
        if (this.MinTemperatureField.Equals((object) value))
          return;
        this.MinTemperatureField = value;
        this.RaisePropertyChanged(nameof (MinTemperature));
      }
    }

    [DataMember]
    public double? OdMileage
    {
      get
      {
        return this.OdMileageField;
      }
      set
      {
        if (this.OdMileageField.Equals((object) value))
          return;
        this.OdMileageField = value;
        this.RaisePropertyChanged(nameof (OdMileage));
      }
    }

    [DataMember]
    public int? OdMileageId
    {
      get
      {
        return this.OdMileageIdField;
      }
      set
      {
        if (this.OdMileageIdField.Equals((object) value))
          return;
        this.OdMileageIdField = value;
        this.RaisePropertyChanged(nameof (OdMileageId));
      }
    }

    [DataMember]
    public string OrderBy
    {
      get
      {
        return this.OrderByField;
      }
      set
      {
        if ((object) this.OrderByField == (object) value)
          return;
        this.OrderByField = value;
        this.RaisePropertyChanged(nameof (OrderBy));
      }
    }

    [DataMember]
    public string OrderContact
    {
      get
      {
        return this.OrderContactField;
      }
      set
      {
        if ((object) this.OrderContactField == (object) value)
          return;
        this.OrderContactField = value;
        this.RaisePropertyChanged(nameof (OrderContact));
      }
    }

    [DataMember]
    public string OrderNumber
    {
      get
      {
        return this.OrderNumberField;
      }
      set
      {
        if ((object) this.OrderNumberField == (object) value)
          return;
        this.OrderNumberField = value;
        this.RaisePropertyChanged(nameof (OrderNumber));
      }
    }

    [DataMember]
    public string OrderSource
    {
      get
      {
        return this.OrderSourceField;
      }
      set
      {
        if ((object) this.OrderSourceField == (object) value)
          return;
        this.OrderSourceField = value;
        this.RaisePropertyChanged(nameof (OrderSource));
      }
    }

    [DataMember]
    public string Priority
    {
      get
      {
        return this.PriorityField;
      }
      set
      {
        if ((object) this.PriorityField == (object) value)
          return;
        this.PriorityField = value;
        this.RaisePropertyChanged(nameof (Priority));
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
    public string Remark2
    {
      get
      {
        return this.Remark2Field;
      }
      set
      {
        if ((object) this.Remark2Field == (object) value)
          return;
        this.Remark2Field = value;
        this.RaisePropertyChanged(nameof (Remark2));
      }
    }

    [DataMember]
    public string RevType1
    {
      get
      {
        return this.RevType1Field;
      }
      set
      {
        if ((object) this.RevType1Field == (object) value)
          return;
        this.RevType1Field = value;
        this.RaisePropertyChanged(nameof (RevType1));
      }
    }

    [DataMember]
    public string RevType2
    {
      get
      {
        return this.RevType2Field;
      }
      set
      {
        if ((object) this.RevType2Field == (object) value)
          return;
        this.RevType2Field = value;
        this.RaisePropertyChanged(nameof (RevType2));
      }
    }

    [DataMember]
    public string RevType3
    {
      get
      {
        return this.RevType3Field;
      }
      set
      {
        if ((object) this.RevType3Field == (object) value)
          return;
        this.RevType3Field = value;
        this.RaisePropertyChanged(nameof (RevType3));
      }
    }

    [DataMember]
    public string RevType4
    {
      get
      {
        return this.RevType4Field;
      }
      set
      {
        if ((object) this.RevType4Field == (object) value)
          return;
        this.RevType4Field = value;
        this.RaisePropertyChanged(nameof (RevType4));
      }
    }

    [DataMember]
    public string Route
    {
      get
      {
        return this.RouteField;
      }
      set
      {
        if ((object) this.RouteField == (object) value)
          return;
        this.RouteField = value;
        this.RaisePropertyChanged(nameof (Route));
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

    [DataMember]
    public string SubCompany
    {
      get
      {
        return this.SubCompanyField;
      }
      set
      {
        if ((object) this.SubCompanyField == (object) value)
          return;
        this.SubCompanyField = value;
        this.RaisePropertyChanged(nameof (SubCompany));
      }
    }

    [DataMember]
    public string TemperatureUnits
    {
      get
      {
        return this.TemperatureUnitsField;
      }
      set
      {
        if ((object) this.TemperatureUnitsField == (object) value)
          return;
        this.TemperatureUnitsField = value;
        this.RaisePropertyChanged(nameof (TemperatureUnits));
      }
    }

    [DataMember]
    public string Terms
    {
      get
      {
        return this.TermsField;
      }
      set
      {
        if ((object) this.TermsField == (object) value)
          return;
        this.TermsField = value;
        this.RaisePropertyChanged(nameof (Terms));
      }
    }

    [DataMember]
    public string TimeZone
    {
      get
      {
        return this.TimeZoneField;
      }
      set
      {
        if ((object) this.TimeZoneField == (object) value)
          return;
        this.TimeZoneField = value;
        this.RaisePropertyChanged(nameof (TimeZone));
      }
    }

    [DataMember]
    public double? TotalMileage
    {
      get
      {
        return this.TotalMileageField;
      }
      set
      {
        if (this.TotalMileageField.Equals((object) value))
          return;
        this.TotalMileageField = value;
        this.RaisePropertyChanged(nameof (TotalMileage));
      }
    }

    [DataMember]
    public int? TotalMileageId
    {
      get
      {
        return this.TotalMileageIdField;
      }
      set
      {
        if (this.TotalMileageIdField.Equals((object) value))
          return;
        this.TotalMileageIdField = value;
        this.RaisePropertyChanged(nameof (TotalMileageId));
      }
    }

    [DataMember]
    public string TrlType1
    {
      get
      {
        return this.TrlType1Field;
      }
      set
      {
        if ((object) this.TrlType1Field == (object) value)
          return;
        this.TrlType1Field = value;
        this.RaisePropertyChanged(nameof (TrlType1));
      }
    }

    [DataMember]
    public string TrlType2
    {
      get
      {
        return this.TrlType2Field;
      }
      set
      {
        if ((object) this.TrlType2Field == (object) value)
          return;
        this.TrlType2Field = value;
        this.RaisePropertyChanged(nameof (TrlType2));
      }
    }

    [DataMember]
    public string TrlType3
    {
      get
      {
        return this.TrlType3Field;
      }
      set
      {
        if ((object) this.TrlType3Field == (object) value)
          return;
        this.TrlType3Field = value;
        this.RaisePropertyChanged(nameof (TrlType3));
      }
    }

    [DataMember]
    public string TrlType4
    {
      get
      {
        return this.TrlType4Field;
      }
      set
      {
        if ((object) this.TrlType4Field == (object) value)
          return;
        this.TrlType4Field = value;
        this.RaisePropertyChanged(nameof (TrlType4));
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
    public int ord_hdrnumber
    {
      get
      {
        return this.ord_hdrnumberField;
      }
      set
      {
        if (this.ord_hdrnumberField.Equals(value))
          return;
        this.ord_hdrnumberField = value;
        this.RaisePropertyChanged(nameof (ord_hdrnumber));
      }
    }
  }
}
