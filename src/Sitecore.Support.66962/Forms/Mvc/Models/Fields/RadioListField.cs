using Sitecore.Support.Forms.Mvc.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.Forms.Mvc.Models.Fields
{
  public class RadioListField : Sitecore.Forms.Mvc.Models.Fields.RadioListField
  {
    public RadioListField(Sitecore.Data.Items.Item item) : base(item)
    {
    }

    [DynamicRequiredCheckBoxList("IsRequired", ErrorMessage = "The {0} field is required.")]
    public override object Value
    {
      get
      {
        return base.Value;
      }

      set
      {
        base.Value = value;
      }
    }
  }
}