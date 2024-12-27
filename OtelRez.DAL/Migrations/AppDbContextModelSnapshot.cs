﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OtelRez.DAL.DbContexts;

#nullable disable

namespace OtelRez.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.Galery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsOda")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPool")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRestorant")
                        .HasColumnType("bit");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Galeriler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsOda = true,
                            IsPool = false,
                            IsRestorant = false,
                            PhotoPath = "/OtelTemp/assets/img/rooms/room1.jpg"
                        },
                        new
                        {
                            Id = 2,
                            IsOda = true,
                            IsPool = false,
                            IsRestorant = false,
                            PhotoPath = "/OtelTemp/assets/img/rooms/room2.jpg"
                        },
                        new
                        {
                            Id = 3,
                            IsOda = true,
                            IsPool = false,
                            IsRestorant = false,
                            PhotoPath = "/OtelTemp/assets/img/rooms/room3.jpg"
                        },
                        new
                        {
                            Id = 4,
                            IsOda = true,
                            IsPool = false,
                            IsRestorant = false,
                            PhotoPath = "/OtelTemp/assets/img/rooms/room4.jpg"
                        },
                        new
                        {
                            Id = 5,
                            IsOda = true,
                            IsPool = false,
                            IsRestorant = false,
                            PhotoPath = "/OtelTemp/assets/img/rooms/room5.jpg"
                        },
                        new
                        {
                            Id = 6,
                            IsOda = true,
                            IsPool = false,
                            IsRestorant = false,
                            PhotoPath = "/OtelTemp/assets/img/gallery/gallery1.jpg"
                        },
                        new
                        {
                            Id = 7,
                            IsOda = true,
                            IsPool = false,
                            IsRestorant = false,
                            PhotoPath = "/OtelTemp/assets/img/gallery/gallery2.jpg"
                        },
                        new
                        {
                            Id = 8,
                            IsOda = true,
                            IsPool = false,
                            IsRestorant = false,
                            PhotoPath = "/OtelTemp/assets/img/gallery/gallery3.jpg"
                        },
                        new
                        {
                            Id = 9,
                            IsOda = false,
                            IsPool = false,
                            IsRestorant = true,
                            PhotoPath = "/OtelTemp/assets/img/dining/dining-img.jpg"
                        },
                        new
                        {
                            Id = 10,
                            IsOda = false,
                            IsPool = true,
                            IsRestorant = false,
                            PhotoPath = "/OtelTemp/assets/img/dining/dining-img2.jpg"
                        });
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.Hizmetler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("SubTitle")
                        .IsUnique();

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Hizmetler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "asjhvhdsvhfsvdhsbh",
                            PhotoPath = "/OtelTemp/assets/img/dining/dining-img.jpg",
                            SubTitle = "Akşam yemeği ve kahvaltı",
                            Title = "Restoranımız"
                        },
                        new
                        {
                            Id = 2,
                            Description = "asjhvhdsvhfsvdhsbh",
                            PhotoPath = "/OtelTemp/assets/img/dining/dining-img2.jpg",
                            SubTitle = "Büyük yüzme havuzu",
                            Title = "Havuzumuz"
                        });
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.Iletisim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Iletisim");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adres = "İstanbul,Beşiktaş",
                            Mail = "istkafullkata@gmail.com",
                            Tel = "0212 568 93 96"
                        });
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.IletisimeGec", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Konu")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mesaj")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("IletisimeGec");
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateOnly?>("DogumTarihi")
                        .HasColumnType("date");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("Mail")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.HasIndex("Tel")
                        .IsUnique();

                    b.ToTable("Kullanicilar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adi = "Emre",
                            DogumTarihi = new DateOnly(1998, 9, 9),
                            Mail = "emre@gmail.com",
                            RoleId = 3,
                            Sifre = "qweasd",
                            Soyadi = "Andaç",
                            Tel = "05456853541"
                        },
                        new
                        {
                            Id = 2,
                            Adi = "Betül Rana",
                            DogumTarihi = new DateOnly(1998, 9, 9),
                            Mail = "betul@gmail.com",
                            RoleId = 3,
                            Sifre = "qweasd",
                            Soyadi = "Özer",
                            Tel = "05648623598"
                        });
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.Oda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("OdaNumarasi")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<int>("OdaTurId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("OdaNumarasi")
                        .IsUnique();

                    b.HasIndex("OdaTurId");

                    b.ToTable("Odalar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OdaNumarasi = "101",
                            OdaTurId = 1
                        },
                        new
                        {
                            Id = 2,
                            OdaNumarasi = "102",
                            OdaTurId = 1
                        },
                        new
                        {
                            Id = 3,
                            OdaNumarasi = "103",
                            OdaTurId = 4
                        },
                        new
                        {
                            Id = 4,
                            OdaNumarasi = "104",
                            OdaTurId = 4
                        },
                        new
                        {
                            Id = 5,
                            OdaNumarasi = "105",
                            OdaTurId = 4
                        },
                        new
                        {
                            Id = 6,
                            OdaNumarasi = "201",
                            OdaTurId = 2
                        },
                        new
                        {
                            Id = 7,
                            OdaNumarasi = "202",
                            OdaTurId = 2
                        },
                        new
                        {
                            Id = 8,
                            OdaNumarasi = "203",
                            OdaTurId = 3
                        },
                        new
                        {
                            Id = 9,
                            OdaNumarasi = "204",
                            OdaTurId = 3
                        },
                        new
                        {
                            Id = 10,
                            OdaNumarasi = "205",
                            OdaTurId = 3
                        },
                        new
                        {
                            Id = 11,
                            OdaNumarasi = "301",
                            OdaTurId = 1
                        },
                        new
                        {
                            Id = 12,
                            OdaNumarasi = "302",
                            OdaTurId = 2
                        },
                        new
                        {
                            Id = 13,
                            OdaNumarasi = "303",
                            OdaTurId = 3
                        },
                        new
                        {
                            Id = 14,
                            OdaNumarasi = "304",
                            OdaTurId = 5
                        },
                        new
                        {
                            Id = 15,
                            OdaNumarasi = "305",
                            OdaTurId = 5
                        },
                        new
                        {
                            Id = 16,
                            OdaNumarasi = "401",
                            OdaTurId = 6
                        },
                        new
                        {
                            Id = 17,
                            OdaNumarasi = "405",
                            OdaTurId = 6
                        });
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.OdaTur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Balkon")
                        .HasColumnType("bit");

                    b.Property<int>("Fiyat")
                        .HasColumnType("int");

                    b.Property<bool>("Jakuzi")
                        .HasColumnType("bit");

                    b.Property<short>("Kapasite")
                        .HasColumnType("smallint");

                    b.Property<bool>("Minibar")
                        .HasColumnType("bit");

                    b.Property<bool>("OdaServisi")
                        .HasColumnType("bit");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TurAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TurDetay")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("WiFi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("TurAdi")
                        .IsUnique();

                    b.ToTable("OdaTurleri");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Balkon = false,
                            Fiyat = 1500,
                            Jakuzi = false,
                            Kapasite = (short)1,
                            Minibar = false,
                            OdaServisi = true,
                            PhotoPath = "/OtelTemp/assets/img/rooms/room1.jpg",
                            TurAdi = "Suit Room",
                            TurDetay = "Tek yataklı oda",
                            WiFi = true
                        },
                        new
                        {
                            Id = 2,
                            Balkon = false,
                            Fiyat = 1600,
                            Jakuzi = false,
                            Kapasite = (short)2,
                            Minibar = false,
                            OdaServisi = true,
                            PhotoPath = "/OtelTemp/assets/img/rooms/room2.jpg",
                            TurAdi = "Twin Room",
                            TurDetay = "İki yataklı oda",
                            WiFi = true
                        },
                        new
                        {
                            Id = 3,
                            Balkon = true,
                            Fiyat = 1700,
                            Jakuzi = false,
                            Kapasite = (short)2,
                            Minibar = false,
                            OdaServisi = true,
                            PhotoPath = "/OtelTemp/assets/img/rooms/room3.jpg",
                            TurAdi = "Double Room",
                            TurDetay = "İki kişilik tek yatak",
                            WiFi = true
                        },
                        new
                        {
                            Id = 4,
                            Balkon = true,
                            Fiyat = 1800,
                            Jakuzi = false,
                            Kapasite = (short)3,
                            Minibar = true,
                            OdaServisi = true,
                            PhotoPath = "/OtelTemp/assets/img/rooms/room4.jpg",
                            TurAdi = "Triple Room",
                            TurDetay = "Üç tek kişilik yatak",
                            WiFi = true
                        },
                        new
                        {
                            Id = 5,
                            Balkon = true,
                            Fiyat = 1750,
                            Jakuzi = false,
                            Kapasite = (short)3,
                            Minibar = true,
                            OdaServisi = true,
                            PhotoPath = "/OtelTemp/assets/img/rooms/room5.jpg",
                            TurAdi = "Family Room",
                            TurDetay = "1 double yatak 1 tek kişilik yatak",
                            WiFi = true
                        },
                        new
                        {
                            Id = 6,
                            Balkon = true,
                            Fiyat = 3000,
                            Jakuzi = true,
                            Kapasite = (short)2,
                            Minibar = true,
                            OdaServisi = true,
                            PhotoPath = "/OtelTemp/assets/img/rooms/room6.jpg",
                            TurAdi = "King Room",
                            TurDetay = "Double yatak",
                            WiFi = true
                        });
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("IzinHakki")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(30);

                    b.Property<int>("PersonelMeslekId")
                        .HasColumnType("int");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("PersonelMeslekId");

                    b.HasIndex("RoleId");

                    b.ToTable("Personeller");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adi = "Ahmet",
                            IzinHakki = 30,
                            PersonelMeslekId = 1,
                            RoleId = 1,
                            Soyadi = "Ak"
                        },
                        new
                        {
                            Id = 2,
                            Adi = "Büşra",
                            IzinHakki = 20,
                            PersonelMeslekId = 2,
                            RoleId = 2,
                            Soyadi = "Aksoy"
                        },
                        new
                        {
                            Id = 3,
                            Adi = "Betüş",
                            IzinHakki = 14,
                            PersonelMeslekId = 3,
                            Soyadi = "Lol"
                        });
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.PersonelGiris", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("Mail")
                        .IsUnique();

                    b.HasIndex("PersonelId")
                        .IsUnique();

                    b.ToTable("PersonelGiris");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Mail = "ahmet@gmail.com",
                            PersonelId = 1,
                            Sifre = "qweasd"
                        },
                        new
                        {
                            Id = 2,
                            Mail = "busr.ar@gmail.com",
                            PersonelId = 2,
                            Sifre = "qweasd"
                        });
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.PersonelMeslek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Maas")
                        .HasColumnType("int");

                    b.Property<string>("Meslek")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("Meslek")
                        .IsUnique();

                    b.ToTable("PersonelMeslekler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Maas = 50000,
                            Meslek = "Yönetici"
                        },
                        new
                        {
                            Id = 2,
                            Maas = 18002,
                            Meslek = "Resepsiyonist"
                        },
                        new
                        {
                            Id = 3,
                            Maas = 25000,
                            Meslek = "Aşçı"
                        });
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.Rezervasyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("Cikis")
                        .HasColumnType("date");

                    b.Property<DateOnly>("CreateTime")
                        .HasColumnType("date");

                    b.Property<DateOnly>("Giris")
                        .HasColumnType("date");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<int>("OdaId")
                        .HasColumnType("int");

                    b.Property<int>("ToplamTutar")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("KullaniciId");

                    b.HasIndex("OdaId")
                        .IsUnique();

                    b.ToTable("Rezervasyonlar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cikis = new DateOnly(2024, 12, 22),
                            CreateTime = new DateOnly(2024, 12, 27),
                            Giris = new DateOnly(2024, 12, 18),
                            KullaniciId = 1,
                            OdaId = 12,
                            ToplamTutar = 4000
                        },
                        new
                        {
                            Id = 2,
                            Cikis = new DateOnly(2024, 12, 22),
                            CreateTime = new DateOnly(2024, 12, 27),
                            Giris = new DateOnly(2024, 12, 20),
                            KullaniciId = 1,
                            OdaId = 4,
                            ToplamTutar = 2000
                        },
                        new
                        {
                            Id = 3,
                            Cikis = new DateOnly(2024, 12, 5),
                            CreateTime = new DateOnly(2024, 12, 27),
                            Giris = new DateOnly(2024, 11, 18),
                            KullaniciId = 2,
                            OdaId = 10,
                            ToplamTutar = 20000
                        });
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RoleAdi")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("RoleAdi")
                        .IsUnique();

                    b.ToTable("Roller");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleAdi = "Yonetici"
                        },
                        new
                        {
                            Id = 2,
                            RoleAdi = "Resepsiyonist"
                        },
                        new
                        {
                            Id = 3,
                            RoleAdi = "Kullanici"
                        });
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.Kullanici", b =>
                {
                    b.HasOne("OtelRez.Entity.Entities.Concrete.Role", "Role")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.Oda", b =>
                {
                    b.HasOne("OtelRez.Entity.Entities.Concrete.OdaTur", "OdaTur")
                        .WithMany("Odalar")
                        .HasForeignKey("OdaTurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OdaTur");
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.Personel", b =>
                {
                    b.HasOne("OtelRez.Entity.Entities.Concrete.PersonelMeslek", "PersonelMeslek")
                        .WithMany("Personeller")
                        .HasForeignKey("PersonelMeslekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OtelRez.Entity.Entities.Concrete.Role", "Role")
                        .WithMany("Personeller")
                        .HasForeignKey("RoleId");

                    b.Navigation("PersonelMeslek");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.PersonelGiris", b =>
                {
                    b.HasOne("OtelRez.Entity.Entities.Concrete.Personel", "Personel")
                        .WithOne("PersonelGiris")
                        .HasForeignKey("OtelRez.Entity.Entities.Concrete.PersonelGiris", "PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.Rezervasyon", b =>
                {
                    b.HasOne("OtelRez.Entity.Entities.Concrete.Kullanici", "Kullanici")
                        .WithMany("Rezervasyonlar")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OtelRez.Entity.Entities.Concrete.Oda", "Oda")
                        .WithOne("Rezervasyon")
                        .HasForeignKey("OtelRez.Entity.Entities.Concrete.Rezervasyon", "OdaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");

                    b.Navigation("Oda");
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.Kullanici", b =>
                {
                    b.Navigation("Rezervasyonlar");
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.Oda", b =>
                {
                    b.Navigation("Rezervasyon")
                        .IsRequired();
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.OdaTur", b =>
                {
                    b.Navigation("Odalar");
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.Personel", b =>
                {
                    b.Navigation("PersonelGiris")
                        .IsRequired();
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.PersonelMeslek", b =>
                {
                    b.Navigation("Personeller");
                });

            modelBuilder.Entity("OtelRez.Entity.Entities.Concrete.Role", b =>
                {
                    b.Navigation("Kullanicilar");

                    b.Navigation("Personeller");
                });
#pragma warning restore 612, 618
        }
    }
}
