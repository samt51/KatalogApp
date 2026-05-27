using KatalogApp.Domain.Commond;
using System.Collections.Generic;

namespace KatalogApp.Domain.Entities
{
    public class Stone : BaseEntity
    {
public decimal CostPrice { get; set; }


        public int StoneTypeId { get; set; }
        public virtual StoneType? StoneType { get; set; }

        public int UnitId { get; set; }
        public virtual Units? Units { get; set; }

        public int? StoneClarityId { get; set; }
        public virtual StoneClarity? StoneClarity { get; set; }

        public int? StoneCutId { get; set; }
        public virtual StoneCut? StoneCut { get; set; }
        
        public int? ColorId { get; set; }
        public virtual Colors? Colors { get; set; }

        public virtual ICollection<ProductStone> ProductStones { get; set; }

        public int? StoneSettingId { get; set; }
        public virtual StoneSetting? StoneSetting { get; set; }

        public int? StoneScaleId { get; set; }
        public virtual StoneScale? StoneScale { get; set; }
    }
}
