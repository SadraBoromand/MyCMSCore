using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Context
{
    public class MyCMSContext : DbContext
    {
        public MyCMSContext(DbContextOptions<MyCMSContext> options) : base(options)
        {

        }

        public DbSet<Page> Pages { get; set; }
        public DbSet<PageComment> PageComments { get; set; }
        public DbSet<PageGroup> PageGroups { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    UserId = 1,
                    Email = "sadrabroo@gmail.com",
                    Password = "123",
                    Role = 1
                }
                );

            modelBuilder.Entity<PageGroup>().HasData(
                new PageGroup()
                {
                    GroupId = 1,
                    GroupTitle = "اقتصادی"
                }
                );

            modelBuilder.Entity<Page>().HasData(
                new Page()
                {
                    PageId = 1,
                    Title = "عنوان خبر",
                    GroupId = 1,
                    CreateDate = DateTime.Now,
                    ShortDescription = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است ...",
                    ShowInSlider = true,
                    Visit = 0,
                    Image = "Default.png",
                    Text = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیستری را برای طراحان رایانه ای و فرهنگ پیشرو در زبان فارسی ایجاد کرد. در این صورت می توان امید داشت که تمام و دشواری موجود در ارائه راهکارها و شرایط سخت تایپ به پایان رسد وزمان مورد نیاز شامل حروفچینی دستاوردهای اصلی و جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد.",
                    Tags = "خبر-خبر اقتصادی-خبر جدید-خبر داغ"
                }
                );

        }
    }
}
