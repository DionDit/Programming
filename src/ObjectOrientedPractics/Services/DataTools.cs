using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Делегат для методов фильтрации товаров.
    /// </summary>
    public delegate bool ItemFilterDelegate(Item item);

    /// <summary>
    /// Делегат для методов сортировки товаров.
    /// </summary>
    public delegate List<Item> ItemSortDelegate(List<Item> items);

    /// <summary>
    /// Сервисный класс для работы с данными.
    /// </summary>
    public class DataTools
    {
        /// <summary>
        /// Фильтрует список товаров по заданному критерию.
        /// </summary>
        public static List<Item> FilterItems(List<Item> items, ItemFilterDelegate filter)
        {
            if (items == null)
            {
                return new List<Item>();
            }

            var filteredItems = new List<Item>();

            foreach (var item in items)
            {
                if (item != null && filter(item))
                {
                    filteredItems.Add(item);
                }
            }

            return filteredItems;
        }

        /// <summary>
        /// Критерий фильтрации товар стоимостью выше 5000.
        /// </summary>
        public static bool CostAbove5000Filter(Item item) => item.Cost > 5000;

        /// <summary>
        /// Критерий фильтрации где товар относится к указанной категории.
        /// </summary>
        public static ItemFilterDelegate CreateCategoryFilter(Category category) => item => item.Category == category;

        /// <summary>
        /// Критерий фильтрации где товар с положительной стоимостью.
        /// </summary>
        public static bool PositiveCostFilter(Item item) => item.Cost > 0;

        /// <summary>
        /// Сортирует список товаров по заданному критерию.
        /// </summary>
        /// <param name="items">Исходный список товаров.</param>
        /// <param name="sorter">Делегат сортировки товаров.</param>
        /// <returns>Новый отсортированный список товаров.</returns>
        public static List<Item> SortItems(List<Item> items, ItemSortDelegate sorter)
        {
            if (items != null)
            {
                return sorter(items);
            }
            else
            {
                return new List<Item>();
            }
        }

        /// <summary>
        /// Сортирует товары по имени в алфавитном порядке.
        /// </summary>
        public static List<Item> SortByName(List<Item> items)
        {
            var sortedItems = new List<Item>(items);

            if (items != null)
            {
                for (int i = 0; i < sortedItems.Count - 1; i++)
                {
                    for (int j = 0; j < sortedItems.Count - i - 1; j++)
                    {
                        if (string.Compare(sortedItems[j].Name, sortedItems[j + 1].Name, StringComparison.OrdinalIgnoreCase) > 0)
                        {
                            var temp = sortedItems[j];
                            sortedItems[j] = sortedItems[j + 1];
                            sortedItems[j + 1] = temp;
                        }
                    }
                }
            }
            return sortedItems;
        }

        /// <summary>
        /// Сортирует товары по возрастанию стоимости.
        /// </summary>
        public static List<Item> SortByCostAscending(List<Item> items)
        {
            var sortedItems = new List<Item>(items);

            if (items != null)
            {
                for (int i = 0; i < sortedItems.Count - 1; i++)
                {
                    for (int j = 0; j < sortedItems.Count - i - 1; j++)
                    {
                        if (sortedItems[j].Cost > sortedItems[j + 1].Cost)
                        {
                            var temp = sortedItems[j];
                            sortedItems[j] = sortedItems[j + 1];
                            sortedItems[j + 1] = temp;
                        }
                    }
                }
            }
            return sortedItems;
        }

        /// <summary>
        /// Сортирует товары по убыванию стоимости.
        /// </summary>
        public static List<Item> SortByCostDescending(List<Item> items)
        {
            var sortedItems = new List<Item>(items);

            if (items != null)
            {
                for (int i = 0; i < sortedItems.Count - 1; i++)
                {
                    for (int j = 0; j < sortedItems.Count - i - 1; j++)
                    {
                        if (sortedItems[j].Cost < sortedItems[j + 1].Cost)
                        {
                            var temp = sortedItems[j];
                            sortedItems[j] = sortedItems[j + 1];
                            sortedItems[j + 1] = temp;
                        }
                    }
                }
            }
            return sortedItems;
        }

        /// <summary>
        /// Создает делегат сортировки по имени.
        /// </summary>
        public static ItemSortDelegate CreateNameSorter() => SortByName;

        /// <summary>
        /// Создает делегат сортировки по возрастанию стоимости.
        /// </summary>
        public static ItemSortDelegate CreateCostAscendingSorter() => SortByCostAscending;

        /// <summary>
        /// Создает делегат сортировки по убыванию стоимости.
        /// </summary>
        public static ItemSortDelegate CreateCostDescendingSorter() => SortByCostDescending;
    }
}