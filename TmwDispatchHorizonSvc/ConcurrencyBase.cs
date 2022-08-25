// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.ConcurrencyBase
// Assembly: Sl_Pilgrims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 918EA6D9-19C7-408C-9F5D-82D307420CD2
// Assembly location: D:\Salida\Sl_Pilgrims 05_2019\Application Files\Sl_Pilgrims_1_0_0_50\Sl_Pilgrims.exe

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace WindowsFormsApp1.TmwDispatchHorizonSvc
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "ConcurrencyBase", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Base")]
  [KnownType(typeof (ConcurrencyAndValidityBase))]
  [KnownType(typeof (ValidationErrorCollection))]
  [KnownType(typeof (ValidationDispatch))]
  [KnownType(typeof (DispatchHorizon))]
  [Serializable]
  public class ConcurrencyBase : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string ControlDataField;
    [OptionalField]
    private List<ConcurrencyFieldRule> RuleDataField;

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
    public string ControlData
    {
      get
      {
        return this.ControlDataField;
      }
      set
      {
        if ((object) this.ControlDataField == (object) value)
          return;
        this.ControlDataField = value;
        this.RaisePropertyChanged(nameof (ControlData));
      }
    }

    [DataMember]
    public List<ConcurrencyFieldRule> RuleData
    {
      get
      {
        return this.RuleDataField;
      }
      set
      {
        if (this.RuleDataField == value)
          return;
        this.RuleDataField = value;
        this.RaisePropertyChanged(nameof (RuleData));
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
