// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.SystemsLinkAuthenticationFault
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
  [DataContract(Name = "SystemsLinkAuthenticationFault", Namespace = "TMWSystems.SystemsLink.Services.ServiceFaults")]
  [Serializable]
  public class SystemsLinkAuthenticationFault : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private long? LogIdField;
    [OptionalField]
    private string MessageField;

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
    public long? LogId
    {
      get
      {
        return this.LogIdField;
      }
      set
      {
        if (this.LogIdField.Equals((object) value))
          return;
        this.LogIdField = value;
        this.RaisePropertyChanged(nameof (LogId));
      }
    }

    [DataMember]
    public string Message
    {
      get
      {
        return this.MessageField;
      }
      set
      {
        if ((object) this.MessageField == (object) value)
          return;
        this.MessageField = value;
        this.RaisePropertyChanged(nameof (Message));
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
