using ECommerce.Models;

namespace ECommerce.Data
{
    public static class DbSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (context.Products.Any()) return;

            context.Products.AddRange(
                new Product
                {
                    Name = "Nike Air Max 90",
                    Price = 459.90m,
                    Stock = 25,
                    Description = "El icónico Air Max 90 con amortiguación visible Air-Sole. Diseño atemporal que combina estilo y comodidad para el día a día.",
                    ImagePath = "/images/airmax90.jpg"
                },
                new Product
                {
                    Name = "Adidas Ultraboost 22",
                    Price = 699.90m,
                    Stock = 18,
                    Description = "Zapatillas de running con tecnología BOOST para máxima energía y retorno. Malla Primeknit transpirable y suela Continental.",
                    ImagePath = "/images/ultraboost22.jpg"
                },
                new Product
                {
                    Name = "Nike Dunk Low Retro",
                    Price = 389.90m,
                    Stock = 30,
                    Description = "El clásico Dunk renacido. Diseño retro de baloncesto con cuero premium y colorways que no pasan de moda.",
                    ImagePath = "/images/dunklow.jpg"
                },
                new Product
                {
                    Name = "New Balance 550 White Green",
                    Price = 429.90m,
                    Stock = 22,
                    Description = "Retro running estilo vintage con cuero blanco y detalles en verde. Silueta cómoda y versátil para cualquier outfit.",
                    ImagePath = "/images/nb550.jpg"
                },
                new Product
                {
                    Name = "Jordan 1 Mid SE",
                    Price = 549.90m,
                    Stock = 15,
                    Description = "La silueta más icónica de Jordan Brand en versión Mid. Cuero de alta calidad con el logo Wings y suela de goma.",
                    ImagePath = "/images/jordan1mid.jpg"
                },
                new Product
                {
                    Name = "Puma Suede Classic XXI",
                    Price = 329.90m,
                    Stock = 35,
                    Description = "Un clásico atemporal del streetwear. Cuero gamuza premium con la franja lateral icónica y suela de goma duradera.",
                    ImagePath = "/images/pumasuede.jpg"
                },
                new Product
                {
                    Name = "Converse Chuck 70 High",
                    Price = 349.90m,
                    Stock = 40,
                    Description = "La versátil Chuck Taylor renovada con tecnología OrthoLite y canvas de mayor durabilidad. Estilo que nunca falla.",
                    ImagePath = "/images/chuck70.jpg"
                },
                new Product
                {
                    Name = "Asics Gel-Kayano 30",
                    Price = 729.90m,
                    Stock = 12,
                    Description = "Máxima estabilidad y amortiguación con tecnología GEL y FF BLAST+. Ideal para corredores que necesitan soporte.",
                    ImagePath = "/images/kayano30.jpg"
                },
                new Product
                {
                    Name = "Under Armour HOVR Phantom 3",
                    Price = 649.90m,
                    Stock = 16,
                    Description = "Zapatillas de running con tecnología UA HOVR que devuelve la energía en cada zancada. Malla de soporte y suela de goma duradera.",
                    ImagePath = "/images/hovrphantom3.jpg"
                },
                new Product
                {
                    Name = "Fila Disruptor 2 Premium",
                    Price = 399.90m,
                    Stock = 28,
                    Description = "El clásico chunky de los 90s regresado con fuerza. Suela platform extra alta con el logo Fila bordado y acolchado cómodo.",
                    ImagePath = "/images/disruptor2.jpg"
                },
                new Product
                {
                    Name = "Reebok Club C 85 Vintage",
                    Price = 379.90m,
                    Stock = 32,
                    Description = "Minimalismo y elegancia en cuero blanco premium. Plantilla OrthoLite y suela de goma con detalles vintage que enamoran.",
                    ImagePath = "/images/clubc85.jpg"
                },
                new Product
                {
                    Name = "Vans Old Skool Classic",
                    Price = 299.90m,
                    Stock = 45,
                    Description = "La silueta Vans original con la icónica franja lateral jazz stripe. Canvas y gamuza con suela waffle para máximo grip.",
                    ImagePath = "/images/oldskool.jpg"
                },
                new Product
                {
                    Name = "Adidas Superstar Foundation",
                    Price = 459.90m,
                    Stock = 20,
                    Description = "El ícono del calzado urbano desde 1969. Coraza de concha protectora, cuero liso y las 3 franjas clásicas que nunca fallan.",
                    ImagePath = "/images/superstar.jpg"
                },
                new Product
                {
                    Name = "Salomon XT-6 Advanced",
                    Price = 849.90m,
                    Stock = 10,
                    Description = "Trail running de alta gama con tecnología Advanced Chassis y suela Contagrip MA. Diseño futurista resistente al agua.",
                    ImagePath = "/images/xt6.jpg"
                }
            );

            context.SaveChanges();
        }
    }
}
