﻿using eAppointmentServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAppointmentServer.Infrastructure.Configurations
{
	internal sealed class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
	{
		public void Configure(EntityTypeBuilder<Doctor> builder)
		{
			builder.Property(p => p.FirstName).HasColumnType("varchar(50)");
			builder.Property(p => p.LastName).HasColumnType("varchar(50)");
			builder.Property(p => p.Department)
				.HasConversion(v => v.Value, v => Domain.Enums.DepartmentEnum.FromValue(v))
				.HasColumnName("Department");
			//builder.HasIndex(x=>new {x.FirstName,x.LastName}).IsUnique(); ad-soyad kısmını uniq bir değer olarak atama

		}
	}
}
