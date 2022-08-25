// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.AdHocAddress
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
  [DataContract(Name = "AdHocAddress", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Location")]
  [Serializable]
  public class AdHocAddress : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string Address1Field;
    [OptionalField]
    private string Address2Field;
    [OptionalField]
    private int? CityIdField;
    [OptionalField]
    private string NameField;
    [OptionalField]
    private string ZipCodeField;

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
    public string Address1
    {
      get
      {
        return this.Address1Field;
      }
      set
      {
        if ((object) this.Address1Field == (object) value)
          return;
        this.Address1Field = value;
        this.RaisePropertyChanged(nameof (Address1));
      }
    }

    [DataMember]
    public string Address2
    {
      get
      {
        return this.Address2Field;
      }
      set
      {
        if ((object) this.Address2Field == (object) value)
          return;
        this.Address2Field = value;
        this.RaisePropertyChanged(nameof (Address2));
      }
    }

    [DataMember]
    public int? CityId
    {
      get
      {
        return this.CityIdField;
      }
      set
      {
        if (this.CityIdField.Equals((object) value))
          return;
        this.CityIdField = value;
        this.RaisePropertyChanged(nameof (CityId));
      }
    }

    [DataMember]
    public string Name
    {
      get
      {
        return this.NameField;
      }
      set
      {
        if ((object) this.NameField == (object) value)
          return;
        this.NameField = value;
        this.RaisePropertyChanged(nameof (Name));
      }
    }

    [DataMember]
    public string ZipCode
    {
      get
      {
        return this.ZipCodeField;
      }
      set
      {
        if ((object) this.ZipCodeField == (object) value)
          return;
        this.ZipCodeField = value;
        this.RaisePropertyChanged(nameof (ZipCode));
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
