// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.ValidityIssue
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
  [DataContract(Name = "ValidityIssue", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Base")]
  [Serializable]
  public class ValidityIssue : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string CategoryField;
    [OptionalField]
    private string KeyField;
    [OptionalField]
    private ValidationItemSeverity SeverityField;
    [OptionalField]
    private string TextField;

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
    public string Category
    {
      get
      {
        return this.CategoryField;
      }
      set
      {
        if ((object) this.CategoryField == (object) value)
          return;
        this.CategoryField = value;
        this.RaisePropertyChanged(nameof (Category));
      }
    }

    [DataMember]
    public string Key
    {
      get
      {
        return this.KeyField;
      }
      set
      {
        if ((object) this.KeyField == (object) value)
          return;
        this.KeyField = value;
        this.RaisePropertyChanged(nameof (Key));
      }
    }

    [DataMember]
    public ValidationItemSeverity Severity
    {
      get
      {
        return this.SeverityField;
      }
      set
      {
        if (this.SeverityField.Equals((object) value))
          return;
        this.SeverityField = value;
        this.RaisePropertyChanged(nameof (Severity));
      }
    }

    [DataMember]
    public string Text
    {
      get
      {
        return this.TextField;
      }
      set
      {
        if ((object) this.TextField == (object) value)
          return;
        this.TextField = value;
        this.RaisePropertyChanged(nameof (Text));
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
