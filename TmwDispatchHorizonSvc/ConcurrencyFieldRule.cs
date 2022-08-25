// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.ConcurrencyFieldRule
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
  [DataContract(Name = "ConcurrencyFieldRule", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Base")]
  [Serializable]
  public class ConcurrencyFieldRule : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string FieldNameField;
    [OptionalField]
    private string FieldTypeField;
    [OptionalField]
    private string ParentTypeField;
    [OptionalField]
    private ConcurrencyFieldRuleType RuleTypeField;

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
    public string FieldName
    {
      get
      {
        return this.FieldNameField;
      }
      set
      {
        if ((object) this.FieldNameField == (object) value)
          return;
        this.FieldNameField = value;
        this.RaisePropertyChanged(nameof (FieldName));
      }
    }

    [DataMember]
    public string FieldType
    {
      get
      {
        return this.FieldTypeField;
      }
      set
      {
        if ((object) this.FieldTypeField == (object) value)
          return;
        this.FieldTypeField = value;
        this.RaisePropertyChanged(nameof (FieldType));
      }
    }

    [DataMember]
    public string ParentType
    {
      get
      {
        return this.ParentTypeField;
      }
      set
      {
        if ((object) this.ParentTypeField == (object) value)
          return;
        this.ParentTypeField = value;
        this.RaisePropertyChanged(nameof (ParentType));
      }
    }

    [DataMember]
    public ConcurrencyFieldRuleType RuleType
    {
      get
      {
        return this.RuleTypeField;
      }
      set
      {
        if (this.RuleTypeField.Equals((object) value))
          return;
        this.RuleTypeField = value;
        this.RaisePropertyChanged(nameof (RuleType));
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
