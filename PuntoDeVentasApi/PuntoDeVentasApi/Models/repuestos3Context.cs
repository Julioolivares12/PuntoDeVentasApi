using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PuntoDeVentasApi.Models
{
    public partial class repuestos3Context : DbContext
    {
        public repuestos3Context()
        {
        }

        public repuestos3Context(DbContextOptions<repuestos3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Cargos> Cargos { get; set; }
        public virtual DbSet<Clasesvehiculos> Clasesvehiculos { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<ContactosCliente> ContactosCliente { get; set; }
        public virtual DbSet<Detalleventas> Detalleventas { get; set; }
        public virtual DbSet<DireccionesCliente> DireccionesCliente { get; set; }
        public virtual DbSet<DocumentosCliente> DocumentosCliente { get; set; }
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<Marcasvehiculos> Marcasvehiculos { get; set; }
        public virtual DbSet<Metodosdar> Metodosdar { get; set; }
        public virtual DbSet<Metodostomar> Metodostomar { get; set; }
        public virtual DbSet<Modelosvehiculos> Modelosvehiculos { get; set; }
        public virtual DbSet<Pagos> Pagos { get; set; }
        public virtual DbSet<Partesvehiculos> Partesvehiculos { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<Repuestos> Repuestos { get; set; }
        public virtual DbSet<Tipodoc> Tipodoc { get; set; }
        public virtual DbSet<Tipovehiculos> Tipovehiculos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Ventas> Ventas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-NQSS6M5\\SQLEXPRESS;Database=repuestos3;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cargos>(entity =>
            {
                entity.HasKey(e => e.IdCargo)
                    .HasName("PK__CARGOS__6F4DBE2B7FA994B9");

                entity.ToTable("CARGOS");

                entity.Property(e => e.IdCargo).HasColumnName("ID_CARGO");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(90);
            });

            modelBuilder.Entity<Clasesvehiculos>(entity =>
            {
                entity.HasKey(e => e.IdClasesveh)
                    .HasName("PK__CLASESVE__617FF1096F859055");

                entity.ToTable("CLASESVEHICULOS");

                entity.Property(e => e.IdClasesveh).HasColumnName("ID_CLASESVEH");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__CLIENTES__23A341303DFFEEDB");

                entity.ToTable("CLIENTES");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.Celular)
                    .HasColumnName("CELULAR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DirecCasa)
                    .HasColumnName("DIREC_CASA")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dui)
                    .HasColumnName("DUI")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoCivil)
                    .HasColumnName("ESTADO_CIVIL")
                    .HasMaxLength(1);

                entity.Property(e => e.Fechanac)
                    .HasColumnName("FECHANAC")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lugartrabajo)
                    .HasColumnName("LUGARTRABAJO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nit)
                    .HasColumnName("NIT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Primerapellido)
                    .HasColumnName("PRIMERAPELLIDO")
                    .HasMaxLength(25);

                entity.Property(e => e.Primernombre)
                    .HasColumnName("PRIMERNOMBRE")
                    .HasMaxLength(25);

                entity.Property(e => e.Sexo)
                    .HasColumnName("SEXO")
                    .HasMaxLength(1);

                entity.Property(e => e.TeleTrabajo)
                    .HasColumnName("TELE_TRABAJO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TelefCasa)
                    .HasColumnName("TELEF_CASA")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContactosCliente>(entity =>
            {
                entity.HasKey(e => e.IdContacto)
                    .HasName("PK__CONTACTO__8806CC1F7CD835EC");

                entity.ToTable("CONTACTOS_CLIENTE");

                entity.Property(e => e.IdContacto).HasColumnName("ID_CONTACTO");

                entity.Property(e => e.Celular)
                    .HasColumnName("CELULAR")
                    .HasMaxLength(20);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.TelCasa)
                    .HasColumnName("TEL_CASA")
                    .HasMaxLength(20);

                entity.Property(e => e.TelReferencia1)
                    .HasColumnName("TEL_REFERENCIA1")
                    .HasMaxLength(20);

                entity.Property(e => e.TelReferencia2)
                    .HasColumnName("TEL_REFERENCIA2")
                    .HasMaxLength(20);

                entity.Property(e => e.TelTrabajo)
                    .HasColumnName("TEL_TRABAJO")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Detalleventas>(entity =>
            {
                entity.HasKey(e => e.IdDetalleventa)
                    .HasName("PK__DETALLEV__575DB36A27AE3FDE");

                entity.ToTable("DETALLEVENTAS");

                entity.Property(e => e.IdDetalleventa).HasColumnName("ID_DETALLEVENTA");

                entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");

                entity.Property(e => e.Descuento)
                    .HasColumnName("DESCUENTO")
                    .HasColumnType("money");

                entity.Property(e => e.FechaPago)
                    .HasColumnName("fechaPago")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdRepuesto).HasColumnName("ID_REPUESTO");

                entity.Property(e => e.IdVenta).HasColumnName("ID_VENTA");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("money");

                entity.Property(e => e.Mes)
                    .HasColumnName("mes")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Preciounitario)
                    .HasColumnName("PRECIOUNITARIO")
                    .HasColumnType("money");

                entity.Property(e => e.Subtotalrepuesto)
                    .HasColumnName("SUBTOTALREPUESTO")
                    .HasColumnType("money");

                entity.Property(e => e.Totalrepuesto)
                    .HasColumnName("TOTALREPUESTO")
                    .HasColumnType("money");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany(p => p.Detalleventas)
                    .HasForeignKey(d => d.IdVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DETALLEVE__ID_VE__6E01572D");
            });

            modelBuilder.Entity<DireccionesCliente>(entity =>
            {
                entity.HasKey(e => e.IdDireccion)
                    .HasName("PK__DIRECCIO__FC7E9E8EBE722DC4");

                entity.ToTable("DIRECCIONES_CLIENTE");

                entity.Property(e => e.IdDireccion).HasColumnName("ID_DIRECCION");

                entity.Property(e => e.Direccioncasa)
                    .HasColumnName("DIRECCIONCASA")
                    .HasMaxLength(200);

                entity.Property(e => e.Direccioncorrespondencia)
                    .HasColumnName("DIRECCIONCORRESPONDENCIA")
                    .HasMaxLength(200);

                entity.Property(e => e.Direcciontrabajo)
                    .HasColumnName("DIRECCIONTRABAJO")
                    .HasMaxLength(200);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");
            });

            modelBuilder.Entity<DocumentosCliente>(entity =>
            {
                entity.HasKey(e => e.IdDocumento)
                    .HasName("PK__DOCUMENT__DD20AF846271269C");

                entity.ToTable("DOCUMENTOS_CLIENTE");

                entity.Property(e => e.IdDocumento).HasColumnName("ID_DOCUMENTO");

                entity.Property(e => e.Dui)
                    .HasColumnName("DUI")
                    .HasMaxLength(20);

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.Licencia)
                    .HasColumnName("LICENCIA")
                    .HasMaxLength(20);

                entity.Property(e => e.Nit)
                    .HasColumnName("NIT")
                    .HasMaxLength(20);

                entity.Property(e => e.Pasaporte)
                    .HasColumnName("PASAPORTE")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.HasKey(e => e.IdInventario)
                    .HasName("PK__INVENTAR__C7FDF206A3E75435");

                entity.ToTable("INVENTARIO");

                entity.Property(e => e.IdInventario).HasColumnName("ID_INVENTARIO");

                entity.Property(e => e.Bodega)
                    .HasColumnName("BODEGA")
                    .HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(200);

                entity.Property(e => e.Existenciasactuales).HasColumnName("EXISTENCIASACTUALES");

                entity.Property(e => e.IdRepuesto).HasColumnName("ID_REPUESTO");

                entity.Property(e => e.Totalexistencias).HasColumnName("TOTALEXISTENCIAS");

                entity.HasOne(d => d.IdRepuestoNavigation)
                    .WithMany(p => p.Inventario)
                    .HasForeignKey(d => d.IdRepuesto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INVENTARIO_REPUESTOS");
            });

            modelBuilder.Entity<Marcasvehiculos>(entity =>
            {
                entity.HasKey(e => e.IdMarcaveh)
                    .HasName("PK__MARCASVE__3BE5B905AAC908F9");

                entity.ToTable("MARCASVEHICULOS");

                entity.Property(e => e.IdMarcaveh).HasColumnName("ID_MARCAVEH");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(200);

                entity.Property(e => e.IdClasesveh).HasColumnName("ID_CLASESVEH");

                entity.Property(e => e.IdModeloveh).HasColumnName("ID_MODELOVEH");

                entity.Property(e => e.IdTipoveh).HasColumnName("ID_TIPOVEH");

                entity.HasOne(d => d.IdClasesvehNavigation)
                    .WithMany(p => p.Marcasvehiculos)
                    .HasForeignKey(d => d.IdClasesveh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MARCASVEH__ID_CL__6FE99F9F");
            });

            modelBuilder.Entity<Metodosdar>(entity =>
            {
                entity.HasKey(e => e.IdMetodo)
                    .HasName("PK__METODOSD__93F65DA795A5A75A");

                entity.ToTable("METODOSDAR");

                entity.Property(e => e.IdMetodo).HasColumnName("ID_METODO");

                entity.Property(e => e.Metodo)
                    .HasColumnName("METODO")
                    .HasMaxLength(75);
            });

            modelBuilder.Entity<Metodostomar>(entity =>
            {
                entity.HasKey(e => e.IdMetodo)
                    .HasName("PK__METODOST__93F65DA78341A1E4");

                entity.ToTable("METODOSTOMAR");

                entity.Property(e => e.IdMetodo).HasColumnName("ID_METODO");

                entity.Property(e => e.Metodo)
                    .HasColumnName("METODO")
                    .HasMaxLength(75);
            });

            modelBuilder.Entity<Modelosvehiculos>(entity =>
            {
                entity.HasKey(e => e.IdModeloveh)
                    .HasName("PK__MODELOSV__A709F230F0537742");

                entity.ToTable("MODELOSVEHICULOS");

                entity.Property(e => e.IdModeloveh).HasColumnName("ID_MODELOVEH");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Pagos>(entity =>
            {
                entity.HasKey(e => e.IdPago)
                    .HasName("PK__PAGOS__B68D23DF25CED7DB");

                entity.ToTable("PAGOS");

                entity.Property(e => e.IdPago).HasColumnName("ID_PAGO");

                entity.Property(e => e.FechePago)
                    .HasColumnName("fechePago")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdVenta).HasColumnName("ID_VENTA");

                entity.Property(e => e.Metodo)
                    .HasColumnName("METODO")
                    .HasMaxLength(200);

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(200);

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<Partesvehiculos>(entity =>
            {
                entity.HasKey(e => e.IdParteveh)
                    .HasName("PK__PARTESVE__41FD09B2E20856BF");

                entity.ToTable("PARTESVEHICULOS");

                entity.Property(e => e.IdParteveh).HasColumnName("ID_PARTEVEH");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.HasKey(e => e.IdPerfil)
                    .HasName("PK__PERFIL__90BDE809707459D1");

                entity.ToTable("PERFIL");

                entity.Property(e => e.IdPerfil).HasColumnName("ID_PERFIL");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(90);
            });

            modelBuilder.Entity<Repuestos>(entity =>
            {
                entity.HasKey(e => e.IdRepuesto)
                    .HasName("PK__REPUESTO__7844671A1FCFE4FD");

                entity.ToTable("REPUESTOS");

                entity.Property(e => e.IdRepuesto).HasColumnName("ID_REPUESTO");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(100);

                entity.Property(e => e.Descuento)
                    .HasColumnName("DESCUENTO")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.IdMarcaveh).HasColumnName("ID_MARCAVEH");

                entity.Property(e => e.IdParteveh).HasColumnName("ID_PARTEVEH");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(20);

                entity.Property(e => e.NumChasis)
                    .HasColumnName("NUM_CHASIS")
                    .HasMaxLength(50);

                entity.Property(e => e.NumMotor)
                    .HasColumnName("NUM_MOTOR")
                    .HasMaxLength(50);

                entity.Property(e => e.NumVin)
                    .HasColumnName("NUM_VIN")
                    .HasMaxLength(50);

                entity.Property(e => e.Preciocompra)
                    .HasColumnName("PRECIOCOMPRA")
                    .HasColumnType("money");

                entity.Property(e => e.Precioventa)
                    .HasColumnName("PRECIOVENTA")
                    .HasColumnType("money");

                entity.Property(e => e.Upc)
                    .HasColumnName("UPC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMarcavehNavigation)
                    .WithMany(p => p.Repuestos)
                    .HasForeignKey(d => d.IdMarcaveh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REPUESTOS__ID_MA__70DDC3D8");

                entity.HasOne(d => d.IdPartevehNavigation)
                    .WithMany(p => p.Repuestos)
                    .HasForeignKey(d => d.IdParteveh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REPUESTOS__ID_PA__71D1E811");
            });

            modelBuilder.Entity<Tipodoc>(entity =>
            {
                entity.HasKey(e => e.IdTipodoc)
                    .HasName("PK__TIPODOC__EDAE18BD276360A4");

                entity.ToTable("TIPODOC");

                entity.Property(e => e.IdTipodoc).HasColumnName("ID_TIPODOC");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Tipovehiculos>(entity =>
            {
                entity.HasKey(e => e.IdTipoveh)
                    .HasName("PK__TIPOVEHI__143D31C109852843");

                entity.ToTable("TIPOVEHICULOS");

                entity.Property(e => e.IdTipoveh).HasColumnName("ID_TIPOVEH");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__USUARIOS__91136B90FFE508E6");

                entity.ToTable("USUARIOS");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(200);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(20);

                entity.Property(e => e.EstadoCivil)
                    .HasColumnName("ESTADO_CIVIL")
                    .HasMaxLength(1);

                entity.Property(e => e.Fechanac)
                    .HasColumnName("FECHANAC")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCargo).HasColumnName("ID_CARGO");

                entity.Property(e => e.IdPerfil).HasColumnName("ID_PERFIL");

                entity.Property(e => e.Pass)
                    .HasColumnName("PASS")
                    .HasMaxLength(200);

                entity.Property(e => e.Primerapellido)
                    .HasColumnName("PRIMERAPELLIDO")
                    .HasMaxLength(25);

                entity.Property(e => e.Primernombre)
                    .HasColumnName("PRIMERNOMBRE")
                    .HasMaxLength(25);

                entity.Property(e => e.Segundoapellido)
                    .HasColumnName("SEGUNDOAPELLIDO")
                    .HasMaxLength(25);

                entity.Property(e => e.Segundonombre)
                    .HasColumnName("SEGUNDONOMBRE")
                    .HasMaxLength(25);

                entity.Property(e => e.Sexo)
                    .HasColumnName("SEXO")
                    .HasMaxLength(1);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(9);

                entity.HasOne(d => d.IdCargoNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdCargo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USUARIOS__ID_CAR__72C60C4A");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USUARIOS__ID_PER__73BA3083");
            });

            modelBuilder.Entity<Ventas>(entity =>
            {
                entity.HasKey(e => e.IdVenta)
                    .HasName("PK__VENTAS__F3B6C1B4F7804289");

                entity.ToTable("VENTAS");

                entity.Property(e => e.IdVenta).HasColumnName("ID_VENTA");

                entity.Property(e => e.Descuento)
                    .HasColumnName("DESCUENTO")
                    .HasColumnType("money");

                entity.Property(e => e.Fechaventa)
                    .HasColumnName("FECHAVENTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                entity.Property(e => e.IdTipodoc)
                    .HasColumnName("ID_TIPODOC")
                    .HasMaxLength(250);

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasColumnType("money");

                entity.Property(e => e.Montototal)
                    .HasColumnName("MONTOTOTAL")
                    .HasColumnType("money");

                entity.Property(e => e.NroCf)
                    .HasColumnName("NRO_CF")
                    .HasMaxLength(10);

                entity.Property(e => e.Nrodoc)
                    .HasColumnName("NRODOC")
                    .HasMaxLength(20);

                entity.Property(e => e.Subtotal)
                    .HasColumnName("SUBTOTAL")
                    .HasColumnType("money");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Ventas)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VENTAS__ID_CLIEN__74AE54BC");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Ventas)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VENTAS__ID_USUAR__75A278F5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
