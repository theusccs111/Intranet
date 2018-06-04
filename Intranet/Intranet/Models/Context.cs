namespace Intranet.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<GrupoAcesso> GrupoAcesso { get; set; }
        //public DbSet<UsuarioAcesso> UsuarioAcesso { get; set; }
        public DbSet<Produto> Produto { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<UsuarioAcesso>().HasKey(x => new { x.IdGrupoAcesso, x.IdUsuario });
        }
}
}
