// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.ValidationError
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
  [DataContract(Name = "ValidationError", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Validation")]
  [Serializable]
  public class ValidationError : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private ValidationCategoryEnum CategoryField;
    [OptionalField]
    private int ErrorNumberField;
    [OptionalField]
    private bool IgnoreField;
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
    public ValidationCategoryEnum Category
    {
      get
      {
        return this.CategoryField;
      }
      set
      {
        if (this.CategoryField.Equals((object) value))
          return;
        this.CategoryField = value;
        this.RaisePropertyChanged(nameof (Category));
      }
    }

    [DataMember]
    public int ErrorNumber
    {
      get
      {
        return this.ErrorNumberField;
      }
      set
      {
        if (this.ErrorNumberField.Equals(value))
          return;
        this.ErrorNumberField = value;
        this.RaisePropertyChanged(nameof (ErrorNumber));
      }
    }

    [DataMember]
    public bool Ignore
    {
      get
      {
        return this.IgnoreField;
      }
      set
      {
        if (this.IgnoreField.Equals(value))
          return;
        this.IgnoreField = value;
        this.RaisePropertyChanged(nameof (Ignore));
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
