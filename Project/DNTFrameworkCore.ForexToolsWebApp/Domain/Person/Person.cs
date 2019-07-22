using DNTFrameworkCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNTFrameworkCore.ForexToolsWebApp.Domain.Person
{
    public class Person : TrackableEntity, IHasRowVersion, ICreationTracking, IModificationTracking
    {
        public const int MaxTitleLength = 50;
        public const int MaxUrlLength = 50;
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string Family { get; set; }
        public string NormalizedFamily { get; set; }

        public byte[] RowVersion { get; set; }

    }
}
