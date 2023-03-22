﻿using Microsoft.EntityFrameworkCore;
using MvcSeguridadDoctores.Models;

namespace MvcSeguridadDoctores.Data
{
    public class HospitalContext: DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options)
            : base(options) { }
        public DbSet<Enfermo> Enfermos { get; set; }
        public DbSet<Doctor> Doctores { get; set; }
    }
}
