using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using DirRX.HelpDesk.Document;

namespace DirRX.HelpDesk.Client
{
  partial class DocumentActions
  {
    public virtual void Action(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      
    }

    public virtual bool CanAction(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      return true;
    }

  }

}