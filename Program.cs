﻿using System;
using System.Text.Json;
using DominandoEFCore.Domain;
using EFcore.Domain;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace DominandoEFCore
{
    class Program
    {
        static void Main(string[] args)
        {

        }


        {
            using var db = new ApplicationContext();
        db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            var departamento = new Departamento { Descricao = "Departamento Teste" };
    }
}
}
