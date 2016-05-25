using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrossImaging
{
   public class SpecimenInfo
    {
       public PowerPathWrapper.Powerpath PP { get; set; }
       public int ID { get; set; }
       public string SpecimenLabel { get; set; }
       public string Description { get; set; }
       public override string ToString() {  return SpecimenLabel + " - " + Description;  }
       public PowerPathWrapper.PPCase ParentCase { get; set; }
    }
}
