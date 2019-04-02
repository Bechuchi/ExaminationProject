using Examensarbete.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examensarbete.Data.Identity
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Content> Content { get; set; }
        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<Facts> Facts { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<LanguageContent> LanguageContent { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Topic> Topic { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.HasOne(d => d.HeaderContent)
                    .WithMany(p => p.Exam)
                    .HasForeignKey(d => d.HeaderContentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Exam_Content");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.Exam)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Exam_Topic");
            });

            modelBuilder.Entity<Facts>(entity =>
            {
                entity.HasOne(d => d.HeaderContent)
                    .WithMany(p => p.Facts)
                    .HasForeignKey(d => d.HeaderContentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Facts_Content");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.Facts)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Facts_Topic");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LanguageContent>(entity =>
            {
                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.ContentId).HasColumnName("Content_Id");

                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.ContentNavigation)
                    .WithMany(p => p.LanguageContent)
                    .HasForeignKey(d => d.ContentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LanguageContent_Content");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Question_Exam");

                entity.HasOne(d => d.HeaderContent)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.HeaderContentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Question_Content");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.Property(e => e.ContentId).HasColumnName("Content_Id");

                entity.Property(e => e.NameContentId).HasColumnName("NameContent_Id");

                entity.HasOne(d => d.NameContent)
                    .WithMany(p => p.Topic)
                    .HasForeignKey(d => d.NameContentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Topic_Content");
            });
        }


    }
}
