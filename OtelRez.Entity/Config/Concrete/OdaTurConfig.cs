﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OtelRez.Entity.Config.Abstract;
using OtelRez.Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRez.Entity.Config.Concrete
{
    public class OdaTurConfig :BaseConfig<OdaTur>
    {
        public override void Configure(EntityTypeBuilder<OdaTur> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.TurAdi).HasMaxLength(50);
            builder.HasIndex(p => p.TurAdi).IsUnique();
            builder.Property(p => p.TurDetay).HasMaxLength(500);
            builder.Property(p => p.TurAdi).IsRequired();
            builder.Property(p => p.TurDetay).IsRequired();
            builder.Property(p => p.Kapasite).IsRequired();
            builder.Property(p => p.Fiyat).IsRequired();
            builder.Property(p => p.PhotoPath).IsRequired();
            builder.Property(p => p.Balkon).IsRequired();
            builder.Property(p => p.WiFi).IsRequired();
            builder.Property(p => p.Jakuzi).IsRequired();
            builder.Property(p => p.OdaServisi).IsRequired();
            builder.Property(p => p.Minibar).IsRequired();

            builder.HasData(new OdaTur() { Id = 1, TurAdi = "Suit Room", TurDetay = "Tek yataklı oda", Kapasite = 1, Fiyat = 1500, PhotoPath = "/OtelTemp/assets/img/rooms/room1.jpg", Balkon = false, Jakuzi = false, Minibar = false });
            builder.HasData(new OdaTur() { Id = 2, TurAdi = "Twin Room", TurDetay = "İki yataklı oda", Kapasite = 2, Fiyat = 1600, PhotoPath = "/OtelTemp/assets/img/rooms/room2.jpg", Balkon = false, Jakuzi = false, Minibar = false });
            builder.HasData(new OdaTur() { Id = 3, TurAdi = "Double Room", TurDetay = "İki kişilik tek yatak", Kapasite = 2, Fiyat = 1700, PhotoPath = "/OtelTemp/assets/img/rooms/room3.jpg", Balkon = true, Jakuzi = false, Minibar = false });
            builder.HasData(new OdaTur() { Id = 4, TurAdi = "Triple Room", TurDetay = "Üç tek kişilik yatak", Kapasite = 3, Fiyat = 1800, PhotoPath = "/OtelTemp/assets/img/rooms/room4.jpg", Balkon = true, Jakuzi = false, Minibar = true });
            builder.HasData(new OdaTur() { Id = 5, TurAdi = "Family Room", TurDetay = "1 double yatak 1 tek kişilik yatak", Kapasite = 3, Fiyat = 1750, PhotoPath = "/OtelTemp/assets/img/rooms/room5.jpg", Balkon = true, Jakuzi = false, Minibar = true });
            builder.HasData(new OdaTur() { Id = 6, TurAdi = "King Room", TurDetay = "Double yatak", Kapasite = 2, Fiyat = 3000, PhotoPath = "/OtelTemp/assets/img/rooms/room6.jpg", Balkon = true, Jakuzi = true, Minibar = true });
        }
    }
}
