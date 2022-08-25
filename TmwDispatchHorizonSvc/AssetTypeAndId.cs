// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.AssetTypeAndId
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
  [DataContract(Name = "AssetTypeAndId", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Activity")]
  [KnownType(typeof (AssetAssignment))]
  [Serializable]
  public class AssetTypeAndId : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string AssetIdField;
    [OptionalField]
    private AssetTypeEnum AssetTypeField;

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
