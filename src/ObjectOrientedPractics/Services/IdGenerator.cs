namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Генератор идентификаторов.
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// Получение следующего идентификатора.
        /// </summary>
        /// <returns>Id</returns>
        public static int GetNextId()
        {
            int maxId = 0;

            if (AppData.Items != null && AppData.Items.Count > 0)
            {
                maxId = Math.Max(maxId, AppData.Items.Max(x => x.Id));
            }

            if (AppData.Customers != null && AppData.Customers.Count > 0)
            {
                maxId = Math.Max(maxId, AppData.Customers.Max(x => x.Id));
            }

            return ++maxId;
        }
    }
}