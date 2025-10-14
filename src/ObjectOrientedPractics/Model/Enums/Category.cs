using System.ComponentModel;

namespace ObjectOrientedPractics.Model.Enums
{
    /// <summary>
    /// Категории товаров.
    /// </summary>
    public enum Category
    {
        /// <summary>
        /// Мобильные устройства и телефоны.
        /// </summary>
        MOBILE_DEVICES,

        /// <summary>
        /// Компьютеры и ноутбуки.
        /// </summary>
        COMPUTERS,

        /// <summary>
        /// Телевизоры и видео техника.
        /// </summary>
        TV_VIDEO,

        /// <summary>
        /// Бытовая техника для дома.
        /// </summary>
        HOME_APPLIANCES,

        /// <summary>
        /// Кухонная техника и приборы.
        /// </summary>
        KITCHEN_APPLIANCES,

        /// <summary>
        /// Спортивные товары и инвентарь.
        /// </summary>
        SPORTS_EQUIPMENT,

        /// <summary>
        /// Товары для красоты и здоровья.
        /// </summary>
        BEAUTY_HEALTH,

        /// <summary>
        /// Детские товары и игрушки.
        /// </summary>
        KIDS_TOYS,

        /// <summary>
        /// Автотовары и аксессуары.
        /// </summary>
        AUTO_GOODS,

        /// <summary>
        /// Инструменты и оборудование.
        /// </summary>
        TOOLS_EQUIPMENT
    }


    /// <summary>
    /// Расширение перечисления категорий.
    /// </summary>
    public static class CategoryExtensions
    {
        /// <summary>
        /// Преобразование перечисления в текст.
        /// </summary>
        /// <param name="category">Категория.</param>
        /// <returns></returns>
        public static string GetDisplayName(this Category category)
        {
            return category switch
            {
                Category.MOBILE_DEVICES => "Мобильные устройства и телефоны",
                Category.COMPUTERS => "Компьютеры и ноутбуки",
                Category.TV_VIDEO => "Телевизоры и видео техника",
                Category.HOME_APPLIANCES => "Бытовая техника для дома",
                Category.KITCHEN_APPLIANCES => "Кухонная техника и приборы",
                Category.SPORTS_EQUIPMENT => "Спортивные товары и инвентарь",
                Category.BEAUTY_HEALTH => "Товары для красоты и здоровья",
                Category.KIDS_TOYS => "Детские товары и игрушки",
                Category.AUTO_GOODS => "Автотовары и аксессуары",
                Category.TOOLS_EQUIPMENT => "Инструменты и оборудование",
                _ => category.ToString()
            };
        }

        /// <summary>
        /// Преобразование перечисления в текст.
        /// </summary>
        /// <param name="orderStatus">Статус заказа.</param>
        /// <returns></returns>
        public static string GetDisplayName(this OrderStatus orderStatus)
        {
            return orderStatus switch
            {
                OrderStatus.New => "Новый заказ",
                OrderStatus.Processing => "Обрабатывается",
                OrderStatus.Assembly => "Собирается на складе",
                OrderStatus.Sent => "Отправлен",
                OrderStatus.Delivered => "Доставлен",
                OrderStatus.Returned => "Возврат",
                OrderStatus.Abandoned => "Отменен (со стороны магазина)",
                _ => orderStatus.ToString()
            };
        }
    }
}