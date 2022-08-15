using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace gestionPedidos.Models
{
    public partial class gestionpedidoContext : DbContext
    {
        public gestionpedidoContext()
        {
        }

        public gestionpedidoContext(DbContextOptions<gestionpedidoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Articulo> Articulos { get; set; } = null!;
        public virtual DbSet<Articulosmedida> Articulosmedidas { get; set; } = null!;
        public virtual DbSet<AsignarUbicacion> AsignarUbicacions { get; set; } = null!;
        public virtual DbSet<AtencionCliente> AtencionClientes { get; set; } = null!;
        public virtual DbSet<Atencioncliente1> Atencionclientes1 { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Clientevip> Clientevips { get; set; } = null!;
        public virtual DbSet<Comentario> Comentarios { get; set; } = null!;
        public virtual DbSet<Consultacom> Consultacoms { get; set; } = null!;
        public virtual DbSet<Consultacom2> Consultacom2s { get; set; } = null!;
        public virtual DbSet<Consultum> Consulta { get; set; } = null!;
        public virtual DbSet<Contadorpedido> Contadorpedidos { get; set; } = null!;
        public virtual DbSet<DetalleAlbaranLiquidacion> DetalleAlbaranLiquidacions { get; set; } = null!;
        public virtual DbSet<DetalleFacturaLiquidacion> DetalleFacturaLiquidacions { get; set; } = null!;
        public virtual DbSet<Estanterium> Estanteria { get; set; } = null!;
        public virtual DbSet<ExportacionArticulo> ExportacionArticulos { get; set; } = null!;
        public virtual DbSet<Familiachino> Familiachinos { get; set; } = null!;
        public virtual DbSet<Fecha> Fechas { get; set; } = null!;
        public virtual DbSet<Formapago> Formapagos { get; set; } = null!;
        public virtual DbSet<ImaControlDipo> ImaControlDipos { get; set; } = null!;
        public virtual DbSet<Incidencia> Incidencias { get; set; } = null!;
        public virtual DbSet<IncidenciasDetalle> IncidenciasDetalles { get; set; } = null!;
        public virtual DbSet<Liquidacione> Liquidaciones { get; set; } = null!;
        public virtual DbSet<Nave> Naves { get; set; } = null!;
        public virtual DbSet<OficinaCabecera> OficinaCabeceras { get; set; } = null!;
        public virtual DbSet<OficinaDetalle> OficinaDetalles { get; set; } = null!;
        public virtual DbSet<Operador> Operadors { get; set; } = null!;
        public virtual DbSet<Pasillo> Pasillos { get; set; } = null!;
        public virtual DbSet<Pedidocabecera> Pedidocabeceras { get; set; } = null!;
        public virtual DbSet<Pedidocabeceradipo> Pedidocabeceradipos { get; set; } = null!;
        public virtual DbSet<Pedidocabeceraunido> Pedidocabeceraunidos { get; set; } = null!;
        public virtual DbSet<Pedidocabeceraweb> Pedidocabecerawebs { get; set; } = null!;
        public virtual DbSet<Pedidodetalledipo> Pedidodetalledipos { get; set; } = null!;
        public virtual DbSet<Pedidodetalleunido> Pedidodetalleunidos { get; set; } = null!;
        public virtual DbSet<Pedidodetalleweb> Pedidodetallewebs { get; set; } = null!;
        public virtual DbSet<Pedidomov> Pedidomovs { get; set; } = null!;
        public virtual DbSet<Pedidosdetalle> Pedidosdetalles { get; set; } = null!;
        public virtual DbSet<Poee> Poees { get; set; } = null!;
        public virtual DbSet<Poee2> Poee2s { get; set; } = null!;
        public virtual DbSet<Provincia> Provincias { get; set; } = null!;
        public virtual DbSet<Salidamadrid> Salidamadrids { get; set; } = null!;
        public virtual DbSet<Sinfoto> Sinfotos { get; set; } = null!;
        public virtual DbSet<Sitio> Sitios { get; set; } = null!;
        public virtual DbSet<Subfamiliachino> Subfamiliachinos { get; set; } = null!;
        public virtual DbSet<Sumatoriafacturapend> Sumatoriafacturapends { get; set; } = null!;
        public virtual DbSet<Temporaldipo> Temporaldipos { get; set; } = null!;
        public virtual DbSet<Temporalweb> Temporalwebs { get; set; } = null!;
        public virtual DbSet<Tipoembalaje> Tipoembalajes { get; set; } = null!;
        public virtual DbSet<Ubicacion> Ubicacions { get; set; } = null!;
        public virtual DbSet<Yewuyuan> Yewuyuans { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Articulo>(entity =>
            {
                entity.ToTable("articulo");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.Bianhao, "bianhao");

                entity.HasIndex(e => e.Codigo, "codigo")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.HasIndex(e => e.Jinyong, "jinyong");

                entity.HasIndex(e => e.MuluId, "muluID");

                entity.HasIndex(e => e.Namecn, "namecn");

                entity.HasIndex(e => e.Namees, "namees");

                entity.HasIndex(e => e.Py, "py");

                entity.HasIndex(e => e.Status, "status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Attributes)
                    .HasMaxLength(255)
                    .HasColumnName("attributes")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Baozhuangshu)
                    .HasPrecision(10, 2)
                    .HasColumnName("baozhuangshu");

                entity.Property(e => e.Beizhu)
                    .HasColumnType("text")
                    .HasColumnName("beizhu");

                entity.Property(e => e.Beizhu2)
                    .HasMaxLength(255)
                    .HasColumnName("beizhu2")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Bianhao)
                    .HasColumnName("bianhao")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Changjia)
                    .HasMaxLength(20)
                    .HasColumnName("changjia")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CodigoAnte)
                    .HasMaxLength(255)
                    .HasColumnName("codigoAnte");

                entity.Property(e => e.Cuxiao).HasColumnName("cuxiao");

                entity.Property(e => e.Des)
                    .HasPrecision(10, 2)
                    .HasColumnName("des");

                entity.Property(e => e.Des2)
                    .HasPrecision(10, 2)
                    .HasColumnName("des2");

                entity.Property(e => e.Des3)
                    .HasPrecision(10, 2)
                    .HasColumnName("des3");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha")
                    .HasDefaultValueSql("'1986-03-03 20:30:00'");

                entity.Property(e => e.FechaActualizar)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_actualizar")
                    .HasDefaultValueSql("'1983-04-19 20:30:00'");

                entity.Property(e => e.FechaC)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_c")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Jinjia)
                    .HasPrecision(10, 2)
                    .HasColumnName("jinjia");

                entity.Property(e => e.Jinyong).HasColumnName("jinyong");

                entity.Property(e => e.Kucun)
                    .HasPrecision(13, 2)
                    .HasColumnName("kucun");

                entity.Property(e => e.Kucun2)
                    .HasPrecision(13, 2)
                    .HasColumnName("kucun2");

                entity.Property(e => e.KucunWeizhi)
                    .HasMaxLength(50)
                    .HasColumnName("kucunWeizhi");

                entity.Property(e => e.Maijia)
                    .HasPrecision(10, 3)
                    .HasColumnName("maijia");

                entity.Property(e => e.Maijia2)
                    .HasPrecision(10, 3)
                    .HasColumnName("maijia2");

                entity.Property(e => e.Maijia3)
                    .HasPrecision(10, 3)
                    .HasColumnName("maijia3");

                entity.Property(e => e.Max).HasColumnName("max");

                entity.Property(e => e.Min).HasColumnName("min");

                entity.Property(e => e.Multi).HasColumnName("multi");

                entity.Property(e => e.MuluId)
                    .HasMaxLength(20)
                    .HasColumnName("muluID")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Namecn)
                    .HasColumnName("namecn")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Namees)
                    .HasColumnName("namees")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Px).HasColumnName("px");

                entity.Property(e => e.Px2).HasColumnName("px2");

                entity.Property(e => e.Py)
                    .HasColumnName("py")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Riqi)
                    .HasColumnType("datetime")
                    .HasColumnName("riqi")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SubMuluId)
                    .HasMaxLength(20)
                    .HasColumnName("subMuluID")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Tuijian).HasColumnName("tuijian");

                entity.Property(e => e.Weizhi)
                    .HasMaxLength(20)
                    .HasColumnName("weizhi");

                entity.Property(e => e.Zhuangxiangshu)
                    .HasPrecision(10, 2)
                    .HasColumnName("zhuangxiangshu");
            });

            modelBuilder.Entity<Articulosmedida>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("articulosmedidas");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.Alto).HasColumnName("alto");

                entity.Property(e => e.Ancho).HasColumnName("ancho");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(70)
                    .HasColumnName("descripcion")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Largo).HasColumnName("largo");

                entity.Property(e => e.Referencia)
                    .HasMaxLength(50)
                    .HasColumnName("referencia")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<AsignarUbicacion>(entity =>
            {
                entity.HasKey(e => e.CodAsignar)
                    .HasName("PRIMARY");

                entity.ToTable("asignar_ubicacion");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.CodAsignar).HasColumnName("cod_asignar");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(20)
                    .HasColumnName("cliente")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CodEstanteria).HasColumnName("cod_estanteria");

                entity.Property(e => e.CodNave).HasColumnName("cod_nave");

                entity.Property(e => e.CodPasillo).HasColumnName("cod_pasillo");

                entity.Property(e => e.CodUbicacion).HasColumnName("cod_ubicacion");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(20)
                    .HasColumnName("matricula")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Ocupado)
                    .HasColumnName("ocupado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Pedido)
                    .HasMaxLength(20)
                    .HasColumnName("pedido")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<AtencionCliente>(entity =>
            {
                entity.HasKey(e => e.IdAtencion)
                    .HasName("PRIMARY");

                entity.ToTable("atencion_cliente");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.IdAtencion).HasColumnName("id_atencion");

                entity.Property(e => e.AutorizaSalida)
                    .HasColumnName("autoriza_salida")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Banco)
                    .HasMaxLength(30)
                    .HasColumnName("banco")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Clienteconfirmado)
                    .HasColumnName("clienteconfirmado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Codcliente)
                    .HasMaxLength(20)
                    .HasColumnName("codcliente")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Codvendedor)
                    .HasMaxLength(20)
                    .HasColumnName("codvendedor")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EnvioCorreo)
                    .HasColumnName("envio_correo")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EnvioMensaje)
                    .HasColumnName("envio_mensaje")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EnvioWechat)
                    .HasColumnName("envio_wechat")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EstadoAtencion)
                    .HasColumnName("estado_atencion")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FechaLlamada)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_llamada");

                entity.Property(e => e.Formapago)
                    .HasMaxLength(30)
                    .HasColumnName("formapago")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.LlamadaCliente)
                    .HasColumnName("llamada_cliente")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Obs)
                    .HasColumnType("text")
                    .HasColumnName("obs")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(30)
                    .HasColumnName("usuario")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<Atencioncliente1>(entity =>
            {
                entity.HasKey(e => e.IdAtencion)
                    .HasName("PRIMARY");

                entity.ToTable("atencioncliente");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.HasIndex(e => e.NoFactura, "NoFactura");

                entity.HasIndex(e => e.Codcliente, "codcliente");

                entity.Property(e => e.IdAtencion).HasColumnName("id_atencion");

                entity.Property(e => e.AutorizaSalida)
                    .HasColumnName("autoriza_salida")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Avisocomercial)
                    .HasColumnName("avisocomercial")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Banco)
                    .HasMaxLength(30)
                    .HasColumnName("banco")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Clienteconfirmado)
                    .HasColumnName("clienteconfirmado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Codcliente)
                    .HasMaxLength(20)
                    .HasColumnName("codcliente")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Codvendedor)
                    .HasMaxLength(20)
                    .HasColumnName("codvendedor")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.EnvioCorreo)
                    .HasColumnName("envio_correo")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EnvioMensaje)
                    .HasColumnName("envio_mensaje")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EnvioWechat)
                    .HasColumnName("envio_wechat")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EstadoAtencion)
                    .HasColumnName("estado_atencion")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FechaLlamada)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_llamada");

                entity.Property(e => e.Formapago)
                    .HasMaxLength(30)
                    .HasColumnName("formapago")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.LlamadaCliente)
                    .HasColumnName("llamada_cliente")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NoFactura)
                    .HasMaxLength(20)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Obs)
                    .HasColumnType("text")
                    .HasColumnName("obs")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(30)
                    .HasColumnName("usuario")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("clientes");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.RelationKindId, "relation_kind_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(255)
                    .HasColumnName("account_name");

                entity.Property(e => e.BankAccount)
                    .HasMaxLength(255)
                    .HasColumnName("bank_account");

                entity.Property(e => e.BankName)
                    .HasMaxLength(255)
                    .HasColumnName("bank_name");

                entity.Property(e => e.CityName)
                    .HasMaxLength(255)
                    .HasColumnName("city_name");

                entity.Property(e => e.ClientAddress)
                    .HasMaxLength(255)
                    .HasColumnName("client_address");

                entity.Property(e => e.ClientConsignee)
                    .HasMaxLength(255)
                    .HasColumnName("client_consignee");

                entity.Property(e => e.ClientCredit)
                    .HasMaxLength(255)
                    .HasColumnName("client_credit");

                entity.Property(e => e.ClientEmail)
                    .HasMaxLength(255)
                    .HasColumnName("client_email");

                entity.Property(e => e.ClientFax)
                    .HasMaxLength(255)
                    .HasColumnName("client_fax");

                entity.Property(e => e.ClientGender)
                    .HasMaxLength(255)
                    .HasColumnName("client_gender");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(255)
                    .HasColumnName("client_id");

                entity.Property(e => e.ClientMobile1)
                    .HasMaxLength(255)
                    .HasColumnName("client_mobile_1");

                entity.Property(e => e.ClientMobile2)
                    .HasMaxLength(255)
                    .HasColumnName("client_mobile_2");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(255)
                    .HasColumnName("client_name");

                entity.Property(e => e.ClientPasswd)
                    .HasMaxLength(255)
                    .HasColumnName("client_passwd");

                entity.Property(e => e.ClientPec)
                    .HasMaxLength(255)
                    .HasColumnName("client_pec");

                entity.Property(e => e.ClientPostal)
                    .HasMaxLength(255)
                    .HasColumnName("client_postal");

                entity.Property(e => e.ClientQq)
                    .HasMaxLength(255)
                    .HasColumnName("client_qq");

                entity.Property(e => e.ClientRecipient)
                    .HasMaxLength(255)
                    .HasColumnName("client_recipient");

                entity.Property(e => e.ClientRemark)
                    .HasMaxLength(255)
                    .HasColumnName("client_remark");

                entity.Property(e => e.ClientTel)
                    .HasMaxLength(255)
                    .HasColumnName("client_tel");

                entity.Property(e => e.ClientTitle)
                    .HasMaxLength(255)
                    .HasColumnName("client_title");

                entity.Property(e => e.ClientUsername)
                    .HasMaxLength(255)
                    .HasColumnName("client_username");

                entity.Property(e => e.ClientWeb)
                    .HasMaxLength(255)
                    .HasColumnName("client_web");

                entity.Property(e => e.ClientWechat)
                    .HasMaxLength(255)
                    .HasColumnName("client_wechat");

                entity.Property(e => e.ContactPersonId)
                    .HasMaxLength(255)
                    .HasColumnName("contact_person_id");

                entity.Property(e => e.ContactPersonName)
                    .HasMaxLength(255)
                    .HasColumnName("contact_person_name");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(255)
                    .HasColumnName("country_name");

                entity.Property(e => e.EnterpriseStatus)
                    .HasMaxLength(255)
                    .HasColumnName("enterprise_status");

                entity.Property(e => e.GroupKindId)
                    .HasMaxLength(255)
                    .HasColumnName("group_kind_id");

                entity.Property(e => e.GroupKindName)
                    .HasMaxLength(255)
                    .HasColumnName("group_kind_name");

                entity.Property(e => e.HandlerId)
                    .HasMaxLength(255)
                    .HasColumnName("handler_id");

                entity.Property(e => e.HandlerName)
                    .HasMaxLength(255)
                    .HasColumnName("handler_name");

                entity.Property(e => e.IdCard)
                    .HasMaxLength(255)
                    .HasColumnName("id_card");

                entity.Property(e => e.IndustryKindId)
                    .HasMaxLength(255)
                    .HasColumnName("industry_kind_id");

                entity.Property(e => e.IndustryKindName)
                    .HasMaxLength(255)
                    .HasColumnName("industry_kind_name");

                entity.Property(e => e.MoneyRateId)
                    .HasMaxLength(255)
                    .HasColumnName("money_rate_id");

                entity.Property(e => e.OriginalPayable)
                    .HasMaxLength(255)
                    .HasColumnName("original_payable");

                entity.Property(e => e.OriginalReceivable)
                    .HasMaxLength(255)
                    .HasColumnName("original_receivable");

                entity.Property(e => e.PaymentKindId)
                    .HasMaxLength(255)
                    .HasColumnName("payment_kind_id");

                entity.Property(e => e.PaymentLimit)
                    .HasMaxLength(255)
                    .HasColumnName("payment_limit");

                entity.Property(e => e.Processed).HasColumnName("processed");

                entity.Property(e => e.ProvinceName)
                    .HasMaxLength(255)
                    .HasColumnName("province_name");

                entity.Property(e => e.RelationKindId).HasColumnName("relation_kind_id");

                entity.Property(e => e.RelationKindName)
                    .HasMaxLength(255)
                    .HasColumnName("relation_kind_name");

                entity.Property(e => e.ScaleKindId)
                    .HasMaxLength(255)
                    .HasColumnName("scale_kind_id");

                entity.Property(e => e.ScaleKindName)
                    .HasMaxLength(255)
                    .HasColumnName("scale_kind_name");

                entity.Property(e => e.SourceKindId)
                    .HasMaxLength(255)
                    .HasColumnName("source_kind_id");

                entity.Property(e => e.SourceKindName)
                    .HasMaxLength(255)
                    .HasColumnName("source_kind_name");

                entity.Property(e => e.SurchargeStatus)
                    .HasMaxLength(255)
                    .HasColumnName("surcharge_status");

                entity.Property(e => e.TaxNumber)
                    .HasMaxLength(255)
                    .HasColumnName("tax_number");

                entity.Property(e => e.TaxRateId)
                    .HasMaxLength(255)
                    .HasColumnName("tax_rate_id");

                entity.Property(e => e.TaxStatus)
                    .HasMaxLength(255)
                    .HasColumnName("tax_status");

                entity.Property(e => e.ValidGrade)
                    .HasMaxLength(255)
                    .HasColumnName("valid_grade");
            });

            modelBuilder.Entity<Clientevip>(entity =>
            {
                entity.ToTable("clientevip");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(20)
                    .HasColumnName("cliente")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(20)
                    .HasColumnName("usuario")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Comentario>(entity =>
            {
                entity.HasKey(e => e.Pedidokey)
                    .HasName("PRIMARY");

                entity.ToTable("comentarios");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Comen)
                    .HasMaxLength(254)
                    .HasColumnName("comen")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Comentarios)
                    .HasColumnType("text")
                    .HasColumnName("comentarios")
                    .UseCollation("utf8_bin")
                    .HasCharSet("utf8");

                entity.Property(e => e.Comentarioss)
                    .HasMaxLength(254)
                    .HasColumnName("comentarioss")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Comentariosss)
                    .HasMaxLength(1)
                    .HasColumnName("comentariosss")
                    .IsFixedLength();

                entity.Property(e => e.Comentariossss)
                    .HasMaxLength(255)
                    .HasColumnName("comentariossss")
                    .IsFixedLength()
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Comentex)
                    .HasColumnType("text")
                    .HasColumnName("comentex")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<Consultacom>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("consultacom");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.BoxNumber)
                    .HasMaxLength(50)
                    .HasColumnName("box_number");

                entity.Property(e => e.CityName)
                    .HasMaxLength(3)
                    .HasColumnName("city_name");

                entity.Property(e => e.ClientAddress)
                    .HasMaxLength(3)
                    .HasColumnName("client_address");

                entity.Property(e => e.ClientConsignee)
                    .HasMaxLength(3)
                    .HasColumnName("client_consignee");

                entity.Property(e => e.ClientDocumentId)
                    .HasMaxLength(19)
                    .HasColumnName("client_document_id");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(20)
                    .HasColumnName("client_id");

                entity.Property(e => e.ClientModel)
                    .HasMaxLength(25)
                    .HasColumnName("client_model");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(50)
                    .HasColumnName("client_name");

                entity.Property(e => e.ClientPostal)
                    .HasMaxLength(3)
                    .HasColumnName("client_postal");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(3)
                    .HasColumnName("country_name");

                entity.Property(e => e.DeliverTimestamp)
                    .HasMaxLength(50)
                    .HasColumnName("deliver_timestamp");

                entity.Property(e => e.DiscountPercent)
                    .HasMaxLength(50)
                    .HasColumnName("discount_percent");

                entity.Property(e => e.DocumentDate)
                    .HasMaxLength(13)
                    .HasColumnName("document_date");

                entity.Property(e => e.DocumentId)
                    .HasMaxLength(20)
                    .HasColumnName("document_id");

                entity.Property(e => e.DocumentKindId)
                    .HasMaxLength(17)
                    .HasColumnName("document_kind_id");

                entity.Property(e => e.DocumentKindName)
                    .HasMaxLength(20)
                    .HasColumnName("document_kind_name");

                entity.Property(e => e.DocumentRemark)
                    .HasMaxLength(3)
                    .HasColumnName("document_remark");

                entity.Property(e => e.GrossWeight)
                    .HasMaxLength(50)
                    .HasColumnName("gross_weight");

                entity.Property(e => e.HandlerId)
                    .HasMaxLength(10)
                    .HasColumnName("handler_id");

                entity.Property(e => e.HandlerName)
                    .HasMaxLength(20)
                    .HasColumnName("handler_name");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(50)
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemRemark)
                    .HasMaxLength(50)
                    .HasColumnName("item_remark");

                entity.Property(e => e.LocalDescription)
                    .HasMaxLength(150)
                    .HasColumnName("local_description");

                entity.Property(e => e.MaterialDescription)
                    .HasMaxLength(50)
                    .HasColumnName("material_description");

                entity.Property(e => e.MiddleQuantity)
                    .HasMaxLength(50)
                    .HasColumnName("middle_quantity");

                entity.Property(e => e.MoneyRateId)
                    .HasMaxLength(13)
                    .HasColumnName("money_rate_id");

                entity.Property(e => e.NetWeight)
                    .HasMaxLength(50)
                    .HasColumnName("net_weight");

                entity.Property(e => e.PackQuantity)
                    .HasMaxLength(50)
                    .HasColumnName("pack_quantity");

                entity.Property(e => e.PackRequest)
                    .HasMaxLength(50)
                    .HasColumnName("pack_request");

                entity.Property(e => e.PackVolume)
                    .HasMaxLength(50)
                    .HasColumnName("pack_volume");

                entity.Property(e => e.ProcessKind)
                    .HasMaxLength(50)
                    .HasColumnName("process_kind");

                entity.Property(e => e.ProcessProcedure)
                    .HasMaxLength(50)
                    .HasColumnName("process_procedure");

                entity.Property(e => e.ProcessUnit)
                    .HasMaxLength(50)
                    .HasColumnName("process_unit");

                entity.Property(e => e.ProduceArea)
                    .HasMaxLength(50)
                    .HasColumnName("produce_area");

                entity.Property(e => e.ProductBarcode)
                    .HasMaxLength(25)
                    .HasColumnName("product_barcode");

                entity.Property(e => e.ProductBatch)
                    .HasMaxLength(15)
                    .HasColumnName("product_batch");

                entity.Property(e => e.ProductBrand)
                    .HasMaxLength(50)
                    .HasColumnName("product_brand");

                entity.Property(e => e.ProductColor)
                    .HasMaxLength(50)
                    .HasColumnName("product_color");

                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(150)
                    .HasColumnName("product_description");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(20)
                    .HasColumnName("product_id");

                entity.Property(e => e.ProductKindId)
                    .HasMaxLength(50)
                    .HasColumnName("product_kind_id");

                entity.Property(e => e.ProductKindName)
                    .HasMaxLength(50)
                    .HasColumnName("product_kind_name");

                entity.Property(e => e.ProductMark)
                    .HasMaxLength(20)
                    .HasColumnName("product_mark");

                entity.Property(e => e.ProductModel)
                    .HasMaxLength(20)
                    .HasColumnName("product_model");

                entity.Property(e => e.ProductQuantity).HasColumnName("product_quantity");

                entity.Property(e => e.ProductSize)
                    .HasMaxLength(50)
                    .HasColumnName("product_size");

                entity.Property(e => e.ProductUnit)
                    .HasMaxLength(50)
                    .HasColumnName("product_unit");

                entity.Property(e => e.ProviderModel)
                    .HasMaxLength(25)
                    .HasColumnName("provider_model");

                entity.Property(e => e.ProvinceName)
                    .HasMaxLength(3)
                    .HasColumnName("province_name");

                entity.Property(e => e.SequenceNumber)
                    .HasMaxLength(20)
                    .HasColumnName("sequence_number");

                entity.Property(e => e.SpecDescription)
                    .HasMaxLength(50)
                    .HasColumnName("spec_description");

                entity.Property(e => e.StoreId)
                    .HasMaxLength(10)
                    .HasColumnName("store_id");

                entity.Property(e => e.StoreName)
                    .HasMaxLength(10)
                    .HasColumnName("store_name");

                entity.Property(e => e.TaxRate)
                    .HasMaxLength(50)
                    .HasColumnName("tax_rate");

                entity.Property(e => e.TechnicRequest)
                    .HasMaxLength(50)
                    .HasColumnName("technic_request");

                entity.Property(e => e.UnitPrice)
                    .HasMaxLength(50)
                    .HasColumnName("unit_price");

                entity.Property(e => e.UnitQuantity)
                    .HasMaxLength(50)
                    .HasColumnName("unit_quantity");
            });

            modelBuilder.Entity<Consultacom2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("consultacom2");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.BoxNumber)
                    .HasMaxLength(50)
                    .HasColumnName("box_number");

                entity.Property(e => e.CityName)
                    .HasMaxLength(3)
                    .HasColumnName("city_name");

                entity.Property(e => e.ClientAddress)
                    .HasMaxLength(3)
                    .HasColumnName("client_address");

                entity.Property(e => e.ClientConsignee)
                    .HasMaxLength(3)
                    .HasColumnName("client_consignee");

                entity.Property(e => e.ClientDocumentId)
                    .HasMaxLength(19)
                    .HasColumnName("client_document_id");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(20)
                    .HasColumnName("client_id");

                entity.Property(e => e.ClientModel)
                    .HasMaxLength(25)
                    .HasColumnName("client_model");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(50)
                    .HasColumnName("client_name");

                entity.Property(e => e.ClientPostal)
                    .HasMaxLength(3)
                    .HasColumnName("client_postal");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(3)
                    .HasColumnName("country_name");

                entity.Property(e => e.DeliverTimestamp)
                    .HasMaxLength(50)
                    .HasColumnName("deliver_timestamp");

                entity.Property(e => e.DiscountPercent)
                    .HasMaxLength(50)
                    .HasColumnName("discount_percent");

                entity.Property(e => e.DocumentDate)
                    .HasMaxLength(13)
                    .HasColumnName("document_date");

                entity.Property(e => e.DocumentId)
                    .HasMaxLength(20)
                    .HasColumnName("document_id");

                entity.Property(e => e.DocumentKindId)
                    .HasMaxLength(17)
                    .HasColumnName("document_kind_id");

                entity.Property(e => e.DocumentKindName)
                    .HasMaxLength(20)
                    .HasColumnName("document_kind_name");

                entity.Property(e => e.DocumentRemark)
                    .HasMaxLength(3)
                    .HasColumnName("document_remark");

                entity.Property(e => e.GrossWeight)
                    .HasMaxLength(50)
                    .HasColumnName("gross_weight");

                entity.Property(e => e.HandlerId)
                    .HasMaxLength(10)
                    .HasColumnName("handler_id");

                entity.Property(e => e.HandlerName)
                    .HasMaxLength(20)
                    .HasColumnName("handler_name");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(50)
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemRemark)
                    .HasMaxLength(50)
                    .HasColumnName("item_remark");

                entity.Property(e => e.LocalDescription)
                    .HasMaxLength(150)
                    .HasColumnName("local_description");

                entity.Property(e => e.MaterialDescription)
                    .HasMaxLength(50)
                    .HasColumnName("material_description");

                entity.Property(e => e.MiddleQuantity)
                    .HasMaxLength(50)
                    .HasColumnName("middle_quantity");

                entity.Property(e => e.MoneyRateId)
                    .HasMaxLength(13)
                    .HasColumnName("money_rate_id");

                entity.Property(e => e.NetWeight)
                    .HasMaxLength(50)
                    .HasColumnName("net_weight");

                entity.Property(e => e.PackQuantity)
                    .HasMaxLength(50)
                    .HasColumnName("pack_quantity");

                entity.Property(e => e.PackRequest)
                    .HasMaxLength(50)
                    .HasColumnName("pack_request");

                entity.Property(e => e.PackVolume)
                    .HasMaxLength(50)
                    .HasColumnName("pack_volume");

                entity.Property(e => e.ProcessKind)
                    .HasMaxLength(50)
                    .HasColumnName("process_kind");

                entity.Property(e => e.ProcessProcedure)
                    .HasMaxLength(50)
                    .HasColumnName("process_procedure");

                entity.Property(e => e.ProcessUnit)
                    .HasMaxLength(50)
                    .HasColumnName("process_unit");

                entity.Property(e => e.ProduceArea)
                    .HasMaxLength(50)
                    .HasColumnName("produce_area");

                entity.Property(e => e.ProductBarcode)
                    .HasMaxLength(25)
                    .HasColumnName("product_barcode");

                entity.Property(e => e.ProductBatch)
                    .HasMaxLength(15)
                    .HasColumnName("product_batch");

                entity.Property(e => e.ProductBrand)
                    .HasMaxLength(50)
                    .HasColumnName("product_brand");

                entity.Property(e => e.ProductColor)
                    .HasMaxLength(50)
                    .HasColumnName("product_color");

                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(150)
                    .HasColumnName("product_description");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(20)
                    .HasColumnName("product_id");

                entity.Property(e => e.ProductKindId)
                    .HasMaxLength(50)
                    .HasColumnName("product_kind_id");

                entity.Property(e => e.ProductKindName)
                    .HasMaxLength(50)
                    .HasColumnName("product_kind_name");

                entity.Property(e => e.ProductMark)
                    .HasMaxLength(20)
                    .HasColumnName("product_mark");

                entity.Property(e => e.ProductModel)
                    .HasMaxLength(20)
                    .HasColumnName("product_model");

                entity.Property(e => e.ProductQuantity).HasColumnName("product_quantity");

                entity.Property(e => e.ProductSize)
                    .HasMaxLength(50)
                    .HasColumnName("product_size");

                entity.Property(e => e.ProductUnit)
                    .HasMaxLength(50)
                    .HasColumnName("product_unit");

                entity.Property(e => e.ProviderModel)
                    .HasMaxLength(25)
                    .HasColumnName("provider_model");

                entity.Property(e => e.ProvinceName)
                    .HasMaxLength(3)
                    .HasColumnName("province_name");

                entity.Property(e => e.SequenceNumber)
                    .HasMaxLength(20)
                    .HasColumnName("sequence_number");

                entity.Property(e => e.SpecDescription)
                    .HasMaxLength(50)
                    .HasColumnName("spec_description");

                entity.Property(e => e.StoreId)
                    .HasMaxLength(10)
                    .HasColumnName("store_id");

                entity.Property(e => e.StoreName)
                    .HasMaxLength(10)
                    .HasColumnName("store_name");

                entity.Property(e => e.TaxRate)
                    .HasMaxLength(50)
                    .HasColumnName("tax_rate");

                entity.Property(e => e.TechnicRequest)
                    .HasMaxLength(50)
                    .HasColumnName("technic_request");

                entity.Property(e => e.UnitPrice)
                    .HasMaxLength(50)
                    .HasColumnName("unit_price");

                entity.Property(e => e.UnitQuantity)
                    .HasMaxLength(50)
                    .HasColumnName("unit_quantity");
            });

            modelBuilder.Entity<Consultum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("consulta");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(20)
                    .HasColumnName("client_id")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProductModel)
                    .HasMaxLength(20)
                    .HasColumnName("product_model")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ProductQuantity)
                    .HasColumnType("float(10,2)")
                    .HasColumnName("product_quantity");
            });

            modelBuilder.Entity<Contadorpedido>(entity =>
            {
                entity.ToTable("contadorpedido");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey");
            });

            modelBuilder.Entity<DetalleAlbaranLiquidacion>(entity =>
            {
                entity.HasKey(e => e.IdFacturapago)
                    .HasName("PRIMARY");

                entity.ToTable("detalle_albaran_liquidacion");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.IdFacturapago).HasColumnName("id_facturapago");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(20)
                    .HasColumnName("cliente");

                entity.Property(e => e.Comision)
                    .HasColumnName("comision")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Descuento)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("descuento")
                    .HasDefaultValueSql("'0.000'");

                entity.Property(e => e.EstadoLiqui)
                    .HasColumnName("estado_liqui")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Importe)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe")
                    .HasDefaultValueSql("'0.000'");

                entity.Property(e => e.ImporteCobrado)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe_cobrado")
                    .HasDefaultValueSql("'0.000'");

                entity.Property(e => e.ImporteComision)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe_comision")
                    .HasDefaultValueSql("'0.000'");

                entity.Property(e => e.ImporteConDes)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe_con_des")
                    .HasDefaultValueSql("'0.000'");

                entity.Property(e => e.ImportePendiente)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe_pendiente")
                    .HasDefaultValueSql("'0.000'");

                entity.Property(e => e.NroFactura)
                    .HasColumnType("mediumtext")
                    .HasColumnName("nro_factura");

                entity.Property(e => e.Obsalbaran)
                    .HasColumnType("mediumtext")
                    .HasColumnName("obsalbaran");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey");

                entity.Property(e => e.SituacionPago)
                    .HasMaxLength(25)
                    .HasColumnName("situacion_pago");

                entity.Property(e => e.Vendedor)
                    .HasMaxLength(20)
                    .HasColumnName("vendedor");
            });

            modelBuilder.Entity<DetalleFacturaLiquidacion>(entity =>
            {
                entity.HasKey(e => e.IdFacturapago)
                    .HasName("PRIMARY");

                entity.ToTable("detalle_factura_liquidacion");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.IdFacturapago).HasColumnName("id_facturapago");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(20)
                    .HasColumnName("cliente");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comision)
                    .HasColumnName("comision")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Conductor)
                    .HasMaxLength(25)
                    .HasColumnName("conductor");

                entity.Property(e => e.DejarPedido)
                    .HasColumnName("dejar_pedido")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Descuento)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("descuento")
                    .HasDefaultValueSql("'0.000'");

                entity.Property(e => e.EstadoAceptado)
                    .HasColumnName("estado_aceptado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EstadoEnviado)
                    .HasColumnName("estado_enviado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EstadoEtiquetado)
                    .HasColumnName("estado_etiquetado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EstadoLiqui)
                    .HasColumnName("estado_liqui")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_ingreso");

                entity.Property(e => e.FinalizadoParcial)
                    .HasColumnName("finalizado_parcial")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Horallegadaempresa)
                    .HasMaxLength(5)
                    .HasColumnName("horallegadaempresa");

                entity.Property(e => e.Horasalidaempresa)
                    .HasMaxLength(5)
                    .HasColumnName("horasalidaempresa");

                entity.Property(e => e.Importe)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe")
                    .HasDefaultValueSql("'0.000'");

                entity.Property(e => e.ImporteCobrado)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe_cobrado")
                    .HasDefaultValueSql("'0.000'");

                entity.Property(e => e.ImporteComision)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe_comision")
                    .HasDefaultValueSql("'0.000'");

                entity.Property(e => e.ImporteConDes)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe_con_des")
                    .HasDefaultValueSql("'0.000'");

                entity.Property(e => e.ImportePendiente)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe_pendiente")
                    .HasDefaultValueSql("'0.000'");

                entity.Property(e => e.Kmllegadaempresa).HasColumnName("kmllegadaempresa");

                entity.Property(e => e.Kmsalidaempresa).HasColumnName("kmsalidaempresa");

                entity.Property(e => e.LiquiOsbpago)
                    .HasMaxLength(255)
                    .HasColumnName("liqui_osbpago");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(25)
                    .HasColumnName("matricula");

                entity.Property(e => e.Namecliente)
                    .HasMaxLength(50)
                    .HasColumnName("namecliente");

                entity.Property(e => e.NroFactura)
                    .HasColumnType("mediumtext")
                    .HasColumnName("nro_factura");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey");

                entity.Property(e => e.SituacionPago)
                    .HasMaxLength(25)
                    .HasColumnName("situacion_pago");

                entity.Property(e => e.UsuarioAutorizaconta)
                    .HasMaxLength(50)
                    .HasColumnName("usuario_autorizaconta");

                entity.Property(e => e.Vendedor)
                    .HasMaxLength(20)
                    .HasColumnName("vendedor");
            });

            modelBuilder.Entity<Estanterium>(entity =>
            {
                entity.HasKey(e => e.CodEstanteria)
                    .HasName("PRIMARY");

                entity.ToTable("estanteria");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.CodEstanteria).HasColumnName("cod_estanteria");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.DescripcionLarga)
                    .HasMaxLength(20)
                    .HasColumnName("descripcion_larga");
            });

            modelBuilder.Entity<ExportacionArticulo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("exportacion_articulos");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.Codigbarra)
                    .HasMaxLength(150)
                    .HasColumnName("codigbarra");

                entity.Property(e => e.Ean)
                    .HasMaxLength(20)
                    .HasColumnName("ean");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .HasColumnName("estado");

                entity.Property(e => e.Longitud).HasColumnName("longitud");

                entity.Property(e => e.Referencia)
                    .HasMaxLength(150)
                    .HasColumnName("referencia");
            });

            modelBuilder.Entity<Familiachino>(entity =>
            {
                entity.ToTable("familiachino");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.HasIndex(e => e.MuluId, "muluID")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "name");

                entity.HasIndex(e => e.Px, "px");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Beizhu)
                    .HasColumnType("text")
                    .HasColumnName("beizhu");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha")
                    .HasDefaultValueSql("'1986-03-03 20:30:00'");

                entity.Property(e => e.Jinyong).HasColumnName("jinyong");

                entity.Property(e => e.MuluId)
                    .HasMaxLength(20)
                    .HasColumnName("muluID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Px).HasColumnName("px");

                entity.Property(e => e.Py)
                    .HasMaxLength(50)
                    .HasColumnName("py");
            });

            modelBuilder.Entity<Fecha>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fecha");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(20)
                    .HasColumnName("cliente");

                entity.Property(e => e.Fechaenvio)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaenvio");

                entity.Property(e => e.Jinez)
                    .HasColumnType("float(10,2)")
                    .HasColumnName("jinez");

                entity.Property(e => e.Namecliente)
                    .HasMaxLength(40)
                    .HasColumnName("namecliente");

                entity.Property(e => e.Namevendedor)
                    .HasMaxLength(35)
                    .HasColumnName("namevendedor");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(25)
                    .HasColumnName("pedidokey");

                entity.Property(e => e.Vendedor)
                    .HasMaxLength(20)
                    .HasColumnName("vendedor");
            });

            modelBuilder.Entity<Formapago>(entity =>
            {
                entity.HasKey(e => e.IdForma)
                    .HasName("PRIMARY");

                entity.ToTable("formapago");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.IdForma).HasColumnName("id_forma");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(20)
                    .HasColumnName("cliente");

                entity.Property(e => e.Formapago1)
                    .HasMaxLength(25)
                    .HasColumnName("formapago");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(25)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<ImaControlDipo>(entity =>
            {
                entity.HasKey(e => e.Item)
                    .HasName("PRIMARY");

                entity.ToTable("ima_control_dipo");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.Item).HasColumnName("item");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(20)
                    .HasColumnName("codigo");
            });

            modelBuilder.Entity<Incidencia>(entity =>
            {
                entity.HasKey(e => e.IdIncidencias)
                    .HasName("PRIMARY");

                entity.ToTable("incidencias");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.IdIncidencias)
                    .ValueGeneratedNever()
                    .HasColumnName("id_incidencias");

                entity.Property(e => e.ClienteIncidencia)
                    .HasMaxLength(20)
                    .HasColumnName("cliente_incidencia");

                entity.Property(e => e.CodCliente)
                    .HasMaxLength(20)
                    .HasColumnName("cod_cliente");

                entity.Property(e => e.ComercialIncidencia)
                    .HasMaxLength(20)
                    .HasColumnName("comercial_incidencia");

                entity.Property(e => e.DescriIncidencia)
                    .HasColumnType("mediumtext")
                    .HasColumnName("descri_incidencia");

                entity.Property(e => e.Devolucion)
                    .HasMaxLength(60)
                    .HasColumnName("devolucion");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(60)
                    .HasColumnName("empresa");

                entity.Property(e => e.ErrorEnvio)
                    .HasMaxLength(60)
                    .HasColumnName("error_envio");

                entity.Property(e => e.ErrorEnviocliente)
                    .HasMaxLength(60)
                    .HasColumnName("error_enviocliente");

                entity.Property(e => e.EstadoIncidencia)
                    .HasMaxLength(7)
                    .HasColumnName("estado_incidencia");

                entity.Property(e => e.FaltaMercancia)
                    .HasMaxLength(60)
                    .HasColumnName("falta_mercancia");

                entity.Property(e => e.FechaIncidencia)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_incidencia");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_modificacion");

                entity.Property(e => e.FecharesueltoInci)
                    .HasColumnType("datetime")
                    .HasColumnName("fecharesuelto_inci");

                entity.Property(e => e.Firmorecibo)
                    .HasMaxLength(10)
                    .HasColumnName("firmorecibo");

                entity.Property(e => e.IncidenciaNumero)
                    .HasMaxLength(20)
                    .HasColumnName("incidencia_numero");

                entity.Property(e => e.Numero).HasColumnName("numero");

                entity.Property(e => e.Reclamacion)
                    .HasMaxLength(60)
                    .HasColumnName("reclamacion");

                entity.Property(e => e.RetrasoEntrega)
                    .HasMaxLength(60)
                    .HasColumnName("retraso_entrega");

                entity.Property(e => e.TipoIncidencia)
                    .HasMaxLength(35)
                    .HasColumnName("tipo_incidencia");

                entity.Property(e => e.UsuarioIncidencia)
                    .HasMaxLength(50)
                    .HasColumnName("usuario_incidencia");

                entity.Property(e => e.UsuarioModificacion)
                    .HasMaxLength(40)
                    .HasColumnName("usuario_modificacion");

                entity.Property(e => e.UsuariofinIncidencia)
                    .HasMaxLength(50)
                    .HasColumnName("usuariofin_incidencia");
            });

            modelBuilder.Entity<IncidenciasDetalle>(entity =>
            {
                entity.HasKey(e => e.Item)
                    .HasName("PRIMARY");

                entity.ToTable("incidencias_detalle");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.Item).HasColumnName("item");

                entity.Property(e => e.Articulo)
                    .HasMaxLength(20)
                    .HasColumnName("articulo");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion");

                entity.Property(e => e.IdIncidencias).HasColumnName("id_incidencias");

                entity.Property(e => e.IncidenciaNumero)
                    .HasMaxLength(20)
                    .HasColumnName("incidencia_numero");
            });

            modelBuilder.Entity<Liquidacione>(entity =>
            {
                entity.HasKey(e => e.Idliqui)
                    .HasName("PRIMARY");

                entity.ToTable("liquidaciones");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.Idliqui).HasColumnName("idliqui");

                entity.Property(e => e.Agencia)
                    .HasColumnType("mediumtext")
                    .HasColumnName("agencia");

                entity.Property(e => e.Bultos).HasColumnName("bultos");

                entity.Property(e => e.CodCliente)
                    .HasMaxLength(20)
                    .HasColumnName("cod_cliente");

                entity.Property(e => e.CodVendedor)
                    .HasMaxLength(20)
                    .HasColumnName("cod_vendedor");

                entity.Property(e => e.Comision).HasColumnName("comision");

                entity.Property(e => e.Cp)
                    .HasMaxLength(10)
                    .HasColumnName("cp");

                entity.Property(e => e.Descuento).HasColumnName("descuento");

                entity.Property(e => e.Devolucion)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("devolucion");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(60)
                    .HasColumnName("direccion");

                entity.Property(e => e.EstadoLiquidacion)
                    .HasColumnName("estado_liquidacion")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FechaEnvio)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_envio");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_factura");

                entity.Property(e => e.FechaPedido)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_pedido");

                entity.Property(e => e.ImporteCobrado)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe_cobrado");

                entity.Property(e => e.ImporteComision)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe_comision");

                entity.Property(e => e.ImporteConDescuento)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe_con_descuento");

                entity.Property(e => e.ImporteFactura)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe_factura");

                entity.Property(e => e.ImportePedido)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe_pedido");

                entity.Property(e => e.ImportePendiente)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe_pendiente");

                entity.Property(e => e.Mediopalet).HasColumnName("mediopalet");

                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(120)
                    .HasColumnName("nombre_cliente");

                entity.Property(e => e.NumeroFactura).HasColumnName("numero_factura");

                entity.Property(e => e.Obs)
                    .HasColumnType("mediumtext")
                    .HasColumnName("obs");

                entity.Property(e => e.Palet).HasColumnName("palet");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey");

                entity.Property(e => e.Provincia)
                    .HasMaxLength(40)
                    .HasColumnName("provincia");

                entity.Property(e => e.SituacionPago)
                    .HasMaxLength(15)
                    .HasColumnName("situacion_pago");

                entity.Property(e => e.Telefono)
                    .HasColumnType("mediumtext")
                    .HasColumnName("telefono");

                entity.Property(e => e.TipoEnvio)
                    .HasMaxLength(20)
                    .HasColumnName("tipo_envio");

                entity.Property(e => e.Vendedor)
                    .HasMaxLength(40)
                    .HasColumnName("vendedor");
            });

            modelBuilder.Entity<Nave>(entity =>
            {
                entity.HasKey(e => e.CodNave)
                    .HasName("PRIMARY");

                entity.ToTable("nave");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.CodNave).HasColumnName("cod_nave");

                entity.Property(e => e.DescripcionCorta)
                    .HasMaxLength(1)
                    .HasColumnName("descripcion_corta")
                    .IsFixedLength();

                entity.Property(e => e.DescripcionLarga)
                    .HasMaxLength(15)
                    .HasColumnName("descripcion_larga");
            });

            modelBuilder.Entity<OficinaCabecera>(entity =>
            {
                entity.HasKey(e => e.Pedidocodigo)
                    .HasName("PRIMARY");

                entity.ToTable("oficina_cabecera");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.HasIndex(e => e.Pedidokey, "pedidokey");

                entity.Property(e => e.Pedidocodigo).HasColumnName("pedidocodigo");

                entity.Property(e => e.CodCliente)
                    .HasMaxLength(20)
                    .HasColumnName("cod_cliente")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CodRepresentante)
                    .HasMaxLength(20)
                    .HasColumnName("cod_representante")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(250)
                    .HasColumnName("comentario")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(5)
                    .HasColumnName("empresa");

                entity.Property(e => e.Enviado).HasColumnName("enviado");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.Namecliente)
                    .HasMaxLength(50)
                    .HasColumnName("namecliente")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasDefaultValueSql("'1500000000'");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Representante)
                    .HasMaxLength(50)
                    .HasColumnName("representante")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Total)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("total");
            });

            modelBuilder.Entity<OficinaDetalle>(entity =>
            {
                entity.ToTable("oficina_detalle");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.HasIndex(e => e.Pedidokey, "pedidokey");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Caja).HasColumnName("caja");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CodArticulo)
                    .HasMaxLength(20)
                    .HasColumnName("cod_articulo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(50)
                    .HasColumnName("cod_barras")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Descuento)
                    .HasColumnType("float(10,2)")
                    .HasColumnName("descuento");

                entity.Property(e => e.Importe)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe");

                entity.Property(e => e.Linea).HasColumnName("linea");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(25)
                    .HasColumnName("ubicacion")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<Operador>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PRIMARY");

                entity.ToTable("operador");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Activado)
                    .HasMaxLength(2)
                    .HasColumnName("activado");

                entity.Property(e => e.Administrador)
                    .HasColumnName("administrador")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Almacen)
                    .HasColumnName("almacen")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Caja)
                    .HasColumnName("caja")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Clave)
                    .HasMaxLength(50)
                    .HasColumnName("clave");

                entity.Property(e => e.Conductor)
                    .HasColumnName("conductor")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Embalaje)
                    .HasColumnName("embalaje")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(5)
                    .HasColumnName("empresa");

                entity.Property(e => e.ExpandirPedido)
                    .HasColumnName("expandir_pedido")
                    .HasDefaultValueSql("'0'")
                    .HasComment("habilita el boton para que pase los pedidos a caja y embalaje");

                entity.Property(e => e.Informes)
                    .HasColumnName("informes")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Nivel)
                    .HasMaxLength(13)
                    .HasColumnName("nivel");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .HasColumnName("nombre");

                entity.Property(e => e.Oficina)
                    .HasColumnName("oficina")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Operadortoro)
                    .HasColumnName("operadortoro")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Pedidoleon)
                    .HasColumnName("pedidoleon")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Pedidosalmacen)
                    .HasColumnName("pedidosalmacen")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Pedidostienda)
                    .HasColumnName("pedidostienda")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Recogida)
                    .HasColumnName("recogida")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(9)
                    .HasColumnName("sexo");

                entity.Property(e => e.Superusuario)
                    .HasColumnName("superusuario")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<Pasillo>(entity =>
            {
                entity.HasKey(e => e.CodPasillo)
                    .HasName("PRIMARY");

                entity.ToTable("pasillo");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.CodPasillo).HasColumnName("cod_pasillo");

                entity.Property(e => e.DescripcionCorta)
                    .HasMaxLength(2)
                    .HasColumnName("descripcion_corta")
                    .IsFixedLength();

                entity.Property(e => e.DescripcionLarga)
                    .HasMaxLength(15)
                    .HasColumnName("descripcion_larga");
            });

            modelBuilder.Entity<Pedidocabecera>(entity =>
            {
                entity.HasKey(e => new { e.Pedidocodigo, e.CodCliente, e.Pedidokey2 })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("pedidocabecera");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.Pedidocodigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("pedidocodigo");

                entity.Property(e => e.CodCliente)
                    .HasMaxLength(20)
                    .HasColumnName("cod_cliente")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Pedidokey2)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey2")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Borrado)
                    .HasColumnName("borrado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CodRepresentante)
                    .HasMaxLength(20)
                    .HasColumnName("cod_representante")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(250)
                    .HasColumnName("comentario")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Enviado)
                    .HasColumnName("enviado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.Namecliente)
                    .HasMaxLength(50)
                    .HasColumnName("namecliente")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasDefaultValueSql("'1500000000'");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Representante)
                    .HasMaxLength(50)
                    .HasColumnName("representante")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Total)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("total");

                entity.Property(e => e.Unir)
                    .HasColumnName("unir")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Pedidocabeceradipo>(entity =>
            {
                entity.HasKey(e => new { e.Pedidocodigo, e.CodCliente, e.Pedidokey })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("pedidocabeceradipo");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.HasIndex(e => e.FechaCreacion, "cod_cliente");

                entity.HasIndex(e => e.Pedidokey, "pedidokey");

                entity.Property(e => e.Pedidocodigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("pedidocodigo");

                entity.Property(e => e.CodCliente)
                    .HasMaxLength(20)
                    .HasColumnName("cod_cliente")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CodRepresentante)
                    .HasMaxLength(20)
                    .HasColumnName("cod_representante")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(250)
                    .HasColumnName("comentario")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Dejapedido)
                    .HasColumnName("dejapedido")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Enviado)
                    .HasColumnName("enviado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.Namecliente)
                    .HasMaxLength(50)
                    .HasColumnName("namecliente")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasDefaultValueSql("'1500000000'");

                entity.Property(e => e.Representante)
                    .HasMaxLength(50)
                    .HasColumnName("representante")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Total)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("total");
            });

            modelBuilder.Entity<Pedidocabeceraunido>(entity =>
            {
                entity.HasKey(e => e.Pedidocodigo)
                    .HasName("PRIMARY");

                entity.ToTable("pedidocabeceraunido");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.Pedidocodigo).HasColumnName("pedidocodigo");

                entity.Property(e => e.CodCliente)
                    .HasMaxLength(20)
                    .HasColumnName("cod_cliente")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CodRepresentante)
                    .HasMaxLength(20)
                    .HasColumnName("cod_representante")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(250)
                    .HasColumnName("comentario")
                    .UseCollation("utf8_unicode_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Dejapedido)
                    .HasColumnName("dejapedido")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Enviado)
                    .HasColumnName("enviado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.Namecliente)
                    .HasMaxLength(50)
                    .HasColumnName("namecliente")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasDefaultValueSql("'1500000000'");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Representante)
                    .HasMaxLength(50)
                    .HasColumnName("representante")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Total)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("total");
            });

            modelBuilder.Entity<Pedidocabeceraweb>(entity =>
            {
                entity.HasKey(e => new { e.Pedidocodigo, e.CodCliente, e.Pedidokey })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("pedidocabeceraweb");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.HasIndex(e => e.CodCliente, "cod_cliente");

                entity.HasIndex(e => e.FechaCreacion, "fecha_creacion");

                entity.HasIndex(e => e.Pedidokey, "pedidokey");

                entity.Property(e => e.Pedidocodigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("pedidocodigo");

                entity.Property(e => e.CodCliente)
                    .HasMaxLength(20)
                    .HasColumnName("cod_cliente")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CodRepresentante)
                    .HasMaxLength(20)
                    .HasColumnName("cod_representante")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(250)
                    .HasColumnName("comentario")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Dejapedido)
                    .HasColumnName("dejapedido")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(5)
                    .HasColumnName("empresa");

                entity.Property(e => e.Enviado)
                    .HasColumnName("enviado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.Namecliente)
                    .HasMaxLength(50)
                    .HasColumnName("namecliente")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Numero)
                    .HasColumnName("numero")
                    .HasDefaultValueSql("'1500000000'");

                entity.Property(e => e.Representante)
                    .HasMaxLength(50)
                    .HasColumnName("representante")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Total)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("total");
            });

            modelBuilder.Entity<Pedidodetalledipo>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Pedidokey })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pedidodetalledipo");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.HasIndex(e => e.Pedidokey, "pedidokey");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Caja).HasColumnName("caja");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CodArticulo)
                    .HasMaxLength(25)
                    .HasColumnName("cod_articulo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(50)
                    .HasColumnName("cod_barras")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Descuento)
                    .HasColumnType("float(10,2)")
                    .HasColumnName("descuento");

                entity.Property(e => e.Importe)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe");

                entity.Property(e => e.Linea).HasColumnName("linea");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(25)
                    .HasColumnName("ubicacion")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<Pedidodetalleunido>(entity =>
            {
                entity.ToTable("pedidodetalleunido");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Caja).HasColumnName("caja");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CodArticulo)
                    .HasMaxLength(25)
                    .HasColumnName("cod_articulo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(50)
                    .HasColumnName("cod_barras")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Descuento)
                    .HasColumnType("float(10,2)")
                    .HasColumnName("descuento");

                entity.Property(e => e.Importe)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe");

                entity.Property(e => e.Linea).HasColumnName("linea");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(25)
                    .HasColumnName("ubicacion")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<Pedidodetalleweb>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Caja })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pedidodetalleweb");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.HasIndex(e => e.Pedidokey, "pedidokey");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Caja).HasColumnName("caja");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CodArticulo)
                    .HasMaxLength(25)
                    .HasColumnName("cod_articulo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(50)
                    .HasColumnName("cod_barras")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Descuento)
                    .HasColumnType("float(10,2)")
                    .HasColumnName("descuento");

                entity.Property(e => e.Importe)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe");

                entity.Property(e => e.Linea).HasColumnName("linea");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(25)
                    .HasColumnName("ubicacion")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<Pedidomov>(entity =>
            {
                entity.ToTable("pedidomov");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.HasIndex(e => e.Codigo, "codigo");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.HasIndex(e => e.PedidoKey, "pedidoKey");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Baozhuangshu)
                    .HasPrecision(8, 2)
                    .HasColumnName("baozhuangshu");

                entity.Property(e => e.Beizhu)
                    .HasMaxLength(255)
                    .HasColumnName("beizhu")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Bianhao)
                    .HasMaxLength(20)
                    .HasColumnName("bianhao")
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(20)
                    .HasColumnName("codigo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Des)
                    .HasPrecision(10, 2)
                    .HasColumnName("des");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(5)
                    .HasColumnName("empresa");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha")
                    .HasDefaultValueSql("'1986-03-03 20:30:00'");

                entity.Property(e => e.Jianshu)
                    .HasPrecision(8, 2)
                    .HasColumnName("jianshu");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Namecn)
                    .HasMaxLength(50)
                    .HasColumnName("namecn")
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Namees)
                    .HasMaxLength(50)
                    .HasColumnName("namees")
                    .HasDefaultValueSql("''")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.PedidoKey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidoKey")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Precio)
                    .HasPrecision(10, 3)
                    .HasColumnName("precio");

                entity.Property(e => e.Zhuangxiangshu)
                    .HasPrecision(8, 2)
                    .HasColumnName("zhuangxiangshu");

                entity.Property(e => e.Zongshuliang)
                    .HasPrecision(10, 2)
                    .HasColumnName("zongshuliang");
            });

            modelBuilder.Entity<Pedidosdetalle>(entity =>
            {
                entity.HasKey(e => new { e.Codigodetalle, e.Pedidokey, e.Pedidokey2 })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("pedidosdetalle");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.Codigodetalle)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigodetalle");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Pedidokey2)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey2")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Borrado)
                    .HasColumnName("borrado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Caja).HasColumnName("caja");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CodBarras)
                    .HasMaxLength(50)
                    .HasColumnName("cod_barras")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.CodCliente)
                    .HasMaxLength(20)
                    .HasColumnName("cod_cliente")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(20)
                    .HasColumnName("codigo")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Descuento)
                    .HasColumnType("float(10,2)")
                    .HasColumnName("descuento");

                entity.Property(e => e.Importe)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importe");

                entity.Property(e => e.Linea).HasColumnName("linea");

                entity.Property(e => e.Pedidocodigo).HasColumnName("pedidocodigo");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(25)
                    .HasColumnName("ubicacion")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<Poee>(entity =>
            {
                entity.HasKey(e => new { e.PedidoCod, e.Pedidokey })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("poee");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.HasIndex(e => new { e.Vendedor, e.Fechaenvio }, "fechaenvio");

                entity.HasIndex(e => e.Pedidokey, "pedidokey");

                entity.Property(e => e.PedidoCod)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("pedido_cod");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey");

                entity.Property(e => e.Agencia)
                    .HasMaxLength(20)
                    .HasColumnName("agencia")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Almacenar)
                    .HasColumnName("almacenar")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Sirve para saber lo que guardamos nosotros");

                entity.Property(e => e.AutorizaSalida)
                    .HasColumnName("autoriza_salida")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Banco)
                    .HasMaxLength(50)
                    .HasColumnName("banco");

                entity.Property(e => e.Borrado)
                    .HasColumnName("borrado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CafechaFinaliza)
                    .HasColumnType("datetime")
                    .HasColumnName("cafecha_finaliza");

                entity.Property(e => e.CafechaInicia)
                    .HasColumnType("datetime")
                    .HasColumnName("cafecha_inicia");

                entity.Property(e => e.CajeroFinaliza)
                    .HasMaxLength(30)
                    .HasColumnName("cajero_finaliza")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CajeroInicia)
                    .HasMaxLength(30)
                    .HasColumnName("cajero_inicia")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.CantidadBultos)
                    .HasColumnName("cantidad_bultos")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CantidadCarro).HasColumnName("cantidad_carro");

                entity.Property(e => e.CantidadMedio)
                    .HasColumnName("cantidad_medio")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CantidadPalet)
                    .HasColumnName("cantidad_palet")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CantidadRecogeBultos).HasColumnName("cantidad_recoge_bultos");

                entity.Property(e => e.CantidadRecogePalet).HasColumnName("cantidad_recoge_palet");

                entity.Property(e => e.CantidadcajaBultos).HasColumnName("cantidadcaja_bultos");

                entity.Property(e => e.CantidadcajaCarro).HasColumnName("cantidadcaja_carro");

                entity.Property(e => e.CantidadcajaPalet).HasColumnName("cantidadcaja_palet");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(20)
                    .HasColumnName("cliente");

                entity.Property(e => e.Cobrado)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("cobrado");

                entity.Property(e => e.Color)
                    .HasMaxLength(15)
                    .HasColumnName("color")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Color2)
                    .HasMaxLength(15)
                    .HasColumnName("color2")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Color3)
                    .HasMaxLength(15)
                    .HasColumnName("color3")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Color4)
                    .HasMaxLength(15)
                    .HasColumnName("color4")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Color5)
                    .HasMaxLength(15)
                    .HasColumnName("color5")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Comentario)
                    .HasColumnType("text")
                    .HasColumnName("comentario")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Dejapedi)
                    .HasColumnName("dejapedi")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Devolucion)
                    .HasColumnName("devolucion")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Dirubi)
                    .HasMaxLength(9)
                    .HasColumnName("dirubi")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.EmbalajePeso).HasColumnName("embalaje_peso");

                entity.Property(e => e.EmbalajePesob)
                    .HasMaxLength(50)
                    .HasColumnName("embalaje_pesob");

                entity.Property(e => e.EmbalajePesom)
                    .HasMaxLength(50)
                    .HasColumnName("embalaje_pesom");

                entity.Property(e => e.EmbalajePesop)
                    .HasMaxLength(50)
                    .HasColumnName("embalaje_pesop");

                entity.Property(e => e.Embalajefeter)
                    .HasColumnType("datetime")
                    .HasColumnName("embalajefeter");

                entity.Property(e => e.Embalajeter)
                    .HasMaxLength(30)
                    .HasColumnName("embalajeter")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.EmpezarCaja)
                    .HasColumnName("empezar_caja")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(5)
                    .HasColumnName("empresa");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .HasColumnName("estado")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.EstadoContabilizado)
                    .HasColumnName("estado_contabilizado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EstadoEmbalaje)
                    .HasMaxLength(1)
                    .HasColumnName("estado_embalaje")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.EstadoEscoger)
                    .HasMaxLength(1)
                    .HasColumnName("estado_escoger")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.EstadoEscogerped)
                    .HasMaxLength(1)
                    .HasColumnName("estado_escogerped")
                    .HasDefaultValueSql("'N'")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.EstadoFacturacion)
                    .HasColumnName("estado_facturacion")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EstadoLiquidacion)
                    .HasColumnName("estado_liquidacion")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EstadoOficina)
                    .HasMaxLength(1)
                    .HasColumnName("estado_oficina")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.EstadoReponer)
                    .HasColumnName("estado_reponer")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Estadoweb)
                    .HasColumnName("estadoweb")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Expedicion)
                    .HasMaxLength(40)
                    .HasColumnName("expedicion")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.FechaComienza)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_comienza");

                entity.Property(e => e.FechaEmbalaje)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_embalaje");

                entity.Property(e => e.FechaEntregaExpe)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_entrega_expe");

                entity.Property(e => e.FechaEscoger)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_escoger");

                entity.Property(e => e.FechaFinaliza)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_finaliza");

                entity.Property(e => e.FechaHoraurgente)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_horaurgente");

                entity.Property(e => e.FechaLiquidado)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_liquidado");

                entity.Property(e => e.FechaOficina)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_oficina");

                entity.Property(e => e.FechaSuperurgente)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_superurgente");

                entity.Property(e => e.FechaTransporte)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_transporte");

                entity.Property(e => e.Fechaenvio)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaenvio");

                entity.Property(e => e.Fechapedido)
                    .HasColumnType("datetime")
                    .HasColumnName("fechapedido");

                entity.Property(e => e.Fechapreparado).HasColumnName("fechapreparado");

                entity.Property(e => e.Fechapreparado2).HasColumnName("fechapreparado2");

                entity.Property(e => e.Fechasalida)
                    .HasColumnType("datetime")
                    .HasColumnName("fechasalida");

                entity.Property(e => e.FinalizarEtiquetado)
                    .HasColumnName("finalizar_etiquetado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FormaPedido)
                    .HasColumnName("forma_pedido")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Formapago)
                    .HasMaxLength(30)
                    .HasColumnName("formapago");

                entity.Property(e => e.Formaped)
                    .HasColumnName("formaped")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Horallegadaempresa)
                    .HasMaxLength(5)
                    .HasColumnName("horallegadaempresa");

                entity.Property(e => e.Horasalidaempresa)
                    .HasMaxLength(5)
                    .HasColumnName("horasalidaempresa");

                entity.Property(e => e.Importefactura)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importefactura");

                entity.Property(e => e.Importepedido)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("importepedido");

                entity.Property(e => e.IniciarFacturacion)
                    .HasColumnName("iniciar_facturacion")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Jinez)
                    .HasPrecision(8, 2)
                    .HasColumnName("jinez")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.Kmllegadaempresa).HasColumnName("kmllegadaempresa");

                entity.Property(e => e.Kmsalidaempresa).HasColumnName("kmsalidaempresa");

                entity.Property(e => e.Letracom)
                    .HasMaxLength(8)
                    .HasColumnName("letracom")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Letraemba)
                    .HasMaxLength(32)
                    .HasColumnName("letraemba")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Letrapre)
                    .HasMaxLength(8)
                    .HasColumnName("letrapre")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.LiquiComision)
                    .HasColumnName("liqui_comision")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LiquiDescuento)
                    .HasColumnName("liqui_descuento")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LiquiDevolucion)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("liqui_devolucion")
                    .HasDefaultValueSql("'0.000'");

                entity.Property(e => e.LiquiFechaEnvio)
                    .HasColumnType("datetime")
                    .HasColumnName("liqui_fecha_envio");

                entity.Property(e => e.LiquiFechafactura)
                    .HasColumnType("datetime")
                    .HasColumnName("liqui_fechafactura");

                entity.Property(e => e.LiquiImporteComision)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("liqui_importe_comision")
                    .HasDefaultValueSql("'0.000'");

                entity.Property(e => e.LiquiImporteConDes)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("liqui_importe_con_des")
                    .HasDefaultValueSql("'0.000'");

                entity.Property(e => e.LiquiImportecobrado)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("liqui_importecobrado")
                    .HasDefaultValueSql("'0.000'");

                entity.Property(e => e.LiquiImportefactura)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("liqui_importefactura")
                    .HasDefaultValueSql("'0.000'");

                entity.Property(e => e.LiquiImportependiente)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("liqui_importependiente")
                    .HasDefaultValueSql("'0.000'");

                entity.Property(e => e.LiquiNumeroFactura).HasColumnName("liqui_numero_factura");

                entity.Property(e => e.LiquiObspago)
                    .HasColumnType("mediumtext")
                    .HasColumnName("liqui_obspago");

                entity.Property(e => e.LiquiSituacionpago)
                    .HasMaxLength(90)
                    .HasColumnName("liqui_situacionpago");

                entity.Property(e => e.Liquidado)
                    .HasColumnName("liquidado")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Logico)
                    .HasColumnName("logico")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MarcadoSalida)
                    .HasColumnName("marcado_salida")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Marcocomprobar)
                    .HasColumnName("marcocomprobar")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(10)
                    .HasColumnName("matricula")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Nalbaran)
                    .HasColumnName("nalbaran")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Namecliente)
                    .HasMaxLength(50)
                    .HasColumnName("namecliente")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Namevendedor)
                    .HasMaxLength(50)
                    .HasColumnName("namevendedor")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Naveagencia)
                    .HasColumnName("naveagencia")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Navecom)
                    .HasMaxLength(10)
                    .HasColumnName("navecom")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Naveemba)
                    .HasMaxLength(32)
                    .HasColumnName("naveemba")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Navepre)
                    .HasMaxLength(10)
                    .HasColumnName("navepre")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Nfactura)
                    .HasColumnName("nfactura")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.NomAutorizaSalida)
                    .HasMaxLength(60)
                    .HasColumnName("nom_autoriza_salida");

                entity.Property(e => e.NuevaUbicacion)
                    .HasColumnType("text")
                    .HasColumnName("nueva_ubicacion")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Obsenviopedido)
                    .HasMaxLength(150)
                    .HasColumnName("obsenviopedido")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Operador)
                    .HasMaxLength(30)
                    .HasColumnName("operador")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OperadorEmbalaje)
                    .HasMaxLength(30)
                    .HasColumnName("operador_embalaje")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OperadorEscoger)
                    .HasMaxLength(30)
                    .HasColumnName("operador_escoger")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OperadorFinaliza)
                    .HasMaxLength(30)
                    .HasColumnName("operador_finaliza")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OperadorOficina)
                    .HasMaxLength(30)
                    .HasColumnName("operador_oficina")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.OperadorTransporte)
                    .HasMaxLength(30)
                    .HasColumnName("operador_transporte")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Pagadologistica)
                    .HasMaxLength(2)
                    .HasColumnName("pagadologistica")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Quienborro)
                    .HasMaxLength(30)
                    .HasColumnName("quienborro")
                    .HasDefaultValueSql("' '")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Retenerpedido)
                    .HasColumnName("retenerpedido")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SitioReparto)
                    .HasMaxLength(35)
                    .HasColumnName("sitio_reparto")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Sitiocom)
                    .HasColumnType("text")
                    .HasColumnName("sitiocom")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Sitioemba)
                    .HasColumnType("text")
                    .HasColumnName("sitioemba")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Sitiopre)
                    .HasColumnType("text")
                    .HasColumnName("sitiopre")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.SuperUrgente)
                    .HasColumnName("super_urgente")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TipoPalet)
                    .HasMaxLength(15)
                    .HasColumnName("tipo_palet")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Transportista)
                    .HasMaxLength(30)
                    .HasColumnName("transportista")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.UbicacionEmbalaje)
                    .HasMaxLength(30)
                    .HasColumnName("ubicacion_embalaje")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Unido)
                    .HasColumnName("unido")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Urgente)
                    .HasColumnName("urgente")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UsuarioAutorizaconta)
                    .HasMaxLength(50)
                    .HasColumnName("usuario_autorizaconta");

                entity.Property(e => e.UsuarioAutorizafac)
                    .HasMaxLength(50)
                    .HasColumnName("usuario_autorizafac");

                entity.Property(e => e.Vendedor)
                    .HasMaxLength(20)
                    .HasColumnName("vendedor");

                entity.Property(e => e.Vip)
                    .HasColumnName("vip")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Vuelta)
                    .HasColumnName("vuelta")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Poee2>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Pedidokey })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("poee2");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey");
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("provincias");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_spanish_ci");

                entity.HasIndex(e => e.Id, "id");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Provincia1)
                    .HasMaxLength(255)
                    .HasColumnName("provincia");
            });

            modelBuilder.Entity<Salidamadrid>(entity =>
            {
                entity.ToTable("salidamadrid");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Autoriza)
                    .HasMaxLength(30)
                    .HasColumnName("autoriza");

                entity.Property(e => e.Bultos)
                    .HasMaxLength(15)
                    .HasColumnName("bultos");

                entity.Property(e => e.CantidadBulto).HasColumnName("cantidad_bulto");

                entity.Property(e => e.CantidadMedio).HasColumnName("cantidad_medio");

                entity.Property(e => e.CantidadPalet).HasColumnName("cantidad_palet");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(20)
                    .HasColumnName("cliente");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(250)
                    .HasColumnName("comentario");

                entity.Property(e => e.Conductor)
                    .HasMaxLength(30)
                    .HasColumnName("conductor");

                entity.Property(e => e.Cp)
                    .HasMaxLength(10)
                    .HasColumnName("cp");

                entity.Property(e => e.Diasalida)
                    .HasMaxLength(9)
                    .HasColumnName("diasalida");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(45)
                    .HasColumnName("direccion");

                entity.Property(e => e.Estadosalida)
                    .HasColumnName("estadosalida")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FechaSalida).HasColumnName("fecha_salida");

                entity.Property(e => e.Horallegadaempresa)
                    .HasMaxLength(5)
                    .HasColumnName("horallegadaempresa");

                entity.Property(e => e.Horasalidaempresa)
                    .HasMaxLength(5)
                    .HasColumnName("horasalidaempresa");

                entity.Property(e => e.Importe)
                    .HasPrecision(10, 2)
                    .HasColumnName("importe");

                entity.Property(e => e.ImporteFactura)
                    .HasPrecision(10, 2)
                    .HasColumnName("importe_factura");

                entity.Property(e => e.Kmllegadaempresa).HasColumnName("kmllegadaempresa");

                entity.Property(e => e.Kmsalidaempresa).HasColumnName("kmsalidaempresa");

                entity.Property(e => e.ListadoSalida)
                    .HasColumnName("listado_salida")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(25)
                    .HasColumnName("matricula");

                entity.Property(e => e.Namecliente)
                    .HasMaxLength(45)
                    .HasColumnName("namecliente");

                entity.Property(e => e.NroFactura)
                    .HasColumnType("mediumtext")
                    .HasColumnName("nro_factura");

                entity.Property(e => e.Pedidokey)
                    .HasMaxLength(20)
                    .HasColumnName("pedidokey");

                entity.Property(e => e.Poblacion)
                    .HasMaxLength(45)
                    .HasColumnName("poblacion");

                entity.Property(e => e.Tel)
                    .HasMaxLength(25)
                    .HasColumnName("tel");

                entity.Property(e => e.Turno)
                    .HasMaxLength(6)
                    .HasColumnName("turno")
                    .UseCollation("utf8_spanish_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Vendedor)
                    .HasMaxLength(20)
                    .HasColumnName("vendedor");
            });

            modelBuilder.Entity<Sinfoto>(entity =>
            {
                entity.HasKey(e => e.Iten)
                    .HasName("PRIMARY");

                entity.ToTable("sinfoto");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.Iten)
                    .ValueGeneratedNever()
                    .HasColumnName("iten");

                entity.Property(e => e.Bianhao)
                    .HasMaxLength(80)
                    .HasColumnName("bianhao");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(80)
                    .HasColumnName("codigo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Sitio>(entity =>
            {
                entity.HasKey(e => e.CodFila)
                    .HasName("PRIMARY");

                entity.ToTable("sitio");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.CodFila).HasColumnName("cod_fila");

                entity.Property(e => e.DescriFila)
                    .HasMaxLength(30)
                    .HasColumnName("descri_fila");
            });

            modelBuilder.Entity<Subfamiliachino>(entity =>
            {
                entity.ToTable("subfamiliachino");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.MuluId, "muluID");

                entity.HasIndex(e => e.SubMuluId, "subMuluID");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Jinyong).HasColumnName("jinyong");

                entity.Property(e => e.MuluId)
                    .HasMaxLength(20)
                    .HasColumnName("MuluID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Px).HasColumnName("px");

                entity.Property(e => e.SubMuluId)
                    .HasMaxLength(20)
                    .HasColumnName("subMuluID");
            });

            modelBuilder.Entity<Sumatoriafacturapend>(entity =>
            {
                entity.ToTable("sumatoriafacturapend");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Total).HasColumnName("total");
            });

            modelBuilder.Entity<Temporaldipo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temporaldipo");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(30)
                    .HasColumnName("barcode");

                entity.Property(e => e.Feature)
                    .HasMaxLength(20)
                    .HasColumnName("feature");

                entity.Property(e => e.Price)
                    .HasColumnType("float(10,2)")
                    .HasColumnName("price");

                entity.Property(e => e.ProductReference)
                    .HasMaxLength(30)
                    .HasColumnName("product_reference");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Unit).HasColumnName("unit");
            });

            modelBuilder.Entity<Temporalweb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temporalweb");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.BoxNumber)
                    .HasMaxLength(50)
                    .HasColumnName("box_number");

                entity.Property(e => e.CityName)
                    .HasMaxLength(3)
                    .HasColumnName("city_name");

                entity.Property(e => e.ClientAddress)
                    .HasMaxLength(3)
                    .HasColumnName("client_address");

                entity.Property(e => e.ClientConsignee)
                    .HasMaxLength(3)
                    .HasColumnName("client_consignee");

                entity.Property(e => e.ClientDocumentId)
                    .HasMaxLength(19)
                    .HasColumnName("client_document_id");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(20)
                    .HasColumnName("client_id");

                entity.Property(e => e.ClientModel)
                    .HasMaxLength(25)
                    .HasColumnName("client_model");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(50)
                    .HasColumnName("client_name");

                entity.Property(e => e.ClientPostal)
                    .HasMaxLength(3)
                    .HasColumnName("client_postal");

                entity.Property(e => e.ClientTel)
                    .HasMaxLength(20)
                    .HasColumnName("client_tel");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(3)
                    .HasColumnName("country_name");

                entity.Property(e => e.DeliverTimestamp)
                    .HasMaxLength(50)
                    .HasColumnName("deliver_timestamp");

                entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");

                entity.Property(e => e.DocumentDate)
                    .HasMaxLength(13)
                    .HasColumnName("document_date");

                entity.Property(e => e.DocumentId)
                    .HasMaxLength(20)
                    .HasColumnName("document_id");

                entity.Property(e => e.DocumentKindId)
                    .HasMaxLength(17)
                    .HasColumnName("document_kind_id");

                entity.Property(e => e.DocumentKindName)
                    .HasMaxLength(20)
                    .HasColumnName("document_kind_name");

                entity.Property(e => e.DocumentRemark)
                    .HasMaxLength(3)
                    .HasColumnName("document_remark");

                entity.Property(e => e.GrossWeight)
                    .HasMaxLength(50)
                    .HasColumnName("gross_weight");

                entity.Property(e => e.HandlerId)
                    .HasMaxLength(10)
                    .HasColumnName("handler_id");

                entity.Property(e => e.HandlerName)
                    .HasMaxLength(20)
                    .HasColumnName("handler_name");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(50)
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemRemark)
                    .HasMaxLength(50)
                    .HasColumnName("item_remark");

                entity.Property(e => e.LocalDescription)
                    .HasMaxLength(150)
                    .HasColumnName("local_description");

                entity.Property(e => e.MaterialDescription)
                    .HasMaxLength(50)
                    .HasColumnName("material_description");

                entity.Property(e => e.MiddleQuantity)
                    .HasMaxLength(50)
                    .HasColumnName("middle_quantity");

                entity.Property(e => e.MoneyRateId)
                    .HasMaxLength(13)
                    .HasColumnName("money_rate_id");

                entity.Property(e => e.NetWeight)
                    .HasMaxLength(50)
                    .HasColumnName("net_weight");

                entity.Property(e => e.PackQuantity)
                    .HasMaxLength(50)
                    .HasColumnName("pack_quantity");

                entity.Property(e => e.PackRequest)
                    .HasMaxLength(50)
                    .HasColumnName("pack_request");

                entity.Property(e => e.PackVolume)
                    .HasMaxLength(50)
                    .HasColumnName("pack_volume");

                entity.Property(e => e.ProcessKind)
                    .HasMaxLength(50)
                    .HasColumnName("process_kind");

                entity.Property(e => e.ProcessProcedure)
                    .HasMaxLength(50)
                    .HasColumnName("process_procedure");

                entity.Property(e => e.ProcessUnit)
                    .HasMaxLength(50)
                    .HasColumnName("process_unit");

                entity.Property(e => e.ProduceArea)
                    .HasMaxLength(50)
                    .HasColumnName("produce_area");

                entity.Property(e => e.ProductBarcode)
                    .HasMaxLength(25)
                    .HasColumnName("product_barcode");

                entity.Property(e => e.ProductBatch)
                    .HasMaxLength(15)
                    .HasColumnName("product_batch");

                entity.Property(e => e.ProductBrand)
                    .HasMaxLength(50)
                    .HasColumnName("product_brand");

                entity.Property(e => e.ProductColor)
                    .HasMaxLength(50)
                    .HasColumnName("product_color");

                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(150)
                    .HasColumnName("product_description");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(20)
                    .HasColumnName("product_id");

                entity.Property(e => e.ProductKindId)
                    .HasMaxLength(50)
                    .HasColumnName("product_kind_id");

                entity.Property(e => e.ProductKindName)
                    .HasMaxLength(50)
                    .HasColumnName("product_kind_name");

                entity.Property(e => e.ProductMark)
                    .HasMaxLength(20)
                    .HasColumnName("product_mark");

                entity.Property(e => e.ProductModel)
                    .HasMaxLength(20)
                    .HasColumnName("product_model");

                entity.Property(e => e.ProductQuantity).HasColumnName("product_quantity");

                entity.Property(e => e.ProductSize)
                    .HasMaxLength(50)
                    .HasColumnName("product_size");

                entity.Property(e => e.ProductUnit)
                    .HasMaxLength(50)
                    .HasColumnName("product_unit");

                entity.Property(e => e.ProviderModel)
                    .HasMaxLength(25)
                    .HasColumnName("provider_model");

                entity.Property(e => e.ProvinceName)
                    .HasMaxLength(3)
                    .HasColumnName("province_name");

                entity.Property(e => e.SequenceNumber)
                    .HasMaxLength(20)
                    .HasColumnName("sequence_number");

                entity.Property(e => e.SpecDescription)
                    .HasMaxLength(50)
                    .HasColumnName("spec_description");

                entity.Property(e => e.StoreId)
                    .HasMaxLength(10)
                    .HasColumnName("store_id");

                entity.Property(e => e.StoreName)
                    .HasMaxLength(10)
                    .HasColumnName("store_name");

                entity.Property(e => e.TaxRate)
                    .HasMaxLength(50)
                    .HasColumnName("tax_rate");

                entity.Property(e => e.TechnicRequest)
                    .HasMaxLength(50)
                    .HasColumnName("technic_request");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("float(10,3)")
                    .HasColumnName("unit_price");

                entity.Property(e => e.UnitQuantity)
                    .HasMaxLength(50)
                    .HasColumnName("unit_quantity");
            });

            modelBuilder.Entity<Tipoembalaje>(entity =>
            {
                entity.HasKey(e => e.Idpalet)
                    .HasName("PRIMARY");

                entity.ToTable("tipoembalaje");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.Idpalet).HasColumnName("idpalet");

                entity.Property(e => e.CodCliente)
                    .HasMaxLength(20)
                    .HasColumnName("cod_cliente");

                entity.Property(e => e.Namecliente)
                    .HasMaxLength(30)
                    .HasColumnName("namecliente")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Tipoembalaje1)
                    .HasMaxLength(40)
                    .HasColumnName("tipoembalaje")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(30)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<Ubicacion>(entity =>
            {
                entity.HasKey(e => e.CodUbicacion)
                    .HasName("PRIMARY");

                entity.ToTable("ubicacion");

                entity.HasCharSet("gbk")
                    .UseCollation("gbk_chinese_ci");

                entity.Property(e => e.CodUbicacion).HasColumnName("cod_ubicacion");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.DescripcionLarga)
                    .HasMaxLength(20)
                    .HasColumnName("descripcion_larga");
            });

            modelBuilder.Entity<Yewuyuan>(entity =>
            {
                entity.ToTable("yewuyuan");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.Py, "PY1");

                entity.HasIndex(e => e.Bianhao, "bianhao")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "lianxiren");

                entity.HasIndex(e => e.Diqu, "name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Auth)
                    .HasMaxLength(12)
                    .HasColumnName("auth")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Beizhu)
                    .HasMaxLength(255)
                    .HasColumnName("beizhu")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Bianhao)
                    .HasMaxLength(20)
                    .HasColumnName("bianhao");

                entity.Property(e => e.Dianshu).HasColumnName("dianshu");

                entity.Property(e => e.Diqu)
                    .HasMaxLength(50)
                    .HasColumnName("diqu")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dizhi)
                    .HasMaxLength(50)
                    .HasColumnName("dizhi")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Jinyong).HasColumnName("jinyong");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Py)
                    .HasMaxLength(50)
                    .HasColumnName("PY")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Tel)
                    .HasMaxLength(20)
                    .HasColumnName("tel")
                    .HasDefaultValueSql("''");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
