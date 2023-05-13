using System.Collections.Immutable;
using IconEtic.Business.ComponentHandler;
using IconEtic.Business.ControllerHandler;
using IconEtic.Business.Helpers;
using IconEtic.Business.Services;
using IconEtic.Data.Abstract;
using IconEtic.Data.Concrete;

namespace IconEtic.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IUserDal, UserDal>();
            builder.Services.AddScoped<ICategoryDal, CategoryDal>();
            builder.Services.AddScoped<ILowerCategoryDal, LowerCategoryDal>();
            builder.Services.AddScoped<ISliderDal, SliderDal>();
            builder.Services.AddScoped<IProductDal, ProductDal>();
            builder.Services.AddScoped<IProductCategoryDal, ProductCategoryDal>();
            builder.Services.AddScoped<IProductImageDal, ProductImageDal>();
            builder.Services.AddScoped<IBasketDal, BasketDal>();
            builder.Services.AddScoped<IBasketProductDal, BasketProductDal>();
         


            builder.Services.AddScoped<ILoginService, LoginService>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<ILowerCategoryService, LowerCategoryService>();
            builder.Services.AddScoped<ISliderService, SliderService>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IProductCategoryService, ProductCategoryService>();
            builder.Services.AddScoped<IProductImageService, ProductImageService>();
            builder.Services.AddScoped<IBasketService, BasketService>();
            builder.Services.AddScoped<IBasketProductService, BasketProductService>();

         


            builder.Services.AddScoped<ICookieHelper, CookieHelper>();

            builder.Services.AddScoped<IAuthenticationControllerHandler, AuthenticationControllerHandler>();
            builder.Services.AddScoped<IHeaderTopComponentHandler, HeaderTopComponentHandler>();
            builder.Services.AddScoped<ILeftMenuComponentHandler, LeftMenuComponentHandler>();
            builder.Services.AddScoped<ILowerMenuComponentHandler, LowerMenuComponentHandler>();
            builder.Services.AddScoped<IBannerStyleTwoComponentHandler, BannerStyleTwoComponentHandler>();
            builder.Services.AddScoped<ICollectionSectionComponentHandler, CollectionSectionComponentHandler>();
            builder.Services.AddScoped<IShopSectionComponentHandler, ShopSectionComponentHandler>();
            builder.Services.AddScoped<IProductControllerHandler, ProductControllerHandler>();
            builder.Services.AddScoped<IApiControllerHandler, ApiControllerHandler>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.MapControllerRoute(
                name: "Register",
                pattern: "/login/",
                defaults: new { controller = "Authentication", action = "Index" });

            app.MapControllerRoute(
                name: "Exit",
                pattern: "/exit/",
                defaults: new { controller = "Authentication", action = "Exit" }); ;

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "ProductDetail",
                pattern: "/urun/{name}",
                defaults: new { controller = "Product", action = "Index" }); ;


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}