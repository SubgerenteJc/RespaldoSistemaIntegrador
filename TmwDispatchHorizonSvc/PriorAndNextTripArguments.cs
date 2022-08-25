// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.PriorAndNextTripArguments
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
  [DataContract(Name = "PriorAndNextTripArguments", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.CircleOfService")]
  [Serializable]
  public class PriorAndNextTripArguments : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private int? CurrentLghNumberField;
    [OptionalField]
    private string Driver1Field;
    [OptionalField]
    private string Driver2Field;
    [OptionalField]
    private string TractorField;
    [OptionalField]
    private string Trailer1Field;
    [OptionalField]
    private string Trailer2Field;

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
    public int? CurrentLghNumber
    {
      get
      {
        return this.CurrentLghNumberField;
      }
      set
      {
        if (this.CurrentLghNumberField.Equals((object) value))
          return;
        this.CurrentLghNumberField = value;
        this.RaisePropertyChanged(nameof (CurrentLghNumber));
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
