// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.DispatchSaveError
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
  [DataContract(Name = "DispatchSaveError", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Dispatch")]
  [Serializable]
  public class DispatchSaveError : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string ErrorMessageField;
    [OptionalField]
    private string ErrorTypeField;
    [OptionalField]
    private bool PreventUpdateField;

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
    public string ErrorMessage
    {
      get
      {
        return this.ErrorMessageField;
      }
      set
      {
        if ((object) this.ErrorMessageField == (object) value)
          return;
        this.ErrorMessageField = value;
        this.RaisePropertyChanged(nameof (ErrorMessage));
      }
    }

    [DataMember]
    public string ErrorType
    {
      get
      {
        return this.ErrorTypeField;
      }
      set
      {
        if ((object) this.ErrorTypeField == (object) value)
          return;
        this.ErrorTypeField = value;
        this.RaisePropertyChanged(nameof (ErrorType));
      }
    }

    [DataMember]
    public bool PreventUpdate
    {
      get
      {
        return this.PreventUpdateField;
      }
      set
      {
        if (this.PreventUpdateField.Equals(value))
          return;
        this.PreventUpdateField = value;
        this.RaisePropertyChanged(nameof (PreventUpdate));
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
