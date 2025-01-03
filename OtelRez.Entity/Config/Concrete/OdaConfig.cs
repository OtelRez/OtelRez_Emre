﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OtelRez.Entity.Config.Abstract;
using OtelRez.Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRez.Entity.Config.Concrete
{
    public class OdaConfig : BaseConfig<Oda>
    {
        public override void Configure(EntityTypeBuilder<Oda> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.OdaNumarasi).HasMaxLength(3);
            builder.HasIndex(p => p.OdaNumarasi).IsUnique();
            builder.Property(p => p.OdaNumarasi).IsRequired();

            builder.HasOne(p => p.OdaTur)
                .WithMany(p => p.Odalar)
                .HasForeignKey(p => p.OdaTurId);

            builder.HasData(new Oda() { Id = 1, OdaTurId = 1, OdaNumarasi = "101" });
            builder.HasData(new Oda() { Id = 2, OdaTurId = 1, OdaNumarasi = "102" });
            builder.HasData(new Oda() { Id = 3, OdaTurId = 4, OdaNumarasi = "103" });
            builder.HasData(new Oda() { Id = 4, OdaTurId = 4, OdaNumarasi = "104" });
            builder.HasData(new Oda() { Id = 5, OdaTurId = 4, OdaNumarasi = "105" });
           
            builder.HasData(new Oda() { Id = 6, OdaTurId = 2, OdaNumarasi = "201" });
            builder.HasData(new Oda() { Id = 7, OdaTurId = 2, OdaNumarasi = "202" });
            builder.HasData(new Oda() { Id = 8, OdaTurId = 3, OdaNumarasi = "203" });
            builder.HasData(new Oda() { Id = 9, OdaTurId = 3, OdaNumarasi = "204" });
            builder.HasData(new Oda() { Id = 10, OdaTurId = 3, OdaNumarasi = "205" });

            builder.HasData(new Oda() { Id = 11, OdaTurId = 1, OdaNumarasi = "301" });
            builder.HasData(new Oda() { Id = 12, OdaTurId = 2, OdaNumarasi = "302" });
            builder.HasData(new Oda() { Id = 13, OdaTurId = 3, OdaNumarasi = "303" });
            builder.HasData(new Oda() { Id = 14, OdaTurId = 5, OdaNumarasi = "304" });
            builder.HasData(new Oda() { Id = 15, OdaTurId = 5, OdaNumarasi = "305" });

            builder.HasData(new Oda() { Id = 16, OdaTurId = 6, OdaNumarasi = "401" });
            builder.HasData(new Oda() { Id = 17, OdaTurId = 6, OdaNumarasi = "405" });
        }
    }
}

