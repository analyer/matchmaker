using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class App_PublicResourcesMapConfig : EntityMappingConfiguration<App_PublicResources>
    {
        public override void Map(EntityTypeBuilder<App_PublicResources>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

