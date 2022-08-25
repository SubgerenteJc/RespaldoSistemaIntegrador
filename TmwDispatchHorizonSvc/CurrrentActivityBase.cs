// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.CurrrentActivityBase
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
  [DataContract(Name = "CurrrentActivityBase", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Activity")]
  [KnownType(typeof (CurrentActivity))]
  [Serializable]
  public class CurrrentActivityBase : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string AssetIdField;
    [OptionalField]
    private AssetTypeEnum AssetTypeField;
    [OptionalField]
    private AssetAssignment CurrentAssignField;
    [OptionalField]
    private AssetAssignment LastAssignAllField;
    [OptionalField]
    private AssetAssignment LastAssignCompletedField;
    [OptionalField]
    private AssetAssignment NextAssignField;

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
    public string AssetId
    {
      get
      {
        return this.AssetIdField;
      }
      set
      {
        if ((object) this.AssetIdField == (object) value)
          return;
        this.AssetIdField = value;
        this.RaisePropertyChanged(nameof (AssetId));
      }
    }

    [DataMember]
    public AssetTypeEnum AssetType
    {
      get
      {
        return this.AssetTypeField;
      }
      set
      {
        if (this.AssetTypeField.Equals((object) value))
          return;
        this.AssetTypeField = value;
        this.RaisePropertyChanged(nameof (AssetType));
      }
    }

    [DataMember]
    public AssetAssignment CurrentAssign
    {
      get
      {
        return this.CurrentAssignField;
      }
      set
      {
        if (this.CurrentAssignField == value)
          return;
        this.CurrentAssignField = value;
        this.RaisePropertyChanged(nameof (CurrentAssign));
      }
    }

    [DataMember]
    public AssetAssignment LastAssignAll
    {
      get
      {
        return this.LastAssignAllField;
      }
      set
      {
        if (this.LastAssignAllField == value)
          return;
        this.LastAssignAllField = value;
        this.RaisePropertyChanged(nameof (LastAssignAll));
      }
    }

    [DataMember]
    public AssetAssignment LastAssignCompleted
    {
      get
      {
        return this.LastAssignCompletedField;
      }
      set
      {
        if (this.LastAssignCompletedField == value)
          return;
        this.LastAssignCompletedField = value;
        this.RaisePropertyChanged(nameof (LastAssignCompleted));
      }
    }

    [DataMember]
    public AssetAssignment NextAssign
    {
      get
      {
        return this.NextAssignField;
      }
      set
      {
        if (this.NextAssignField == value)
          return;
        this.NextAssignField = value;
        this.RaisePropertyChanged(nameof (NextAssign));
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
