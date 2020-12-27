using rapChieuPhim.Data.Entities;
using rapChieuPhim.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace rapChieuPhim.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }
               );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                 new Category()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active
                 },
                new Category()
                {
                    Id = 3,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 3,
                    Status = Status.Active
                });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Phim Hay", LanguageId = "vi-VN", SeoAlias = "phim-hay", SeoDescription = "Phim Hay được nhiều người xem", SeoTitle = "Phim Hay được nhiều người xem" },
                  new CategoryTranslation() { Id = 2, CategoryId = 2, Name = "Phim Sắp Chiếu", LanguageId = "vi-VN", SeoAlias = "phim-sap-chieu", SeoDescription = "COMING SOON", SeoTitle = "COMING SOON" },
                  new CategoryTranslation() { Id = 3, CategoryId = 3, Name = "Phim Đang Chiếu", LanguageId = "vi-VN", SeoAlias = "phim-dang-chieu", SeoDescription = "PHIM ĐANG CHIẾU", SeoTitle = "PHIM ĐANG CHIẾU" }
                    );
            modelBuilder.Entity<Product>().HasData(
           new Product()
           {
               Id = 1,
               DateCreated = DateTime.Now,
               OriginalPrice = 100000,
               Price = 200000,
               Stock = 0,
               ViewCount = 0,
           });
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Toy Story 4",
                     LanguageId = "vi-VN",
                     SeoAlias = "toy-story-4",
                     SeoDescription = "Toy Story 4",
                     SeoTitle = "Toy Story 4",
                     Details = "Toy Story 4",
                     Description = "Toy Story 4"
                 },
                    new ProductTranslation()
                    {
                        Id = 2,
                        ProductId = 1,
                        Name = "Spider-Man: Into the Spider-Verse",
                        LanguageId = "vi-VN",
                        SeoAlias = "spider-man-into-verse",
                        SeoDescription = "Spider-Man: Into the Spider-Verse",
                        SeoTitle = "Spider-Man: Into the Spider-Verse",
                        Details = "Spider-Man: Into the Spider-Verse",
                        Description = "Spider-Man: Into the Spider-Verse"
                    });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );
            // any guid
            var roleId = new Guid("695025D4-E840-421E-AB3F-2FC2E240DA61");
            var adminId = new Guid("5EDFCA40-C950-4820-883F-310BD37EDB54");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "chien",
                NormalizedUserName = "chien",
                Email = "chien1sttttt@gmail.com",
                NormalizedEmail = "chien1sttttt@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456Chien$"),
                SecurityStamp = string.Empty,
                FirstName = "Chien",
                LastName = "Van",
                Dob = new DateTime(2020, 12, 28)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

            modelBuilder.Entity<Slide>().HasData(
              new Slide() { Id = 1, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 1, Url = "#", Image = "/themes/images/carousel/1.png", Status = Status.Active },
              new Slide() { Id = 2, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 2, Url = "#", Image = "/themes/images/carousel/2.png", Status = Status.Active },
              new Slide() { Id = 3, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 3, Url = "#", Image = "/themes/images/carousel/3.png", Status = Status.Active },
              new Slide() { Id = 4, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 4, Url = "#", Image = "/themes/images/carousel/4.png", Status = Status.Active },
              new Slide() { Id = 5, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 5, Url = "#", Image = "/themes/images/carousel/5.png", Status = Status.Active },
              new Slide() { Id = 6, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 6, Url = "#", Image = "/themes/images/carousel/6.png", Status = Status.Active }
              );
        }
    }
}