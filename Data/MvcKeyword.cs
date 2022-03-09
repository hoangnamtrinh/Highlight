#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Highlight.Models;

    public class MvcKeyword : DbContext
    {
        public MvcKeyword (DbContextOptions<MvcKeyword> options)
            : base(options)
        {
        }

        public DbSet<Highlight.Models.Keyword> Keyword { get; set; }
        public DbSet<Highlight.Models.Tag> Tags { get; set; }
    }
