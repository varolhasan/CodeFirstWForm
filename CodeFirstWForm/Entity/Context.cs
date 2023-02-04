using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWForm.Entity
{
    class Context : DbContext
    {
        DbSet<Urunler> Urunlers { get; set; }
        DbSet<Musteri> Musteris { get; set; }
    }
}
