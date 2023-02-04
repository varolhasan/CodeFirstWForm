namespace CodeFirstWForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteKategoriTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Urunlers", "Kategori_KategoriID", "dbo.Kategoris");
            DropIndex("dbo.Urunlers", new[] { "Kategori_KategoriID" });
            DropColumn("dbo.Urunlers", "Kategori_KategoriID");
            DropTable("dbo.Kategoris");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        KategoriID = c.Int(nullable: false, identity: true),
                        KategoriAd = c.String(),
                    })
                .PrimaryKey(t => t.KategoriID);
            
            AddColumn("dbo.Urunlers", "Kategori_KategoriID", c => c.Int());
            CreateIndex("dbo.Urunlers", "Kategori_KategoriID");
            AddForeignKey("dbo.Urunlers", "Kategori_KategoriID", "dbo.Kategoris", "KategoriID");
        }
    }
}
