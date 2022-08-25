// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.DispatchHorizon
// Assembly: Sl_Pilgrims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 918EA6D9-19C7-408C-9F5D-82D307420CD2
// Assembly location: D:\Salida\Sl_Pilgrims 05_2019\Application Files\Sl_Pilgrims_1_0_0_50\Sl_Pilgrims.exe

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace WindowsFormsApp1.TmwDispatchHorizonSvc
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "DispatchHorizon", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Dispatch")]
  [Serializable]
  public class DispatchHorizon : ConcurrencyAndValidityBase
  {
    [OptionalField]
    private List<DispatchSaveError> ErrorsField;
    [OptionalField]
    private List<ExtraDataItem> ExtraDataField;
    [OptionalField]
    private List<Move> MovesField;
    [OptionalField]
    private List<Order> OrdersField;

    [DataMember]
    public List<DispatchSaveError> Errors
    {
      get
      {
        return this.ErrorsField;
      }
      set
      {
        if (this.ErrorsField == value)
          return;
        this.ErrorsField = value;
        this.RaisePropertyChanged(nameof (Errors));
      }
    }

    [DataMember]
    public List<ExtraDataItem> ExtraData
    {
      get
      {
        return this.ExtraDataField;
      }
      set
      {
        if (this.ExtraDataField == value)
          return;
        this.ExtraDataField = value;
        this.RaisePropertyChanged(nameof (ExtraData));
      }
    }

    [DataMember]
    public List<Move> Moves
    {
      get
      {
        return this.MovesField;
      }
      set
      {
        if (this.MovesField == value)
          return;
        this.MovesField = value;
        this.RaisePropertyChanged(nameof (Moves));
      }
    }

    [DataMember]
    public List<Order> Orders
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
  }
}
