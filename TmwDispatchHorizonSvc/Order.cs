// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp1.TmwDispatchHorizonSvc.Order
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
  [DataContract(Name = "Order", Namespace = "http://schemas.datacontract.org/2004/07/TMWSystems.MiddleTier.Core.Contracts.Models.Dispatch")]
  [Serializable]
  public class Order : OrderBase
  {
    [OptionalField]
    private List<TMSOrderLineItemDetail> LineItemsField;
    [OptionalField]
    private List<ReferenceNumber> ReferenceNumbersField;

    [DataMember]
    public List<TMSOrderLineItemDetail> LineItems
    {
      get
      {
        return this.LineItemsField;
      }
      set
      {
        if (this.LineItemsField == value)
          return;
        this.LineItemsField = value;
        this.RaisePropertyChanged(nameof (LineItems));
      }
    }

    [DataMember]
    public List<ReferenceNumber> ReferenceNumbers
    {
      get
      {
        return this.ReferenceNumbersField;
      }
      set
      {
        if (this.ReferenceNumbersField == value)
          return;
        this.ReferenceNumbersField = value;
        this.RaisePropertyChanged(nameof (ReferenceNumbers));
      }
    }
  }
}
