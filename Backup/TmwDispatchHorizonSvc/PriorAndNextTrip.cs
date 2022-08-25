// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.PriorAndNextTrip
// Assembly: Sl_Pilgrims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 918EA6D9-19C7-408C-9F5D-82D307420CD2
// Assembly location: D:\Salida\Sl_Pilgrims 05_2019\Application Files\Sl_Pilgrims_1_0_0_50\Sl_Pilgrims.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace WindowsFormsApp1.TmwDispatchHorizonSvc
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "PriorAndNextTrip", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.CircleOfService")]
  [Serializable]
  public class PriorAndNextTrip : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private DispatchHorizon NextTripHorizonField;
    [OptionalField]
    private int NextTripLghNumberField;
    [OptionalField]
    private DispatchHorizon PriorTripHorizonField;
    [OptionalField]
    private int? PriorTripLghNumberField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get
      {
        return this.extensionDataField;
      }
      set
      {
        this.extensionDataField = value;
      }
    }

    [DataMember]
    public DispatchHorizon NextTripHorizon
    {
      get
      {
        return this.NextTripHorizonField;
      }
      set
      {
        if (this.NextTripHorizonField == value)
          return;
        this.NextTripHorizonField = value;
        this.RaisePropertyChanged(nameof (NextTripHorizon));
      }
    }

    [DataMember]
    public int NextTripLghNumber
    {
      get
      {
        return this.NextTripLghNumberField;
      }
      set
      {
        if (this.NextTripLghNumberField.Equals(value))
          return;
        this.NextTripLghNumberField = value;
        this.RaisePropertyChanged(nameof (NextTripLghNumber));
      }
    }

    [DataMember]
    public DispatchHorizon PriorTripHorizon
    {
      get
      {
        return this.PriorTripHorizonField;
      }
      set
      {
        if (this.PriorTripHorizonField == value)
          return;
        this.PriorTripHorizonField = value;
        this.RaisePropertyChanged(nameof (PriorTripHorizon));
      }
    }

    [DataMember]
    public int? PriorTripLghNumber
    {
      get
      {
        return this.PriorTripLghNumberField;
      }
      set
      {
        if (this.PriorTripLghNumberField.Equals((object) value))
          return;
        this.PriorTripLghNumberField = value;
        this.RaisePropertyChanged(nameof (PriorTripLghNumber));
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void RaisePropertyChanged(string propertyName)
    {
      PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
      if (propertyChanged == null)
        return;
      propertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
