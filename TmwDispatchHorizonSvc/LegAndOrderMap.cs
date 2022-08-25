// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.LegAndOrderMap
// Assembly: Sl_Pilgrims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 918EA6D9-19C7-408C-9F5D-82D307420CD2
// Assembly location: D:\Salida\Sl_Pilgrims 05_2019\Application Files\Sl_Pilgrims_1_0_0_50\Sl_Pilgrims.exe

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace WindowsFormsApp1.TmwDispatchHorizonSvc
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "LegAndOrderMap", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Dispatch")]
  [Serializable]
  public class LegAndOrderMap : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private List<LegAndOrderMap.Item> LegsField;
    [OptionalField]
    private List<LegAndOrderMap.Item> OrdersField;

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
    public List<LegAndOrderMap.Item> Legs
    {
      get
      {
        return this.LegsField;
      }
      set
      {
        if (this.LegsField == value)
          return;
        this.LegsField = value;
        this.RaisePropertyChanged(nameof (Legs));
      }
    }

    [DataMember]
    public List<LegAndOrderMap.Item> Orders
    {
      get
      {
        return this.OrdersField;
      }
      set
      {
        if (this.OrdersField == value)
          return;
        this.OrdersField = value;
        this.RaisePropertyChanged(nameof (Orders));
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

    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "LegAndOrderMap.Item", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Dispatch")]
    [Serializable]
    public class Item : IExtensibleDataObject, INotifyPropertyChanged
    {
      [NonSerialized]
      private ExtensionDataObject extensionDataField;
      [OptionalField]
      private int NewValueField;
      [OptionalField]
      private int OldValueField;

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
      public int NewValue
      {
        get
        {
          return this.NewValueField;
        }
        set
        {
          if (this.NewValueField.Equals(value))
            return;
          this.NewValueField = value;
          this.RaisePropertyChanged(nameof (NewValue));
        }
      }

      [DataMember]
      public int OldValue
      {
        get
        {
          return this.OldValueField;
        }
        set
        {
          if (this.OldValueField.Equals(value))
            return;
          this.OldValueField = value;
          this.RaisePropertyChanged(nameof (OldValue));
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
}
