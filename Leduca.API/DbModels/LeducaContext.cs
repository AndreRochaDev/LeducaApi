using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Leduca.API.DbModels;

public partial class LeducaContext : DbContext
{
    public LeducaContext(DbContextOptions<LeducaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookLevel> BookLevels { get; set; }

    public virtual DbSet<BookQuiz> BookQuizzes { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<QuestionAnswer> QuestionAnswers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAward> UserAwards { get; set; }

    public virtual DbSet<UserAwardType> UserAwardTypes { get; set; }

    public virtual DbSet<UserBookQuiz> UserBookQuizzes { get; set; }

    public virtual DbSet<UserBookQuizAnswer> UserBookQuizAnswers { get; set; }

    public virtual DbSet<UserBookRecommendation> UserBookRecommendations { get; set; }

    public virtual DbSet<UserProfile> UserProfiles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Book__3214EC072ABF5723");

            entity.ToTable("Book");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Author).HasMaxLength(255);
            entity.Property(e => e.Isbn).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);

            entity.HasOne(d => d.BookLevel).WithMany(p => p.Books)
                .HasForeignKey(d => d.BookLevelId)
                .HasConstraintName("FK__Book__BookLevelI__403A8C7D");
        });

        modelBuilder.Entity<BookLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BookLeve__3214EC079D5D5DC2");

            entity.ToTable("BookLevel");

            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<BookQuiz>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BookQuiz__3214EC0734147E40");

            entity.ToTable("BookQuiz");

            entity.HasOne(d => d.Book).WithMany(p => p.BookQuizzes)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("FK__BookQuiz__BookId__47DBAE45");

            entity.HasOne(d => d.Question).WithMany(p => p.BookQuizzes)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK__BookQuiz__Questi__48CFD27E");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Message__3214EC07425A9D23");

            entity.ToTable("Message");

            entity.Property(e => e.Message1).HasColumnName("Message");

            entity.HasOne(d => d.FromUser).WithMany(p => p.MessageFromUsers)
                .HasForeignKey(d => d.FromUserId)
                .HasConstraintName("FK__Message__FromUse__619B8048");

            entity.HasOne(d => d.ToUser).WithMany(p => p.MessageToUsers)
                .HasForeignKey(d => d.ToUserId)
                .HasConstraintName("FK__Message__ToUserI__628FA481");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Question__3214EC07EC327A73");

            entity.ToTable("Question");
        });

        modelBuilder.Entity<QuestionAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Question__3214EC071EFF5A4D");

            entity.ToTable("QuestionAnswer");

            entity.HasOne(d => d.Question).WithMany(p => p.QuestionAnswers)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK__QuestionA__Quest__44FF419A");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3214EC07A4E21A7F");

            entity.ToTable("User");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);

            entity.HasOne(d => d.UserProfile).WithMany(p => p.Users)
                .HasForeignKey(d => d.UserProfileId)
                .HasConstraintName("FK__User__UserProfil__3A81B327");
        });

        modelBuilder.Entity<UserAward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserAwar__3214EC071FAC67E2");

            entity.ToTable("UserAward");

            entity.HasOne(d => d.UserAwardType).WithMany(p => p.UserAwards)
                .HasForeignKey(d => d.UserAwardTypeId)
                .HasConstraintName("FK__UserAward__UserA__59FA5E80");

            entity.HasOne(d => d.User).WithMany(p => p.UserAwards)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__UserAward__UserI__59063A47");
        });

        modelBuilder.Entity<UserAwardType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserAwar__3214EC0780684995");

            entity.ToTable("UserAwardType");

            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<UserBookQuiz>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserBook__3214EC071E75E35D");

            entity.ToTable("UserBookQuiz");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

            entity.HasOne(d => d.Book).WithMany(p => p.UserBookQuizzes)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("FK__UserBookQ__BookI__4D94879B");

            entity.HasOne(d => d.BookQuizNavigation).WithMany(p => p.UserBookQuizzes)
                .HasForeignKey(d => d.BookQuiz)
                .HasConstraintName("FK__UserBookQ__BookQ__4E88ABD4");

            entity.HasOne(d => d.User).WithMany(p => p.UserBookQuizzes)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__UserBookQ__UserI__4CA06362");
        });

        modelBuilder.Entity<UserBookQuizAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserBook__3214EC07D3EC6064");

            entity.ToTable("UserBookQuizAnswer");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

            entity.HasOne(d => d.QuestionAnswer).WithMany(p => p.UserBookQuizAnswers)
                .HasForeignKey(d => d.QuestionAnswerId)
                .HasConstraintName("FK__UserBookQ__Quest__5441852A");

            entity.HasOne(d => d.Question).WithMany(p => p.UserBookQuizAnswers)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK__UserBookQ__Quest__534D60F1");

            entity.HasOne(d => d.UserBookQuiz).WithMany(p => p.UserBookQuizAnswers)
                .HasForeignKey(d => d.UserBookQuizId)
                .HasConstraintName("FK__UserBookQ__UserB__52593CB8");
        });

        modelBuilder.Entity<UserBookRecommendation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserBook__3214EC07239E6D63");

            entity.ToTable("UserBookRecommendation");

            entity.HasOne(d => d.Book).WithMany(p => p.UserBookRecommendations)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("FK__UserBookR__BookI__5DCAEF64");

            entity.HasOne(d => d.RecommendedByUser).WithMany(p => p.UserBookRecommendationRecommendedByUsers)
                .HasForeignKey(d => d.RecommendedByUserId)
                .HasConstraintName("FK__UserBookR__Recom__5EBF139D");

            entity.HasOne(d => d.User).WithMany(p => p.UserBookRecommendationUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__UserBookR__UserI__5CD6CB2B");
        });

        modelBuilder.Entity<UserProfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserProf__3214EC07A540F74A");

            entity.ToTable("UserProfile");

            entity.Property(e => e.Name).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
