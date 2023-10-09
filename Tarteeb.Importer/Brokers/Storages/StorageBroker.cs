﻿//===========================
// Copyright (c) Tarteeb LLC
// Powering True Leadership
//===========================

using System;
using System.Linq;
using System.Threading.Tasks;
using EFxceptions;
using Microsoft.EntityFrameworkCore;
using Tarteeb.Importer.Models.Clients;

namespace Tarteeb.Importer.Brokers.Storages
{
    internal class StorageBroker : EFxceptionsContext
    {
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source = ..\..\..\Tarteeb.db";
            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
