using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace PizzaKing.Models;

// PizzaKing.Models.AppDbContext
public class AppDbContext : IdentityDbContext<IdentityUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.ConfigureWarnings(w => 
    //         w.Ignore(RelationalEventId.PendingModelChangesWarning)
    //     );
    // }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Pizza> pizzaList =
		[
			new ("香腸披薩", "全香腸") { Id = 1, Price = 12, LongDescription = "全是香腸", ImageUrl="/images/毛细.png"},
			new ("什錦披薩", "全都有") { IsInStock=true, Id = 2, Price = 10, LongDescription = "蔬菜什錦還有大魚大肉", ImageUrl="/images/细.png"},
			new ("起司披薩", "濃濃的起司起司") { IsInStock=true, Id = 3, Price = 11, LongDescription = "可以拉絲的起司披薩", ImageUrl="/images/三细.png"},
			new ("夏威夷披薩", "有鳳梨") { Id = 4,Price = 10, LongDescription = "義大利人的惡夢", ImageUrl="/images/二细.png"},
			new ("小龍蝦披薩", "辣小龍蝦口味") { Id = 5,Price = 11, LongDescription = "吃貨最愛", ImageUrl="/images/二柱子.png"},
			new ("鹹蛋黃蝦仁披薩", "啥") { IsInStock=true, Id = 6,Price = 12, LongDescription = "亂掰", ImageUrl="/images/韭叶子.png"},
			new ("川式臘味披薩", "啥啥") { IsInStock=true, Id = 7,Price = 11, LongDescription = "亂掰", ImageUrl="/images/薄宽.png"},
			new ("螺獅粉披薩", "臭臭的披薩") { IsInStock=true, Id = 8,Price = 10, LongDescription = "碳水爆炸", ImageUrl="/images/大宽.png"},
			new ("正宗義大利披薩", "番茄") { Id = 9,Price = 15, LongDescription = "可能也不太正宗", ImageUrl="/images/荞麦棱子.png"},
			new ("好吃的披薩", "從必勝客打包來的") { Id = 10,Price = 15, LongDescription = "好吃", ImageUrl="/images/一窝丝.png"}
		];


        List<Feedback> feedbackList =
        [
            new() { Id = 1, Name = "阿萊克斯", Email = "noname1@hotmail.com", Comments = "真不錯", CreateTimeUTC = DateTime.UtcNow},
			new() { Id = 2, Name = "萊克斯", Email = "noname2@hotmail.com", Comments = "好吃", CreateTimeUTC = DateTime.UtcNow},
			new() { Id = 3, Name = "克斯", Email = "noname3@hotmail.com", Comments = "亂七八糟", CreateTimeUTC = DateTime.UtcNow},
			new() { Id = 4, Name = "克斯", Email = "noname4@hotmail.com", Comments = "有嚼進", CreateTimeUTC = DateTime.UtcNow},
		];

        modelBuilder.Entity<Pizza>().HasData(pizzaList);
        modelBuilder.Entity<Feedback>().HasData(feedbackList);

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Pizza> Pizzas {get;set;}

    public DbSet<Feedback> Feedbacks {get;set;}

}