using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BlogApp.Entity;
using Microsoft.AspNetCore.Components.Web;


namespace BlogApp.Data.Concrete.efCore
{
    public static class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();

            if (context != null)
            {
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }

                if (!context.Tags.Any())
                {
                    context.Tags.AddRange(
                        new Tag { Text = "web programlama", Url = "web-proglamlama", Color = TagColors.warning },
                        new Tag { Text = "backend", Url = "Backend", Color = TagColors.warning },
                        new Tag { Text = "frontend", Url = "frontend", Color = TagColors.danger },
                        new Tag { Text = "fullstack", Url = "fullstack", Color = TagColors.success },
                        new Tag { Text = "Php", Url = "php", Color = TagColors.primary }

                    );
                    context.SaveChanges();
                }

                if (!context.Users.Any())
                {
                    context.Users.AddRange(
                        new User { UserName = "aliemirkoca", Name = "Ali Emir", Email = "aliemirkoca@gmail.com", Password = "12345", Image = "p1.jpg" },
                        new User { UserName = "musab2025", Name = "Musab Yağız", Email = "123@info.com", Password = "musab", Image = "p1.jpg" }
                    );
                    context.SaveChanges();
                }

                if (!context.Posts.Any())
                {
                    context.Posts.AddRange(
                        new Post
                        {
                            Title = "asp.net core",
                            Content = "asp.net core dersleri",
                            Descrition = "açıklama",
                            Url = "aspnet-core",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-10),
                            Tags = context.Tags.Take(3).ToList(),
                            Image = "1.jpg",
                            UserId = 1,
                            Comments = new List<Comment>{
                                new Comment  {Text = "güzel", PublishedOn = new DateTime(), UserId= 1},
                                new Comment {Text = "fena değil", PublishedOn= new DateTime(),UserId=2 }}
                        },

                        new Post
                        {
                            Title = "Qai",
                            Content = "Qai",
                            Descrition = "açıklama",
                            Url = "ai-ders",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-20),
                            Tags = context.Tags.Take(2).ToList(),
                            Image = "2.jpg",
                            UserId = 1
                        },

                        new Post
                        {
                            Title = "valde",
                            Content = "valde dersleri",
                            Descrition = "açıklama",
                            Url = "valde-ders",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-30),
                            Tags = context.Tags.Take(4).ToList(),
                            Image = "3.jpg",
                            UserId = 2
                        },

                        new Post
                        {
                            Title = "deneme",
                            Content = "deneme",
                            Descrition = "açıklama",
                            Url = "deneme-ders",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-40),
                            Tags = context.Tags.Take(4).ToList(),
                            Image = "3.jpg",
                            UserId = 2
                        }




                    );

                    context.SaveChanges();
                }
            }
        }
    }
}

