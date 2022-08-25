// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.ParameterMessage
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
  [DataContract(Name = "ParameterMessage", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
  [Serializable]
  public class ParameterMessage : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string ParamFailureMessageField;
    [OptionalField]
    private string ParamNameField;

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
    public string ParamFailureMessage
    {
      get
      {
        return this.ParamFailureMessageField;
      }
      set
      {
        if ((object) this.ParamFailureMessageField == (object) value)
          return;
        this.ParamFailureMessageField = value;
        this.RaisePropertyChanged(nameof (ParamFailureMessage));
      }
    }

    [DataMember]
    public string ParamName
    {
      get
      {
        return this.ParamNameField;
      }
      set
      {
        if ((object) this.ParamNameField == (object) value)
          return;
        this.ParamNameField = value;
        this.RaisePropertyChanged(nameof (ParamName));
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
