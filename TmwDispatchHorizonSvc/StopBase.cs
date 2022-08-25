// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.StopBase
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
  [DataContract(Name = "StopBase", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Dispatch")]
  [KnownType(typeof (Stop))]
  [Serializable]
  public class StopBase : ConcurrencyNestedAndValidityBase
  {
    [OptionalField]
    private DateTime ArrivalDateField;
    [OptionalField]
    private string ArrivalLateReasonField;
    [OptionalField]
    private string ArrivalLateReasonTextField;
    [OptionalField]
    private bool ArrivedField;
    [OptionalField]
    private bool CompletedField;
    [OptionalField]
    private DateTime DepartureDateField;
    [OptionalField]
    private string DepartureLateReasonField;
    [OptionalField]
    private string DepartureLateReasonTextField;
    [OptionalField]
    private double? DriveTimeField;
    [OptionalField]
    private DateTime EarliestDateField;
    [OptionalField]
    private string EventField;
    [OptionalField]
    private DateTime LatestDateField;
    [OptionalField]
    private string LoadStatusField;
    [OptionalField]
    private Location LocationField;
    [OptionalField]
    private float? MileageField;
    [OptionalField]
    private int? MileageIdField;
    [OptionalField]
    private float? OrderMileageField;
    [OptionalField]
    private int? OrderMileageIdField;
    [OptionalField]
    private float? PayMileageField;
    [OptionalField]
    private int? PayMileageIdField;
    [OptionalField]
    private string ProofOfDeliveryNameField;
    [OptionalField]
    private string StopCommentField;
    [OptionalField]
    private DateTime StopCustomerRequestDateField;
    [OptionalField]
    private string StopDepartureStatusField;
    [OptionalField]
    private DateTime? StopETAField;
    [OptionalField]
    private DateTime? StopETDField;
    [OptionalField]
    private string StopStatusField;
    [OptionalField]
    private int? StopTransferStopField;
    [OptionalField]
    private string StopType1Field;
    [OptionalField]
    private string StopType2Field;
    [OptionalField]
    private string StopType3Field;
    [OptionalField]
    private int? TractorOdometerField;
    [OptionalField]
    private string Trailer1Field;
    [OptionalField]
    private string Trailer2Field;
    [OptionalField]
    private int? lgh_numberField;
    [OptionalField]
    private int? mfh_numberField;
    [OptionalField]
    private int? ord_hdrnumberField;
    [OptionalField]
    private int? stp_numberField;

    [DataMember]
    public DateTime ArrivalDate
    {
      get
      {
        return this.ArrivalDateField;
      }
      set
      {
        if (this.ArrivalDateField.Equals(value))
          return;
        this.ArrivalDateField = value;
        this.RaisePropertyChanged(nameof (ArrivalDate));
      }
    }

    [DataMember]
    public string ArrivalLateReason
    {
      get
      {
        return this.ArrivalLateReasonField;
      }
      set
      {
        if ((object) this.ArrivalLateReasonField == (object) value)
          return;
        this.ArrivalLateReasonField = value;
        this.RaisePropertyChanged(nameof (ArrivalLateReason));
      }
    }

    [DataMember]
    public string ArrivalLateReasonText
    {
      get
      {
        return this.ArrivalLateReasonTextField;
      }
      set
      {
        if ((object) this.ArrivalLateReasonTextField == (object) value)
          return;
        this.ArrivalLateReasonTextField = value;
        this.RaisePropertyChanged(nameof (ArrivalLateReasonText));
      }
    }

    [DataMember]
    public bool Arrived
    {
      get
      {
        return this.ArrivedField;
      }
      set
      {
        if (this.ArrivedField.Equals(value))
          return;
        this.ArrivedField = value;
        this.RaisePropertyChanged(nameof (Arrived));
      }
    }

    [DataMember]
    public bool Completed
    {
      get
      {
        return this.CompletedField;
      }
      set
      {
        if (this.CompletedField.Equals(value))
          return;
        this.CompletedField = value;
        this.RaisePropertyChanged(nameof (Completed));
      }
    }

    [DataMember]
    public DateTime DepartureDate
    {
      get
      {
        return this.DepartureDateField;
      }
      set
      {
        if (this.DepartureDateField.Equals(value))
          return;
        this.DepartureDateField = value;
        this.RaisePropertyChanged(nameof (DepartureDate));
      }
    }

    [DataMember]
    public string DepartureLateReason
    {
      get
      {
        return this.DepartureLateReasonField;
      }
      set
      {
        if ((object) this.DepartureLateReasonField == (object) value)
          return;
        this.DepartureLateReasonField = value;
        this.RaisePropertyChanged(nameof (DepartureLateReason));
      }
    }

    [DataMember]
    public string DepartureLateReasonText
    {
      get
      {
        return this.DepartureLateReasonTextField;
      }
      set
      {
        if ((object) this.DepartureLateReasonTextField == (object) value)
          return;
        this.DepartureLateReasonTextField = value;
        this.RaisePropertyChanged(nameof (DepartureLateReasonText));
      }
    }

    [DataMember]
    public double? DriveTime
    {
      get
      {
        return this.DriveTimeField;
      }
      set
      {
        if (this.DriveTimeField.Equals((object) value))
          return;
        this.DriveTimeField = value;
        this.RaisePropertyChanged(nameof (DriveTime));
      }
    }

    [DataMember]
    public DateTime EarliestDate
    {
      get
      {
        return this.EarliestDateField;
      }
      set
      {
        if (this.EarliestDateField.Equals(value))
          return;
        this.EarliestDateField = value;
        this.RaisePropertyChanged(nameof (EarliestDate));
      }
    }

    [DataMember]
    public string Event
    {
      get
      {
        return this.EventField;
      }
      set
      {
        if ((object) this.EventField == (object) value)
          return;
        this.EventField = value;
        this.RaisePropertyChanged(nameof (Event));
      }
    }

    [DataMember]
    public DateTime LatestDate
    {
      get
      {
        return this.LatestDateField;
      }
      set
      {
        if (this.LatestDateField.Equals(value))
          return;
        this.LatestDateField = value;
        this.RaisePropertyChanged(nameof (LatestDate));
      }
    }

    [DataMember]
    public string LoadStatus
    {
      get
      {
        return this.LoadStatusField;
      }
      set
      {
        if ((object) this.LoadStatusField == (object) value)
          return;
        this.LoadStatusField = value;
        this.RaisePropertyChanged(nameof (LoadStatus));
      }
    }

    [DataMember]
    public Location Location
    {
      get
      {
        return this.LocationField;
      }
      set
      {
        if (this.LocationField == value)
          return;
        this.LocationField = value;
        this.RaisePropertyChanged(nameof (Location));
      }
    }

    [DataMember]
    public float? Mileage
    {
      get
      {
        return this.MileageField;
      }
      set
      {
        if (this.MileageField.Equals((object) value))
          return;
        this.MileageField = value;
        this.RaisePropertyChanged(nameof (Mileage));
      }
    }

    [DataMember]
    public int? MileageId
    {
      get
      {
        return this.MileageIdField;
      }
      set
      {
        if (this.MileageIdField.Equals((object) value))
          return;
        this.MileageIdField = value;
        this.RaisePropertyChanged(nameof (MileageId));
      }
    }

    [DataMember]
    public float? OrderMileage
    {
      get
      {
        return this.OrderMileageField;
      }
      set
      {
        if (this.OrderMileageField.Equals((object) value))
          return;
        this.OrderMileageField = value;
        this.RaisePropertyChanged(nameof (OrderMileage));
      }
    }

    [DataMember]
    public int? OrderMileageId
    {
      get
      {
        return this.OrderMileageIdField;
      }
      set
      {
        if (this.OrderMileageIdField.Equals((object) value))
          return;
        this.OrderMileageIdField = value;
        this.RaisePropertyChanged(nameof (OrderMileageId));
      }
    }

    [DataMember]
    public float? PayMileage
    {
      get
      {
        return this.PayMileageField;
      }
      set
      {
        if (this.PayMileageField.Equals((object) value))
          return;
        this.PayMileageField = value;
        this.RaisePropertyChanged(nameof (PayMileage));
      }
    }

    [DataMember]
    public int? PayMileageId
    {
      get
      {
        return this.PayMileageIdField;
      }
      set
      {
        if (this.PayMileageIdField.Equals((object) value))
          return;
        this.PayMileageIdField = value;
        this.RaisePropertyChanged(nameof (PayMileageId));
      }
    }

    [DataMember]
    public string ProofOfDeliveryName
    {
      get
      {
        return this.ProofOfDeliveryNameField;
      }
      set
      {
        if ((object) this.ProofOfDeliveryNameField == (object) value)
          return;
        this.ProofOfDeliveryNameField = value;
        this.RaisePropertyChanged(nameof (ProofOfDeliveryName));
      }
    }

    [DataMember]
    public string StopComment
    {
      get
      {
        return this.StopCommentField;
      }
      set
      {
        if ((object) this.StopCommentField == (object) value)
          return;
        this.StopCommentField = value;
        this.RaisePropertyChanged(nameof (StopComment));
      }
    }

    [DataMember]
    public DateTime StopCustomerRequestDate
    {
      get
      {
        return this.StopCustomerRequestDateField;
      }
      set
      {
        if (this.StopCustomerRequestDateField.Equals(value))
          return;
        this.StopCustomerRequestDateField = value;
        this.RaisePropertyChanged(nameof (StopCustomerRequestDate));
      }
    }

    [DataMember]
    public string StopDepartureStatus
    {
      get
      {
        return this.StopDepartureStatusField;
      }
      set
      {
        if ((object) this.StopDepartureStatusField == (object) value)
          return;
        this.StopDepartureStatusField = value;
        this.RaisePropertyChanged(nameof (StopDepartureStatus));
      }
    }

    [DataMember]
    public DateTime? StopETA
    {
      get
      {
        return this.StopETAField;
      }
      set
      {
        if (this.StopETAField.Equals((object) value))
          return;
        this.StopETAField = value;
        this.RaisePropertyChanged(nameof (StopETA));
      }
    }

    [DataMember]
    public DateTime? StopETD
    {
      get
      {
        return this.StopETDField;
      }
      set
      {
        if (this.StopETDField.Equals((object) value))
          return;
        this.StopETDField = value;
        this.RaisePropertyChanged(nameof (StopETD));
      }
    }

    [DataMember]
    public string StopStatus
    {
      get
      {
        return this.StopStatusField;
      }
      set
      {
        if ((object) this.StopStatusField == (object) value)
          return;
        this.StopStatusField = value;
        this.RaisePropertyChanged(nameof (StopStatus));
      }
    }

    [DataMember]
    public int? StopTransferStop
    {
      get
      {
        return this.StopTransferStopField;
      }
      set
      {
        if (this.StopTransferStopField.Equals((object) value))
          return;
        this.StopTransferStopField = value;
        this.RaisePropertyChanged(nameof (StopTransferStop));
      }
    }

    [DataMember]
    public string StopType1
    {
      get
      {
        return this.StopType1Field;
      }
      set
      {
        if ((object) this.StopType1Field == (object) value)
          return;
        this.StopType1Field = value;
        this.RaisePropertyChanged(nameof (StopType1));
      }
    }

    [DataMember]
    public string StopType2
    {
      get
      {
        return this.StopType2Field;
      }
      set
      {
        if ((object) this.StopType2Field == (object) value)
          return;
        this.StopType2Field = value;
        this.RaisePropertyChanged(nameof (StopType2));
      }
    }

    [DataMember]
    public string StopType3
    {
      get
      {
        return this.StopType3Field;
      }
      set
      {
        if ((object) this.StopType3Field == (object) value)
          return;
        this.StopType3Field = value;
        this.RaisePropertyChanged(nameof (StopType3));
      }
    }

    [DataMember]
    public int? TractorOdometer
    {
      get
      {
        return this.TractorOdometerField;
      }
      set
      {
        if (this.TractorOdometerField.Equals((object) value))
          return;
        this.TractorOdometerField = value;
        this.RaisePropertyChanged(nameof (TractorOdometer));
      }
    }

    [DataMember]
    public string Trailer1
    {
      get
      {
        return this.Trailer1Field;
      }
      set
      {
        if ((object) this.Trailer1Field == (object) value)
          return;
        this.Trailer1Field = value;
        this.RaisePropertyChanged(nameof (Trailer1));
      }
    }

    [DataMember]
    public string Trailer2
    {
      get
      {
        return this.Trailer2Field;
      }
      set
      {
        if ((object) this.Trailer2Field == (object) value)
          return;
        this.Trailer2Field = value;
        this.RaisePropertyChanged(nameof (Trailer2));
      }
    }

    [DataMember]
    public int? lgh_number
    {
      get
      {
        return this.lgh_numberField;
      }
      set
      {
        if (this.lgh_numberField.Equals((object) value))
          return;
        this.lgh_numberField = value;
        this.RaisePropertyChanged(nameof (lgh_number));
      }
    }

    [DataMember]
    public int? mfh_number
    {
      get
      {
        return this.mfh_numberField;
      }
      set
      {
        if (this.mfh_numberField.Equals((object) value))
          return;
        this.mfh_numberField = value;
        this.RaisePropertyChanged(nameof (mfh_number));
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

    [DataMember]
    public int? stp_number
    {
      get
      {
        return this.stp_numberField;
      }
      set
      {
        if (this.stp_numberField.Equals((object) value))
          return;
        this.stp_numberField = value;
        this.RaisePropertyChanged(nameof (stp_number));
      }
    }
  }
}
