// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.ExtraDataRequest
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
  [DataContract(Name = "ExtraDataRequest", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Dispatch")]
  [Serializable]
  public class ExtraDataRequest : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string ColumnNameField;
    [OptionalField]
    private ExtraDataElementEnum ElementField;
    [OptionalField]
    private string ParallelTableNameField;

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
    public string ColumnName
    {
      get
      {
        return this.ColumnNameField;
      }
      set
      {
        if ((object) this.ColumnNameField == (object) value)
          return;
        this.ColumnNameField = value;
        this.RaisePropertyChanged(nameof (ColumnName));
      }
    }

    [DataMember]
    public ExtraDataElementEnum Element
    {
      get
      {
        return this.ElementField;
      }
      set
      {
        if (this.ElementField.Equals((object) value))
          return;
        this.ElementField = value;
        this.RaisePropertyChanged(nameof (Element));
      }
    }

    [DataMember]
    public string ParallelTableName
    {
      get
      {
        return this.ParallelTableNameField;
      }
      set
      {
        if ((object) this.ParallelTableNameField == (object) value)
          return;
        this.ParallelTableNameField = value;
        this.RaisePropertyChanged(nameof (ParallelTableName));
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
