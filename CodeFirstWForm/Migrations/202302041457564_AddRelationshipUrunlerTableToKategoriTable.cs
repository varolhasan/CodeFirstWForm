namespace CodeFirstWForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationshipUrunlerTableToKategoriTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        KategoriID = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(),
                        KategoriDetay = c.String(),
                    })
                .PrimaryKey(t => t.KategoriID);
            
            AddColumn("dbo.Urunlers", "Kategori_KategoriID", c => c.Int());
            CreateIndex("dbo.Urunlers", "Kategori_KategoriID");
            AddForeignKey("dbo.Urunlers", "Kategori_KategoriID", "dbo.Kategoris", "KategoriID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urunlers", "Kategori_KategoriID", "dbo.Kategoris");
            DropIndex("dbo.Urunlers", new[] { "Kategori_KategoriID" });
            DropColumn("dbo.Urunlers", "Kategori_KategoriID");
            DropTable("dbo.Kategoris");
        }
    }
}
