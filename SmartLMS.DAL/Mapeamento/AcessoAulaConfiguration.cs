﻿using SmartLMS.Dominio.Entidades;
using SmartLMS.Dominio.Entidades.Historico;
using System.Data.Entity.ModelConfiguration;

namespace SmartLMS.DAL.Mapeamento
{
    public class AcessoAulaConfiguration : EntityTypeConfiguration<AcessoAula>
    {
        public AcessoAulaConfiguration()
        {
           HasRequired(x => x.Usuario).WithMany(a => a.AcessosAula).WillCascadeOnDelete(true); ;
           HasRequired(x => x.Aula).WithMany(a => a.Acessos).WillCascadeOnDelete(true);
        }
    }
}