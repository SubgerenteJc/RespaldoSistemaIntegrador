// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.ValidationReturnObject
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
  [DataContract(Name = "ValidationReturnObject", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Validation")]
  [Serializable]
  public class ValidationReturnObject : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private bool OrderSavedField;
    [OptionalField]
    private DateTime ProcessedDateField;
    [OptionalField]
    private List<ValidationError> ValidationErrorsField;

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
    public bool OrderSaved
    {
      get
      {
        return this.OrderSavedField;
      }
      set
      {
        if (this.OrderSavedField.Equals(value))
          return;
        this.OrderSavedField = value;
        this.RaisePropertyChanged(nameof (OrderSaved));
      }
    }

    [DataMember]
    public DateTime ProcessedDate
    {
      get
      {
        return this.ProcessedDateField;
      }
      set
      {
        if (this.ProcessedDateField.Equals(value))
          return;
        this.ProcessedDateField = value;
        this.RaisePropertyChanged(nameof (ProcessedDate));
      }
    }

    [DataMember]
    public List<ValidationError> ValidationErrors
    {
      get
      {
        return this.ValidationErrorsField;
      }
      set
      {
        if (this.ValidationErrorsField == value)
          return;
        this.ValidationErrorsField = value;
        this.RaisePropertyChanged(nameof (ValidationErrors));
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
