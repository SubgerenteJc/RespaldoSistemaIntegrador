// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.DeadheadReturn
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
  [DataContract(Name = "DeadheadReturn", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.CircleOfService")]
  [Serializable]
  public class DeadheadReturn : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private DispatchHorizon TripHorizonField;
    [OptionalField]
    private int TripLghNumberField;

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
    public DispatchHorizon TripHorizon
    {
      get
      {
        return this.TripHorizonField;
      }
      set
      {
        if (this.TripHorizonField == value)
          return;
        this.TripHorizonField = value;
        this.RaisePropertyChanged(nameof (TripHorizon));
      }
    }

    [DataMember]
    public int TripLghNumber
    {
      get
      {
        return this.TripLghNumberField;
      }
      set
      {
        if (this.TripLghNumberField.Equals(value))
          return;
        this.TripLghNumberField = value;
        this.RaisePropertyChanged(nameof (TripLghNumber));
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
