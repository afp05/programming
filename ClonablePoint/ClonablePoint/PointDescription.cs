using System;
using System.Collections.Generic;
using System.Text;

namespace ClonablePoint
{
    class PointDescription
    {
        public string PetName { get; set; }
        public Guid PointID { get; set; }
        public PointDescription()
        {
            PetName = "No-name";
            PointID = Guid.NewGuid();
        }
        
    }
}
