using Sitecore.Data.Items;
using Sitecore.Forms.Mvc.Models.Fields;
using Sitecore.Support.Forms.Mvc.Validators;
using System;

namespace Sitecore.Support.Forms.Mvc.Models.Fields
{
  public class CheckBoxListField : Sitecore.Forms.Mvc.Models.Fields.CheckBoxListField
  {
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

    public CheckBoxListField(Item item) : base(item)
    {
    }
  }
}
