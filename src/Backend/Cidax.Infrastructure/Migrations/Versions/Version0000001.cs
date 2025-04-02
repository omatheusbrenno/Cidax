using FluentMigrator;

namespace Cidax.Infrastructure.Migrations.Versions
{
    [Migration(DatabaseVersions.TABLE_LOCATION, "Cria tabela para salvar informações de Localizações")]
    public class Version0000001 : ForwardOnlyMigration
    {
        public override void Up()
        {
            Create.Table("Locations")
                .WithColumn("Id").AsGuid().PrimaryKey()
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("Category").AsInt32().Nullable()
                .WithColumn("Point").AsCustom("GEOGRAPHY(Point, 4326)").NotNullable();
        }
    }
}
