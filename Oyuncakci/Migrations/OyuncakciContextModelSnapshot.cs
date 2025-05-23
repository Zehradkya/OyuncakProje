﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oyuncakci.Models;

#nullable disable

namespace Oyuncakci.Migrations
{
    [DbContext(typeof(OyuncakciContext))]
    partial class OyuncakciContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Oyuncakci.Models.Calisan", b =>
                {
                    b.Property<int>("CalisanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CalisanID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Pozisyon")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RolID")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CalisanID");

                    b.HasIndex("RolID");

                    b.ToTable("Calisanlar", (string)null);
                });

            modelBuilder.Entity("Oyuncakci.Models.GecmisSiparis", b =>
                {
                    b.Property<int>("GecmisSiparisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GecmisSiparisID"));

                    b.Property<string>("Detay")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("SiparisID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("GecmisSiparisID");

                    b.HasIndex("SiparisID");

                    b.ToTable("GecmisSiparisler", (string)null);
                });

            modelBuilder.Entity("Oyuncakci.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriID"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategoriler", (string)null);
                });

            modelBuilder.Entity("Oyuncakci.Models.Musteri", b =>
                {
                    b.Property<int>("MusteriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MusteriID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("MusteriID");

                    b.ToTable("Musteriler", (string)null);
                });

            modelBuilder.Entity("Oyuncakci.Models.Odeme", b =>
                {
                    b.Property<int>("OdemeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OdemeID"));

                    b.Property<DateTime>("OdemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("OdemeTuru")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("SiparisID")
                        .HasColumnType("int");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("OdemeID");

                    b.HasIndex("SiparisID");

                    b.ToTable("Odemeler", (string)null);
                });

            modelBuilder.Entity("Oyuncakci.Models.Oyuncak", b =>
                {
                    b.Property<int>("OyuncakID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OyuncakID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StokMiktari")
                        .HasColumnType("int");

                    b.HasKey("OyuncakID");

                    b.HasIndex("KategoriID");

                    b.ToTable("Oyuncaklar", (string)null);
                });

            modelBuilder.Entity("Oyuncakci.Models.Rol", b =>
                {
                    b.Property<int>("RolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RolID"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("RolAdi")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("RolID");

                    b.ToTable("Roller", (string)null);
                });

            modelBuilder.Entity("Oyuncakci.Models.Siparis", b =>
                {
                    b.Property<int>("SiparisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SiparisID"));

                    b.Property<int>("MusteriID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ToplamTutar")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("SiparisID");

                    b.HasIndex("MusteriID");

                    b.ToTable("Siparisler", (string)null);
                });

            modelBuilder.Entity("Oyuncakci.Models.SiparisDetay", b =>
                {
                    b.Property<int>("SiparisDetayID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SiparisDetayID"));

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("OyuncakID")
                        .HasColumnType("int");

                    b.Property<int>("SiparisID")
                        .HasColumnType("int");

                    b.HasKey("SiparisDetayID");

                    b.HasIndex("OyuncakID");

                    b.HasIndex("SiparisID");

                    b.ToTable("SiparisDetaylari", (string)null);
                });

            modelBuilder.Entity("Oyuncakci.Models.StokGiris", b =>
                {
                    b.Property<int>("StokGirisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StokGirisID"));

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<int>("OyuncakID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("TedarikciID")
                        .HasColumnType("int");

                    b.HasKey("StokGirisID");

                    b.HasIndex("OyuncakID");

                    b.HasIndex("TedarikciID");

                    b.ToTable("StokGirisleri", (string)null);
                });

            modelBuilder.Entity("Oyuncakci.Models.Tedarikci", b =>
                {
                    b.Property<int>("TedarikciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TedarikciID"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirmaAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("TedarikciID");

                    b.ToTable("Tedarikciler", (string)null);
                });

            modelBuilder.Entity("Oyuncakci.Models.Calisan", b =>
                {
                    b.HasOne("Oyuncakci.Models.Rol", "Rol")
                        .WithMany("Calisanlar")
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Oyuncakci.Models.GecmisSiparis", b =>
                {
                    b.HasOne("Oyuncakci.Models.Siparis", "Siparis")
                        .WithMany("GecmisSiparisler")
                        .HasForeignKey("SiparisID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Siparis");
                });

            modelBuilder.Entity("Oyuncakci.Models.Odeme", b =>
                {
                    b.HasOne("Oyuncakci.Models.Siparis", "Siparis")
                        .WithMany("Odemeler")
                        .HasForeignKey("SiparisID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Siparis");
                });

            modelBuilder.Entity("Oyuncakci.Models.Oyuncak", b =>
                {
                    b.HasOne("Oyuncakci.Models.Kategori", "Kategori")
                        .WithMany("Oyuncaklar")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("Oyuncakci.Models.Siparis", b =>
                {
                    b.HasOne("Oyuncakci.Models.Musteri", "Musteri")
                        .WithMany("Siparisler")
                        .HasForeignKey("MusteriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("Oyuncakci.Models.SiparisDetay", b =>
                {
                    b.HasOne("Oyuncakci.Models.Oyuncak", "Oyuncak")
                        .WithMany()
                        .HasForeignKey("OyuncakID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oyuncakci.Models.Siparis", "Siparis")
                        .WithMany("SiparisDetaylari")
                        .HasForeignKey("SiparisID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Oyuncak");

                    b.Navigation("Siparis");
                });

            modelBuilder.Entity("Oyuncakci.Models.StokGiris", b =>
                {
                    b.HasOne("Oyuncakci.Models.Oyuncak", "Oyuncak")
                        .WithMany()
                        .HasForeignKey("OyuncakID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oyuncakci.Models.Tedarikci", "Tedarikci")
                        .WithMany("StokGirisleri")
                        .HasForeignKey("TedarikciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Oyuncak");

                    b.Navigation("Tedarikci");
                });

            modelBuilder.Entity("Oyuncakci.Models.Kategori", b =>
                {
                    b.Navigation("Oyuncaklar");
                });

            modelBuilder.Entity("Oyuncakci.Models.Musteri", b =>
                {
                    b.Navigation("Siparisler");
                });

            modelBuilder.Entity("Oyuncakci.Models.Rol", b =>
                {
                    b.Navigation("Calisanlar");
                });

            modelBuilder.Entity("Oyuncakci.Models.Siparis", b =>
                {
                    b.Navigation("GecmisSiparisler");

                    b.Navigation("Odemeler");

                    b.Navigation("SiparisDetaylari");
                });

            modelBuilder.Entity("Oyuncakci.Models.Tedarikci", b =>
                {
                    b.Navigation("StokGirisleri");
                });
#pragma warning restore 612, 618
        }
    }
}
